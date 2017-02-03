using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBorder:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDesiredSizeScale(IntPtr _this,ref FVector2D InScale);
/// <summary>
/// Sets the DesireSizeScale of this border.
/// @param InScale    The X and Y multipliers for the desired size
/// </summary>
public  void SetDesiredSizeScale(FVector2D InScale)
{
	CheckIsValid();
	SetDesiredSizeScale(_this.Get(),ref InScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetDynamicMaterial(IntPtr _this);
public  UMaterialInstanceDynamic GetDynamicMaterial()
{
	CheckIsValid();
	IntPtr ___ret = GetDynamicMaterial(_this.Get());
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrushFromMaterial(IntPtr _this,IntPtr Material);
public  void SetBrushFromMaterial(UMaterialInterface Material)
{
	CheckIsValid();
	SetBrushFromMaterial(_this.Get(),Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrushFromTexture(IntPtr _this,IntPtr Texture);
public  void SetBrushFromTexture(UTexture2D Texture)
{
	CheckIsValid();
	SetBrushFromTexture(_this.Get(),Texture);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrushFromAsset(IntPtr _this,IntPtr Asset);
public  void SetBrushFromAsset(USlateBrushAsset Asset)
{
	CheckIsValid();
	SetBrushFromAsset(_this.Get(),Asset);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrush(IntPtr _this,ref FSlateBrush InBrush);
public  void SetBrush(FSlateBrush InBrush)
{
	CheckIsValid();
	SetBrush(_this.Get(),ref InBrush);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrushColor(IntPtr _this,ref FLinearColor InBrushColor);
public  void SetBrushColor(FLinearColor InBrushColor)
{
	CheckIsValid();
	SetBrushColor(_this.Get(),ref InBrushColor);
	
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
extern static void SetContentColorAndOpacity(IntPtr _this,ref FLinearColor InContentColorAndOpacity);
public  void SetContentColorAndOpacity(FLinearColor InContentColorAndOpacity)
{
	CheckIsValid();
	SetContentColorAndOpacity(_this.Get(),ref InContentColorAndOpacity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
