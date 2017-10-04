using System;
namespace UnrealEngine
{
	public partial class UTextureLightProfile:UTexture2D
	{
		/// <summary>Light brightness in Lumens, imported from IES profile, <= 0 if the profile is used for masking only. Use with InverseSquareFalloff.</summary>
		public float Brightness;
		
		/// <summary>Multiplier to map texture value to result to integrate over the sphere to 1.0f</summary>
		public float TextureMultiplier;
		
		
	}
	
}
