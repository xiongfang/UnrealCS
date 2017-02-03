using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPoseableMeshComponent:USkinnedMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CopyPoseFromSkeletalComponent(IntPtr _this,IntPtr InComponentToCopy);
public  void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy)
{
	CheckIsValid();
	CopyPoseFromSkeletalComponent(_this.Get(),InComponentToCopy);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetBoneTransformByName(IntPtr _this,string BoneName);
public  void ResetBoneTransformByName(string BoneName)
{
	CheckIsValid();
	ResetBoneTransformByName(_this.Get(),BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetBoneScaleByName(IntPtr _this,string BoneName,int BoneSpace);
public  FVector GetBoneScaleByName(string BoneName,EBoneSpaces BoneSpace)
{
	CheckIsValid();
	FVector ___ret = GetBoneScaleByName(_this.Get(),BoneName,(int)BoneSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetBoneRotationByName(IntPtr _this,string BoneName,int BoneSpace);
public  FRotator GetBoneRotationByName(string BoneName,EBoneSpaces BoneSpace)
{
	CheckIsValid();
	FRotator ___ret = GetBoneRotationByName(_this.Get(),BoneName,(int)BoneSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetBoneLocationByName(IntPtr _this,string BoneName,int BoneSpace);
public  FVector GetBoneLocationByName(string BoneName,EBoneSpaces BoneSpace)
{
	CheckIsValid();
	FVector ___ret = GetBoneLocationByName(_this.Get(),BoneName,(int)BoneSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetBoneTransformByName(IntPtr _this,string BoneName,int BoneSpace);
public  FTransform GetBoneTransformByName(string BoneName,EBoneSpaces BoneSpace)
{
	CheckIsValid();
	FTransform ___ret = GetBoneTransformByName(_this.Get(),BoneName,(int)BoneSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoneScaleByName(IntPtr _this,string BoneName,ref FVector InScale3D,int BoneSpace);
public  void SetBoneScaleByName(string BoneName,FVector InScale3D,EBoneSpaces BoneSpace)
{
	CheckIsValid();
	SetBoneScaleByName(_this.Get(),BoneName,ref InScale3D,(int)BoneSpace);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoneRotationByName(IntPtr _this,string BoneName,ref FRotator InRotation,int BoneSpace);
public  void SetBoneRotationByName(string BoneName,FRotator InRotation,EBoneSpaces BoneSpace)
{
	CheckIsValid();
	SetBoneRotationByName(_this.Get(),BoneName,ref InRotation,(int)BoneSpace);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoneLocationByName(IntPtr _this,string BoneName,ref FVector InLocation,int BoneSpace);
public  void SetBoneLocationByName(string BoneName,FVector InLocation,EBoneSpaces BoneSpace)
{
	CheckIsValid();
	SetBoneLocationByName(_this.Get(),BoneName,ref InLocation,(int)BoneSpace);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoneTransformByName(IntPtr _this,string BoneName,ref FTransform InTransform,int BoneSpace);
public  void SetBoneTransformByName(string BoneName,FTransform InTransform,EBoneSpaces BoneSpace)
{
	CheckIsValid();
	SetBoneTransformByName(_this.Get(),BoneName,ref InTransform,(int)BoneSpace);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
