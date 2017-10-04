using System;
namespace UnrealEngine
{
	/// <summary>UMaterial interface settings for Lightmass</summary>
	public partial struct FLightmassMaterialInterfaceSettings
	{
		/// <summary>If true, forces translucency to cast static shadows as if the material were masked.</summary>
		public bool bCastShadowAsMasked;
		/// <summary>Scales the emissive contribution of this material to static lighting.</summary>
		public float EmissiveBoost;
		/// <summary>Scales the diffuse contribution of this material to static lighting.</summary>
		public float DiffuseBoost;
		/// <summary>
		/// Scales the resolution that this material's attributes were exported at.
		/// This is useful for increasing material resolution when details are needed.
		/// </summary>
		public float ExportResolutionScale;
		/// <summary>If true, override the bCastShadowAsMasked setting of the parent material.</summary>
		public bool bOverrideCastShadowAsMasked;
		/// <summary>If true, override the emissive boost setting of the parent material.</summary>
		public bool bOverrideEmissiveBoost;
		/// <summary>If true, override the diffuse boost setting of the parent material.</summary>
		public bool bOverrideDiffuseBoost;
		/// <summary>If true, override the export resolution scale setting of the parent material.</summary>
		public bool bOverrideExportResolutionScale;
		
	}
	
}
