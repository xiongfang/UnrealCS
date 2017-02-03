using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public partial class UWidgetTree
    {
        /** Finds the widget in the tree by name. */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static IntPtr FindWidget(IntPtr _This, string Name);

        public UWidget FindWidget(string Name)
        {
            CheckIsValid();
            return new UWidget() { _this = FindWidget(this, Name) };
        }

        public T FindWidget<T>(string Name) where T:UWidget,new()
        {
            return Cast<T>(FindWidget(Name));
        }

        /** Removes the widget from the hierarchy and all sub widgets. */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static bool RemoveWidget(IntPtr _This, IntPtr Widget);

        public bool RemoveWidget(UWidget Widget)
        {
            CheckIsValid();
            return RemoveWidget(this, Widget);
        }

        /** Gets the parent widget of a given widget, and potentially the child index. */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static IntPtr FindWidgetParent(IntPtr _This, IntPtr Widget, out int OutChildIndex);

        public UPanelWidget FindWidgetParent(UWidget Widget, out int OutChildIndex)
        {
            return new UPanelWidget() { _this = FindWidgetParent(this,Widget, out OutChildIndex) };
        }

        /** Gathers all the widgets in the tree recursively */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void GetAllWidgets(IntPtr _This, out IntPtr[] Widgets);

        public void GetAllWidgets(out UWidget[] Widgets)
        {
            IntPtr[] OutWidgets;
            GetAllWidgets(this, out OutWidgets);
            Widgets = MarshalUtil.IntPtrArrayToObjectArray<UWidget>(OutWidgets);
        }

    }
}
