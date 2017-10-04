using System;
namespace UnrealEngine
{
	public partial class USceneCaptureComponent:USceneComponent
	{
		/// <summary>Clears the Show Only list.</summary>
		public extern void ClearShowOnlyComponents(UPrimitiveComponent InComponent);
		/// <summary>Removes a actor's components from the Show Only list.</summary>
		public extern void RemoveShowOnlyActorComponents(AActor InActor);
		/// <summary>Removes a component from the Show Only list.</summary>
		public extern void RemoveShowOnlyComponent(UPrimitiveComponent InComponent);
		/// <summary>Adds all primitive components in the actor to our list of show-only components.</summary>
		public extern void ShowOnlyActorComponents(AActor InActor);
		/// <summary>Adds the component to our list of show-only components.</summary>
		public extern void ShowOnlyComponent(UPrimitiveComponent InComponent);
		/// <summary>Adds all primitive components in the actor to our list of hidden components.</summary>
		public extern void HideActorComponents(AActor InActor);
		/// <summary>Adds the component to our list of hidden components.</summary>
		public extern void HideComponent(UPrimitiveComponent InComponent);
		/// <summary>Whether to update the capture's contents every frame.  If disabled, the component will render once on load and then only when moved.</summary>
		public bool bCaptureEveryFrame;
		
		/// <summary>Whether to update the capture's contents on movement.  Disable if you are going to capture manually from blueprint.</summary>
		public bool bCaptureOnMovement;
		
		/// <summary>if > 0, sets a maximum render distance override.  Can be used to cull distant objects from a reflection if the reflecting plane is in an enclosed area like a hallway or room</summary>
		public float MaxViewDistanceOverride;
		
		
	}
	
}
