#pragma once

namespace UnrealEngine
{
	class _UVisibilityBinding
	{
		static int32 GetValue(UVisibilityBinding* _this)
		{
			ESlateVisibility ___ret = _this->GetValue();
			return (int)___ret;
			
		}
		static UClass* StaticClass(){return UVisibilityBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVisibilityBinding::GetValue",(const void*)GetValue);
			mono_add_internal_call("UnrealEngine.UVisibilityBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
