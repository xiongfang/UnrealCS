#pragma once

namespace UnrealEngine
{
	class _AAudioVolume
	{
		static void SetInteriorSettings(AAudioVolume* _this,FInteriorSettings* NewInteriorSettings)
		{
			_this->SetInteriorSettings(*NewInteriorSettings);
			
		}
		static void SetReverbSettings(AAudioVolume* _this,FReverbSettings* NewReverbSettings)
		{
			_this->SetReverbSettings(*NewReverbSettings);
			
		}
		static void SetEnabled(AAudioVolume* _this,int32 bNewEnabled)
		{
			_this->SetEnabled(bNewEnabled>0?true:false);
			
		}
		static void SetPriority(AAudioVolume* _this,float NewPriority)
		{
			_this->SetPriority(NewPriority);
			
		}
		static UClass* StaticClass(){return AAudioVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AAudioVolume::SetInteriorSettings",(const void*)SetInteriorSettings);
			mono_add_internal_call("UnrealEngine.AAudioVolume::SetReverbSettings",(const void*)SetReverbSettings);
			mono_add_internal_call("UnrealEngine.AAudioVolume::SetEnabled",(const void*)SetEnabled);
			mono_add_internal_call("UnrealEngine.AAudioVolume::SetPriority",(const void*)SetPriority);
			mono_add_internal_call("UnrealEngine.AAudioVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
