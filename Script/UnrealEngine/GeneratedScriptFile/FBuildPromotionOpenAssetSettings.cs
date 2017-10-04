using System;
namespace UnrealEngine
{
	/// <summary>Holds settings for the open assets stage of the build promotion test</summary>
	public partial struct FBuildPromotionOpenAssetSettings
	{
		/// <summary>The blueprint asset to open</summary>
		public FFilePath BlueprintAsset;
		/// <summary>The material asset to open</summary>
		public FFilePath MaterialAsset;
		/// <summary>The particle system asset to open</summary>
		public FFilePath ParticleSystemAsset;
		/// <summary>The skeletal mesh asset to open</summary>
		public FFilePath SkeletalMeshAsset;
		/// <summary>The static mesh asset to open</summary>
		public FFilePath StaticMeshAsset;
		/// <summary>The texture asset to open</summary>
		public FFilePath TextureAsset;
		
	}
	
}
