using System;
namespace UnrealEngine
{
	public partial class USceneComponent:UActorComponent
	{
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
		public extern void K2_SetWorldLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>Set which parts of the relative transform should be relative to parent, and which should be relative to world</summary>
		public extern void SetAbsolute(bool bNewAbsoluteLocation=false,bool bNewAbsoluteRotation=false,bool bNewAbsoluteScale=false);
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
		public extern void K2_SetRelativeLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>Get the PhysicsVolume overlapping this component.</summary>
		public extern APhysicsVolume GetPhysicsVolume();
		/// <summary>
		/// Changes the value of HiddenGame.
		/// @param NewHidden     - The value to assign to HiddenGame.
		/// </summary>
		public extern virtual void SetHiddenInGame(bool NewHidden,bool bPropagateToChildren=false);
		/// <summary>Toggle visibility of the component</summary>
		public extern void ToggleVisibility(bool bPropagateToChildren=false);
		/// <summary>Set visibility of the component, if during game use this to turn on/off</summary>
		public extern virtual void SetVisibility(bool bNewVisibility,bool bPropagateToChildren=false);
		/// <summary>
		/// Is this component visible or not in game
		/// @return true if visible
		/// </summary>
		public extern virtual bool IsVisible();
		/// <summary>
		/// Get velocity of the component: either ComponentVelocity, or the velocity of the physics body if simulating physics.
		/// @return Velocity of the component
		/// </summary>
		public extern virtual FVector GetComponentVelocity();
		/// <summary>
		/// return true if socket with the given name exists
		/// @param InSocketName Name of the socket or the bone to get the transform
		/// @return true if the socket with the given name exists. Otherwise, return false
		/// </summary>
		public extern virtual bool DoesSocketExist(FName InSocketName);
		/// <summary>
		/// Get world-space socket or bone  FRotator rotation.
		/// @param InSocketName Name of the socket or the bone to get the transform
		/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </summary>
		public extern virtual FRotator GetSocketRotation(FName InSocketName);
		/// <summary>
		/// Get world-space socket or bone location.
		/// @param InSocketName Name of the socket or the bone to get the transform
		/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </summary>
		public extern virtual FVector GetSocketLocation(FName InSocketName);
		/// <summary>
		/// Get world-space socket transform.
		/// @param InSocketName Name of the socket or the bone to get the transform
		/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </summary>
		public extern virtual FTransform GetSocketTransform(FName InSocketName,ERelativeTransformSpace TransformSpace=ERelativeTransformSpace.RTS_World);
		/// <summary>
		/// Attach this component to another scene component, optionally at a named socket. It is valid to call this on components whether or not they have been Registered.
		/// @param  InParent                             Parent to attach to.
		/// @param  InSocketName                 Optional socket to attach to on the parent.
		/// @param  AttachType                   How to handle transform when attaching (Keep relative offset, keep world position, etc).
		/// @param  bWeldSimulatedBodies Whether to weld together simulated physics bodies.
		/// @return True if attachment is successful (or already attached to requested parent/socket), false if attachment is rejected and there is no change in AttachParent.
		/// </summary>
		public extern bool K2_AttachTo(USceneComponent InParent,FName InSocketName,EAttachLocation AttachType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true);
		/// <summary>Gets the attached child component at the specified location</summary>
		public extern USceneComponent GetChildComponent(int ChildIndex);
		/// <summary>Gets the number of attached children components</summary>
		public extern int GetNumChildrenComponents();
		/// <summary>Get the socket we are attached to.</summary>
		public extern FName GetAttachSocketName();
		/// <summary>Get the SceneComponent we are attached to.</summary>
		public extern USceneComponent GetAttachParent();
		/// <summary>Returns whether the specified body is currently using physics simulation</summary>
		public extern virtual bool IsAnySimulatingPhysics();
		/// <summary>Returns whether the specified body is currently using physics simulation</summary>
		public extern virtual bool IsSimulatingPhysics(FName BoneName);
		/// <summary>Get the right (Y) unit direction vector from this component, in world space.</summary>
		public extern FVector GetRightVector();
		/// <summary>Get the up (Z) unit direction vector from this component, in world space.</summary>
		public extern FVector GetUpVector();
		/// <summary>Get the forward (X) unit direction vector from this component, in world space.</summary>
		public extern FVector GetForwardVector();
		/// <summary>Get the current component-to-world transform for this component</summary>
		public extern FTransform K2_GetComponentToWorld();
		/// <summary>Returns scale of the component, in world space.</summary>
		public extern FVector K2_GetComponentScale();
		/// <summary>Returns rotation of the component, in world space.</summary>
		public extern FRotator K2_GetComponentRotation();
		/// <summary>Return location of the component, in world space</summary>
		public extern FVector K2_GetComponentLocation();
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
		public extern void K2_AddWorldTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
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
		public extern void K2_AddWorldRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
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
		public extern void K2_AddWorldOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
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
		public extern void K2_SetWorldTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Set the relative scale of the component to put it at the supplied scale in world space.
		/// @param NewScale              New scale in world space for this component.
		/// </summary>
		public extern void SetWorldScale3D(FVector NewScale);
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
		public extern void K2_SetWorldRotation(FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
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
		public extern void K2_SetWorldLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
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
		public extern void K2_AddLocalTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Adds a delta to the rotation of the component in its local reference frame
		/// @param DeltaRotation         Change in rotation of the component in its local reference frame.
		/// @param SweepHitResult        Hit result from any impact if sweep is true.
		/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		public extern void K2_AddLocalRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
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
		public extern void K2_AddLocalOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Adds a delta the rotation of the component relative to its parent
		/// @param DeltaRotation         Change in rotation of the component relative to is parent.
		/// @param SweepHitResult        Hit result from any impact if sweep is true.
		/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		public extern void K2_AddRelativeRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
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
		public extern void K2_AddRelativeLocation(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>Set the non-uniform scale of the component relative to its parent</summary>
		public extern virtual void SetRelativeScale3D(FVector NewScale3D);
		/// <summary>Reset the transform of the component relative to its parent. Sets relative location to zero, relative rotation to no rotation, and Scale to 1.</summary>
		public extern void ResetRelativeTransform();
		/// <summary>Returns the transform of the component relative to its parent</summary>
		public extern FTransform GetRelativeTransform();
		/// <summary>
		/// Set the transform of the component relative to its parent
		/// @param NewTransform          New transform of the component relative to its parent.
		/// @param SweepHitResult        Hit result from any impact if sweep is true.
		/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		public extern void K2_SetRelativeTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Set the rotation of the component relative to its parent
		/// @param NewRotation           New rotation of the component relative to its parent
		/// @param SweepHitResult        Hit result from any impact if sweep is true.
		/// @param bSweep                        Whether we sweep to the destination (currently not supported for rotation).
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		public extern void K2_SetRelativeRotation(FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
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
		public extern void K2_SetRelativeLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		public USceneComponent AttachParent;
		
		/// <summary>Optional socket name on AttachParent that we are attached to.</summary>
		public FName AttachSocketName;
		
		/// <summary>True if we have ever updated ComponentToWorld based on RelativeLocation/Rotation/Scale. Used at startup to make sure it is initialized.</summary>
		public bool bWorldToComponentUpdated;
		
		/// <summary>If RelativeLocation should be considered relative to the world, rather than the parent</summary>
		public bool bAbsoluteLocation;
		
		/// <summary>If RelativeRotation should be considered relative to the world, rather than the parent</summary>
		public bool bAbsoluteRotation;
		
		/// <summary>If RelativeScale3D should be considered relative to the world, rather than the parent</summary>
		public bool bAbsoluteScale;
		
		/// <summary>Whether to completely draw the primitive; if false, the primitive is not drawn, does not cast a shadow.</summary>
		public bool bVisible;
		
		/// <summary>Whether to hide the primitive in game, if the primitive is Visible.</summary>
		public bool bHiddenInGame;
		
		/// <summary>
		/// Whether or not the cached PhysicsVolume this component overlaps should be updated when the component is moved.
		/// @see GetPhysicsVolume()
		/// </summary>
		public bool bShouldUpdatePhysicsVolume;
		
		/// <summary>If true, a change in the bounds of the component will call trigger a streaming data rebuild</summary>
		public bool bBoundsChangeTriggersStreamingDataRebuild;
		
		/// <summary>
		/// If true, this component uses its parents bounds when attached.
		/// This can be a significant optimization with many components attached together.
		/// </summary>
		public bool bUseAttachParentBound;
		
		/// <summary>DEPRECATED</summary>
		public bool bAbsoluteTranslation;
		
		/// <summary>Location of the component relative to its parent</summary>
		public FVector RelativeLocation;
		
		/// <summary>Rotation of the component relative to its parent</summary>
		public FRotator RelativeRotation;
		
		/// <summary>
		/// Non-uniform scaling of the component relative to its parent.
		/// Note that scaling is always applied in local space (no shearing etc)
		/// </summary>
		public FVector RelativeScale3D;
		
		public FVector RelativeTranslation;
		
		/// <summary>How often this component is allowed to move, used to make various optimizations. Only safe to set in constructor.</summary>
		public EComponentMobility Mobility;
		
		/// <summary>If detail mode is >= system detail mode, primitive won't be rendered.</summary>
		public EDetailMode DetailMode;
		
		/// <summary>
		/// Velocity of the component.
		/// @see GetComponentVelocity()
		/// </summary>
		public FVector ComponentVelocity;
		
		public bool bVisualizeComponent;
		
		
	}
	
}
