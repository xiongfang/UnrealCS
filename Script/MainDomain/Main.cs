using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;
using UnrealEngine;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace MainDomain
{
    public class Main
    {
        static Main Instance;

        bool withEidtor;
        string gameName;
        string pluginBaseDir;
        string engineAssembliesDir;
        string gameAssembliesDir;
        string shadowCopyDirectory;

        AppDomain gameDomain;
        System.IO.FileSystemWatcher fsw;

        public Main(string gameName, string pluginBaseDir, string engineAssembliesDir, string gameAssembliesDir, string shadowCopyDirectory, int withEidtor)
        {
            this.withEidtor = withEidtor != 0;
            this.gameName = gameName;
            this.pluginBaseDir = pluginBaseDir;
            this.engineAssembliesDir = engineAssembliesDir;
            this.gameAssembliesDir = gameAssembliesDir;
            this.shadowCopyDirectory = shadowCopyDirectory;

            if (this.withEidtor)
                CreateFileWatcher();
        }


        void CreateFileWatcher()
        {
            //开启文件监测服务
            fsw = new FileSystemWatcher(gameAssembliesDir);
            fsw.Filter = "*.dll";
            fsw.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.FileName;
            //fsw.Changed += Fsw_Changed;
            fsw.Created += Fsw_Created;
            //fsw.Deleted += Fsw_Deleted;
            fsw.Error += Fsw_Error;
            //fsw.Renamed += Fsw_Renamed;
            fsw.IncludeSubdirectories = false;
            fsw.InternalBufferSize = 10240;
            fsw.EnableRaisingEvents = true;

            UnrealEngine.UObject.LogInfo("启动文件热更监听 " + gameAssembliesDir + "Game.dll");

        }

        private void Fsw_Renamed(object sender, RenamedEventArgs e)
        {
            UnrealEngine.UObject.LogInfo("Fsw_Renamed:" + e.OldName + " NewName:" + e.Name);
        }

        private void Fsw_Error(object sender, ErrorEventArgs e)
        {
            UnrealEngine.UObject.LogInfo("Fsw_Error:" + e.ToString());
        }

        private void Fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            UnrealEngine.UObject.LogInfo("Fsw_Deleted:" + e.Name);
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            UnrealEngine.UObject.LogInfo("Fsw_Created:" + e.Name);
            NativeReload();
        }

        private void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            UnrealEngine.UObject.LogInfo("Fsw_Changed:" + e.Name);
            NativeReload();
        }


        public void OnCommand(string cmd)
        {
            switch (cmd)
            {
                case "OpenProject":
                    OpenProject();
                    break;
                case "AOT":
                    AOT();
                    break;
                default:
                    break;
            }
        }

        void CopyFolder(string Dest, string Src)
        {
            if (!(Dest.EndsWith("\\") || Dest.EndsWith("/")))
                Dest += "/";
            if (!(Src.EndsWith("\\") || Src.EndsWith("/")))
                Src += "/";
            if (!Directory.Exists(Dest))
                Directory.CreateDirectory(Dest);

            // 子文件夹
            foreach (string sub in Directory.GetDirectories(Src, "*", SearchOption.TopDirectoryOnly))
            {
                string name = Path.GetFileName(sub);
                CopyFolder(Path.Combine(Dest, name), Path.Combine(Src, name));
            }


            // 文件
            foreach (string file in Directory.GetFiles(Src, "*", SearchOption.TopDirectoryOnly))
            {
                string name = Path.GetFileName(file);
                File.Copy(Path.Combine(Src, name), Path.Combine(Dest, name), true);
            }
        }
        void OpenProject()
        {
            //检查脚本工程
            if (!Directory.Exists(Path.Combine(FPaths.GameDir(), "Project")))
            {
                //复制脚本模板到工程目录
                UObject.LogInfo("Copy script project template");
                string ProjectDir = Path.Combine(pluginBaseDir, "Project");
                CopyFolder(Path.Combine(FPaths.GameDir(), "Project"), ProjectDir);

                ////重命名静态库，否则打包会失败
                //string MonoHelperFilePathName = Path.Combine(FPaths.GamePluginsDir(), "Mono", "Binaries", "Win64", "UE4-MonoHelper.lib");
                //if(File.Exists(MonoHelperFilePathName))
                //{
                //    File.Move(MonoHelperFilePathName, Path.Combine(FPaths.GamePluginsDir(), "Mono", "Binaries", "Win64", gameName + "-MonoHelper.lib"));
                //}
                //else
                //{
                //    UObject.LogWarning("File Not Found:"+ MonoHelperFilePathName);
                //}
                //string MonoPluginFilePathName = Path.Combine(FPaths.GamePluginsDir(), "Mono", "Binaries", "Win64", "UE4-MonoPlugin.lib");
                //if (File.Exists(MonoPluginFilePathName))
                //{
                //    File.Move(MonoPluginFilePathName, Path.Combine(FPaths.GamePluginsDir(), "Mono", "Binaries", "Win64", gameName + "-MonoPlugin.lib"));
                //}
                //else
                //{
                //    UObject.LogWarning("File Not Found:" + MonoPluginFilePathName);
                //}
            }

            if (UGameplayStatics.GetPlatformName() == "Windows")
            {
                string InstallDir = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\devenv.exe",
                    null, "").ToString();
                if (string.IsNullOrEmpty(InstallDir))
                {
                    UObject.LogWarning("Can't find devenv.exe");
                    return;
                }
                Process.Start(InstallDir, Path.Combine(FPaths.GameDir(), "Project", "Script.sln"));
            }
            else
            {
                //无工具，显示项目位置
                UObject.LogWarning("C# script solution file located at " + Path.Combine(FPaths.GameDir(), "Project", "Script.sln"));
            }
        }


        List<string> aot_filename_list = null;

        void AOT()
        {
            UObject.LogInfo("AOT Start");

            aot_filename_list = new List<string>();
            aot_filename_list.Clear();

            string last_work_dir = System.Environment.CurrentDirectory;
            try
            {
                bool isWindows = UGameplayStatics.GetPlatformName() == "Windows";
                bool isMac = UGameplayStatics.GetPlatformName() == "Mac";

                if (!isWindows && !isMac)
                    return;

                //遍历目录，aot每个文件
                string MAC_AOT_MONO_PATH;
                if (isWindows)
                    MAC_AOT_MONO_PATH = Path.GetFullPath(Path.Combine(pluginBaseDir, "mono_aot", "aot_host_windows_target_armv7", "bin"));
                else
                    MAC_AOT_MONO_PATH = Path.GetFullPath(Path.Combine(pluginBaseDir, "mono_aot", "aot_host_mac_target_armv7", "bin"));

                string aot_target = "armv7";
                string mscorlib_path = Path.GetFullPath(Path.Combine(pluginBaseDir, "mono_aot", "pre_aot_files", aot_target));

                string ios_predefine_header_file_pathname = Path.GetFullPath(Path.Combine(pluginBaseDir, "Source", "MonoPlugin", "Private", "ios_predefine.h"));
                string ios_private_path = Path.GetFullPath(Path.Combine(pluginBaseDir, "Source", "MonoPlugin", "Private", "IOS"));

                string outpath = Path.GetFullPath(Path.Combine(pluginBaseDir, "AOT"));
                string temppath = Path.Combine(outpath, "Temp");

                if (Directory.Exists(outpath))
                    Directory.Delete(outpath, true);
                if (Directory.Exists(temppath))
                    Directory.Delete(temppath, true);

                Directory.CreateDirectory(outpath);
                Directory.CreateDirectory(temppath);


                //拷贝所有dll到temp文件夹
                {
                    List<string> dllPath = new List<string>();
                    dllPath.Add(engineAssembliesDir);
                    dllPath.Add(gameAssembliesDir);
                    dllPath.Add(Path.Combine(FPaths.GameDir(), "Content", "Scripts", "framework"));

                    foreach (var dir in dllPath)
                    {

                        string[] files = Directory.GetFiles(dir, "*.dll", SearchOption.AllDirectories);
                        foreach (var file in files)
                        {
                            string filename = Path.GetFileName(file);
                            string filepath = file.Substring(0, file.Length - filename.Length);
                            //跳过无效的UnrealEngine.dll
                            if (filename == "UnrealEngine.dll")
                            {

                                if ((aot_target == "armv7" || aot_target == "armv7s") && !filepath.Contains("Game_32bits"))
                                {
                                    continue;
                                }
                                else if (aot_target == "arm64" && !filepath.Contains("Game_64bits"))
                                {
                                    continue;
                                }
                            }
                            UObject.LogInfo("copy {0} to {1}", filename, outpath);
                            File.Copy(file, Path.Combine(temppath, filename), true);
                        }
                    }
                }


                //AOT所有目标temp文件夹的文件
                {
                    string[] files = Directory.GetFiles(temppath, "*.dll", SearchOption.AllDirectories);
                    foreach (var file in files)
                    {
                        string filename = Path.GetFileName(file);
                        string filepath = file.Substring(0, file.Length - filename.Length);

                        //跳过此文件
                        if (filename == "mscorlib.dll")
                        {
                            aot_filename_list.Add("mono_aot_module_mscorlib_info");
                            //copy mscorlib.dll.a
                            File.Copy(Path.Combine(mscorlib_path, "mscorlib.dll.a"), Path.Combine(outpath, "mscorlib.dll.a"));
                            //File.Copy(Path.Combine(mscorlib_path, "mscorlib.dll.s"), Path.Combine(ios_private_path, "mscorlib.dll.s"),true);
                            continue;
                        }

                        //AOT
                        {
                            System.Environment.CurrentDirectory = MAC_AOT_MONO_PATH;

                            Process proc = new System.Diagnostics.Process();
                            proc.StartInfo.WorkingDirectory = MAC_AOT_MONO_PATH;
                            if (isWindows)
                            {
                                proc.StartInfo.FileName = Path.Combine(MAC_AOT_MONO_PATH, "mono-sgen.exe");
                                proc.StartInfo.Arguments = string.Format(" --aot=full,asmonly,static \"{0}\"", file);
                            }
                            else
                            {
                                proc.StartInfo.FileName = "./armv7-apple-darwin-mono-sgen";
                                proc.StartInfo.Arguments = string.Format("--aot=full,asmonly,static,nrgctx-trampolines=8096,nimt-trampolines=8096,ntrampolines=4048 \"{0}\"", file);
                            }

                            proc.StartInfo.CreateNoWindow = true;
                            proc.StartInfo.UseShellExecute = false;
                            proc.StartInfo.RedirectStandardOutput = true;
                            proc.StartInfo.RedirectStandardError = true;
                            proc.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                            proc.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler);

                            UObject.LogInfo("aot {0}", proc.StartInfo.Arguments);
                            proc.Start();

                            proc.BeginOutputReadLine();
                            proc.BeginErrorReadLine();

                            proc.WaitForExit();
                            proc.Close();

                            //复制到Private/IOS目录
                            //File.Copy(file+".s", Path.Combine(ios_private_path, filename +".s"), true);
                        }

                        if (isMac)
                        {
                            //AS
                            {
                                Process proc = new System.Diagnostics.Process();
                                proc.StartInfo.WorkingDirectory = filepath;
                                //proc.StartInfo.FileName = "as";
                                //proc.StartInfo.Arguments = string.Format("-arch {2} -march=armv7-a -mno-thumb -miphoneos-version-min=7.0 -isysroot /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS.sdk -o {0}.o {1}.s", filename, filename, aot_target);
                                proc.StartInfo.FileName = "xcrun";
                                proc.StartInfo.Arguments = string.Format("-sdk iphoneos as -arch {2} -mno-thumb -miphoneos-version-min=7.0 -isysroot /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS.sdk -o {0}.o {1}.s", filename, filename, aot_target);

                                proc.StartInfo.CreateNoWindow = true;
                                proc.StartInfo.UseShellExecute = false;
                                proc.StartInfo.RedirectStandardOutput = true;
                                proc.StartInfo.RedirectStandardError = true;
                                proc.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                                proc.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler);

                                UObject.LogInfo("as {0}", proc.StartInfo.Arguments);
                                proc.Start();

                                proc.BeginOutputReadLine();
                                proc.BeginErrorReadLine();

                                proc.WaitForExit();
                                proc.Close();
                            }

                            //ar
                            {
                                Process proc = new System.Diagnostics.Process();
                                proc.StartInfo.WorkingDirectory = filepath;
                                //proc.StartInfo.FileName = "ar";
                                //proc.StartInfo.Arguments = string.Format("-r \"{0}.a\" {1}.o", Path.GetFullPath(Path.Combine(outpath, filename)), filename);

                                proc.StartInfo.FileName = "xcrun";
                                proc.StartInfo.Arguments = string.Format("-sdk iphoneos ar rcu \"{0}.a\" {1}.o", Path.GetFullPath(Path.Combine(outpath, filename)), filename);

                                proc.StartInfo.CreateNoWindow = true;
                                proc.StartInfo.UseShellExecute = false;
                                proc.StartInfo.RedirectStandardOutput = true;
                                proc.StartInfo.RedirectStandardError = true;
                                proc.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                                proc.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler);

                                UObject.LogInfo("ar {0}", proc.StartInfo.Arguments);
                                proc.Start();

                                proc.BeginOutputReadLine();
                                proc.BeginErrorReadLine();

                                proc.WaitForExit();
                                proc.Close();
                            }

                        }


                    }



                }

                //删除temp文件夹
                {
                    Directory.Delete(temppath, true);
                }

                //构建ios预定义头文件
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("extern \"C\"{");
                sb.AppendLine("\tvoid mono_aot_register_module(void* pt);");
                foreach (var filename in aot_filename_list)
                {
                    sb.AppendFormat("\textern void* {0};", filename);
                    sb.AppendLine();
                }
                sb.AppendLine("}");

                sb.AppendLine("void RegisterMonoModules(){");
                foreach (var filename in aot_filename_list)
                {
                    sb.AppendFormat("\tmono_aot_register_module({0});", filename);
                    sb.AppendLine();
                }
                sb.AppendLine("}");
                aot_filename_list.Clear();
                //写入文件
                File.WriteAllText(ios_predefine_header_file_pathname, sb.ToString(), System.Text.Encoding.UTF8);

            }
            catch (Exception e)
            {
                UObject.LogError(e.Message);
                UObject.LogError(e.StackTrace);
            }
            finally
            {
                System.Environment.CurrentDirectory = last_work_dir;
            }

        }

        private static void OutputHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            // Collect the sort command output.
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                Regex r = new Regex("mono_aot_module_[\\s\\S]*_info");

                Match m = r.Match(outLine.Data);
                if (m.Success)
                {
                    Instance.aot_filename_list.Add(m.ToString());
                }
                UObject.LogWarning(outLine.Data);
            }
        }
        private static void ErrorHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            // Collect the sort command output.
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                UObject.LogError(outLine.Data);
            }
        }

        void Start()
        {
            if(gameDomain==null)
            {
                var domaininfo = new AppDomainSetup();
                //domaininfo.ShadowCopyDirectories = gameAssembliesDir;// string.Join(System.IO.Path.PathSeparator.ToString(), engineAssembliesDir, gameAssembliesDir);
                //domaininfo.ShadowCopyFiles = "true";
                domaininfo.ApplicationName = gameName;
                domaininfo.DisallowApplicationBaseProbing = true;
                //domaininfo.CachePath = shadowCopyDirectory;
                gameDomain = AppDomain.CreateDomain("Game", AppDomain.CurrentDomain.Evidence, domaininfo);
                //gameDomain = AppDomain.CreateDomain("Game");
            }
        }

        void End()
        {
            if(gameDomain!=null)
            {
                //UnrealEngine.UObject.Log("Unload Game Domain");
                //AppDomain.Unload(gameDomain);
                gameDomain = null;
            }
        }

        void ClearAndRenameAssembly()
        {
            //查找最新的文件
            string[] files = Directory.GetFiles(gameAssembliesDir);
            string lastFileName = "";

           int max_number = -1;
            foreach (var file in files)
            {
                int startIndex = file.LastIndexOf('-');
                int endIndex = file.LastIndexOf('.');
                if (startIndex == -1 || endIndex == -1)
                {
                    continue;
                }

                string numStr = file.Substring(startIndex + 1, (endIndex - startIndex)-1);

                try
                {
                    int num = int.Parse(numStr);
                    if (max_number < num)
                    {
                        max_number = num;
                        lastFileName = file;
                    }
                        
                }
                catch(Exception e)
                {
                }
            }

            if (max_number >= 0)
            {
                //删除之前的文件
                foreach (var f in files)
                {
                    if (f != lastFileName)
                    {
                        UnrealEngine.UObject.LogInfo("DeleteFile " + f);
                        File.Delete(f);
                    }
                        
                }
                //UnrealEngine.UObject.Log("Move " + lastFileName);
                //File.Move(lastFileName, Path.Combine(gameAssembliesDir, "Game.dll"));
            }
        }

        public void HotReload()
        {
            if (withEidtor)
            {
                End();
                ClearAndRenameAssembly();
            }
            Start();
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void NativeReload();


        public static Main Initialize(string gameName, string pluginBaseDir, string engineAssembliesDir, string gameAssembliesDir,string shadowCopyDirectory,int withEidtor)
        {
            Instance = new Main(gameName, pluginBaseDir, engineAssembliesDir, gameAssembliesDir, shadowCopyDirectory,withEidtor);
            return Instance;
        }

        public static void Shutdown()
        {
            if(Instance!=null)
            {
                Instance.End();
                Instance = null;
            }
        }
    }
}
