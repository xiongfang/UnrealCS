using System;
namespace UnrealEngine
{
	public partial class UWidgetLayoutLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Removes all widgets from the viewport.</summary>
		public extern static void RemoveAllWidgets(UObject WorldContextObject);
		/// <summary>
		/// Gets the slot object on the child widget as a Vertical Box Slot, allowing you to manipulate its information.
		/// @param Widget The child widget of a Vertical Box.
		/// </summary>
		public extern static UVerticalBoxSlot SlotAsVerticalBoxSlot(UWidget Widget);
		/// <summary>
		/// Gets the slot object on the child widget as a Uniform Grid Slot, allowing you to manipulate layout information.
		/// @param Widget The child widget of a uniform grid panel.
		/// </summary>
		public extern static UUniformGridSlot SlotAsUniformGridSlot(UWidget Widget);
		/// <summary>
		/// Gets the slot object on the child widget as a Overlay Slot, allowing you to manipulate layout information.
		/// @param Widget The child widget of a overlay panel.
		/// </summary>
		public extern static UOverlaySlot SlotAsOverlaySlot(UWidget Widget);
		/// <summary>
		/// Gets the slot object on the child widget as a Horizontal Box Slot, allowing you to manipulate its information.
		/// @param Widget The child widget of a Horizontal Box.
		/// </summary>
		public extern static UHorizontalBoxSlot SlotAsHorizontalBoxSlot(UWidget Widget);
		/// <summary>
		/// Gets the slot object on the child widget as a Grid Slot, allowing you to manipulate layout information.
		/// @param Widget The child widget of a grid panel.
		/// </summary>
		public extern static UGridSlot SlotAsGridSlot(UWidget Widget);
		/// <summary>
		/// Gets the slot object on the child widget as a Canvas Slot, allowing you to manipulate layout information.
		/// @param Widget The child widget of a canvas panel.
		/// </summary>
		public extern static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget);
		/// <summary>
		/// Gets the slot object on the child widget as a Border Slot, allowing you to manipulate layout information.
		/// @param Widget The child widget of a border panel.
		/// </summary>
		public extern static UBorderSlot SlotAsBorderSlot(UWidget Widget);
		/// <summary>
		/// Gets the mouse position of the player controller, scaled by the DPI.  If you're trying to go from raw mouse screenspace coordinates
		/// to fullscreen widget space, you'll need to transform the mouse into DPI Scaled space.  This function performs that scaling.
		/// MousePositionScaledByDPI = MousePosition * (1 / ViewportScale).
		/// </summary>
		public extern static bool GetMousePositionScaledByDPI(APlayerController Player,out float LocationX,out float LocationY);
		/// <summary>Gets the size of the game viewport.</summary>
		public extern static FVector2D GetViewportSize(UObject WorldContextObject);
		/// <summary>Gets the current DPI Scale being applied to the viewport and all the Widgets.</summary>
		public extern static float GetViewportScale(UObject WorldContextObject);
		/// <summary>
		/// Gets the projected world to screen position for a player, then converts it into a widget
		/// position, which takes into account any quality scaling.
		/// @param PlayerController The player controller to project the position in the world to their screen.
		/// @param WorldLocation The world location to project from.
		/// @param ScreenPosition The position in the viewport with quality scale removed and DPI scale remove.
		/// @return true if the position projects onto the screen.
		/// </summary>
		public extern static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController,FVector WorldLocation,out FVector2D ScreenPosition);
		
	}
	
}
