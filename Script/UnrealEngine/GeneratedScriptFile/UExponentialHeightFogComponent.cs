using System;
namespace UnrealEngine
{
	public partial class UExponentialHeightFogComponent:USceneComponent
	{
		public extern void SetFogCutoffDistance(float Value);
		public extern void SetStartDistance(float Value);
		public extern void SetFogMaxOpacity(float Value);
		public extern void SetFogHeightFalloff(float Value);
		public extern void SetDirectionalInscatteringColor(FLinearColor Value);
		public extern void SetDirectionalInscatteringStartDistance(float Value);
		public extern void SetDirectionalInscatteringExponent(float Value);
		public extern void SetInscatteringTextureTint(FLinearColor Value);
		public extern void SetNonDirectionalInscatteringColorDistance(float Value);
		public extern void SetFullyDirectionalInscatteringColorDistance(float Value);
		public extern void SetInscatteringColorCubemap(UTextureCube Value);
		public extern void SetFogInscatteringColor(FLinearColor Value);
		public extern void SetFogDensity(float Value);
		/// <summary>Global density factor.</summary>
		public float FogDensity;
		
		public FLinearColor FogInscatteringColor;
		
		/// <summary>
		/// Cubemap that can be specified for fog color, which is useful to make distant, heavily fogged scene elements match the sky.
		/// When the cubemap is specified, FogInscatteringColor is ignored and Directional inscattering is disabled.
		/// </summary>
		public UTextureCube InscatteringColorCubemap;
		
		/// <summary>Tint color used when InscatteringColorCubemap is specified, for quick edits without having to reimport InscatteringColorCubemap.</summary>
		public FLinearColor InscatteringTextureTint;
		
		/// <summary>Distance at which InscatteringColorCubemap should be used directly for the Inscattering Color.</summary>
		public float FullyDirectionalInscatteringColorDistance;
		
		/// <summary>Distance at which only the average color of InscatteringColorCubemap should be used as Inscattering Color.</summary>
		public float NonDirectionalInscatteringColorDistance;
		
		/// <summary>
		/// Controls the size of the directional inscattering cone, which is used to approximate inscattering from a directional light.
		/// Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.
		/// </summary>
		public float DirectionalInscatteringExponent;
		
		/// <summary>
		/// Controls the start distance from the viewer of the directional inscattering, which is used to approximate inscattering from a directional light.
		/// Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.
		/// </summary>
		public float DirectionalInscatteringStartDistance;
		
		/// <summary>
		/// Controls the color of the directional inscattering, which is used to approximate inscattering from a directional light.
		/// Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.
		/// </summary>
		public FLinearColor DirectionalInscatteringColor;
		
		/// <summary>
		/// Height density factor, controls how the density increases as height decreases.
		/// Smaller values make the visible transition larger.
		/// </summary>
		public float FogHeightFalloff;
		
		/// <summary>
		/// Maximum opacity of the fog.
		/// A value of 1 means the fog can become fully opaque at a distance and replace scene color completely,
		/// A value of 0 means the fog color will not be factored in at all.
		/// </summary>
		public float FogMaxOpacity;
		
		/// <summary>Distance from the camera that the fog will start, in world units.</summary>
		public float StartDistance;
		
		/// <summary>Scene elements past this distance will not have fog applied.  This is useful for excluding skyboxes which already have fog baked in.</summary>
		public float FogCutoffDistance;
		
		
	}
	
}
