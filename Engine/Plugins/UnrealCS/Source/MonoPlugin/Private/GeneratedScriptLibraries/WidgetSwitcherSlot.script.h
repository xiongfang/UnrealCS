#pragma once

namespace UnrealEngine
{
	class _UWidgetSwitcherSlot
	{
		static void SetVerticalAlignment(UWidgetSwitcherSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UWidgetSwitcherSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetPadding(UWidgetSwitcherSlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UWidgetSwitcherSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetSwitcherSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UWidgetSwitcherSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UWidgetSwitcherSlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UWidgetSwitcherSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
