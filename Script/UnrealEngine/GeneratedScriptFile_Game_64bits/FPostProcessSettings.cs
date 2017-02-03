#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=928)]
	public partial struct FPostProcessSettings
	{
		public bool bOverride_WhiteTemp
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_WhiteTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_ColorSaturation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_ColorContrast
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_ColorGamma
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_ColorGain
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_ColorOffset
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_FilmWhitePoint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_FilmSaturation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_FilmChannelMixerRed
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_FilmChannelMixerGreen
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_FilmChannelMixerBlue
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_FilmContrast
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_FilmDynamicRange
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_FilmHealAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_FilmToeAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_FilmShadowTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_FilmShadowTintBlend
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_FilmShadowTintAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_FilmSlope
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_FilmToe
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_FilmShoulder
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_FilmBlackClip
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_FilmWhiteClip
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_SceneColorTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_SceneFringeIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_AmbientCubemapTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_AmbientCubemapIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_BloomIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_BloomThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_Bloom1Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_Bloom1Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_Bloom2Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_Bloom2Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_Bloom3Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_Bloom3Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_Bloom4Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_Bloom4Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_Bloom5Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_Bloom5Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_Bloom6Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_Bloom6Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_BloomSizeScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_BloomDirtMaskIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_BloomDirtMaskTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_BloomDirtMask
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_AutoExposureMethod
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_AutoExposureLowPercent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_AutoExposureHighPercent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_AutoExposureMinBrightness
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_AutoExposureMaxBrightness
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_AutoExposureSpeedUp
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_AutoExposureSpeedDown
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_AutoExposureBias
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_HistogramLogMin
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_HistogramLogMax
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_LensFlareIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_LensFlareTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_LensFlareTints
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_LensFlareBokehSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_LensFlareBokehShape
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_LensFlareThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_VignetteIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_GrainIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_GrainJitter
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_AmbientOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_AmbientOcclusionStaticFraction
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_AmbientOcclusionRadius
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_AmbientOcclusionFadeDistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_AmbientOcclusionFadeRadius
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_AmbientOcclusionDistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_AmbientOcclusionRadiusInWS
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_AmbientOcclusionPower
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_AmbientOcclusionBias
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_AmbientOcclusionQuality
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_AmbientOcclusionMipBlend
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_AmbientOcclusionMipScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_AmbientOcclusionMipThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_LPVIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_LPVDirectionalOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_LPVDirectionalOcclusionRadius
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_LPVDiffuseOcclusionExponent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_LPVSpecularOcclusionExponent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_LPVDiffuseOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_LPVSpecularOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_LPVSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_LPVSecondaryOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_LPVSecondaryBounceIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_LPVGeometryVolumeBias
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_LPVVplInjectionBias
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_LPVEmissiveInjectionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_IndirectLightingColor
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_IndirectLightingIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_ColorGradingIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_ColorGradingLUT
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_DepthOfFieldFocalDistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_DepthOfFieldFstop
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_DepthOfFieldSensorWidth
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_DepthOfFieldDepthBlurRadius
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_DepthOfFieldDepthBlurAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_DepthOfFieldFocalRegion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_DepthOfFieldNearTransitionRegion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_DepthOfFieldFarTransitionRegion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_DepthOfFieldScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_DepthOfFieldMaxBokehSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_DepthOfFieldNearBlurSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_DepthOfFieldFarBlurSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_DepthOfFieldMethod
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_MobileHQGaussian
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_DepthOfFieldBokehShape
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_DepthOfFieldOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_DepthOfFieldColorThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_DepthOfFieldSizeThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_DepthOfFieldSkyFocusDistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_DepthOfFieldVignetteSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_MotionBlurAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_MotionBlurMax
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_MotionBlurPerObjectSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_ScreenPercentage
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_AntiAliasingMethod
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_ScreenSpaceReflectionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_ScreenSpaceReflectionQuality
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_ScreenSpaceReflectionMaxRoughness
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_ScreenSpaceReflectionRoughnessScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 8, 8); } }}
			
		}
		[FieldOffset(16)]
		public float WhiteTemp;
		[FieldOffset(20)]
		public float WhiteTint;
		[FieldOffset(24)]
		public FVector ColorSaturation;
		[FieldOffset(36)]
		public FVector ColorContrast;
		[FieldOffset(48)]
		public FVector ColorGamma;
		[FieldOffset(60)]
		public FVector ColorGain;
		[FieldOffset(72)]
		public FVector ColorOffset;
		[FieldOffset(84)]
		public FLinearColor FilmWhitePoint;
		[FieldOffset(100)]
		public FLinearColor FilmShadowTint;
		[FieldOffset(116)]
		public float FilmShadowTintBlend;
		[FieldOffset(120)]
		public float FilmShadowTintAmount;
		[FieldOffset(124)]
		public float FilmSaturation;
		[FieldOffset(128)]
		public FLinearColor FilmChannelMixerRed;
		[FieldOffset(144)]
		public FLinearColor FilmChannelMixerGreen;
		[FieldOffset(160)]
		public FLinearColor FilmChannelMixerBlue;
		[FieldOffset(176)]
		public float FilmContrast;
		[FieldOffset(180)]
		public float FilmToeAmount;
		[FieldOffset(184)]
		public float FilmHealAmount;
		[FieldOffset(188)]
		public float FilmDynamicRange;
		[FieldOffset(192)]
		public float FilmSlope;
		[FieldOffset(196)]
		public float FilmToe;
		[FieldOffset(200)]
		public float FilmShoulder;
		[FieldOffset(204)]
		public float FilmBlackClip;
		[FieldOffset(208)]
		public float FilmWhiteClip;
		[FieldOffset(212)]
		public FLinearColor SceneColorTint;
		[FieldOffset(228)]
		public float SceneFringeIntensity;
		[FieldOffset(232)]
		public float BloomIntensity;
		[FieldOffset(236)]
		public float BloomThreshold;
		[FieldOffset(240)]
		public float BloomSizeScale;
		[FieldOffset(244)]
		public float Bloom1Size;
		[FieldOffset(248)]
		public float Bloom2Size;
		[FieldOffset(252)]
		public float Bloom3Size;
		[FieldOffset(256)]
		public float Bloom4Size;
		[FieldOffset(260)]
		public float Bloom5Size;
		[FieldOffset(264)]
		public float Bloom6Size;
		[FieldOffset(268)]
		public FLinearColor Bloom1Tint;
		[FieldOffset(284)]
		public FLinearColor Bloom2Tint;
		[FieldOffset(300)]
		public FLinearColor Bloom3Tint;
		[FieldOffset(316)]
		public FLinearColor Bloom4Tint;
		[FieldOffset(332)]
		public FLinearColor Bloom5Tint;
		[FieldOffset(348)]
		public FLinearColor Bloom6Tint;
		[FieldOffset(364)]
		public float BloomDirtMaskIntensity;
		[FieldOffset(368)]
		public FLinearColor BloomDirtMaskTint;
		[FieldOffset(392)]
		public float LPVIntensity;
		[FieldOffset(396)]
		public float LPVVplInjectionBias;
		[FieldOffset(400)]
		public float LPVSize;
		[FieldOffset(404)]
		public float LPVSecondaryOcclusionIntensity;
		[FieldOffset(408)]
		public float LPVSecondaryBounceIntensity;
		[FieldOffset(412)]
		public float LPVGeometryVolumeBias;
		[FieldOffset(416)]
		public float LPVEmissiveInjectionIntensity;
		[FieldOffset(420)]
		public float LPVDirectionalOcclusionIntensity;
		[FieldOffset(424)]
		public float LPVDirectionalOcclusionRadius;
		[FieldOffset(428)]
		public float LPVDiffuseOcclusionExponent;
		[FieldOffset(432)]
		public float LPVSpecularOcclusionExponent;
		[FieldOffset(436)]
		public float LPVDiffuseOcclusionIntensity;
		[FieldOffset(440)]
		public float LPVSpecularOcclusionIntensity;
		[FieldOffset(444)]
		public FLinearColor AmbientCubemapTint;
		[FieldOffset(460)]
		public float AmbientCubemapIntensity;
		[FieldOffset(472)]
		public EAutoExposureMethod AutoExposureMethod;
		[FieldOffset(476)]
		public float AutoExposureLowPercent;
		[FieldOffset(480)]
		public float AutoExposureHighPercent;
		[FieldOffset(484)]
		public float AutoExposureMinBrightness;
		[FieldOffset(488)]
		public float AutoExposureMaxBrightness;
		[FieldOffset(492)]
		public float AutoExposureSpeedUp;
		[FieldOffset(496)]
		public float AutoExposureSpeedDown;
		[FieldOffset(500)]
		public float AutoExposureBias;
		[FieldOffset(504)]
		public float HistogramLogMin;
		[FieldOffset(508)]
		public float HistogramLogMax;
		[FieldOffset(512)]
		public float LensFlareIntensity;
		[FieldOffset(516)]
		public FLinearColor LensFlareTint;
		[FieldOffset(532)]
		public float LensFlareBokehSize;
		[FieldOffset(536)]
		public float LensFlareThreshold;
		[FieldOffset(552)]
		public FLinearColor LensFlareTints;
		[FieldOffset(680)]
		public float VignetteIntensity;
		[FieldOffset(684)]
		public float GrainJitter;
		[FieldOffset(688)]
		public float GrainIntensity;
		[FieldOffset(692)]
		public float AmbientOcclusionIntensity;
		[FieldOffset(696)]
		public float AmbientOcclusionStaticFraction;
		[FieldOffset(700)]
		public float AmbientOcclusionRadius;
		public bool AmbientOcclusionRadiusInWS
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 704, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 704, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(708)]
		public float AmbientOcclusionFadeDistance;
		[FieldOffset(712)]
		public float AmbientOcclusionFadeRadius;
		[FieldOffset(716)]
		public float AmbientOcclusionDistance;
		[FieldOffset(720)]
		public float AmbientOcclusionPower;
		[FieldOffset(724)]
		public float AmbientOcclusionBias;
		[FieldOffset(728)]
		public float AmbientOcclusionQuality;
		[FieldOffset(732)]
		public float AmbientOcclusionMipBlend;
		[FieldOffset(736)]
		public float AmbientOcclusionMipScale;
		[FieldOffset(740)]
		public float AmbientOcclusionMipThreshold;
		[FieldOffset(744)]
		public FLinearColor IndirectLightingColor;
		[FieldOffset(760)]
		public float IndirectLightingIntensity;
		[FieldOffset(764)]
		public float ColorGradingIntensity;
		[FieldOffset(776)]
		public EDepthOfFieldMethod DepthOfFieldMethod;
		public bool bMobileHQGaussian
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 780, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 780, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(784)]
		public float DepthOfFieldFstop;
		[FieldOffset(788)]
		public float DepthOfFieldSensorWidth;
		[FieldOffset(792)]
		public float DepthOfFieldFocalDistance;
		[FieldOffset(796)]
		public float DepthOfFieldDepthBlurAmount;
		[FieldOffset(800)]
		public float DepthOfFieldDepthBlurRadius;
		[FieldOffset(804)]
		public float DepthOfFieldFocalRegion;
		[FieldOffset(808)]
		public float DepthOfFieldNearTransitionRegion;
		[FieldOffset(812)]
		public float DepthOfFieldFarTransitionRegion;
		[FieldOffset(816)]
		public float DepthOfFieldScale;
		[FieldOffset(820)]
		public float DepthOfFieldMaxBokehSize;
		[FieldOffset(824)]
		public float DepthOfFieldNearBlurSize;
		[FieldOffset(828)]
		public float DepthOfFieldFarBlurSize;
		[FieldOffset(840)]
		public float DepthOfFieldOcclusion;
		[FieldOffset(844)]
		public float DepthOfFieldColorThreshold;
		[FieldOffset(848)]
		public float DepthOfFieldSizeThreshold;
		[FieldOffset(852)]
		public float DepthOfFieldSkyFocusDistance;
		[FieldOffset(856)]
		public float DepthOfFieldVignetteSize;
		[FieldOffset(860)]
		public float MotionBlurAmount;
		[FieldOffset(864)]
		public float MotionBlurMax;
		[FieldOffset(868)]
		public float MotionBlurPerObjectSize;
		[FieldOffset(872)]
		public float ScreenPercentage;
		[FieldOffset(876)]
		public EAntiAliasingMethod AntiAliasingMethod;
		[FieldOffset(880)]
		public float ScreenSpaceReflectionIntensity;
		[FieldOffset(884)]
		public float ScreenSpaceReflectionQuality;
		[FieldOffset(888)]
		public float ScreenSpaceReflectionMaxRoughness;
		[FieldOffset(896)]
		public FWeightedBlendables WeightedBlendables;
		public TObjectArray<UObject> Blendables
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+912, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+912, false);}}}
			
		}
		
	}
	
}
#endif
#endif
