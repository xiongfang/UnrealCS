using System;
namespace UnrealEngine
{
	public partial class ULightComponent:ULightComponentBase
	{
		public extern void SetIESTexture(UTextureLightProfile NewValue);
		public extern void SetBloomTint(FColor NewValue);
		public extern void SetBloomThreshold(float NewValue);
		public extern void SetBloomScale(float NewValue);
		public extern void SetEnableLightShaftBloom(bool bNewValue);
		public extern void SetAffectTranslucentLighting(bool bNewValue);
		public extern void SetAffectDynamicIndirectLighting(bool bNewValue);
		public extern void SetLightFunctionDisabledBrightness(float NewValue);
		public extern void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance);
		public extern void SetLightFunctionScale(FVector NewLightFunctionScale);
		public extern void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial);
		public extern void SetTemperature(float NewTemperature);
		/// <summary>Set color of the light</summary>
		public extern void SetLightColor(FLinearColor NewLightColor,bool bSRGB=true);
		public extern void SetIndirectLightingIntensity(float NewIntensity);
		/// <summary>Set intensity of the light</summary>
		public extern void SetIntensity(float NewIntensity);
		/// <summary>
		/// Color temperature in Kelvin of the blackbody illuminant.
		/// White (D65) is 6500K.
		/// </summary>
		public float Temperature;
		
		public float MaxDrawDistance;
		
		public float MaxDistanceFadeRange;
		
		/// <summary>false: use white (D65) as illuminant.</summary>
		public bool bUseTemperature;
		
		/// <summary>Legacy shadowmap channel from the lighting build, now stored in FLightComponentMapBuildData.</summary>
		public int ShadowMapChannel;
		
		/// <summary>Min roughness effective for this light. Used for softening specular highlights.</summary>
		public float MinRoughness;
		
		/// <summary>
		/// Scales the resolution of shadowmaps used to shadow this light.  By default shadowmap resolution is chosen based on screen size of the caster.
		/// Note: shadowmap resolution is still clamped by 'r.Shadow.MaxResolution'
		/// </summary>
		public float ShadowResolutionScale;
		
		/// <summary>
		/// Controls how accurate self shadowing of whole scene shadows from this light are.
		/// At 0, shadows will start at the their caster surface, but there will be many self shadowing artifacts.
		/// larger values, shadows will start further from their caster, and there won't be self shadowing artifacts but object might appear to fly.
		/// around 0.5 seems to be a good tradeoff. This also affects the soft transition of shadows
		/// </summary>
		public float ShadowBias;
		
		/// <summary>Amount to sharpen shadow filtering</summary>
		public float ShadowSharpen;
		
		/// <summary>Length of screen space ray trace for sharp contact shadows. Zero is disabled.</summary>
		public float ContactShadowLength;
		
		public bool InverseSquaredFalloff;
		
		/// <summary>Whether the light is allowed to cast dynamic shadows from translucency.</summary>
		public bool CastTranslucentShadows;
		
		/// <summary>
		/// Whether the light should only cast shadows from components marked as bCastCinematicShadows.
		/// This is useful for setting up cinematic Movable spotlights aimed at characters and avoiding the shadow depth rendering costs of the background.
		/// Note: this only works with dynamic shadow maps, not with static shadowing or Ray Traced Distance Field shadows.
		/// </summary>
		public bool bCastShadowsFromCinematicObjectsOnly;
		
		/// <summary>Whether the light should be injected into the Light Propagation Volume</summary>
		public bool bAffectDynamicIndirectLighting;
		
		/// <summary>
		/// Channels that this light should affect.
		/// These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
		/// </summary>
		public FLightingChannels LightingChannels;
		
		/// <summary>
		/// The light function material to be applied to this light.
		/// Note that only non-lightmapped lights (UseDirectLightMap=False) can have a light function.
		/// </summary>
		public UMaterialInterface LightFunctionMaterial;
		
		/// <summary>Scales the light function projection.  X and Y scale in the directions perpendicular to the light's direction, Z scales along the light direction.</summary>
		public FVector LightFunctionScale;
		
		/// <summary>IES texture (light profiles from real world measured data)</summary>
		public UTextureLightProfile IESTexture;
		
		/// <summary>true: take light brightness from IES profile, false: use the light brightness - the maximum light in one direction is used to define no masking. Use with InverseSquareFalloff. Will be disabled if a valid IES profile texture is not supplied.</summary>
		public bool bUseIESBrightness;
		
		/// <summary>Global scale for IES brightness contribution. Only available when "Use IES Brightness" is selected, and a valid IES profile texture is set</summary>
		public float IESBrightnessScale;
		
		/// <summary>
		/// Distance at which the light function should be completely faded to DisabledBrightness.
		/// This is useful for hiding aliasing from light functions applied in the distance.
		/// </summary>
		public float LightFunctionFadeDistance;
		
		/// <summary>
		/// Brightness factor applied to the light when the light function is specified but disabled, for example in scene captures that use SceneCapView_LitNoShadows.
		/// This should be set to the average brightness of the light function material's emissive input, which should be between 0 and 1.
		/// </summary>
		public float DisabledBrightness;
		
		/// <summary>
		/// Whether to render light shaft bloom from this light.
		/// For directional lights, the color around the light direction will be blurred radially and added back to the scene.
		/// for point lights, the color on pixels closer than the light's SourceRadius will be blurred radially and added back to the scene.
		/// </summary>
		public bool bEnableLightShaftBloom;
		
		/// <summary>Scales the additive color.</summary>
		public float BloomScale;
		
		/// <summary>Scene color must be larger than this to create bloom in the light shafts.</summary>
		public float BloomThreshold;
		
		/// <summary>Multiplies against scene color to create the bloom color.</summary>
		public FColor BloomTint;
		
		/// <summary>
		/// Whether to use ray traced distance field area shadows.  The project setting bGenerateMeshDistanceFields must be enabled for this to have effect.
		/// Distance field shadows support area lights so they create soft shadows with sharp contacts.
		/// They have less aliasing artifacts than standard shadowmaps, but inherit all the limitations of distance field representations (only uniform scale, no deformation).
		/// These shadows have a low per-object cost (and don't depend on triangle count) so they are effective for distant shadows from a dynamic sun.
		/// </summary>
		public bool bUseRayTracedDistanceFieldShadows;
		
		/// <summary>
		/// Controls how large of an offset ray traced shadows have from the receiving surface as the camera gets further away.
		/// This can be useful to hide self-shadowing artifacts from low resolution distance fields on huge static meshes.
		/// </summary>
		public float RayStartOffsetDepthScale;
		
		
	}
	
}
