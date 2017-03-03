#pragma once

namespace UnrealEngine
{
	class _UForceFeedbackComponent
	{
		static int32 BP_GetAttenuationSettingsToApply(UForceFeedbackComponent* _this,FForceFeedbackAttenuationSettings* OutAttenuationSettings)
		{
			bool ___ret = _this->BP_GetAttenuationSettingsToApply(*OutAttenuationSettings);
			return ___ret?1:0;
			
		}
		static void AdjustAttenuation(UForceFeedbackComponent* _this,FForceFeedbackAttenuationSettings* InAttenuationSettings)
		{
			_this->AdjustAttenuation(*InAttenuationSettings);
			
		}
		static void SetIntensityMultiplier(UForceFeedbackComponent* _this,float NewIntensityMultiplier)
		{
			_this->SetIntensityMultiplier(NewIntensityMultiplier);
			
		}
		static void Stop(UForceFeedbackComponent* _this)
		{
			_this->Stop();
			
		}
		static void Play(UForceFeedbackComponent* _this,float StartTime)
		{
			_this->Play(StartTime);
			
		}
		static void SetForceFeedbackEffect(UForceFeedbackComponent* _this,UForceFeedbackEffect* NewForceFeedbackEffect)
		{
			_this->SetForceFeedbackEffect(NewForceFeedbackEffect);
			
		}
		static UClass* StaticClass(){return UForceFeedbackComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UForceFeedbackComponent::BP_GetAttenuationSettingsToApply",(const void*)BP_GetAttenuationSettingsToApply);
			mono_add_internal_call("UnrealEngine.UForceFeedbackComponent::AdjustAttenuation",(const void*)AdjustAttenuation);
			mono_add_internal_call("UnrealEngine.UForceFeedbackComponent::SetIntensityMultiplier",(const void*)SetIntensityMultiplier);
			mono_add_internal_call("UnrealEngine.UForceFeedbackComponent::Stop",(const void*)Stop);
			mono_add_internal_call("UnrealEngine.UForceFeedbackComponent::Play",(const void*)Play);
			mono_add_internal_call("UnrealEngine.UForceFeedbackComponent::SetForceFeedbackEffect",(const void*)SetForceFeedbackEffect);
			mono_add_internal_call("UnrealEngine.UForceFeedbackComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
