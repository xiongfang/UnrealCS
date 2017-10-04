using System;
namespace UnrealEngine
{
	public partial class AActor:UObject
	{
		/// <summary>Script exposed version of FindComponentByClass</summary>
		public extern UActorComponent GetComponentByClass(TSubclassOf<UActorComponent>  ComponentClass);
		/// <summary>
		/// Returns the point of view of the actor.
		/// Note that this doesn't mean the camera, but the 'eyes' of the actor.
		/// For example, for a Pawn, this would define the eye height location,
		/// and view rotation (which is different from the pawn rotation which has a zeroed pitch component).
		/// A camera first person view will typically use this view point. Most traces (weapon, AI) will be done from this view point.
		/// @param       OutLocation - location of view point
		/// @param       OutRotation - view rotation of actor.
		/// </summary>
		public extern virtual void GetActorEyesViewPoint(out FVector OutLocation,out FRotator OutRotation);
		/// <summary>Force actor to be updated to clients</summary>
		public extern virtual void ForceNetUpdate();
		/// <summary>
		/// Returns true if this actor has been rendered "recently", with a tolerance in seconds to define what "recent" means.
		/// e.g.: If a tolerance of 0.1 is used, this function will return true only if the actor was rendered in the last 0.1 seconds of game time.
		/// @param Tolerance  How many seconds ago the actor last render time can be and still count as having been "recently" rendered.
		/// @return Whether this actor was recently rendered.
		/// </summary>
		public extern bool WasRecentlyRendered(float Tolerance=0.200000f);
		/// <summary>
		/// Sets the ticking group for this actor.
		/// @param NewTickGroup the new value to assign
		/// </summary>
		public extern void SetTickGroup(ETickingGroup NewTickGroup);
		/// <summary>Walk up the attachment chain from RootComponent until we encounter a different actor, and return the socket name in the component. If we are not attached to a component in a different actor, returns NAME_None</summary>
		public extern FName GetAttachParentSocketName();
		/// <summary>Walk up the attachment chain from RootComponent until we encounter a different actor, and return it. If we are not attached to a component in a different actor, returns NULL</summary>
		public extern AActor GetAttachParentActor();
		/// <summary>
		/// Teleport this actor to a new location. If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such.
		/// @param DestLocation The target destination point
		/// @param DestRotation The target rotation at the destination
		/// @return true if the actor has been successfully moved, or false if it couldn't fit.
		/// </summary>
		public extern bool K2_TeleportTo(FVector DestLocation,FRotator DestRotation);
		/// <summary>If this Actor was created by a Child Actor Component returns the Actor that owns that Child Actor Component</summary>
		public extern AActor GetParentActor();
		/// <summary>If this Actor was created by a Child Actor Component returns that Child Actor Component</summary>
		public extern UChildActorComponent GetParentComponent();
		/// <summary>Returns whether this Actor was spawned by a child actor component</summary>
		public extern bool IsChildActor();
		/// <summary>Forces dormant actor to replicate but doesn't change NetDormancy state (i.e., they will go dormant again if left dormant)</summary>
		public extern void FlushNetDormancy();
		/// <summary>
		/// Check whether any component of this Actor is overlapping any component of another Actor.
		/// @param Other The other Actor to test against
		/// @return Whether any component of this Actor is overlapping any component of another Actor.
		/// </summary>
		public extern bool IsOverlappingActor(AActor Other);
		/// <summary>
		/// Get the owner of this Actor, used primarily for network replication.
		/// @return Actor that owns this Actor
		/// </summary>
		public extern AActor GetOwner();
		/// <summary>
		/// Set the owner of this Actor, used primarily for network replication.
		/// @param NewOwner      The Actor whom takes over ownership of this Actor
		/// </summary>
		public extern virtual void SetOwner(AActor NewOwner);
		/// <summary>ReplicatedMovement struct replication event</summary>
		public extern virtual void OnRep_ReplicatedMovement();
		/// <summary>Returns the tick interval of this actor's primary tick function</summary>
		public extern float GetActorTickInterval();
		/// <summary>
		/// Sets the tick interval of this actor's primary tick function. Will not enable a disabled tick function. Takes effect on next tick.
		/// @param TickInterval   The rate at which this actor should be ticking
		/// </summary>
		public extern void SetActorTickInterval(float TickInterval);
		/// <summary>Returns whether this actor has tick enabled or not</summary>
		public extern bool IsActorTickEnabled();
		/// <summary>
		/// Set this actor's tick functions to be enabled or disabled. Only has an effect if the function is registered
		/// This only modifies the tick function on actor itself
		/// @param       bEnabled        Whether it should be enabled or not
		/// </summary>
		public extern void SetActorTickEnabled(bool bEnabled);
		/// <summary>Get the remaining lifespan of this actor. If zero is returned the actor lives forever.</summary>
		public extern virtual float GetLifeSpan();
		/// <summary>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.</summary>
		public extern virtual void SetLifeSpan(float InLifespan);
		public extern bool IsActorBeingDestroyed();
		/// <summary>
		/// Trigger a noise caused by a given Pawn, at a given location.
		/// Note that the NoiseInstigator Pawn MUST have a PawnNoiseEmitterComponent for the noise to be detected by a PawnSensingComponent.
		/// Senders of MakeNoise should have an Instigator if they are not pawns, or pass a NoiseInstigator.
		/// @param Loudness The relative loudness of this noise. Usual range is 0 (no noise) to 1 (full volume). If MaxRange is used, this scales the max range, otherwise it affects the hearing range specified by the sensor.
		/// @param NoiseInstigator Pawn responsible for this noise.  Uses the actor's Instigator if NoiseInstigator=NULL
		/// @param NoiseLocation Position of noise source.  If zero vector, use the actor's location.
		/// @param MaxRange Max range at which the sound may be heard. A value of 0 indicates no max range (though perception may have its own range). Loudness scales the range. (Note: not supported for legacy PawnSensingComponent, only for AIPerception)
		/// @param Tag Identifier for the noise.
		/// </summary>
		public extern void MakeNoise(float Loudness=1.000000f,APawn NoiseInstigator=default(APawn),FVector NoiseLocation=default(FVector),float MaxRange=0.000000f,FName Tag=default(FName));
		/// <summary>The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds.</summary>
		public extern float GetGameTimeSinceCreation();
		/// <summary>Sets whether this actor can tick when paused.</summary>
		public extern void SetTickableWhenPaused(bool bTickableWhenPaused);
		/// <summary>Gets whether this actor can tick when paused.</summary>
		public extern bool GetTickableWhenPaused();
		/// <summary>Remove tick dependency on PrerequisiteComponent.</summary>
		public extern virtual void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent);
		/// <summary>Remove tick dependency on PrerequisiteActor.</summary>
		public extern virtual void RemoveTickPrerequisiteActor(AActor PrerequisiteActor);
		/// <summary>Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired.</summary>
		public extern virtual void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent);
		/// <summary>Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired.</summary>
		public extern virtual void AddTickPrerequisiteActor(AActor PrerequisiteActor);
		/// <summary>
		/// Get CustomTimeDilation - this can be used for input control or speed control for slomo.
		/// We don't want to scale input globally because input can be used for UI, which do not care for TimeDilation.
		/// </summary>
		public extern float GetActorTimeDilation();
		/// <summary>See if this actor contains the supplied tag</summary>
		public extern bool ActorHasTag(FName Tag);
		/// <summary>
		/// Detaches the RootComponent of this Actor from any SceneComponent it is currently attached to.
		///  @param bMaintainWorldTransform     If true, update the relative location/rotation of this component to keep its world position the same
		/// </summary>
		public extern void DetachRootComponentFromParent(bool bMaintainWorldPosition=true);
		/// <summary>
		/// Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered.
		///  @param AttachLocationType   Type of attachment, AbsoluteWorld to keep its world position, RelativeOffset to keep the object's relative offset and SnapTo to snap to the new parent.
		/// </summary>
		public extern void K2_AttachRootComponentToActor(AActor InParentActor,FName InSocketName,EAttachLocation AttachLocationType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true);
		/// <summary>
		/// Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered.
		///  @param AttachLocationType  Type of attachment, AbsoluteWorld to keep its world position, RelativeOffset to keep the object's relative offset and SnapTo to snap to the new parent.
		/// </summary>
		public extern void K2_AttachRootComponentTo(USceneComponent InParent,FName InSocketName,EAttachLocation AttachLocationType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true);
		/// <summary>
		/// Creates a new component and assigns ownership to the Actor this is
		/// called for. Automatic attachment causes the first component created to
		/// become the root, and all subsequent components to be attached under that
		/// root. When bManualAttachment is set, automatic attachment is
		/// skipped and it is up to the user to attach the resulting component (or
		/// set it up as the root) themselves.
		/// @see UK2Node_AddComponent    DO NOT CALL MANUALLY - BLUEPRINT INTERNAL USE ONLY (for Add Component nodes)
		/// @param TemplateName                                  The name of the Component Template to use.
		/// @param bManualAttachment                             Whether manual or automatic attachment is to be used
		/// @param RelativeTransform                             The relative transform between the new component and its attach parent (automatic only)
		/// @param ComponentTemplateContext              Optional UBlueprintGeneratedClass reference to use to find the template in. If null (or not a BPGC), component is sought in this Actor's class
		/// </summary>
		public extern UActorComponent AddComponent(FName TemplateName,bool bManualAttachment,FTransform RelativeTransform,UObject ComponentTemplateContext);
		/// <summary>Returns whether this actor has network authority</summary>
		public extern bool HasAuthority();
		/// <summary>Destroy the actor</summary>
		public extern virtual void K2_DestroyActor();
		/// <summary>Get current state of collision for the whole actor</summary>
		public extern bool GetActorEnableCollision();
		/// <summary>Allows enabling/disabling collision for the whole actor</summary>
		public extern void SetActorEnableCollision(bool bNewActorEnableCollision);
		/// <summary>
		/// Sets the actor to be hidden in the game
		/// @param  bNewHidden      Whether or not to hide the actor and all its components
		/// </summary>
		public extern virtual void SetActorHiddenInGame(bool bNewHidden);
		/// <summary>Return the actor's relative scale 3d</summary>
		public extern FVector GetActorRelativeScale3D();
		/// <summary>
		/// Set the actor's RootComponent to the specified relative scale 3d
		/// @param NewRelativeScale      New scale to set the actor's RootComponent to
		/// </summary>
		public extern void SetActorRelativeScale3D(FVector NewRelativeScale);
		/// <summary>
		/// Set the actor's RootComponent to the specified relative transform
		/// @param NewRelativeTransform          New relative transform of the actor's root component
		/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                      If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </summary>
		public extern void K2_SetActorRelativeTransform(FTransform NewRelativeTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Set the actor's RootComponent to the specified relative rotation
		/// @param NewRelativeRotation   New relative rotation of the actor's root component
		/// @param bSweep                                Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                              Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                             Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                              If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                              If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                              If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </summary>
		public extern void K2_SetActorRelativeRotation(FRotator NewRelativeRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Set the actor's RootComponent to the specified relative location.
		/// @param NewRelativeLocation   New relative location of the actor's root component
		/// @param bSweep                                Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                              Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                             Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                              If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                              If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                              If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </summary>
		public extern void K2_SetActorRelativeLocation(FVector NewRelativeLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Adds a delta to the transform of this component in its local reference frame
		/// @param NewTransform          The change in transform in local space.
		/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                      If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </summary>
		public extern void K2_AddActorLocalTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Adds a delta to the rotation of this component in its local reference frame
		/// @param DeltaRotation         The change in rotation in local space.
		/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                      If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </summary>
		public extern void K2_AddActorLocalRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Adds a delta to the location of this component in its local reference frame.
		/// @param DelatLocation         The change in location in local space.
		/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                      If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </summary>
		public extern void K2_AddActorLocalOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Set the Actors transform to the specified one.
		/// @param NewTransform          The new transform.
		/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                      If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </summary>
		public extern bool K2_SetActorTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>Adds a delta to the transform of this actor in world space. Scale is unchanged.</summary>
		public extern void K2_AddActorWorldTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Adds a delta to the rotation of this actor in world space.
		/// @param DeltaRotation         The change in rotation.
		/// @param bSweep                        Whether to sweep to the target rotation (not currently supported for rotation).
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                      If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// @param SweepHitResult        The hit result from the move if swept.
		/// </summary>
		public extern void K2_AddActorWorldRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Adds a delta to the location of this actor in world space.
		/// @param DeltaLocation         The change in location.
		/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                      If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// @param SweepHitResult        The hit result from the move if swept.
		/// </summary>
		public extern void K2_AddActorWorldOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>Returns the dot product from this Actor to OtherActor, ignoring Z. Returns -2.0 on failure. Returns 0.0 for coincidental actors.</summary>
		public extern float GetHorizontalDotProductTo(AActor OtherActor);
		/// <summary>Returns the dot product from this Actor to OtherActor. Returns -2.0 on failure. Returns 0.0 for coincidental actors.</summary>
		public extern float GetDotProductTo(AActor OtherActor);
		/// <summary>Returns the distance from this Actor to OtherActor, ignoring XY.</summary>
		public extern float GetVerticalDistanceTo(AActor OtherActor);
		/// <summary>Returns the distance from this Actor to OtherActor, ignoring Z.</summary>
		public extern float GetHorizontalDistanceTo(AActor OtherActor);
		/// <summary>Returns the squared distance from this Actor to OtherActor.</summary>
		public extern float GetSquaredDistanceTo(AActor OtherActor);
		/// <summary>Returns the distance from this Actor to OtherActor.</summary>
		public extern float GetDistanceTo(AActor OtherActor);
		/// <summary>Returns the Actor's world-space scale.</summary>
		public extern FVector GetActorScale3D();
		/// <summary>Set the Actor's world-space scale.</summary>
		public extern void SetActorScale3D(FVector NewScale3D);
		/// <summary>
		/// Move the actor instantly to the specified location and rotation.
		/// @param NewLocation           The new location to teleport the Actor to.
		/// @param NewRotation           The new rotation for the Actor.
		/// @param bSweep                        Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                                      Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport                     Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                                      If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// @param SweepHitResult        The hit result from the move if swept.
		/// @return      Whether the rotation was successfully set.
		/// </summary>
		public extern bool K2_SetActorLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>
		/// Set the Actor's rotation instantly to the specified rotation.
		/// @param       NewRotation     The new rotation for the Actor.
		/// @param       bTeleportPhysics Whether we teleport the physics state (if physics collision is enabled for this object).
		///                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// @return      Whether the rotation was successfully set.
		/// </summary>
		public extern bool K2_SetActorRotation(FRotator NewRotation,bool bTeleportPhysics);
		/// <summary>Returns velocity (in cm/s (Unreal Units/second) of the rootcomponent if it is either using physics or has an associated MovementComponent</summary>
		public extern virtual FVector GetVelocity();
		/// <summary>Returns the RootComponent of this Actor</summary>
		public extern USceneComponent K2_GetRootComponent();
		/// <summary>
		/// Returns the bounding box of all components that make up this Actor.
		/// @param       bOnlyCollidingComponents        If true, will only return the bounding box for components with collision enabled.
		/// </summary>
		public extern void GetActorBounds(bool bOnlyCollidingComponents,out FVector Origin,out FVector BoxExtent);
		/// <summary>Get the right (Y) vector (length 1.0) from this Actor, in world space.</summary>
		public extern FVector GetActorRightVector();
		/// <summary>Get the up (Z) vector (length 1.0) from this Actor, in world space.</summary>
		public extern FVector GetActorUpVector();
		/// <summary>Get the forward (X) vector (length 1.0) from this Actor, in world space.</summary>
		public extern FVector GetActorForwardVector();
		/// <summary>Returns rotation of the RootComponent of this Actor.</summary>
		public extern FRotator K2_GetActorRotation();
		/// <summary>
		/// Move the Actor to the specified location.
		/// @param NewLocation   The new location to move the Actor to.
		/// @param bSweep                Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.
		///                                              Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect.
		/// @param bTeleport             Whether we teleport the physics state (if physics collision is enabled for this object).
		///                                              If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		///                                              If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		///                                              If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// @param SweepHitResult        The hit result from the move if swept.
		/// @return      Whether the location was successfully set (if not swept), or whether movement occurred at all (if swept).
		/// </summary>
		public extern bool K2_SetActorLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport);
		/// <summary>Returns the location of the RootComponent of this Actor</summary>
		public extern FVector K2_GetActorLocation();
		/// <summary>
		/// Get the actor-to-world transform.
		/// @return The transform that transforms from actor space to world space.
		/// </summary>
		public extern FTransform GetTransform();
		/// <summary>Returns the instigator's controller for this actor, or NULL if there is none.</summary>
		public extern AController GetInstigatorController();
		/// <summary>Returns the instigator for this actor, or NULL if there is none.</summary>
		public extern APawn GetInstigator();
		/// <summary>Gets the value of the input axis key if input is enabled for this actor.</summary>
		public extern FVector GetInputVectorAxisValue(FKey InputAxisKey);
		/// <summary>Gets the value of the input axis key if input is enabled for this actor.</summary>
		public extern float GetInputAxisKeyValue(FKey InputAxisKey);
		/// <summary>Gets the value of the input axis if input is enabled for this actor.</summary>
		public extern float GetInputAxisValue(FName InputAxisName);
		/// <summary>
		/// Removes this actor from the stack of input being handled by a PlayerController.
		/// @param PlayerController The PlayerController whose input events we no longer want to receive. If null, this actor will stop receiving input from all PlayerControllers.
		/// </summary>
		public extern virtual void DisableInput(APlayerController PlayerController);
		/// <summary>
		/// Pushes this actor on to the stack of input being handled by a PlayerController.
		/// @param PlayerController The PlayerController whose input events we want to receive.
		/// </summary>
		public extern virtual void EnableInput(APlayerController PlayerController);
		/// <summary>Called on clients when Instigator is replicated.</summary>
		public extern virtual void OnRep_Instigator();
		/// <summary>Called on client when updated AttachmentReplication value is received for this actor.</summary>
		public extern virtual void OnRep_AttachmentReplication();
		/// <summary>Returns how much control the remote machine has over this actor.</summary>
		public extern ENetRole GetRemoteRole();
		/// <summary>
		/// Set whether this actor's movement replicates to network clients.
		/// @param bInReplicateMovement Whether this Actor's movement replicates to clients.
		/// </summary>
		public extern virtual void SetReplicateMovement(bool bInReplicateMovement);
		/// <summary>
		/// Set whether this actor replicates to network clients. When this actor is spawned on the server it will be sent to clients as well.
		/// Properties flagged for replication will update on clients if they change on the server.
		/// Internally changes the RemoteRole property and handles the cases where the actor needs to be added to the network actor list.
		/// @param bInReplicates Whether this Actor replicates to network clients.
		/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication/
		/// </summary>
		public extern void SetReplicates(bool bInReplicates);
		/// <summary>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.</summary>
		public extern virtual void TearOff();
		/// <summary>Called on client when updated bReplicateMovement value is received for this actor.</summary>
		public extern virtual void OnRep_ReplicateMovement();
		/// <summary>
		/// Primary Actor tick function, which calls TickActor().
		/// Tick functions can be configured to control whether ticking is enabled, at what time during a frame the update occurs, and to set up tick dependencies.
		/// @see https://docs.unrealengine.com/latest/INT/API/Runtime/Engine/Engine/FTickFunction/
		/// @see AddTickPrerequisiteActor(), AddTickPrerequisiteComponent()
		/// </summary>
		public FActorTickFunction PrimaryActorTick;
		
		/// <summary>Allow each actor to run at a different time speed. The DeltaTime for a frame is multiplied by the global TimeDilation (in WorldSettings) and this CustomTimeDilation for this actor's tick.</summary>
		public float CustomTimeDilation;
		
		/// <summary>
		/// Allows us to only see this Actor in the Editor, and not in the actual game.
		/// @see SetActorHiddenInGame()
		/// </summary>
		public bool bHidden;
		
		/// <summary>If true, when the actor is spawned it will be sent to the client but receive no further replication updates from the server afterwards.</summary>
		public bool bNetTemporary;
		
		/// <summary>If true, this actor was loaded directly from the map, and for networking purposes can be addressed by its full path name</summary>
		public bool bNetStartup;
		
		/// <summary>If true, this actor is only relevant to its owner. If this flag is changed during play, all non-owner channels would need to be explicitly closed.</summary>
		public bool bOnlyRelevantToOwner;
		
		/// <summary>Always relevant for network (overrides bOnlyRelevantToOwner).</summary>
		public bool bAlwaysRelevant;
		
		/// <summary>
		/// If true, replicate movement/location related properties.
		/// Actor must also be set to replicate.
		/// @see SetReplicates()
		/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication/
		/// </summary>
		public bool bReplicateMovement;
		
		/// <summary>
		/// If true, this actor is no longer replicated to new clients, and is "torn off" (becomes a ROLE_Authority) on clients to which it was being replicated.
		/// @see TornOff()
		/// </summary>
		public bool bTearOff;
		
		/// <summary>
		/// Whether we have already exchanged Role/RemoteRole on the client, as when removing then re-adding a streaming level.
		/// Causes all initialization to be performed again even though the actor may not have actually been reloaded.
		/// </summary>
		public bool bExchangedRoles;
		
		/// <summary>Is this actor still pending a full net update due to clients that weren't able to replicate the actor at the time of LastNetUpdateTime</summary>
		public bool bPendingNetUpdate;
		
		/// <summary>This actor will be loaded on network clients during map load</summary>
		public bool bNetLoadOnClient;
		
		/// <summary>If actor has valid Owner, call Owner's IsNetRelevantFor and GetNetPriority</summary>
		public bool bNetUseOwnerRelevancy;
		
		/// <summary>If true, all input on the stack below this actor will not be considered</summary>
		public bool bBlockInput;
		
		/// <summary>
		/// Whether we allow this Actor to tick before it receives the BeginPlay event.
		/// Normally we don't tick actors until after BeginPlay; this setting allows this behavior to be overridden.
		/// This Actor must be able to tick for this setting to be relevant.
		/// </summary>
		public bool bAllowTickBeforeBeginPlay;
		
		/// <summary>
		/// Enables any collision on this actor.
		/// @see SetActorEnableCollision(), GetActorEnableCollision()
		/// </summary>
		public bool bActorEnableCollision;
		
		/// <summary>
		/// If true, this actor will replicate to remote machines
		/// @see SetReplicates()
		/// </summary>
		public bool bReplicates;
		
		/// <summary>Used to specify the net driver to replicate on (NAME_None || NAME_GameNetDriver is the default net driver)</summary>
		public FName NetDriverName;
		
		/// <summary>Describes how much control the remote machine has over the actor.</summary>
		public ENetRole RemoteRole;
		
		/// <summary>
		/// Owner of this Actor, used primarily for replication (bNetUseOwnerRelevancy & bOnlyRelevantToOwner) and visibility (PrimitiveComponent bOwnerNoSee and bOnlyOwnerSee)
		/// @see SetOwner(), GetOwner()
		/// </summary>
		public AActor Owner;
		
		/// <summary>Used for replication of our RootComponent's position and velocity</summary>
		public FRepMovement ReplicatedMovement;
		
		/// <summary>
		/// Used for replicating attachment of this actor's RootComponent to another actor.
		/// This is filled in via GatherCurrentMovement() when the RootComponent has an AttachParent.
		/// </summary>
		public FRepAttachment AttachmentReplication;
		
		/// <summary>Describes how much control the local machine has over the actor.</summary>
		public ENetRole Role;
		
		/// <summary>Automatically registers this actor to receive input from a player.</summary>
		public EAutoReceiveInput AutoReceiveInput;
		
		/// <summary>The priority of this input component when pushed in to the stack.</summary>
		public int InputPriority;
		
		/// <summary>Component that handles input for this actor, if input is enabled.</summary>
		public UInputComponent InputComponent;
		
		public EInputConsumeOptions InputConsumeOption;
		
		/// <summary>Square of the max distance from the client's viewpoint that this actor is relevant and will be replicated.</summary>
		public float NetCullDistanceSquared;
		
		/// <summary>Internal - used by UWorld::ServerTickClients()</summary>
		public int NetTag;
		
		/// <summary>Next time this actor will be considered for replication, set by SetNetUpdateTime()</summary>
		public float NetUpdateTime;
		
		/// <summary>How often (per second) this actor will be considered for replication, used to determine NetUpdateTime</summary>
		public float NetUpdateFrequency;
		
		/// <summary>Used to determine what rate to throttle down to when replicated properties are changing infrequently</summary>
		public float MinNetUpdateFrequency;
		
		/// <summary>Priority for this actor when checking for replication in a low bandwidth or saturated situation, higher priority means it is more likely to replicate</summary>
		public float NetPriority;
		
		/// <summary>
		/// Last time this actor was updated for replication via NetUpdateTime
		/// @warning: internal net driver time, not related to WorldSettings.TimeSeconds
		/// </summary>
		public float LastNetUpdateTime;
		
		/// <summary>If true then destroy self when "finished", meaning all relevant components report that they are done and no timelines or timers are in flight.</summary>
		public bool bAutoDestroyWhenFinished;
		
		/// <summary>
		/// Whether this actor can take damage. Must be true for damage events (e.g. ReceiveDamage()) to be called.
		/// @see https://www.unrealengine.com/blog/damage-in-ue4
		/// @see TakeDamage(), ReceiveDamage()
		/// </summary>
		public bool bCanBeDamaged;
		
		/// <summary>Set when actor is about to be deleted.</summary>
		public bool bActorIsBeingDestroyed;
		
		/// <summary>This actor collides with the world when placing in the editor, even if RootComponent collision is disabled. Does not affect spawning, @see SpawnCollisionHandlingMethod</summary>
		public bool bCollideWhenPlacing;
		
		/// <summary>If true, this actor should search for an owned camera component to view through when used as a view target.</summary>
		public bool bFindCameraComponentWhenViewTarget;
		
		/// <summary>If true, this actor will be replicated to network replays (default is true)</summary>
		public bool bRelevantForNetworkReplays;
		
		/// <summary>If true, this actor will generate overlap events when spawned as part of level streaming. You might enable this is in the case where a streaming level loads around an actor and you want overlaps to trigger.</summary>
		public bool bGenerateOverlapEventsDuringLevelStreaming;
		
		/// <summary>Pawn responsible for damage caused by this actor.</summary>
		public APawn Instigator;
		
		/// <summary>Collision primitive that defines the transform (location, rotation, scale) of this Actor.</summary>
		public USceneComponent RootComponent;
		
		/// <summary>Local space pivot offset for the actor</summary>
		public FVector PivotOffset;
		
		/// <summary>How long this Actor lives before dying, 0=forever. Note this is the INITIAL value and should not be modified once play has begun.</summary>
		public float InitialLifeSpan;
		
		/// <summary>The group this actor is a part of.</summary>
		public AActor GroupActor;
		
		/// <summary>The scale to apply to any billboard components in editor builds (happens in any WITH_EDITOR build, including non-cooked games).</summary>
		public float SpriteScale;
		
		/// <summary>
		/// The friendly name for this actor, displayed in the editor.  You should always use AActor::GetActorLabel() to access the actual label to display,
		/// and call AActor::SetActorLabel() or FActorLabelUtilities::SetActorLabelUnique() to change the label.  Never set the label directly.
		/// </summary>
		public FString ActorLabel;
		
		/// <summary>The folder path of this actor in the world (empty=root, / separated)</summary>
		public FName FolderPath;
		
		public bool bActorLabelEditable;
		
		/// <summary>Whether this actor is hidden within the editor viewport.</summary>
		public bool bHiddenEd;
		
		/// <summary>Whether the actor can be manipulated by editor operations.</summary>
		public bool bEditable;
		
		/// <summary>Whether this actor should be listed in the scene outliner.</summary>
		public bool bListedInSceneOutliner;
		
		/// <summary>Whether this actor is hidden by the layer browser.</summary>
		public bool bHiddenEdLayer;
		
		/// <summary>Whether this actor is temporarily hidden within the editor; used for show/hide/etc functionality w/o dirtying the actor.</summary>
		public bool bHiddenEdTemporary;
		
		/// <summary>Whether this actor is hidden by the level browser.</summary>
		public bool bHiddenEdLevel;
		
		/// <summary>If true, prevents the actor from being moved in the editor viewport.</summary>
		public bool bLockLocation;
		
		/// <summary>
		/// If false, the Blueprint ReceiveTick() event will be disabled on dedicated servers.
		/// @see AllowReceiveTickEventOnDedicatedServer()
		/// </summary>
		public bool bAllowReceiveTickEventOnDedicatedServer;
		
		/// <summary>Indicates the actor was pulled through a seamless travel.</summary>
		public bool bActorSeamlessTraveled;
		
		/// <summary>Whether this actor should not be affected by world origin shifting.</summary>
		public bool bIgnoresOriginShifting;
		
		/// <summary>If true, and if World setting has bEnableHierarchicalLOD equal to true, then it will generate LODActor from groups of clustered Actor</summary>
		public bool bEnableAutoLODGeneration;
		
		/// <summary>Bitflag to represent which views this actor is hidden in, via per-view layer visibility.</summary>
		public ulong HiddenEditorViews;
		
		
	}
	
}
