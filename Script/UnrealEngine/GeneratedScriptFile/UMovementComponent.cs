using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMovementComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SnapUpdatedComponentToPlane(IntPtr _this);
/// <summary>Snap the updated component to the plane constraint, if enabled.</summary>
public  void SnapUpdatedComponentToPlane()
{
	CheckIsValid();
	SnapUpdatedComponentToPlane(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ConstrainNormalToPlane(IntPtr _this,ref FVector Normal);
/// <summary>Constrain a normal vector (of unit length) to the plane constraint, if enabled.</summary>
public  FVector ConstrainNormalToPlane(FVector Normal)
{
	CheckIsValid();
	FVector ___ret = ConstrainNormalToPlane(_this.Get(),ref Normal);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ConstrainLocationToPlane(IntPtr _this,ref FVector Location);
/// <summary>Constrain a position vector to the plane constraint, if enabled.</summary>
public  FVector ConstrainLocationToPlane(FVector Location)
{
	CheckIsValid();
	FVector ___ret = ConstrainLocationToPlane(_this.Get(),ref Location);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ConstrainDirectionToPlane(IntPtr _this,ref FVector Direction);
/// <summary>
/// Constrain a direction vector to the plane constraint, if enabled.
/// @see SetPlaneConstraint
/// </summary>
public  FVector ConstrainDirectionToPlane(FVector Direction)
{
	CheckIsValid();
	FVector ___ret = ConstrainDirectionToPlane(_this.Get(),ref Direction);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPlaneConstraintOrigin(IntPtr _this);
/// <summary>
/// Get the plane constraint origin. This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane().
/// @return The origin of the plane that constrains movement, if the plane constraint is enabled.
/// </summary>
public  FVector GetPlaneConstraintOrigin()
{
	CheckIsValid();
	FVector ___ret = GetPlaneConstraintOrigin(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPlaneConstraintNormal(IntPtr _this);
/// <summary>@return The normal of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
public  FVector GetPlaneConstraintNormal()
{
	CheckIsValid();
	FVector ___ret = GetPlaneConstraintNormal(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlaneConstraintEnabled(IntPtr _this,int bEnabled);
/// <summary>Sets whether or not the plane constraint is enabled.</summary>
public  void SetPlaneConstraintEnabled(bool bEnabled)
{
	CheckIsValid();
	SetPlaneConstraintEnabled(_this.Get(),bEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlaneConstraintOrigin(IntPtr _this,ref FVector PlaneOrigin);
/// <summary>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
public  void SetPlaneConstraintOrigin(FVector PlaneOrigin)
{
	CheckIsValid();
	SetPlaneConstraintOrigin(_this.Get(),ref PlaneOrigin);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlaneConstraintFromVectors(IntPtr _this,ref FVector Forward,ref FVector Up);
/// <summary>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
public  void SetPlaneConstraintFromVectors(FVector Forward,FVector Up)
{
	CheckIsValid();
	SetPlaneConstraintFromVectors(_this.Get(),ref Forward,ref Up);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlaneConstraintNormal(IntPtr _this,ref FVector PlaneNormal);
/// <summary>
/// Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled.
/// Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom".
/// @param PlaneNormal   The normal of the plane. If non-zero in length, it will be normalized.
/// </summary>
public  void SetPlaneConstraintNormal(FVector PlaneNormal)
{
	CheckIsValid();
	SetPlaneConstraintNormal(_this.Get(),ref PlaneNormal);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_MoveUpdatedComponent(IntPtr _this,ref FVector Delta,ref FRotator NewRotation,out FHitResult OutHit,int bSweep,int bTeleport);
/// <summary>
/// Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation.
/// Respects the plane constraint, if enabled.
/// @return True if some movement occurred, false if no movement occurred. Result of any impact will be stored in OutHit.
/// </summary>
public  bool K2_MoveUpdatedComponent(FVector Delta,FRotator NewRotation,out FHitResult OutHit,bool bSweep=true,bool bTeleport=false)
{
	CheckIsValid();
	int ___ret = K2_MoveUpdatedComponent(_this.Get(),ref Delta,ref NewRotation,out OutHit,bSweep?1:0,bTeleport?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUpdatedComponent(IntPtr _this,IntPtr NewUpdatedComponent);
/// <summary>Assign the component we move and update.</summary>
public  void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
{
	CheckIsValid();
	SetUpdatedComponent(_this.Get(),NewUpdatedComponent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PhysicsVolumeChanged(IntPtr _this,IntPtr NewVolume);
/// <summary>Delegate when PhysicsVolume of UpdatedComponent has been changed *</summary>
public  void PhysicsVolumeChanged(APhysicsVolume NewVolume)
{
	CheckIsValid();
	PhysicsVolumeChanged(_this.Get(),NewVolume);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPhysicsVolume(IntPtr _this);
/// <summary>@return PhysicsVolume this MovementComponent is using, or the world's default physics volume if none. *</summary>
public  APhysicsVolume GetPhysicsVolume()
{
	CheckIsValid();
	IntPtr ___ret = GetPhysicsVolume(_this.Get());
	if(___ret==IntPtr.Zero) return null; APhysicsVolume ___ret2= new APhysicsVolume(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopMovementImmediately(IntPtr _this);
/// <summary>Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration).</summary>
public  void StopMovementImmediately()
{
	CheckIsValid();
	StopMovementImmediately(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsExceedingMaxSpeed(IntPtr _this,float MaxSpeed);
/// <summary>
/// Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance.
/// Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit
/// can cause the max speed to be violated.
/// </summary>
public  bool IsExceedingMaxSpeed(float MaxSpeed)
{
	CheckIsValid();
	int ___ret = IsExceedingMaxSpeed(_this.Get(),MaxSpeed);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetModifiedMaxSpeed(IntPtr _this);
/// <summary>@return the result of GetMaxSpeed() * GetMaxSpeedModifier().</summary>
public  float K2_GetModifiedMaxSpeed()
{
	CheckIsValid();
	float ___ret = K2_GetModifiedMaxSpeed(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMaxSpeed(IntPtr _this);
/// <summary>@return Maximum speed of component in current movement mode.</summary>
public  float GetMaxSpeed()
{
	CheckIsValid();
	float ___ret = GetMaxSpeed(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetGravityZ(IntPtr _this);
/// <summary>@return gravity that affects this component</summary>
public  float GetGravityZ()
{
	CheckIsValid();
	float ___ret = GetGravityZ(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
