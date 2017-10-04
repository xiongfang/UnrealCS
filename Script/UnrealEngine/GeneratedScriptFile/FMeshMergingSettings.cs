using System;
namespace UnrealEngine
{
	/// <summary>Mesh merging settings</summary>
	public partial struct FMeshMergingSettings
	{
		/// <summary>Whether to generate lightmap UVs for a merged mesh</summary>
		public bool bGenerateLightMapUV;
		/// <summary>Target lightmap resolution</summary>
		public int TargetLightMapResolution;
		/// <summary>Whether we should import vertex colors into merged mesh</summary>
		public bool bImportVertexColors;
		/// <summary>Whether merged mesh should have pivot at world origin, or at first merged component otherwise</summary>
		public bool bPivotPointAtZero;
		/// <summary>Whether to merge physics data (collision primitives)</summary>
		public bool bMergePhysicsData;
		/// <summary>Whether to merge source materials into one flat material</summary>
		public bool bMergeMaterials;
		/// <summary>Material simplification</summary>
		public FMaterialProxySettings MaterialSettings;
		/// <summary>Whether or not vertex data such as vertex colours should be baked into the resulting mesh</summary>
		public bool bBakeVertexDataToMesh;
		/// <summary>Whether or not vertex data such as vertex colours should be used when baking out materials</summary>
		public bool bUseVertexDataForBakingMaterial;
		/// <summary>Whether or not to calculate varying output texture sizes according to their importance in the final atlas texture</summary>
		public bool bUseTextureBinning;
		public bool bCalculateCorrectLODModel;
		public int ExportSpecificLOD;
		/// <summary>A given LOD level to export from the source meshes</summary>
		public int SpecificLOD;
		/// <summary>Whether or not to use available landscape geometry to cull away invisible triangles</summary>
		public bool bUseLandscapeCulling;
		/// <summary>Whether to export normal maps for material merging</summary>
		public bool bExportNormalMap;
		/// <summary>Whether to export metallic maps for material merging</summary>
		public bool bExportMetallicMap;
		/// <summary>Whether to export roughness maps for material merging</summary>
		public bool bExportRoughnessMap;
		/// <summary>Whether to export specular maps for material merging</summary>
		public bool bExportSpecularMap;
		/// <summary>Merged material texture atlas resolution</summary>
		public int MergedMaterialAtlasResolution;
		
	}
	
}
