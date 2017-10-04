using System;
namespace UnrealEngine
{
	/// <summary>Holds settings for the new project stage of the build promotion test</summary>
	public partial struct FBuildPromotionNewProjectSettings
	{
		/// <summary>The path for the new project</summary>
		public FDirectoryPath NewProjectFolderOverride;
		/// <summary>The name of the project *</summary>
		public FString NewProjectNameOverride;
		
	}
	
}
