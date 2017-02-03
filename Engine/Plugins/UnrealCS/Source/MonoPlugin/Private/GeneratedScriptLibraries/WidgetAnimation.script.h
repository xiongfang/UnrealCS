#pragma once

namespace UnrealEngine
{
	class _UWidgetAnimation
	{
		static float GetEndTime(UWidgetAnimation* _this)
		{
			float ___ret = _this->GetEndTime();
			return ___ret;
			
		}
		static float GetStartTime(UWidgetAnimation* _this)
		{
			float ___ret = _this->GetStartTime();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UWidgetAnimation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetAnimation::GetEndTime",(const void*)GetEndTime);
			mono_add_internal_call("UnrealEngine.UWidgetAnimation::GetStartTime",(const void*)GetStartTime);
			mono_add_internal_call("UnrealEngine.UWidgetAnimation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
