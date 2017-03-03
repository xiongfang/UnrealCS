#pragma once

namespace UnrealEngine
{
	class _UScaleBoxSlot
	{
		static void SetVerticalAlignment(UScaleBoxSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UScaleBoxSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetPadding(UScaleBoxSlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UScaleBoxSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UScaleBoxSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UScaleBoxSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UScaleBoxSlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UScaleBoxSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
