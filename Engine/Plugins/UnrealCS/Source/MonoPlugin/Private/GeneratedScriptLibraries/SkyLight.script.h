#pragma once

namespace UnrealEngine
{
	class _ASkyLight
	{
		static void OnRep_bEnabled(ASkyLight* _this)
		{
			_this->OnRep_bEnabled();
			
		}
		static UClass* StaticClass(){return ASkyLight::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASkyLight::OnRep_bEnabled",(const void*)OnRep_bEnabled);
			mono_add_internal_call("UnrealEngine.ASkyLight::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
