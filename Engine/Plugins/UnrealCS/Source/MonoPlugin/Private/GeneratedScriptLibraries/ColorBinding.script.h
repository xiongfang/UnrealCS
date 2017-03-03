#pragma once

namespace UnrealEngine
{
	class _UColorBinding
	{
		static FLinearColor GetLinearValue(UColorBinding* _this)
		{
			FLinearColor ___ret = _this->GetLinearValue();
			return ___ret;
			
		}
		static FSlateColor GetSlateValue(UColorBinding* _this)
		{
			FSlateColor ___ret = _this->GetSlateValue();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UColorBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UColorBinding::GetLinearValue",(const void*)GetLinearValue);
			mono_add_internal_call("UnrealEngine.UColorBinding::GetSlateValue",(const void*)GetSlateValue);
			mono_add_internal_call("UnrealEngine.UColorBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
