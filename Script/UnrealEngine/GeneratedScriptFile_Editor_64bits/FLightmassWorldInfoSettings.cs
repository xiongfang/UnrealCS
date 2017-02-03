#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=68)]
	public partial struct FLightmassWorldInfoSettings
	{
		/// <summary>
		/// Warning: Setting this to less than 1 will greatly increase build times!
		/// Scale of the level relative to real world scale (1 Unreal Unit = 1 cm).
		/// All scale-dependent Lightmass setting defaults have been tweaked to work well with real world scale,
		/// Any levels with a different scale should use this scale to compensate.
		/// For large levels it can drastically reduce build times to set this to 2 or 4.
		/// </summary>
		[FieldOffset(0)]
		public float StaticLightingLevelScale;
		/// <summary>
		/// Number of times light is allowed to bounce off of surfaces, starting from the light source.
		/// 0 is direct lighting only, 1 is one bounce, etc.
		/// Bounce 1 takes the most time to calculate and contributes the most to visual quality, followed by bounce 2.
		/// Successive bounces don't really affect build times, but have a much lower visual impact.
		/// </summary>
		[FieldOffset(4)]
		public int NumIndirectLightingBounces;
		/// <summary>
		/// Warning: Setting this higher than 1 will greatly increase build times!
		/// Can be used to increase the GI solver sample counts in order to get higher quality for levels that need it.
		/// It can be useful to reduce IndirectLightingSmoothness somewhat (~.75) when increasing quality to get defined indirect shadows.
		/// Note that this can't affect compression artifacts, UV seams or other texture based artifacts.
		/// </summary>
		[FieldOffset(8)]
		public float IndirectLightingQuality;
		/// <summary>
		/// Smoothness factor to apply to indirect lighting.  This is useful in some lighting conditions when Lightmass cannot resolve accurate indirect lighting.
		/// 1 is default smoothness tweaked for a variety of lighting situations.
		/// Higher values like 3 smooth out the indirect lighting more, but at the cost of indirect shadows losing detail.
		/// </summary>
		[FieldOffset(12)]
		public float IndirectLightingSmoothness;
		/// <summary>
		/// Represents a constant color light surrounding the upper hemisphere of the level, like a sky.
		/// This light source currently does not get bounced as indirect lighting.
		/// </summary>
		[FieldOffset(16)]
		public FColor EnvironmentColor;
		/// <summary>Scales EnvironmentColor to allow independent color and brightness controls.</summary>
		[FieldOffset(20)]
		public float EnvironmentIntensity;
		/// <summary>Scales the emissive contribution of all materials in the scene.  Currently disabled and should be removed with mesh area lights.</summary>
		[FieldOffset(24)]
		public float EmissiveBoost;
		/// <summary>Scales the diffuse contribution of all materials in the scene.</summary>
		[FieldOffset(28)]
		public float DiffuseBoost;
		/// <summary>If true, AmbientOcclusion will be enabled.</summary>
		public bool bUseAmbientOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 1); } }}
			
		}
		/// <summary>
		/// Whether to generate textures storing the AO computed by Lightmass.
		/// These can be accessed through the PrecomputedAOMask material node,
		/// Which is useful for blending between material layers on environment assets.
		/// Be sure to set DirectIlluminationOcclusionFraction and IndirectIlluminationOcclusionFraction to 0 if you only want the PrecomputedAOMask!
		/// </summary>
		public bool bGenerateAmbientOcclusionMaterialMask
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 2, 2); } }}
			
		}
		/// <summary>How much of the AO to apply to direct lighting.</summary>
		[FieldOffset(36)]
		public float DirectIlluminationOcclusionFraction;
		/// <summary>How much of the AO to apply to indirect lighting.</summary>
		[FieldOffset(40)]
		public float IndirectIlluminationOcclusionFraction;
		/// <summary>Higher exponents increase contrast.</summary>
		[FieldOffset(44)]
		public float OcclusionExponent;
		/// <summary>Fraction of samples taken that must be occluded in order to reach full occlusion.</summary>
		[FieldOffset(48)]
		public float FullyOccludedSamplesFraction;
		/// <summary>Maximum distance for an object to cause occlusion on another object.</summary>
		[FieldOffset(52)]
		public float MaxOcclusionDistance;
		/// <summary>If true, override normal direct and indirect lighting with just the exported diffuse term.</summary>
		public bool bVisualizeMaterialDiffuse
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If true, override normal direct and indirect lighting with just the AO term.</summary>
		public bool bVisualizeAmbientOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 2, 2); } }}
			
		}
		/// <summary>
		/// Scales the distances at which volume lighting samples are placed.  Volume lighting samples are computed by Lightmass and are used for GI on movable components.
		/// Using larger scales results in less sample memory usage and reduces Indirect Lighting Cache update times, but less accurate transitions between lighting areas.
		/// </summary>
		[FieldOffset(60)]
		public float VolumeLightSamplePlacementScale;
		/// <summary>
		/// Whether to compress lightmap textures.  Disabling lightmap texture compression will reduce artifacts but increase memory and disk size by 4x.
		/// Use caution when disabling this.
		/// </summary>
		public bool bCompressLightmaps
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 64, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 64, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
