#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=208)]
	public partial struct FMeshProxySettings
	{
		[FieldOffset(0)]
		public int ScreenSize;
		[FieldOffset(4)]
		public FMaterialProxySettings MaterialSettings;
		[FieldOffset(108)]
		public int TextureWidth;
		[FieldOffset(112)]
		public int TextureHeight;
		public bool bExportNormalMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 1, 255); } }}
			
		}
		public bool bExportMetallicMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 1, 255); } }}
			
		}
		public bool bExportRoughnessMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 1, 255); } }}
			
		}
		public bool bExportSpecularMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 119, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 119, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(120)]
		public FMaterialSimplificationSettings Material;
		public bool bCalculateCorrectLODModel
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 188, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 188, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(192)]
		public float MergeDistance;
		[FieldOffset(196)]
		public float HardAngleThreshold;
		[FieldOffset(200)]
		public int LightMapResolution;
		public bool bRecalculateNormals
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 204, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 204, 1, 0, 1, 255); } }}
			
		}
		public bool bBakeVertexData
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 205, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 205, 1, 0, 1, 255); } }}
			
		}
		public bool bUseLandscapeCulling
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 206, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 206, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(207)]
		public ELandscapeCullingPrecision LandscapeCullingPrecision;
		
	}
	
}
#endif
#endif
