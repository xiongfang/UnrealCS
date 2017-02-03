#pragma once

namespace UnrealEngine
{
	class _ULightComponent
	{
		static void SetIESTexture(ULightComponent* _this,UTextureLightProfile* NewValue)
		{
			_this->SetIESTexture(NewValue);
			
		}
		static void SetBloomTint(ULightComponent* _this,FColor* NewValue)
		{
			_this->SetBloomTint(*NewValue);
			
		}
		static void SetBloomThreshold(ULightComponent* _this,float NewValue)
		{
			_this->SetBloomThreshold(NewValue);
			
		}
		static void SetBloomScale(ULightComponent* _this,float NewValue)
		{
			_this->SetBloomScale(NewValue);
			
		}
		static void SetEnableLightShaftBloom(ULightComponent* _this,int32 bNewValue)
		{
			_this->SetEnableLightShaftBloom(bNewValue>0?true:false);
			
		}
		static void SetAffectTranslucentLighting(ULightComponent* _this,int32 bNewValue)
		{
			_this->SetAffectTranslucentLighting(bNewValue>0?true:false);
			
		}
		static void SetAffectDynamicIndirectLighting(ULightComponent* _this,int32 bNewValue)
		{
			_this->SetAffectDynamicIndirectLighting(bNewValue>0?true:false);
			
		}
		static void SetLightFunctionDisabledBrightness(ULightComponent* _this,float NewValue)
		{
			_this->SetLightFunctionDisabledBrightness(NewValue);
			
		}
		static void SetLightFunctionFadeDistance(ULightComponent* _this,float NewLightFunctionFadeDistance)
		{
			_this->SetLightFunctionFadeDistance(NewLightFunctionFadeDistance);
			
		}
		static void SetLightFunctionScale(ULightComponent* _this,FVector* NewLightFunctionScale)
		{
			_this->SetLightFunctionScale(*NewLightFunctionScale);
			
		}
		static void SetLightFunctionMaterial(ULightComponent* _this,UMaterialInterface* NewLightFunctionMaterial)
		{
			_this->SetLightFunctionMaterial(NewLightFunctionMaterial);
			
		}
		static void SetTemperature(ULightComponent* _this,float NewTemperature)
		{
			_this->SetTemperature(NewTemperature);
			
		}
		static void SetLightColor(ULightComponent* _this,FLinearColor* NewLightColor,int32 bSRGB)
		{
			_this->SetLightColor(*NewLightColor,bSRGB>0?true:false);
			
		}
		static void SetIndirectLightingIntensity(ULightComponent* _this,float NewIntensity)
		{
			_this->SetIndirectLightingIntensity(NewIntensity);
			
		}
		static void SetIntensity(ULightComponent* _this,float NewIntensity)
		{
			_this->SetIntensity(NewIntensity);
			
		}
		static UClass* StaticClass(){return ULightComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULightComponent::SetIESTexture",(const void*)SetIESTexture);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetBloomTint",(const void*)SetBloomTint);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetBloomThreshold",(const void*)SetBloomThreshold);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetBloomScale",(const void*)SetBloomScale);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetEnableLightShaftBloom",(const void*)SetEnableLightShaftBloom);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetAffectTranslucentLighting",(const void*)SetAffectTranslucentLighting);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetAffectDynamicIndirectLighting",(const void*)SetAffectDynamicIndirectLighting);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetLightFunctionDisabledBrightness",(const void*)SetLightFunctionDisabledBrightness);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetLightFunctionFadeDistance",(const void*)SetLightFunctionFadeDistance);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetLightFunctionScale",(const void*)SetLightFunctionScale);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetLightFunctionMaterial",(const void*)SetLightFunctionMaterial);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetTemperature",(const void*)SetTemperature);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetLightColor",(const void*)SetLightColor);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetIndirectLightingIntensity",(const void*)SetIndirectLightingIntensity);
			mono_add_internal_call("UnrealEngine.ULightComponent::SetIntensity",(const void*)SetIntensity);
			mono_add_internal_call("UnrealEngine.ULightComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
