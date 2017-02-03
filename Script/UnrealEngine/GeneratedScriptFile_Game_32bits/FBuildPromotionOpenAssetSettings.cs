#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FBuildPromotionOpenAssetSettings
	{
		[FieldOffset(0)]
		public FFilePath BlueprintAsset;
		[FieldOffset(12)]
		public FFilePath MaterialAsset;
		[FieldOffset(24)]
		public FFilePath ParticleSystemAsset;
		[FieldOffset(36)]
		public FFilePath SkeletalMeshAsset;
		[FieldOffset(48)]
		public FFilePath StaticMeshAsset;
		[FieldOffset(60)]
		public FFilePath TextureAsset;
		
	}
	
}
#endif
#endif
