using System;
namespace UnrealEngine
{
	/// <summary>Handles attachment replication to clients. Movement replication will not happen while AttachParent is non-nullptr</summary>
	public partial struct FRepAttachment
	{
		public AActor AttachParent;
		public FVector_NetQuantize100 LocationOffset;
		public FVector_NetQuantize100 RelativeScale3D;
		public FRotator RotationOffset;
		public FName AttachSocket;
		public USceneComponent AttachComponent;
		
	}
	
}
