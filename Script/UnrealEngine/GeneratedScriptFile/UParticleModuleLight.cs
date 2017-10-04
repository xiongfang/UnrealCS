using System;
namespace UnrealEngine
{
	public partial class UParticleModuleLight:UParticleModuleLightBase
	{
		/// <summary>Whether to use physically based inverse squared falloff from the light.  If unchecked, the LightExponent distribution will be used instead.</summary>
		public bool bUseInverseSquaredFalloff;
		
		/// <summary>
		/// Whether lights from this module should affect translucency.
		/// Use with caution.  Modules enabling this should only make a few particle lights at most, and the smaller they are, the less they will cost.
		/// </summary>
		public bool bAffectsTranslucency;
		
		/// <summary>
		/// Will draw wireframe spheres to preview the light radius if enabled.
		/// Note: this is intended for previewing and the value will not be saved, it will always revert to disabled.
		/// </summary>
		public bool bPreviewLightRadius;
		
		/// <summary>Fraction of particles in this emitter to create lights on.</summary>
		public float SpawnFraction;
		
		/// <summary>Scale that is applied to the particle's color to calculate the light's color, and can be setup as a curve over the particle's lifetime.</summary>
		public FRawDistributionVector ColorScaleOverLife;
		
		/// <summary>Brightness scale for the light, which can be setup as a curve over the particle's lifetime.</summary>
		public FRawDistributionFloat BrightnessOverLife;
		
		/// <summary>Scales the particle's radius, to calculate the light's radius.</summary>
		public FRawDistributionFloat RadiusScale;
		
		/// <summary>Provides the light's exponent when inverse squared falloff is disabled.</summary>
		public FRawDistributionFloat LightExponent;
		
		/// <summary>
		/// Channels that this light should affect.
		/// Only affect high quality lights
		/// These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
		/// </summary>
		public FLightingChannels LightingChannels;
		
		public bool bHighQualityLights;
		
		public bool bShadowCastingLights;
		
		
	}
	
}
