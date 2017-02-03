#pragma once

namespace UnrealEngine
{
	class _UVerticalBox
	{
		static UVerticalBoxSlot* AddChildToVerticalBox(UVerticalBox* _this,UWidget* Content)
		{
			UVerticalBoxSlot* ___ret = _this->AddChildToVerticalBox(Content);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UVerticalBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVerticalBox::AddChildToVerticalBox",(const void*)AddChildToVerticalBox);
			mono_add_internal_call("UnrealEngine.UVerticalBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
