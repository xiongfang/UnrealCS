using System;
namespace UnrealEngine
{
	public partial struct FLevelSimplificationDetails
	{
		/// <summary>Whether to create separate packages for each generated asset. All in map package otherwise</summary>
		public bool bCreatePackagePerAsset;
		/// <summary>Percentage of details for static mesh proxy</summary>
		public float DetailsPercentage;
		/// <summary>Static mesh material simplification</summary>
		public FMaterialSimplificationSettings StaticMeshMaterial;
		/// <summary>Landscape material simplification</summary>
		public FMaterialProxySettings StaticMeshMaterialSettings;
		public bool bOverrideLandscapeExportLOD;
		/// <summary>Landscape LOD to use for static mesh generation, when not specified 'Max LODLevel' from landscape actor will be used</summary>
		public int LandscapeExportLOD;
		/// <summary>Landscape material simplification</summary>
		public FMaterialSimplificationSettings LandscapeMaterial;
		/// <summary>Landscape material simplification</summary>
		public FMaterialProxySettings LandscapeMaterialSettings;
		/// <summary>Whether to bake foliage into landscape static mesh texture</summary>
		public bool bBakeFoliageToLandscape;
		/// <summary>Whether to bake grass into landscape static mesh texture</summary>
		public bool bBakeGrassToLandscape;
		public bool bGenerateMeshNormalMap;
		public bool bGenerateMeshMetallicMap;
		public bool bGenerateMeshRoughnessMap;
		public bool bGenerateMeshSpecularMap;
		public bool bGenerateLandscapeNormalMap;
		public bool bGenerateLandscapeMetallicMap;
		public bool bGenerateLandscapeRoughnessMap;
		public bool bGenerateLandscapeSpecularMap;
		
	}
	
}
