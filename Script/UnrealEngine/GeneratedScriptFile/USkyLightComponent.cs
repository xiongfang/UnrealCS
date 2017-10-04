using System;
namespace UnrealEngine
{
	public partial class USkyLightComponent:ULightComponentBase
	{
		/// <summary>
		/// Recaptures the scene for the skylight.
		/// This is useful for making sure the sky light is up to date after changing something in the world that it would capture.
		/// Warning: this is very costly and will definitely cause a hitch.
		/// </summary>
		public extern void RecaptureSky();
		public extern void SetMinOcclusion(float InMinOcclusion);
		public extern void SetOcclusionTint(FColor InTint);
		/// <summary>
		/// Creates sky lighting from a blend between two cubemaps, which is only valid when SourceType is set to SpecifiedCubemap.
		/// This can be used to seamlessly transition sky lighting between different times of day.
		/// The caller should continue to update the blend until BlendFraction is 0 or 1 to reduce rendering cost.
		/// The caller is responsible for avoiding pops due to changing the source or destination.
		/// </summary>
		public extern void SetCubemapBlend(UTextureCube SourceCubemap,UTextureCube DestinationCubemap,float InBlendFraction);
		/// <summary>Sets the cubemap used when SourceType is set to SpecifiedCubemap, and causes a skylight update on the next tick.</summary>
		public extern void SetCubemap(UTextureCube NewCubemap);
		/// <summary>Set color of the light</summary>
		public extern void SetLightColor(FLinearColor NewLightColor);
		public extern void SetIndirectLightingIntensity(float NewIntensity);
		public extern void SetIntensity(float NewIntensity);
		/// <summary>Indicates where to get the light contribution from.</summary>
		public ESkyLightSourceType SourceType;
		
		/// <summary>Cubemap to use for sky lighting if SourceType is set to SLS_SpecifiedCubemap.</summary>
		public UTextureCube Cubemap;
		
		/// <summary>Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap.</summary>
		public float SourceCubemapAngle;
		
		/// <summary>Maximum resolution for the very top processed cubemap mip. Must be a power of 2.</summary>
		public int CubemapResolution;
		
		/// <summary>
		/// Distance from the sky light at which any geometry should be treated as part of the sky.
		/// This is also used by reflection captures, so update reflection captures to see the impact.
		/// </summary>
		public float SkyDistanceThreshold;
		
		/// <summary>
		/// Whether all distant lighting from the lower hemisphere should be set to LowerHemisphereColor.
		/// Enabling this is accurate when lighting a scene on a planet where the ground blocks the sky,
		/// However disabling it can be useful to approximate skylight bounce lighting (eg Movable light).
		/// </summary>
		public bool bLowerHemisphereIsBlack;
		
		public FLinearColor LowerHemisphereColor;
		
		/// <summary>
		/// Max distance that the occlusion of one point will affect another.
		/// Higher values increase the cost of Distance Field AO exponentially.
		/// </summary>
		public float OcclusionMaxDistance;
		
		/// <summary>Contrast S-curve applied to the computed AO.  A value of 0 means no contrast increase, 1 is a significant contrast increase.</summary>
		public float Contrast;
		
		/// <summary>Controls the darkest that a fully occluded area can get.</summary>
		public float MinOcclusion;
		
		/// <summary>Tint color on occluded areas, artistic control.</summary>
		public FColor OcclusionTint;
		
		public UTextureCube BlendDestinationCubemap;
		
		
	}
	
}
