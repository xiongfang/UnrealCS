using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USizeBox:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMaxAspectRatio(IntPtr _this);
public  void ClearMaxAspectRatio()
{
	CheckIsValid();
	ClearMaxAspectRatio(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaxAspectRatio(IntPtr _this,float InMaxAspectRatio);
public  void SetMaxAspectRatio(float InMaxAspectRatio)
{
	CheckIsValid();
	SetMaxAspectRatio(_this.Get(),InMaxAspectRatio);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMaxDesiredHeight(IntPtr _this);
public  void ClearMaxDesiredHeight()
{
	CheckIsValid();
	ClearMaxDesiredHeight(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaxDesiredHeight(IntPtr _this,float InMaxDesiredHeight);
/// <summary>When specified, will report the MaxDesiredHeight if smaller than the content's desired height.</summary>
public  void SetMaxDesiredHeight(float InMaxDesiredHeight)
{
	CheckIsValid();
	SetMaxDesiredHeight(_this.Get(),InMaxDesiredHeight);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMaxDesiredWidth(IntPtr _this);
public  void ClearMaxDesiredWidth()
{
	CheckIsValid();
	ClearMaxDesiredWidth(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaxDesiredWidth(IntPtr _this,float InMaxDesiredWidth);
/// <summary>When specified, will report the MaxDesiredWidth if smaller than the content's desired width.</summary>
public  void SetMaxDesiredWidth(float InMaxDesiredWidth)
{
	CheckIsValid();
	SetMaxDesiredWidth(_this.Get(),InMaxDesiredWidth);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMinDesiredHeight(IntPtr _this);
public  void ClearMinDesiredHeight()
{
	CheckIsValid();
	ClearMinDesiredHeight(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMinDesiredHeight(IntPtr _this,float InMinDesiredHeight);
/// <summary>When specified, will report the MinDesiredHeight if larger than the content's desired height.</summary>
public  void SetMinDesiredHeight(float InMinDesiredHeight)
{
	CheckIsValid();
	SetMinDesiredHeight(_this.Get(),InMinDesiredHeight);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMinDesiredWidth(IntPtr _this);
public  void ClearMinDesiredWidth()
{
	CheckIsValid();
	ClearMinDesiredWidth(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMinDesiredWidth(IntPtr _this,float InMinDesiredWidth);
/// <summary>When specified, will report the MinDesiredWidth if larger than the content's desired width.</summary>
public  void SetMinDesiredWidth(float InMinDesiredWidth)
{
	CheckIsValid();
	SetMinDesiredWidth(_this.Get(),InMinDesiredWidth);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearHeightOverride(IntPtr _this);
public  void ClearHeightOverride()
{
	CheckIsValid();
	ClearHeightOverride(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHeightOverride(IntPtr _this,float InHeightOverride);
/// <summary>When specified, ignore the content's desired size and report the HeightOverride as the Box's desired height.</summary>
public  void SetHeightOverride(float InHeightOverride)
{
	CheckIsValid();
	SetHeightOverride(_this.Get(),InHeightOverride);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearWidthOverride(IntPtr _this);
public  void ClearWidthOverride()
{
	CheckIsValid();
	ClearWidthOverride(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWidthOverride(IntPtr _this,float InWidthOverride);
/// <summary>When specified, ignore the content's desired size and report the WidthOverride as the Box's desired width.</summary>
public  void SetWidthOverride(float InWidthOverride)
{
	CheckIsValid();
	SetWidthOverride(_this.Get(),InWidthOverride);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
