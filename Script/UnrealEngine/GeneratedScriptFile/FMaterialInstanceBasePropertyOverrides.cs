using System;
namespace UnrealEngine
{
	/// <summary>Properties from the base material that can be overridden in material instances.</summary>
	public partial struct FMaterialInstanceBasePropertyOverrides
	{
		/// <summary>Enables override of the opacity mask clip value.</summary>
		public bool bOverride_OpacityMaskClipValue;
		/// <summary>Enables override of the blend mode.</summary>
		public bool bOverride_BlendMode;
		/// <summary>Enables override of the shading model.</summary>
		public bool bOverride_ShadingModel;
		/// <summary>Enables override of the two sided property.</summary>
		public bool bOverride_DitheredLODTransition;
		/// <summary>Enables override of the two sided property.</summary>
		public bool bOverride_TwoSided;
		/// <summary>If BlendMode is BLEND_Masked, the surface is not rendered where OpacityMask < OpacityMaskClipValue.</summary>
		public float OpacityMaskClipValue;
		/// <summary>The blend mode</summary>
		public EBlendMode BlendMode;
		/// <summary>The shading model</summary>
		public EMaterialShadingModel ShadingModel;
		/// <summary>Indicates that the material should be rendered without backface culling and the normal should be flipped for backfaces.</summary>
		public bool TwoSided;
		/// <summary>Whether the material should support a dithered LOD transition when used with the foliage system.</summary>
		public bool DitheredLODTransition;
		
	}
	
}
