using System;
namespace UnrealEngine
{
	/// <summary>Directional light settings for Lightmass</summary>
	public partial struct FLightmassDirectionalLightSettings
	{
		/// <summary>Angle that the directional light's emissive surface extends relative to a receiver, affects penumbra sizes.</summary>
		public float LightSourceAngle;
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
