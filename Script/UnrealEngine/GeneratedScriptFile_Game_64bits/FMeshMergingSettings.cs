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
		public int TargetLightMapResolution;
		public bool bImportVertexColors
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		public bool bPivotPointAtZero
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 1, 255); } }}
			
		}
		public bool bMergePhysicsData
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 1, 255); } }}
			
		}
		public bool bMergeMaterials
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(12)]
		public FMaterialProxySettings MaterialSettings;
		public bool bBakeVertexDataToMesh
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 1, 255); } }}
			
		}
		public bool bUseVertexDataForBakingMaterial
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 1, 255); } }}
			
		}
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
