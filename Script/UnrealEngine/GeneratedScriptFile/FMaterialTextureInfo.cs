using System;
namespace UnrealEngine
{
	/// <summary>This struct holds data about how a texture is sampled within a material.</summary>
	public partial struct FMaterialTextureInfo
	{
		/// <summary>The scale used when sampling the texture</summary>
		public float SamplingScale;
		/// <summary>The coordinate index used when sampling the texture</summary>
		public int UVChannelIndex;
		/// <summary>The texture name. Used for debugging and also to for quick matching of the entries.</summary>
		public FName TextureName;
		/// <summary>The reference to the texture, used to keep the TextureName valid even if it gets renamed.</summary>
		public FStringAssetReference TextureReference;
		/// <summary>
		/// The texture index in the material resource the data was built from.
		/// This must be transient as it depends on which shader map was used for the build.
		/// </summary>
		public int TextureIndex;
		
	}
	
}
