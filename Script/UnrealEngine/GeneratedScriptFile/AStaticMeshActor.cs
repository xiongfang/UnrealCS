using System;
namespace UnrealEngine
{
	public partial class AStaticMeshActor:AActor
	{
		public UStaticMeshComponent StaticMeshComponent;
		
		/// <summary>This static mesh should replicate movement. Automatically sets the RemoteRole and bReplicateMovement flags. Meant to be edited on placed actors (those other two properties are not)</summary>
		public bool bStaticMeshReplicateMovement;
		
		
	}
	
}
