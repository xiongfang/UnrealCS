using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USlider:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSliderHandleColor(IntPtr _this,ref FLinearColor InValue);
/// <summary>Sets the color of the handle bar</summary>
public  void SetSliderHandleColor(FLinearColor InValue)
{
	CheckIsValid();
	SetSliderHandleColor(_this.Get(),ref InValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSliderBarColor(IntPtr _this,ref FLinearColor InValue);
/// <summary>Sets the color of the slider bar</summary>
public  void SetSliderBarColor(FLinearColor InValue)
{
	CheckIsValid();
	SetSliderBarColor(_this.Get(),ref InValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStepSize(IntPtr _this,float InValue);
/// <summary>Sets the amount to adjust the value by, when using a controller or keyboard</summary>
public  void SetStepSize(float InValue)
{
	CheckIsValid();
	SetStepSize(_this.Get(),InValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLocked(IntPtr _this,int InValue);
/// <summary>Sets the handle to be interactive or fixed</summary>
public  void SetLocked(bool InValue)
{
	CheckIsValid();
	SetLocked(_this.Get(),InValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIndentHandle(IntPtr _this,int InValue);
/// <summary>Sets if the slidable area should be indented to fit the handle</summary>
public  void SetIndentHandle(bool InValue)
{
	CheckIsValid();
	SetIndentHandle(_this.Get(),InValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetValue(IntPtr _this,float InValue);
/// <summary>Sets the current value of the slider.</summary>
public  void SetValue(float InValue)
{
	CheckIsValid();
	SetValue(_this.Get(),InValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetValue(IntPtr _this);
/// <summary>Gets the current value of the slider.</summary>
public  float GetValue()
{
	CheckIsValid();
	float ___ret = GetValue(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
