using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UNavMovementComponent:UMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsFlying(IntPtr _this);
/// <summary>@return true if currently flying (moving through a non-fluid volume without resting on the ground)</summary>
public  bool IsFlying()
{
	CheckIsValid();
	int ___ret = IsFlying(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsSwimming(IntPtr _this);
/// <summary>@return true if currently swimming (moving through a fluid volume)</summary>
public  bool IsSwimming()
{
	CheckIsValid();
	int ___ret = IsSwimming(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMovingOnGround(IntPtr _this);
/// <summary>@return true if currently moving on the ground (e.g. walking or driving)</summary>
public  bool IsMovingOnGround()
{
	CheckIsValid();
	int ___ret = IsMovingOnGround(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsFalling(IntPtr _this);
/// <summary>@return true if currently falling (not flying, in a non-fluid volume, and not on the ground)</summary>
public  bool IsFalling()
{
	CheckIsValid();
	int ___ret = IsFalling(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsCrouching(IntPtr _this);
/// <summary>@return true if currently crouching</summary>
public  bool IsCrouching()
{
	CheckIsValid();
	int ___ret = IsCrouching(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopMovementKeepPathing(IntPtr _this);
/// <summary>Stops movement immediately (reset velocity) but keeps following current path</summary>
public  void StopMovementKeepPathing()
{
	CheckIsValid();
	StopMovementKeepPathing(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopActiveMovement(IntPtr _this);
/// <summary>Stops applying further movement (usually zeros acceleration).</summary>
public  void StopActiveMovement()
{
	CheckIsValid();
	StopActiveMovement(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
