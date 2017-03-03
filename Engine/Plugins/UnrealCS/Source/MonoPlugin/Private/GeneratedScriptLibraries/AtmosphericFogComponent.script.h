#pragma once

namespace UnrealEngine
{
	class _UAtmosphericFogComponent
	{
		static void SetPrecomputeParams(UAtmosphericFogComponent* _this,float DensityHeight,int32 MaxScatteringOrder,int32 InscatterAltitudeSampleNum)
		{
			_this->SetPrecomputeParams(DensityHeight,MaxScatteringOrder,InscatterAltitudeSampleNum);
			
		}
		static void DisableGroundScattering(UAtmosphericFogComponent* _this,int32 NewGroundScattering)
		{
			_this->DisableGroundScattering(NewGroundScattering>0?true:false);
			
		}
		static void DisableSunDisk(UAtmosphericFogComponent* _this,int32 NewSunDisk)
		{
			_this->DisableSunDisk(NewSunDisk>0?true:false);
			
		}
		static void SetDistanceOffset(UAtmosphericFogComponent* _this,float NewDistanceOffset)
		{
			_this->SetDistanceOffset(NewDistanceOffset);
			
		}
		static void SetStartDistance(UAtmosphericFogComponent* _this,float NewStartDistance)
		{
			_this->SetStartDistance(NewStartDistance);
			
		}
		static void SetAltitudeScale(UAtmosphericFogComponent* _this,float NewAltitudeScale)
		{
			_this->SetAltitudeScale(NewAltitudeScale);
			
		}
		static void SetDistanceScale(UAtmosphericFogComponent* _this,float NewDistanceScale)
		{
			_this->SetDistanceScale(NewDistanceScale);
			
		}
		static void SetDensityOffset(UAtmosphericFogComponent* _this,float NewDensityOffset)
		{
			_this->SetDensityOffset(NewDensityOffset);
			
		}
		static void SetDensityMultiplier(UAtmosphericFogComponent* _this,float NewDensityMultiplier)
		{
			_this->SetDensityMultiplier(NewDensityMultiplier);
			
		}
		static void SetFogMultiplier(UAtmosphericFogComponent* _this,float NewFogMultiplier)
		{
			_this->SetFogMultiplier(NewFogMultiplier);
			
		}
		static void SetSunMultiplier(UAtmosphericFogComponent* _this,float NewSunMultiplier)
		{
			_this->SetSunMultiplier(NewSunMultiplier);
			
		}
		static void SetDefaultLightColor(UAtmosphericFogComponent* _this,FLinearColor* NewLightColor)
		{
			_this->SetDefaultLightColor(*NewLightColor);
			
		}
		static void SetDefaultBrightness(UAtmosphericFogComponent* _this,float NewBrightness)
		{
			_this->SetDefaultBrightness(NewBrightness);
			
		}
		static UClass* StaticClass(){return UAtmosphericFogComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetPrecomputeParams",(const void*)SetPrecomputeParams);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::DisableGroundScattering",(const void*)DisableGroundScattering);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::DisableSunDisk",(const void*)DisableSunDisk);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetDistanceOffset",(const void*)SetDistanceOffset);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetStartDistance",(const void*)SetStartDistance);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetAltitudeScale",(const void*)SetAltitudeScale);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetDistanceScale",(const void*)SetDistanceScale);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetDensityOffset",(const void*)SetDensityOffset);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetDensityMultiplier",(const void*)SetDensityMultiplier);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetFogMultiplier",(const void*)SetFogMultiplier);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetSunMultiplier",(const void*)SetSunMultiplier);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetDefaultLightColor",(const void*)SetDefaultLightColor);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::SetDefaultBrightness",(const void*)SetDefaultBrightness);
			mono_add_internal_call("UnrealEngine.UAtmosphericFogComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
