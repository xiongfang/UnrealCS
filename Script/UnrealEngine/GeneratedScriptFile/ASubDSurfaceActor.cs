using System;
namespace UnrealEngine
{
	public partial class ASubDSurfaceActor:AActor
	{
		/// <summary>Component to render the actor, used GetSubDSurface() to access</summary>
		public USubDSurfaceComponent SubDSurface;
		
		/// <summary>later this all will be done by USubDSurfaceComponent</summary>
		public UStaticMeshComponent DisplayMeshComponent;
		
		/// <summary>Reference to the billboard component</summary>
		public UBillboardComponent SpriteComponent;
		
		
	}
	
}
