#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the editor build promotion test</summary>
	[StructLayout(LayoutKind.Explicit,Size=496)]
	public partial struct FBuildPromotionTestSettings
	{
		/// <summary>Default static mesh asset to apply materials to *</summary>
		[FieldOffset(0)]
		public FFilePath DefaultStaticMeshAsset;
		/// <summary>Import workflow settings *</summary>
		[FieldOffset(16)]
		public FBuildPromotionImportWorkflowSettings ImportWorkflow;
		/// <summary>Open assets settings *</summary>
		[FieldOffset(352)]
		public FBuildPromotionOpenAssetSettings OpenAssets;
		/// <summary>New project settings *</summary>
		[FieldOffset(448)]
		public FBuildPromotionNewProjectSettings NewProjectSettings;
		/// <summary>Material to modify for the content browser step *</summary>
		[FieldOffset(480)]
		public FFilePath SourceControlMaterial;
		
	}
	
}
#endif
#endif
