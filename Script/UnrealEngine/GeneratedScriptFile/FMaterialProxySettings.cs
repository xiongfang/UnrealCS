using System;
namespace UnrealEngine
{
	public partial struct FMaterialProxySettings
	{
		/// <summary>Size of generated BaseColor map</summary>
		public FIntPoint TextureSize;
		public ETextureSizingType TextureSizingType;
		public float GutterSpace;
		/// <summary>Whether to generate normal map</summary>
		public bool bNormalMap;
		/// <summary>Whether to generate metallic map</summary>
		public bool bMetallicMap;
		/// <summary>Metallic constant</summary>
		public float MetallicConstant;
		/// <summary>Whether to generate roughness map</summary>
		public bool bRoughnessMap;
		/// <summary>Roughness constant</summary>
		public float RoughnessConstant;
		/// <summary>Whether to generate specular map</summary>
		public bool bSpecularMap;
		/// <summary>Specular constant</summary>
		public float SpecularConstant;
		/// <summary>Whether to generate emissive map</summary>
		public bool bEmissiveMap;
		/// <summary>Whether to generate opacity map</summary>
		public bool bOpacityMap;
		/// <summary>Override diffuse map size</summary>
		public FIntPoint DiffuseTextureSize;
		/// <summary>Override normal map size</summary>
		public FIntPoint NormalTextureSize;
		/// <summary>Override metallic map size</summary>
		public FIntPoint MetallicTextureSize;
		/// <summary>Override roughness map size</summary>
		public FIntPoint RoughnessTextureSize;
		/// <summary>Override specular map size</summary>
		public FIntPoint SpecularTextureSize;
		/// <summary>Override emissive map size</summary>
		public FIntPoint EmissiveTextureSize;
		/// <summary>Override opacity map size</summary>
		public FIntPoint OpacityTextureSize;
		public EMaterialMergeType MaterialMergeType;
		
	}
	
}
