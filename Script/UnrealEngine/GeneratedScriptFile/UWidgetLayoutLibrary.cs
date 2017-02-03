using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetLayoutLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveAllWidgets(IntPtr _this,IntPtr WorldContextObject);
/// <summary>Removes all widgets from the viewport.</summary>
public static void RemoveAllWidgets(UObject WorldContextObject)
{
	RemoveAllWidgets(IntPtr.Zero,WorldContextObject);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SlotAsVerticalBoxSlot(IntPtr _this,IntPtr Widget);
/// <summary>
/// Gets the slot object on the child widget as a Vertical Box Slot, allowing you to manipulate its information.
/// @param Widget The child widget of a Vertical Box.
/// </summary>
public static UVerticalBoxSlot SlotAsVerticalBoxSlot(UWidget Widget)
{
	IntPtr ___ret = SlotAsVerticalBoxSlot(IntPtr.Zero,Widget);
	if(___ret==IntPtr.Zero) return null; UVerticalBoxSlot ___ret2= new UVerticalBoxSlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SlotAsUniformGridSlot(IntPtr _this,IntPtr Widget);
/// <summary>
/// Gets the slot object on the child widget as a Uniform Grid Slot, allowing you to manipulate layout information.
/// @param Widget The child widget of a uniform grid panel.
/// </summary>
public static UUniformGridSlot SlotAsUniformGridSlot(UWidget Widget)
{
	IntPtr ___ret = SlotAsUniformGridSlot(IntPtr.Zero,Widget);
	if(___ret==IntPtr.Zero) return null; UUniformGridSlot ___ret2= new UUniformGridSlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SlotAsOverlaySlot(IntPtr _this,IntPtr Widget);
/// <summary>
/// Gets the slot object on the child widget as a Overlay Slot, allowing you to manipulate layout information.
/// @param Widget The child widget of a overlay panel.
/// </summary>
public static UOverlaySlot SlotAsOverlaySlot(UWidget Widget)
{
	IntPtr ___ret = SlotAsOverlaySlot(IntPtr.Zero,Widget);
	if(___ret==IntPtr.Zero) return null; UOverlaySlot ___ret2= new UOverlaySlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SlotAsHorizontalBoxSlot(IntPtr _this,IntPtr Widget);
/// <summary>
/// Gets the slot object on the child widget as a Horizontal Box Slot, allowing you to manipulate its information.
/// @param Widget The child widget of a Horizontal Box.
/// </summary>
public static UHorizontalBoxSlot SlotAsHorizontalBoxSlot(UWidget Widget)
{
	IntPtr ___ret = SlotAsHorizontalBoxSlot(IntPtr.Zero,Widget);
	if(___ret==IntPtr.Zero) return null; UHorizontalBoxSlot ___ret2= new UHorizontalBoxSlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SlotAsGridSlot(IntPtr _this,IntPtr Widget);
/// <summary>
/// Gets the slot object on the child widget as a Grid Slot, allowing you to manipulate layout information.
/// @param Widget The child widget of a grid panel.
/// </summary>
public static UGridSlot SlotAsGridSlot(UWidget Widget)
{
	IntPtr ___ret = SlotAsGridSlot(IntPtr.Zero,Widget);
	if(___ret==IntPtr.Zero) return null; UGridSlot ___ret2= new UGridSlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SlotAsCanvasSlot(IntPtr _this,IntPtr Widget);
/// <summary>
/// Gets the slot object on the child widget as a Canvas Slot, allowing you to manipulate layout information.
/// @param Widget The child widget of a canvas panel.
/// </summary>
public static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget)
{
	IntPtr ___ret = SlotAsCanvasSlot(IntPtr.Zero,Widget);
	if(___ret==IntPtr.Zero) return null; UCanvasPanelSlot ___ret2= new UCanvasPanelSlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SlotAsBorderSlot(IntPtr _this,IntPtr Widget);
/// <summary>
/// Gets the slot object on the child widget as a Border Slot, allowing you to manipulate layout information.
/// @param Widget The child widget of a border panel.
/// </summary>
public static UBorderSlot SlotAsBorderSlot(UWidget Widget)
{
	IntPtr ___ret = SlotAsBorderSlot(IntPtr.Zero,Widget);
	if(___ret==IntPtr.Zero) return null; UBorderSlot ___ret2= new UBorderSlot(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMousePositionScaledByDPI(IntPtr _this,IntPtr Player,out float LocationX,out float LocationY);
/// <summary>
/// Gets the mouse position of the player controller, scaled by the DPI.  If you're trying to go from raw mouse screenspace coordinates
/// to fullscreen widget space, you'll need to transform the mouse into DPI Scaled space.  This function performs that scaling.
/// MousePositionScaledByDPI = MousePosition * (1 / ViewportScale).
/// </summary>
public static bool GetMousePositionScaledByDPI(APlayerController Player,out float LocationX,out float LocationY)
{
	int ___ret = GetMousePositionScaledByDPI(IntPtr.Zero,Player,out LocationX,out LocationY);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetViewportSize(IntPtr _this,IntPtr WorldContextObject);
/// <summary>Gets the size of the game viewport.</summary>
public static FVector2D GetViewportSize(UObject WorldContextObject)
{
	FVector2D ___ret = GetViewportSize(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetViewportScale(IntPtr _this,IntPtr WorldContextObject);
/// <summary>Gets the current DPI Scale being applied to the viewport and all the Widgets.</summary>
public static float GetViewportScale(UObject WorldContextObject)
{
	float ___ret = GetViewportScale(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ProjectWorldLocationToWidgetPosition(IntPtr _this,IntPtr PlayerController,ref FVector WorldLocation,out FVector2D ScreenPosition);
/// <summary>
/// Gets the projected world to screen position for a player, then converts it into a widget
/// position, which takes into account any quality scaling.
/// @param PlayerController The player controller to project the position in the world to their screen.
/// @param WorldLocation The world location to project from.
/// @param ScreenPosition The position in the viewport with quality scale removed and DPI scale remove.
/// @return true if the position projects onto the screen.
/// </summary>
public static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController,FVector WorldLocation,out FVector2D ScreenPosition)
{
	int ___ret = ProjectWorldLocationToWidgetPosition(IntPtr.Zero,PlayerController,ref WorldLocation,out ScreenPosition);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
