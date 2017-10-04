using System;
namespace UnrealEngine
{
	/// <summary>Settings used to reduce a mesh.</summary>
	public partial struct FMeshReductionSettings
	{
		/// <summary>Percentage of triangles to keep. 1.0 = no reduction, 0.0 = no triangles.</summary>
		public float PercentTriangles;
		/// <summary>The maximum distance in object space by which the reduced mesh may deviate from the original mesh.</summary>
		public float MaxDeviation;
		/// <summary>The amount of error in pixels allowed for this LOD.</summary>
		public float PixelError;
		/// <summary>Threshold in object space at which vertices are welded together.</summary>
		public float WeldingThreshold;
		/// <summary>Angle at which a hard edge is introduced between faces.</summary>
		public float HardAngleThreshold;
		/// <summary>Higher values minimize change to border edges.</summary>
		public EMeshFeatureImportance SilhouetteImportance;
		/// <summary>Higher values reduce texture stretching.</summary>
		public EMeshFeatureImportance TextureImportance;
		/// <summary>Higher values try to preserve normals better.</summary>
		public EMeshFeatureImportance ShadingImportance;
		/// <summary>
		/// UPROPERTY(EditAnywhere, Category = ReductionSettings)
		///        bool bActive;
		/// </summary>
		public bool bRecalculateNormals;
		public int BaseLODModel;
		public bool bGenerateUniqueLightmapUVs;
		public bool bKeepSymmetry;
		public bool bVisibilityAided;
		public bool bCullOccluded;
		/// <summary>Higher values generates fewer samples</summary>
		public EMeshFeatureImportance VisibilityAggressiveness;
		/// <summary>Higher values minimize change to vertex color data.</summary>
		public EMeshFeatureImportance VertexColorImportance;
		
	}
	
}
