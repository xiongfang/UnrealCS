#pragma once

namespace UnrealEngine
{
	class _UActorComponent
	{
		static void RemoveTickPrerequisiteComponent(UActorComponent* _this,UActorComponent* PrerequisiteComponent)
		{
			_this->RemoveTickPrerequisiteComponent(PrerequisiteComponent);
			
		}
		static void RemoveTickPrerequisiteActor(UActorComponent* _this,AActor* PrerequisiteActor)
		{
			_this->RemoveTickPrerequisiteActor(PrerequisiteActor);
			
		}
		static void AddTickPrerequisiteComponent(UActorComponent* _this,UActorComponent* PrerequisiteComponent)
		{
			_this->AddTickPrerequisiteComponent(PrerequisiteComponent);
			
		}
		static void AddTickPrerequisiteActor(UActorComponent* _this,AActor* PrerequisiteActor)
		{
			_this->AddTickPrerequisiteActor(PrerequisiteActor);
			
		}
		static void SetTickGroup(UActorComponent* _this,int32 NewTickGroup)
		{
			_this->SetTickGroup((TEnumAsByte<ETickingGroup>)NewTickGroup);
			
		}
		static void K2_DestroyComponent(UActorComponent* _this,UObject* Object)
		{
			_this->K2_DestroyComponent(Object);
			
		}
		static float GetComponentTickInterval(UActorComponent* _this)
		{
			float ___ret = _this->GetComponentTickInterval();
			return ___ret;
			
		}
		static void SetComponentTickInterval(UActorComponent* _this,float TickInterval)
		{
			_this->SetComponentTickInterval(TickInterval);
			
		}
		static int32 IsComponentTickEnabled(UActorComponent* _this)
		{
			bool ___ret = _this->IsComponentTickEnabled();
			return ___ret?1:0;
			
		}
		static void SetComponentTickEnabled(UActorComponent* _this,int32 bEnabled)
		{
			_this->SetComponentTickEnabled(bEnabled>0?true:false);
			
		}
		static void SetIsReplicated(UActorComponent* _this,int32 ShouldReplicate)
		{
			_this->SetIsReplicated(ShouldReplicate>0?true:false);
			
		}
		static void SetTickableWhenPaused(UActorComponent* _this,int32 bTickableWhenPaused)
		{
			_this->SetTickableWhenPaused(bTickableWhenPaused>0?true:false);
			
		}
		static int32 IsActive(UActorComponent* _this)
		{
			bool ___ret = _this->IsActive();
			return ___ret?1:0;
			
		}
		static void ToggleActive(UActorComponent* _this)
		{
			_this->ToggleActive();
			
		}
		static void SetActive(UActorComponent* _this,int32 bNewActive,int32 bReset)
		{
			_this->SetActive(bNewActive>0?true:false,bReset>0?true:false);
			
		}
		static void Deactivate(UActorComponent* _this)
		{
			_this->Deactivate();
			
		}
		static void Activate(UActorComponent* _this,int32 bReset)
		{
			_this->Activate(bReset>0?true:false);
			
		}
		static int32 ComponentHasTag(UActorComponent* _this,MonoString* Tag)
		{
			FName Tag_temp=MonoStringToFName(Tag);
			bool ___ret = _this->ComponentHasTag(Tag_temp);
			return ___ret?1:0;
			
		}
		static AActor* GetOwner(UActorComponent* _this)
		{
			AActor* ___ret = _this->GetOwner();
			return ___ret;
			
		}
		static void OnRep_IsActive(UActorComponent* _this)
		{
			_this->OnRep_IsActive();
			
		}
		static int32 IsBeingDestroyed(UActorComponent* _this)
		{
			bool ___ret = _this->IsBeingDestroyed();
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UActorComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UActorComponent::RemoveTickPrerequisiteComponent",(const void*)RemoveTickPrerequisiteComponent);
			mono_add_internal_call("UnrealEngine.UActorComponent::RemoveTickPrerequisiteActor",(const void*)RemoveTickPrerequisiteActor);
			mono_add_internal_call("UnrealEngine.UActorComponent::AddTickPrerequisiteComponent",(const void*)AddTickPrerequisiteComponent);
			mono_add_internal_call("UnrealEngine.UActorComponent::AddTickPrerequisiteActor",(const void*)AddTickPrerequisiteActor);
			mono_add_internal_call("UnrealEngine.UActorComponent::SetTickGroup",(const void*)SetTickGroup);
			mono_add_internal_call("UnrealEngine.UActorComponent::K2_DestroyComponent",(const void*)K2_DestroyComponent);
			mono_add_internal_call("UnrealEngine.UActorComponent::GetComponentTickInterval",(const void*)GetComponentTickInterval);
			mono_add_internal_call("UnrealEngine.UActorComponent::SetComponentTickInterval",(const void*)SetComponentTickInterval);
			mono_add_internal_call("UnrealEngine.UActorComponent::IsComponentTickEnabled",(const void*)IsComponentTickEnabled);
			mono_add_internal_call("UnrealEngine.UActorComponent::SetComponentTickEnabled",(const void*)SetComponentTickEnabled);
			mono_add_internal_call("UnrealEngine.UActorComponent::SetIsReplicated",(const void*)SetIsReplicated);
			mono_add_internal_call("UnrealEngine.UActorComponent::SetTickableWhenPaused",(const void*)SetTickableWhenPaused);
			mono_add_internal_call("UnrealEngine.UActorComponent::IsActive",(const void*)IsActive);
			mono_add_internal_call("UnrealEngine.UActorComponent::ToggleActive",(const void*)ToggleActive);
			mono_add_internal_call("UnrealEngine.UActorComponent::SetActive",(const void*)SetActive);
			mono_add_internal_call("UnrealEngine.UActorComponent::Deactivate",(const void*)Deactivate);
			mono_add_internal_call("UnrealEngine.UActorComponent::Activate",(const void*)Activate);
			mono_add_internal_call("UnrealEngine.UActorComponent::ComponentHasTag",(const void*)ComponentHasTag);
			mono_add_internal_call("UnrealEngine.UActorComponent::GetOwner",(const void*)GetOwner);
			mono_add_internal_call("UnrealEngine.UActorComponent::OnRep_IsActive",(const void*)OnRep_IsActive);
			mono_add_internal_call("UnrealEngine.UActorComponent::IsBeingDestroyed",(const void*)IsBeingDestroyed);
			mono_add_internal_call("UnrealEngine.UActorComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
