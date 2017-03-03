#pragma once

namespace UnrealEngine
{
	class _USkyLightComponent
	{
		static void RecaptureSky(USkyLightComponent* _this)
		{
			_this->RecaptureSky();
			
		}
		static void SetMinOcclusion(USkyLightComponent* _this,float InMinOcclusion)
		{
			_this->SetMinOcclusion(InMinOcclusion);
			
		}
		static void SetOcclusionTint(USkyLightComponent* _this,FColor* InTint)
		{
			_this->SetOcclusionTint(*InTint);
			
		}
		static void SetCubemapBlend(USkyLightComponent* _this,UTextureCube* SourceCubemap,UTextureCube* DestinationCubemap,float InBlendFraction)
		{
			_this->SetCubemapBlend(SourceCubemap,DestinationCubemap,InBlendFraction);
			
		}
		static void SetCubemap(USkyLightComponent* _this,UTextureCube* NewCubemap)
		{
			_this->SetCubemap(NewCubemap);
			
		}
		static void SetLightColor(USkyLightComponent* _this,FLinearColor* NewLightColor)
		{
			_this->SetLightColor(*NewLightColor);
			
		}
		static void SetIndirectLightingIntensity(USkyLightComponent* _this,float NewIntensity)
		{
			_this->SetIndirectLightingIntensity(NewIntensity);
			
		}
		static void SetIntensity(USkyLightComponent* _this,float NewIntensity)
		{
			_this->SetIntensity(NewIntensity);
			
		}
		static UClass* StaticClass(){return USkyLightComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USkyLightComponent::RecaptureSky",(const void*)RecaptureSky);
			mono_add_internal_call("UnrealEngine.USkyLightComponent::SetMinOcclusion",(const void*)SetMinOcclusion);
			mono_add_internal_call("UnrealEngine.USkyLightComponent::SetOcclusionTint",(const void*)SetOcclusionTint);
			mono_add_internal_call("UnrealEngine.USkyLightComponent::SetCubemapBlend",(const void*)SetCubemapBlend);
			mono_add_internal_call("UnrealEngine.USkyLightComponent::SetCubemap",(const void*)SetCubemap);
			mono_add_internal_call("UnrealEngine.USkyLightComponent::SetLightColor",(const void*)SetLightColor);
			mono_add_internal_call("UnrealEngine.USkyLightComponent::SetIndirectLightingIntensity",(const void*)SetIndirectLightingIntensity);
			mono_add_internal_call("UnrealEngine.USkyLightComponent::SetIntensity",(const void*)SetIntensity);
			mono_add_internal_call("UnrealEngine.USkyLightComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
