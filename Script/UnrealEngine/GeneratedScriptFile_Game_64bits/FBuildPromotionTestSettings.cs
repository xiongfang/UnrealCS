#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=496)]
	public partial struct FBuildPromotionTestSettings
	{
		[FieldOffset(0)]
		public FFilePath DefaultStaticMeshAsset;
		[FieldOffset(16)]
		public FBuildPromotionImportWorkflowSettings ImportWorkflow;
		[FieldOffset(352)]
		public FBuildPromotionOpenAssetSettings OpenAssets;
		[FieldOffset(448)]
		public FBuildPromotionNewProjectSettings NewProjectSettings;
		[FieldOffset(480)]
		public FFilePath SourceControlMaterial;
		
	}
	
}
#endif
#endif
