#pragma once

namespace UnrealEngine
{
	class _UMouseCursorBinding
	{
		static int32 GetValue(UMouseCursorBinding* _this)
		{
			TEnumAsByte<EMouseCursor::Type> ___ret = _this->GetValue();
			return (int)___ret.GetValue();
			
		}
		static UClass* StaticClass(){return UMouseCursorBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMouseCursorBinding::GetValue",(const void*)GetValue);
			mono_add_internal_call("UnrealEngine.UMouseCursorBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
