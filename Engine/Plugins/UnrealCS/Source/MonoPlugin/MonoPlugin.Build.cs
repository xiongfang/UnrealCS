// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

using System.IO;
using UnrealBuildTool;

namespace UnrealBuildTool.Rules
{
    public class MonoPlugin : ModuleRules
    {
        protected string ThirdPartyPath
        {
            get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "..", "ThirdParty")); }
        }

        void AddAllAOTFiles()
        {
            string aot_path = Path.GetFullPath(Path.Combine(ModuleDirectory, "..","..", "AOT"));
            string[] aot_files = Directory.GetFiles(aot_path, "*.a");
            PublicLibraryPaths.Add(aot_path);
            foreach(var f in aot_files)
            {
                PublicAdditionalLibraries.Add(f);
            }
        }

        void LoadMono(TargetInfo Target)
        {
            bool bEnableSGen = true;

            //Type = ModuleType.External;

            string MonoPath = Path.Combine(ThirdPartyPath,"mono");
            PrivateIncludePaths.AddRange(
                new string[] {
                    Path.Combine(MonoPath ,"include","mono-2.0")
                    }
                );

            string PlatformPath;

            switch (Target.Platform)
            {
                case UnrealTargetPlatform.Win64:
                    PlatformPath = "Win64";
                    break;
                case UnrealTargetPlatform.Win32:
                    PlatformPath = "Win32";
                    break;
                case UnrealTargetPlatform.Mac:
                    PlatformPath = "Mac";
                    break;
                case UnrealTargetPlatform.Android:
                    PlatformPath = "Android";
                    break;
                case UnrealTargetPlatform.IOS:
                    PlatformPath = "IOS";
                    break;
                default:
                    throw new BuildException("Mono not supported on platform '{0}'", Target.Platform.ToString());
            }

            string MonoLibPath = Path.Combine(MonoPath, "lib", PlatformPath);

            if (Target.Platform == UnrealTargetPlatform.Win64
                || Target.Platform == UnrealTargetPlatform.Win32)
            {
                PublicLibraryPaths.Add(MonoLibPath);

                string LibraryName;
                if (bEnableSGen)
                {
                    LibraryName = "monosgen-2.0";
                }
                else
                {
                    LibraryName = "mono-2.0"; ;
                }
                PublicAdditionalLibraries.Add(LibraryName + ".lib");
                PublicDelayLoadDLLs.Add(LibraryName + ".dll");

                //依赖文件
                //AddAllFrameworkFiles();

                if (Target.Platform == UnrealTargetPlatform.Win64)
                    RuntimeDependencies.Add(new RuntimeDependency(string.Format("$(EngineDir)/Binaries/ThirdParty/EMono/bin/Win64/{0}.dll", LibraryName)));
                else
                    RuntimeDependencies.Add(new RuntimeDependency(string.Format("$(EngineDir)/Binaries/ThirdParty/EMono/bin/Win32/{0}.dll", LibraryName)));
            }
            else if (Target.Platform == UnrealTargetPlatform.Mac)
            {
                PublicLibraryPaths.Add(MonoLibPath);

                string LibraryName;
                if (bEnableSGen)
                {
                    LibraryName = "libmonosgen-2.0";
                }
                else
                {
                    LibraryName = "libmonoboehm-2.0";
                }

                PublicAdditionalLibraries.Add(Path.Combine(MonoLibPath, LibraryName + ".a"));
                PublicAdditionalLibraries.Add("iconv");
                //PublicDelayLoadDLLs.Add(Path.Combine(MonoLibPath, LibraryName + ".dylib"));
                //RuntimeDependencies.Add(new RuntimeDependency("$(EngineDir)/Binaries/ThirdParty/EMono/bin/Mac/libmonosgen-2.0.dylib"));
            }
            else if (Target.Platform == UnrealTargetPlatform.Android)
            {
                PublicLibraryPaths.Add(MonoLibPath + "/ARMv7");
                //PublicLibraryPaths.Add(MonoLibPath + "/lib/Android/ARM64");
                //PublicLibraryPaths.Add(MonoLibPath + "/lib/Android/x86");
                //PublicLibraryPaths.Add(MonoLibPath + "/lib/Android/x64");

                PublicAdditionalLibraries.Add("monosgen-2.0");

                //AddAllFrameworkFiles();
            }
            else if (Target.Platform == UnrealTargetPlatform.IOS)
            {
                PublicLibraryPaths.Add(MonoLibPath + "/ARMv7");
                PublicAdditionalLibraries.Add("iconv");
                PublicAdditionalLibraries.Add("monosgen-2.0");
                //所有AOT文件
                AddAllAOTFiles();
            }
            else
            {
                throw new BuildException("Mono not supported on platform '{0}'", Target.Platform.ToString());
            }

            if (bEnableSGen)
            {
                Definitions.Add("WITH_MONO_SGEN=1");
            }
            else
            {
                Definitions.Add("WITH_MONO_SGEN=0");
            }
        }

        public MonoPlugin(TargetInfo Target)
        {
            PublicIncludePaths.AddRange(
                new string[] {					
					//"Programs/UnrealHeaderTool/Public",
					// ... add other public include paths required here ...
                    "Runtime/UMG/Public"
                }
                );

            PrivateIncludePaths.AddRange(
                new string[] {
					// ... add other private include paths required here ...
                }
                );

            PrivateDependencyModuleNames.AddRange(
                new string[]
				{
					"Core",
					"CoreUObject",
					"Engine",
					"InputCore",
					"SlateCore",
                    "NetworkReplayStreaming",
                    "AIModule",
                    "PacketHandler",
                    "MovieSceneTracks",
                    "MovieScene",
                    "Slate",
                    "UMG",
                    "MonoHelper",
                    "Projects"
					// ... add other public dependencies that you statically link with here ...
				}
                );

            if (UEBuildConfiguration.bBuildEditor == true)
            {

                PublicDependencyModuleNames.AddRange(
                    new string[] 
					{
						"UnrealEd", 
					}
                );

            }


            DynamicallyLoadedModuleNames.AddRange(
                new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
                );

            {
                LoadMono(Target);
                Definitions.Add("WITH_MONO=1");
            }

        }
    }
}