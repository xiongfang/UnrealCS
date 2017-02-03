#pragma once

namespace UnrealEngine
{
	class _UContentWidget
	{
		static UPanelSlot* SetContent(UContentWidget* _this,UWidget* Content)
		{
			UPanelSlot* ___ret = _this->SetContent(Content);
			return ___ret;
			
		}
		static UPanelSlot* GetContentSlot(UContentWidget* _this)
		{
			UPanelSlot* ___ret = _this->GetContentSlot();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UContentWidget::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UContentWidget::SetContent",(const void*)SetContent);
			mono_add_internal_call("UnrealEngine.UContentWidget::GetContentSlot",(const void*)GetContentSlot);
			mono_add_internal_call("UnrealEngine.UContentWidget::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
