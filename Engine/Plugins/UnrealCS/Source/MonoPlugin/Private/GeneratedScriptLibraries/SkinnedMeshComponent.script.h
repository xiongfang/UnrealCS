#pragma once

namespace UnrealEngine
{
	class _USkinnedMeshComponent
	{
		static int32 IsBoneHiddenByName(USkinnedMeshComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			bool ___ret = _this->IsBoneHiddenByName(BoneName_temp);
			return ___ret?1:0;
			
		}
		static void UnHideBoneByName(USkinnedMeshComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->UnHideBoneByName(BoneName_temp);
			
		}
		static void HideBoneByName(USkinnedMeshComponent* _this,MonoString* BoneName,int32 PhysBodyOption)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->HideBoneByName(BoneName_temp,(TEnumAsByte<EPhysBodyOp>)PhysBodyOption);
			
		}
		static MonoString* FindClosestBone_K2(USkinnedMeshComponent* _this,FVector* TestLocation,FVector* BoneLocation,float IgnoreScale,int32 bRequirePhysicsAsset)
		{
			FName ___ret = _this->FindClosestBone_K2(*TestLocation,*BoneLocation,IgnoreScale,bRequirePhysicsAsset>0?true:false);
			return FNameToMonoString(___ret);
			
		}
		static void TransformFromBoneSpace(USkinnedMeshComponent* _this,MonoString* BoneName,FVector* InPosition,FRotator* InRotation,FVector* OutPosition,FRotator* OutRotation)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->TransformFromBoneSpace(BoneName_temp,*InPosition,*InRotation,*OutPosition,*OutRotation);
			
		}
		static void TransformToBoneSpace(USkinnedMeshComponent* _this,MonoString* BoneName,FVector* InPosition,FRotator* InRotation,FVector* OutPosition,FRotator* OutRotation)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->TransformToBoneSpace(BoneName_temp,*InPosition,*InRotation,*OutPosition,*OutRotation);
			
		}
		static int32 BoneIsChildOf(USkinnedMeshComponent* _this,MonoString* BoneName,MonoString* ParentBoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FName ParentBoneName_temp=MonoStringToFName(ParentBoneName);
			bool ___ret = _this->BoneIsChildOf(BoneName_temp,ParentBoneName_temp);
			return ___ret?1:0;
			
		}
		static void SetMasterPoseComponent(USkinnedMeshComponent* _this,USkinnedMeshComponent* NewMasterBoneComponent)
		{
			_this->SetMasterPoseComponent(NewMasterBoneComponent);
			
		}
		static void ClearVertexColorOverride(USkinnedMeshComponent* _this,int32 LODIndex)
		{
			_this->ClearVertexColorOverride(LODIndex);
			
		}
		static void SetVertexColorOverride_LinearColor(USkinnedMeshComponent* _this,int32 LODIndex,MonoArray* VertexColors)
		{
			_this->SetVertexColorOverride_LinearColor(LODIndex,MonoArrayToTArray<FLinearColor>(VertexColors));
			
		}
		static MonoString* GetParentBone(USkinnedMeshComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FName ___ret = _this->GetParentBone(BoneName_temp);
			return FNameToMonoString(___ret);
			
		}
		static void SetSkeletalMesh(USkinnedMeshComponent* _this,USkeletalMesh* NewMesh,int32 bReinitPose)
		{
			_this->SetSkeletalMesh(NewMesh,bReinitPose>0?true:false);
			
		}
		static MonoString* GetSocketBoneName(USkinnedMeshComponent* _this,MonoString* InSocketName)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			FName ___ret = _this->GetSocketBoneName(InSocketName_temp);
			return FNameToMonoString(___ret);
			
		}
		static MonoString* GetBoneName(USkinnedMeshComponent* _this,int32 BoneIndex)
		{
			FName ___ret = _this->GetBoneName(BoneIndex);
			return FNameToMonoString(___ret);
			
		}
		static int32 GetBoneIndex(USkinnedMeshComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			int32 ___ret = _this->GetBoneIndex(BoneName_temp);
			return ___ret;
			
		}
		static int32 GetNumBones(USkinnedMeshComponent* _this)
		{
			int32 ___ret = _this->GetNumBones();
			return ___ret;
			
		}
		static void SetForcedLOD(USkinnedMeshComponent* _this,int32 InNewForcedLOD)
		{
			_this->SetForcedLOD(InNewForcedLOD);
			
		}
		static void SetMinLOD(USkinnedMeshComponent* _this,int32 InNewMinLOD)
		{
			_this->SetMinLOD(InNewMinLOD);
			
		}
		static void SetPhysicsAsset(USkinnedMeshComponent* _this,UPhysicsAsset* NewPhysicsAsset,int32 bForceReInit)
		{
			_this->SetPhysicsAsset(NewPhysicsAsset,bForceReInit>0?true:false);
			
		}
		static UClass* StaticClass(){return USkinnedMeshComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::IsBoneHiddenByName",(const void*)IsBoneHiddenByName);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::UnHideBoneByName",(const void*)UnHideBoneByName);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::HideBoneByName",(const void*)HideBoneByName);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::FindClosestBone_K2",(const void*)FindClosestBone_K2);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::TransformFromBoneSpace",(const void*)TransformFromBoneSpace);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::TransformToBoneSpace",(const void*)TransformToBoneSpace);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::BoneIsChildOf",(const void*)BoneIsChildOf);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::SetMasterPoseComponent",(const void*)SetMasterPoseComponent);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::ClearVertexColorOverride",(const void*)ClearVertexColorOverride);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::SetVertexColorOverride_LinearColor",(const void*)SetVertexColorOverride_LinearColor);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::GetParentBone",(const void*)GetParentBone);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::SetSkeletalMesh",(const void*)SetSkeletalMesh);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::GetSocketBoneName",(const void*)GetSocketBoneName);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::GetBoneName",(const void*)GetBoneName);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::GetBoneIndex",(const void*)GetBoneIndex);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::GetNumBones",(const void*)GetNumBones);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::SetForcedLOD",(const void*)SetForcedLOD);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::SetMinLOD",(const void*)SetMinLOD);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::SetPhysicsAsset",(const void*)SetPhysicsAsset);
			mono_add_internal_call("UnrealEngine.USkinnedMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
