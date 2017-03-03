#pragma once

namespace UnrealEngine
{
	class _UWidgetSwitcher
	{
		static UWidget* GetWidgetAtIndex(UWidgetSwitcher* _this,int32 Index)
		{
			UWidget* ___ret = _this->GetWidgetAtIndex(Index);
			return ___ret;
			
		}
		static void SetActiveWidget(UWidgetSwitcher* _this,UWidget* Widget)
		{
			_this->SetActiveWidget(Widget);
			
		}
		static void SetActiveWidgetIndex(UWidgetSwitcher* _this,int32 Index)
		{
			_this->SetActiveWidgetIndex(Index);
			
		}
		static int32 GetActiveWidgetIndex(UWidgetSwitcher* _this)
		{
			int32 ___ret = _this->GetActiveWidgetIndex();
			return ___ret;
			
		}
		static int32 GetNumWidgets(UWidgetSwitcher* _this)
		{
			int32 ___ret = _this->GetNumWidgets();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UWidgetSwitcher::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetSwitcher::GetWidgetAtIndex",(const void*)GetWidgetAtIndex);
			mono_add_internal_call("UnrealEngine.UWidgetSwitcher::SetActiveWidget",(const void*)SetActiveWidget);
			mono_add_internal_call("UnrealEngine.UWidgetSwitcher::SetActiveWidgetIndex",(const void*)SetActiveWidgetIndex);
			mono_add_internal_call("UnrealEngine.UWidgetSwitcher::GetActiveWidgetIndex",(const void*)GetActiveWidgetIndex);
			mono_add_internal_call("UnrealEngine.UWidgetSwitcher::GetNumWidgets",(const void*)GetNumWidgets);
			mono_add_internal_call("UnrealEngine.UWidgetSwitcher::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
