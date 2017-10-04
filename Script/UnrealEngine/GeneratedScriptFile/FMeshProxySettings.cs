using System;
namespace UnrealEngine
{
	public partial struct FMeshProxySettings
	{
		/// <summary>Screen size of the resulting proxy mesh in pixel size</summary>
		public int ScreenSize;
		/// <summary>Material simplification</summary>
		public FMaterialProxySettings MaterialSettings;
		public int TextureWidth;
		public int TextureHeight;
		public bool bExportNormalMap;
		public bool bExportMetallicMap;
		public bool bExportRoughnessMap;
		public bool bExportSpecularMap;
		/// <summary>Material simplification</summary>
		public FMaterialSimplificationSettings Material;
		/// <summary>Determines whether or not the correct LOD models should be calculated given the source meshes and transition size</summary>
		public bool bCalculateCorrectLODModel;
		/// <summary>Distance at which meshes should be merged together</summary>
		public float MergeDistance;
		/// <summary>Angle at which a hard edge is introduced between faces</summary>
		public float HardAngleThreshold;
		/// <summary>Lightmap resolution</summary>
		public int LightMapResolution;
		/// <summary>Whether Simplygon should recalculate normals, otherwise the normals channel will be sampled from the original mesh</summary>
		public bool bRecalculateNormals;
		public bool bBakeVertexData;
		/// <summary>Whether or not to use available landscape geometry to cull away invisible triangles</summary>
		public bool bUseLandscapeCulling;
		/// <summary>Level of detail of the landscape that should be used for the culling</summary>
		public ELandscapeCullingPrecision LandscapeCullingPrecision;
		
	}
	
}
