#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FMeshReductionSettings
	{
		[FieldOffset(0)]
		public float PercentTriangles;
		[FieldOffset(4)]
		public float MaxDeviation;
		[FieldOffset(8)]
		public float WeldingThreshold;
		[FieldOffset(12)]
		public float HardAngleThreshold;
		[FieldOffset(16)]
		public EMeshFeatureImportance SilhouetteImportance;
		[FieldOffset(17)]
		public EMeshFeatureImportance TextureImportance;
		[FieldOffset(18)]
		public EMeshFeatureImportance ShadingImportance;
		public bool bRecalculateNormals
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 19, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 19, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(20)]
		public int BaseLODModel;
		public bool bGenerateUniqueLightmapUVs
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		public bool bKeepSymmetry
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 25, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 25, 1, 0, 1, 255); } }}
			
		}
		public bool bVisibilityAided
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 26, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 26, 1, 0, 1, 255); } }}
			
		}
		public bool bCullOccluded
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 27, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 27, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(28)]
		public EMeshFeatureImportance VisibilityAggressiveness;
		[FieldOffset(29)]
		public EMeshFeatureImportance VertexColorImportance;
		
	}
	
}
#endif
#endif
