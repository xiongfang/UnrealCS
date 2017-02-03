#pragma once

namespace UnrealEngine
{
	class _UWindowTitleBarAreaSlot
	{
		static void SetVerticalAlignment(UWindowTitleBarAreaSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UWindowTitleBarAreaSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetPadding(UWindowTitleBarAreaSlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UWindowTitleBarAreaSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWindowTitleBarAreaSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UWindowTitleBarAreaSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UWindowTitleBarAreaSlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UWindowTitleBarAreaSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
