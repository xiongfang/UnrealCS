using System;
namespace UnrealEngine
{
	public partial class UPrimitiveComponent:USceneComponent
	{
		/// <summary>
		/// Return true if the given Pawn can step up onto this component.
		/// This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it.
		/// @param Pawn the Pawn that wants to step onto this component.
		/// @see CanCharacterStepUpOn
		/// </summary>
		public extern virtual bool CanCharacterStepUp(APawn Pawn);
		/// <summary>
		/// Changes the value of CullDistance.
		/// @param NewCullDistance - The value to assign to CullDistance.
		/// </summary>
		public extern void SetCullDistance(float NewCullDistance);
		/// <summary>
		/// Changes the current PhysMaterialOverride for this component.
		/// Note that if physics is already running on this component, this will _not_ alter its mass/inertia etc,
		/// it will only change its surface properties like friction.
		/// </summary>
		public extern virtual void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial);
		/// <summary>
		/// Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse
		/// @param       NewResponse  What the new response should be to the supplied Channel
		/// </summary>
		public extern virtual void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse);
		/// <summary>
		/// Changes a member of the ResponseToChannels container for this PrimitiveComponent.
		/// @param       Channel      The channel to change the response of
		/// @param       NewResponse  What the new response should be to the supplied Channel
		/// </summary>
		public extern virtual void SetCollisionResponseToChannel(ECollisionChannel Channel,ECollisionResponse NewResponse);
		/// <summary>Returns if any body in this component is currently awake and simulating.</summary>
		public extern virtual bool IsAnyRigidBodyAwake();
		/// <summary>Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object.</summary>
		public extern virtual FVector ScaleByMomentOfInertia(FVector InputVector,FName BoneName);
		/// <summary>Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space.</summary>
		public extern virtual FVector GetInertiaTensor(FName BoneName);
		/// <summary>Returns the mass of this component in kg.</summary>
		public extern virtual float GetMass();
		/// <summary>
		/// Override the mass (in Kg) of a single physics body.
		/// Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group.
		/// Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass.
		/// </summary>
		public extern virtual void SetMassOverrideInKg(FName BoneName,float MassInKg=1.000000f,bool bOverrideMass=true);
		/// <summary>Change the mass scale used fo all bodies in this component</summary>
		public extern virtual void SetAllMassScale(float InMassScale=1.000000f);
		/// <summary>Returns the mass scale used to calculate the mass of a single physics body</summary>
		public extern virtual float GetMassScale(FName BoneName);
		/// <summary>Change the mass scale used to calculate the mass of a single physics body</summary>
		public extern virtual void SetMassScale(FName BoneName,float InMassScale=1.000000f);
		/// <summary>Returns the angular damping of this component.</summary>
		public extern virtual float GetAngularDamping();
		/// <summary>Sets the angular damping of this component.</summary>
		public extern virtual void SetAngularDamping(float InDamping);
		/// <summary>Returns the linear damping of this component.</summary>
		public extern virtual float GetLinearDamping();
		/// <summary>Sets the linear damping of this component.</summary>
		public extern virtual void SetLinearDamping(float InDamping);
		/// <summary>Returns whether this component is affected by gravity. Returns always false if the component is not simulated.</summary>
		public extern virtual bool IsGravityEnabled();
		/// <summary>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true.</summary>
		public extern virtual void SetEnableGravity(bool bGravityEnabled);
		/// <summary>Ensure simulation is running for all bodies in this component.</summary>
		public extern virtual void WakeAllRigidBodies();
		/// <summary>Gets the collision object type</summary>
		public extern virtual ECollisionChannel GetCollisionObjectType();
		/// <summary>Gets the response type given a specific channel</summary>
		public extern virtual ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel);
		/// <summary>Utility to see if there is any physics collision enabled on this component.</summary>
		public extern bool K2_IsPhysicsCollisionEnabled();
		/// <summary>Utility to see if there is any query collision enabled on this component.</summary>
		public extern bool K2_IsQueryCollisionEnabled();
		/// <summary>Utility to see if there is any form of collision (query or physics) enabled on this component.</summary>
		public extern bool K2_IsCollisionEnabled();
		/// <summary>Returns the form of collision for this component</summary>
		public extern virtual ECollisionEnabled GetCollisionEnabled();
		/// <summary>
		/// Returns the distance and closest point to the collision surface.
		/// Component must have simple collision to be queried for closest point.
		/// @param Point                          World 3D vector
		/// @param OutPointOnBody         Point on the surface of collision closest to Point
		/// @param BoneName                       If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
		/// @return               Success if returns > 0.f, if returns 0.f, it is either not convex or inside of the point
		///                               If returns < 0.f, this primitive does not have collsion
		/// </summary>
		public extern float GetClosestPointOnCollision(FVector Point,out FVector OutPointOnBody,FName BoneName);
		/// <summary>@return number of material elements in this primitive</summary>
		public extern virtual int GetNumMaterials();
		/// <summary>Sets bRenderInMono property and marks the render state dirty.</summary>
		public extern void SetRenderInMono(bool bValue);
		/// <summary>Sets bRenderInMainPass property and marks the render state dirty.</summary>
		public extern void SetRenderInMainPass(bool bValue);
		/// <summary>Sets the CustomDepth stencil value (0 - 255) and marks the render state dirty.</summary>
		public extern void SetCustomDepthStencilValue(int Value);
		/// <summary>Sets the bRenderCustomDepth property and marks the render state dirty.</summary>
		public extern void SetRenderCustomDepth(bool bValue);
		/// <summary>Perform a line trace against a single component</summary>
		public extern bool K2_LineTraceComponent(FVector TraceStart,FVector TraceEnd,bool bTraceComplex,bool bShowTrace,out FVector HitLocation,out FVector HitNormal,out FName BoneName,out FHitResult OutHit);
		/// <summary>
		/// Changes the collision channel that this object uses when it moves
		/// @param      Channel     The new channel for this component to use
		/// </summary>
		public extern virtual void SetCollisionObjectType(ECollisionChannel Channel);
		/// <summary>Get the collision profile name</summary>
		public extern FName GetCollisionProfileName();
		/// <summary>
		/// Set Collision Profile Name
		/// This function is called by constructors when they set ProfileName
		/// This will change current CollisionProfileName to be this, and overwrite Collision Setting
		/// @param InCollisionProfileName : New Profile Name
		/// </summary>
		public extern virtual void SetCollisionProfileName(FName InCollisionProfileName);
		/// <summary>Controls what kind of collision is enabled for this body</summary>
		public extern virtual void SetCollisionEnabled(ECollisionEnabled NewType);
		/// <summary>Changes the value of TranslucentSortPriority.</summary>
		public extern void SetTranslucentSortPriority(int NewTranslucentSortPriority);
		/// <summary>Changes the value of CastShadow.</summary>
		public extern void SetCastShadow(bool NewCastShadow);
		/// <summary>Changes the value of bOnlyOwnerSee.</summary>
		public extern void SetOnlyOwnerSee(bool bNewOnlyOwnerSee);
		/// <summary>Changes the value of bOwnerNoSee.</summary>
		public extern void SetOwnerNoSee(bool bNewOwnerNoSee);
		/// <summary>
		/// Changes the value of bNotifyRigidBodyCollision
		/// @param bNewNotifyRigidBodyCollision - The value to assign to bNotifyRigidBodyCollision
		/// </summary>
		public extern virtual void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision);
		/// <summary>
		/// Force a single body back to sleep.
		/// @param  BoneName        If a SkeletalMeshComponent, name of body to put to sleep. 'None' indicates root body.
		/// </summary>
		public extern void PutRigidBodyToSleep(FName BoneName);
		/// <summary>
		/// 'Wake' physics simulation for a single body.
		/// @param  BoneName        If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body.
		/// </summary>
		public extern virtual void WakeRigidBody(FName BoneName);
		/// <summary>
		/// Set the center of mass of a single body. This will offset the physx-calculated center of mass.
		/// Note that in the case where multiple bodies are attached together, the center of mass will be set for the entire group.
		/// @param CenterOfMassOffset               User specified offset for the center of mass of this object, from the calculated location.
		/// @param BoneName                 If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
		/// </summary>
		public extern void SetCenterOfMass(FVector CenterOfMassOffset,FName BoneName);
		/// <summary>
		/// Get the center of mass of a single body. In the case of a welded body this will return the center of mass of the entire welded body (including its parent and children)
		/// Objects that are not simulated return (0,0,0) as they do not have COM
		/// @param BoneName                 If a SkeletalMeshComponent, name of body to get center of mass of. 'None' indicates root body.
		/// </summary>
		public extern FVector GetCenterOfMass(FName BoneName);
		/// <summary>
		/// Get the angular velocity of a single body, in degrees per second.
		/// @param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </summary>
		public extern FVector GetPhysicsAngularVelocity(FName BoneName);
		/// <summary>
		/// Set the maximum angular velocity of a single body.
		/// @param NewMaxAngVel             New maximum angular velocity to apply to body, in degrees per second.
		/// @param bAddToCurrent    If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.
		/// @param BoneName                 If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.
		/// </summary>
		public extern void SetPhysicsMaxAngularVelocity(float NewMaxAngVel,bool bAddToCurrent=false,FName BoneName=default(FName));
		/// <summary>
		/// Set the angular velocity of a single body.
		/// This should be used cautiously - it may be better to use AddTorque or AddImpulse.
		/// @param NewAngVel                New angular velocity to apply to body, in degrees per second.
		/// @param bAddToCurrent    If true, NewAngVel is added to the existing angular velocity of the body.
		/// @param BoneName                 If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.
		/// </summary>
		public extern void SetPhysicsAngularVelocity(FVector NewAngVel,bool bAddToCurrent=false,FName BoneName=default(FName));
		/// <summary>
		/// Set the linear velocity of all bodies in this component.
		/// @param NewVel                   New linear velocity to apply to physics.
		/// @param bAddToCurrent    If true, NewVel is added to the existing velocity of the body.
		/// </summary>
		public extern virtual void SetAllPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent=false);
		/// <summary>
		/// Get the linear velocity of a point on a single body.
		/// @param Point                    Point is specified in world space.
		/// @param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </summary>
		public extern FVector GetPhysicsLinearVelocityAtPoint(FVector Point,FName BoneName);
		/// <summary>
		/// Get the linear velocity of a single body.
		/// @param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </summary>
		public extern FVector GetPhysicsLinearVelocity(FName BoneName);
		/// <summary>
		/// Set the linear velocity of a single body.
		/// This should be used cautiously - it may be better to use AddForce or AddImpulse.
		/// @param NewVel                   New linear velocity to apply to physics.
		/// @param bAddToCurrent    If true, NewVel is added to the existing velocity of the body.
		/// @param BoneName                 If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body.
		/// </summary>
		public extern void SetPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent=false,FName BoneName=default(FName));
		/// <summary>
		/// Add a torque to a single rigid body.
		/// @param Torque           Torque to apply. Direction is axis of rotation and magnitude is strength of torque.
		/// @param BoneName         If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.
		/// @param bAccelChange If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no affect).
		/// </summary>
		public extern void AddTorque(FVector Torque,FName BoneName,bool bAccelChange=false);
		/// <summary>
		/// Add a force to all bodies in this component, originating from the supplied world-space location.
		/// @param Origin           Origin of force in world space.
		/// @param Radius           Radius within which to apply the force.
		/// @param Strength         Strength of force to apply.
		/// @param Falloff              Allows you to control the strength of the force as a function of distance from Origin.
		/// @param bAccelChange If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no affect).
		/// </summary>
		public extern virtual void AddRadialForce(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bAccelChange=false);
		/// <summary>
		/// Add a force to a single rigid body at a particular location.
		/// This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
		/// @param Force            Force vector to apply. Magnitude indicates strength of force.
		/// @param Location         Location to apply force, in world space.
		/// @param BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
		/// </summary>
		public extern virtual void AddForceAtLocation(FVector Force,FVector Location,FName BoneName);
		/// <summary>
		/// Add a force to a single rigid body.
		/// This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
		/// @param  Force            Force vector to apply. Magnitude indicates strength of force.
		/// @param  BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
		/// @param  bAccelChange If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no affect).
		/// </summary>
		public extern virtual void AddForce(FVector Force,FName BoneName,bool bAccelChange=false);
		/// <summary>
		/// Add an impulse to all rigid bodies in this component, radiating out from the specified position.
		/// @param Origin                Point of origin for the radial impulse blast, in world space
		/// @param Radius                Size of radial impulse. Beyond this distance from Origin, there will be no affect.
		/// @param Strength              Maximum strength of impulse applied to body.
		/// @param Falloff               Allows you to control the strength of the impulse as a function of distance from Origin.
		/// @param bVelChange    If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect).
		/// </summary>
		public extern virtual void AddRadialImpulse(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bVelChange=false);
		/// <summary>
		/// Add an impulse to a single rigid body at a specific location.
		/// @param  Impulse         Magnitude and direction of impulse to apply.
		/// @param  Location        Point in world space to apply impulse at.
		/// @param  BoneName        If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body.
		/// </summary>
		public extern virtual void AddImpulseAtLocation(FVector Impulse,FVector Location,FName BoneName);
		/// <summary>
		/// Add an angular impulse to a single rigid body. Good for one time instant burst.
		/// @param  AngularImpulse  Magnitude and direction of impulse to apply. Direction is axis of rotation.
		/// @param  BoneName        If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.
		/// @param  bVelChange      If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no affect).
		/// </summary>
		public extern virtual void AddAngularImpulse(FVector Impulse,FName BoneName,bool bVelChange=false);
		/// <summary>
		/// Add an impulse to a single rigid body. Good for one time instant burst.
		/// @param  Impulse         Magnitude and direction of impulse to apply.
		/// @param  BoneName        If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
		/// @param  bVelChange      If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect).
		/// </summary>
		public extern virtual void AddImpulse(FVector Impulse,FName BoneName,bool bVelChange=false);
		/// <summary>
		/// Sets the constraint mode of the component.
		/// @param ConstraintMode        The type of constraint to use.
		/// </summary>
		public extern virtual void SetConstraintMode(EDOFMode ConstraintMode);
		/// <summary>
		/// Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic).
		/// @param  bSimulate       New simulation state for single body
		/// </summary>
		public extern virtual void SetSimulatePhysics(bool bSimulate);
		/// <summary>Sets a new slope override for this component instance.</summary>
		public extern void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride);
		/// <summary>Returns the slope override struct for this component.</summary>
		public extern FWalkableSlopeOverride GetWalkableSlopeOverride();
		/// <summary>
		/// Creates a Dynamic Material Instance for the specified element index, optionally from the supplied material.
		/// @param ElementIndex - The index of the skin to replace the material for.  If invalid, the material is unchanged and NULL is returned.
		/// </summary>
		public extern virtual UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex,UMaterialInterface SourceMaterial);
		/// <summary>
		/// Changes the material applied to an element of the mesh.
		/// @param MaterialSlotName - The slot name to access the material of.
		/// @return the material used by the indexed element of this mesh.
		/// </summary>
		public extern virtual void SetMaterialByName(FName MaterialSlotName,UMaterialInterface Material);
		/// <summary>
		/// Changes the material applied to an element of the mesh.
		/// @param ElementIndex - The element to access the material of.
		/// @return the material used by the indexed element of this mesh.
		/// </summary>
		public extern virtual void SetMaterial(int ElementIndex,UMaterialInterface Material);
		/// <summary>
		/// Returns the material used by the element at the specified index
		/// @param ElementIndex - The element to access the material of.
		/// @return the material used by the indexed element of this mesh.
		/// </summary>
		public extern virtual UMaterialInterface GetMaterial(int ElementIndex);
		/// <summary>Scale the bounds of this object, used for frustum culling. Useful for features like WorldPositionOffset.</summary>
		public extern void SetBoundsScale(float NewBoundsScale=1.000000f);
		/// <summary>
		/// Check whether this component is overlapping any component of the given Actor.
		/// @param Other Actor to test this component against.
		/// @return Whether this component is overlapping any component of the given Actor.
		/// </summary>
		public extern bool IsOverlappingActor(AActor Other);
		/// <summary>
		/// Check whether this component is overlapping another component.
		/// @param OtherComp Component to test this component against.
		/// @return Whether this component is overlapping another component.
		/// </summary>
		public extern bool IsOverlappingComponent(UPrimitiveComponent OtherComp);
		/// <summary>Clear the list of components we ignore when moving.</summary>
		public extern void ClearMoveIgnoreComponents();
		/// <summary>
		/// Tells this component whether to ignore collision with another component when this component is moved.
		/// The other components may also need to be told to do the same when they move.
		/// Does not affect movement of this component when simulating physics.
		/// </summary>
		public extern void IgnoreComponentWhenMoving(UPrimitiveComponent Component,bool bShouldIgnore);
		/// <summary>Clear the list of actors we ignore when moving.</summary>
		public extern void ClearMoveIgnoreActors();
		/// <summary>
		/// Tells this component whether to ignore collision with all components of a specific Actor when this component is moved.
		/// Components on the other Actor may also need to be told to do the same when they move.
		/// Does not affect movement of this component when simulating physics.
		/// </summary>
		public extern void IgnoreActorWhenMoving(AActor Actor,bool bShouldIgnore);
		/// <summary>
		/// The minimum distance at which the primitive should be rendered,
		/// measured in world space units from the center of the primitive's bounding sphere to the camera position.
		/// </summary>
		public float MinDrawDistance;
		
		/// <summary>Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object.</summary>
		public float LDMaxDrawDistance;
		
		/// <summary>
		/// The distance to cull this primitive at.
		/// A CachedMaxDrawDistance of 0 indicates that the primitive should not be culled by distance.
		/// </summary>
		public float CachedMaxDrawDistance;
		
		/// <summary>The scene depth priority group to draw the primitive in.</summary>
		public ESceneDepthPriorityGroup DepthPriorityGroup;
		
		/// <summary>The scene depth priority group to draw the primitive in, if it's being viewed by its owner.</summary>
		public ESceneDepthPriorityGroup ViewOwnerDepthPriorityGroup;
		
		/// <summary>
		/// Indicates if we'd like to create physics state all the time (for collision and simulation).
		/// If you set this to false, it still will create physics state if collision or simulation activated.
		/// This can help performance if you'd like to avoid overhead of creating physics state when triggers
		/// </summary>
		public bool bAlwaysCreatePhysicsState;
		
		/// <summary>
		/// If true, this component will generate overlap events when it is overlapping other components (eg Begin Overlap).
		/// Both components (this and the other) must have this enabled for overlap events to occur.
		/// @see [Overlap Events](https://docs.unrealengine.com/latest/INT/Engine/Physics/Collision/index.html#overlapandgenerateoverlapevents)
		/// @see UpdateOverlaps(), BeginComponentOverlap(), EndComponentOverlap()
		/// </summary>
		public bool bGenerateOverlapEvents;
		
		/// <summary>
		/// If true, this component will generate individual overlaps for each overlapping physics body if it is a multi-body component. When false, this component will
		/// generate only one overlap, regardless of how many physics bodies it has and how many of them are overlapping another component/body. This flag has no
		/// influence on single body components.
		/// </summary>
		public bool bMultiBodyOverlap;
		
		/// <summary>
		/// If true, this component will look for collisions on both physic scenes during movement.
		/// Only required if the asynchronous physics scene is enabled and has geometry in it, and you wish to test for collisions with objects in that scene.
		/// @see MoveComponent()
		/// </summary>
		public bool bCheckAsyncSceneOnMove;
		
		/// <summary>
		/// If true, component sweeps with this component should trace against complex collision during movement (for example, each triangle of a mesh).
		/// If false, collision will be resolved against simple collision bounds instead.
		/// @see MoveComponent()
		/// </summary>
		public bool bTraceComplexOnMove;
		
		/// <summary>
		/// If true, component sweeps will return the material in their hit result.
		/// @see MoveComponent(), FHitResult
		/// </summary>
		public bool bReturnMaterialOnMove;
		
		/// <summary>True if the primitive should be rendered using ViewOwnerDepthPriorityGroup if viewed by its owner.</summary>
		public bool bUseViewOwnerDepthPriorityGroup;
		
		/// <summary>Whether to accept cull distance volumes to modify cached cull distance.</summary>
		public bool bAllowCullDistanceVolume;
		
		/// <summary>true if the primitive has motion blur velocity meshes</summary>
		public bool bHasMotionBlurVelocityMeshes;
		
		/// <summary>If true, this component will be visible in reflection captures.</summary>
		public bool bVisibleInReflectionCaptures;
		
		/// <summary>If true, this component will be rendered in the main pass (z prepass, basepass, transparency)</summary>
		public bool bRenderInMainPass;
		
		/// <summary>If true, this component will be rendered in mono only if an HMD is connected and monoscopic far field rendering is activated.</summary>
		public bool bRenderInMono;
		
		/// <summary>Whether the primitive receives decals.</summary>
		public bool bReceivesDecals;
		
		/// <summary>If this is True, this component won't be visible when the view actor is the component's owner, directly or indirectly.</summary>
		public bool bOwnerNoSee;
		
		/// <summary>If this is True, this component will only be visible when the view actor is the component's owner, directly or indirectly.</summary>
		public bool bOnlyOwnerSee;
		
		/// <summary>Treat this primitive as part of the background for occlusion purposes. This can be used as an optimization to reduce the cost of rendering skyboxes, large ground planes that are part of the vista, etc.</summary>
		public bool bTreatAsBackgroundForOcclusion;
		
		/// <summary>
		/// Whether to render the primitive in the depth only pass.
		/// This should generally be true for all objects, and let the renderer make decisions about whether to render objects in the depth only pass.
		/// @todo - if any rendering features rely on a complete depth only pass, this variable needs to go away.
		/// </summary>
		public bool bUseAsOccluder;
		
		/// <summary>If this is True, this component can be selected in the editor.</summary>
		public bool bSelectable;
		
		/// <summary>If true, forces mips for textures used by this component to be resident when this component's level is loaded.</summary>
		public bool bForceMipStreaming;
		
		/// <summary>If true a hit-proxy will be generated for each instance of instanced static meshes</summary>
		public bool bHasPerInstanceHitProxies;
		
		/// <summary>
		/// Controls whether the primitive component should cast a shadow or not.
		/// This flag is ignored (no shadows will be generated) if all materials on this component have an Unlit shading model.
		/// </summary>
		public bool CastShadow;
		
		/// <summary>Controls whether the primitive should inject light into the Light Propagation Volume.  This flag is only used if CastShadow is true. *</summary>
		public bool bAffectDynamicIndirectLighting;
		
		/// <summary>Controls whether the primitive should affect dynamic distance field lighting methods.  This flag is only used if CastShadow is true. *</summary>
		public bool bAffectDistanceFieldLighting;
		
		/// <summary>Controls whether the primitive should cast shadows in the case of non precomputed shadowing.  This flag is only used if CastShadow is true. *</summary>
		public bool bCastDynamicShadow;
		
		/// <summary>Whether the object should cast a static shadow from shadow casting lights.  This flag is only used if CastShadow is true.</summary>
		public bool bCastStaticShadow;
		
		/// <summary>
		/// Whether the object should cast a volumetric translucent shadow.
		/// Volumetric translucent shadows are useful for primitives with smoothly changing opacity like particles representing a volume,
		/// But have artifacts when used on highly opaque surfaces.
		/// </summary>
		public bool bCastVolumetricTranslucentShadow;
		
		/// <summary>
		/// When enabled, the component will only cast a shadow on itself and not other components in the world.
		/// This is especially useful for first person weapons, and forces bCastInsetShadow to be enabled.
		/// </summary>
		public bool bSelfShadowOnly;
		
		/// <summary>When enabled, the component will be rendering into the far shadow cascades (only for directional lights).</summary>
		public bool bCastFarShadow;
		
		/// <summary>
		/// Whether this component should create a per-object shadow that gives higher effective shadow resolution.
		/// Useful for cinematic character shadowing. Assumed to be enabled if bSelfShadowOnly is enabled.
		/// </summary>
		public bool bCastInsetShadow;
		
		/// <summary>
		/// Whether this component should cast shadows from lights that have bCastShadowsFromCinematicObjectsOnly enabled.
		/// This is useful for characters in a cinematic with special cinematic lights, where the cost of shadowmap rendering of the environment is undesired.
		/// </summary>
		public bool bCastCinematicShadow;
		
		/// <summary>
		/// If true, the primitive will cast shadows even if bHidden is true.
		/// Controls whether the primitive should cast shadows when hidden.
		/// This flag is only used if CastShadow is true.
		/// </summary>
		public bool bCastHiddenShadow;
		
		/// <summary>Whether this primitive should cast dynamic shadows as if it were a two sided material.</summary>
		public bool bCastShadowAsTwoSided;
		
		/// <summary>
		/// Whether to light this primitive as if it were static, including generating lightmaps.
		/// This only has an effect for component types that can bake lighting, like static mesh components.
		/// This is useful for moving meshes that don't change significantly.
		/// </summary>
		public bool bLightAsIfStatic;
		
		/// <summary>
		/// Whether to light this component and any attachments as a group.  This only has effect on the root component of an attachment tree.
		/// When enabled, attached component shadowing settings like bCastInsetShadow, bCastVolumetricTranslucentShadow, etc, will be ignored.
		/// This is useful for improving performance when multiple movable components are attached together.
		/// </summary>
		public bool bLightAttachmentsAsGroup;
		
		/// <summary>Quality of indirect lighting for Movable primitives.  This has a large effect on Indirect Lighting Cache update time.</summary>
		public EIndirectLightingCacheQuality IndirectLightingCacheQuality;
		
		/// <summary>
		/// Mobile only:
		/// If enabled this component can receive combined static and CSM shadows from a stationary light. (Enabling will increase shading cost.)
		/// If disabled this component will only receive static shadows from stationary lights.
		/// </summary>
		public bool bReceiveCombinedCSMAndStaticShadowsFromStationaryLights;
		
		/// <summary>
		/// Whether the whole component should be shadowed as one from stationary lights, which makes shadow receiving much cheaper.
		/// When enabled shadowing data comes from the volume lighting samples precomputed by Lightmass, which are very sparse.
		/// This is currently only used on stationary directional lights.
		/// </summary>
		public bool bSingleSampleShadowFromStationaryLights;
		
		/// <summary>
		/// Channels that this component should be in.  Lights with matching channels will affect the component.
		/// These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
		/// </summary>
		public FLightingChannels LightingChannels;
		
		/// <summary>Will ignore radial impulses applied to this component.</summary>
		public bool bIgnoreRadialImpulse;
		
		/// <summary>Will ignore radial forces applied to this component.</summary>
		public bool bIgnoreRadialForce;
		
		/// <summary>If this is True, this component must always be loaded on clients, even if Hidden and CollisionEnabled is NoCollision.</summary>
		public bool AlwaysLoadOnClient;
		
		/// <summary>If this is True, this component must always be loaded on servers, even if Hidden and CollisionEnabled is NoCollision</summary>
		public bool AlwaysLoadOnServer;
		
		/// <summary>Composite the drawing of this component onto the scene after post processing (only applies to editor drawing)</summary>
		public bool bUseEditorCompositing;
		
		/// <summary>If true, this component will be rendered in the CustomDepth pass (usually used for outlines)</summary>
		public bool bRenderCustomDepth;
		
		/// <summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
		public int CustomDepthStencilValue;
		
		/// <summary>
		/// Translucent objects with a lower sort priority draw behind objects with a higher priority.
		/// Translucent objects with the same priority are rendered from back-to-front based on their bounds origin.
		/// Ignored if the object is not translucent.  The default priority is zero.
		/// Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly.
		/// It is especially problematic on dynamic gameplay effects.
		/// </summary>
		public int TranslucencySortPriority;
		
		/// <summary>Used for precomputed visibility</summary>
		public int VisibilityId;
		
		/// <summary>
		/// Multiplier used to scale the Light Propagation Volume light injection bias, to reduce light bleeding.
		/// Set to 0 for no bias, 1 for default or higher for increased biasing (e.g. for
		/// thin geometry such as walls)
		/// </summary>
		public float LpvBiasMultiplier;
		
		/// <summary>Physics scene information for this component, holds a single rigid body with multiple shapes.</summary>
		public FBodyInstance BodyInstance;
		
		/// <summary>If true then DoCustomNavigableGeometryExport will be called to collect navigable geometry of this component.</summary>
		public EHasCustomNavigableGeometry bHasCustomNavigableGeometry;
		
		/// <summary>
		/// Scales the bounds of the object.
		/// This is useful when using World Position Offset to animate the vertices of the object outside of its bounds.
		/// Warning: Increasing the bounds of an object will reduce performance and shadow quality!
		/// Currently only used by StaticMeshComponent and SkeletalMeshComponent.
		/// </summary>
		public float BoundsScale;
		
		/// <summary>Last time the component was submitted for rendering (called FScene::AddPrimitive).</summary>
		public float LastSubmitTime;
		
		/// <summary>
		/// The value of WorldSettings->TimeSeconds for the frame when this component was last rendered.  This is written
		/// from the render thread, which is up to a frame behind the game thread, so you should allow this time to
		/// be at least a frame behind the game thread's world time before you consider the actor non-visible.
		/// </summary>
		public float LastRenderTime;
		
		public float LastRenderTimeOnScreen;
		
		public ECanBeCharacterBase CanBeCharacterBase;
		
		/// <summary>
		/// Determine whether a Character can step up onto this component.
		/// This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it.
		/// @see FWalkableSlopeOverride
		/// </summary>
		public ECanBeCharacterBase CanCharacterStepUpOn;
		
		/// <summary>LOD parent primitive to draw instead of this one (multiple UPrim's will point to the same LODParent )</summary>
		public UPrimitiveComponent LODParentPrimitive;
		
		/// <summary>Tick function for physics ticking *</summary>
		public FPrimitiveComponentPostPhysicsTickFunction PostPhysicsComponentTick;
		
		
	}
	
}
