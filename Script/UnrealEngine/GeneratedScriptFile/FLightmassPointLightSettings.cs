using System;
namespace UnrealEngine
{
	/// <summary>Point/spot settings for Lightmass</summary>
	public partial struct FLightmassPointLightSettings
	{
		/// <summary>0 will be completely desaturated, 1 will be unchanged</summary>
		public float IndirectLightingSaturation;
		/// <summary>Controls the falloff of shadow penumbras</summary>
		public float ShadowExponent;
		/// <summary>
		/// Whether to use area shadows for stationary light precomputed shadowmaps.
		/// Area shadows get softer the further they are from shadow casters, but require higher lightmap resolution to get the same quality where the shadow is sharp.
		/// </summary>
		public bool bUseAreaShadowsForStationaryLight;
		
	}
	
}
