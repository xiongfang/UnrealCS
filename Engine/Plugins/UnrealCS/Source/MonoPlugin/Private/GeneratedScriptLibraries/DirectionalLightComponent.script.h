#pragma once

namespace UnrealEngine
{
	class _UDirectionalLightComponent
	{
		static void SetLightShaftOverrideDirection(UDirectionalLightComponent* _this,FVector* NewValue)
		{
			_this->SetLightShaftOverrideDirection(*NewValue);
			
		}
		static void SetOcclusionMaskDarkness(UDirectionalLightComponent* _this,float NewValue)
		{
			_this->SetOcclusionMaskDarkness(NewValue);
			
		}
		static void SetEnableLightShaftOcclusion(UDirectionalLightComponent* _this,int32 bNewValue)
		{
			_this->SetEnableLightShaftOcclusion(bNewValue>0?true:false);
			
		}
		static void SetShadowDistanceFadeoutFraction(UDirectionalLightComponent* _this,float NewValue)
		{
			_this->SetShadowDistanceFadeoutFraction(NewValue);
			
		}
		static void SetCascadeTransitionFraction(UDirectionalLightComponent* _this,float NewValue)
		{
			_this->SetCascadeTransitionFraction(NewValue);
			
		}
		static void SetCascadeDistributionExponent(UDirectionalLightComponent* _this,float NewValue)
		{
			_this->SetCascadeDistributionExponent(NewValue);
			
		}
		static void SetDynamicShadowCascades(UDirectionalLightComponent* _this,int32 NewValue)
		{
			_this->SetDynamicShadowCascades(NewValue);
			
		}
		static void SetDynamicShadowDistanceStationaryLight(UDirectionalLightComponent* _this,float NewValue)
		{
			_this->SetDynamicShadowDistanceStationaryLight(NewValue);
			
		}
		static void SetDynamicShadowDistanceMovableLight(UDirectionalLightComponent* _this,float NewValue)
		{
			_this->SetDynamicShadowDistanceMovableLight(NewValue);
			
		}
		static UClass* StaticClass(){return UDirectionalLightComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetLightShaftOverrideDirection",(const void*)SetLightShaftOverrideDirection);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetOcclusionMaskDarkness",(const void*)SetOcclusionMaskDarkness);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetEnableLightShaftOcclusion",(const void*)SetEnableLightShaftOcclusion);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetShadowDistanceFadeoutFraction",(const void*)SetShadowDistanceFadeoutFraction);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetCascadeTransitionFraction",(const void*)SetCascadeTransitionFraction);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetCascadeDistributionExponent",(const void*)SetCascadeDistributionExponent);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetDynamicShadowCascades",(const void*)SetDynamicShadowCascades);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetDynamicShadowDistanceStationaryLight",(const void*)SetDynamicShadowDistanceStationaryLight);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::SetDynamicShadowDistanceMovableLight",(const void*)SetDynamicShadowDistanceMovableLight);
			mono_add_internal_call("UnrealEngine.UDirectionalLightComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
