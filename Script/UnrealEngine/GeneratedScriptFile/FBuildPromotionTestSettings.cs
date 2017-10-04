using System;
namespace UnrealEngine
{
	/// <summary>Holds settings for the editor build promotion test</summary>
	public partial struct FBuildPromotionTestSettings
	{
		/// <summary>Default static mesh asset to apply materials to *</summary>
		public FFilePath DefaultStaticMeshAsset;
		/// <summary>Import workflow settings *</summary>
		public FBuildPromotionImportWorkflowSettings ImportWorkflow;
		/// <summary>Open assets settings *</summary>
		public FBuildPromotionOpenAssetSettings OpenAssets;
		/// <summary>New project settings *</summary>
		public FBuildPromotionNewProjectSettings NewProjectSettings;
		/// <summary>Material to modify for the content browser step *</summary>
		public FFilePath SourceControlMaterial;
		
	}
	
}
