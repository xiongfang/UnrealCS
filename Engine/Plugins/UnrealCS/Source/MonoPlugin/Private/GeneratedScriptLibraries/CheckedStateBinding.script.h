#pragma once

namespace UnrealEngine
{
	class _UCheckedStateBinding
	{
		static int32 GetValue(UCheckedStateBinding* _this)
		{
			ECheckBoxState ___ret = _this->GetValue();
			return (int)___ret;
			
		}
		static UClass* StaticClass(){return UCheckedStateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCheckedStateBinding::GetValue",(const void*)GetValue);
			mono_add_internal_call("UnrealEngine.UCheckedStateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
