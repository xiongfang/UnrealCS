using System;
namespace UnrealEngine
{
	public partial class UPoseableMeshComponent:USkinnedMeshComponent
	{
		public extern void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy);
		public extern void ResetBoneTransformByName(FName BoneName);
		public extern FVector GetBoneScaleByName(FName BoneName,EBoneSpaces BoneSpace);
		public extern FRotator GetBoneRotationByName(FName BoneName,EBoneSpaces BoneSpace);
		public extern FVector GetBoneLocationByName(FName BoneName,EBoneSpaces BoneSpace);
		public extern FTransform GetBoneTransformByName(FName BoneName,EBoneSpaces BoneSpace);
		public extern void SetBoneScaleByName(FName BoneName,FVector InScale3D,EBoneSpaces BoneSpace);
		public extern void SetBoneRotationByName(FName BoneName,FRotator InRotation,EBoneSpaces BoneSpace);
		public extern void SetBoneLocationByName(FName BoneName,FVector InLocation,EBoneSpaces BoneSpace);
		public extern void SetBoneTransformByName(FName BoneName,FTransform InTransform,EBoneSpaces BoneSpace);
		
	}
	
}
