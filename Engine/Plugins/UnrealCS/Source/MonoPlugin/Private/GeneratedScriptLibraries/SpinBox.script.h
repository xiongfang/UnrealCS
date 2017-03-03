#pragma once

namespace UnrealEngine
{
	class _USpinBox
	{
		static void SetForegroundColor(USpinBox* _this,FSlateColor* InForegroundColor)
		{
			_this->SetForegroundColor(*InForegroundColor);
			
		}
		static void ClearMaxSliderValue(USpinBox* _this)
		{
			_this->ClearMaxSliderValue();
			
		}
		static void SetMaxSliderValue(USpinBox* _this,float NewValue)
		{
			_this->SetMaxSliderValue(NewValue);
			
		}
		static float GetMaxSliderValue(USpinBox* _this)
		{
			float ___ret = _this->GetMaxSliderValue();
			return ___ret;
			
		}
		static void ClearMinSliderValue(USpinBox* _this)
		{
			_this->ClearMinSliderValue();
			
		}
		static void SetMinSliderValue(USpinBox* _this,float NewValue)
		{
			_this->SetMinSliderValue(NewValue);
			
		}
		static float GetMinSliderValue(USpinBox* _this)
		{
			float ___ret = _this->GetMinSliderValue();
			return ___ret;
			
		}
		static void ClearMaxValue(USpinBox* _this)
		{
			_this->ClearMaxValue();
			
		}
		static void SetMaxValue(USpinBox* _this,float NewValue)
		{
			_this->SetMaxValue(NewValue);
			
		}
		static float GetMaxValue(USpinBox* _this)
		{
			float ___ret = _this->GetMaxValue();
			return ___ret;
			
		}
		static void ClearMinValue(USpinBox* _this)
		{
			_this->ClearMinValue();
			
		}
		static void SetMinValue(USpinBox* _this,float NewValue)
		{
			_this->SetMinValue(NewValue);
			
		}
		static float GetMinValue(USpinBox* _this)
		{
			float ___ret = _this->GetMinValue();
			return ___ret;
			
		}
		static void SetValue(USpinBox* _this,float NewValue)
		{
			_this->SetValue(NewValue);
			
		}
		static float GetValue(USpinBox* _this)
		{
			float ___ret = _this->GetValue();
			return ___ret;
			
		}
		static UClass* StaticClass(){return USpinBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USpinBox::SetForegroundColor",(const void*)SetForegroundColor);
			mono_add_internal_call("UnrealEngine.USpinBox::ClearMaxSliderValue",(const void*)ClearMaxSliderValue);
			mono_add_internal_call("UnrealEngine.USpinBox::SetMaxSliderValue",(const void*)SetMaxSliderValue);
			mono_add_internal_call("UnrealEngine.USpinBox::GetMaxSliderValue",(const void*)GetMaxSliderValue);
			mono_add_internal_call("UnrealEngine.USpinBox::ClearMinSliderValue",(const void*)ClearMinSliderValue);
			mono_add_internal_call("UnrealEngine.USpinBox::SetMinSliderValue",(const void*)SetMinSliderValue);
			mono_add_internal_call("UnrealEngine.USpinBox::GetMinSliderValue",(const void*)GetMinSliderValue);
			mono_add_internal_call("UnrealEngine.USpinBox::ClearMaxValue",(const void*)ClearMaxValue);
			mono_add_internal_call("UnrealEngine.USpinBox::SetMaxValue",(const void*)SetMaxValue);
			mono_add_internal_call("UnrealEngine.USpinBox::GetMaxValue",(const void*)GetMaxValue);
			mono_add_internal_call("UnrealEngine.USpinBox::ClearMinValue",(const void*)ClearMinValue);
			mono_add_internal_call("UnrealEngine.USpinBox::SetMinValue",(const void*)SetMinValue);
			mono_add_internal_call("UnrealEngine.USpinBox::GetMinValue",(const void*)GetMinValue);
			mono_add_internal_call("UnrealEngine.USpinBox::SetValue",(const void*)SetValue);
			mono_add_internal_call("UnrealEngine.USpinBox::GetValue",(const void*)GetValue);
			mono_add_internal_call("UnrealEngine.USpinBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
