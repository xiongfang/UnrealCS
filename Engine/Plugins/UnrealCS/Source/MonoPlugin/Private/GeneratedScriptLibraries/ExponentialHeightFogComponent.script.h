#pragma once

namespace UnrealEngine
{
	class _UExponentialHeightFogComponent
	{
		static void SetStartDistance(UExponentialHeightFogComponent* _this,float Value)
		{
			_this->SetStartDistance(Value);
			
		}
		static void SetFogMaxOpacity(UExponentialHeightFogComponent* _this,float Value)
		{
			_this->SetFogMaxOpacity(Value);
			
		}
		static void SetFogHeightFalloff(UExponentialHeightFogComponent* _this,float Value)
		{
			_this->SetFogHeightFalloff(Value);
			
		}
		static void SetDirectionalInscatteringColor(UExponentialHeightFogComponent* _this,FLinearColor* Value)
		{
			_this->SetDirectionalInscatteringColor(*Value);
			
		}
		static void SetDirectionalInscatteringStartDistance(UExponentialHeightFogComponent* _this,float Value)
		{
			_this->SetDirectionalInscatteringStartDistance(Value);
			
		}
		static void SetDirectionalInscatteringExponent(UExponentialHeightFogComponent* _this,float Value)
		{
			_this->SetDirectionalInscatteringExponent(Value);
			
		}
		static void SetFogInscatteringColor(UExponentialHeightFogComponent* _this,FLinearColor* Value)
		{
			_this->SetFogInscatteringColor(*Value);
			
		}
		static void SetFogDensity(UExponentialHeightFogComponent* _this,float Value)
		{
			_this->SetFogDensity(Value);
			
		}
		static UClass* StaticClass(){return UExponentialHeightFogComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::SetStartDistance",(const void*)SetStartDistance);
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::SetFogMaxOpacity",(const void*)SetFogMaxOpacity);
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::SetFogHeightFalloff",(const void*)SetFogHeightFalloff);
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::SetDirectionalInscatteringColor",(const void*)SetDirectionalInscatteringColor);
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::SetDirectionalInscatteringStartDistance",(const void*)SetDirectionalInscatteringStartDistance);
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::SetDirectionalInscatteringExponent",(const void*)SetDirectionalInscatteringExponent);
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::SetFogInscatteringColor",(const void*)SetFogInscatteringColor);
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::SetFogDensity",(const void*)SetFogDensity);
			mono_add_internal_call("UnrealEngine.UExponentialHeightFogComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
