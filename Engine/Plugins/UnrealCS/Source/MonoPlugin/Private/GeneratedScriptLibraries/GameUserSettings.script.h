#pragma once

namespace UnrealEngine
{
	class _UGameUserSettings
	{
		static void EnableHDRDisplayOutput(UGameUserSettings* _this,int32 bEnable,int32 DisplayNits)
		{
			_this->EnableHDRDisplayOutput(bEnable>0?true:false,DisplayNits);
			
		}
		static int32 SupportsHDRDisplayOutput(UGameUserSettings* _this)
		{
			bool ___ret = _this->SupportsHDRDisplayOutput();
			return ___ret?1:0;
			
		}
		static void ApplyHardwareBenchmarkResults(UGameUserSettings* _this)
		{
			_this->ApplyHardwareBenchmarkResults();
			
		}
		static void RunHardwareBenchmark(UGameUserSettings* _this,int32 WorkScale,float CPUMultiplier,float GPUMultiplier)
		{
			_this->RunHardwareBenchmark(WorkScale,CPUMultiplier,GPUMultiplier);
			
		}
		static UGameUserSettings* GetGameUserSettings(UGameUserSettings* _this)
		{
			UGameUserSettings* ___ret = _this->GetGameUserSettings();
			return ___ret;
			
		}
		static int32 GetDefaultWindowMode(UGameUserSettings* _this)
		{
			TEnumAsByte<EWindowMode::Type> ___ret = _this->GetDefaultWindowMode();
			return (int32)___ret.GetValue();
			
		}
		static FIntPoint GetDefaultWindowPosition(UGameUserSettings* _this)
		{
			FIntPoint ___ret = _this->GetDefaultWindowPosition();
			return ___ret;
			
		}
		static FIntPoint GetDefaultResolution(UGameUserSettings* _this)
		{
			FIntPoint ___ret = _this->GetDefaultResolution();
			return ___ret;
			
		}
		static float GetDefaultResolutionScale(UGameUserSettings* _this)
		{
			float ___ret = _this->GetDefaultResolutionScale();
			return ___ret;
			
		}
		static void SetToDefaults(UGameUserSettings* _this)
		{
			_this->SetToDefaults();
			
		}
		static void ResetToCurrentSettings(UGameUserSettings* _this)
		{
			_this->ResetToCurrentSettings();
			
		}
		static void SaveSettings(UGameUserSettings* _this)
		{
			_this->SaveSettings();
			
		}
		static void LoadSettings(UGameUserSettings* _this,int32 bForceReload)
		{
			_this->LoadSettings(bForceReload>0?true:false);
			
		}
		static void ValidateSettings(UGameUserSettings* _this)
		{
			_this->ValidateSettings();
			
		}
		static int32 IsDirty(UGameUserSettings* _this)
		{
			bool ___ret = _this->IsDirty();
			return ___ret?1:0;
			
		}
		static int32 GetFoliageQuality(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetFoliageQuality();
			return ___ret;
			
		}
		static void SetFoliageQuality(UGameUserSettings* _this,int32 Value)
		{
			_this->SetFoliageQuality(Value);
			
		}
		static int32 GetPostProcessingQuality(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetPostProcessingQuality();
			return ___ret;
			
		}
		static void SetPostProcessingQuality(UGameUserSettings* _this,int32 Value)
		{
			_this->SetPostProcessingQuality(Value);
			
		}
		static int32 GetVisualEffectQuality(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetVisualEffectQuality();
			return ___ret;
			
		}
		static void SetVisualEffectQuality(UGameUserSettings* _this,int32 Value)
		{
			_this->SetVisualEffectQuality(Value);
			
		}
		static int32 GetTextureQuality(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetTextureQuality();
			return ___ret;
			
		}
		static void SetTextureQuality(UGameUserSettings* _this,int32 Value)
		{
			_this->SetTextureQuality(Value);
			
		}
		static int32 GetAntiAliasingQuality(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetAntiAliasingQuality();
			return ___ret;
			
		}
		static void SetAntiAliasingQuality(UGameUserSettings* _this,int32 Value)
		{
			_this->SetAntiAliasingQuality(Value);
			
		}
		static int32 GetShadowQuality(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetShadowQuality();
			return ___ret;
			
		}
		static void SetShadowQuality(UGameUserSettings* _this,int32 Value)
		{
			_this->SetShadowQuality(Value);
			
		}
		static int32 GetViewDistanceQuality(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetViewDistanceQuality();
			return ___ret;
			
		}
		static void SetViewDistanceQuality(UGameUserSettings* _this,int32 Value)
		{
			_this->SetViewDistanceQuality(Value);
			
		}
		static void SetResolutionScaleNormalized(UGameUserSettings* _this,float NewScaleNormalized)
		{
			_this->SetResolutionScaleNormalized(NewScaleNormalized);
			
		}
		static void SetResolutionScaleValueEx(UGameUserSettings* _this,float NewScaleValue)
		{
			_this->SetResolutionScaleValueEx(NewScaleValue);
			
		}
		static void GetResolutionScaleInformationEx(UGameUserSettings* _this,float* CurrentScaleNormalized,float* CurrentScaleValue,float* MinScaleValue,float* MaxScaleValue)
		{
			_this->GetResolutionScaleInformationEx(*CurrentScaleNormalized,*CurrentScaleValue,*MinScaleValue,*MaxScaleValue);
			
		}
		static int32 GetOverallScalabilityLevel(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetOverallScalabilityLevel();
			return ___ret;
			
		}
		static void SetOverallScalabilityLevel(UGameUserSettings* _this,int32 Value)
		{
			_this->SetOverallScalabilityLevel(Value);
			
		}
		static float GetFrameRateLimit(UGameUserSettings* _this)
		{
			float ___ret = _this->GetFrameRateLimit();
			return ___ret;
			
		}
		static void SetFrameRateLimit(UGameUserSettings* _this,float NewLimit)
		{
			_this->SetFrameRateLimit(NewLimit);
			
		}
		static int32 GetAudioQualityLevel(UGameUserSettings* _this)
		{
			int32 ___ret = _this->GetAudioQualityLevel();
			return ___ret;
			
		}
		static void SetAudioQualityLevel(UGameUserSettings* _this,int32 QualityLevel)
		{
			_this->SetAudioQualityLevel(QualityLevel);
			
		}
		static void SetBenchmarkFallbackValues(UGameUserSettings* _this)
		{
			_this->SetBenchmarkFallbackValues();
			
		}
		static void RevertVideoMode(UGameUserSettings* _this)
		{
			_this->RevertVideoMode();
			
		}
		static void ConfirmVideoMode(UGameUserSettings* _this)
		{
			_this->ConfirmVideoMode();
			
		}
		static int32 IsVSyncDirty(UGameUserSettings* _this)
		{
			bool ___ret = _this->IsVSyncDirty();
			return ___ret?1:0;
			
		}
		static int32 IsFullscreenModeDirty(UGameUserSettings* _this)
		{
			bool ___ret = _this->IsFullscreenModeDirty();
			return ___ret?1:0;
			
		}
		static int32 IsScreenResolutionDirty(UGameUserSettings* _this)
		{
			bool ___ret = _this->IsScreenResolutionDirty();
			return ___ret?1:0;
			
		}
		static int32 IsVSyncEnabled(UGameUserSettings* _this)
		{
			bool ___ret = _this->IsVSyncEnabled();
			return ___ret?1:0;
			
		}
		static void SetVSyncEnabled(UGameUserSettings* _this,int32 bEnable)
		{
			_this->SetVSyncEnabled(bEnable>0?true:false);
			
		}
		static int32 GetPreferredFullscreenMode(UGameUserSettings* _this)
		{
			TEnumAsByte<EWindowMode::Type> ___ret = _this->GetPreferredFullscreenMode();
			return (int32)___ret.GetValue();
			
		}
		static void SetFullscreenMode(UGameUserSettings* _this,int32 InFullscreenMode)
		{
			_this->SetFullscreenMode((TEnumAsByte<EWindowMode::Type>)InFullscreenMode);
			
		}
		static int32 GetLastConfirmedFullscreenMode(UGameUserSettings* _this)
		{
			TEnumAsByte<EWindowMode::Type> ___ret = _this->GetLastConfirmedFullscreenMode();
			return (int32)___ret.GetValue();
			
		}
		static int32 GetFullscreenMode(UGameUserSettings* _this)
		{
			TEnumAsByte<EWindowMode::Type> ___ret = _this->GetFullscreenMode();
			return (int32)___ret.GetValue();
			
		}
		static void SetScreenResolution(UGameUserSettings* _this,FIntPoint* Resolution)
		{
			_this->SetScreenResolution(*Resolution);
			
		}
		static FIntPoint GetDesktopResolution(UGameUserSettings* _this)
		{
			FIntPoint ___ret = _this->GetDesktopResolution();
			return ___ret;
			
		}
		static FIntPoint GetLastConfirmedScreenResolution(UGameUserSettings* _this)
		{
			FIntPoint ___ret = _this->GetLastConfirmedScreenResolution();
			return ___ret;
			
		}
		static FIntPoint GetScreenResolution(UGameUserSettings* _this)
		{
			FIntPoint ___ret = _this->GetScreenResolution();
			return ___ret;
			
		}
		static void ApplyResolutionSettings(UGameUserSettings* _this,int32 bCheckForCommandLineOverrides)
		{
			_this->ApplyResolutionSettings(bCheckForCommandLineOverrides>0?true:false);
			
		}
		static void ApplyNonResolutionSettings(UGameUserSettings* _this)
		{
			_this->ApplyNonResolutionSettings();
			
		}
		static void ApplySettings(UGameUserSettings* _this,int32 bCheckForCommandLineOverrides)
		{
			_this->ApplySettings(bCheckForCommandLineOverrides>0?true:false);
			
		}
		static UClass* StaticClass(){return UGameUserSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UGameUserSettings::EnableHDRDisplayOutput",(const void*)EnableHDRDisplayOutput);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SupportsHDRDisplayOutput",(const void*)SupportsHDRDisplayOutput);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::ApplyHardwareBenchmarkResults",(const void*)ApplyHardwareBenchmarkResults);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::RunHardwareBenchmark",(const void*)RunHardwareBenchmark);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetGameUserSettings",(const void*)GetGameUserSettings);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetDefaultWindowMode",(const void*)GetDefaultWindowMode);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetDefaultWindowPosition",(const void*)GetDefaultWindowPosition);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetDefaultResolution",(const void*)GetDefaultResolution);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetDefaultResolutionScale",(const void*)GetDefaultResolutionScale);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetToDefaults",(const void*)SetToDefaults);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::ResetToCurrentSettings",(const void*)ResetToCurrentSettings);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SaveSettings",(const void*)SaveSettings);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::LoadSettings",(const void*)LoadSettings);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::ValidateSettings",(const void*)ValidateSettings);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::IsDirty",(const void*)IsDirty);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetFoliageQuality",(const void*)GetFoliageQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetFoliageQuality",(const void*)SetFoliageQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetPostProcessingQuality",(const void*)GetPostProcessingQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetPostProcessingQuality",(const void*)SetPostProcessingQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetVisualEffectQuality",(const void*)GetVisualEffectQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetVisualEffectQuality",(const void*)SetVisualEffectQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetTextureQuality",(const void*)GetTextureQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetTextureQuality",(const void*)SetTextureQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetAntiAliasingQuality",(const void*)GetAntiAliasingQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetAntiAliasingQuality",(const void*)SetAntiAliasingQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetShadowQuality",(const void*)GetShadowQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetShadowQuality",(const void*)SetShadowQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetViewDistanceQuality",(const void*)GetViewDistanceQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetViewDistanceQuality",(const void*)SetViewDistanceQuality);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetResolutionScaleNormalized",(const void*)SetResolutionScaleNormalized);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetResolutionScaleValueEx",(const void*)SetResolutionScaleValueEx);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetResolutionScaleInformationEx",(const void*)GetResolutionScaleInformationEx);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetOverallScalabilityLevel",(const void*)GetOverallScalabilityLevel);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetOverallScalabilityLevel",(const void*)SetOverallScalabilityLevel);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetFrameRateLimit",(const void*)GetFrameRateLimit);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetFrameRateLimit",(const void*)SetFrameRateLimit);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetAudioQualityLevel",(const void*)GetAudioQualityLevel);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetAudioQualityLevel",(const void*)SetAudioQualityLevel);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetBenchmarkFallbackValues",(const void*)SetBenchmarkFallbackValues);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::RevertVideoMode",(const void*)RevertVideoMode);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::ConfirmVideoMode",(const void*)ConfirmVideoMode);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::IsVSyncDirty",(const void*)IsVSyncDirty);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::IsFullscreenModeDirty",(const void*)IsFullscreenModeDirty);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::IsScreenResolutionDirty",(const void*)IsScreenResolutionDirty);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::IsVSyncEnabled",(const void*)IsVSyncEnabled);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetVSyncEnabled",(const void*)SetVSyncEnabled);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetPreferredFullscreenMode",(const void*)GetPreferredFullscreenMode);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetFullscreenMode",(const void*)SetFullscreenMode);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetLastConfirmedFullscreenMode",(const void*)GetLastConfirmedFullscreenMode);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetFullscreenMode",(const void*)GetFullscreenMode);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::SetScreenResolution",(const void*)SetScreenResolution);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetDesktopResolution",(const void*)GetDesktopResolution);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetLastConfirmedScreenResolution",(const void*)GetLastConfirmedScreenResolution);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::GetScreenResolution",(const void*)GetScreenResolution);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::ApplyResolutionSettings",(const void*)ApplyResolutionSettings);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::ApplyNonResolutionSettings",(const void*)ApplyNonResolutionSettings);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::ApplySettings",(const void*)ApplySettings);
			mono_add_internal_call("UnrealEngine.UGameUserSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
