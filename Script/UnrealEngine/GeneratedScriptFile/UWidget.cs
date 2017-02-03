using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidget:UVisual 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveFromParent(IntPtr _this);
/// <summary>
/// Removes the widget from its parent widget.  If this widget was added to the player's screen or the viewport
/// it will also be removed from those containers.
/// </summary>
public  void RemoveFromParent()
{
	CheckIsValid();
	RemoveFromParent(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetParent(IntPtr _this);
/// <summary>Gets the parent widget</summary>
public  UPanelWidget GetParent()
{
	CheckIsValid();
	IntPtr ___ret = GetParent(_this.Get());
	if(___ret==IntPtr.Zero) return null; UPanelWidget ___ret2= new UPanelWidget(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetDesiredSize(IntPtr _this);
/// <summary>
/// Gets the widgets desired size.
/// NOTE: The underlying Slate widget must exist and be valid, also at least one pre-pass must
///       have occurred before this value will be of any use.
/// @return The widget's desired size
/// </summary>
public  FVector2D GetDesiredSize()
{
	CheckIsValid();
	FVector2D ___ret = GetDesiredSize(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void InvalidateLayoutAndVolatility(IntPtr _this);
/// <summary>
/// Invalidates the widget from the view of a layout caching widget that may own this widget.
/// will force the owning widget to redraw and cache children on the next paint pass.
/// </summary>
public  void InvalidateLayoutAndVolatility()
{
	CheckIsValid();
	InvalidateLayoutAndVolatility(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ForceLayoutPrepass(IntPtr _this);
/// <summary>
/// Forces a pre-pass.  A pre-pass caches the desired size of the widget hierarchy owned by this widget.
/// One pre-pass is already happens for every widget before Tick occurs.  You only need to perform another
/// pre-pass if you are adding child widgets this frame and want them to immediately be visible this frame.
/// </summary>
public  void ForceLayoutPrepass()
{
	CheckIsValid();
	ForceLayoutPrepass(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUserFocus(IntPtr _this,IntPtr PlayerController);
/// <summary>Sets the focus to this widget for a specific user</summary>
public  void SetUserFocus(APlayerController PlayerController)
{
	CheckIsValid();
	SetUserFocus(_this.Get(),PlayerController);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasUserFocusedDescendants(IntPtr _this,IntPtr PlayerController);
/// <summary>@return true if any descendant widget is focused by a specific user.</summary>
public  bool HasUserFocusedDescendants(APlayerController PlayerController)
{
	CheckIsValid();
	int ___ret = HasUserFocusedDescendants(_this.Get(),PlayerController);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasFocusedDescendants(IntPtr _this);
/// <summary>@return true if any descendant widget is focused by any user.</summary>
public  bool HasFocusedDescendants()
{
	CheckIsValid();
	int ___ret = HasFocusedDescendants(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasAnyUserFocus(IntPtr _this);
/// <summary>@return true if this widget is focused by any user.</summary>
public  bool HasAnyUserFocus()
{
	CheckIsValid();
	int ___ret = HasAnyUserFocus(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasUserFocus(IntPtr _this,IntPtr PlayerController);
/// <summary>@return true if this widget is focused by a specific user.</summary>
public  bool HasUserFocus(APlayerController PlayerController)
{
	CheckIsValid();
	int ___ret = HasUserFocus(_this.Get(),PlayerController);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetKeyboardFocus(IntPtr _this);
/// <summary>Sets the focus to this widget.</summary>
public  void SetKeyboardFocus()
{
	CheckIsValid();
	SetKeyboardFocus(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMouseCapture(IntPtr _this);
/// <summary>
/// Checks to see if this widget is the current mouse captor
/// @return  True if this widget has captured the mouse
/// </summary>
public  bool HasMouseCapture()
{
	CheckIsValid();
	int ___ret = HasMouseCapture(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasKeyboardFocus(IntPtr _this);
/// <summary>
/// Checks to see if this widget currently has the keyboard focus
/// @return  True if this widget has keyboard focus
/// </summary>
public  bool HasKeyboardFocus()
{
	CheckIsValid();
	int ___ret = HasKeyboardFocus(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsHovered(IntPtr _this);
/// <summary>@return true if the widget is currently being hovered by a pointer device</summary>
public  bool IsHovered()
{
	CheckIsValid();
	int ___ret = IsHovered(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ForceVolatile(IntPtr _this,int bForce);
/// <summary>Sets the forced volatility of the widget.</summary>
public  void ForceVolatile(bool bForce)
{
	CheckIsValid();
	ForceVolatile(_this.Get(),bForce?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVisibility(IntPtr _this,int InVisibility);
/// <summary>Sets the visibility of the widget.</summary>
public  void SetVisibility(ESlateVisibility InVisibility)
{
	CheckIsValid();
	SetVisibility(_this.Get(),(int)InVisibility);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetVisibility(IntPtr _this);
/// <summary>Gets the current visibility of the widget.</summary>
public  ESlateVisibility GetVisibility()
{
	CheckIsValid();
	int ___ret = GetVisibility(_this.Get());
	return (ESlateVisibility)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsVisible(IntPtr _this);
/// <summary>@return true if the widget is Visible, HitTestInvisible or SelfHitTestInvisible.</summary>
public  bool IsVisible()
{
	CheckIsValid();
	int ___ret = IsVisible(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetCursor(IntPtr _this);
/// <summary>Resets the cursor to use on the widget, removing any customization for it.</summary>
public  void ResetCursor()
{
	CheckIsValid();
	ResetCursor(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCursor(IntPtr _this,int InCursor);
/// <summary>Sets the cursor to show over the widget.</summary>
public  void SetCursor(EMouseCursor InCursor)
{
	CheckIsValid();
	SetCursor(_this.Get(),(int)InCursor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetToolTip(IntPtr _this,IntPtr Widget);
/// <summary>Sets a custom widget as the tooltip of the widget.</summary>
public  void SetToolTip(UWidget Widget)
{
	CheckIsValid();
	SetToolTip(_this.Get(),Widget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetToolTipText(IntPtr _this,string InToolTipText);
/// <summary>Sets the tooltip text for the widget.</summary>
public  void SetToolTipText(string InToolTipText)
{
	CheckIsValid();
	SetToolTipText(_this.Get(),InToolTipText);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIsEnabled(IntPtr _this,int bInIsEnabled);
/// <summary>Sets the current enabled status of the widget</summary>
public  void SetIsEnabled(bool bInIsEnabled)
{
	CheckIsValid();
	SetIsEnabled(_this.Get(),bInIsEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetIsEnabled(IntPtr _this);
/// <summary>Gets the current enabled status of the widget</summary>
public  bool GetIsEnabled()
{
	CheckIsValid();
	int ___ret = GetIsEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderTransformPivot(IntPtr _this,ref FVector2D Pivot);
public  void SetRenderTransformPivot(FVector2D Pivot)
{
	CheckIsValid();
	SetRenderTransformPivot(_this.Get(),ref Pivot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderTranslation(IntPtr _this,ref FVector2D Translation);
public  void SetRenderTranslation(FVector2D Translation)
{
	CheckIsValid();
	SetRenderTranslation(_this.Get(),ref Translation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderAngle(IntPtr _this,float Angle);
public  void SetRenderAngle(float Angle)
{
	CheckIsValid();
	SetRenderAngle(_this.Get(),Angle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderShear(IntPtr _this,ref FVector2D Shear);
public  void SetRenderShear(FVector2D Shear)
{
	CheckIsValid();
	SetRenderShear(_this.Get(),ref Shear);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderScale(IntPtr _this,ref FVector2D Scale);
public  void SetRenderScale(FVector2D Scale)
{
	CheckIsValid();
	SetRenderScale(_this.Get(),ref Scale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderTransform(IntPtr _this,ref FWidgetTransform InTransform);
public  void SetRenderTransform(FWidgetTransform InTransform)
{
	CheckIsValid();
	SetRenderTransform(_this.Get(),ref InTransform);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
