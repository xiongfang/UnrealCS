using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UScrollBox:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScrollWidgetIntoView(IntPtr _this,IntPtr WidgetToFind,int AnimateScroll);
/// <summary>Scrolls the ScrollBox to the widget during the next layout pass.</summary>
public  void ScrollWidgetIntoView(UWidget WidgetToFind,bool AnimateScroll=true)
{
	CheckIsValid();
	ScrollWidgetIntoView(_this.Get(),WidgetToFind,AnimateScroll?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScrollToEnd(IntPtr _this);
/// <summary>Scrolls the ScrollBox to the bottom instantly during the next layout pass.</summary>
public  void ScrollToEnd()
{
	CheckIsValid();
	ScrollToEnd(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScrollToStart(IntPtr _this);
/// <summary>Scrolls the ScrollBox to the top instantly</summary>
public  void ScrollToStart()
{
	CheckIsValid();
	ScrollToStart(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScrollOffset(IntPtr _this);
/// <summary>Gets the scroll offset of the scrollbox in Slate Units.</summary>
public  float GetScrollOffset()
{
	CheckIsValid();
	float ___ret = GetScrollOffset(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetScrollOffset(IntPtr _this,float NewScrollOffset);
/// <summary>
/// Updates the scroll offset of the scrollbox.
/// @param NewScrollOffset is in Slate Units.
/// </summary>
public  void SetScrollOffset(float NewScrollOffset)
{
	CheckIsValid();
	SetScrollOffset(_this.Get(),NewScrollOffset);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
