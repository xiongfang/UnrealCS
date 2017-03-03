#pragma once

namespace UnrealEngine
{
	class _UOverlay
	{
		static UOverlaySlot* AddChildToOverlay(UOverlay* _this,UWidget* Content)
		{
			UOverlaySlot* ___ret = _this->AddChildToOverlay(Content);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UOverlay::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UOverlay::AddChildToOverlay",(const void*)AddChildToOverlay);
			mono_add_internal_call("UnrealEngine.UOverlay::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
