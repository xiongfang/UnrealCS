using System;
namespace UnrealEngine
{
	/// <summary>Holds settings for the import workflow stage of the build promotion test</summary>
	public partial struct FBuildPromotionImportWorkflowSettings
	{
		/// <summary>Import settings for the Diffuse texture</summary>
		public FEditorImportWorkflowDefinition Diffuse;
		/// <summary>Import settings for the Normalmap texture</summary>
		public FEditorImportWorkflowDefinition Normal;
		/// <summary>Import settings for the static mesh</summary>
		public FEditorImportWorkflowDefinition StaticMesh;
		/// <summary>Import settings for the static mesh to re-import</summary>
		public FEditorImportWorkflowDefinition ReimportStaticMesh;
		/// <summary>Import settings for the blend shape</summary>
		public FEditorImportWorkflowDefinition BlendShapeMesh;
		/// <summary>Import settings for the morph mesh</summary>
		public FEditorImportWorkflowDefinition MorphMesh;
		/// <summary>Import settings for the skeletal mesh</summary>
		public FEditorImportWorkflowDefinition SkeletalMesh;
		/// <summary>Import settings for the animation asset.  (Will automatically use the skeleton of the skeletal mesh above)</summary>
		public FEditorImportWorkflowDefinition Animation;
		/// <summary>Import settings for the sound</summary>
		public FEditorImportWorkflowDefinition Sound;
		/// <summary>Import settings for the surround sound (Select any of the channels.  It will auto import the rest)</summary>
		public FEditorImportWorkflowDefinition SurroundSound;
		
	}
	
}
