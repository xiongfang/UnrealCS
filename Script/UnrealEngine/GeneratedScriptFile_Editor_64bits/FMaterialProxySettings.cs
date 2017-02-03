#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FMaterialProxySettings
	{
		/// <summary>Size of generated BaseColor map</summary>
		[FieldOffset(0)]
		public FIntPoint TextureSize;
		[FieldOffset(8)]
		public ETextureSizingType TextureSizingType;
		[FieldOffset(12)]
		public float GutterSpace;
		/// <summary>Whether to generate normal map</summary>
		public bool bNormalMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether to generate metallic map</summary>
		public bool bMetallicMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 17, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 17, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Metallic constant</summary>
		[FieldOffset(20)]
		public float MetallicConstant;
		/// <summary>Whether to generate roughness map</summary>
		public bool bRoughnessMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Roughness constant</summary>
		[FieldOffset(28)]
		public float RoughnessConstant;
		/// <summary>Whether to generate specular map</summary>
		public bool bSpecularMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Specular constant</summary>
		[FieldOffset(36)]
		public float SpecularConstant;
		/// <summary>Whether to generate emissive map</summary>
		public bool bEmissiveMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 40, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 40, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether to generate opacity map</summary>
		public bool bOpacityMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 41, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 41, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Override diffuse map size</summary>
		[FieldOffset(44)]
		public FIntPoint DiffuseTextureSize;
		/// <summary>Override normal map size</summary>
		[FieldOffset(52)]
		public FIntPoint NormalTextureSize;
		/// <summary>Override metallic map size</summary>
		[FieldOffset(60)]
		public FIntPoint MetallicTextureSize;
		/// <summary>Override roughness map size</summary>
		[FieldOffset(68)]
		public FIntPoint RoughnessTextureSize;
		/// <summary>Override specular map size</summary>
		[FieldOffset(76)]
		public FIntPoint SpecularTextureSize;
		/// <summary>Override emissive map size</summary>
		[FieldOffset(84)]
		public FIntPoint EmissiveTextureSize;
		/// <summary>Override opacity map size</summary>
		[FieldOffset(92)]
		public FIntPoint OpacityTextureSize;
		[FieldOffset(100)]
		public EMaterialMergeType MaterialMergeType;
		
	}
	
}
#endif
#endif
