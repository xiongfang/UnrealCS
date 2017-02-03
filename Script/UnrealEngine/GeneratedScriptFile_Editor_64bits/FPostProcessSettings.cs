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
	[StructLayout(LayoutKind.Explicit,Size=928)]
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
		/// <summary>Scene tint color</summary>
		[FieldOffset(212)]
		public FLinearColor SceneColorTint;
		/// <summary>in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners.</summary>
		[FieldOffset(228)]
		public float SceneFringeIntensity;
		/// <summary>Multiplier for all bloom contributions >=0: off, 1(default), >1 brighter</summary>
		[FieldOffset(232)]
		public float BloomIntensity;
		/// <summary>
		/// minimum brightness the bloom starts having effect
		/// -1:all pixels affect bloom equally (physically correct, faster as a threshold pass is omitted), 0:all pixels affect bloom brights more, 1(default), >1 brighter
		/// </summary>
		[FieldOffset(236)]
		public float BloomThreshold;
		/// <summary>Scale for all bloom sizes</summary>
		[FieldOffset(240)]
		public float BloomSizeScale;
		/// <summary>
		/// Diameter size for the Bloom1 in percent of the screen width
		/// (is done in 1/2 resolution, larger values cost more performance, good for high frequency details)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(244)]
		public float Bloom1Size;
		/// <summary>
		/// Diameter size for Bloom2 in percent of the screen width
		/// (is done in 1/4 resolution, larger values cost more performance)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(248)]
		public float Bloom2Size;
		/// <summary>
		/// Diameter size for Bloom3 in percent of the screen width
		/// (is done in 1/8 resolution, larger values cost more performance)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(252)]
		public float Bloom3Size;
		/// <summary>
		/// Diameter size for Bloom4 in percent of the screen width
		/// (is done in 1/16 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(256)]
		public float Bloom4Size;
		/// <summary>
		/// Diameter size for Bloom5 in percent of the screen width
		/// (is done in 1/32 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(260)]
		public float Bloom5Size;
		/// <summary>
		/// Diameter size for Bloom6 in percent of the screen width
		/// (is done in 1/64 resolution, larger values cost more performance, best for wide contributions)
		/// >=0: can be clamped because of shader limitations
		/// </summary>
		[FieldOffset(264)]
		public float Bloom6Size;
		/// <summary>Bloom1 tint color</summary>
		[FieldOffset(268)]
		public FLinearColor Bloom1Tint;
		/// <summary>Bloom2 tint color</summary>
		[FieldOffset(284)]
		public FLinearColor Bloom2Tint;
		/// <summary>Bloom3 tint color</summary>
		[FieldOffset(300)]
		public FLinearColor Bloom3Tint;
		/// <summary>Bloom4 tint color</summary>
		[FieldOffset(316)]
		public FLinearColor Bloom4Tint;
		/// <summary>Bloom5 tint color</summary>
		[FieldOffset(332)]
		public FLinearColor Bloom5Tint;
		/// <summary>Bloom6 tint color</summary>
		[FieldOffset(348)]
		public FLinearColor Bloom6Tint;
		/// <summary>BloomDirtMask intensity</summary>
		[FieldOffset(364)]
		public float BloomDirtMaskIntensity;
		/// <summary>BloomDirtMask tint color</summary>
		[FieldOffset(368)]
		public FLinearColor BloomDirtMaskTint;
		/// <summary>Texture that defines the dirt on the camera lens where the light of very bright objects is scattered.</summary>
		/// <summary>How strong the dynamic GI from the LPV should be. 0.0 is off, 1.0 is the "normal" value, but higher values can be used to boost the effect</summary>
		[FieldOffset(392)]
		public float LPVIntensity;
		/// <summary>Bias applied to light injected into the LPV in cell units. Increase to reduce bleeding through thin walls</summary>
		[FieldOffset(396)]
		public float LPVVplInjectionBias;
		/// <summary>The size of the LPV volume, in Unreal units</summary>
		[FieldOffset(400)]
		public float LPVSize;
		/// <summary>Secondary occlusion strength (bounce light shadows). Set to 0 to disable</summary>
		[FieldOffset(404)]
		public float LPVSecondaryOcclusionIntensity;
		/// <summary>Secondary bounce light strength (bounce light shadows). Set to 0 to disable</summary>
		[FieldOffset(408)]
		public float LPVSecondaryBounceIntensity;
		/// <summary>Bias applied to the geometry volume in cell units. Increase to reduce darkening due to secondary occlusion</summary>
		[FieldOffset(412)]
		public float LPVGeometryVolumeBias;
		[FieldOffset(416)]
		public float LPVEmissiveInjectionIntensity;
		/// <summary>Controls the amount of directional occlusion. Requires LPV. Values very close to 1.0 are recommended</summary>
		[FieldOffset(420)]
		public float LPVDirectionalOcclusionIntensity;
		/// <summary>Occlusion Radius - 16 is recommended for most scenes</summary>
		[FieldOffset(424)]
		public float LPVDirectionalOcclusionRadius;
		/// <summary>Diffuse occlusion exponent - increase for more contrast. 1 to 2 is recommended</summary>
		[FieldOffset(428)]
		public float LPVDiffuseOcclusionExponent;
		/// <summary>Specular occlusion exponent - increase for more contrast. 6 to 9 is recommended</summary>
		[FieldOffset(432)]
		public float LPVSpecularOcclusionExponent;
		/// <summary>Diffuse occlusion intensity - higher values provide increased diffuse occlusion.</summary>
		[FieldOffset(436)]
		public float LPVDiffuseOcclusionIntensity;
		/// <summary>Specular occlusion intensity - higher values provide increased specular occlusion.</summary>
		[FieldOffset(440)]
		public float LPVSpecularOcclusionIntensity;
		/// <summary>AmbientCubemap tint color</summary>
		[FieldOffset(444)]
		public FLinearColor AmbientCubemapTint;
		/// <summary>
		/// To scale the Ambient cubemap brightness
		/// >=0: off, 1(default), >1 brighter
		/// </summary>
		[FieldOffset(460)]
		public float AmbientCubemapIntensity;
		/// <summary>The Ambient cubemap (Affects diffuse and specular shading), blends additively which if different from all other settings here</summary>
		/// <summary>Luminance computation method</summary>
		[FieldOffset(472)]
		public EAutoExposureMethod AutoExposureMethod;
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// bright spots.
		/// >0, <100, good values are in the range 70 .. 80
		/// </summary>
		[FieldOffset(476)]
		public float AutoExposureLowPercent;
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// bright spots.
		/// >0, <100, good values are in the range 80 .. 95
		/// </summary>
		[FieldOffset(480)]
		public float AutoExposureHighPercent;
		/// <summary>
		/// A good value should be positive near 0. This is the minimum brightness the auto exposure can adapt to.
		/// It should be tweaked in a dark lighting situation (too small: image appears too bright, too large: image appears too dark).
		/// Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global
		/// effect and defined the HDR range - you don't want to change that late in the project development.
		/// Eye Adaptation is disabled if MinBrightness = MaxBrightness
		/// </summary>
		[FieldOffset(484)]
		public float AutoExposureMinBrightness;
		/// <summary>
		/// A good value should be positive (2 is a good value). This is the maximum brightness the auto exposure can adapt to.
		/// It should be tweaked in a bright lighting situation (too small: image appears too bright, too large: image appears too dark).
		/// Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global
		/// effect and defined the HDR range - you don't want to change that late in the project development.
		/// Eye Adaptation is disabled if MinBrightness = MaxBrightness
		/// </summary>
		[FieldOffset(488)]
		public float AutoExposureMaxBrightness;
		/// <summary>>0</summary>
		[FieldOffset(492)]
		public float AutoExposureSpeedUp;
		/// <summary>>0</summary>
		[FieldOffset(496)]
		public float AutoExposureSpeedDown;
		/// <summary>
		/// Logarithmic adjustment for the exposure. Only used if a tonemapper is specified.
		/// 0: no adjustment, -1:2x darker, -2:4x darker, 1:2x brighter, 2:4x brighter, ...
		/// </summary>
		[FieldOffset(500)]
		public float AutoExposureBias;
		/// <summary>temporary exposed until we found good values, -8: 1/256, -10: 1/1024</summary>
		[FieldOffset(504)]
		public float HistogramLogMin;
		/// <summary>temporary exposed until we found good values 4: 16, 8: 256</summary>
		[FieldOffset(508)]
		public float HistogramLogMax;
		/// <summary>Brightness scale of the image cased lens flares (linear)</summary>
		[FieldOffset(512)]
		public float LensFlareIntensity;
		/// <summary>Tint color for the image based lens flares.</summary>
		[FieldOffset(516)]
		public FLinearColor LensFlareTint;
		/// <summary>Size of the Lens Blur (in percent of the view width) that is done with the Bokeh texture (note: performance cost is radius*radius)</summary>
		[FieldOffset(532)]
		public float LensFlareBokehSize;
		/// <summary>Minimum brightness the lens flare starts having effect (this should be as high as possible to avoid the performance cost of blurring content that is too dark too see)</summary>
		[FieldOffset(536)]
		public float LensFlareThreshold;
		/// <summary>Defines the shape of the Bokeh when the image base lens flares are blurred, cannot be blended</summary>
		/// <summary>RGB defines the lens flare color, A it's position. This is a temporary solution.</summary>
		[FieldOffset(552)]
		public FLinearColor LensFlareTints;
		/// <summary>0..1 0=off/no vignette .. 1=strong vignette</summary>
		[FieldOffset(680)]
		public float VignetteIntensity;
		/// <summary>0..1 grain jitter</summary>
		[FieldOffset(684)]
		public float GrainJitter;
		/// <summary>0..1 grain intensity</summary>
		[FieldOffset(688)]
		public float GrainIntensity;
		/// <summary>0..1 0=off/no ambient occlusion .. 1=strong ambient occlusion, defines how much it affects the non direct lighting after base pass</summary>
		[FieldOffset(692)]
		public float AmbientOcclusionIntensity;
		/// <summary>0..1 0=no effect on static lighting .. 1=AO affects the stat lighting, 0 is free meaning no extra rendering pass</summary>
		[FieldOffset(696)]
		public float AmbientOcclusionStaticFraction;
		/// <summary>>0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion</summary>
		[FieldOffset(700)]
		public float AmbientOcclusionRadius;
		/// <summary>true: AO radius is in world space units, false: AO radius is locked the view space in 400 units</summary>
		public bool AmbientOcclusionRadiusInWS
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 704, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 704, 1, 0, 1, 1); } }}
			
		}
		/// <summary>>0, in unreal units, at what distance the AO effect disppears in the distance (avoding artifacts and AO effects on huge object)</summary>
		[FieldOffset(708)]
		public float AmbientOcclusionFadeDistance;
		/// <summary>>0, in unreal units, how many units before AmbientOcclusionFadeOutDistance it starts fading out</summary>
		[FieldOffset(712)]
		public float AmbientOcclusionFadeRadius;
		/// <summary>>0, in unreal units, how wide the ambient occlusion effect should affect the geometry (in depth), will be removed - only used for non normal method which is not exposed</summary>
		[FieldOffset(716)]
		public float AmbientOcclusionDistance;
		/// <summary>>0, in unreal units, bigger values means even distant surfaces affect the ambient occlusion</summary>
		[FieldOffset(720)]
		public float AmbientOcclusionPower;
		/// <summary>>0, in unreal units, default (3.0) works well for flat surfaces but can reduce details</summary>
		[FieldOffset(724)]
		public float AmbientOcclusionBias;
		/// <summary>0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition</summary>
		[FieldOffset(728)]
		public float AmbientOcclusionQuality;
		/// <summary>Affects the blend over the multiple mips (lower resolution versions) , 0:fully use full resolution, 1::fully use low resolution, around 0.6 seems to be a good value</summary>
		[FieldOffset(732)]
		public float AmbientOcclusionMipBlend;
		/// <summary>Affects the radius AO radius scale over the multiple mips (lower resolution versions)</summary>
		[FieldOffset(736)]
		public float AmbientOcclusionMipScale;
		/// <summary>to tweak the bilateral upsampling when using multiple mips (lower resolution versions)</summary>
		[FieldOffset(740)]
		public float AmbientOcclusionMipThreshold;
		/// <summary>Adjusts indirect lighting color. (1,1,1) is default. (0,0,0) to disable GI. The show flag 'Global Illumination' must be enabled to use this property.</summary>
		[FieldOffset(744)]
		public FLinearColor IndirectLightingColor;
		/// <summary>Scales the indirect lighting contribution. A value of 0 disables GI. Default is 1. The show flag 'Global Illumination' must be enabled to use this property.</summary>
		[FieldOffset(760)]
		public float IndirectLightingIntensity;
		/// <summary>0..1=full intensity</summary>
		[FieldOffset(764)]
		public float ColorGradingIntensity;
		/// <summary>Name of the LUT texture e.g. MyPackage01.LUTNeutral, empty if not used</summary>
		/// <summary>BokehDOF, Simple gaussian, ... Mobile supports Gaussian only.</summary>
		[FieldOffset(776)]
		public EDepthOfFieldMethod DepthOfFieldMethod;
		/// <summary>Enable HQ Gaussian on high end mobile platforms. (ES3_1)</summary>
		public bool bMobileHQGaussian
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 780, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 780, 1, 0, 1, 1); } }}
			
		}
		/// <summary>CircleDOF only: Defines the opening of the camera lens, Aperture is 1/fstop, typical lens go down to f/1.2 (large opening), larger numbers reduce the DOF effect</summary>
		[FieldOffset(784)]
		public float DepthOfFieldFstop;
		/// <summary>Width of the camera sensor to assume, in mm.</summary>
		[FieldOffset(788)]
		public float DepthOfFieldSensorWidth;
		/// <summary>Distance in which the Depth of Field effect should be sharp, in unreal units (cm)</summary>
		[FieldOffset(792)]
		public float DepthOfFieldFocalDistance;
		/// <summary>CircleDOF only: Depth blur km for 50%</summary>
		[FieldOffset(796)]
		public float DepthOfFieldDepthBlurAmount;
		/// <summary>CircleDOF only: Depth blur radius in pixels at 1920x</summary>
		[FieldOffset(800)]
		public float DepthOfFieldDepthBlurRadius;
		/// <summary>Artificial region where all content is in focus, starting after DepthOfFieldFocalDistance, in unreal units  (cm)</summary>
		[FieldOffset(804)]
		public float DepthOfFieldFocalRegion;
		/// <summary>To define the width of the transition region next to the focal region on the near side (cm)</summary>
		[FieldOffset(808)]
		public float DepthOfFieldNearTransitionRegion;
		/// <summary>To define the width of the transition region next to the focal region on the near side (cm)</summary>
		[FieldOffset(812)]
		public float DepthOfFieldFarTransitionRegion;
		/// <summary>
		/// SM5: BokehDOF only: To amplify the depth of field effect (like aperture)  0=off
		///           ES2: Used to blend DoF. 0=off
		/// </summary>
		[FieldOffset(816)]
		public float DepthOfFieldScale;
		/// <summary>BokehDOF only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size*size)</summary>
		[FieldOffset(820)]
		public float DepthOfFieldMaxBokehSize;
		/// <summary>Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size)</summary>
		[FieldOffset(824)]
		public float DepthOfFieldNearBlurSize;
		/// <summary>Gaussian only: Maximum size of the Depth of Field blur (in percent of the view width) (note: performance cost scales with size)</summary>
		[FieldOffset(828)]
		public float DepthOfFieldFarBlurSize;
		/// <summary>Defines the shape of the Bokeh when object get out of focus, cannot be blended</summary>
		/// <summary>Occlusion tweak factor 1 (0.18 to get natural occlusion, 0.4 to solve layer color leaking issues)</summary>
		[FieldOffset(840)]
		public float DepthOfFieldOcclusion;
		/// <summary>Color threshold to do full quality DOF (BokehDOF only)</summary>
		[FieldOffset(844)]
		public float DepthOfFieldColorThreshold;
		/// <summary>Size threshold to do full quality DOF (BokehDOF only)</summary>
		[FieldOffset(848)]
		public float DepthOfFieldSizeThreshold;
		/// <summary>Artificial distance to allow the skybox to be in focus (e.g. 200000), <=0 to switch the feature off, only for GaussianDOF, can cost performance</summary>
		[FieldOffset(852)]
		public float DepthOfFieldSkyFocusDistance;
		/// <summary>Artificial circular mask to (near) blur content outside the radius, only for GaussianDOF, diameter in percent of screen width, costs performance if the mask is used, keep Feather can Radius on default to keep it off</summary>
		[FieldOffset(856)]
		public float DepthOfFieldVignetteSize;
		/// <summary>Strength of motion blur, 0:off, should be renamed to intensity</summary>
		[FieldOffset(860)]
		public float MotionBlurAmount;
		/// <summary>max distortion caused by motion blur, in percent of the screen width, 0:off</summary>
		[FieldOffset(864)]
		public float MotionBlurMax;
		/// <summary>The minimum projected screen radius for a primitive to be drawn in the velocity pass, percentage of screen width. smaller numbers cause more draw calls, default: 4%</summary>
		[FieldOffset(868)]
		public float MotionBlurPerObjectSize;
		/// <summary>
		/// To render with lower or high resolution than it is presented,
		/// controlled by console variable,
		/// 100:off, needs to be <99 to get upsampling and lower to get performance,
		/// >100 for super sampling (slower but higher quality),
		/// only applied in game
		/// </summary>
		[FieldOffset(872)]
		public float ScreenPercentage;
		/// <summary>TemporalAA, FXAA, ...</summary>
		[FieldOffset(876)]
		public EAntiAliasingMethod AntiAliasingMethod;
		/// <summary>Enable/Fade/disable the Screen Space Reflection feature, in percent, avoid numbers between 0 and 1 fo consistency</summary>
		[FieldOffset(880)]
		public float ScreenSpaceReflectionIntensity;
		/// <summary>0=lowest quality..100=maximum quality, only a few quality levels are implemented, no soft transition, 50 is the default for better performance.</summary>
		[FieldOffset(884)]
		public float ScreenSpaceReflectionQuality;
		/// <summary>Until what roughness we fade the screen space reflections, 0.8 works well, smaller can run faster</summary>
		[FieldOffset(888)]
		public float ScreenSpaceReflectionMaxRoughness;
		/// <summary>
		/// Allows custom post process materials to be defined, using a MaterialInstance with the same Material as its parent to allow blending.
		/// For materials this needs to be the "PostProcess" domain type. This can be used for any UObject object implementing the IBlendableInterface (e.g. could be used to fade weather settings).
		/// </summary>
		[FieldOffset(896)]
		public FWeightedBlendables WeightedBlendables;
		/// <summary>for backwards compatibility</summary>
		public TObjectArray<UObject> Blendables
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+912, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+912, false);}}}
			
		}
		
	}
	
}
#endif
#endif
