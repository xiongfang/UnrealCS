#pragma once

namespace UnrealEngine
{
	class _UPhysicalAnimationComponent
	{
		static void ApplyPhysicalAnimationProfileBelow(UPhysicalAnimationComponent* _this,MonoString* BodyName,MonoString* ProfileName,int32 bIncludeSelf,int32 bClearNotFound)
		{
			FName BodyName_temp=MonoStringToFName(BodyName);
			FName ProfileName_temp=MonoStringToFName(ProfileName);
			_this->ApplyPhysicalAnimationProfileBelow(BodyName_temp,ProfileName_temp,bIncludeSelf>0?true:false,bClearNotFound>0?true:false);
			
		}
		static void SetStrengthMultiplyer(UPhysicalAnimationComponent* _this,float InStrengthMultiplyer)
		{
			_this->SetStrengthMultiplyer(InStrengthMultiplyer);
			
		}
		static void ApplyPhysicalAnimationSettingsBelow(UPhysicalAnimationComponent* _this,MonoString* BodyName,FPhysicalAnimationData* PhysicalAnimationData,int32 bIncludeSelf)
		{
			FName BodyName_temp=MonoStringToFName(BodyName);
			_this->ApplyPhysicalAnimationSettingsBelow(BodyName_temp,*PhysicalAnimationData,bIncludeSelf>0?true:false);
			
		}
		static void ApplyPhysicalAnimationSettings(UPhysicalAnimationComponent* _this,MonoString* BodyName,FPhysicalAnimationData* PhysicalAnimationData)
		{
			FName BodyName_temp=MonoStringToFName(BodyName);
			_this->ApplyPhysicalAnimationSettings(BodyName_temp,*PhysicalAnimationData);
			
		}
		static void SetSkeletalMeshComponent(UPhysicalAnimationComponent* _this,USkeletalMeshComponent* InSkeletalMeshComponent)
		{
			_this->SetSkeletalMeshComponent(InSkeletalMeshComponent);
			
		}
		static UClass* StaticClass(){return UPhysicalAnimationComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicalAnimationComponent::ApplyPhysicalAnimationProfileBelow",(const void*)ApplyPhysicalAnimationProfileBelow);
			mono_add_internal_call("UnrealEngine.UPhysicalAnimationComponent::SetStrengthMultiplyer",(const void*)SetStrengthMultiplyer);
			mono_add_internal_call("UnrealEngine.UPhysicalAnimationComponent::ApplyPhysicalAnimationSettingsBelow",(const void*)ApplyPhysicalAnimationSettingsBelow);
			mono_add_internal_call("UnrealEngine.UPhysicalAnimationComponent::ApplyPhysicalAnimationSettings",(const void*)ApplyPhysicalAnimationSettings);
			mono_add_internal_call("UnrealEngine.UPhysicalAnimationComponent::SetSkeletalMeshComponent",(const void*)SetSkeletalMeshComponent);
			mono_add_internal_call("UnrealEngine.UPhysicalAnimationComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
