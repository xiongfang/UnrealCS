#pragma once

namespace UnrealEngine
{
	class _UPoseableMeshComponent
	{
		static void CopyPoseFromSkeletalComponent(UPoseableMeshComponent* _this,USkeletalMeshComponent* InComponentToCopy)
		{
			_this->CopyPoseFromSkeletalComponent(InComponentToCopy);
			
		}
		static void ResetBoneTransformByName(UPoseableMeshComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->ResetBoneTransformByName(BoneName_temp);
			
		}
		static FVector GetBoneScaleByName(UPoseableMeshComponent* _this,MonoString* BoneName,int32 BoneSpace)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FVector ___ret = _this->GetBoneScaleByName(BoneName_temp,(TEnumAsByte<EBoneSpaces::Type>)BoneSpace);
			return ___ret;
			
		}
		static FRotator GetBoneRotationByName(UPoseableMeshComponent* _this,MonoString* BoneName,int32 BoneSpace)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FRotator ___ret = _this->GetBoneRotationByName(BoneName_temp,(TEnumAsByte<EBoneSpaces::Type>)BoneSpace);
			return ___ret;
			
		}
		static FVector GetBoneLocationByName(UPoseableMeshComponent* _this,MonoString* BoneName,int32 BoneSpace)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FVector ___ret = _this->GetBoneLocationByName(BoneName_temp,(TEnumAsByte<EBoneSpaces::Type>)BoneSpace);
			return ___ret;
			
		}
		static FTransform GetBoneTransformByName(UPoseableMeshComponent* _this,MonoString* BoneName,int32 BoneSpace)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FTransform ___ret = _this->GetBoneTransformByName(BoneName_temp,(TEnumAsByte<EBoneSpaces::Type>)BoneSpace);
			return ___ret;
			
		}
		static void SetBoneScaleByName(UPoseableMeshComponent* _this,MonoString* BoneName,FVector* InScale3D,int32 BoneSpace)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetBoneScaleByName(BoneName_temp,*InScale3D,(TEnumAsByte<EBoneSpaces::Type>)BoneSpace);
			
		}
		static void SetBoneRotationByName(UPoseableMeshComponent* _this,MonoString* BoneName,FRotator* InRotation,int32 BoneSpace)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetBoneRotationByName(BoneName_temp,*InRotation,(TEnumAsByte<EBoneSpaces::Type>)BoneSpace);
			
		}
		static void SetBoneLocationByName(UPoseableMeshComponent* _this,MonoString* BoneName,FVector* InLocation,int32 BoneSpace)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetBoneLocationByName(BoneName_temp,*InLocation,(TEnumAsByte<EBoneSpaces::Type>)BoneSpace);
			
		}
		static void SetBoneTransformByName(UPoseableMeshComponent* _this,MonoString* BoneName,FTransform* InTransform,int32 BoneSpace)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetBoneTransformByName(BoneName_temp,*InTransform,(TEnumAsByte<EBoneSpaces::Type>)BoneSpace);
			
		}
		static UClass* StaticClass(){return UPoseableMeshComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::CopyPoseFromSkeletalComponent",(const void*)CopyPoseFromSkeletalComponent);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::ResetBoneTransformByName",(const void*)ResetBoneTransformByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::GetBoneScaleByName",(const void*)GetBoneScaleByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::GetBoneRotationByName",(const void*)GetBoneRotationByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::GetBoneLocationByName",(const void*)GetBoneLocationByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::GetBoneTransformByName",(const void*)GetBoneTransformByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::SetBoneScaleByName",(const void*)SetBoneScaleByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::SetBoneRotationByName",(const void*)SetBoneRotationByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::SetBoneLocationByName",(const void*)SetBoneLocationByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::SetBoneTransformByName",(const void*)SetBoneTransformByName);
			mono_add_internal_call("UnrealEngine.UPoseableMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
