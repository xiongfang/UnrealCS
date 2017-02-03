#pragma once

namespace UnrealEngine
{
	class _UCurveVector
	{
		static FVector GetVectorValue(UCurveVector* _this,float InTime)
		{
			FVector ___ret = _this->GetVectorValue(InTime);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UCurveVector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCurveVector::GetVectorValue",(const void*)GetVectorValue);
			mono_add_internal_call("UnrealEngine.UCurveVector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
