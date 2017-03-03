#pragma once

namespace UnrealEngine
{
	class _UWrapBoxSlot
	{
		static void SetVerticalAlignment(UWrapBoxSlot* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UWrapBoxSlot* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetFillSpanWhenLessThan(UWrapBoxSlot* _this,float InFillSpanWhenLessThan)
		{
			_this->SetFillSpanWhenLessThan(InFillSpanWhenLessThan);
			
		}
		static void SetFillEmptySpace(UWrapBoxSlot* _this,int32 InbFillEmptySpace)
		{
			_this->SetFillEmptySpace(InbFillEmptySpace>0?true:false);
			
		}
		static void SetPadding(UWrapBoxSlot* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UWrapBoxSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWrapBoxSlot::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UWrapBoxSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UWrapBoxSlot::SetFillSpanWhenLessThan",(const void*)SetFillSpanWhenLessThan);
			mono_add_internal_call("UnrealEngine.UWrapBoxSlot::SetFillEmptySpace",(const void*)SetFillEmptySpace);
			mono_add_internal_call("UnrealEngine.UWrapBoxSlot::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UWrapBoxSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
