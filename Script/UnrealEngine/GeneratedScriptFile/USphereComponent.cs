using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USphereComponent:UShapeComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetShapeScale(IntPtr _this);
/// <summary>
/// Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling.
/// @return the scale used by this shape.
/// </summary>
public  float GetShapeScale()
{
	CheckIsValid();
	float ___ret = GetShapeScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnscaledSphereRadius(IntPtr _this);
/// <summary>@return the radius of the sphere, ignoring component scale.</summary>
public  float GetUnscaledSphereRadius()
{
	CheckIsValid();
	float ___ret = GetUnscaledSphereRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScaledSphereRadius(IntPtr _this);
/// <summary>@return the radius of the sphere, with component scale applied.</summary>
public  float GetScaledSphereRadius()
{
	CheckIsValid();
	float ___ret = GetScaledSphereRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSphereRadius(IntPtr _this,float InSphereRadius,int bUpdateOverlaps);
/// <summary>
/// Change the sphere radius. This is the unscaled radius, before component scale is applied.
/// @param       InSphereRadius: the new sphere radius
/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
/// </summary>
public  void SetSphereRadius(float InSphereRadius,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetSphereRadius(_this.Get(),InSphereRadius,bUpdateOverlaps?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
