#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=208)]
	public partial struct FMeshProxySettings
	{
		/// <summary>Screen size of the resulting proxy mesh in pixel size</summary>
		[FieldOffset(0)]
		public int ScreenSize;
		/// <summary>Material simplification</summary>
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
		/// <summary>Material simplification</summary>
		[FieldOffset(120)]
		public FMaterialSimplificationSettings Material;
		/// <summary>Determines whether or not the correct LOD models should be calculated given the source meshes and transition size</summary>
		public bool bCalculateCorrectLODModel
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 188, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 188, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Distance at which meshes should be merged together</summary>
		[FieldOffset(192)]
		public float MergeDistance;
		/// <summary>Angle at which a hard edge is introduced between faces</summary>
		[FieldOffset(196)]
		public float HardAngleThreshold;
		/// <summary>Lightmap resolution</summary>
		[FieldOffset(200)]
		public int LightMapResolution;
		/// <summary>Whether Simplygon should recalculate normals, otherwise the normals channel will be sampled from the original mesh</summary>
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
		/// <summary>Whether or not to use available landscape geometry to cull away invisible triangles</summary>
		public bool bUseLandscapeCulling
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 206, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 206, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Level of detail of the landscape that should be used for the culling</summary>
		[FieldOffset(207)]
		public ELandscapeCullingPrecision LandscapeCullingPrecision;
		
	}
	
}
#endif
#endif
