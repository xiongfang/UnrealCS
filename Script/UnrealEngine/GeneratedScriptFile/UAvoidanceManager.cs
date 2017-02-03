using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAvoidanceManager:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetAvoidanceVelocity(IntPtr _this,ref FNavAvoidanceData AvoidanceData,float DeltaTime);
/// <summary>Only use if you want manual velocity planning. Will not ignore your own volume if you are registered.</summary>
public  FVector GetAvoidanceVelocity(FNavAvoidanceData AvoidanceData,float DeltaTime)
{
	CheckIsValid();
	FVector ___ret = GetAvoidanceVelocity(_this.Get(),ref AvoidanceData,DeltaTime);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetAvoidanceVelocityIgnoringUID(IntPtr _this,ref FNavAvoidanceData AvoidanceData,float DeltaTime,int IgnoreThisUID);
/// <summary>Only use if you want manual velocity planning. Provide your AvoidanceUID in order to avoid colliding with yourself.</summary>
public  FVector GetAvoidanceVelocityIgnoringUID(FNavAvoidanceData AvoidanceData,float DeltaTime,int IgnoreThisUID)
{
	CheckIsValid();
	FVector ___ret = GetAvoidanceVelocityIgnoringUID(_this.Get(),ref AvoidanceData,DeltaTime,IgnoreThisUID);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetAvoidanceVelocityForComponent(IntPtr _this,IntPtr MovementComp);
/// <summary>Calculate avoidance velocity for component (avoids collisions with the supplied component)</summary>
public  FVector GetAvoidanceVelocityForComponent(UMovementComponent MovementComp)
{
	CheckIsValid();
	FVector ___ret = GetAvoidanceVelocityForComponent(_this.Get(),MovementComp);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RegisterMovementComponent(IntPtr _this,IntPtr MovementComp,float AvoidanceWeight);
/// <summary>
/// Register with the given avoidance manager.
/// @param AvoidanceWeight      When avoiding each other, actors divert course in proportion to their relative weights. Range is 0.0 to 1.0. Special: at 1.0, actor will not divert course at all.
/// </summary>
public  bool RegisterMovementComponent(UMovementComponent MovementComp,float AvoidanceWeight=0.500000f)
{
	CheckIsValid();
	int ___ret = RegisterMovementComponent(_this.Get(),MovementComp,AvoidanceWeight);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNewAvoidanceUID(IntPtr _this);
/// <summary>Get appropriate UID for use when reporting to this function or requesting RVO assistance.</summary>
public  int GetNewAvoidanceUID()
{
	CheckIsValid();
	int ___ret = GetNewAvoidanceUID(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetObjectCount(IntPtr _this);
/// <summary>Get the number of avoidance objects currently in the manager.</summary>
public  int GetObjectCount()
{
	CheckIsValid();
	int ___ret = GetObjectCount(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
