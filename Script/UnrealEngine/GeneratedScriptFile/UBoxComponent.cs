using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBoxComponent:UShapeComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetUnscaledBoxExtent(IntPtr _this);
/// <summary>@return the box extent, ignoring component scale.</summary>
public  FVector GetUnscaledBoxExtent()
{
	CheckIsValid();
	FVector ___ret = GetUnscaledBoxExtent(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetScaledBoxExtent(IntPtr _this);
/// <summary>@return the box extent, scaled by the component scale.</summary>
public  FVector GetScaledBoxExtent()
{
	CheckIsValid();
	FVector ___ret = GetScaledBoxExtent(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoxExtent(IntPtr _this,ref FVector InBoxExtent,int bUpdateOverlaps);
/// <summary>
/// Change the box extent size. This is the unscaled size, before component scale is applied.
/// @param       InBoxExtent: new extent (radius) for the box.
/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
/// </summary>
public  void SetBoxExtent(FVector InBoxExtent,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetBoxExtent(_this.Get(),ref InBoxExtent,bUpdateOverlaps?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
