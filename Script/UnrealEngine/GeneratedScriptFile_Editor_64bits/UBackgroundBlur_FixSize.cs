#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A background blur is a container widget that can contain one child widget, providing an opportunity
	/// to surround it with adjustable padding and apply a post-process Gaussian blur to all content beneath the widget.
	/// * Single Child
	/// * Blur Effect
	/// </summary>
	public partial class UBackgroundBlur
	{
		static readonly int Padding__Offset;
		/// <summary>The padding area between the slot and the content it contains.</summary>
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Padding__Offset, false);}
			
		}
		
		static readonly int HorizontalAlignment__Offset;
		/// <summary>The alignment of the content horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment
		{
			get{ CheckIsValid();return (EHorizontalAlignment)Marshal.PtrToStructure(_this.Get()+HorizontalAlignment__Offset, typeof(EHorizontalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizontalAlignment__Offset, false);}
			
		}
		
		static readonly int VerticalAlignment__Offset;
		/// <summary>The alignment of the content vertically.</summary>
		public EVerticalAlignment VerticalAlignment
		{
			get{ CheckIsValid();return (EVerticalAlignment)Marshal.PtrToStructure(_this.Get()+VerticalAlignment__Offset, typeof(EVerticalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalAlignment__Offset, false);}
			
		}
		
		static readonly int bApplyAlphaToBlur__Offset;
		/// <summary>True to modulate the strength of the blur based on the widget alpha.</summary>
		public bool bApplyAlphaToBlur
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyAlphaToBlur__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyAlphaToBlur__Offset, 1,0,1,255);}
			
		}
		
		static readonly int BlurStrength__Offset;
		/// <summary>How blurry the background is.  Larger numbers mean more blurry but will result in larger runtime cost on the gpu.</summary>
		public float BlurStrength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlurStrength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlurStrength__Offset, false);}
			
		}
		
		static readonly int bOverrideAutoRadiusCalculation__Offset;
		/// <summary>Whether or not the radius should be computed automatically or if it should use the radius</summary>
		public bool bOverrideAutoRadiusCalculation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideAutoRadiusCalculation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BlurRadius__Offset;
		/// <summary>
		/// This is the number of pixels which will be weighted in each direction from any given pixel when computing the blur
		/// A larger value is more costly but allows for stronger blurs.
		/// </summary>
		public int BlurRadius
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BlurRadius__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlurRadius__Offset, false);}
			
		}
		
		static readonly int LowQualityFallbackBrush__Offset;
		/// <summary>
		/// An image to draw instead of applying a blur when low quality override mode is enabled.
		/// You can enable low quality mode for background blurs by setting the cvar Slate.ForceBackgroundBlurLowQualityOverride to 1.
		/// This is usually done in the project's scalability settings
		/// </summary>
		public FSlateBrush LowQualityFallbackBrush
		{
			get{ CheckIsValid();return (FSlateBrush)Marshal.PtrToStructure(_this.Get()+LowQualityFallbackBrush__Offset, typeof(FSlateBrush));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LowQualityFallbackBrush__Offset, false);}
			
		}
		
		static UBackgroundBlur()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BackgroundBlur");
			Padding__Offset=GetPropertyOffset(NativeClassPtr,"Padding");
			HorizontalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"HorizontalAlignment");
			VerticalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"VerticalAlignment");
			bApplyAlphaToBlur__Offset=GetPropertyOffset(NativeClassPtr,"bApplyAlphaToBlur");
			BlurStrength__Offset=GetPropertyOffset(NativeClassPtr,"BlurStrength");
			bOverrideAutoRadiusCalculation__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideAutoRadiusCalculation");
			BlurRadius__Offset=GetPropertyOffset(NativeClassPtr,"BlurRadius");
			LowQualityFallbackBrush__Offset=GetPropertyOffset(NativeClassPtr,"LowQualityFallbackBrush");
			
		}
		
	}
	
}
#endif
#endif
