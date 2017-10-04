using System;
namespace UnrealEngine
{
	/// <summary>Settings applied when building a mesh.</summary>
	public partial struct FMeshBuildSettings
	{
		/// <summary>If true, degenerate triangles will be removed.</summary>
		public bool bUseMikkTSpace;
		/// <summary>If true, normals in the raw mesh are ignored and recomputed.</summary>
		public bool bRecomputeNormals;
		/// <summary>If true, tangents in the raw mesh are ignored and recomputed.</summary>
		public bool bRecomputeTangents;
		/// <summary>If true, degenerate triangles will be removed.</summary>
		public bool bRemoveDegenerates;
		/// <summary>Required for PNT tessellation but can be slow. Recommend disabling for larger meshes.</summary>
		public bool bBuildAdjacencyBuffer;
		/// <summary>Required to optimize mesh in mirrored transform. Double index buffer size.</summary>
		public bool bBuildReversedIndexBuffer;
		/// <summary>If true, Tangents will be stored at 16 bit vs 8 bit precision.</summary>
		public bool bUseHighPrecisionTangentBasis;
		/// <summary>If true, UVs will be stored at full floating point precision.</summary>
		public bool bUseFullPrecisionUVs;
		public bool bGenerateLightmapUVs;
		public int MinLightmapResolution;
		public int SrcLightmapIndex;
		public int DstLightmapIndex;
		public float BuildScale;
		/// <summary>The local scale applied when building the mesh</summary>
		public FVector BuildScale3D;
		/// <summary>
		/// Scale to apply to the mesh when allocating the distance field volume texture.
		/// The default scale is 1, which is assuming that the mesh will be placed unscaled in the world.
		/// </summary>
		public float DistanceFieldResolutionScale;
		/// <summary>
		/// Whether to generate the distance field treating every triangle hit as a front face.
		/// When enabled prevents the distance field from being discarded due to the mesh being open, but also lowers Distance Field AO quality.
		/// </summary>
		public bool bGenerateDistanceFieldAsIfTwoSided;
		/// <summary>
		/// Adding a constant distance effectively shrinks the distance field representation.
		/// This is useful for preventing self shadowing aritfacts when doing some minor ambient animation.
		/// Thin walls will be affected more severely than large hollow objects, because thin walls don't have a large negative region.
		/// </summary>
		public float DistanceFieldBias;
		public UStaticMesh DistanceFieldReplacementMesh;
		
	}
	
}
