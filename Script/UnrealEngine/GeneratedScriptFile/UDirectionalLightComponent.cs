using System;
namespace UnrealEngine
{
	public partial class UDirectionalLightComponent:ULightComponent
	{
		public extern void SetLightShaftOverrideDirection(FVector NewValue);
		public extern void SetOcclusionMaskDarkness(float NewValue);
		public extern void SetEnableLightShaftOcclusion(bool bNewValue);
		public extern void SetShadowDistanceFadeoutFraction(float NewValue);
		public extern void SetCascadeTransitionFraction(float NewValue);
		public extern void SetCascadeDistributionExponent(float NewValue);
		public extern void SetDynamicShadowCascades(int NewValue);
		public extern void SetDynamicShadowDistanceStationaryLight(float NewValue);
		public extern void SetDynamicShadowDistanceMovableLight(float NewValue);
		/// <summary>Whether to occlude fog and atmosphere inscattering with screenspace blurred occlusion from this light.</summary>
		public bool bEnableLightShaftOcclusion;
		
		/// <summary>Controls how dark the occlusion masking is, a value of 1 results in no darkening term.</summary>
		public float OcclusionMaskDarkness;
		
		/// <summary>Everything closer to the camera than this distance will occlude light shafts.</summary>
		public float OcclusionDepthRange;
		
		/// <summary>
		/// Can be used to make light shafts come from somewhere other than the light's actual direction.
		/// This will only be used when non-zero.  It does not have to be normalized.
		/// </summary>
		public FVector LightShaftOverrideDirection;
		
		public float WholeSceneDynamicShadowRadius;
		
		/// <summary>
		/// How far Cascaded Shadow Map dynamic shadows will cover for a movable light, measured from the camera.
		/// A value of 0 disables the dynamic shadow.
		/// </summary>
		public float DynamicShadowDistanceMovableLight;
		
		/// <summary>
		/// How far Cascaded Shadow Map dynamic shadows will cover for a stationary light, measured from the camera.
		/// A value of 0 disables the dynamic shadow.
		/// </summary>
		public float DynamicShadowDistanceStationaryLight;
		
		/// <summary>
		/// Number of cascades to split the view frustum into for the whole scene dynamic shadow.
		/// More cascades result in better shadow resolution, but adds significant rendering cost.
		/// </summary>
		public int DynamicShadowCascades;
		
		/// <summary>
		/// Controls whether the cascades are distributed closer to the camera (larger exponent) or further from the camera (smaller exponent).
		/// An exponent of 1 means that cascade transitions will happen at a distance proportional to their resolution.
		/// </summary>
		public float CascadeDistributionExponent;
		
		/// <summary>
		/// Proportion of the fade region between cascades.
		/// Pixels within the fade region of two cascades have their shadows blended to avoid hard transitions between quality levels.
		/// A value of zero eliminates the fade region, creating hard transitions.
		/// Higher values increase the size of the fade region, creating a more gradual transition between cascades.
		/// The value is expressed as a percentage proportion (i.e. 0.1 = 10% overlap).
		/// Ideal values are the smallest possible which still hide the transition.
		/// An increased fade region size causes an increase in shadow rendering cost.
		/// </summary>
		public float CascadeTransitionFraction;
		
		/// <summary>
		/// Controls the size of the fade out region at the far extent of the dynamic shadow's influence.
		/// This is specified as a fraction of DynamicShadowDistance.
		/// </summary>
		public float ShadowDistanceFadeoutFraction;
		
		/// <summary>
		/// Stationary lights only: Whether to use per-object inset shadows for movable components, even though cascaded shadow maps are enabled.
		/// This allows dynamic objects to have a shadow even when they are outside of the cascaded shadow map, which is important when DynamicShadowDistanceStationaryLight is small.
		/// If DynamicShadowDistanceStationaryLight is large (currently > 8000), this will be forced off.
		/// Disabling this can reduce shadowing cost significantly with many movable objects.
		/// </summary>
		public bool bUseInsetShadowsForMovableObjects;
		
		/// <summary>0: no DistantShadowCascades, otherwise the count of cascades between WholeSceneDynamicShadowRadius and DistantShadowDistance that are covered by distant shadow cascades.</summary>
		public int FarShadowCascadeCount;
		
		/// <summary>Distance at which the far shadow cascade should end.  Far shadows will cover the range between 'Dynamic Shadow Distance' and this distance.</summary>
		public float FarShadowDistance;
		
		/// <summary>Distance at which the ray traced shadow cascade should end.  Distance field shadows will cover the range between 'Dynamic Shadow Distance' this distance.</summary>
		public float DistanceFieldShadowDistance;
		
		/// <summary>
		/// Light source angle in degrees, used for dynamic shadowing methods.
		/// Currently only Ray Traced Distance Field shadows and Capsule shadows support area shadows, and therefore make use of LightSourceAngle.
		/// </summary>
		public float LightSourceAngle;
		
		/// <summary>Determines how far shadows can be cast, in world units.  Larger values increase the shadowing cost.</summary>
		public float TraceDistance;
		
		/// <summary>The Lightmass settings for this object.</summary>
		public FLightmassDirectionalLightSettings LightmassSettings;
		
		/// <summary>Whether the light should cast modulated shadows from dynamic objects (mobile only).  Also requires Cast Shadows to be set to True.</summary>
		public bool bCastModulatedShadows;
		
		/// <summary>Color to modulate against the scene color when rendering modulated shadows. (mobile only)</summary>
		public FColor ModulatedShadowColor;
		
		public bool bUsedAsAtmosphereSunLight;
		
		
	}
	
}
