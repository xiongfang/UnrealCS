using System;
namespace UnrealEngine
{
	public partial class UBackgroundBlur:UContentWidget
	{
		public extern void SetLowQualityFallbackBrush(FSlateBrush InBrush);
		public extern virtual void SetBlurStrength(float InStrength);
		public extern void SetBlurRadius(int InBlurRadius);
		public extern void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur);
		public extern void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment);
		public extern void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment);
		public extern void SetPadding(FMargin InPadding);
		/// <summary>The padding area between the slot and the content it contains.</summary>
		public FMargin Padding;
		
		/// <summary>The alignment of the content horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment;
		
		/// <summary>The alignment of the content vertically.</summary>
		public EVerticalAlignment VerticalAlignment;
		
		/// <summary>True to modulate the strength of the blur based on the widget alpha.</summary>
		public bool bApplyAlphaToBlur;
		
		/// <summary>How blurry the background is.  Larger numbers mean more blurry but will result in larger runtime cost on the gpu.</summary>
		public float BlurStrength;
		
		/// <summary>Whether or not the radius should be computed automatically or if it should use the radius</summary>
		public bool bOverrideAutoRadiusCalculation;
		
		/// <summary>
		/// This is the number of pixels which will be weighted in each direction from any given pixel when computing the blur
		/// A larger value is more costly but allows for stronger blurs.
		/// </summary>
		public int BlurRadius;
		
		/// <summary>
		/// An image to draw instead of applying a blur when low quality override mode is enabled.
		/// You can enable low quality mode for background blurs by setting the cvar Slate.ForceBackgroundBlurLowQualityOverride to 1.
		/// This is usually done in the project's scalability settings
		/// </summary>
		public FSlateBrush LowQualityFallbackBrush;
		
		
	}
	
}
