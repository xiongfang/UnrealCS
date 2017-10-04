using System;
namespace UnrealEngine
{
	/// <summary>Use FMaterialProxySettings instead</summary>
	public partial struct FMaterialSimplificationSettings
	{
		/// <summary>Size of generated BaseColor map</summary>
		public FIntPoint BaseColorMapSize;
		/// <summary>Whether to generate normal map</summary>
		public bool bNormalMap;
		/// <summary>Size of generated specular map</summary>
		public FIntPoint NormalMapSize;
		/// <summary>Metallic constant</summary>
		public float MetallicConstant;
		/// <summary>Whether to generate metallic map</summary>
		public bool bMetallicMap;
		/// <summary>Size of generated metallic map</summary>
		public FIntPoint MetallicMapSize;
		/// <summary>Roughness constant</summary>
		public float RoughnessConstant;
		/// <summary>Whether to generate roughness map</summary>
		public bool bRoughnessMap;
		/// <summary>Size of generated roughness map</summary>
		public FIntPoint RoughnessMapSize;
		/// <summary>Specular constant</summary>
		public float SpecularConstant;
		/// <summary>Whether to generate specular map</summary>
		public bool bSpecularMap;
		/// <summary>Size of generated specular map</summary>
		public FIntPoint SpecularMapSize;
		
	}
	
}
