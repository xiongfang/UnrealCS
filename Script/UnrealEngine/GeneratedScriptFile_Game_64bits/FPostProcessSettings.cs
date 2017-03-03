#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1216)]
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
		public bool bOverride_ColorSaturationShadows
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_ColorContrastShadows
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_ColorGammaShadows
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_ColorGainShadows
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_ColorOffsetShadows
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_ColorSaturationMidtones
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_ColorContrastMidtones
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_ColorGammaMidtones
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_ColorGainMidtones
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_ColorOffsetMidtones
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_ColorSaturationHighlights
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_ColorContrastHighlights
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_ColorGammaHighlights
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_ColorGainHighlights
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_ColorOffsetHighlights
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_ColorCorrectionShadowsMax
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_ColorCorrectionHighlightsMin
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_FilmWhitePoint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_FilmSaturation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_FilmChannelMixerRed
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_FilmChannelMixerGreen
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_FilmChannelMixerBlue
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_FilmContrast
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_FilmDynamicRange
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_FilmHealAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_FilmToeAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_FilmShadowTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_FilmShadowTintBlend
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_FilmShadowTintAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_FilmSlope
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_FilmToe
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_FilmShoulder
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_FilmBlackClip
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_FilmWhiteClip
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_SceneColorTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_SceneFringeIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_AmbientCubemapTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_AmbientCubemapIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_BloomIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_BloomThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_Bloom1Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_Bloom1Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_Bloom2Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_Bloom2Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_Bloom3Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_Bloom3Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_Bloom4Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_Bloom4Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_Bloom5Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_Bloom5Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_Bloom6Tint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_Bloom6Size
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_BloomSizeScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_BloomDirtMaskIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_BloomDirtMaskTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_BloomDirtMask
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_AutoExposureMethod
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_AutoExposureLowPercent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_AutoExposureHighPercent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_AutoExposureMinBrightness
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_AutoExposureMaxBrightness
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_AutoExposureSpeedUp
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_AutoExposureSpeedDown
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_AutoExposureBias
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_HistogramLogMin
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_HistogramLogMax
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_LensFlareIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_LensFlareTint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_LensFlareTints
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_LensFlareBokehSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_LensFlareBokehShape
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_LensFlareThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_VignetteIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_GrainIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_GrainJitter
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_AmbientOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_AmbientOcclusionStaticFraction
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_AmbientOcclusionRadius
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_AmbientOcclusionFadeDistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_AmbientOcclusionFadeRadius
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_AmbientOcclusionDistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 10, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 10, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_AmbientOcclusionRadiusInWS
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_AmbientOcclusionPower
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_AmbientOcclusionBias
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_AmbientOcclusionQuality
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_AmbientOcclusionMipBlend
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_AmbientOcclusionMipScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_AmbientOcclusionMipThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_LPVIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 11, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 11, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_LPVDirectionalOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_LPVDirectionalOcclusionRadius
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_LPVDiffuseOcclusionExponent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_LPVSpecularOcclusionExponent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_LPVDiffuseOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_LPVSpecularOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_LPVSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_LPVSecondaryOcclusionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_LPVSecondaryBounceIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_LPVGeometryVolumeBias
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_LPVVplInjectionBias
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_LPVEmissiveInjectionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_IndirectLightingColor
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_IndirectLightingIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_ColorGradingIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_ColorGradingLUT
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 13, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 13, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_DepthOfFieldFocalDistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_DepthOfFieldFstop
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_DepthOfFieldSensorWidth
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_DepthOfFieldDepthBlurRadius
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_DepthOfFieldDepthBlurAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_DepthOfFieldFocalRegion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_DepthOfFieldNearTransitionRegion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_DepthOfFieldFarTransitionRegion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 14, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 14, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_DepthOfFieldScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_DepthOfFieldMaxBokehSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_DepthOfFieldNearBlurSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_DepthOfFieldFarBlurSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_DepthOfFieldMethod
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_MobileHQGaussian
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_DepthOfFieldBokehShape
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_DepthOfFieldOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 15, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 15, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_DepthOfFieldColorThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_DepthOfFieldSizeThreshold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_DepthOfFieldSkyFocusDistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_DepthOfFieldVignetteSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 8, 8); } }}
			
		}
		public bool bOverride_MotionBlurAmount
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 16, 16); } }}
			
		}
		public bool bOverride_MotionBlurMax
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 32, 32); } }}
			
		}
		public bool bOverride_MotionBlurPerObjectSize
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 64, 64); } }}
			
		}
		public bool bOverride_ScreenPercentage
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 128, 128); } }}
			
		}
		public bool bOverride_ScreenSpaceReflectionIntensity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 17, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 17, 1, 0, 1, 1); } }}
			
		}
		public bool bOverride_ScreenSpaceReflectionQuality
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 17, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 17, 1, 0, 2, 2); } }}
			
		}
		public bool bOverride_ScreenSpaceReflectionMaxRoughness
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 17, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 17, 1, 0, 4, 4); } }}
			
		}
		public bool bOverride_ScreenSpaceReflectionRoughnessScale
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 17, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 17, 1, 0, 8, 8); } }}
			
		}
		[FieldOffset(20)]
		public float WhiteTemp;
		[FieldOffset(24)]
		public float WhiteTint;
		[FieldOffset(32)]
		public FVector4 ColorSaturation;
		[FieldOffset(48)]
		public FVector4 ColorContrast;
		[FieldOffset(64)]
		public FVector4 ColorGamma;
		[FieldOffset(80)]
		public FVector4 ColorGain;
		[FieldOffset(96)]
		public FVector4 ColorOffset;
		[FieldOffset(112)]
		public FVector4 ColorSaturationShadows;
		[FieldOffset(128)]
		public FVector4 ColorContrastShadows;
		[FieldOffset(144)]
		public FVector4 ColorGammaShadows;
		[FieldOffset(160)]
		public FVector4 ColorGainShadows;
		[FieldOffset(176)]
		public FVector4 ColorOffsetShadows;
		[FieldOffset(192)]
		public float ColorCorrectionShadowsMax;
		[FieldOffset(208)]
		public FVector4 ColorSaturationMidtones;
		[FieldOffset(224)]
		public FVector4 ColorContrastMidtones;
		[FieldOffset(240)]
		public FVector4 ColorGammaMidtones;
		[FieldOffset(256)]
		public FVector4 ColorGainMidtones;
		[FieldOffset(272)]
		public FVector4 ColorOffsetMidtones;
		[FieldOffset(288)]
		public FVector4 ColorSaturationHighlights;
		[FieldOffset(304)]
		public FVector4 ColorContrastHighlights;
		[FieldOffset(320)]
		public FVector4 ColorGammaHighlights;
		[FieldOffset(336)]
		public FVector4 ColorGainHighlights;
		[FieldOffset(352)]
		public FVector4 ColorOffsetHighlights;
		[FieldOffset(368)]
		public float ColorCorrectionHighlightsMin;
		[FieldOffset(372)]
		public FLinearColor FilmWhitePoint;
		[FieldOffset(388)]
		public FLinearColor FilmShadowTint;
		[FieldOffset(404)]
		public float FilmShadowTintBlend;
		[FieldOffset(408)]
		public float FilmShadowTintAmount;
		[FieldOffset(412)]
		public float FilmSaturation;
		[FieldOffset(416)]
		public FLinearColor FilmChannelMixerRed;
		[FieldOffset(432)]
		public FLinearColor FilmChannelMixerGreen;
		[FieldOffset(448)]
		public FLinearColor FilmChannelMixerBlue;
		[FieldOffset(464)]
		public float FilmContrast;
		[FieldOffset(468)]
		public float FilmToeAmount;
		[FieldOffset(472)]
		public float FilmHealAmount;
		[FieldOffset(476)]
		public float FilmDynamicRange;
		[FieldOffset(480)]
		public float FilmSlope;
		[FieldOffset(484)]
		public float FilmToe;
		[FieldOffset(488)]
		public float FilmShoulder;
		[FieldOffset(492)]
		public float FilmBlackClip;
		[FieldOffset(496)]
		public float FilmWhiteClip;
		[FieldOffset(500)]
		public FLinearColor SceneColorTint;
		[FieldOffset(516)]
		public float SceneFringeIntensity;
		[FieldOffset(520)]
		public float BloomIntensity;
		[FieldOffset(524)]
		public float BloomThreshold;
		[FieldOffset(528)]
		public float BloomSizeScale;
		[FieldOffset(532)]
		public float Bloom1Size;
		[FieldOffset(536)]
		public float Bloom2Size;
		[FieldOffset(540)]
		public float Bloom3Size;
		[FieldOffset(544)]
		public float Bloom4Size;
		[FieldOffset(548)]
		public float Bloom5Size;
		[FieldOffset(552)]
		public float Bloom6Size;
		[FieldOffset(556)]
		public FLinearColor Bloom1Tint;
		[FieldOffset(572)]
		public FLinearColor Bloom2Tint;
		[FieldOffset(588)]
		public FLinearColor Bloom3Tint;
		[FieldOffset(604)]
		public FLinearColor Bloom4Tint;
		[FieldOffset(620)]
		public FLinearColor Bloom5Tint;
		[FieldOffset(636)]
		public FLinearColor Bloom6Tint;
		[FieldOffset(652)]
		public float BloomDirtMaskIntensity;
		[FieldOffset(656)]
		public FLinearColor BloomDirtMaskTint;
		[FieldOffset(680)]
		public FLinearColor AmbientCubemapTint;
		[FieldOffset(696)]
		public float AmbientCubemapIntensity;
		[FieldOffset(712)]
		public EAutoExposureMethod AutoExposureMethod;
		[FieldOffset(716)]
		public float AutoExposureLowPercent;
		[FieldOffset(720)]
		public float AutoExposureHighPercent;
		[FieldOffset(724)]
		public float AutoExposureMinBrightness;
		[FieldOffset(728)]
		public float AutoExposureMaxBrightness;
		[FieldOffset(732)]
		public float AutoExposureSpeedUp;
		[FieldOffset(736)]
		public float AutoExposureSpeedDown;
		[FieldOffset(740)]
		public float AutoExposureBias;
		[FieldOffset(744)]
		public float HistogramLogMin;
		[FieldOffset(748)]
		public float HistogramLogMax;
		[FieldOffset(752)]
		public float LensFlareIntensity;
		[FieldOffset(756)]
		public FLinearColor LensFlareTint;
		[FieldOffset(772)]
		public float LensFlareBokehSize;
		[FieldOffset(776)]
		public float LensFlareThreshold;
		[FieldOffset(792)]
		public FLinearColor LensFlareTints;
		[FieldOffset(920)]
		public float VignetteIntensity;
		[FieldOffset(924)]
		public float GrainJitter;
		[FieldOffset(928)]
		public float GrainIntensity;
		[FieldOffset(932)]
		public float AmbientOcclusionIntensity;
		[FieldOffset(936)]
		public float AmbientOcclusionStaticFraction;
		[FieldOffset(940)]
		public float AmbientOcclusionRadius;
		public bool AmbientOcclusionRadiusInWS
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 944, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 944, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(948)]
		public float AmbientOcclusionFadeDistance;
		[FieldOffset(952)]
		public float AmbientOcclusionFadeRadius;
		[FieldOffset(956)]
		public float AmbientOcclusionDistance;
		[FieldOffset(960)]
		public float AmbientOcclusionPower;
		[FieldOffset(964)]
		public float AmbientOcclusionBias;
		[FieldOffset(968)]
		public float AmbientOcclusionQuality;
		[FieldOffset(972)]
		public float AmbientOcclusionMipBlend;
		[FieldOffset(976)]
		public float AmbientOcclusionMipScale;
		[FieldOffset(980)]
		public float AmbientOcclusionMipThreshold;
		[FieldOffset(984)]
		public FLinearColor IndirectLightingColor;
		[FieldOffset(1000)]
		public float IndirectLightingIntensity;
		[FieldOffset(1004)]
		public float ColorGradingIntensity;
		[FieldOffset(1016)]
		public EDepthOfFieldMethod DepthOfFieldMethod;
		public bool bMobileHQGaussian
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1020, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1020, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(1024)]
		public float DepthOfFieldFstop;
		[FieldOffset(1028)]
		public float DepthOfFieldSensorWidth;
		[FieldOffset(1032)]
		public float DepthOfFieldFocalDistance;
		[FieldOffset(1036)]
		public float DepthOfFieldDepthBlurAmount;
		[FieldOffset(1040)]
		public float DepthOfFieldDepthBlurRadius;
		[FieldOffset(1044)]
		public float DepthOfFieldFocalRegion;
		[FieldOffset(1048)]
		public float DepthOfFieldNearTransitionRegion;
		[FieldOffset(1052)]
		public float DepthOfFieldFarTransitionRegion;
		[FieldOffset(1056)]
		public float DepthOfFieldScale;
		[FieldOffset(1060)]
		public float DepthOfFieldMaxBokehSize;
		[FieldOffset(1064)]
		public float DepthOfFieldNearBlurSize;
		[FieldOffset(1068)]
		public float DepthOfFieldFarBlurSize;
		[FieldOffset(1080)]
		public float DepthOfFieldOcclusion;
		[FieldOffset(1084)]
		public float DepthOfFieldColorThreshold;
		[FieldOffset(1088)]
		public float DepthOfFieldSizeThreshold;
		[FieldOffset(1092)]
		public float DepthOfFieldSkyFocusDistance;
		[FieldOffset(1096)]
		public float DepthOfFieldVignetteSize;
		[FieldOffset(1100)]
		public float MotionBlurAmount;
		[FieldOffset(1104)]
		public float MotionBlurMax;
		[FieldOffset(1108)]
		public float MotionBlurPerObjectSize;
		[FieldOffset(1112)]
		public float LPVIntensity;
		[FieldOffset(1116)]
		public float LPVVplInjectionBias;
		[FieldOffset(1120)]
		public float LPVSize;
		[FieldOffset(1124)]
		public float LPVSecondaryOcclusionIntensity;
		[FieldOffset(1128)]
		public float LPVSecondaryBounceIntensity;
		[FieldOffset(1132)]
		public float LPVGeometryVolumeBias;
		[FieldOffset(1136)]
		public float LPVEmissiveInjectionIntensity;
		[FieldOffset(1140)]
		public float LPVDirectionalOcclusionIntensity;
		[FieldOffset(1144)]
		public float LPVDirectionalOcclusionRadius;
		[FieldOffset(1148)]
		public float LPVDiffuseOcclusionExponent;
		[FieldOffset(1152)]
		public float LPVSpecularOcclusionExponent;
		[FieldOffset(1156)]
		public float LPVDiffuseOcclusionIntensity;
		[FieldOffset(1160)]
		public float LPVSpecularOcclusionIntensity;
		[FieldOffset(1164)]
		public float ScreenSpaceReflectionIntensity;
		[FieldOffset(1168)]
		public float ScreenSpaceReflectionQuality;
		[FieldOffset(1172)]
		public float ScreenSpaceReflectionMaxRoughness;
		[FieldOffset(1176)]
		public float ScreenPercentage;
		[FieldOffset(1184)]
		public FWeightedBlendables WeightedBlendables;
		public TObjectArray<UObject> Blendables
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+1200, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+1200, false);}}}
			
		}
		
	}
	
}
#endif
#endif
