#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FMaterialProxySettings
	{
		[FieldOffset(0)]
		public FIntPoint TextureSize;
		[FieldOffset(8)]
		public ETextureSizingType TextureSizingType;
		[FieldOffset(12)]
		public float GutterSpace;
		public bool bNormalMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 255); } }}
			
		}
		public bool bMetallicMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 17, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 17, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(20)]
		public float MetallicConstant;
		public bool bRoughnessMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(28)]
		public float RoughnessConstant;
		public bool bSpecularMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(36)]
		public float SpecularConstant;
		public bool bEmissiveMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 40, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 40, 1, 0, 1, 255); } }}
			
		}
		public bool bOpacityMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 41, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 41, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(44)]
		public FIntPoint DiffuseTextureSize;
		[FieldOffset(52)]
		public FIntPoint NormalTextureSize;
		[FieldOffset(60)]
		public FIntPoint MetallicTextureSize;
		[FieldOffset(68)]
		public FIntPoint RoughnessTextureSize;
		[FieldOffset(76)]
		public FIntPoint SpecularTextureSize;
		[FieldOffset(84)]
		public FIntPoint EmissiveTextureSize;
		[FieldOffset(92)]
		public FIntPoint OpacityTextureSize;
		[FieldOffset(100)]
		public EMaterialMergeType MaterialMergeType;
		
	}
	
}
#endif
#endif
