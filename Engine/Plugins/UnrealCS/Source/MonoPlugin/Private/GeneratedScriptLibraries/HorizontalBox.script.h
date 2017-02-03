#pragma once

namespace UnrealEngine
{
	class _UHorizontalBox
	{
		static UHorizontalBoxSlot* AddChildToHorizontalBox(UHorizontalBox* _this,UWidget* Content)
		{
			UHorizontalBoxSlot* ___ret = _this->AddChildToHorizontalBox(Content);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UHorizontalBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHorizontalBox::AddChildToHorizontalBox",(const void*)AddChildToHorizontalBox);
			mono_add_internal_call("UnrealEngine.UHorizontalBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
