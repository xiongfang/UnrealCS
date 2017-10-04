using System;
namespace UnrealEngine
{
	public partial class UStaticMeshSocket:UObject
	{
		/// <summary>
		/// Defines a named attachment location on the UStaticMesh.
		/// These are set up in editor and used as a shortcut instead of specifying
		/// everything explicitly to AttachComponent in the StaticMeshComponent.
		/// The Outer of a StaticMeshSocket should always be the UStaticMesh.
		/// </summary>
		public FName SocketName;
		
		public FVector RelativeLocation;
		
		public FRotator RelativeRotation;
		
		public FVector RelativeScale;
		
		public FString Tag;
		
		public UStaticMesh PreviewStaticMesh;
		
		
	}
	
}
