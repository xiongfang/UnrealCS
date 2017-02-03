#pragma once

namespace UnrealEngine
{
	class _UAudioComponent
	{
		static int32 BP_GetAttenuationSettingsToApply(UAudioComponent* _this,FAttenuationSettings* OutAttenuationSettings)
		{
			bool ___ret = _this->BP_GetAttenuationSettingsToApply(*OutAttenuationSettings);
			return ___ret?1:0;
			
		}
		static void AdjustAttenuation(UAudioComponent* _this,FAttenuationSettings* InAttenuationSettings)
		{
			_this->AdjustAttenuation(*InAttenuationSettings);
			
		}
		static void SetUISound(UAudioComponent* _this,int32 bInUISound)
		{
			_this->SetUISound(bInUISound>0?true:false);
			
		}
		static void SetPitchMultiplier(UAudioComponent* _this,float NewPitchMultiplier)
		{
			_this->SetPitchMultiplier(NewPitchMultiplier);
			
		}
		static void SetVolumeMultiplier(UAudioComponent* _this,float NewVolumeMultiplier)
		{
			_this->SetVolumeMultiplier(NewVolumeMultiplier);
			
		}
		static void SetIntParameter(UAudioComponent* _this,MonoString* InName,int32 InInt)
		{
			FName InName_temp=MonoStringToFName(InName);
			_this->SetIntParameter(InName_temp,InInt);
			
		}
		static void SetBoolParameter(UAudioComponent* _this,MonoString* InName,int32 InBool)
		{
			FName InName_temp=MonoStringToFName(InName);
			_this->SetBoolParameter(InName_temp,InBool>0?true:false);
			
		}
		static void SetWaveParameter(UAudioComponent* _this,MonoString* InName,USoundWave* InWave)
		{
			FName InName_temp=MonoStringToFName(InName);
			_this->SetWaveParameter(InName_temp,InWave);
			
		}
		static void SetFloatParameter(UAudioComponent* _this,MonoString* InName,float InFloat)
		{
			FName InName_temp=MonoStringToFName(InName);
			_this->SetFloatParameter(InName_temp,InFloat);
			
		}
		static void AdjustVolume(UAudioComponent* _this,float AdjustVolumeDuration,float AdjustVolumeLevel)
		{
			_this->AdjustVolume(AdjustVolumeDuration,AdjustVolumeLevel);
			
		}
		static int32 IsPlaying(UAudioComponent* _this)
		{
			bool ___ret = _this->IsPlaying();
			return ___ret?1:0;
			
		}
		static void Stop(UAudioComponent* _this)
		{
			_this->Stop();
			
		}
		static void Play(UAudioComponent* _this,float StartTime)
		{
			_this->Play(StartTime);
			
		}
		static void FadeOut(UAudioComponent* _this,float FadeOutDuration,float FadeVolumeLevel)
		{
			_this->FadeOut(FadeOutDuration,FadeVolumeLevel);
			
		}
		static void FadeIn(UAudioComponent* _this,float FadeInDuration,float FadeVolumeLevel,float StartTime)
		{
			_this->FadeIn(FadeInDuration,FadeVolumeLevel,StartTime);
			
		}
		static void SetSound(UAudioComponent* _this,USoundBase* NewSound)
		{
			_this->SetSound(NewSound);
			
		}
		static UClass* StaticClass(){return UAudioComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAudioComponent::BP_GetAttenuationSettingsToApply",(const void*)BP_GetAttenuationSettingsToApply);
			mono_add_internal_call("UnrealEngine.UAudioComponent::AdjustAttenuation",(const void*)AdjustAttenuation);
			mono_add_internal_call("UnrealEngine.UAudioComponent::SetUISound",(const void*)SetUISound);
			mono_add_internal_call("UnrealEngine.UAudioComponent::SetPitchMultiplier",(const void*)SetPitchMultiplier);
			mono_add_internal_call("UnrealEngine.UAudioComponent::SetVolumeMultiplier",(const void*)SetVolumeMultiplier);
			mono_add_internal_call("UnrealEngine.UAudioComponent::SetIntParameter",(const void*)SetIntParameter);
			mono_add_internal_call("UnrealEngine.UAudioComponent::SetBoolParameter",(const void*)SetBoolParameter);
			mono_add_internal_call("UnrealEngine.UAudioComponent::SetWaveParameter",(const void*)SetWaveParameter);
			mono_add_internal_call("UnrealEngine.UAudioComponent::SetFloatParameter",(const void*)SetFloatParameter);
			mono_add_internal_call("UnrealEngine.UAudioComponent::AdjustVolume",(const void*)AdjustVolume);
			mono_add_internal_call("UnrealEngine.UAudioComponent::IsPlaying",(const void*)IsPlaying);
			mono_add_internal_call("UnrealEngine.UAudioComponent::Stop",(const void*)Stop);
			mono_add_internal_call("UnrealEngine.UAudioComponent::Play",(const void*)Play);
			mono_add_internal_call("UnrealEngine.UAudioComponent::FadeOut",(const void*)FadeOut);
			mono_add_internal_call("UnrealEngine.UAudioComponent::FadeIn",(const void*)FadeIn);
			mono_add_internal_call("UnrealEngine.UAudioComponent::SetSound",(const void*)SetSound);
			mono_add_internal_call("UnrealEngine.UAudioComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
