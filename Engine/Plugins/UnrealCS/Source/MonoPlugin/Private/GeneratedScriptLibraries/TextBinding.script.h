#pragma once

namespace UnrealEngine
{
	class _UTextBinding
	{
		static MonoString* GetStringValue(UTextBinding* _this)
		{
			FString ___ret = _this->GetStringValue();
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetTextValue(UTextBinding* _this)
		{
			FText ___ret = _this->GetTextValue();
			return FStringToMonoString(___ret.ToString());
			
		}
		static UClass* StaticClass(){return UTextBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextBinding::GetStringValue",(const void*)GetStringValue);
			mono_add_internal_call("UnrealEngine.UTextBinding::GetTextValue",(const void*)GetTextValue);
			mono_add_internal_call("UnrealEngine.UTextBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
