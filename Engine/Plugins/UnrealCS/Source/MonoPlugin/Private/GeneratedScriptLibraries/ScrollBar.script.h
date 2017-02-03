#pragma once

namespace UnrealEngine
{
	class _UScrollBar
	{
		static void SetState(UScrollBar* _this,float InOffsetFraction,float InThumbSizeFraction)
		{
			_this->SetState(InOffsetFraction,InThumbSizeFraction);
			
		}
		static UClass* StaticClass(){return UScrollBar::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UScrollBar::SetState",(const void*)SetState);
			mono_add_internal_call("UnrealEngine.UScrollBar::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
