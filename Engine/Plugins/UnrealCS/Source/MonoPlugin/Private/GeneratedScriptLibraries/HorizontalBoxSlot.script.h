#pragma once

namespace UnrealEngine
{
	class _UHorizontalBoxSlot
	{
		static void SetVerticalAlignment(UHorizontalBoxSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UHorizontalBoxSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetSize(UHorizontalBoxSlot* _this,FSlateChildSize* InSize)
		{
			_this->SetSize(*InSize);
			
		}
		static void SetPadding(UHorizontalBoxSlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UHorizontalBoxSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHorizontalBoxSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UHorizontalBoxSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UHorizontalBoxSlot::SetSize",(const void*)SetSize);
			mono_add_internal_call("UnrealEngine.UHorizontalBoxSlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UHorizontalBoxSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
