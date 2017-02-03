#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=372)]
	public partial struct FLevelSimplificationDetails
	{
		public bool bCreatePackagePerAsset
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(4)]
		public float DetailsPercentage;
		[FieldOffset(8)]
		public FMaterialSimplificationSettings StaticMeshMaterial;
		[FieldOffset(76)]
		public FMaterialProxySettings StaticMeshMaterialSettings;
		public bool bOverrideLandscapeExportLOD
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 180, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 180, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(184)]
		public int LandscapeExportLOD;
		[FieldOffset(188)]
		public FMaterialSimplificationSettings LandscapeMaterial;
		[FieldOffset(256)]
		public FMaterialProxySettings LandscapeMaterialSettings;
		public bool bBakeFoliageToLandscape
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 360, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 360, 1, 0, 1, 255); } }}
			
		}
		public bool bBakeGrassToLandscape
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 361, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 361, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateMeshNormalMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 362, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 362, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateMeshMetallicMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 363, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 363, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateMeshRoughnessMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 364, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 364, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateMeshSpecularMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 365, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 365, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateLandscapeNormalMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 366, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 366, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateLandscapeMetallicMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 367, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 367, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateLandscapeRoughnessMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 368, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 368, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateLandscapeSpecularMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 369, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 369, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
