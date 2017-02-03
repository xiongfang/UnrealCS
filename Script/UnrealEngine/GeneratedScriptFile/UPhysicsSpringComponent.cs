using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicsSpringComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetSpringDirection(IntPtr _this);
/// <summary>Returns the spring direction from start to resting point</summary>
public  FVector GetSpringDirection()
{
	CheckIsValid();
	FVector ___ret = GetSpringDirection(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetSpringCurrentEndPoint(IntPtr _this);
/// <summary>Returns the spring current end point in world space.</summary>
public  FVector GetSpringCurrentEndPoint()
{
	CheckIsValid();
	FVector ___ret = GetSpringCurrentEndPoint(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetSpringRestingPoint(IntPtr _this);
/// <summary>Returns the spring resting point in world space.</summary>
public  FVector GetSpringRestingPoint()
{
	CheckIsValid();
	FVector ___ret = GetSpringRestingPoint(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetNormalizedCompressionScalar(IntPtr _this);
/// <summary>
/// Returns the spring compression as a normalized scalar along spring direction.
/// 0 implies spring is at rest
/// 1 implies fully compressed
/// </summary>
public  float GetNormalizedCompressionScalar()
{
	CheckIsValid();
	float ___ret = GetNormalizedCompressionScalar(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
