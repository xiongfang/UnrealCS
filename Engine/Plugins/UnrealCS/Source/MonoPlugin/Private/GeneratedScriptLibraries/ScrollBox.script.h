#pragma once

namespace UnrealEngine
{
	class _UScrollBox
	{
		static void ScrollWidgetIntoView(UScrollBox* _this,UWidget* WidgetToFind,int32 AnimateScroll)
		{
			_this->ScrollWidgetIntoView(WidgetToFind,AnimateScroll>0?true:false);
			
		}
		static void ScrollToEnd(UScrollBox* _this)
		{
			_this->ScrollToEnd();
			
		}
		static void ScrollToStart(UScrollBox* _this)
		{
			_this->ScrollToStart();
			
		}
		static float GetScrollOffset(UScrollBox* _this)
		{
			float ___ret = _this->GetScrollOffset();
			return ___ret;
			
		}
		static void SetScrollOffset(UScrollBox* _this,float NewScrollOffset)
		{
			_this->SetScrollOffset(NewScrollOffset);
			
		}
		static UClass* StaticClass(){return UScrollBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UScrollBox::ScrollWidgetIntoView",(const void*)ScrollWidgetIntoView);
			mono_add_internal_call("UnrealEngine.UScrollBox::ScrollToEnd",(const void*)ScrollToEnd);
			mono_add_internal_call("UnrealEngine.UScrollBox::ScrollToStart",(const void*)ScrollToStart);
			mono_add_internal_call("UnrealEngine.UScrollBox::GetScrollOffset",(const void*)GetScrollOffset);
			mono_add_internal_call("UnrealEngine.UScrollBox::SetScrollOffset",(const void*)SetScrollOffset);
			mono_add_internal_call("UnrealEngine.UScrollBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
