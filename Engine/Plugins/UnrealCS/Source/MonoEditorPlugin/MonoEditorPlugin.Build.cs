// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

using System.IO;
using UnrealBuildTool;
namespace UnrealBuildTool.Rules
{
	public class MonoEditorPlugin : ModuleRules
	{
		public MonoEditorPlugin(TargetInfo Target)
		{

            PrivatePCHHeaderFile = "Private/MonoEditorPluginPrivatePCH.h";

            PublicIncludePaths.AddRange(
				new string[] {					
					//"Programs/UnrealHeaderTool/Public",
					// ... add other public include paths required here ...
				}
				);

			PrivateIncludePaths.AddRange(
				new string[] {
					// ... add other private include paths required here ...
				}
				);

            PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"Engine",
					"InputCore",
					"UnrealEd",
					"AssetTools",
					"ClassViewer",
					"KismetCompiler",
					"Kismet",
					"BlueprintGraph",
                    "UMG",
                    "MonoPlugin",
					// ... add other public dependencies that you statically link with here ...
				}
				);
            PrivateDependencyModuleNames.AddRange(
                new string[]
				{
					"LevelEditor",
                    "GameProjectGeneration",
                    "MessageLog",
                    "EditorStyle",
                    "MainFrame",
                    "SlateCore",
                    "Slate"
                }
            );
            PrivateIncludePathModuleNames.AddRange(
            new string[] {
                "UMG"
            });
            DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);
		}
	}
}