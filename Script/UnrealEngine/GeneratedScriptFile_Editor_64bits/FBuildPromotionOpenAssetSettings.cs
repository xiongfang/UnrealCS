#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the open assets stage of the build promotion test</summary>
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FBuildPromotionOpenAssetSettings
	{
		/// <summary>The blueprint asset to open</summary>
		[FieldOffset(0)]
		public FFilePath BlueprintAsset;
		/// <summary>The material asset to open</summary>
		[FieldOffset(16)]
		public FFilePath MaterialAsset;
		/// <summary>The particle system asset to open</summary>
		[FieldOffset(32)]
		public FFilePath ParticleSystemAsset;
		/// <summary>The skeletal mesh asset to open</summary>
		[FieldOffset(48)]
		public FFilePath SkeletalMeshAsset;
		/// <summary>The static mesh asset to open</summary>
		[FieldOffset(64)]
		public FFilePath StaticMeshAsset;
		/// <summary>The texture asset to open</summary>
		[FieldOffset(80)]
		public FFilePath TextureAsset;
		
	}
	
}
#endif
#endif
