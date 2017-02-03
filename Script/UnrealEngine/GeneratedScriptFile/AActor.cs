using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AActor:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr[] GetComponentsByTag(IntPtr _this,IntPtr ComponentClass,string Tag);
/// <summary>Gets all the components that inherit from the given class with a given tag.</summary>
public  UActorComponent[] GetComponentsByTag(TSubclassOf<UActorComponent>  ComponentClass,string Tag)
{
	CheckIsValid();
	IntPtr[] ___ret = GetComponentsByTag(_this.Get(),ComponentClass.NativeClass,Tag);
	return MarshalUtil.IntPtrArrayToObjectArray<UActorComponent>(___ret);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr[] GetComponentsByClass(IntPtr _this,IntPtr ComponentClass);
/// <summary>
/// Gets all the components that inherit from the given class.
///               Currently returns an array of UActorComponent which must be cast to the correct type.
/// </summary>
public  UActorComponent[] GetComponentsByClass(TSubclassOf<UActorComponent>  ComponentClass)
{
	CheckIsValid();
	IntPtr[] ___ret = GetComponentsByClass(_this.Get(),ComponentClass.NativeClass);
	return MarshalUtil.IntPtrArrayToObjectArray<UActorComponent>(___ret);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetComponentByClass(IntPtr _this,IntPtr ComponentClass);
/// <summary>Script exposed version of FindComponentByClass</summary>
public  UActorComponent GetComponentByClass(TSubclassOf<UActorComponent>  ComponentClass)
{
	CheckIsValid();
	IntPtr ___ret = GetComponentByClass(_this.Get(),ComponentClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UActorComponent ___ret2= new UActorComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetActorEyesViewPoint(IntPtr _this,out FVector OutLocation,out FRotator OutRotation);
/// <summary>
/// Returns the point of view of the actor.
/// Note that this doesn't mean the camera, but the 'eyes' of the actor.
/// For example, for a Pawn, this would define the eye height location,
/// and view rotation (which is different from the pawn rotation which has a zeroed pitch component).
/// A camera first person view will typically use this view point. Most traces (weapon, AI) will be done from this view point.
/// @param       OutLocation - location of view point
/// @param       OutRotation - view rotation of actor.
/// </summary>
public  void GetActorEyesViewPoint(out FVector OutLocation,out FRotator OutRotation)
{
	CheckIsValid();
	GetActorEyesViewPoint(_this.Get(),out OutLocation,out OutRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ForceNetUpdate(IntPtr _this);
/// <summary>Force actor to be updated to clients</summary>
public  void ForceNetUpdate()
{
	CheckIsValid();
	ForceNetUpdate(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int WasRecentlyRendered(IntPtr _this,float Tolerance);
/// <summary>
/// Returns true if this actor has been rendered "recently", with a tolerance in seconds to define what "recent" means.
/// e.g.: If a tolerance of 0.1 is used, this function will return true only if the actor was rendered in the last 0.1 seconds of game time.
/// @param Tolerance  How many seconds ago the actor last render time can be and still count as having been "recently" rendered.
/// @return Whether this actor was recently rendered.
/// </summary>
public  bool WasRecentlyRendered(float Tolerance=0.200000f)
{
	CheckIsValid();
	int ___ret = WasRecentlyRendered(_this.Get(),Tolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTickGroup(IntPtr _this,int NewTickGroup);
/// <summary>
/// Sets the ticking group for this actor.
/// @param NewTickGroup the new value to assign
/// </summary>
public  void SetTickGroup(ETickingGroup NewTickGroup)
{
	CheckIsValid();
	SetTickGroup(_this.Get(),(int)NewTickGroup);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAttachedActors(IntPtr _this,out IntPtr[] OutActors);
/// <summary>Find all Actors which are attached directly to a component in this actor</summary>
public  void GetAttachedActors(out AActor[] OutActors)
{
	CheckIsValid();
	IntPtr[] OutActors_temp;
	GetAttachedActors(_this.Get(),out OutActors_temp);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_TeleportTo(IntPtr _this,ref FVector DestLocation,ref FRotator DestRotation);
/// <summary>
/// Teleport this actor to a new location. If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such.
/// @param DestLocation The target destination point
/// @param DestRotation The target rotation at the destination
/// @return true if the actor has been successfully moved, or false if it couldn't fit.
/// </summary>
public  bool K2_TeleportTo(FVector DestLocation,FRotator DestRotation)
{
	CheckIsValid();
	int ___ret = K2_TeleportTo(_this.Get(),ref DestLocation,ref DestRotation);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetParentActor(IntPtr _this);
public  AActor GetParentActor()
{
	CheckIsValid();
	IntPtr ___ret = GetParentActor(_this.Get());
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetParentComponent(IntPtr _this);
public  UChildActorComponent GetParentComponent()
{
	CheckIsValid();
	IntPtr ___ret = GetParentComponent(_this.Get());
	if(___ret==IntPtr.Zero) return null; UChildActorComponent ___ret2= new UChildActorComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAllChildActors(IntPtr _this,out IntPtr[] ChildActors,int bIncludeDescendants);
/// <summary>Returns a list of all child actors, including children of children</summary>
public  void GetAllChildActors(out AActor[] ChildActors,bool bIncludeDescendants=true)
{
	CheckIsValid();
	IntPtr[] ChildActors_temp;
	GetAllChildActors(_this.Get(),out ChildActors_temp,bIncludeDescendants?1:0);
	ChildActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(ChildActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsChildActor(IntPtr _this);
/// <summary>Returns whether this Actor was spawned by a child actor component</summary>
public  bool IsChildActor()
{
	CheckIsValid();
	int ___ret = IsChildActor(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FlushNetDormancy(IntPtr _this);
/// <summary>Forces dormant actor to replicate but doesn't change NetDormancy state (i.e., they will go dormant again if left dormant)</summary>
public  void FlushNetDormancy()
{
	CheckIsValid();
	FlushNetDormancy(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsOverlappingActor(IntPtr _this,IntPtr Other);
/// <summary>
/// Check whether any component of this Actor is overlapping any component of another Actor.
/// @param Other The other Actor to test against
/// @return Whether any component of this Actor is overlapping any component of another Actor.
/// </summary>
public  bool IsOverlappingActor(AActor Other)
{
	CheckIsValid();
	int ___ret = IsOverlappingActor(_this.Get(),Other);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwner(IntPtr _this);
/// <summary>
/// Get the owner of this Actor, used primarily for network replication.
/// @return Actor that owns this Actor
/// </summary>
public  AActor GetOwner()
{
	CheckIsValid();
	IntPtr ___ret = GetOwner(_this.Get());
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOwner(IntPtr _this,IntPtr NewOwner);
/// <summary>
/// Set the owner of this Actor, used primarily for network replication.
/// @param NewOwner      The Actor whom takes over ownership of this Actor
/// </summary>
public  void SetOwner(AActor NewOwner)
{
	CheckIsValid();
	SetOwner(_this.Get(),NewOwner);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ReplicatedMovement(IntPtr _this);
/// <summary>ReplicatedMovement struct replication event</summary>
public  void OnRep_ReplicatedMovement()
{
	CheckIsValid();
	OnRep_ReplicatedMovement(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetActorTickInterval(IntPtr _this);
/// <summary>Returns the tick interval of this actor's primary tick function</summary>
public  float GetActorTickInterval()
{
	CheckIsValid();
	float ___ret = GetActorTickInterval(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActorTickInterval(IntPtr _this,float TickInterval);
/// <summary>
/// Sets the tick interval of this actor's primary tick function. Will not enable a disabled tick function. Takes effect on next tick.
/// @param TickInterval   The rate at which this actor should be ticking
/// </summary>
public  void SetActorTickInterval(float TickInterval)
{
	CheckIsValid();
	SetActorTickInterval(_this.Get(),TickInterval);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsActorTickEnabled(IntPtr _this);
/// <summary>Returns whether this actor has tick enabled or not</summary>
public  bool IsActorTickEnabled()
{
	CheckIsValid();
	int ___ret = IsActorTickEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActorTickEnabled(IntPtr _this,int bEnabled);
/// <summary>
/// Set this actor's tick functions to be enabled or disabled. Only has an effect if the function is registered
/// This only modifies the tick function on actor itself
/// @param       bEnabled        Whether it should be enabled or not
/// </summary>
public  void SetActorTickEnabled(bool bEnabled)
{
	CheckIsValid();
	SetActorTickEnabled(_this.Get(),bEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetLifeSpan(IntPtr _this);
/// <summary>Get the remaining lifespan of this actor. If zero is returned the actor lives forever.</summary>
public  float GetLifeSpan()
{
	CheckIsValid();
	float ___ret = GetLifeSpan(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLifeSpan(IntPtr _this,float InLifespan);
/// <summary>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.</summary>
public  void SetLifeSpan(float InLifespan)
{
	CheckIsValid();
	SetLifeSpan(_this.Get(),InLifespan);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetOverlappingComponents(IntPtr _this,out IntPtr[] OverlappingComponents);
/// <summary>Returns list of components this actor is overlapping.</summary>
public  void GetOverlappingComponents(out UPrimitiveComponent[] OverlappingComponents)
{
	CheckIsValid();
	IntPtr[] OverlappingComponents_temp;
	GetOverlappingComponents(_this.Get(),out OverlappingComponents_temp);
	OverlappingComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OverlappingComponents_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetOverlappingActors(IntPtr _this,out IntPtr[] OverlappingActors,IntPtr ClassFilter);
/// <summary>
/// Returns list of actors this actor is overlapping (any component overlapping any component). Does not return itself.
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
extern static int IsActorBeingDestroyed(IntPtr _this);
public  bool IsActorBeingDestroyed()
{
	CheckIsValid();
	int ___ret = IsActorBeingDestroyed(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MakeNoise(IntPtr _this,float Loudness,IntPtr NoiseInstigator,ref FVector NoiseLocation,float MaxRange,string Tag);
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
public  void MakeNoise(float Loudness=1.000000f,APawn NoiseInstigator=default(APawn),FVector NoiseLocation=default(FVector),float MaxRange=0.000000f,string Tag="None")
{
	CheckIsValid();
	MakeNoise(_this.Get(),Loudness,NoiseInstigator,ref NoiseLocation,MaxRange,Tag);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetGameTimeSinceCreation(IntPtr _this);
/// <summary>The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds.</summary>
public  float GetGameTimeSinceCreation()
{
	CheckIsValid();
	float ___ret = GetGameTimeSinceCreation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTickableWhenPaused(IntPtr _this,int bTickableWhenPaused);
/// <summary>Sets whether this actor can tick when paused.</summary>
public  void SetTickableWhenPaused(bool bTickableWhenPaused)
{
	CheckIsValid();
	SetTickableWhenPaused(_this.Get(),bTickableWhenPaused?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetTickableWhenPaused(IntPtr _this);
/// <summary>Gets whether this actor can tick when paused.</summary>
public  bool GetTickableWhenPaused()
{
	CheckIsValid();
	int ___ret = GetTickableWhenPaused(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveTickPrerequisiteComponent(IntPtr _this,IntPtr PrerequisiteComponent);
/// <summary>Remove tick dependency on PrerequisiteComponent.</summary>
public  void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
{
	CheckIsValid();
	RemoveTickPrerequisiteComponent(_this.Get(),PrerequisiteComponent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveTickPrerequisiteActor(IntPtr _this,IntPtr PrerequisiteActor);
/// <summary>Remove tick dependency on PrerequisiteActor.</summary>
public  void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
{
	CheckIsValid();
	RemoveTickPrerequisiteActor(_this.Get(),PrerequisiteActor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddTickPrerequisiteComponent(IntPtr _this,IntPtr PrerequisiteComponent);
/// <summary>Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired.</summary>
public  void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
{
	CheckIsValid();
	AddTickPrerequisiteComponent(_this.Get(),PrerequisiteComponent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddTickPrerequisiteActor(IntPtr _this,IntPtr PrerequisiteActor);
/// <summary>Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired.</summary>
public  void AddTickPrerequisiteActor(AActor PrerequisiteActor)
{
	CheckIsValid();
	AddTickPrerequisiteActor(_this.Get(),PrerequisiteActor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetActorTimeDilation(IntPtr _this);
/// <summary>
/// Get CustomTimeDilation - this can be used for input control or speed control for slomo.
/// We don't want to scale input globally because input can be used for UI, which do not care for TimeDilation.
/// </summary>
public  float GetActorTimeDilation()
{
	CheckIsValid();
	float ___ret = GetActorTimeDilation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ActorHasTag(IntPtr _this,string Tag);
/// <summary>See if this actor contains the supplied tag</summary>
public  bool ActorHasTag(string Tag)
{
	CheckIsValid();
	int ___ret = ActorHasTag(_this.Get(),Tag);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DetachFromActor(IntPtr _this,int LocationRule,int RotationRule,int ScaleRule);
/// <summary>
/// Detaches the RootComponent of this Actor from any SceneComponent it is currently attached to.
/// @param  LocationRule                         How to handle translation when detaching.
/// @param  RotationRule                         How to handle rotation when detaching.
/// @param  ScaleRule                            How to handle scale when detaching.
/// </summary>
public  void K2_DetachFromActor(EDetachmentRule LocationRule=EDetachmentRule.KeepRelative,EDetachmentRule RotationRule=EDetachmentRule.KeepRelative,EDetachmentRule ScaleRule=EDetachmentRule.KeepRelative)
{
	CheckIsValid();
	K2_DetachFromActor(_this.Get(),(int)LocationRule,(int)RotationRule,(int)ScaleRule);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DetachRootComponentFromParent(IntPtr _this,int bMaintainWorldPosition);
/// <summary>
/// Detaches the RootComponent of this Actor from any SceneComponent it is currently attached to.
///  @param bMaintainWorldTransform     If true, update the relative location/rotation of this component to keep its world position the same
/// </summary>
public  void DetachRootComponentFromParent(bool bMaintainWorldPosition=true)
{
	CheckIsValid();
	DetachRootComponentFromParent(_this.Get(),bMaintainWorldPosition?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AttachToActor(IntPtr _this,IntPtr ParentActor,string SocketName,int LocationRule,int RotationRule,int ScaleRule,int bWeldSimulatedBodies);
/// <summary>
/// Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered.
/// @param ParentActor                           Actor to attach this actor's RootComponent to
/// @param SocketName                            Socket name to attach to, if any
/// @param LocationRule                          How to handle translation when attaching.
/// @param RotationRule                          How to handle rotation when attaching.
/// @param ScaleRule                                     How to handle scale when attaching.
/// @param bWeldSimulatedBodies          Whether to weld together simulated physics bodies.
/// </summary>
public  void K2_AttachToActor(AActor ParentActor,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies)
{
	CheckIsValid();
	K2_AttachToActor(_this.Get(),ParentActor,SocketName,(int)LocationRule,(int)RotationRule,(int)ScaleRule,bWeldSimulatedBodies?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AttachRootComponentToActor(IntPtr _this,IntPtr InParentActor,string InSocketName,int AttachLocationType,int bWeldSimulatedBodies);
/// <summary>
/// Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered.
///  @param AttachLocationType   Type of attachment, AbsoluteWorld to keep its world position, RelativeOffset to keep the object's relative offset and SnapTo to snap to the new parent.
/// </summary>
public  void K2_AttachRootComponentToActor(AActor InParentActor,string InSocketName="None",EAttachLocation AttachLocationType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true)
{
	CheckIsValid();
	K2_AttachRootComponentToActor(_this.Get(),InParentActor,InSocketName,(int)AttachLocationType,bWeldSimulatedBodies?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AttachToComponent(IntPtr _this,IntPtr Parent,string SocketName,int LocationRule,int RotationRule,int ScaleRule,int bWeldSimulatedBodies);
/// <summary>
/// Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered.
/// @param  Parent                                       Parent to attach to.
/// @param  SocketName                           Optional socket to attach to on the parent.
/// @param  AttachmentRules                      How to handle transforms when attaching.
/// @param  bWeldSimulatedBodies         Whether to weld together simulated physics bodies.
/// </summary>
public  void K2_AttachToComponent(USceneComponent Parent,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies)
{
	CheckIsValid();
	K2_AttachToComponent(_this.Get(),Parent,SocketName,(int)LocationRule,(int)RotationRule,(int)ScaleRule,bWeldSimulatedBodies?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AttachRootComponentTo(IntPtr _this,IntPtr InParent,string InSocketName,int AttachLocationType,int bWeldSimulatedBodies);
/// <summary>
/// Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered.
///  @param AttachLocationType  Type of attachment, AbsoluteWorld to keep its world position, RelativeOffset to keep the object's relative offset and SnapTo to snap to the new parent.
/// </summary>
public  void K2_AttachRootComponentTo(USceneComponent InParent,string InSocketName="None",EAttachLocation AttachLocationType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true)
{
	CheckIsValid();
	K2_AttachRootComponentTo(_this.Get(),InParent,InSocketName,(int)AttachLocationType,bWeldSimulatedBodies?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddComponent(IntPtr _this,string TemplateName,int bManualAttachment,ref FTransform RelativeTransform,IntPtr ComponentTemplateContext);
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
public  UActorComponent AddComponent(string TemplateName,bool bManualAttachment,FTransform RelativeTransform,UObject ComponentTemplateContext)
{
	CheckIsValid();
	IntPtr ___ret = AddComponent(_this.Get(),TemplateName,bManualAttachment?1:0,ref RelativeTransform,ComponentTemplateContext);
	if(___ret==IntPtr.Zero) return null; UActorComponent ___ret2= new UActorComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasAuthority(IntPtr _this);
/// <summary>Returns whether this actor has network authority</summary>
public  bool HasAuthority()
{
	CheckIsValid();
	int ___ret = HasAuthority(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DestroyActor(IntPtr _this);
/// <summary>Destroy the actor</summary>
public  void K2_DestroyActor()
{
	CheckIsValid();
	K2_DestroyActor(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetActorEnableCollision(IntPtr _this);
/// <summary>Get current state of collision for the whole actor</summary>
public  bool GetActorEnableCollision()
{
	CheckIsValid();
	int ___ret = GetActorEnableCollision(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActorEnableCollision(IntPtr _this,int bNewActorEnableCollision);
/// <summary>Allows enabling/disabling collision for the whole actor</summary>
public  void SetActorEnableCollision(bool bNewActorEnableCollision)
{
	CheckIsValid();
	SetActorEnableCollision(_this.Get(),bNewActorEnableCollision?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActorHiddenInGame(IntPtr _this,int bNewHidden);
/// <summary>
/// Sets the actor to be hidden in the game
/// @param  bNewHidden      Whether or not to hide the actor and all its components
/// </summary>
public  void SetActorHiddenInGame(bool bNewHidden)
{
	CheckIsValid();
	SetActorHiddenInGame(_this.Get(),bNewHidden?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetActorRelativeScale3D(IntPtr _this);
/// <summary>Return the actor's relative scale 3d</summary>
public  FVector GetActorRelativeScale3D()
{
	CheckIsValid();
	FVector ___ret = GetActorRelativeScale3D(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActorRelativeScale3D(IntPtr _this,ref FVector NewRelativeScale);
/// <summary>
/// Set the actor's RootComponent to the specified relative scale 3d
/// @param NewRelativeScale      New scale to set the actor's RootComponent to
/// </summary>
public  void SetActorRelativeScale3D(FVector NewRelativeScale)
{
	CheckIsValid();
	SetActorRelativeScale3D(_this.Get(),ref NewRelativeScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetActorRelativeTransform(IntPtr _this,ref FTransform NewRelativeTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  void K2_SetActorRelativeTransform(FTransform NewRelativeTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetActorRelativeTransform(_this.Get(),ref NewRelativeTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetActorRelativeRotation(IntPtr _this,ref FRotator NewRelativeRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  void K2_SetActorRelativeRotation(FRotator NewRelativeRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetActorRelativeRotation(_this.Get(),ref NewRelativeRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetActorRelativeLocation(IntPtr _this,ref FVector NewRelativeLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  void K2_SetActorRelativeLocation(FVector NewRelativeLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetActorRelativeLocation(_this.Get(),ref NewRelativeLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddActorLocalTransform(IntPtr _this,ref FTransform NewTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  void K2_AddActorLocalTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddActorLocalTransform(_this.Get(),ref NewTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddActorLocalRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  void K2_AddActorLocalRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddActorLocalRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddActorLocalOffset(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  void K2_AddActorLocalOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddActorLocalOffset(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_SetActorTransform(IntPtr _this,ref FTransform NewTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  bool K2_SetActorTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	int ___ret = K2_SetActorTransform(_this.Get(),ref NewTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddActorWorldTransform(IntPtr _this,ref FTransform DeltaTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
/// <summary>Adds a delta to the transform of this actor in world space. Scale is unchanged.</summary>
public  void K2_AddActorWorldTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddActorWorldTransform(_this.Get(),ref DeltaTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddActorWorldRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  void K2_AddActorWorldRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddActorWorldRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddActorWorldOffset(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  void K2_AddActorWorldOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddActorWorldOffset(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetHorizontalDotProductTo(IntPtr _this,IntPtr OtherActor);
/// <summary>Returns the dot product from this Actor to OtherActor, ignoring Z. Returns -2.0 on failure. Returns 0.0 for coincidental actors.</summary>
public  float GetHorizontalDotProductTo(AActor OtherActor)
{
	CheckIsValid();
	float ___ret = GetHorizontalDotProductTo(_this.Get(),OtherActor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetDotProductTo(IntPtr _this,IntPtr OtherActor);
/// <summary>Returns the dot product from this Actor to OtherActor. Returns -2.0 on failure. Returns 0.0 for coincidental actors.</summary>
public  float GetDotProductTo(AActor OtherActor)
{
	CheckIsValid();
	float ___ret = GetDotProductTo(_this.Get(),OtherActor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetVerticalDistanceTo(IntPtr _this,IntPtr OtherActor);
/// <summary>Returns the distance from this Actor to OtherActor, ignoring XY.</summary>
public  float GetVerticalDistanceTo(AActor OtherActor)
{
	CheckIsValid();
	float ___ret = GetVerticalDistanceTo(_this.Get(),OtherActor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetHorizontalDistanceTo(IntPtr _this,IntPtr OtherActor);
/// <summary>Returns the distance from this Actor to OtherActor, ignoring Z.</summary>
public  float GetHorizontalDistanceTo(AActor OtherActor)
{
	CheckIsValid();
	float ___ret = GetHorizontalDistanceTo(_this.Get(),OtherActor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetSquaredDistanceTo(IntPtr _this,IntPtr OtherActor);
/// <summary>Returns the squared distance from this Actor to OtherActor.</summary>
public  float GetSquaredDistanceTo(AActor OtherActor)
{
	CheckIsValid();
	float ___ret = GetSquaredDistanceTo(_this.Get(),OtherActor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetDistanceTo(IntPtr _this,IntPtr OtherActor);
/// <summary>Returns the distance from this Actor to OtherActor.</summary>
public  float GetDistanceTo(AActor OtherActor)
{
	CheckIsValid();
	float ___ret = GetDistanceTo(_this.Get(),OtherActor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetActorScale3D(IntPtr _this);
/// <summary>Returns the Actor's world-space scale.</summary>
public  FVector GetActorScale3D()
{
	CheckIsValid();
	FVector ___ret = GetActorScale3D(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActorScale3D(IntPtr _this,ref FVector NewScale3D);
/// <summary>Set the Actor's world-space scale.</summary>
public  void SetActorScale3D(FVector NewScale3D)
{
	CheckIsValid();
	SetActorScale3D(_this.Get(),ref NewScale3D);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_SetActorLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  bool K2_SetActorLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	int ___ret = K2_SetActorLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_SetActorRotation(IntPtr _this,ref FRotator NewRotation,int bTeleportPhysics);
/// <summary>
/// Set the Actor's rotation instantly to the specified rotation.
/// @param       NewRotation     The new rotation for the Actor.
/// @param       bTeleportPhysics Whether we teleport the physics state (if physics collision is enabled for this object).
///                      If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
///                      If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
/// @return      Whether the rotation was successfully set.
/// </summary>
public  bool K2_SetActorRotation(FRotator NewRotation,bool bTeleportPhysics)
{
	CheckIsValid();
	int ___ret = K2_SetActorRotation(_this.Get(),ref NewRotation,bTeleportPhysics?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetVelocity(IntPtr _this);
/// <summary>Returns velocity (in cm/s (Unreal Units/second) of the rootcomponent if it is either using physics or has an associated MovementComponent</summary>
public  FVector GetVelocity()
{
	CheckIsValid();
	FVector ___ret = GetVelocity(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr K2_GetRootComponent(IntPtr _this);
/// <summary>Returns the RootComponent of this Actor</summary>
public  USceneComponent K2_GetRootComponent()
{
	CheckIsValid();
	IntPtr ___ret = K2_GetRootComponent(_this.Get());
	if(___ret==IntPtr.Zero) return null; USceneComponent ___ret2= new USceneComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetActorBounds(IntPtr _this,int bOnlyCollidingComponents,out FVector Origin,out FVector BoxExtent);
/// <summary>
/// Returns the bounding box of all components that make up this Actor.
/// @param       bOnlyCollidingComponents        If true, will only return the bounding box for components with collision enabled.
/// </summary>
public  void GetActorBounds(bool bOnlyCollidingComponents,out FVector Origin,out FVector BoxExtent)
{
	CheckIsValid();
	GetActorBounds(_this.Get(),bOnlyCollidingComponents?1:0,out Origin,out BoxExtent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetActorRightVector(IntPtr _this);
/// <summary>Get the right (Y) vector (length 1.0) from this Actor, in world space.</summary>
public  FVector GetActorRightVector()
{
	CheckIsValid();
	FVector ___ret = GetActorRightVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetActorUpVector(IntPtr _this);
/// <summary>Get the up (Z) vector (length 1.0) from this Actor, in world space.</summary>
public  FVector GetActorUpVector()
{
	CheckIsValid();
	FVector ___ret = GetActorUpVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetActorForwardVector(IntPtr _this);
/// <summary>Get the forward (X) vector (length 1.0) from this Actor, in world space.</summary>
public  FVector GetActorForwardVector()
{
	CheckIsValid();
	FVector ___ret = GetActorForwardVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator K2_GetActorRotation(IntPtr _this);
/// <summary>Returns rotation of the RootComponent of this Actor.</summary>
public  FRotator K2_GetActorRotation()
{
	CheckIsValid();
	FRotator ___ret = K2_GetActorRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_SetActorLocation(IntPtr _this,ref FVector NewLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
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
public  bool K2_SetActorLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	int ___ret = K2_SetActorLocation(_this.Get(),ref NewLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector K2_GetActorLocation(IntPtr _this);
/// <summary>Returns the location of the RootComponent of this Actor</summary>
public  FVector K2_GetActorLocation()
{
	CheckIsValid();
	FVector ___ret = K2_GetActorLocation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetTransform(IntPtr _this);
/// <summary>
/// Get the actor-to-world transform.
/// @return The transform that transforms from actor space to world space.
/// </summary>
public  FTransform GetTransform()
{
	CheckIsValid();
	FTransform ___ret = GetTransform(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetInstigatorController(IntPtr _this);
/// <summary>Returns the instigator's controller for this actor, or NULL if there is none.</summary>
public  AController GetInstigatorController()
{
	CheckIsValid();
	IntPtr ___ret = GetInstigatorController(_this.Get());
	if(___ret==IntPtr.Zero) return null; AController ___ret2= new AController(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetInstigator(IntPtr _this);
/// <summary>Returns the instigator for this actor, or NULL if there is none.</summary>
public  APawn GetInstigator()
{
	CheckIsValid();
	IntPtr ___ret = GetInstigator(_this.Get());
	if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetInputVectorAxisValue(IntPtr _this,ref FKey InputAxisKey);
/// <summary>Gets the value of the input axis key if input is enabled for this actor.</summary>
public  FVector GetInputVectorAxisValue(FKey InputAxisKey)
{
	CheckIsValid();
	FVector ___ret = GetInputVectorAxisValue(_this.Get(),ref InputAxisKey);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInputAxisKeyValue(IntPtr _this,ref FKey InputAxisKey);
/// <summary>Gets the value of the input axis key if input is enabled for this actor.</summary>
public  float GetInputAxisKeyValue(FKey InputAxisKey)
{
	CheckIsValid();
	float ___ret = GetInputAxisKeyValue(_this.Get(),ref InputAxisKey);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInputAxisValue(IntPtr _this,string InputAxisName);
/// <summary>Gets the value of the input axis if input is enabled for this actor.</summary>
public  float GetInputAxisValue(string InputAxisName)
{
	CheckIsValid();
	float ___ret = GetInputAxisValue(_this.Get(),InputAxisName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DisableInput(IntPtr _this,IntPtr PlayerController);
/// <summary>
/// Removes this actor from the stack of input being handled by a PlayerController.
/// @param PlayerController The PlayerController whose input events we no longer want to receive. If null, this actor will stop receiving input from all PlayerControllers.
/// </summary>
public  void DisableInput(APlayerController PlayerController)
{
	CheckIsValid();
	DisableInput(_this.Get(),PlayerController);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableInput(IntPtr _this,IntPtr PlayerController);
/// <summary>
/// Pushes this actor on to the stack of input being handled by a PlayerController.
/// @param PlayerController The PlayerController whose input events we want to receive.
/// </summary>
public  void EnableInput(APlayerController PlayerController)
{
	CheckIsValid();
	EnableInput(_this.Get(),PlayerController);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_Instigator(IntPtr _this);
/// <summary>Called on clients when Instigatolr is replicated.</summary>
public  void OnRep_Instigator()
{
	CheckIsValid();
	OnRep_Instigator(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_AttachmentReplication(IntPtr _this);
/// <summary>Called on client when updated AttachmentReplication value is received for this actor.</summary>
public  void OnRep_AttachmentReplication()
{
	CheckIsValid();
	OnRep_AttachmentReplication(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetRemoteRole(IntPtr _this);
/// <summary>Returns how much control the remote machine has over this actor.</summary>
public  ENetRole GetRemoteRole()
{
	CheckIsValid();
	int ___ret = GetRemoteRole(_this.Get());
	return (ENetRole)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetReplicateMovement(IntPtr _this,int bInReplicateMovement);
/// <summary>
/// Set whether this actor's movement replicates to network clients.
/// @param bInReplicateMovement Whether this Actor's movement replicates to clients.
/// </summary>
public  void SetReplicateMovement(bool bInReplicateMovement)
{
	CheckIsValid();
	SetReplicateMovement(_this.Get(),bInReplicateMovement?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetReplicates(IntPtr _this,int bInReplicates);
/// <summary>
/// Set whether this actor replicates to network clients. When this actor is spawned on the server it will be sent to clients as well.
/// Properties flagged for replication will update on clients if they change on the server.
/// Internally changes the RemoteRole property and handles the cases where the actor needs to be added to the network actor list.
/// @param bInReplicates Whether this Actor replicates to network clients.
/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication/
/// </summary>
public  void SetReplicates(bool bInReplicates)
{
	CheckIsValid();
	SetReplicates(_this.Get(),bInReplicates?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void TearOff(IntPtr _this);
/// <summary>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.</summary>
public  void TearOff()
{
	CheckIsValid();
	TearOff(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ReplicateMovement(IntPtr _this);
/// <summary>Called on client when updated bReplicateMovement value is received for this actor.</summary>
public  void OnRep_ReplicateMovement()
{
	CheckIsValid();
	OnRep_ReplicateMovement(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
