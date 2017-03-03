#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBackgroundBlur
	{
		static readonly int Padding__Offset;
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Padding__Offset, false);}
			
		}
		
		static readonly int HorizontalAlignment__Offset;
		public EHorizontalAlignment HorizontalAlignment
		{
			get{ CheckIsValid();return (EHorizontalAlignment)Marshal.PtrToStructure(_this.Get()+HorizontalAlignment__Offset, typeof(EHorizontalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizontalAlignment__Offset, false);}
			
		}
		
		static readonly int VerticalAlignment__Offset;
		public EVerticalAlignment VerticalAlignment
		{
			get{ CheckIsValid();return (EVerticalAlignment)Marshal.PtrToStructure(_this.Get()+VerticalAlignment__Offset, typeof(EVerticalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalAlignment__Offset, false);}
			
		}
		
		static readonly int bApplyAlphaToBlur__Offset;
		public bool bApplyAlphaToBlur
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyAlphaToBlur__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyAlphaToBlur__Offset, 1,0,1,255);}
			
		}
		
		static readonly int BlurStrength__Offset;
		public float BlurStrength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlurStrength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlurStrength__Offset, false);}
			
		}
		
		static readonly int bOverrideAutoRadiusCalculation__Offset;
		public bool bOverrideAutoRadiusCalculation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideAutoRadiusCalculation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BlurRadius__Offset;
		public int BlurRadius
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BlurRadius__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlurRadius__Offset, false);}
			
		}
		
		static readonly int LowQualityFallbackBrush__Offset;
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
