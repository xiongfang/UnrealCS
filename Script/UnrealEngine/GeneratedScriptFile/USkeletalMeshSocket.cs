using System;
namespace UnrealEngine
{
	public partial class USkeletalMeshSocket:UObject
	{
		/// <summary>Sets BoneName, RelativeLocation and RelativeRotation based on closest bone to WorldLocation and WorldNormal</summary>
		public extern void InitializeSocketFromLocation(USkeletalMeshComponent SkelComp,FVector WorldLocation,FVector WorldNormal);
		public extern FVector GetSocketLocation(USkeletalMeshComponent SkelComp);
		/// <summary>
		/// Defines a named attachment location on the USkeletalMesh.
		/// These are set up in editor and used as a shortcut instead of specifying
		/// everything explicitly to AttachComponent in the SkeletalMeshComponent.
		/// The Outer of a SkeletalMeshSocket should always be the USkeletalMesh.
		/// </summary>
		public FName SocketName;
		
		public FName BoneName;
		
		public FVector RelativeLocation;
		
		public FRotator RelativeRotation;
		
		public FVector RelativeScale;
		
		/// <summary>
		/// If true then the hierarchy of bones this socket is attached to will always be
		///           evaluated, even if it had previously been removed due to the current lod setting
		/// </summary>
		public bool bForceAlwaysAnimated;
		
		
	}
	
}
