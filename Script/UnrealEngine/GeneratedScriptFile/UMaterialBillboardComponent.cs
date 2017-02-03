using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMaterialBillboardComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddElement(IntPtr _this,IntPtr Material,IntPtr DistanceToOpacityCurve,int bSizeIsInScreenSpace,float BaseSizeX,float BaseSizeY,IntPtr DistanceToSizeCurve);
/// <summary>Adds an element to the sprite.</summary>
public  void AddElement(UMaterialInterface Material,UCurveFloat DistanceToOpacityCurve,bool bSizeIsInScreenSpace,float BaseSizeX,float BaseSizeY,UCurveFloat DistanceToSizeCurve)
{
	CheckIsValid();
	AddElement(_this.Get(),Material,DistanceToOpacityCurve,bSizeIsInScreenSpace?1:0,BaseSizeX,BaseSizeY,DistanceToSizeCurve);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetElements(IntPtr _this,FMaterialSpriteElement[] NewElements);
/// <summary>Set all elements of this material billboard component</summary>
public  void SetElements(FMaterialSpriteElement[] NewElements)
{
	CheckIsValid();
	SetElements(_this.Get(),NewElements);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
