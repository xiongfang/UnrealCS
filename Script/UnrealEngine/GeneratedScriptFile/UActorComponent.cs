using System;
namespace UnrealEngine
{
	public partial class UActorComponent:UObject
	{
		/// <summary>Remove tick dependency on PrerequisiteComponent.</summary>
		public extern virtual void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent);
		/// <summary>Remove tick dependency on PrerequisiteActor.</summary>
		public extern virtual void RemoveTickPrerequisiteActor(AActor PrerequisiteActor);
		/// <summary>Make this component tick after PrerequisiteComponent.</summary>
		public extern virtual void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent);
		/// <summary>Make this component tick after PrerequisiteActor</summary>
		public extern virtual void AddTickPrerequisiteActor(AActor PrerequisiteActor);
		/// <summary>Changes the ticking group for this component</summary>
		public extern void SetTickGroup(ETickingGroup NewTickGroup);
		/// <summary>Unregister and mark for pending kill a component.  This may not be used to destroy a component is owned by an actor other than the one calling the function.</summary>
		public extern void K2_DestroyComponent(UObject Object);
		/// <summary>Returns whether this component has tick enabled or not</summary>
		public extern float GetComponentTickInterval();
		/// <summary>
		/// Sets the tick interval for this component's primary tick function. Does not enable the tick interval. Takes effect on next tick.
		/// @param TickInterval   The duration between ticks for this component's primary tick function
		/// </summary>
		public extern void SetComponentTickInterval(float TickInterval);
		/// <summary>Returns whether this component has tick enabled or not</summary>
		public extern bool IsComponentTickEnabled();
		/// <summary>
		/// Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered
		/// @param       bEnabled - Whether it should be enabled or not
		/// </summary>
		public extern virtual void SetComponentTickEnabled(bool bEnabled);
		/// <summary>Enable or disable replication. This is the equivalent of RemoteRole for actors (only a bool is required for components)</summary>
		public extern void SetIsReplicated(bool ShouldReplicate);
		/// <summary>Sets whether this component can tick when paused.</summary>
		public extern void SetTickableWhenPaused(bool bTickableWhenPaused);
		/// <summary>
		/// Sets whether the component should be auto activate or not. Only safe during construction scripts.
		/// @param bNewAutoActivate - The new auto activate state of the component
		/// </summary>
		public extern virtual void SetAutoActivate(bool bNewAutoActivate);
		/// <summary>
		/// Returns whether the component is active or not
		/// @return - The active state of the component.
		/// </summary>
		public extern virtual bool IsActive();
		/// <summary>Toggles the active state of the component</summary>
		public extern virtual void ToggleActive();
		/// <summary>
		/// Sets whether the component is active or not
		/// @param bNewActive - The new active state of the component
		/// </summary>
		public extern virtual void SetActive(bool bNewActive,bool bReset=false);
		/// <summary>Deactivates the SceneComponent.</summary>
		public extern virtual void Deactivate();
		/// <summary>
		/// Activates the SceneComponent
		/// @param bReset - The value to assign to HiddenGame.
		/// </summary>
		public extern virtual void Activate(bool bReset=false);
		/// <summary>See if this component contains the supplied tag</summary>
		public extern bool ComponentHasTag(FName Tag);
		/// <summary>Follow the Outer chain to get the  AActor  that 'Owns' this component</summary>
		public extern AActor GetOwner();
		public extern void OnRep_IsActive();
		/// <summary>Returns whether the component is in the process of being destroyed.</summary>
		public extern bool IsBeingDestroyed();
		/// <summary>Main tick function for the Actor</summary>
		public FActorComponentTickFunction PrimaryComponentTick;
		
		/// <summary>Is this component currently replicating? Should the network code consider it for replication? Owning Actor must be replicating first!</summary>
		public bool bReplicates;
		
		/// <summary>Is this component safe to ID over the network by name?</summary>
		public bool bNetAddressable;
		
		/// <summary>True if this component was created by a construction script, and will be destroyed by DestroyConstructedComponents</summary>
		public bool bCreatedByConstructionScript;
		
		/// <summary>True if this component was created as an instance component</summary>
		public bool bInstanceComponent;
		
		/// <summary>Whether the component is activated at creation or must be explicitly activated.</summary>
		public bool bAutoActivate;
		
		/// <summary>Whether the component is currently active.</summary>
		public bool bIsActive;
		
		public bool bEditableWhenInherited;
		
		/// <summary>Whether this component can potentially influence navigation</summary>
		public bool bCanEverAffectNavigation;
		
		/// <summary>If true, the component will be excluded from non-editor builds</summary>
		public bool bIsEditorOnly;
		
		
	}
	
}
