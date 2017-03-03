#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This struct holds data about how a texture is sampled within a material.</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FMaterialTextureInfo
	{
		/// <summary>The scale used when sampling the texture</summary>
		[FieldOffset(0)]
		public float SamplingScale;
		/// <summary>The coordinate index used when sampling the texture</summary>
		[FieldOffset(4)]
		public int UVChannelIndex;
		/// <summary>The texture name. Used for debugging and also to for quick matching of the entries.</summary>
		[FieldOffset(8)]
		public FName TextureName;
		/// <summary>The reference to the texture, used to keep the TextureName valid even if it gets renamed.</summary>
		[FieldOffset(24)]
		public FStringAssetReference TextureReference;
		/// <summary>
		/// The texture index in the material resource the data was built from.
		/// This must be transient as it depends on which shader map was used for the build.
		/// </summary>
		[FieldOffset(40)]
		public int TextureIndex;
		
	}
	
}
#endif
#endif
