using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UProjectileMovementComponent:UMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopSimulating(IntPtr _this,ref FHitResult HitResult);
/// <summary>Clears the reference to UpdatedComponent, fires stop event (OnProjectileStop), and stops ticking (if bAutoUpdateTickRegistration is true).</summary>
public  void StopSimulating(FHitResult HitResult)
{
	CheckIsValid();
	StopSimulating(_this.Get(),ref HitResult);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVelocityInLocalSpace(IntPtr _this,ref FVector NewVelocity);
/// <summary>Sets the velocity to the new value, rotated into Actor space.</summary>
public  void SetVelocityInLocalSpace(FVector NewVelocity)
{
	CheckIsValid();
	SetVelocityInLocalSpace(_this.Get(),ref NewVelocity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
