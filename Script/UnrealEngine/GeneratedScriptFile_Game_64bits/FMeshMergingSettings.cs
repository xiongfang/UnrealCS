#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=148)]
	public partial struct FMeshMergingSettings
	{
		public bool bGenerateLightMapUV
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(4)]
		public int TargetLightMapUVChannel;
		[FieldOffset(8)]
		public int TargetLightMapResolution;
		public bool bImportVertexColors
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 255); } }}
			
		}
		public bool bPivotPointAtZero
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 1, 255); } }}
			
		}
		public bool bMergePhysicsData
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 1, 255); } }}
			
		}
		public bool bMergeMaterials
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(16)]
		public FMaterialProxySettings MaterialSettings;
		public bool bBakeVertexDataToMesh
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 120, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 120, 1, 0, 1, 255); } }}
			
		}
		public bool bUseVertexDataForBakingMaterial
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 121, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 121, 1, 0, 1, 255); } }}
			
		}
		public bool bCalculateCorrectLODModel
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 122, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 122, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(123)]
		public EMeshLODSelectionType LODSelectionType;
		[FieldOffset(124)]
		public int ExportSpecificLOD;
		[FieldOffset(128)]
		public int SpecificLOD;
		public bool bUseLandscapeCulling
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 132, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 132, 1, 0, 1, 255); } }}
			
		}
		public bool bExportNormalMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 133, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 133, 1, 0, 1, 255); } }}
			
		}
		public bool bExportMetallicMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 134, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 134, 1, 0, 1, 255); } }}
			
		}
		public bool bExportRoughnessMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 135, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 135, 1, 0, 1, 255); } }}
			
		}
		public bool bExportSpecularMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 136, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 136, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(140)]
		public int MergedMaterialAtlasResolution;
		
	}
	
}
#endif
#endif
