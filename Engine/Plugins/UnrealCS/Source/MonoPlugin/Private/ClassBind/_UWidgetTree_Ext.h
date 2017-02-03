// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
namespace UnrealEngine
{
	class _UWidgetTree_Ext
	{
		/** Finds the widget in the tree by name. */
		static UWidget* FindWidget(UWidgetTree* _This,MonoString* Name)
		{
			return _This->FindWidget(MonoStringToFName(Name));
		}

		/** Removes the widget from the hierarchy and all sub widgets. */
		static bool RemoveWidget(UWidgetTree* _This, UWidget* Widget)
		{
			return _This->RemoveWidget(Widget);
		}

		/** Gets the parent widget of a given widget, and potentially the child index. */
		static UPanelWidget* FindWidgetParent(UWidgetTree* _This, UWidget* Widget, int32* OutChildIndex)
		{
			return _This->FindWidgetParent(Widget, *OutChildIndex);
		}

		/** Gathers all the widgets in the tree recursively */
		static void GetAllWidgets(UWidgetTree* _This,MonoArray** Widgets)
		{
			TArray<UWidget*> WidgetsTemp;
			_This->GetAllWidgets(WidgetsTemp);
			*Widgets = TArrayToMonoArray(WidgetsTemp,"IntPtr");
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetTree::FindWidget", (const void*)FindWidget);
			mono_add_internal_call("UnrealEngine.UWidgetTree::RemoveWidget", (const void*)RemoveWidget);
			mono_add_internal_call("UnrealEngine.UWidgetTree::FindWidgetParent", (const void*)FindWidgetParent);
			mono_add_internal_call("UnrealEngine.UWidgetTree::GetAllWidgets", (const void*)GetAllWidgets);
		}
	};
}
