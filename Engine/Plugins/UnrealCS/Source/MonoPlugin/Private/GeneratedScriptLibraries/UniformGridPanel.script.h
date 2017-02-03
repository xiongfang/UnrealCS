#pragma once

namespace UnrealEngine
{
	class _UUniformGridPanel
	{
		static UUniformGridSlot* AddChildToUniformGrid(UUniformGridPanel* _this,UWidget* Content)
		{
			UUniformGridSlot* ___ret = _this->AddChildToUniformGrid(Content);
			return ___ret;
			
		}
		static void SetMinDesiredSlotHeight(UUniformGridPanel* _this,float InMinDesiredSlotHeight)
		{
			_this->SetMinDesiredSlotHeight(InMinDesiredSlotHeight);
			
		}
		static void SetMinDesiredSlotWidth(UUniformGridPanel* _this,float InMinDesiredSlotWidth)
		{
			_this->SetMinDesiredSlotWidth(InMinDesiredSlotWidth);
			
		}
		static void SetSlotPadding(UUniformGridPanel* _this,FMargin* InSlotPadding)
		{
			_this->SetSlotPadding(*InSlotPadding);
			
		}
		static UClass* StaticClass(){return UUniformGridPanel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UUniformGridPanel::AddChildToUniformGrid",(const void*)AddChildToUniformGrid);
			mono_add_internal_call("UnrealEngine.UUniformGridPanel::SetMinDesiredSlotHeight",(const void*)SetMinDesiredSlotHeight);
			mono_add_internal_call("UnrealEngine.UUniformGridPanel::SetMinDesiredSlotWidth",(const void*)SetMinDesiredSlotWidth);
			mono_add_internal_call("UnrealEngine.UUniformGridPanel::SetSlotPadding",(const void*)SetSlotPadding);
			mono_add_internal_call("UnrealEngine.UUniformGridPanel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
