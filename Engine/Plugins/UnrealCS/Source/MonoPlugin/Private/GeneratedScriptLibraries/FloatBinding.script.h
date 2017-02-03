#pragma once

namespace UnrealEngine
{
	class _UFloatBinding
	{
		static float GetValue(UFloatBinding* _this)
		{
			float ___ret = _this->GetValue();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UFloatBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UFloatBinding::GetValue",(const void*)GetValue);
			mono_add_internal_call("UnrealEngine.UFloatBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
