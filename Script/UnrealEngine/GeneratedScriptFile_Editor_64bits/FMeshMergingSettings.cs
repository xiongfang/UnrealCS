#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Mesh merging settings</summary>
	[StructLayout(LayoutKind.Explicit,Size=148)]
	public partial struct FMeshMergingSettings
	{
		/// <summary>Whether to generate lightmap UVs for a merged mesh</summary>
		public bool bGenerateLightMapUV
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Target lightmap resolution</summary>
		[FieldOffset(4)]
		public int TargetLightMapResolution;
		/// <summary>Whether we should import vertex colors into merged mesh</summary>
		public bool bImportVertexColors
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether merged mesh should have pivot at world origin, or at first merged component otherwise</summary>
		public bool bPivotPointAtZero
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether to merge physics data (collision primitives)</summary>
		public bool bMergePhysicsData
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether to merge source materials into one flat material</summary>
		public bool bMergeMaterials
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Material simplification</summary>
		[FieldOffset(12)]
		public FMaterialProxySettings MaterialSettings;
		/// <summary>Whether or not vertex data such as vertex colours should be baked into the resulting mesh</summary>
		public bool bBakeVertexDataToMesh
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not vertex data such as vertex colours should be used when baking out materials</summary>
		public bool bUseVertexDataForBakingMaterial
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not to calculate varying output texture sizes according to their importance in the final atlas texture</summary>
		public bool bUseTextureBinning
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 1, 255); } }}
			
		}
		public bool bCalculateCorrectLODModel
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 119, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 119, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(124)]
		public int ExportSpecificLOD;
		/// <summary>A given LOD level to export from the source meshes</summary>
		[FieldOffset(128)]
		public int SpecificLOD;
		/// <summary>Whether or not to use available landscape geometry to cull away invisible triangles</summary>
		public bool bUseLandscapeCulling
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 132, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 132, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether to export normal maps for material merging</summary>
		public bool bExportNormalMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 133, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 133, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether to export metallic maps for material merging</summary>
		public bool bExportMetallicMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 134, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 134, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether to export roughness maps for material merging</summary>
		public bool bExportRoughnessMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 135, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 135, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether to export specular maps for material merging</summary>
		public bool bExportSpecularMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 136, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 136, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Merged material texture atlas resolution</summary>
		[FieldOffset(140)]
		public int MergedMaterialAtlasResolution;
		
	}
	
}
#endif
#endif
