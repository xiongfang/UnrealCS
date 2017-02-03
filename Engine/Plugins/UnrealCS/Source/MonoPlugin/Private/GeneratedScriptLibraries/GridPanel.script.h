#pragma once

namespace UnrealEngine
{
	class _UGridPanel
	{
		static UGridSlot* AddChildToGrid(UGridPanel* _this,UWidget* Content)
		{
			UGridSlot* ___ret = _this->AddChildToGrid(Content);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UGridPanel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UGridPanel::AddChildToGrid",(const void*)AddChildToGrid);
			mono_add_internal_call("UnrealEngine.UGridPanel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
