#pragma once

namespace UnrealEngine
{
	class _UCurveBase
	{
		static void GetValueRange(UCurveBase* _this,float* MinValue,float* MaxValue)
		{
			_this->GetValueRange(*MinValue,*MaxValue);
			
		}
		static void GetTimeRange(UCurveBase* _this,float* MinTime,float* MaxTime)
		{
			_this->GetTimeRange(*MinTime,*MaxTime);
			
		}
		static UClass* StaticClass(){return UCurveBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCurveBase::GetValueRange",(const void*)GetValueRange);
			mono_add_internal_call("UnrealEngine.UCurveBase::GetTimeRange",(const void*)GetTimeRange);
			mono_add_internal_call("UnrealEngine.UCurveBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
