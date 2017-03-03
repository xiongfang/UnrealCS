#pragma once

namespace UnrealEngine
{
	class _UDecalComponent
	{
		static UMaterialInstanceDynamic* CreateDynamicMaterialInstance(UDecalComponent* _this)
		{
			UMaterialInstanceDynamic* ___ret = _this->CreateDynamicMaterialInstance();
			return ___ret;
			
		}
		static UMaterialInterface* GetDecalMaterial(UDecalComponent* _this)
		{
			UMaterialInterface* ___ret = _this->GetDecalMaterial();
			return ___ret;
			
		}
		static void SetDecalMaterial(UDecalComponent* _this,UMaterialInterface* NewDecalMaterial)
		{
			_this->SetDecalMaterial(NewDecalMaterial);
			
		}
		static void SetSortOrder(UDecalComponent* _this,int32 Value)
		{
			_this->SetSortOrder(Value);
			
		}
		static void SetFadeOut(UDecalComponent* _this,float StartDelay,float Duration,int32 DestroyOwnerAfterFade)
		{
			_this->SetFadeOut(StartDelay,Duration,DestroyOwnerAfterFade>0?true:false);
			
		}
		static float GetFadeDuration(UDecalComponent* _this)
		{
			float ___ret = _this->GetFadeDuration();
			return ___ret;
			
		}
		static float GetFadeStartDelay(UDecalComponent* _this)
		{
			float ___ret = _this->GetFadeStartDelay();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UDecalComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDecalComponent::CreateDynamicMaterialInstance",(const void*)CreateDynamicMaterialInstance);
			mono_add_internal_call("UnrealEngine.UDecalComponent::GetDecalMaterial",(const void*)GetDecalMaterial);
			mono_add_internal_call("UnrealEngine.UDecalComponent::SetDecalMaterial",(const void*)SetDecalMaterial);
			mono_add_internal_call("UnrealEngine.UDecalComponent::SetSortOrder",(const void*)SetSortOrder);
			mono_add_internal_call("UnrealEngine.UDecalComponent::SetFadeOut",(const void*)SetFadeOut);
			mono_add_internal_call("UnrealEngine.UDecalComponent::GetFadeDuration",(const void*)GetFadeDuration);
			mono_add_internal_call("UnrealEngine.UDecalComponent::GetFadeStartDelay",(const void*)GetFadeStartDelay);
			mono_add_internal_call("UnrealEngine.UDecalComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
