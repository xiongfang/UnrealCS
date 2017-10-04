using System;
namespace UnrealEngine
{
	/// <summary>
	/// To be able to use struct PostProcessSettings. // Each property consists of a bool to enable it (by default off),
	/// // the variable declaration and further down the default value for it.
	/// // The comment should include the meaning and usable range.
	/// </summary>
	public partial struct FPostProcessSettings
	{
		/// <summary>first all bOverride_... as they get grouped together into bitfields</summary>
		public bool bOverride_WhiteTemp;
		public bool bOverride_WhiteTint;
		/// <summary>Color Correction controls</summary>
		public bool bOverride_ColorSaturation;
		public bool bOverride_ColorContrast;
		public bool bOverride_ColorGamma;
		public bool bOverride_ColorGain;
		public bool bOverride_ColorOffset;
		public bool bOverride_ColorSaturationShadows;
		public bool bOverride_ColorContrastShadows;
		public bool bOverride_ColorGammaShadows;
		public bool bOverride_ColorGainShadows;
		public bool bOverride_ColorOffsetShadows;
		public bool bOverride_ColorSaturationMidtones;
		public bool bOverride_ColorContrastMidtones;
		public bool bOverride_ColorGammaMidtones;
		public bool bOverride_ColorGainMidtones;
		public bool bOverride_ColorOffsetMidtones;
		public bool bOverride_ColorSaturationHighlights;
		public bool bOverride_ColorContrastHighlights;
		public bool bOverride_ColorGammaHighlights;
		public bool bOverride_ColorGainHighlights;
		public bool bOverride_ColorOffsetHighlights;
		public bool bOverride_ColorCorrectionShadowsMax;
		public bool bOverride_ColorCorrectionHighlightsMin;
		public bool bOverride_FilmWhitePoint;
		public bool bOverride_FilmSaturation;
		public bool bOverride_FilmChannelMixerRed;
		public bool bOverride_FilmChannelMixerGreen;
		public bool bOverride_FilmChannelMixerBlue;
		public bool bOverride_FilmContrast;
		public bool bOverride_FilmDynamicRange;
		public bool bOverride_FilmHealAmount;
		public bool bOverride_FilmToeAmount;
		public bool bOverride_FilmShadowTint;
		public bool bOverride_FilmShadowTintBlend;
		public bool bOverride_FilmShadowTintAmount;
		public bool bOverride_FilmSlope;
		public bool bOverride_FilmToe;
		public bool bOverride_FilmShoulder;
		public bool bOverride_FilmBlackClip;
		public bool bOverride_FilmWhiteClip;
		public bool bOverride_SceneColorTint;
		public bool bOverride_SceneFringeIntensity;
		public bool bOverride_AmbientCubemapTint;
		public bool bOverride_AmbientCubemapIntensity;
		public bool bOverride_BloomIntensity;
		public bool bOverride_BloomThreshold;
		public bool bOverride_Bloom1Tint;
		public bool bOverride_Bloom1Size;
		public bool bOverride_Bloom2Size;
		public bool bOverride_Bloom2Tint;
		public bool bOverride_Bloom3Tint;
		public bool bOverride_Bloom3Size;
		public bool bOverride_Bloom4Tint;
		public bool bOverride_Bloom4Size;
		public bool bOverride_Bloom5Tint;
		public bool bOverride_Bloom5Size;
		public bool bOverride_Bloom6Tint;
		public bool bOverride_Bloom6Size;
		public bool bOverride_BloomSizeScale;
		public bool bOverride_BloomDirtMaskIntensity;
		public bool bOverride_BloomDirtMaskTint;
		public bool bOverride_BloomDirtMask;
		public bool bOverride_AutoExposureMethod;
		public bool bOverride_AutoExposureLowPercent;
		public bool bOverride_AutoExposureHighPercent;
		public bool bOverride_AutoExposureMinBrightness;
		public bool bOverride_AutoExposureMaxBrightness;
		public bool bOverride_AutoExposureSpeedUp;
		public bool bOverride_AutoExposureSpeedDown;
		public bool bOverride_AutoExposureBias;
		public bool bOverride_HistogramLogMin;
		public bool bOverride_HistogramLogMax;
		public bool bOverride_LensFlareIntensity;
		public bool bOverride_LensFlareTint;
		public bool bOverride_LensFlareTints;
		public bool bOverride_LensFlareBokehSize;
		public bool bOverride_LensFlareBokehShape;
		public bool bOverride_LensFlareThreshold;
		public bool bOverride_VignetteIntensity;
		public bool bOverride_GrainIntensity;
		public bool bOverride_GrainJitter;
		public bool bOverride_AmbientOcclusionIntensity;
		public bool bOverride_AmbientOcclusionStaticFraction;
		public bool bOverride_AmbientOcclusionRadius;
		public bool bOverride_AmbientOcclusionFadeDistance;
		public bool bOverride_AmbientOcclusionFadeRadius;
		public bool bOverride_AmbientOcclusionDistance;
		public bool bOverride_AmbientOcclusionRadiusInWS;
		public bool bOverride_AmbientOcclusionPower;
		public bool bOverride_AmbientOcclusionBias;
		public bool bOverride_AmbientOcclusionQuality;
		public bool bOverride_AmbientOcclusionMipBlend;
		public bool bOverride_AmbientOcclusionMipScale;
		public bool bOverride_AmbientOcclusionMipThreshold;
		public bool bOverride_LPVIntensity;
		public bool bOverride_LPVDirectionalOcclusionIntensity;
		public bool bOverride_LPVDirectionalOcclusionRadius;
		public bool bOverride_LPVDiffuseOcclusionExponent;
		public bool bOverride_LPVSpecularOcclusionExponent;
		public bool bOverride_LPVDiffuseOcclusionIntensity;
		public bool bOverride_LPVSpecularOcclusionIntensity;
		public bool bOverride_LPVSize;
		public bool bOverride_LPVSecondaryOcclusionIntensity;
		public bool bOverride_LPVSecondaryBounceIntensity;
		public bool bOverride_LPVGeometryVolumeBias;
		public bool bOverride_LPVVplInjectionBias;
		public bool bOverride_LPVEmissiveInjectionIntensity;
		public bool bOverride_IndirectLightingColor;
		public bool bOverride_IndirectLightingIntensity;
		public bool bOverride_ColorGradingIntensity;
		public bool bOverride_ColorGradingLUT;
		public bool bOverride_DepthOfFieldFocalDistance;
		public bool bOverride_DepthOfFieldFstop;
		public bool bOverride_DepthOfFieldSensorWidth;
		public bool bOverride_DepthOfFieldDepthBlurRadius;
		public bool bOverride_DepthOfFieldDepthBlurAmount;
		public bool bOverride_DepthOfFieldFocalRegion;
		public bool bOverride_DepthOfFieldNearTransitionRegion;
		public bool bOverride_DepthOfFieldFarTransitionRegion;
		public bool bOverride_DepthOfFieldScale;
		public bool bOverride_DepthOfFieldMaxBokehSize;
		public bool bOverride_DepthOfFieldNearBlurSize;
		public bool bOverride_DepthOfFieldFarBlurSize;
		public bool bOverride_DepthOfFieldMethod;
		public bool bOverride_MobileHQGaussian;
		public bool bOverride_DepthOfFieldBokehShape;
		public bool bOverride_DepthOfFieldOcclusion;
		public bool bOverride_DepthOfFieldColorThreshold;
		public bool bOverride_DepthOfFieldSizeThreshold;
		public bool bOverride_DepthOfFieldSkyFocusDistance;
		public bool bOverride_DepthOfFieldVignetteSize;
		public bool bOverride_MotionBlurAmount;
		public bool bOverride_MotionBlurMax;
		public bool bOverride_MotionBlurPerObjectSize;
		public bool bOverride_ScreenPercentage;
		public bool bOverride_ScreenSpaceReflectionIntensity;
		public bool bOverride_ScreenSpaceReflectionQuality;
		public bool bOverride_ScreenSpaceReflectionMaxRoughness;
		public bool bOverride_ScreenSpaceReflectionRoughnessScale;
		public float WhiteTemp;
		public float WhiteTint;
		/// <summary>Color Correction controls</summary>
		public FVector4 ColorSaturation;
		public FVector4 ColorContrast;
		public FVector4 ColorGamma;
		public FVector4 ColorGain;
		public FVector4 ColorOffset;
		public FVector4 ColorSaturationShadows;
		public FVector4 ColorContrastShadows;
		public FVector4 ColorGammaShadows;
		public FVector4 ColorGainShadows;
		public FVector4 ColorOffsetShadows;
		public float ColorCorrectionShadowsMax;
		public FVector4 ColorSaturationMidtones;
		public FVector4 ColorContrastMidtones;
		public FVector4 ColorGammaMidtones;
		public FVector4 ColorGainMidtones;
		public FVector4 ColorOffsetMidtones;
		public FVector4 ColorSaturationHighlights;
		public FVector4 ColorContrastHighlights;
		public FVector4 ColorGammaHighlights;
		public FVector4 ColorGainHighlights;
		public FVector4 ColorOffsetHighlights;
		public float ColorCorrectionHighlightsMin;
		public FLinearColor FilmWhitePoint;
		public FLinearColor FilmShadowTint;
		public float FilmShadowTintBlend;
		public float FilmShadowTintAmount;
		public float FilmSaturation;
		public FLinearColor FilmChannelMixerRed;
		public FLinearColor FilmChannelMixerGreen;
		public FLinearColor FilmChannelMixerBlue;
		public float FilmContrast;
		public float FilmToeAmount;
		public float FilmHealAmount;
		public float FilmDynamicRange;
		public float FilmSlope;
		public float FilmToe;
		public float FilmShoulder;
		public float FilmBlackClip;
		public float FilmWhiteClip;
		/// <summary>Scene tint color</summary>
		public FLinearColor SceneColorTint;
		/// <summary>in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners.</summary>
		public float SceneFringeIntensity;
		/// <summary>Multiplier for all bloom contributions >=0: off, 1(default), >1 brighter</summary>
		public float BloomIntensity;
		/// <summary>
		/// minimum brightness the bloom starts having effect
		/// -1:all pixels affect bloom equally (physically correct, faster as a threshold pass is omitted), 0:all pixels affect bloom brights more, 1(default), >1 brighter
		/// </summary>
		public float BloomThreshold;
		/// <summary>Scale for all bloom sizes</summary>
		public float BloomSizeScale;
		/// <summary>
		/// Diameter size for the Bloom1 in percent of the screen width
		/// (is done in 1/2 resolution, larger values cost more performance, good for high frequency details)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom1Size;
		/// <summary>
		/// Diameter size for Bloom2 in percent of the screen width
		/// (is done in 1/4 resolution, larger values cost more performance)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom2Size;
		/// <summary>
		/// Diameter size for Bloom3 in percent of the screen width
		/// (is done in 1/8 resolution, larger values cost more performance)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom3Size;
		/// <summary>
		/// Diameter size for Bloom4 in percent of the screen width
		/// (is done in 1/16 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom4Size;
		/// <summary>
		/// Diameter size for Bloom5 in percent of the screen width
		/// (is done in 1/32 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom5Size;
		/// <summary>
		/// Diameter size for Bloom6 in percent of the screen width
		/// (is done in 1/64 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		public float Bloom6Size;
		/// <summary>Bloom1 tint color</summary>
		public FLinearColor Bloom1Tint;
		/// <summary>Bloom2 tint color</summary>
		public FLinearColor Bloom2Tint;
		/// <summary>Bloom3 tint color</summary>
		public FLinearColor Bloom3Tint;
		/// <summary>Bloom4 tint color</summary>
		public FLinearColor Bloom4Tint;
		/// <summary>Bloom5 tint color</summary>
		public FLinearColor Bloom5Tint;
		/// <summary>Bloom6 tint color</summary>
		public FLinearColor Bloom6Tint;
		/// <summary>BloomDirtMask intensity</summary>
		public float BloomDirtMaskIntensity;
		/// <summary>BloomDirtMask tint color</summary>
		public FLinearColor BloomDirtMaskTint;
		/// <summary>Texture that defines the dirt on the camera lens where the light of very bright objects is scattered.</summary>
		public UTexture BloomDirtMask;
		/// <summary>AmbientCubemap tint color</summary>
		public FLinearColor AmbientCubemapTint;
		/// <summary>
		/// To scale the Ambient cubemap brightness
		/// >=0: off, 1(default), >1 brighter
		/// </summary>
		public float AmbientCubemapIntensity;
		/// <summary>The Ambient cubemap (Affects diffuse and specular shading), blends additively which if different from all other settings here</summary>
		public UTextureCube AmbientCubemap;
		/// <summary>Luminance computation method</summary>
		public EAutoExposureMethod AutoExposureMethod;
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// bright spots.
		/// >0, <100, good values are in the range 70 .. 80
		/// </summary>
		public float AutoExposureLowPercent;
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// bright spots.
		/// >0, <100, good values are in the range 80 .. 95
		/// </summary>
		public float AutoExposureHighPercent;
		/// <summary>
		/// A good value should be positive near 0. This is the minimum brightness the auto exposure can adapt to.
		/// It should be tweaked in a dark lighting situation (too small: image appears too bright, too large: image appears too dark).
		/// Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global
		/// effect and defined the HDR range - you don't want to change that late in the project development.
		/// Eye Adaptation is disabled if MinBrightness = MaxBrightness
		/// </summary>
		public float AutoExposureMinBrightness;
		/// <summary>
		/// A good value should be positive (2 is a good value). This is the maximum brightness the auto exposure can adapt to.
		/// It should be tweaked in a bright lighting situation (too small: image appears too bright, too large: image appears too dark).
		/// Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global
		/// effect and defined the HDR range - you don't want to change that late in the project development.
		/// Eye Adaptation is disabled if MinBrightness = MaxBrightness
		/// </summary>
		public float AutoExposureMaxBrightness;
		/// <summary>>0</summary>
		public float AutoExposureSpeedUp;
		/// <summary>>0</summary>
		public float AutoExposureSpeedDown;
		/// <summary>
		/// Logarithmic adjustment for the exposure. Only used if a tonemapper is specified.
		/// 0: no adjustment, -1:2x darker, -2:4x darker, 1:2x brighter, 2:4x brighter, ...
		/// </summary>
		public float AutoExposureBias;
		/// <summary>temporary exposed until we found good values, -8: 1/256, -10: 1/1024</summary>
		public float HistogramLogMin;
		/// <summary>temporary exposed until we found good values 4: 16, 8: 256</summary>
		public float HistogramLogMax;
		/// <summary>Brightness scale of the image cased lens flares (linear)</summary>
		public float LensFlareIntensity;
		/// <summary>Tint color for the image based lens flares.</summary>
		public FLinearColor LensFlareTint;
		/// <summary>Size of the Lens Blur (in percent of the view width) that is done with the Bokeh texture (note: performance cost is radius*radius)</summary>
		public float LensFlareBokehSize;
		/// <summary>Minimum brightness the lens flare starts having effect (this should be as high as possible to avoid the performance cost of blurring content that is too dark too see)</summary>
		public float LensFlareThreshold;
		/// <summary>Defines the shape of the Bokeh when the image base lens flares are blurred, cannot be blended</summary>
		public UTexture LensFlareBokehShape;
		/// <summary>RGB defines the lens flare color, A it's position. This is a temporary solution.</summary>
		public FLinearColor LensFlareTints;
		/// <summary>0..1 0=off/no vignette .. 1=strong vignette</summary>
		public float VignetteIntensity;
		/// <summary>0..1 grain jitter</summary>
		public float GrainJitter;
		/// <summary>0..1 grain intensity</summary>
		public float GrainIntensity;
		/// <summary>0..1 0=off/no ambient occlusion .. 1=strong ambient occlusion, defines how much it affects the non direct lighting after base pass</summary>
		public float AmbientOcclusionIntensity;
		/// <summary>0..1 0=no effect on static lighting .. 1=AO affects the stat lighting, 0 is free meaning no extra rendering pass</summary>
		public float AmbientOcclusionStaticFraction;
		/// <summary>>0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion</summary>
		public float AmbientOcclusionRadius;
		/// <summary>true: AO radius is in world space units, false: AO radius is locked the view space in 400 units</summary>
		public bool AmbientOcclusionRadiusInWS;
		/// <summary>>0, in unreal units, at what distance the AO effect disppears in the distance (avoding artifacts and AO effects on huge object)</summary>
		public float AmbientOcclusionFadeDistance;
		/// <summary>>0, in unreal units, how many units before AmbientOcclusionFadeOutDistance it starts fading out</summary>
		public float AmbientOcclusionFadeRadius;
		/// <summary>>0, in unreal units, how wide the ambient occlusion effect should affect the geometry (in depth), will be removed - only used for non normal method which is not exposed</summary>
		public float AmbientOcclusionDistance;
		/// <summary>>0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion</summary>
		public float AmbientOcclusionPower;
		/// <summary>>0, in unreal units, default (3.0) works well for flat surfaces but can reduce details</summary>
		public float AmbientOcclusionBias;
		/// <summary>0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition</summary>
		public float AmbientOcclusionQuality;
		/// <summary>Affects the blend over the multiple mips (lower resolution versions) , 0:fully use full resolution, 1::fully use low resolution, around 0.6 seems to be a good value</summary>
		public float AmbientOcclusionMipBlend;
		/// <summary>Affects the radius AO radius scale over the multiple mips (lower resolution versions)</summary>
		public float AmbientOcclusionMipScale;
		/// <summary>to tweak the bilateral upsampling when using multiple mips (lower resolution versions)</summary>
		public float AmbientOcclusionMipThreshold;
		/// <summary>Adjusts indirect lighting color. (1,1,1) is default. (0,0,0) to disable GI. The show flag 'Global Illumination' must be enabled to use this property.</summary>
		public FLinearColor IndirectLightingColor;
		/// <summary>Scales the indirect lighting contribution. A value of 0 disables GI. Default is 1. The show flag 'Global Illumination' must be enabled to use this property.</summary>
		public float IndirectLightingIntensity;
		/// <summary>Color grading lookup table intensity. 0 = no intensity, 1=full intensity</summary>
		public float ColorGradingIntensity;
		/// <summary>Look up table texture to use or none of not used</summary>
		public UTexture ColorGradingLUT;
		/// <summary>BokehDOF, Simple gaussian, ... Mobile supports Gaussian only.</summary>
		public EDepthOfFieldMethod DepthOfFieldMethod;
		/// <summary>Enable HQ Gaussian on high end mobile platforms. (ES3_1)</summary>
		public bool bMobileHQGaussian;
		/// <summary>CircleDOF only: Defines the opening of the camera lens, Aperture is 1/fstop, typical lens go down to f/1.2 (large opening), larger numbers reduce the DOF effect</summary>
		public float DepthOfFieldFstop;
		/// <summary>Width of the camera sensor to assume, in mm.</summary>
		public float DepthOfFieldSensorWidth;
		/// <summary>Distance in which the Depth of Field effect should be sharp, in unreal units (cm)</summary>
		public float DepthOfFieldFocalDistance;
		/// <summary>CircleDOF only: Depth blur km for 50%</summary>
		public float DepthOfFieldDepthBlurAmount;
		/// <summary>CircleDOF only: Depth blur radius in pixels at 1920x</summary>
		public float DepthOfFieldDepthBlurRadius;
		/// <summary>Artificial region where all content is in focus, starting after DepthOfFieldFocalDistance, in unreal units  (cm)</summary>
		public float DepthOfFieldFocalRegion;
		/// <summary>To define the width of the transition region next to the focal region on the near side (cm)</summary>
		public float DepthOfFieldNearTransitionRegion;
		/// <summary>To define the width of the transition region next to the focal region on the near side (cm)</summary>
		public float DepthOfFieldFarTransitionRegion;
		/// <summary>
		/// SM5: BokehDOF only: To amplify the depth of field effect (like aperture)  0=off
		///           ES2: Used to blend DoF. 0=off
		/// </summary>
		public float DepthOfFieldScale;
		/// <summary>BokehDOF only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size*size)</summary>
		public float DepthOfFieldMaxBokehSize;
		/// <summary>Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size)</summary>
		public float DepthOfFieldNearBlurSize;
		/// <summary>Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size)</summary>
		public float DepthOfFieldFarBlurSize;
		/// <summary>Defines the shape of the Bokeh when object get out of focus, cannot be blended</summary>
		public UTexture DepthOfFieldBokehShape;
		/// <summary>Occlusion tweak factor 1 (0.18 to get natural occlusion, 0.4 to solve layer color leaking issues)</summary>
		public float DepthOfFieldOcclusion;
		/// <summary>Color threshold to do full quality DOF (BokehDOF only)</summary>
		public float DepthOfFieldColorThreshold;
		/// <summary>Size threshold to do full quality DOF (BokehDOF only)</summary>
		public float DepthOfFieldSizeThreshold;
		/// <summary>Artificial distance to allow the skybox to be in focus (e.g. 200000), <=0 to switch the feature off, only for GaussianDOF, can cost performance</summary>
		public float DepthOfFieldSkyFocusDistance;
		/// <summary>Artificial circular mask to (near) blur content outside the radius, only for GaussianDOF, diameter in percent of screen width, costs performance if the mask is used, keep Feather can Radius on default to keep it off</summary>
		public float DepthOfFieldVignetteSize;
		/// <summary>Strength of motion blur, 0:off, should be renamed to intensity</summary>
		public float MotionBlurAmount;
		/// <summary>max distortion caused by motion blur, in percent of the screen width, 0:off</summary>
		public float MotionBlurMax;
		/// <summary>The minimum projected screen radius for a primitive to be drawn in the velocity pass, percentage of screen width. smaller numbers cause more draw calls, default: 4%</summary>
		public float MotionBlurPerObjectSize;
		/// <summary>How strong the dynamic GI from the LPV should be. 0.0 is off, 1.0 is the "normal" value, but higher values can be used to boost the effect</summary>
		public float LPVIntensity;
		/// <summary>Bias applied to light injected into the LPV in cell units. Increase to reduce bleeding through thin walls</summary>
		public float LPVVplInjectionBias;
		/// <summary>The size of the LPV volume, in Unreal units</summary>
		public float LPVSize;
		/// <summary>Secondary occlusion strength (bounce light shadows). Set to 0 to disable</summary>
		public float LPVSecondaryOcclusionIntensity;
		/// <summary>Secondary bounce light strength (bounce light shadows). Set to 0 to disable</summary>
		public float LPVSecondaryBounceIntensity;
		/// <summary>Bias applied to the geometry volume in cell units. Increase to reduce darkening due to secondary occlusion</summary>
		public float LPVGeometryVolumeBias;
		public float LPVEmissiveInjectionIntensity;
		/// <summary>Controls the amount of directional occlusion. Requires LPV. Values very close to 1.0 are recommended</summary>
		public float LPVDirectionalOcclusionIntensity;
		/// <summary>Occlusion Radius - 16 is recommended for most scenes</summary>
		public float LPVDirectionalOcclusionRadius;
		/// <summary>Diffuse occlusion exponent - increase for more contrast. 1 to 2 is recommended</summary>
		public float LPVDiffuseOcclusionExponent;
		/// <summary>Specular occlusion exponent - increase for more contrast. 6 to 9 is recommended</summary>
		public float LPVSpecularOcclusionExponent;
		/// <summary>Diffuse occlusion intensity - higher values provide increased diffuse occlusion.</summary>
		public float LPVDiffuseOcclusionIntensity;
		/// <summary>Specular occlusion intensity - higher values provide increased specular occlusion.</summary>
		public float LPVSpecularOcclusionIntensity;
		/// <summary>Enable/Fade/disable the Screen Space Reflection feature, in percent, avoid numbers between 0 and 1 fo consistency</summary>
		public float ScreenSpaceReflectionIntensity;
		/// <summary>0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition, 50 is the default for better performance.</summary>
		public float ScreenSpaceReflectionQuality;
		/// <summary>Until what roughness we fade the screen space reflections, 0.8 works well, smaller can run faster</summary>
		public float ScreenSpaceReflectionMaxRoughness;
		/// <summary>
		/// To render with lower or high resolution than it is presented,
		/// controlled by console variable,
		/// 100:off, needs to be <99 to get upsampling and lower to get performance,
		/// >100 for super sampling (slower but higher quality),
		/// only applied in game
		/// </summary>
		public float ScreenPercentage;
		/// <summary>
		/// Allows custom post process materials to be defined, using a MaterialInstance with the same Material as its parent to allow blending.
		/// For materials this needs to be the "PostProcess" domain type. This can be used for any UObject object implementing the IBlendableInterface (e.g. could be used to fade weather settings).
		/// </summary>
		public FWeightedBlendables WeightedBlendables;
		
	}
	
}
