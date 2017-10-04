using System;
namespace UnrealEngine
{
	/// <summary>FSkeletalMeshOptimizationSettings - The settings used to optimize a skeletal mesh LOD.</summary>
	public partial struct FSkeletalMeshOptimizationSettings
	{
		/// <summary>The method to use when optimizing the skeletal mesh LOD</summary>
		public SkeletalMeshOptimizationType ReductionMethod;
		/// <summary>If ReductionMethod equals SMOT_NumOfTriangles this value is the ratio of triangles [0-1] to remove from the mesh</summary>
		public float NumOfTrianglesPercentage;
		/// <summary>If ReductionMethod equals SMOT_MaxDeviation this value is the maximum deviation from the base mesh as a percentage of the bounding sphere.</summary>
		public float MaxDeviationPercentage;
		/// <summary>The welding threshold distance. Vertices under this distance will be welded.</summary>
		public float WeldingThreshold;
		/// <summary>Whether Normal smoothing groups should be preserved. If false then NormalsThreshold is used *</summary>
		public bool bRecalcNormals;
		/// <summary>
		/// If the angle between two triangles are above this value, the normals will not be
		///       smooth over the edge between those two triangles. Set in degrees. This is only used when PreserveNormals is set to false
		/// </summary>
		public float NormalsThreshold;
		/// <summary>How important the shape of the geometry is.</summary>
		public SkeletalMeshOptimizationImportance SilhouetteImportance;
		/// <summary>How important texture density is.</summary>
		public SkeletalMeshOptimizationImportance TextureImportance;
		/// <summary>How important shading quality is.</summary>
		public SkeletalMeshOptimizationImportance ShadingImportance;
		/// <summary>How important skinning quality is.</summary>
		public SkeletalMeshOptimizationImportance SkinningImportance;
		/// <summary>The ratio of bones that will be removed from the mesh</summary>
		public float BoneReductionRatio;
		/// <summary>Maximum number of bones that can be assigned to each vertex.</summary>
		public int MaxBonesPerVertex;
		/// <summary>Maximum number of bones that can be assigned to each vertex.</summary>
		public int BaseLOD;
		
	}
	
}
