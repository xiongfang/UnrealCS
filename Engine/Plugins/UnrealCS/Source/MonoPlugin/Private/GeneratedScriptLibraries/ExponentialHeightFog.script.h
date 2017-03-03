#pragma once

namespace UnrealEngine
{
	class _AExponentialHeightFog
	{
		static void OnRep_bEnabled(AExponentialHeightFog* _this)
		{
			_this->OnRep_bEnabled();
			
		}
		static UClass* StaticClass(){return AExponentialHeightFog::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AExponentialHeightFog::OnRep_bEnabled",(const void*)OnRep_bEnabled);
			mono_add_internal_call("UnrealEngine.AExponentialHeightFog::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
