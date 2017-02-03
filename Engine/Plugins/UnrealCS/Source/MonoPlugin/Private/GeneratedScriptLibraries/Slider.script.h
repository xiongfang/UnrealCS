#pragma once

namespace UnrealEngine
{
	class _USlider
	{
		static void SetSliderHandleColor(USlider* _this,FLinearColor* InValue)
		{
			_this->SetSliderHandleColor(*InValue);
			
		}
		static void SetSliderBarColor(USlider* _this,FLinearColor* InValue)
		{
			_this->SetSliderBarColor(*InValue);
			
		}
		static void SetStepSize(USlider* _this,float InValue)
		{
			_this->SetStepSize(InValue);
			
		}
		static void SetLocked(USlider* _this,int32 InValue)
		{
			_this->SetLocked(InValue>0?true:false);
			
		}
		static void SetIndentHandle(USlider* _this,int32 InValue)
		{
			_this->SetIndentHandle(InValue>0?true:false);
			
		}
		static void SetValue(USlider* _this,float InValue)
		{
			_this->SetValue(InValue);
			
		}
		static float GetValue(USlider* _this)
		{
			float ___ret = _this->GetValue();
			return ___ret;
			
		}
		static UClass* StaticClass(){return USlider::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlider::SetSliderHandleColor",(const void*)SetSliderHandleColor);
			mono_add_internal_call("UnrealEngine.USlider::SetSliderBarColor",(const void*)SetSliderBarColor);
			mono_add_internal_call("UnrealEngine.USlider::SetStepSize",(const void*)SetStepSize);
			mono_add_internal_call("UnrealEngine.USlider::SetLocked",(const void*)SetLocked);
			mono_add_internal_call("UnrealEngine.USlider::SetIndentHandle",(const void*)SetIndentHandle);
			mono_add_internal_call("UnrealEngine.USlider::SetValue",(const void*)SetValue);
			mono_add_internal_call("UnrealEngine.USlider::GetValue",(const void*)GetValue);
			mono_add_internal_call("UnrealEngine.USlider::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
