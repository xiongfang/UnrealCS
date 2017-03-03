#pragma once

namespace UnrealEngine
{
	class _UTileView
	{
		static void RequestListRefresh(UTileView* _this)
		{
			_this->RequestListRefresh();
			
		}
		static void SetItemHeight(UTileView* _this,float Height)
		{
			_this->SetItemHeight(Height);
			
		}
		static void SetItemWidth(UTileView* _this,float Width)
		{
			_this->SetItemWidth(Width);
			
		}
		static UClass* StaticClass(){return UTileView::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTileView::RequestListRefresh",(const void*)RequestListRefresh);
			mono_add_internal_call("UnrealEngine.UTileView::SetItemHeight",(const void*)SetItemHeight);
			mono_add_internal_call("UnrealEngine.UTileView::SetItemWidth",(const void*)SetItemWidth);
			mono_add_internal_call("UnrealEngine.UTileView::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
