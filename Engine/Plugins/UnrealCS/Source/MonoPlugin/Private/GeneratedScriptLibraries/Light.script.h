#pragma once

namespace UnrealEngine
{
	class _ALight
	{
		static void OnRep_bEnabled(ALight* _this)
		{
			_this->OnRep_bEnabled();
			
		}
		static UClass* StaticClass(){return ALight::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ALight::OnRep_bEnabled",(const void*)OnRep_bEnabled);
			mono_add_internal_call("UnrealEngine.ALight::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
