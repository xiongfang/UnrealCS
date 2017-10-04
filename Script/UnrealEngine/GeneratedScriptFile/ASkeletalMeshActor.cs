using System;
namespace UnrealEngine
{
	public partial class ASkeletalMeshActor:AActor
	{
		public extern virtual void OnRep_ReplicatedMaterial1();
		public extern virtual void OnRep_ReplicatedMaterial0();
		public extern virtual void OnRep_ReplicatedPhysAsset();
		/// <summary>Replication Notification Callbacks</summary>
		public extern virtual void OnRep_ReplicatedMesh();
		/// <summary>Whether or not this actor should respond to anim notifies - CURRENTLY ONLY AFFECTS PlayParticleEffect NOTIFIES*</summary>
		public bool bShouldDoAnimNotifies;
		
		public bool bWakeOnLevelStart;
		
		public USkeletalMeshComponent SkeletalMeshComponent;
		
		/// <summary>Used to replicate mesh to clients</summary>
		public USkeletalMesh ReplicatedMesh;
		
		/// <summary>Used to replicate physics asset to clients</summary>
		public UPhysicsAsset ReplicatedPhysAsset;
		
		/// <summary>used to replicate the material in index 0</summary>
		public UMaterialInterface ReplicatedMaterial0;
		
		public UMaterialInterface ReplicatedMaterial1;
		
		
	}
	
}
