using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMenuAnchor:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasOpenSubMenus(IntPtr _this);
/// <summary>@return Whether this menu has open submenus</summary>
public  bool HasOpenSubMenus()
{
	CheckIsValid();
	int ___ret = HasOpenSubMenus(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetMenuPosition(IntPtr _this);
/// <summary>@return The current menu position</summary>
public  FVector2D GetMenuPosition()
{
	CheckIsValid();
	FVector2D ___ret = GetMenuPosition(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ShouldOpenDueToClick(IntPtr _this);
/// <summary>
/// @return true if we should open the menu due to a click. Sometimes we should not, if
/// the same MouseDownEvent that just closed the menu is about to re-open it because it
/// happens to land on the button.
/// </summary>
public  bool ShouldOpenDueToClick()
{
	CheckIsValid();
	int ___ret = ShouldOpenDueToClick(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsOpen(IntPtr _this);
/// <summary>@return true if the popup is open; false otherwise.</summary>
public  bool IsOpen()
{
	CheckIsValid();
	int ___ret = IsOpen(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Close(IntPtr _this);
/// <summary>Closes the menu if it is currently open.</summary>
public  void Close()
{
	CheckIsValid();
	Close(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Open(IntPtr _this,int bFocusMenu);
/// <summary>Opens the menu if it is not already open</summary>
public  void Open(bool bFocusMenu)
{
	CheckIsValid();
	Open(_this.Get(),bFocusMenu?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleOpen(IntPtr _this,int bFocusOnOpen);
/// <summary>
/// Toggles the menus open state.
/// @param bFocusOnOpen  Should we focus the popup as soon as it opens?
/// </summary>
public  void ToggleOpen(bool bFocusOnOpen)
{
	CheckIsValid();
	ToggleOpen(_this.Get(),bFocusOnOpen?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
