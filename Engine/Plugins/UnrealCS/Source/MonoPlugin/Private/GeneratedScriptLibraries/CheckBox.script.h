#pragma once

namespace UnrealEngine
{
	class _UCheckBox
	{
		static void SetCheckedState(UCheckBox* _this,int32 InCheckedState)
		{
			_this->SetCheckedState((TEnumAsByte<ECheckBoxState>)InCheckedState);
			
		}
		static void SetIsChecked(UCheckBox* _this,int32 InIsChecked)
		{
			_this->SetIsChecked(InIsChecked>0?true:false);
			
		}
		static int32 GetCheckedState(UCheckBox* _this)
		{
			TEnumAsByte<ECheckBoxState> ___ret = _this->GetCheckedState();
			return (int)___ret.GetValue();
			
		}
		static int32 IsChecked(UCheckBox* _this)
		{
			bool ___ret = _this->IsChecked();
			return ___ret?1:0;
			
		}
		static int32 IsPressed(UCheckBox* _this)
		{
			bool ___ret = _this->IsPressed();
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UCheckBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCheckBox::SetCheckedState",(const void*)SetCheckedState);
			mono_add_internal_call("UnrealEngine.UCheckBox::SetIsChecked",(const void*)SetIsChecked);
			mono_add_internal_call("UnrealEngine.UCheckBox::GetCheckedState",(const void*)GetCheckedState);
			mono_add_internal_call("UnrealEngine.UCheckBox::IsChecked",(const void*)IsChecked);
			mono_add_internal_call("UnrealEngine.UCheckBox::IsPressed",(const void*)IsPressed);
			mono_add_internal_call("UnrealEngine.UCheckBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
