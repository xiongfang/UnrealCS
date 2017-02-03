#pragma once

namespace UnrealEngine
{
	class _UOverlaySlot
	{
		static void SetVerticalAlignment(UOverlaySlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UOverlaySlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetPadding(UOverlaySlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UOverlaySlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UOverlaySlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UOverlaySlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UOverlaySlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UOverlaySlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
