using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;
using UnrealEngine;
using System.Diagnostics;

namespace MainDomain
{
    public class Main
    {
        static  Main Instance;

        bool withEidtor;
        string gameName;
        string pluginBaseDir;
        string engineAssembliesDir;
        string gameAssembliesDir;
        string shadowCopyDirectory;

        AppDomain gameDomain;
        System.IO.FileSystemWatcher fsw;

        public Main(string gameName,string pluginBaseDir, string engineAssembliesDir, string gameAssembliesDir, string shadowCopyDirectory, int withEidtor)
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
            UnrealEngine.UObject.LogInfo("Fsw_Renamed:" + e.OldName+" NewName:"+e.Name);
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
            switch(cmd)
            {
                case "OpenProject":
                    OpenProject();
                    break;
                default:
                    break;
            }
        }

        void CopyFolder(string Dest,string Src)
        {
            if (!(Dest.EndsWith("\\") || Dest.EndsWith("/")))
                Dest += "/";
            if (!(Src.EndsWith("\\") || Src.EndsWith("/")))
                Src += "/";
            if (!Directory.Exists(Dest))
                Directory.CreateDirectory(Dest);

            // 子文件夹
            foreach (string sub in Directory.GetDirectories(Src,"*",SearchOption.TopDirectoryOnly))
	        {
                string name = Path.GetFileName(sub);
                CopyFolder(Path.Combine(Dest, name), Path.Combine(Src, name));
	        }


            // 文件
	        foreach (string file in Directory.GetFiles(Src,"*",SearchOption.TopDirectoryOnly))
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

            if(UGameplayStatics.GetPlatformName() == "Windows")
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
                UObject.LogWarning("C# script solution file located at "+ Path.Combine(FPaths.GameDir(), "Project","Script.sln"));
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
