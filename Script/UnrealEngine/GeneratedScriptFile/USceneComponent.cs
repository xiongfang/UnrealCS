using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USceneComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetWorldLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Set the relative location and rotation of the component to put it at the supplied pose in world space.
/// @param NewLocation           New location in world space for the component.
/// @param NewRotation           New rotation in world space for the component.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_SetWorldLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetWorldLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAbsolute(IntPtr _this,int bNewAbsoluteLocation,int bNewAbsoluteRotation,int bNewAbsoluteScale);
/// <summary>Set which parts of the relative transform should be relative to parent, and which should be relative to world</summary>
public  void SetAbsolute(bool bNewAbsoluteLocation=false,bool bNewAbsoluteRotation=false,bool bNewAbsoluteScale=false)
{
	CheckIsValid();
	SetAbsolute(_this.Get(),bNewAbsoluteLocation?1:0,bNewAbsoluteRotation?1:0,bNewAbsoluteScale?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetRelativeLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Set the location and rotation of the component relative to its parent
/// @param NewLocation           New location of the component relative to its parent.
/// @param NewRotation           New rotation of the component relative to its parent.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_SetRelativeLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetRelativeLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPhysicsVolume(IntPtr _this);
/// <summary>Get the PhysicsVolume overlapping this component.</summary>
public  APhysicsVolume GetPhysicsVolume()
{
	CheckIsValid();
	IntPtr ___ret = GetPhysicsVolume(_this.Get());
	if(___ret==IntPtr.Zero) return null; APhysicsVolume ___ret2= new APhysicsVolume(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHiddenInGame(IntPtr _this,int NewHidden,int bPropagateToChildren);
/// <summary>
/// Changes the value of HiddenGame.
/// @param NewHidden     - The value to assign to HiddenGame.
/// </summary>
public  void SetHiddenInGame(bool NewHidden,bool bPropagateToChildren=false)
{
	CheckIsValid();
	SetHiddenInGame(_this.Get(),NewHidden?1:0,bPropagateToChildren?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleVisibility(IntPtr _this,int bPropagateToChildren);
/// <summary>Toggle visibility of the component</summary>
public  void ToggleVisibility(bool bPropagateToChildren=false)
{
	CheckIsValid();
	ToggleVisibility(_this.Get(),bPropagateToChildren?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVisibility(IntPtr _this,int bNewVisibility,int bPropagateToChildren);
/// <summary>Set visibility of the component, if during game use this to turn on/off</summary>
public  void SetVisibility(bool bNewVisibility,bool bPropagateToChildren=false)
{
	CheckIsValid();
	SetVisibility(_this.Get(),bNewVisibility?1:0,bPropagateToChildren?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsVisible(IntPtr _this);
/// <summary>
/// Is this component visible or not in game
/// @return true if visible
/// </summary>
public  bool IsVisible()
{
	CheckIsValid();
	int ___ret = IsVisible(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetComponentVelocity(IntPtr _this);
/// <summary>
/// Get velocity of the component: either ComponentVelocity, or the velocity of the physics body if simulating physics.
/// @return Velocity of the component
/// </summary>
public  FVector GetComponentVelocity()
{
	CheckIsValid();
	FVector ___ret = GetComponentVelocity(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DoesSocketExist(IntPtr _this,string InSocketName);
/// <summary>
/// return true if socket with the given name exists
/// @param InSocketName Name of the socket or the bone to get the transform
/// @return true if the socket with the given name exists. Otherwise, return false
/// </summary>
public  bool DoesSocketExist(string InSocketName)
{
	CheckIsValid();
	int ___ret = DoesSocketExist(_this.Get(),InSocketName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetSocketRotation(IntPtr _this,string InSocketName);
/// <summary>
/// Get world-space socket or bone  FRotator rotation.
/// @param InSocketName Name of the socket or the bone to get the transform
/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
/// </summary>
public  FRotator GetSocketRotation(string InSocketName)
{
	CheckIsValid();
	FRotator ___ret = GetSocketRotation(_this.Get(),InSocketName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetSocketLocation(IntPtr _this,string InSocketName);
/// <summary>
/// Get world-space socket or bone location.
/// @param InSocketName Name of the socket or the bone to get the transform
/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
/// </summary>
public  FVector GetSocketLocation(string InSocketName)
{
	CheckIsValid();
	FVector ___ret = GetSocketLocation(_this.Get(),InSocketName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetSocketTransform(IntPtr _this,string InSocketName,int TransformSpace);
/// <summary>
/// Get world-space socket transform.
/// @param InSocketName Name of the socket or the bone to get the transform
/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
/// </summary>
public  FTransform GetSocketTransform(string InSocketName,ERelativeTransformSpace TransformSpace=ERelativeTransformSpace.RTS_World)
{
	CheckIsValid();
	FTransform ___ret = GetSocketTransform(_this.Get(),InSocketName,(int)TransformSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FName[] GetAllSocketNames(IntPtr _this);
/// <summary>
/// Gets the names of all the sockets on the component.
/// @return Get the names of all the sockets on the component.
/// </summary>
public  FName[] GetAllSocketNames()
{
	CheckIsValid();
	FName[] ___ret = GetAllSocketNames(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DetachFromParent(IntPtr _this,int bMaintainWorldPosition,int bCallModify);
public  void DetachFromParent(bool bMaintainWorldPosition=false,bool bCallModify=true)
{
	CheckIsValid();
	DetachFromParent(_this.Get(),bMaintainWorldPosition?1:0,bCallModify?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_AttachTo(IntPtr _this,IntPtr InParent,string InSocketName,int AttachType,int bWeldSimulatedBodies);
/// <summary>
/// Attach this component to another scene component, optionally at a named socket. It is valid to call this on components whether or not they have been Registered.
/// @param  InParent                             Parent to attach to.
/// @param  InSocketName                 Optional socket to attach to on the parent.
/// @param  AttachType                   How to handle transform when attaching (Keep relative offset, keep world position, etc).
/// @param  bWeldSimulatedBodies Whether to weld together simulated physics bodies.
/// @return True if attachment is successful (or already attached to requested parent/socket), false if attachment is rejected and there is no change in AttachParent.
/// </summary>
public  bool K2_AttachTo(USceneComponent InParent,string InSocketName="None",EAttachLocation AttachType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true)
{
	CheckIsValid();
	int ___ret = K2_AttachTo(_this.Get(),InParent,InSocketName,(int)AttachType,bWeldSimulatedBodies?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetChildrenComponents(IntPtr _this,int bIncludeAllDescendants,out IntPtr[] Children);
/// <summary>
/// Gets all the attached child components
/// @param bIncludeAllDescendants Whether to include all descendants in the list of children (i.e. grandchildren, great grandchildren, etc.)
/// @param Children The list of attached child components
/// </summary>
public  void GetChildrenComponents(bool bIncludeAllDescendants,out USceneComponent[] Children)
{
	CheckIsValid();
	IntPtr[] Children_temp;
	GetChildrenComponents(_this.Get(),bIncludeAllDescendants?1:0,out Children_temp);
	Children = MarshalUtil.IntPtrArrayToObjectArray<USceneComponent>(Children_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetChildComponent(IntPtr _this,int ChildIndex);
/// <summary>Gets the attached child component at the specified location</summary>
public  USceneComponent GetChildComponent(int ChildIndex)
{
	CheckIsValid();
	IntPtr ___ret = GetChildComponent(_this.Get(),ChildIndex);
	if(___ret==IntPtr.Zero) return null; USceneComponent ___ret2= new USceneComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumChildrenComponents(IntPtr _this);
/// <summary>Gets the number of attached children components</summary>
public  int GetNumChildrenComponents()
{
	CheckIsValid();
	int ___ret = GetNumChildrenComponents(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetParentComponents(IntPtr _this,out IntPtr[] Parents);
/// <summary>Gets all parent components up to and including the root component</summary>
public  void GetParentComponents(out USceneComponent[] Parents)
{
	CheckIsValid();
	IntPtr[] Parents_temp;
	GetParentComponents(_this.Get(),out Parents_temp);
	Parents = MarshalUtil.IntPtrArrayToObjectArray<USceneComponent>(Parents_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetAttachSocketName(IntPtr _this);
/// <summary>Get the socket we are attached to.</summary>
public  string GetAttachSocketName()
{
	CheckIsValid();
	string ___ret = GetAttachSocketName(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetAttachParent(IntPtr _this);
/// <summary>Get the SceneComponent we are attached to.</summary>
public  USceneComponent GetAttachParent()
{
	CheckIsValid();
	IntPtr ___ret = GetAttachParent(_this.Get());
	if(___ret==IntPtr.Zero) return null; USceneComponent ___ret2= new USceneComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsAnySimulatingPhysics(IntPtr _this);
/// <summary>Returns whether the specified body is currently using physics simulation</summary>
public  bool IsAnySimulatingPhysics()
{
	CheckIsValid();
	int ___ret = IsAnySimulatingPhysics(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsSimulatingPhysics(IntPtr _this,string BoneName);
/// <summary>Returns whether the specified body is currently using physics simulation</summary>
public  bool IsSimulatingPhysics(string BoneName="None")
{
	CheckIsValid();
	int ___ret = IsSimulatingPhysics(_this.Get(),BoneName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetRightVector(IntPtr _this);
/// <summary>Get the right (Y) unit direction vector from this component, in world space.</summary>
public  FVector GetRightVector()
{
	CheckIsValid();
	FVector ___ret = GetRightVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetUpVector(IntPtr _this);
/// <summary>Get the up (Z) unit direction vector from this component, in world space.</summary>
public  FVector GetUpVector()
{
	CheckIsValid();
	FVector ___ret = GetUpVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetForwardVector(IntPtr _this);
/// <summary>Get the forward (X) unit direction vector from this component, in world space.</summary>
public  FVector GetForwardVector()
{
	CheckIsValid();
	FVector ___ret = GetForwardVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform K2_GetComponentToWorld(IntPtr _this);
/// <summary>Get the current component-to-world transform for this component</summary>
public  FTransform K2_GetComponentToWorld()
{
	CheckIsValid();
	FTransform ___ret = K2_GetComponentToWorld(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector K2_GetComponentScale(IntPtr _this);
/// <summary>Returns scale of the component, in world space.</summary>
public  FVector K2_GetComponentScale()
{
	CheckIsValid();
	FVector ___ret = K2_GetComponentScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator K2_GetComponentRotation(IntPtr _this);
/// <summary>Returns rotation of the component, in world space.</summary>
public  FRotator K2_GetComponentRotation()
{
	CheckIsValid();
	FRotator ___ret = K2_GetComponentRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector K2_GetComponentLocation(IntPtr _this);
/// <summary>Return location of the component, in world space</summary>
public  FVector K2_GetComponentLocation()
{
	CheckIsValid();
	FVector ___ret = K2_GetComponentLocation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddWorldTransform(IntPtr _this,ref FTransform DeltaTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Adds a delta to the transform of the component in world space. Scale is unchanged.
/// @param DeltaTransform        Change in transform in world space for the component. Scale is unchanged.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_AddWorldTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddWorldTransform(_this.Get(),ref DeltaTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddWorldRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Adds a delta to the rotation of the component in world space.
/// @param DeltaRotation         Change in rotation in world space for the component.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_AddWorldRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddWorldRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddWorldOffset(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Adds a delta to the location of the component in world space.
/// @param DeltaLocation         Change in location in world space for the component.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_AddWorldOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddWorldOffset(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetWorldTransform(IntPtr _this,ref FTransform NewTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Set the transform of the component in world space.
/// @param NewTransform          New transform in world space for the component.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_SetWorldTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetWorldTransform(_this.Get(),ref NewTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWorldScale3D(IntPtr _this,ref FVector NewScale);
/// <summary>
/// Set the relative scale of the component to put it at the supplied scale in world space.
/// @param NewScale              New scale in world space for this component.
/// </summary>
public  void SetWorldScale3D(FVector NewScale)
{
	CheckIsValid();
	SetWorldScale3D(_this.Get(),ref NewScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetWorldRotation(IntPtr _this,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// * Put this component at the specified rotation in world space. Updates relative rotation to achieve the final world rotation.
/// * @param NewRotation           New rotation in world space for the component.
/// * @param SweepHitResult        Hit result from any impact if sweep is true.
/// * @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
/// * @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
/// *                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
/// *                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
/// *                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_SetWorldRotation(FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetWorldRotation(_this.Get(),ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetWorldLocation(IntPtr _this,ref FVector NewLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Put this component at the specified location in world space. Updates relative location to achieve the final world location.
/// @param NewLocation           New location in world space for the component.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_SetWorldLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetWorldLocation(_this.Get(),ref NewLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddLocalTransform(IntPtr _this,ref FTransform DeltaTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Adds a delta to the transform of the component in its local reference frame. Scale is unchanged.
/// @param DeltaTransform        Change in transform of the component in its local reference frame. Scale is unchanged.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_AddLocalTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddLocalTransform(_this.Get(),ref DeltaTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddLocalRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Adds a delta to the rotation of the component in its local reference frame
/// @param DeltaRotation         Change in rotation of the component in its local reference frame.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
/// </summary>
public  void K2_AddLocalRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddLocalRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddLocalOffset(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Adds a delta to the location of the component in its local reference frame
/// @param DeltaLocation         Change in location of the component in its local reference frame.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_AddLocalOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddLocalOffset(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddRelativeRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Adds a delta the rotation of the component relative to its parent
/// @param DeltaRotation         Change in rotation of the component relative to is parent.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
/// </summary>
public  void K2_AddRelativeRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddRelativeRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddRelativeLocation(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Adds a delta to the translation of the component relative to its parent
/// @param DeltaLocation         Change in location of the component relative to its parent
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_AddRelativeLocation(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddRelativeLocation(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRelativeScale3D(IntPtr _this,ref FVector NewScale3D);
/// <summary>Set the non-uniform scale of the component relative to its parent</summary>
public  void SetRelativeScale3D(FVector NewScale3D)
{
	CheckIsValid();
	SetRelativeScale3D(_this.Get(),ref NewScale3D);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetRelativeTransform(IntPtr _this);
/// <summary>Reset the transform of the component relative to its parent. Sets relative location to zero, relative rotation to no rotation, and Scale to 1.</summary>
public  void ResetRelativeTransform()
{
	CheckIsValid();
	ResetRelativeTransform(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetRelativeTransform(IntPtr _this);
/// <summary>Returns the transform of the component relative to its parent</summary>
public  FTransform GetRelativeTransform()
{
	CheckIsValid();
	FTransform ___ret = GetRelativeTransform(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetRelativeTransform(IntPtr _this,ref FTransform NewTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Set the transform of the component relative to its parent
/// @param NewTransform          New transform of the component relative to its parent.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
/// </summary>
public  void K2_SetRelativeTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetRelativeTransform(_this.Get(),ref NewTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetRelativeRotation(IntPtr _this,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Set the rotation of the component relative to its parent
/// @param NewRotation           New rotation of the component relative to its parent
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
/// </summary>
public  void K2_SetRelativeRotation(FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetRelativeRotation(_this.Get(),ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetRelativeLocation(IntPtr _this,ref FVector NewLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>
/// Set the location of the component relative to its parent
/// @param NewLocation           New location of the component relative to its parent.
/// @param SweepHitResult        Hit result from any impact if sweep is true.
/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
///                                                      If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
/// </summary>
public  void K2_SetRelativeLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetRelativeLocation(_this.Get(),ref NewLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
