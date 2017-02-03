#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>FSkeletalMeshOptimizationSettings - The settings used to optimize a skeletal mesh LOD.</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FSkeletalMeshOptimizationSettings
	{
		/// <summary>The method to use when optimizing the skeletal mesh LOD</summary>
		[FieldOffset(0)]
		public SkeletalMeshOptimizationType ReductionMethod;
		/// <summary>If ReductionMethod equals SMOT_NumOfTriangles this value is the ratio of triangles [0-1] to remove from the mesh</summary>
		[FieldOffset(4)]
		public float NumOfTrianglesPercentage;
		/// <summary>If ReductionMethod equals SMOT_MaxDeviation this value is the maximum deviation from the base mesh as a percentage of the bounding sphere.</summary>
		[FieldOffset(8)]
		public float MaxDeviationPercentage;
		/// <summary>The welding threshold distance. Vertices under this distance will be welded.</summary>
		[FieldOffset(12)]
		public float WeldingThreshold;
		/// <summary>Whether Normal smoothing groups should be preserved. If false then NormalsThreshold is used *</summary>
		public bool bRecalcNormals
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// If the angle between two triangles are above this value, the normals will not be
		///       smooth over the edge between those two triangles. Set in degrees. This is only used when PreserveNormals is set to false
		/// </summary>
		[FieldOffset(20)]
		public float NormalsThreshold;
		/// <summary>How important the shape of the geometry is.</summary>
		[FieldOffset(24)]
		public SkeletalMeshOptimizationImportance SilhouetteImportance;
		/// <summary>How important texture density is.</summary>
		[FieldOffset(25)]
		public SkeletalMeshOptimizationImportance TextureImportance;
		/// <summary>How important shading quality is.</summary>
		[FieldOffset(26)]
		public SkeletalMeshOptimizationImportance ShadingImportance;
		/// <summary>How important skinning quality is.</summary>
		[FieldOffset(27)]
		public SkeletalMeshOptimizationImportance SkinningImportance;
		/// <summary>The ratio of bones that will be removed from the mesh</summary>
		[FieldOffset(28)]
		public float BoneReductionRatio;
		/// <summary>Maximum number of bones that can be assigned to each vertex.</summary>
		[FieldOffset(32)]
		public int MaxBonesPerVertex;
		public TStructArray<FBoneReference> BonesToRemove
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBoneReference>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		/// <summary>Maximum number of bones that can be assigned to each vertex.</summary>
		[FieldOffset(56)]
		public int BaseLOD;
		
	}
	
}
#endif
#endif
