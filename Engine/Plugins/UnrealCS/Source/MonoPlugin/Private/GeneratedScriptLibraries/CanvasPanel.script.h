#pragma once

namespace UnrealEngine
{
	class _UCanvasPanel
	{
		static UCanvasPanelSlot* AddChildToCanvas(UCanvasPanel* _this,UWidget* Content)
		{
			UCanvasPanelSlot* ___ret = _this->AddChildToCanvas(Content);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UCanvasPanel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCanvasPanel::AddChildToCanvas",(const void*)AddChildToCanvas);
			mono_add_internal_call("UnrealEngine.UCanvasPanel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
