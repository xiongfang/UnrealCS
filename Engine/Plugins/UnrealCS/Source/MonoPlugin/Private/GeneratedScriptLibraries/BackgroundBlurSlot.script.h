#pragma once

namespace UnrealEngine
{
	class _UBackgroundBlurSlot
	{
		static void SetVerticalAlignment(UBackgroundBlurSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UBackgroundBlurSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetPadding(UBackgroundBlurSlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UBackgroundBlurSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBackgroundBlurSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UBackgroundBlurSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UBackgroundBlurSlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UBackgroundBlurSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
