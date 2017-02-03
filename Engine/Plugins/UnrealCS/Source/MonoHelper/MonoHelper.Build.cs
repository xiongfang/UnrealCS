// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

using System.IO;
using UnrealBuildTool;
namespace UnrealBuildTool.Rules
{
	public class MonoHelper : ModuleRules
	{
		public MonoHelper(TargetInfo Target)
		{
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

            PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					// ... add other public dependencies that you statically link with here ...
				}
				);
            PrivateDependencyModuleNames.AddRange(
                new string[]
				{
                }
            );
            PrivateIncludePathModuleNames.AddRange(
            new string[] {
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