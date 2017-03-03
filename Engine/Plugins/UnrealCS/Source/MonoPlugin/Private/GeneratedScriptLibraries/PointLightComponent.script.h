#pragma once

namespace UnrealEngine
{
	class _UPointLightComponent
	{
		static void SetSourceLength(UPointLightComponent* _this,float NewValue)
		{
			_this->SetSourceLength(NewValue);
			
		}
		static void SetSourceRadius(UPointLightComponent* _this,float bNewValue)
		{
			_this->SetSourceRadius(bNewValue);
			
		}
		static void SetLightFalloffExponent(UPointLightComponent* _this,float NewLightFalloffExponent)
		{
			_this->SetLightFalloffExponent(NewLightFalloffExponent);
			
		}
		static void SetAttenuationRadius(UPointLightComponent* _this,float NewRadius)
		{
			_this->SetAttenuationRadius(NewRadius);
			
		}
		static UClass* StaticClass(){return UPointLightComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPointLightComponent::SetSourceLength",(const void*)SetSourceLength);
			mono_add_internal_call("UnrealEngine.UPointLightComponent::SetSourceRadius",(const void*)SetSourceRadius);
			mono_add_internal_call("UnrealEngine.UPointLightComponent::SetLightFalloffExponent",(const void*)SetLightFalloffExponent);
			mono_add_internal_call("UnrealEngine.UPointLightComponent::SetAttenuationRadius",(const void*)SetAttenuationRadius);
			mono_add_internal_call("UnrealEngine.UPointLightComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
