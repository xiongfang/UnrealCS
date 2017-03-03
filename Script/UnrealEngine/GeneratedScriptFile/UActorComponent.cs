using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UActorComponent:UObject 
{
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
/// <summary>Make this component tick after PrerequisiteComponent.</summary>
public  void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
{
	CheckIsValid();
	AddTickPrerequisiteComponent(_this.Get(),PrerequisiteComponent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddTickPrerequisiteActor(IntPtr _this,IntPtr PrerequisiteActor);
/// <summary>Make this component tick after PrerequisiteActor</summary>
public  void AddTickPrerequisiteActor(AActor PrerequisiteActor)
{
	CheckIsValid();
	AddTickPrerequisiteActor(_this.Get(),PrerequisiteActor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTickGroup(IntPtr _this,int NewTickGroup);
/// <summary>Changes the ticking group for this component</summary>
public  void SetTickGroup(ETickingGroup NewTickGroup)
{
	CheckIsValid();
	SetTickGroup(_this.Get(),(int)NewTickGroup);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DestroyComponent(IntPtr _this,IntPtr Object);
/// <summary>Unregister and mark for pending kill a component.  This may not be used to destroy a component is owned by an actor other than the one calling the function.</summary>
public  void K2_DestroyComponent(UObject Object)
{
	CheckIsValid();
	K2_DestroyComponent(_this.Get(),Object);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetComponentTickInterval(IntPtr _this);
/// <summary>Returns whether this component has tick enabled or not</summary>
public  float GetComponentTickInterval()
{
	CheckIsValid();
	float ___ret = GetComponentTickInterval(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetComponentTickInterval(IntPtr _this,float TickInterval);
/// <summary>
/// Sets the tick interval for this component's primary tick function. Does not enable the tick interval. Takes effect on next tick.
/// @param TickInterval   The duration between ticks for this component's primary tick function
/// </summary>
public  void SetComponentTickInterval(float TickInterval)
{
	CheckIsValid();
	SetComponentTickInterval(_this.Get(),TickInterval);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsComponentTickEnabled(IntPtr _this);
/// <summary>Returns whether this component has tick enabled or not</summary>
public  bool IsComponentTickEnabled()
{
	CheckIsValid();
	int ___ret = IsComponentTickEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetComponentTickEnabled(IntPtr _this,int bEnabled);
/// <summary>
/// Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered
/// @param       bEnabled - Whether it should be enabled or not
/// </summary>
public  void SetComponentTickEnabled(bool bEnabled)
{
	CheckIsValid();
	SetComponentTickEnabled(_this.Get(),bEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIsReplicated(IntPtr _this,int ShouldReplicate);
/// <summary>Enable or disable replication. This is the equivalent of RemoteRole for actors (only a bool is required for components)</summary>
public  void SetIsReplicated(bool ShouldReplicate)
{
	CheckIsValid();
	SetIsReplicated(_this.Get(),ShouldReplicate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTickableWhenPaused(IntPtr _this,int bTickableWhenPaused);
/// <summary>Sets whether this component can tick when paused.</summary>
public  void SetTickableWhenPaused(bool bTickableWhenPaused)
{
	CheckIsValid();
	SetTickableWhenPaused(_this.Get(),bTickableWhenPaused?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAutoActivate(IntPtr _this,int bNewAutoActivate);
/// <summary>
/// Sets whether the component should be auto activate or not. Only safe during construction scripts.
/// @param bNewAutoActivate - The new auto activate state of the component
/// </summary>
public  void SetAutoActivate(bool bNewAutoActivate)
{
	CheckIsValid();
	SetAutoActivate(_this.Get(),bNewAutoActivate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsActive(IntPtr _this);
/// <summary>
/// Returns whether the component is active or not
/// @return - The active state of the component.
/// </summary>
public  bool IsActive()
{
	CheckIsValid();
	int ___ret = IsActive(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleActive(IntPtr _this);
/// <summary>Toggles the active state of the component</summary>
public  void ToggleActive()
{
	CheckIsValid();
	ToggleActive(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActive(IntPtr _this,int bNewActive,int bReset);
/// <summary>
/// Sets whether the component is active or not
/// @param bNewActive - The new active state of the component
/// </summary>
public  void SetActive(bool bNewActive,bool bReset=false)
{
	CheckIsValid();
	SetActive(_this.Get(),bNewActive?1:0,bReset?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Deactivate(IntPtr _this);
/// <summary>Deactivates the SceneComponent.</summary>
public  void Deactivate()
{
	CheckIsValid();
	Deactivate(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Activate(IntPtr _this,int bReset);
/// <summary>
/// Activates the SceneComponent
/// @param bReset - The value to assign to HiddenGame.
/// </summary>
public  void Activate(bool bReset=false)
{
	CheckIsValid();
	Activate(_this.Get(),bReset?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ComponentHasTag(IntPtr _this,string Tag);
/// <summary>See if this component contains the supplied tag</summary>
public  bool ComponentHasTag(string Tag)
{
	CheckIsValid();
	int ___ret = ComponentHasTag(_this.Get(),Tag);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwner(IntPtr _this);
/// <summary>Follow the Outer chain to get the  AActor  that 'Owns' this component</summary>
public  AActor GetOwner()
{
	CheckIsValid();
	IntPtr ___ret = GetOwner(_this.Get());
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_IsActive(IntPtr _this);
public  void OnRep_IsActive()
{
	CheckIsValid();
	OnRep_IsActive(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsBeingDestroyed(IntPtr _this);
/// <summary>Returns whether the component is in the process of being destroyed.</summary>
public  bool IsBeingDestroyed()
{
	CheckIsValid();
	int ___ret = IsBeingDestroyed(_this.Get());
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
