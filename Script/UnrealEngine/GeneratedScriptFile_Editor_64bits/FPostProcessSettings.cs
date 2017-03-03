#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// To be able to use struct PostProcessSettings. // Each property consists of a bool to enable it (by default off),
	/// // the variable declaration and further down the default value for it.
	/// // The comment should include the meaning and usable range.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=1216)]
	public partial struct FPostProcessSettings
	{
		/// <summary>first all bOverride_... as they get grouped together into bitfields</summary>
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
		/// <summary>Color Correction controls</summary>
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
		/// <summary>Color Correction controls</summary>
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
		/// <summary>Scene tint color</summary>
		[FieldOffset(500)]
		public FLinearColor SceneColorTint;
		/// <summary>in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners.</summary>
		[FieldOffset(516)]
		public float SceneFringeIntensity;
		/// <summary>Multiplier for all bloom contributions >=0: off, 1(default), >1 brighter</summary>
		[FieldOffset(520)]
		public float BloomIntensity;
		/// <summary>
		/// minimum brightness the bloom starts having effect
		/// -1:all pixels affect bloom equally (physically correct, faster as a threshold pass is omitted), 0:all pixels affect bloom brights more, 1(default), >1 brighter
		/// </summary>
		[FieldOffset(524)]
		public float BloomThreshold;
		/// <summary>Scale for all bloom sizes</summary>
		[FieldOffset(528)]
		public float BloomSizeScale;
		/// <summary>
		/// Diameter size for the Bloom1 in percent of the screen width
		/// (is done in 1/2 resolution, larger values cost more performance, good for high frequency details)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(532)]
		public float Bloom1Size;
		/// <summary>
		/// Diameter size for Bloom2 in percent of the screen width
		/// (is done in 1/4 resolution, larger values cost more performance)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(536)]
		public float Bloom2Size;
		/// <summary>
		/// Diameter size for Bloom3 in percent of the screen width
		/// (is done in 1/8 resolution, larger values cost more performance)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(540)]
		public float Bloom3Size;
		/// <summary>
		/// Diameter size for Bloom4 in percent of the screen width
		/// (is done in 1/16 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(544)]
		public float Bloom4Size;
		/// <summary>
		/// Diameter size for Bloom5 in percent of the screen width
		/// (is done in 1/32 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(548)]
		public float Bloom5Size;
		/// <summary>
		/// Diameter size for Bloom6 in percent of the screen width
		/// (is done in 1/64 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(552)]
		public float Bloom6Size;
		/// <summary>Bloom1 tint color</summary>
		[FieldOffset(556)]
		public FLinearColor Bloom1Tint;
		/// <summary>Bloom2 tint color</summary>
		[FieldOffset(572)]
		public FLinearColor Bloom2Tint;
		/// <summary>Bloom3 tint color</summary>
		[FieldOffset(588)]
		public FLinearColor Bloom3Tint;
		/// <summary>Bloom4 tint color</summary>
		[FieldOffset(604)]
		public FLinearColor Bloom4Tint;
		/// <summary>Bloom5 tint color</summary>
		[FieldOffset(620)]
		public FLinearColor Bloom5Tint;
		/// <summary>Bloom6 tint color</summary>
		[FieldOffset(636)]
		public FLinearColor Bloom6Tint;
		/// <summary>BloomDirtMask intensity</summary>
		[FieldOffset(652)]
		public float BloomDirtMaskIntensity;
		/// <summary>BloomDirtMask tint color</summary>
		[FieldOffset(656)]
		public FLinearColor BloomDirtMaskTint;
		/// <summary>Texture that defines the dirt on the camera lens where the light of very bright objects is scattered.</summary>
		/// <summary>AmbientCubemap tint color</summary>
		[FieldOffset(680)]
		public FLinearColor AmbientCubemapTint;
		/// <summary>
		/// To scale the Ambient cubemap brightness
		/// >=0: off, 1(default), >1 brighter
		/// </summary>
		[FieldOffset(696)]
		public float AmbientCubemapIntensity;
		/// <summary>The Ambient cubemap (Affects diffuse and specular shading), blends additively which if different from all other settings here</summary>
		/// <summary>Luminance computation method</summary>
		[FieldOffset(712)]
		public EAutoExposureMethod AutoExposureMethod;
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// bright spots.
		/// >0, <100, good values are in the range 70 .. 80
		/// </summary>
		[FieldOffset(716)]
		public float AutoExposureLowPercent;
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// bright spots.
		/// >0, <100, good values are in the range 80 .. 95
		/// </summary>
		[FieldOffset(720)]
		public float AutoExposureHighPercent;
		/// <summary>
		/// A good value should be positive near 0. This is the minimum brightness the auto exposure can adapt to.
		/// It should be tweaked in a dark lighting situation (too small: image appears too bright, too large: image appears too dark).
		/// Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global
		/// effect and defined the HDR range - you don't want to change that late in the project development.
		/// Eye Adaptation is disabled if MinBrightness = MaxBrightness
		/// </summary>
		[FieldOffset(724)]
		public float AutoExposureMinBrightness;
		/// <summary>
		/// A good value should be positive (2 is a good value). This is the maximum brightness the auto exposure can adapt to.
		/// It should be tweaked in a bright lighting situation (too small: image appears too bright, too large: image appears too dark).
		/// Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global
		/// effect and defined the HDR range - you don't want to change that late in the project development.
		/// Eye Adaptation is disabled if MinBrightness = MaxBrightness
		/// </summary>
		[FieldOffset(728)]
		public float AutoExposureMaxBrightness;
		/// <summary>>0</summary>
		[FieldOffset(732)]
		public float AutoExposureSpeedUp;
		/// <summary>>0</summary>
		[FieldOffset(736)]
		public float AutoExposureSpeedDown;
		/// <summary>
		/// Logarithmic adjustment for the exposure. Only used if a tonemapper is specified.
		/// 0: no adjustment, -1:2x darker, -2:4x darker, 1:2x brighter, 2:4x brighter, ...
		/// </summary>
		[FieldOffset(740)]
		public float AutoExposureBias;
		/// <summary>temporary exposed until we found good values, -8: 1/256, -10: 1/1024</summary>
		[FieldOffset(744)]
		public float HistogramLogMin;
		/// <summary>temporary exposed until we found good values 4: 16, 8: 256</summary>
		[FieldOffset(748)]
		public float HistogramLogMax;
		/// <summary>Brightness scale of the image cased lens flares (linear)</summary>
		[FieldOffset(752)]
		public float LensFlareIntensity;
		/// <summary>Tint color for the image based lens flares.</summary>
		[FieldOffset(756)]
		public FLinearColor LensFlareTint;
		/// <summary>Size of the Lens Blur (in percent of the view width) that is done with the Bokeh texture (note: performance cost is radius*radius)</summary>
		[FieldOffset(772)]
		public float LensFlareBokehSize;
		/// <summary>Minimum brightness the lens flare starts having effect (this should be as high as possible to avoid the performance cost of blurring content that is too dark too see)</summary>
		[FieldOffset(776)]
		public float LensFlareThreshold;
		/// <summary>Defines the shape of the Bokeh when the image base lens flares are blurred, cannot be blended</summary>
		/// <summary>RGB defines the lens flare color, A it's position. This is a temporary solution.</summary>
		[FieldOffset(792)]
		public FLinearColor LensFlareTints;
		/// <summary>0..1 0=off/no vignette .. 1=strong vignette</summary>
		[FieldOffset(920)]
		public float VignetteIntensity;
		/// <summary>0..1 grain jitter</summary>
		[FieldOffset(924)]
		public float GrainJitter;
		/// <summary>0..1 grain intensity</summary>
		[FieldOffset(928)]
		public float GrainIntensity;
		/// <summary>0..1 0=off/no ambient occlusion .. 1=strong ambient occlusion, defines how much it affects the non direct lighting after base pass</summary>
		[FieldOffset(932)]
		public float AmbientOcclusionIntensity;
		/// <summary>0..1 0=no effect on static lighting .. 1=AO affects the stat lighting, 0 is free meaning no extra rendering pass</summary>
		[FieldOffset(936)]
		public float AmbientOcclusionStaticFraction;
		/// <summary>>0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion</summary>
		[FieldOffset(940)]
		public float AmbientOcclusionRadius;
		/// <summary>true: AO radius is in world space units, false: AO radius is locked the view space in 400 units</summary>
		public bool AmbientOcclusionRadiusInWS
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 944, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 944, 1, 0, 1, 1); } }}
			
		}
		/// <summary>>0, in unreal units, at what distance the AO effect disppears in the distance (avoding artifacts and AO effects on huge object)</summary>
		[FieldOffset(948)]
		public float AmbientOcclusionFadeDistance;
		/// <summary>>0, in unreal units, how many units before AmbientOcclusionFadeOutDistance it starts fading out</summary>
		[FieldOffset(952)]
		public float AmbientOcclusionFadeRadius;
		/// <summary>>0, in unreal units, how wide the ambient occlusion effect should affect the geometry (in depth), will be removed - only used for non normal method which is not exposed</summary>
		[FieldOffset(956)]
		public float AmbientOcclusionDistance;
		/// <summary>>0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion</summary>
		[FieldOffset(960)]
		public float AmbientOcclusionPower;
		/// <summary>>0, in unreal units, default (3.0) works well for flat surfaces but can reduce details</summary>
		[FieldOffset(964)]
		public float AmbientOcclusionBias;
		/// <summary>0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition</summary>
		[FieldOffset(968)]
		public float AmbientOcclusionQuality;
		/// <summary>Affects the blend over the multiple mips (lower resolution versions) , 0:fully use full resolution, 1::fully use low resolution, around 0.6 seems to be a good value</summary>
		[FieldOffset(972)]
		public float AmbientOcclusionMipBlend;
		/// <summary>Affects the radius AO radius scale over the multiple mips (lower resolution versions)</summary>
		[FieldOffset(976)]
		public float AmbientOcclusionMipScale;
		/// <summary>to tweak the bilateral upsampling when using multiple mips (lower resolution versions)</summary>
		[FieldOffset(980)]
		public float AmbientOcclusionMipThreshold;
		/// <summary>Adjusts indirect lighting color. (1,1,1) is default. (0,0,0) to disable GI. The show flag 'Global Illumination' must be enabled to use this property.</summary>
		[FieldOffset(984)]
		public FLinearColor IndirectLightingColor;
		/// <summary>Scales the indirect lighting contribution. A value of 0 disables GI. Default is 1. The show flag 'Global Illumination' must be enabled to use this property.</summary>
		[FieldOffset(1000)]
		public float IndirectLightingIntensity;
		/// <summary>Color grading lookup table intensity. 0 = no intensity, 1=full intensity</summary>
		[FieldOffset(1004)]
		public float ColorGradingIntensity;
		/// <summary>Look up table texture to use or none of not used</summary>
		/// <summary>BokehDOF, Simple gaussian, ... Mobile supports Gaussian only.</summary>
		[FieldOffset(1016)]
		public EDepthOfFieldMethod DepthOfFieldMethod;
		/// <summary>Enable HQ Gaussian on high end mobile platforms. (ES3_1)</summary>
		public bool bMobileHQGaussian
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1020, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1020, 1, 0, 1, 1); } }}
			
		}
		/// <summary>CircleDOF only: Defines the opening of the camera lens, Aperture is 1/fstop, typical lens go down to f/1.2 (large opening), larger numbers reduce the DOF effect</summary>
		[FieldOffset(1024)]
		public float DepthOfFieldFstop;
		/// <summary>Width of the camera sensor to assume, in mm.</summary>
		[FieldOffset(1028)]
		public float DepthOfFieldSensorWidth;
		/// <summary>Distance in which the Depth of Field effect should be sharp, in unreal units (cm)</summary>
		[FieldOffset(1032)]
		public float DepthOfFieldFocalDistance;
		/// <summary>CircleDOF only: Depth blur km for 50%</summary>
		[FieldOffset(1036)]
		public float DepthOfFieldDepthBlurAmount;
		/// <summary>CircleDOF only: Depth blur radius in pixels at 1920x</summary>
		[FieldOffset(1040)]
		public float DepthOfFieldDepthBlurRadius;
		/// <summary>Artificial region where all content is in focus, starting after DepthOfFieldFocalDistance, in unreal units  (cm)</summary>
		[FieldOffset(1044)]
		public float DepthOfFieldFocalRegion;
		/// <summary>To define the width of the transition region next to the focal region on the near side (cm)</summary>
		[FieldOffset(1048)]
		public float DepthOfFieldNearTransitionRegion;
		/// <summary>To define the width of the transition region next to the focal region on the near side (cm)</summary>
		[FieldOffset(1052)]
		public float DepthOfFieldFarTransitionRegion;
		/// <summary>
		/// SM5: BokehDOF only: To amplify the depth of field effect (like aperture)  0=off
		///           ES2: Used to blend DoF. 0=off
		/// </summary>
		[FieldOffset(1056)]
		public float DepthOfFieldScale;
		/// <summary>BokehDOF only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size*size)</summary>
		[FieldOffset(1060)]
		public float DepthOfFieldMaxBokehSize;
		/// <summary>Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size)</summary>
		[FieldOffset(1064)]
		public float DepthOfFieldNearBlurSize;
		/// <summary>Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size)</summary>
		[FieldOffset(1068)]
		public float DepthOfFieldFarBlurSize;
		/// <summary>Defines the shape of the Bokeh when object get out of focus, cannot be blended</summary>
		/// <summary>Occlusion tweak factor 1 (0.18 to get natural occlusion, 0.4 to solve layer color leaking issues)</summary>
		[FieldOffset(1080)]
		public float DepthOfFieldOcclusion;
		/// <summary>Color threshold to do full quality DOF (BokehDOF only)</summary>
		[FieldOffset(1084)]
		public float DepthOfFieldColorThreshold;
		/// <summary>Size threshold to do full quality DOF (BokehDOF only)</summary>
		[FieldOffset(1088)]
		public float DepthOfFieldSizeThreshold;
		/// <summary>Artificial distance to allow the skybox to be in focus (e.g. 200000), <=0 to switch the feature off, only for GaussianDOF, can cost performance</summary>
		[FieldOffset(1092)]
		public float DepthOfFieldSkyFocusDistance;
		/// <summary>Artificial circular mask to (near) blur content outside the radius, only for GaussianDOF, diameter in percent of screen width, costs performance if the mask is used, keep Feather can Radius on default to keep it off</summary>
		[FieldOffset(1096)]
		public float DepthOfFieldVignetteSize;
		/// <summary>Strength of motion blur, 0:off, should be renamed to intensity</summary>
		[FieldOffset(1100)]
		public float MotionBlurAmount;
		/// <summary>max distortion caused by motion blur, in percent of the screen width, 0:off</summary>
		[FieldOffset(1104)]
		public float MotionBlurMax;
		/// <summary>The minimum projected screen radius for a primitive to be drawn in the velocity pass, percentage of screen width. smaller numbers cause more draw calls, default: 4%</summary>
		[FieldOffset(1108)]
		public float MotionBlurPerObjectSize;
		/// <summary>How strong the dynamic GI from the LPV should be. 0.0 is off, 1.0 is the "normal" value, but higher values can be used to boost the effect</summary>
		[FieldOffset(1112)]
		public float LPVIntensity;
		/// <summary>Bias applied to light injected into the LPV in cell units. Increase to reduce bleeding through thin walls</summary>
		[FieldOffset(1116)]
		public float LPVVplInjectionBias;
		/// <summary>The size of the LPV volume, in Unreal units</summary>
		[FieldOffset(1120)]
		public float LPVSize;
		/// <summary>Secondary occlusion strength (bounce light shadows). Set to 0 to disable</summary>
		[FieldOffset(1124)]
		public float LPVSecondaryOcclusionIntensity;
		/// <summary>Secondary bounce light strength (bounce light shadows). Set to 0 to disable</summary>
		[FieldOffset(1128)]
		public float LPVSecondaryBounceIntensity;
		/// <summary>Bias applied to the geometry volume in cell units. Increase to reduce darkening due to secondary occlusion</summary>
		[FieldOffset(1132)]
		public float LPVGeometryVolumeBias;
		[FieldOffset(1136)]
		public float LPVEmissiveInjectionIntensity;
		/// <summary>Controls the amount of directional occlusion. Requires LPV. Values very close to 1.0 are recommended</summary>
		[FieldOffset(1140)]
		public float LPVDirectionalOcclusionIntensity;
		/// <summary>Occlusion Radius - 16 is recommended for most scenes</summary>
		[FieldOffset(1144)]
		public float LPVDirectionalOcclusionRadius;
		/// <summary>Diffuse occlusion exponent - increase for more contrast. 1 to 2 is recommended</summary>
		[FieldOffset(1148)]
		public float LPVDiffuseOcclusionExponent;
		/// <summary>Specular occlusion exponent - increase for more contrast. 6 to 9 is recommended</summary>
		[FieldOffset(1152)]
		public float LPVSpecularOcclusionExponent;
		/// <summary>Diffuse occlusion intensity - higher values provide increased diffuse occlusion.</summary>
		[FieldOffset(1156)]
		public float LPVDiffuseOcclusionIntensity;
		/// <summary>Specular occlusion intensity - higher values provide increased specular occlusion.</summary>
		[FieldOffset(1160)]
		public float LPVSpecularOcclusionIntensity;
		/// <summary>Enable/Fade/disable the Screen Space Reflection feature, in percent, avoid numbers between 0 and 1 fo consistency</summary>
		[FieldOffset(1164)]
		public float ScreenSpaceReflectionIntensity;
		/// <summary>0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition, 50 is the default for better performance.</summary>
		[FieldOffset(1168)]
		public float ScreenSpaceReflectionQuality;
		/// <summary>Until what roughness we fade the screen space reflections, 0.8 works well, smaller can run faster</summary>
		[FieldOffset(1172)]
		public float ScreenSpaceReflectionMaxRoughness;
		/// <summary>
		/// To render with lower or high resolution than it is presented,
		/// controlled by console variable,
		/// 100:off, needs to be <99 to get upsampling and lower to get performance,
		/// >100 for super sampling (slower but higher quality),
		/// only applied in game
		/// </summary>
		[FieldOffset(1176)]
		public float ScreenPercentage;
		/// <summary>
		/// Allows custom post process materials to be defined, using a MaterialInstance with the same Material as its parent to allow blending.
		/// For materials this needs to be the "PostProcess" domain type. This can be used for any UObject object implementing the IBlendableInterface (e.g. could be used to fade weather settings).
		/// </summary>
		[FieldOffset(1184)]
		public FWeightedBlendables WeightedBlendables;
		/// <summary>for backwards compatibility</summary>
		public TObjectArray<UObject> Blendables
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+1200, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+1200, false);}}}
			
		}
		
	}
	
}
#endif
#endif
