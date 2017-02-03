#pragma once

namespace UnrealEngine
{
	class _UBrushBinding
	{
		static FSlateBrush GetValue(UBrushBinding* _this)
		{
			FSlateBrush ___ret = _this->GetValue();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UBrushBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBrushBinding::GetValue",(const void*)GetValue);
			mono_add_internal_call("UnrealEngine.UBrushBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
