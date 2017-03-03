#pragma once

namespace UnrealEngine
{
	class _UCurveLinearColor
	{
		static FLinearColor GetLinearColorValue(UCurveLinearColor* _this,float InTime)
		{
			FLinearColor ___ret = _this->GetLinearColorValue(InTime);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UCurveLinearColor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCurveLinearColor::GetLinearColorValue",(const void*)GetLinearColorValue);
			mono_add_internal_call("UnrealEngine.UCurveLinearColor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
