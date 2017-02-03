#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=372)]
	public partial struct FBuildPromotionTestSettings
	{
		[FieldOffset(0)]
		public FFilePath DefaultStaticMeshAsset;
		[FieldOffset(12)]
		public FBuildPromotionImportWorkflowSettings ImportWorkflow;
		[FieldOffset(264)]
		public FBuildPromotionOpenAssetSettings OpenAssets;
		[FieldOffset(336)]
		public FBuildPromotionNewProjectSettings NewProjectSettings;
		[FieldOffset(360)]
		public FFilePath SourceControlMaterial;
		
	}
	
}
#endif
#endif
