#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Settings used to reduce a mesh.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FMeshReductionSettings
	{
		/// <summary>Percentage of triangles to keep. 1.0 = no reduction, 0.0 = no triangles.</summary>
		[FieldOffset(0)]
		public float PercentTriangles;
		/// <summary>The maximum distance in object space by which the reduced mesh may deviate from the original mesh.</summary>
		[FieldOffset(4)]
		public float MaxDeviation;
		/// <summary>Threshold in object space at which vertices are welded together.</summary>
		[FieldOffset(8)]
		public float WeldingThreshold;
		/// <summary>Angle at which a hard edge is introduced between faces.</summary>
		[FieldOffset(12)]
		public float HardAngleThreshold;
		/// <summary>Higher values minimize change to border edges.</summary>
		[FieldOffset(16)]
		public EMeshFeatureImportance SilhouetteImportance;
		/// <summary>Higher values reduce texture stretching.</summary>
		[FieldOffset(17)]
		public EMeshFeatureImportance TextureImportance;
		/// <summary>Higher values try to preserve normals better.</summary>
		[FieldOffset(18)]
		public EMeshFeatureImportance ShadingImportance;
		/// <summary>
		/// UPROPERTY(EditAnywhere, Category = ReductionSettings)
		///        bool bActive;
		/// </summary>
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
		/// <summary>Higher values generates fewer samples</summary>
		[FieldOffset(28)]
		public EMeshFeatureImportance VisibilityAggressiveness;
		/// <summary>Higher values minimize change to vertex color data.</summary>
		[FieldOffset(29)]
		public EMeshFeatureImportance VertexColorImportance;
		
	}
	
}
#endif
#endif
