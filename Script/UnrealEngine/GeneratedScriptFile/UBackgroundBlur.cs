using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBackgroundBlur:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLowQualityFallbackBrush(IntPtr _this,ref FSlateBrush InBrush);
public  void SetLowQualityFallbackBrush(FSlateBrush InBrush)
{
	CheckIsValid();
	SetLowQualityFallbackBrush(_this.Get(),ref InBrush);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBlurStrength(IntPtr _this,float InStrength);
public  void SetBlurStrength(float InStrength)
{
	CheckIsValid();
	SetBlurStrength(_this.Get(),InStrength);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBlurRadius(IntPtr _this,int InBlurRadius);
public  void SetBlurRadius(int InBlurRadius)
{
	CheckIsValid();
	SetBlurRadius(_this.Get(),InBlurRadius);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetApplyAlphaToBlur(IntPtr _this,int bInApplyAlphaToBlur);
public  void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur)
{
	CheckIsValid();
	SetApplyAlphaToBlur(_this.Get(),bInApplyAlphaToBlur?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVerticalAlignment(IntPtr _this,int InVerticalAlignment);
public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
{
	CheckIsValid();
	SetVerticalAlignment(_this.Get(),(int)InVerticalAlignment);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHorizontalAlignment(IntPtr _this,int InHorizontalAlignment);
public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
{
	CheckIsValid();
	SetHorizontalAlignment(_this.Get(),(int)InHorizontalAlignment);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPadding(IntPtr _this,ref FMargin InPadding);
public  void SetPadding(FMargin InPadding)
{
	CheckIsValid();
	SetPadding(_this.Get(),ref InPadding);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
