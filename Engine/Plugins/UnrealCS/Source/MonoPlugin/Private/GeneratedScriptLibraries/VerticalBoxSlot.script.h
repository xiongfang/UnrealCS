#pragma once

namespace UnrealEngine
{
	class _UVerticalBoxSlot
	{
		static void SetVerticalAlignment(UVerticalBoxSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UVerticalBoxSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetSize(UVerticalBoxSlot* _this,FSlateChildSize* InSize)
		{
			_this->SetSize(*InSize);
			
		}
		static void SetPadding(UVerticalBoxSlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UVerticalBoxSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVerticalBoxSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UVerticalBoxSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UVerticalBoxSlot::SetSize",(const void*)SetSize);
			mono_add_internal_call("UnrealEngine.UVerticalBoxSlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UVerticalBoxSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
