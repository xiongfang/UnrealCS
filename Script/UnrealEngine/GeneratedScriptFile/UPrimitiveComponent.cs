using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPrimitiveComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CanCharacterStepUp(IntPtr _this,IntPtr Pawn);
/// <summary>
/// Return true if the given Pawn can step up onto this component.
/// This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it.
/// @param Pawn the Pawn that wants to step onto this component.
/// @see CanCharacterStepUpOn
/// </summary>
public  bool CanCharacterStepUp(APawn Pawn)
{
	CheckIsValid();
	int ___ret = CanCharacterStepUp(_this.Get(),Pawn);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCullDistance(IntPtr _this,float NewCullDistance);
/// <summary>
/// Changes the value of CullDistance.
/// @param NewCullDistance - The value to assign to CullDistance.
/// </summary>
public  void SetCullDistance(float NewCullDistance)
{
	CheckIsValid();
	SetCullDistance(_this.Get(),NewCullDistance);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysMaterialOverride(IntPtr _this,IntPtr NewPhysMaterial);
/// <summary>
/// Changes the current PhysMaterialOverride for this component.
/// Note that if physics is already running on this component, this will _not_ alter its mass/inertia etc,
/// it will only change its surface properties like friction.
/// </summary>
public  void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial)
{
	CheckIsValid();
	SetPhysMaterialOverride(_this.Get(),NewPhysMaterial);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionResponseToAllChannels(IntPtr _this,int NewResponse);
/// <summary>
/// Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse
/// @param       NewResponse  What the new response should be to the supplied Channel
/// </summary>
public  void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
{
	CheckIsValid();
	SetCollisionResponseToAllChannels(_this.Get(),(int)NewResponse);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionResponseToChannel(IntPtr _this,int Channel,int NewResponse);
/// <summary>
/// Changes a member of the ResponseToChannels container for this PrimitiveComponent.
/// @param       Channel      The channel to change the response of
/// @param       NewResponse  What the new response should be to the supplied Channel
/// </summary>
public  void SetCollisionResponseToChannel(ECollisionChannel Channel,ECollisionResponse NewResponse)
{
	CheckIsValid();
	SetCollisionResponseToChannel(_this.Get(),(int)Channel,(int)NewResponse);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsAnyRigidBodyAwake(IntPtr _this);
/// <summary>Returns if any body in this component is currently awake and simulating.</summary>
public  bool IsAnyRigidBodyAwake()
{
	CheckIsValid();
	int ___ret = IsAnyRigidBodyAwake(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ScaleByMomentOfInertia(IntPtr _this,ref FVector InputVector,string BoneName);
/// <summary>Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object.</summary>
public  FVector ScaleByMomentOfInertia(FVector InputVector,string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = ScaleByMomentOfInertia(_this.Get(),ref InputVector,BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetInertiaTensor(IntPtr _this,string BoneName);
/// <summary>Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space.</summary>
public  FVector GetInertiaTensor(string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetInertiaTensor(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMass(IntPtr _this);
/// <summary>Returns the mass of this component in kg.</summary>
public  float GetMass()
{
	CheckIsValid();
	float ___ret = GetMass(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMassOverrideInKg(IntPtr _this,string BoneName,float MassInKg,int bOverrideMass);
/// <summary>
/// Override the mass (in Kg) of a single physics body.
/// Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group.
/// Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass.
/// </summary>
public  void SetMassOverrideInKg(string BoneName="None",float MassInKg=1.000000f,bool bOverrideMass=true)
{
	CheckIsValid();
	SetMassOverrideInKg(_this.Get(),BoneName,MassInKg,bOverrideMass?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAllMassScale(IntPtr _this,float InMassScale);
/// <summary>Change the mass scale used fo all bodies in this component</summary>
public  void SetAllMassScale(float InMassScale=1.000000f)
{
	CheckIsValid();
	SetAllMassScale(_this.Get(),InMassScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMassScale(IntPtr _this,string BoneName);
/// <summary>Returns the mass scale used to calculate the mass of a single physics body</summary>
public  float GetMassScale(string BoneName="None")
{
	CheckIsValid();
	float ___ret = GetMassScale(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMassScale(IntPtr _this,string BoneName,float InMassScale);
/// <summary>Change the mass scale used to calculate the mass of a single physics body</summary>
public  void SetMassScale(string BoneName="None",float InMassScale=1.000000f)
{
	CheckIsValid();
	SetMassScale(_this.Get(),BoneName,InMassScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAngularDamping(IntPtr _this);
/// <summary>Returns the angular damping of this component.</summary>
public  float GetAngularDamping()
{
	CheckIsValid();
	float ___ret = GetAngularDamping(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularDamping(IntPtr _this,float InDamping);
/// <summary>Sets the angular damping of this component.</summary>
public  void SetAngularDamping(float InDamping)
{
	CheckIsValid();
	SetAngularDamping(_this.Get(),InDamping);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetLinearDamping(IntPtr _this);
/// <summary>Returns the linear damping of this component.</summary>
public  float GetLinearDamping()
{
	CheckIsValid();
	float ___ret = GetLinearDamping(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearDamping(IntPtr _this,float InDamping);
/// <summary>Sets the linear damping of this component.</summary>
public  void SetLinearDamping(float InDamping)
{
	CheckIsValid();
	SetLinearDamping(_this.Get(),InDamping);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsGravityEnabled(IntPtr _this);
/// <summary>Returns whether this component is affected by gravity. Returns always false if the component is not simulated.</summary>
public  bool IsGravityEnabled()
{
	CheckIsValid();
	int ___ret = IsGravityEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEnableGravity(IntPtr _this,int bGravityEnabled);
/// <summary>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true.</summary>
public  void SetEnableGravity(bool bGravityEnabled)
{
	CheckIsValid();
	SetEnableGravity(_this.Get(),bGravityEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void WakeAllRigidBodies(IntPtr _this);
/// <summary>Ensure simulation is running for all bodies in this component.</summary>
public  void WakeAllRigidBodies()
{
	CheckIsValid();
	WakeAllRigidBodies(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCollisionObjectType(IntPtr _this);
/// <summary>Gets the collision object type</summary>
public  ECollisionChannel GetCollisionObjectType()
{
	CheckIsValid();
	int ___ret = GetCollisionObjectType(_this.Get());
	return (ECollisionChannel)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCollisionResponseToChannel(IntPtr _this,int Channel);
/// <summary>Gets the response type given a specific channel</summary>
public  ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel)
{
	CheckIsValid();
	int ___ret = GetCollisionResponseToChannel(_this.Get(),(int)Channel);
	return (ECollisionResponse)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsPhysicsCollisionEnabled(IntPtr _this);
/// <summary>Utility to see if there is any physics collision enabled on this component.</summary>
public  bool K2_IsPhysicsCollisionEnabled()
{
	CheckIsValid();
	int ___ret = K2_IsPhysicsCollisionEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsQueryCollisionEnabled(IntPtr _this);
/// <summary>Utility to see if there is any query collision enabled on this component.</summary>
public  bool K2_IsQueryCollisionEnabled()
{
	CheckIsValid();
	int ___ret = K2_IsQueryCollisionEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsCollisionEnabled(IntPtr _this);
/// <summary>Utility to see if there is any form of collision (query or physics) enabled on this component.</summary>
public  bool K2_IsCollisionEnabled()
{
	CheckIsValid();
	int ___ret = K2_IsCollisionEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCollisionEnabled(IntPtr _this);
/// <summary>Returns the form of collision for this component</summary>
public  ECollisionEnabled GetCollisionEnabled()
{
	CheckIsValid();
	int ___ret = GetCollisionEnabled(_this.Get());
	return (ECollisionEnabled)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetClosestPointOnCollision(IntPtr _this,ref FVector Point,out FVector OutPointOnBody,string BoneName);
/// <summary>
/// Returns the distance and closest point to the collision surface.
/// Component must have simple collision to be queried for closest point.
/// @param Point                          World 3D vector
/// @param OutPointOnBody         Point on the surface of collision closest to Point
/// @param BoneName                       If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
/// @return               Success if returns > 0.f, if returns 0.f, it is either not convex or inside of the point
///                               If returns < 0.f, this primitive does not have collsion
/// </summary>
public  float GetClosestPointOnCollision(FVector Point,out FVector OutPointOnBody,string BoneName="None")
{
	CheckIsValid();
	float ___ret = GetClosestPointOnCollision(_this.Get(),ref Point,out OutPointOnBody,BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumMaterials(IntPtr _this);
/// <summary>@return number of material elements in this primitive</summary>
public  int GetNumMaterials()
{
	CheckIsValid();
	int ___ret = GetNumMaterials(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderInMainPass(IntPtr _this,int bValue);
/// <summary>Sets bRenderInMainPass property and marks the render state dirty.</summary>
public  void SetRenderInMainPass(bool bValue)
{
	CheckIsValid();
	SetRenderInMainPass(_this.Get(),bValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCustomDepthStencilValue(IntPtr _this,int Value);
/// <summary>Sets the CustomDepth stencil value (0 - 255) and marks the render state dirty.</summary>
public  void SetCustomDepthStencilValue(int Value)
{
	CheckIsValid();
	SetCustomDepthStencilValue(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderCustomDepth(IntPtr _this,int bValue);
/// <summary>Sets the bRenderCustomDepth property and marks the render state dirty.</summary>
public  void SetRenderCustomDepth(bool bValue)
{
	CheckIsValid();
	SetRenderCustomDepth(_this.Get(),bValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_LineTraceComponent(IntPtr _this,ref FVector TraceStart,ref FVector TraceEnd,int bTraceComplex,int bShowTrace,out FVector HitLocation,out FVector HitNormal,out string BoneName);
/// <summary>Perform a line trace against a single component</summary>
public  bool K2_LineTraceComponent(FVector TraceStart,FVector TraceEnd,bool bTraceComplex,bool bShowTrace,out FVector HitLocation,out FVector HitNormal,out string BoneName)
{
	CheckIsValid();
	int ___ret = K2_LineTraceComponent(_this.Get(),ref TraceStart,ref TraceEnd,bTraceComplex?1:0,bShowTrace?1:0,out HitLocation,out HitNormal,out BoneName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionObjectType(IntPtr _this,int Channel);
/// <summary>
/// Changes the collision channel that this object uses when it moves
/// @param      Channel     The new channel for this component to use
/// </summary>
public  void SetCollisionObjectType(ECollisionChannel Channel)
{
	CheckIsValid();
	SetCollisionObjectType(_this.Get(),(int)Channel);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetCollisionProfileName(IntPtr _this);
/// <summary>Get the collision profile name</summary>
public  string GetCollisionProfileName()
{
	CheckIsValid();
	string ___ret = GetCollisionProfileName(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionProfileName(IntPtr _this,string InCollisionProfileName);
/// <summary>
/// Set Collision Profile Name
/// This function is called by constructors when they set ProfileName
/// This will change current CollisionProfileName to be this, and overwrite Collision Setting
/// @param InCollisionProfileName : New Profile Name
/// </summary>
public  void SetCollisionProfileName(string InCollisionProfileName)
{
	CheckIsValid();
	SetCollisionProfileName(_this.Get(),InCollisionProfileName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionEnabled(IntPtr _this,int NewType);
/// <summary>Controls what kind of collision is enabled for this body</summary>
public  void SetCollisionEnabled(ECollisionEnabled NewType)
{
	CheckIsValid();
	SetCollisionEnabled(_this.Get(),(int)NewType);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTranslucentSortPriority(IntPtr _this,int NewTranslucentSortPriority);
/// <summary>Changes the value of TranslucentSortPriority.</summary>
public  void SetTranslucentSortPriority(int NewTranslucentSortPriority)
{
	CheckIsValid();
	SetTranslucentSortPriority(_this.Get(),NewTranslucentSortPriority);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCastShadow(IntPtr _this,int NewCastShadow);
/// <summary>Changes the value of CastShadow.</summary>
public  void SetCastShadow(bool NewCastShadow)
{
	CheckIsValid();
	SetCastShadow(_this.Get(),NewCastShadow?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOnlyOwnerSee(IntPtr _this,int bNewOnlyOwnerSee);
/// <summary>Changes the value of bOnlyOwnerSee.</summary>
public  void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
{
	CheckIsValid();
	SetOnlyOwnerSee(_this.Get(),bNewOnlyOwnerSee?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOwnerNoSee(IntPtr _this,int bNewOwnerNoSee);
/// <summary>Changes the value of bOwnerNoSee.</summary>
public  void SetOwnerNoSee(bool bNewOwnerNoSee)
{
	CheckIsValid();
	SetOwnerNoSee(_this.Get(),bNewOwnerNoSee?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNotifyRigidBodyCollision(IntPtr _this,int bNewNotifyRigidBodyCollision);
/// <summary>
/// Changes the value of bNotifyRigidBodyCollision
/// @param bNewNotifyRigidBodyCollision - The value to assign to bNotifyRigidBodyCollision
/// </summary>
public  void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	CheckIsValid();
	SetNotifyRigidBodyCollision(_this.Get(),bNewNotifyRigidBodyCollision?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PutRigidBodyToSleep(IntPtr _this,string BoneName);
/// <summary>
/// Force a single body back to sleep.
/// @param  BoneName        If a SkeletalMeshComponent, name of body to put to sleep. 'None' indicates root body.
/// </summary>
public  void PutRigidBodyToSleep(string BoneName="None")
{
	CheckIsValid();
	PutRigidBodyToSleep(_this.Get(),BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void WakeRigidBody(IntPtr _this,string BoneName);
/// <summary>
/// 'Wake' physics simulation for a single body.
/// @param  BoneName        If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body.
/// </summary>
public  void WakeRigidBody(string BoneName="None")
{
	CheckIsValid();
	WakeRigidBody(_this.Get(),BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCenterOfMass(IntPtr _this,ref FVector CenterOfMassOffset,string BoneName);
/// <summary>
/// Set the center of mass of a single body. This will offset the physx-calculated center of mass.
/// Note that in the case where multiple bodies are attached together, the center of mass will be set for the entire group.
/// @param CenterOfMassOffset               User specified offset for the center of mass of this object, from the calculated location.
/// @param BoneName                 If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
/// </summary>
public  void SetCenterOfMass(FVector CenterOfMassOffset,string BoneName="None")
{
	CheckIsValid();
	SetCenterOfMass(_this.Get(),ref CenterOfMassOffset,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetCenterOfMass(IntPtr _this,string BoneName);
/// <summary>
/// Get the center of mass of a single body. In the case of a welded body this will return the center of mass of the entire welded body (including its parent and children)
/// Objects that are not simulated return (0,0,0) as they do not have COM
/// @param BoneName                 If a SkeletalMeshComponent, name of body to get center of mass of. 'None' indicates root body.
/// </summary>
public  FVector GetCenterOfMass(string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetCenterOfMass(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPhysicsAngularVelocity(IntPtr _this,string BoneName);
/// <summary>
/// Get the angular velocity of a single body, in degrees per second.
/// @param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
/// </summary>
public  FVector GetPhysicsAngularVelocity(string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetPhysicsAngularVelocity(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysicsMaxAngularVelocity(IntPtr _this,float NewMaxAngVel,int bAddToCurrent,string BoneName);
/// <summary>
/// Set the maximum angular velocity of a single body.
/// @param NewMaxAngVel             New maximum angular velocity to apply to body, in degrees per second.
/// @param bAddToCurrent    If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.
/// @param BoneName                 If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.
/// </summary>
public  void SetPhysicsMaxAngularVelocity(float NewMaxAngVel,bool bAddToCurrent=false,string BoneName="None")
{
	CheckIsValid();
	SetPhysicsMaxAngularVelocity(_this.Get(),NewMaxAngVel,bAddToCurrent?1:0,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysicsAngularVelocity(IntPtr _this,ref FVector NewAngVel,int bAddToCurrent,string BoneName);
/// <summary>
/// Set the angular velocity of a single body.
/// This should be used cautiously - it may be better to use AddTorque or AddImpulse.
/// @param NewAngVel                New angular velocity to apply to body, in degrees per second.
/// @param bAddToCurrent    If true, NewAngVel is added to the existing angular velocity of the body.
/// @param BoneName                 If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.
/// </summary>
public  void SetPhysicsAngularVelocity(FVector NewAngVel,bool bAddToCurrent=false,string BoneName="None")
{
	CheckIsValid();
	SetPhysicsAngularVelocity(_this.Get(),ref NewAngVel,bAddToCurrent?1:0,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAllPhysicsLinearVelocity(IntPtr _this,ref FVector NewVel,int bAddToCurrent);
/// <summary>
/// Set the linear velocity of all bodies in this component.
/// @param NewVel                   New linear velocity to apply to physics.
/// @param bAddToCurrent    If true, NewVel is added to the existing velocity of the body.
/// </summary>
public  void SetAllPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent=false)
{
	CheckIsValid();
	SetAllPhysicsLinearVelocity(_this.Get(),ref NewVel,bAddToCurrent?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPhysicsLinearVelocityAtPoint(IntPtr _this,ref FVector Point,string BoneName);
/// <summary>
/// Get the linear velocity of a point on a single body.
/// @param Point                    Point is specified in world space.
/// @param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
/// </summary>
public  FVector GetPhysicsLinearVelocityAtPoint(FVector Point,string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetPhysicsLinearVelocityAtPoint(_this.Get(),ref Point,BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPhysicsLinearVelocity(IntPtr _this,string BoneName);
/// <summary>
/// Get the linear velocity of a single body.
/// @param BoneName                 If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
/// </summary>
public  FVector GetPhysicsLinearVelocity(string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetPhysicsLinearVelocity(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysicsLinearVelocity(IntPtr _this,ref FVector NewVel,int bAddToCurrent,string BoneName);
/// <summary>
/// Set the linear velocity of a single body.
/// This should be used cautiously - it may be better to use AddForce or AddImpulse.
/// @param NewVel                   New linear velocity to apply to physics.
/// @param bAddToCurrent    If true, NewVel is added to the existing velocity of the body.
/// @param BoneName                 If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body.
/// </summary>
public  void SetPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent=false,string BoneName="None")
{
	CheckIsValid();
	SetPhysicsLinearVelocity(_this.Get(),ref NewVel,bAddToCurrent?1:0,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddTorque(IntPtr _this,ref FVector Torque,string BoneName,int bAccelChange);
/// <summary>
/// Add a torque to a single rigid body.
/// @param Torque           Torque to apply. Direction is axis of rotation and magnitude is strength of torque.
/// @param BoneName         If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.
/// @param bAccelChange If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no affect).
/// </summary>
public  void AddTorque(FVector Torque,string BoneName="None",bool bAccelChange=false)
{
	CheckIsValid();
	AddTorque(_this.Get(),ref Torque,BoneName,bAccelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddRadialForce(IntPtr _this,ref FVector Origin,float Radius,float Strength,int Falloff,int bAccelChange);
/// <summary>
/// Add a force to all bodies in this component, originating from the supplied world-space location.
/// @param Origin           Origin of force in world space.
/// @param Radius           Radius within which to apply the force.
/// @param Strength         Strength of force to apply.
/// @param Falloff              Allows you to control the strength of the force as a function of distance from Origin.
/// @param bAccelChange If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no affect).
/// </summary>
public  void AddRadialForce(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bAccelChange=false)
{
	CheckIsValid();
	AddRadialForce(_this.Get(),ref Origin,Radius,Strength,(int)Falloff,bAccelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddForceAtLocation(IntPtr _this,ref FVector Force,ref FVector Location,string BoneName);
/// <summary>
/// Add a force to a single rigid body at a particular location.
/// This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
/// @param Force            Force vector to apply. Magnitude indicates strength of force.
/// @param Location         Location to apply force, in world space.
/// @param BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
/// </summary>
public  void AddForceAtLocation(FVector Force,FVector Location,string BoneName="None")
{
	CheckIsValid();
	AddForceAtLocation(_this.Get(),ref Force,ref Location,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddForce(IntPtr _this,ref FVector Force,string BoneName,int bAccelChange);
/// <summary>
/// Add a force to a single rigid body.
/// This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
/// @param  Force            Force vector to apply. Magnitude indicates strength of force.
/// @param  BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
/// @param  bAccelChange If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no affect).
/// </summary>
public  void AddForce(FVector Force,string BoneName="None",bool bAccelChange=false)
{
	CheckIsValid();
	AddForce(_this.Get(),ref Force,BoneName,bAccelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddRadialImpulse(IntPtr _this,ref FVector Origin,float Radius,float Strength,int Falloff,int bVelChange);
/// <summary>
/// Add an impulse to all rigid bodies in this component, radiating out from the specified position.
/// @param Origin                Point of origin for the radial impulse blast, in world space
/// @param Radius                Size of radial impulse. Beyond this distance from Origin, there will be no affect.
/// @param Strength              Maximum strength of impulse applied to body.
/// @param Falloff               Allows you to control the strength of the impulse as a function of distance from Origin.
/// @param bVelChange    If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect).
/// </summary>
public  void AddRadialImpulse(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bVelChange=false)
{
	CheckIsValid();
	AddRadialImpulse(_this.Get(),ref Origin,Radius,Strength,(int)Falloff,bVelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddImpulseAtLocation(IntPtr _this,ref FVector Impulse,ref FVector Location,string BoneName);
/// <summary>
/// Add an impulse to a single rigid body at a specific location.
/// @param  Impulse         Magnitude and direction of impulse to apply.
/// @param  Location        Point in world space to apply impulse at.
/// @param  BoneName        If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body.
/// </summary>
public  void AddImpulseAtLocation(FVector Impulse,FVector Location,string BoneName="None")
{
	CheckIsValid();
	AddImpulseAtLocation(_this.Get(),ref Impulse,ref Location,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddAngularImpulse(IntPtr _this,ref FVector Impulse,string BoneName,int bVelChange);
/// <summary>
/// Add an angular impulse to a single rigid body. Good for one time instant burst.
/// @param  AngularImpulse  Magnitude and direction of impulse to apply. Direction is axis of rotation.
/// @param  BoneName        If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.
/// @param  bVelChange      If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no affect).
/// </summary>
public  void AddAngularImpulse(FVector Impulse,string BoneName="None",bool bVelChange=false)
{
	CheckIsValid();
	AddAngularImpulse(_this.Get(),ref Impulse,BoneName,bVelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddImpulse(IntPtr _this,ref FVector Impulse,string BoneName,int bVelChange);
/// <summary>
/// Add an impulse to a single rigid body. Good for one time instant burst.
/// @param  Impulse         Magnitude and direction of impulse to apply.
/// @param  BoneName        If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
/// @param  bVelChange      If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect).
/// </summary>
public  void AddImpulse(FVector Impulse,string BoneName="None",bool bVelChange=false)
{
	CheckIsValid();
	AddImpulse(_this.Get(),ref Impulse,BoneName,bVelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintMode(IntPtr _this,int ConstraintMode);
/// <summary>
/// Sets the constraint mode of the component.
/// @param ConstraintMode        The type of constraint to use.
/// </summary>
public  void SetConstraintMode(EDOFMode ConstraintMode)
{
	CheckIsValid();
	SetConstraintMode(_this.Get(),(int)ConstraintMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSimulatePhysics(IntPtr _this,int bSimulate);
/// <summary>
/// Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic).
/// @param  bSimulate       New simulation state for single body
/// </summary>
public  void SetSimulatePhysics(bool bSimulate)
{
	CheckIsValid();
	SetSimulatePhysics(_this.Get(),bSimulate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWalkableSlopeOverride(IntPtr _this,ref FWalkableSlopeOverride NewOverride);
/// <summary>Sets a new slope override for this component instance.</summary>
public  void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride)
{
	CheckIsValid();
	SetWalkableSlopeOverride(_this.Get(),ref NewOverride);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FWalkableSlopeOverride GetWalkableSlopeOverride(IntPtr _this);
/// <summary>Returns the slope override struct for this component.</summary>
public  FWalkableSlopeOverride GetWalkableSlopeOverride()
{
	CheckIsValid();
	FWalkableSlopeOverride ___ret = GetWalkableSlopeOverride(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateDynamicMaterialInstance(IntPtr _this,int ElementIndex,IntPtr SourceMaterial);
/// <summary>
/// Creates a Dynamic Material Instance for the specified element index, optionally from the supplied material.
/// @param ElementIndex - The index of the skin to replace the material for.  If invalid, the material is unchanged and NULL is returned.
/// </summary>
public  UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex,UMaterialInterface SourceMaterial)
{
	CheckIsValid();
	IntPtr ___ret = CreateDynamicMaterialInstance(_this.Get(),ElementIndex,SourceMaterial);
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaterialByName(IntPtr _this,string MaterialSlotName,IntPtr Material);
/// <summary>
/// Changes the material applied to an element of the mesh.
/// @param MaterialSlotName - The slot name to access the material of.
/// @return the material used by the indexed element of this mesh.
/// </summary>
public  void SetMaterialByName(string MaterialSlotName,UMaterialInterface Material)
{
	CheckIsValid();
	SetMaterialByName(_this.Get(),MaterialSlotName,Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaterial(IntPtr _this,int ElementIndex,IntPtr Material);
/// <summary>
/// Changes the material applied to an element of the mesh.
/// @param ElementIndex - The element to access the material of.
/// @return the material used by the indexed element of this mesh.
/// </summary>
public  void SetMaterial(int ElementIndex,UMaterialInterface Material)
{
	CheckIsValid();
	SetMaterial(_this.Get(),ElementIndex,Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetMaterial(IntPtr _this,int ElementIndex);
/// <summary>
/// Returns the material used by the element at the specified index
/// @param ElementIndex - The element to access the material of.
/// @return the material used by the indexed element of this mesh.
/// </summary>
public  UMaterialInterface GetMaterial(int ElementIndex)
{
	CheckIsValid();
	IntPtr ___ret = GetMaterial(_this.Get(),ElementIndex);
	if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoundsScale(IntPtr _this,float NewBoundsScale);
/// <summary>Scale the bounds of this object, used for frustum culling. Useful for features like WorldPositionOffset.</summary>
public  void SetBoundsScale(float NewBoundsScale=1.000000f)
{
	CheckIsValid();
	SetBoundsScale(_this.Get(),NewBoundsScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FOverlapInfo[] GetOverlapInfos(IntPtr _this);
/// <summary>Returns list of components this component is overlapping.</summary>
public  FOverlapInfo[] GetOverlapInfos()
{
	CheckIsValid();
	FOverlapInfo[] ___ret = GetOverlapInfos(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetOverlappingComponents(IntPtr _this,out IntPtr[] InOverlappingComponents);
/// <summary>Returns list of components this component is overlapping.</summary>
public  void GetOverlappingComponents(out UPrimitiveComponent[] InOverlappingComponents)
{
	CheckIsValid();
	IntPtr[] InOverlappingComponents_temp;
	GetOverlappingComponents(_this.Get(),out InOverlappingComponents_temp);
	InOverlappingComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(InOverlappingComponents_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetOverlappingActors(IntPtr _this,out IntPtr[] OverlappingActors,IntPtr ClassFilter);
/// <summary>
/// Returns a list of actors that this component is overlapping.
/// @param OverlappingActors             [out] Returned list of overlapping actors
/// @param ClassFilter                   [optional] If set, only returns actors of this class or subclasses
/// </summary>
public  void GetOverlappingActors(out AActor[] OverlappingActors,TSubclassOf<AActor>  ClassFilter)
{
	CheckIsValid();
	IntPtr[] OverlappingActors_temp;
	GetOverlappingActors(_this.Get(),out OverlappingActors_temp,ClassFilter.NativeClass);
	OverlappingActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OverlappingActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsOverlappingActor(IntPtr _this,IntPtr Other);
/// <summary>
/// Check whether this component is overlapping any component of the given Actor.
/// @param Other Actor to test this component against.
/// @return Whether this component is overlapping any component of the given Actor.
/// </summary>
public  bool IsOverlappingActor(AActor Other)
{
	CheckIsValid();
	int ___ret = IsOverlappingActor(_this.Get(),Other);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsOverlappingComponent(IntPtr _this,IntPtr OtherComp);
/// <summary>
/// Check whether this component is overlapping another component.
/// @param OtherComp Component to test this component against.
/// @return Whether this component is overlapping another component.
/// </summary>
public  bool IsOverlappingComponent(UPrimitiveComponent OtherComp)
{
	CheckIsValid();
	int ___ret = IsOverlappingComponent(_this.Get(),OtherComp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMoveIgnoreComponents(IntPtr _this);
/// <summary>Clear the list of components we ignore when moving.</summary>
public  void ClearMoveIgnoreComponents()
{
	CheckIsValid();
	ClearMoveIgnoreComponents(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr[] CopyArrayOfMoveIgnoreComponents(IntPtr _this);
/// <summary>Returns the list of actors we currently ignore when moving.</summary>
public  UPrimitiveComponent[] CopyArrayOfMoveIgnoreComponents()
{
	CheckIsValid();
	IntPtr[] ___ret = CopyArrayOfMoveIgnoreComponents(_this.Get());
	return MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(___ret);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void IgnoreComponentWhenMoving(IntPtr _this,IntPtr Component,int bShouldIgnore);
/// <summary>
/// Tells this component whether to ignore collision with another component when this component is moved.
/// The other components may also need to be told to do the same when they move.
/// Does not affect movement of this component when simulating physics.
/// </summary>
public  void IgnoreComponentWhenMoving(UPrimitiveComponent Component,bool bShouldIgnore)
{
	CheckIsValid();
	IgnoreComponentWhenMoving(_this.Get(),Component,bShouldIgnore?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMoveIgnoreActors(IntPtr _this);
/// <summary>Clear the list of actors we ignore when moving.</summary>
public  void ClearMoveIgnoreActors()
{
	CheckIsValid();
	ClearMoveIgnoreActors(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr[] CopyArrayOfMoveIgnoreActors(IntPtr _this);
/// <summary>Returns the list of actors we currently ignore when moving.</summary>
public  AActor[] CopyArrayOfMoveIgnoreActors()
{
	CheckIsValid();
	IntPtr[] ___ret = CopyArrayOfMoveIgnoreActors(_this.Get());
	return MarshalUtil.IntPtrArrayToObjectArray<AActor>(___ret);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void IgnoreActorWhenMoving(IntPtr _this,IntPtr Actor,int bShouldIgnore);
/// <summary>
/// Tells this component whether to ignore collision with all components of a specific Actor when this component is moved.
/// Components on the other Actor may also need to be told to do the same when they move.
/// Does not affect movement of this component when simulating physics.
/// </summary>
public  void IgnoreActorWhenMoving(AActor Actor,bool bShouldIgnore)
{
	CheckIsValid();
	IgnoreActorWhenMoving(_this.Get(),Actor,bShouldIgnore?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
