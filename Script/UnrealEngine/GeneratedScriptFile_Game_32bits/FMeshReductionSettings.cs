#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FMeshReductionSettings
	{
		[FieldOffset(0)]
		public float PercentTriangles;
		[FieldOffset(4)]
		public float MaxDeviation;
		[FieldOffset(8)]
		public float PixelError;
		[FieldOffset(12)]
		public float WeldingThreshold;
		[FieldOffset(16)]
		public float HardAngleThreshold;
		[FieldOffset(20)]
		public EMeshFeatureImportance SilhouetteImportance;
		[FieldOffset(21)]
		public EMeshFeatureImportance TextureImportance;
		[FieldOffset(22)]
		public EMeshFeatureImportance ShadingImportance;
		public bool bRecalculateNormals
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 23, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 23, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(24)]
		public int BaseLODModel;
		public bool bGenerateUniqueLightmapUVs
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 255); } }}
			
		}
		public bool bKeepSymmetry
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 29, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 29, 1, 0, 1, 255); } }}
			
		}
		public bool bVisibilityAided
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 30, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 30, 1, 0, 1, 255); } }}
			
		}
		public bool bCullOccluded
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 31, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 31, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(32)]
		public EMeshFeatureImportance VisibilityAggressiveness;
		[FieldOffset(33)]
		public EMeshFeatureImportance VertexColorImportance;
		
	}
	
}
#endif
#endif
