#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FBuildPromotionOpenAssetSettings
	{
		[FieldOffset(0)]
		public FFilePath BlueprintAsset;
		[FieldOffset(16)]
		public FFilePath MaterialAsset;
		[FieldOffset(32)]
		public FFilePath ParticleSystemAsset;
		[FieldOffset(48)]
		public FFilePath SkeletalMeshAsset;
		[FieldOffset(64)]
		public FFilePath StaticMeshAsset;
		[FieldOffset(80)]
		public FFilePath TextureAsset;
		
	}
	
}
#endif
#endif
