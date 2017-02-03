#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=888)]
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
		[FieldOffset(388)]
		public float LPVIntensity;
		[FieldOffset(392)]
		public float LPVVplInjectionBias;
		[FieldOffset(396)]
		public float LPVSize;
		[FieldOffset(400)]
		public float LPVSecondaryOcclusionIntensity;
		[FieldOffset(404)]
		public float LPVSecondaryBounceIntensity;
		[FieldOffset(408)]
		public float LPVGeometryVolumeBias;
		[FieldOffset(412)]
		public float LPVEmissiveInjectionIntensity;
		[FieldOffset(416)]
		public float LPVDirectionalOcclusionIntensity;
		[FieldOffset(420)]
		public float LPVDirectionalOcclusionRadius;
		[FieldOffset(424)]
		public float LPVDiffuseOcclusionExponent;
		[FieldOffset(428)]
		public float LPVSpecularOcclusionExponent;
		[FieldOffset(432)]
		public float LPVDiffuseOcclusionIntensity;
		[FieldOffset(436)]
		public float LPVSpecularOcclusionIntensity;
		[FieldOffset(440)]
		public FLinearColor AmbientCubemapTint;
		[FieldOffset(456)]
		public float AmbientCubemapIntensity;
		[FieldOffset(464)]
		public EAutoExposureMethod AutoExposureMethod;
		[FieldOffset(468)]
		public float AutoExposureLowPercent;
		[FieldOffset(472)]
		public float AutoExposureHighPercent;
		[FieldOffset(476)]
		public float AutoExposureMinBrightness;
		[FieldOffset(480)]
		public float AutoExposureMaxBrightness;
		[FieldOffset(484)]
		public float AutoExposureSpeedUp;
		[FieldOffset(488)]
		public float AutoExposureSpeedDown;
		[FieldOffset(492)]
		public float AutoExposureBias;
		[FieldOffset(496)]
		public float HistogramLogMin;
		[FieldOffset(500)]
		public float HistogramLogMax;
		[FieldOffset(504)]
		public float LensFlareIntensity;
		[FieldOffset(508)]
		public FLinearColor LensFlareTint;
		[FieldOffset(524)]
		public float LensFlareBokehSize;
		[FieldOffset(528)]
		public float LensFlareThreshold;
		[FieldOffset(536)]
		public FLinearColor LensFlareTints;
		[FieldOffset(664)]
		public float VignetteIntensity;
		[FieldOffset(668)]
		public float GrainJitter;
		[FieldOffset(672)]
		public float GrainIntensity;
		[FieldOffset(676)]
		public float AmbientOcclusionIntensity;
		[FieldOffset(680)]
		public float AmbientOcclusionStaticFraction;
		[FieldOffset(684)]
		public float AmbientOcclusionRadius;
		public bool AmbientOcclusionRadiusInWS
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 688, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 688, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(692)]
		public float AmbientOcclusionFadeDistance;
		[FieldOffset(696)]
		public float AmbientOcclusionFadeRadius;
		[FieldOffset(700)]
		public float AmbientOcclusionDistance;
		[FieldOffset(704)]
		public float AmbientOcclusionPower;
		[FieldOffset(708)]
		public float AmbientOcclusionBias;
		[FieldOffset(712)]
		public float AmbientOcclusionQuality;
		[FieldOffset(716)]
		public float AmbientOcclusionMipBlend;
		[FieldOffset(720)]
		public float AmbientOcclusionMipScale;
		[FieldOffset(724)]
		public float AmbientOcclusionMipThreshold;
		[FieldOffset(728)]
		public FLinearColor IndirectLightingColor;
		[FieldOffset(744)]
		public float IndirectLightingIntensity;
		[FieldOffset(748)]
		public float ColorGradingIntensity;
		[FieldOffset(756)]
		public EDepthOfFieldMethod DepthOfFieldMethod;
		public bool bMobileHQGaussian
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 757, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 757, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(760)]
		public float DepthOfFieldFstop;
		[FieldOffset(764)]
		public float DepthOfFieldSensorWidth;
		[FieldOffset(768)]
		public float DepthOfFieldFocalDistance;
		[FieldOffset(772)]
		public float DepthOfFieldDepthBlurAmount;
		[FieldOffset(776)]
		public float DepthOfFieldDepthBlurRadius;
		[FieldOffset(780)]
		public float DepthOfFieldFocalRegion;
		[FieldOffset(784)]
		public float DepthOfFieldNearTransitionRegion;
		[FieldOffset(788)]
		public float DepthOfFieldFarTransitionRegion;
		[FieldOffset(792)]
		public float DepthOfFieldScale;
		[FieldOffset(796)]
		public float DepthOfFieldMaxBokehSize;
		[FieldOffset(800)]
		public float DepthOfFieldNearBlurSize;
		[FieldOffset(804)]
		public float DepthOfFieldFarBlurSize;
		[FieldOffset(812)]
		public float DepthOfFieldOcclusion;
		[FieldOffset(816)]
		public float DepthOfFieldColorThreshold;
		[FieldOffset(820)]
		public float DepthOfFieldSizeThreshold;
		[FieldOffset(824)]
		public float DepthOfFieldSkyFocusDistance;
		[FieldOffset(828)]
		public float DepthOfFieldVignetteSize;
		[FieldOffset(832)]
		public float MotionBlurAmount;
		[FieldOffset(836)]
		public float MotionBlurMax;
		[FieldOffset(840)]
		public float MotionBlurPerObjectSize;
		[FieldOffset(844)]
		public float ScreenPercentage;
		[FieldOffset(848)]
		public EAntiAliasingMethod AntiAliasingMethod;
		[FieldOffset(852)]
		public float ScreenSpaceReflectionIntensity;
		[FieldOffset(856)]
		public float ScreenSpaceReflectionQuality;
		[FieldOffset(860)]
		public float ScreenSpaceReflectionMaxRoughness;
		[FieldOffset(864)]
		public FWeightedBlendables WeightedBlendables;
		public TObjectArray<UObject> Blendables
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+876, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+876, false);}}}
			
		}
		
	}
	
}
#endif
#endif
