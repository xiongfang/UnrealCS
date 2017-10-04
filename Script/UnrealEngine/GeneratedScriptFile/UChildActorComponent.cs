using System;
namespace UnrealEngine
{
	public partial class UChildActorComponent:USceneComponent
	{
		public extern void SetChildActorClass(TSubclassOf<AActor>  InClass);
		/// <summary>The class of Actor to spawn</summary>
		public TSubclassOf<AActor>  ChildActorClass;
		
		/// <summary>The actor that we spawned and own</summary>
		public AActor ChildActor;
		
		/// <summary>Property to point to the template child actor for details panel purposes</summary>
		public AActor ChildActorTemplate;
		
		
	}
	
}
