using System;
namespace UnrealEngine
{
	public partial struct FLightmassWorldInfoSettings
	{
		/// <summary>
		/// Warning: Setting this to less than 1 will greatly increase build times!
		/// Scale of the level relative to real world scale (1 Unreal Unit = 1 cm).
		/// All scale-dependent Lightmass setting defaults have been tweaked to work well with real world scale,
		/// Any levels with a different scale should use this scale to compensate.
		/// For large levels it can drastically reduce build times to set this to 2 or 4.
		/// </summary>
		public float StaticLightingLevelScale;
		/// <summary>
		/// Number of times light is allowed to bounce off of surfaces, starting from the light source.
		/// 0 is direct lighting only, 1 is one bounce, etc.
		/// Bounce 1 takes the most time to calculate and contributes the most to visual quality, followed by bounce 2.
		/// Successive bounces don't really affect build times, but have a much lower visual impact.
		/// </summary>
		public int NumIndirectLightingBounces;
		/// <summary>
		/// Warning: Setting this higher than 1 will greatly increase build times!
		/// Can be used to increase the GI solver sample counts in order to get higher quality for levels that need it.
		/// It can be useful to reduce IndirectLightingSmoothness somewhat (~.75) when increasing quality to get defined indirect shadows.
		/// Note that this can't affect compression artifacts, UV seams or other texture based artifacts.
		/// </summary>
		public float IndirectLightingQuality;
		/// <summary>
		/// Smoothness factor to apply to indirect lighting.  This is useful in some lighting conditions when Lightmass cannot resolve accurate indirect lighting.
		/// 1 is default smoothness tweaked for a variety of lighting situations.
		/// Higher values like 3 smooth out the indirect lighting more, but at the cost of indirect shadows losing detail.
		/// </summary>
		public float IndirectLightingSmoothness;
		/// <summary>
		/// Represents a constant color light surrounding the upper hemisphere of the level, like a sky.
		/// This light source currently does not get bounced as indirect lighting.
		/// </summary>
		public FColor EnvironmentColor;
		/// <summary>Scales EnvironmentColor to allow independent color and brightness controls.</summary>
		public float EnvironmentIntensity;
		/// <summary>Scales the emissive contribution of all materials in the scene.  Currently disabled and should be removed with mesh area lights.</summary>
		public float EmissiveBoost;
		/// <summary>Scales the diffuse contribution of all materials in the scene.</summary>
		public float DiffuseBoost;
		/// <summary>If true, AmbientOcclusion will be enabled.</summary>
		public bool bUseAmbientOcclusion;
		/// <summary>
		/// Whether to generate textures storing the AO computed by Lightmass.
		/// These can be accessed through the PrecomputedAOMask material node,
		/// Which is useful for blending between material layers on environment assets.
		/// Be sure to set DirectIlluminationOcclusionFraction and IndirectIlluminationOcclusionFraction to 0 if you only want the PrecomputedAOMask!
		/// </summary>
		public bool bGenerateAmbientOcclusionMaterialMask;
		/// <summary>How much of the AO to apply to direct lighting.</summary>
		public float DirectIlluminationOcclusionFraction;
		/// <summary>How much of the AO to apply to indirect lighting.</summary>
		public float IndirectIlluminationOcclusionFraction;
		/// <summary>Higher exponents increase contrast.</summary>
		public float OcclusionExponent;
		/// <summary>Fraction of samples taken that must be occluded in order to reach full occlusion.</summary>
		public float FullyOccludedSamplesFraction;
		/// <summary>Maximum distance for an object to cause occlusion on another object.</summary>
		public float MaxOcclusionDistance;
		/// <summary>If true, override normal direct and indirect lighting with just the exported diffuse term.</summary>
		public bool bVisualizeMaterialDiffuse;
		/// <summary>If true, override normal direct and indirect lighting with just the AO term.</summary>
		public bool bVisualizeAmbientOcclusion;
		/// <summary>
		/// Scales the distances at which volume lighting samples are placed.  Volume lighting samples are computed by Lightmass and are used for GI on movable components.
		/// Using larger scales results in less sample memory usage and reduces Indirect Lighting Cache update times, but less accurate transitions between lighting areas.
		/// </summary>
		public float VolumeLightSamplePlacementScale;
		/// <summary>
		/// Whether to compress lightmap textures.  Disabling lightmap texture compression will reduce artifacts but increase memory and disk size by 4x.
		/// Use caution when disabling this.
		/// </summary>
		public bool bCompressLightmaps;
		
	}
	
}
