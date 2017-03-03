#pragma once

namespace UnrealEngine
{
	class _UWrapBox
	{
		static UWrapBoxSlot* AddChildWrapBox(UWrapBox* _this,UWidget* Content)
		{
			UWrapBoxSlot* ___ret = _this->AddChildWrapBox(Content);
			return ___ret;
			
		}
		static void SetInnerSlotPadding(UWrapBox* _this,FVector2D* InPadding)
		{
			_this->SetInnerSlotPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UWrapBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWrapBox::AddChildWrapBox",(const void*)AddChildWrapBox);
			mono_add_internal_call("UnrealEngine.UWrapBox::SetInnerSlotPadding",(const void*)SetInnerSlotPadding);
			mono_add_internal_call("UnrealEngine.UWrapBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
