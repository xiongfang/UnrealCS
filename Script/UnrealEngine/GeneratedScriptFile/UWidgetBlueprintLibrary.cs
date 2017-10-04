using System;
namespace UnrealEngine
{
	public partial class UWidgetBlueprintLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Gets the amount of padding that needs to be added when accounting for the safe zone on TVs.</summary>
		public extern static void GetSafeZonePadding(UObject WorldContextObject,out FVector2D SafePadding,out FVector2D SafePaddingScale,out FVector2D SpillOverPadding);
		public extern static FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event);
		public extern static FInputEvent GetInputEventFromControllerEvent(FControllerEvent Event);
		public extern static FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event);
		public extern static FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event);
		public extern static FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event);
		public extern static FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event);
		/// <summary>Closes any popup menu</summary>
		public extern static void DismissAllMenus();
		/// <summary>
		/// Gets the material that allows changes to parameters at runtime.  The brush must already have a material assigned to it,
		/// if it does it will automatically be converted to a MID.
		/// @return A material that supports dynamic input from the game.
		/// </summary>
		public extern static UMaterialInstanceDynamic GetDynamicMaterial(out FSlateBrush Brush);
		/// <summary>
		/// Creates a Slate Brush that wont draw anything, the "Null Brush".
		/// @return A new slate brush that wont draw anything.
		/// </summary>
		public extern static FSlateBrush NoResourceBrush();
		/// <summary>Sets the resource on a brush to be a Material.</summary>
		public extern static void SetBrushResourceToMaterial(out FSlateBrush Brush,UMaterialInterface Material);
		/// <summary>Sets the resource on a brush to be a UTexture2D.</summary>
		public extern static void SetBrushResourceToTexture(out FSlateBrush Brush,UTexture2D Texture);
		/// <summary>Gets the brush resource as a material.</summary>
		public extern static UMaterialInterface GetBrushResourceAsMaterial(out FSlateBrush Brush);
		/// <summary>Gets the brush resource as a texture 2D.</summary>
		public extern static UTexture2D GetBrushResourceAsTexture2D(out FSlateBrush Brush);
		/// <summary>Gets the resource object on a brush.  This could be a UTexture2D or a UMaterialInterface.</summary>
		public extern static UObject GetBrushResource(out FSlateBrush Brush);
		/// <summary>
		/// Creates a Slate Brush from a Material.  Materials don't have an implicit size, so providing a widget and height
		/// is required to hint slate with how large the image wants to be by default.
		/// @return A new slate brush using the material.
		/// </summary>
		public extern static FSlateBrush MakeBrushFromMaterial(UMaterialInterface Material,int Width=32,int Height=32);
		/// <summary>
		/// Creates a Slate Brush from a Texture2D
		/// @param Width  When less than or equal to zero, the Width of the brush will default to the Width of the Texture
		/// @param Height  When less than or equal to zero, the Height of the brush will default to the Height of the Texture
		/// @return A new slate brush using the texture.
		/// </summary>
		public extern static FSlateBrush MakeBrushFromTexture(UTexture2D Texture,int Width=0,int Height=0);
		/// <summary>
		/// Creates a Slate Brush from a Slate Brush Asset
		/// @return A new slate brush using the asset's brush.
		/// </summary>
		public extern static FSlateBrush MakeBrushFromAsset(USlateBrushAsset BrushAsset);
		/// <summary>Cancels any current drag drop operation.</summary>
		public extern static void CancelDragDrop();
		/// <summary>Returns the drag and drop operation that is currently occurring if any, otherwise nothing.</summary>
		public extern static UDragDropOperation GetDragDroppingContent();
		/// <summary>Returns true if a drag/drop event is occurring that a widget can handle.</summary>
		public extern static bool IsDragDropping();
		/// <summary>An event should return FReply::Handled().EndDragDrop() to request that the current drag/drop operation be terminated.</summary>
		public extern static FEventReply EndDragDrop(out FEventReply Reply);
		/// <summary>
		/// Given the pointer event, emit the DetectDrag reply if the provided key was pressed.
		/// If the DragKey is a touch key, that will also automatically work.
		/// @param PointerEvent  The pointer device event coming in.
		/// @param WidgetDetectingDrag  Detect dragging in this widget.
		/// @param DragKey                      This button should be pressed to detect the drag, won't emit the DetectDrag FEventReply unless this is pressed.
		/// </summary>
		public extern static FEventReply DetectDragIfPressed(FPointerEvent PointerEvent,UWidget WidgetDetectingDrag,FKey DragKey);
		/// <summary>
		/// Ask Slate to detect if a user starts dragging in this widget later.  Slate internally tracks the movement
		/// and if it surpasses the drag threshold, Slate will send an OnDragDetected event to the widget.
		/// @param WidgetDetectingDrag  Detect dragging in this widget
		/// @param DragKey                      This button should be pressed to detect the drag
		/// </summary>
		public extern static FEventReply DetectDrag(out FEventReply Reply,UWidget WidgetDetectingDrag,FKey DragKey);
		public extern static FEventReply SetMousePosition(out FEventReply Reply,FVector2D NewMousePosition);
		public extern static FEventReply ClearUserFocus(out FEventReply Reply,bool bInAllUsers=false);
		public extern static FEventReply SetUserFocus(out FEventReply Reply,UWidget FocusWidget,bool bInAllUsers=false);
		public extern static FEventReply UnlockMouse(out FEventReply Reply);
		public extern static FEventReply LockMouse(out FEventReply Reply,UWidget CapturingWidget);
		public extern static FEventReply ReleaseMouseCapture(out FEventReply Reply);
		public extern static FEventReply CaptureMouse(out FEventReply Reply,UWidget CapturingWidget);
		/// <summary>The event reply to use when you choose not to handle an event.</summary>
		public extern static FEventReply Unhandled();
		/// <summary>
		/// The event reply to use when you choose to handle an event.  This will prevent the event
		/// from continuing to bubble up / down the widget hierarchy.
		/// </summary>
		public extern static FEventReply Handled();
		/// <summary>
		/// Draws text.
		/// @param Text                  The string to draw.
		/// @param Position              The starting position where the text is drawn in local space.
		/// @param Tint                  Color to render the line.
		/// </summary>
		public extern static void DrawTextFormatted(out FPaintContext Context,FText Text,FVector2D Position,UFont Font,int FontSize=16,FName FontTypeFace=default(FName),FLinearColor Tint=default(FLinearColor));
		/// <summary>
		/// Draws a line.
		/// @param PositionA             Starting position of the line in local space.
		/// @param PositionB             Ending position of the line in local space.
		/// @param Thickness             How many pixels thick this line should be.
		/// @param Tint                  Color to render the line.
		/// </summary>
		public extern static void DrawLine(out FPaintContext Context,FVector2D PositionA,FVector2D PositionB,FLinearColor Tint=default(FLinearColor),bool bAntiAlias=true);
		/// <summary>Draws a box</summary>
		public extern static void DrawBox(out FPaintContext Context,FVector2D Position,FVector2D Size,USlateBrushAsset Brush,FLinearColor Tint=default(FLinearColor));
		public extern static void SetFocusToGameViewport();
		/// <summary>Setup an input mode that allows only player input / player controller to respond to user input.</summary>
		public extern static void SetInputMode_GameOnly(APlayerController Target);
		/// <summary>
		/// Creates a new drag and drop operation that can be returned from a drag begin to inform the UI what i
		/// being dragged and dropped and what it looks like.
		/// </summary>
		public extern static UDragDropOperation CreateDragDropOperation(TSubclassOf<UDragDropOperation>  OperationClass);
		/// <summary>Creates a widget</summary>
		public extern static UUserWidget Create(UObject WorldContextObject,TSubclassOf<UUserWidget>  WidgetType,APlayerController OwningPlayer);
		
	}
	
}
