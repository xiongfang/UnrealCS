using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetBlueprintLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetSafeZonePadding(IntPtr _this,IntPtr WorldContextObject,out FVector2D SafePadding,out FVector2D SafePaddingScale,out FVector2D SpillOverPadding);
/// <summary>Gets the amount of padding that needs to be added when accounting for the safe zone on TVs.</summary>
public static void GetSafeZonePadding(UObject WorldContextObject,out FVector2D SafePadding,out FVector2D SafePaddingScale,out FVector2D SpillOverPadding)
{
	GetSafeZonePadding(IntPtr.Zero,WorldContextObject,out SafePadding,out SafePaddingScale,out SpillOverPadding);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromNavigationEvent(IntPtr _this,ref FNavigationEvent Event);
public static FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event)
{
	FInputEvent ___ret = GetInputEventFromNavigationEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromControllerEvent(IntPtr _this,ref FControllerEvent Event);
public static FInputEvent GetInputEventFromControllerEvent(FControllerEvent Event)
{
	FInputEvent ___ret = GetInputEventFromControllerEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromPointerEvent(IntPtr _this,ref FPointerEvent Event);
public static FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event)
{
	FInputEvent ___ret = GetInputEventFromPointerEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromCharacterEvent(IntPtr _this,ref FCharacterEvent Event);
public static FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event)
{
	FInputEvent ___ret = GetInputEventFromCharacterEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FKeyEvent GetKeyEventFromAnalogInputEvent(IntPtr _this,ref FAnalogInputEvent Event);
public static FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event)
{
	FKeyEvent ___ret = GetKeyEventFromAnalogInputEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromKeyEvent(IntPtr _this,ref FKeyEvent Event);
public static FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event)
{
	FInputEvent ___ret = GetInputEventFromKeyEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAllWidgetsWithInterface(IntPtr _this,IntPtr WorldContextObject,IntPtr Interface,out IntPtr[] FoundWidgets,int TopLevelOnly);
/// <summary>
/// Find all widgets in the world with the specified interface.
/// This is a slow operation, use with caution e.g. do not use every frame.
/// @param Interface The interface to find. Must be specified or result array will be empty.
/// @param FoundWidgets Output array of widgets that implement the specified interface.
/// @param TopLevelOnly Only the widgets that are direct children of the viewport will be returned.
/// </summary>
public static void GetAllWidgetsWithInterface(UObject WorldContextObject,TSubclassOf<UInterface>  Interface,out UUserWidget[] FoundWidgets,bool TopLevelOnly)
{
	IntPtr[] FoundWidgets_temp;
	GetAllWidgetsWithInterface(IntPtr.Zero,WorldContextObject,Interface.NativeClass,out FoundWidgets_temp,TopLevelOnly?1:0);
	FoundWidgets = MarshalUtil.IntPtrArrayToObjectArray<UUserWidget>(FoundWidgets_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAllWidgetsOfClass(IntPtr _this,IntPtr WorldContextObject,out IntPtr[] FoundWidgets,IntPtr WidgetClass,int TopLevelOnly);
/// <summary>
/// Find all widgets of a certain class.
/// @param FoundWidgets The widgets that were found matching the filter.
/// @param WidgetClass The widget class to filter by.
/// @param TopLevelOnly Only the widgets that are direct children of the viewport will be returned.
/// </summary>
public static void GetAllWidgetsOfClass(UObject WorldContextObject,out UUserWidget[] FoundWidgets,TSubclassOf<UUserWidget>  WidgetClass,bool TopLevelOnly=true)
{
	IntPtr[] FoundWidgets_temp;
	GetAllWidgetsOfClass(IntPtr.Zero,WorldContextObject,out FoundWidgets_temp,WidgetClass.NativeClass,TopLevelOnly?1:0);
	FoundWidgets = MarshalUtil.IntPtrArrayToObjectArray<UUserWidget>(FoundWidgets_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DismissAllMenus(IntPtr _this);
/// <summary>Closes any popup menu</summary>
public static void DismissAllMenus()
{
	DismissAllMenus(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetDynamicMaterial(IntPtr _this,out FSlateBrush Brush);
/// <summary>
/// Gets the material that allows changes to parameters at runtime.  The brush must already have a material assigned to it,
/// if it does it will automatically be converted to a MID.
/// @return A material that supports dynamic input from the game.
/// </summary>
public static UMaterialInstanceDynamic GetDynamicMaterial(out FSlateBrush Brush)
{
	IntPtr ___ret = GetDynamicMaterial(IntPtr.Zero,out Brush);
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush NoResourceBrush(IntPtr _this);
/// <summary>
/// Creates a Slate Brush that wont draw anything, the "Null Brush".
/// @return A new slate brush that wont draw anything.
/// </summary>
public static FSlateBrush NoResourceBrush()
{
	FSlateBrush ___ret = NoResourceBrush(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrushResourceToMaterial(IntPtr _this,out FSlateBrush Brush,IntPtr Material);
/// <summary>Sets the resource on a brush to be a Material.</summary>
public static void SetBrushResourceToMaterial(out FSlateBrush Brush,UMaterialInterface Material)
{
	SetBrushResourceToMaterial(IntPtr.Zero,out Brush,Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrushResourceToTexture(IntPtr _this,out FSlateBrush Brush,IntPtr Texture);
/// <summary>Sets the resource on a brush to be a UTexture2D.</summary>
public static void SetBrushResourceToTexture(out FSlateBrush Brush,UTexture2D Texture)
{
	SetBrushResourceToTexture(IntPtr.Zero,out Brush,Texture);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetBrushResourceAsMaterial(IntPtr _this,out FSlateBrush Brush);
/// <summary>Gets the brush resource as a material.</summary>
public static UMaterialInterface GetBrushResourceAsMaterial(out FSlateBrush Brush)
{
	IntPtr ___ret = GetBrushResourceAsMaterial(IntPtr.Zero,out Brush);
	if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetBrushResourceAsTexture2D(IntPtr _this,out FSlateBrush Brush);
/// <summary>Gets the brush resource as a texture 2D.</summary>
public static UTexture2D GetBrushResourceAsTexture2D(out FSlateBrush Brush)
{
	IntPtr ___ret = GetBrushResourceAsTexture2D(IntPtr.Zero,out Brush);
	if(___ret==IntPtr.Zero) return null; UTexture2D ___ret2= new UTexture2D(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetBrushResource(IntPtr _this,out FSlateBrush Brush);
/// <summary>Gets the resource object on a brush.  This could be a UTexture2D or a UMaterialInterface.</summary>
public static UObject GetBrushResource(out FSlateBrush Brush)
{
	IntPtr ___ret = GetBrushResource(IntPtr.Zero,out Brush);
	if(___ret==IntPtr.Zero) return null; UObject ___ret2= new UObject(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush MakeBrushFromMaterial(IntPtr _this,IntPtr Material,int Width,int Height);
/// <summary>
/// Creates a Slate Brush from a Material.  Materials don't have an implicit size, so providing a widget and height
/// is required to hint slate with how large the image wants to be by default.
/// @return A new slate brush using the material.
/// </summary>
public static FSlateBrush MakeBrushFromMaterial(UMaterialInterface Material,int Width=32,int Height=32)
{
	FSlateBrush ___ret = MakeBrushFromMaterial(IntPtr.Zero,Material,Width,Height);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush MakeBrushFromTexture(IntPtr _this,IntPtr Texture,int Width,int Height);
/// <summary>
/// Creates a Slate Brush from a Texture2D
/// @param Width  When less than or equal to zero, the Width of the brush will default to the Width of the Texture
/// @param Height  When less than or equal to zero, the Height of the brush will default to the Height of the Texture
/// @return A new slate brush using the texture.
/// </summary>
public static FSlateBrush MakeBrushFromTexture(UTexture2D Texture,int Width=0,int Height=0)
{
	FSlateBrush ___ret = MakeBrushFromTexture(IntPtr.Zero,Texture,Width,Height);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush MakeBrushFromAsset(IntPtr _this,IntPtr BrushAsset);
/// <summary>
/// Creates a Slate Brush from a Slate Brush Asset
/// @return A new slate brush using the asset's brush.
/// </summary>
public static FSlateBrush MakeBrushFromAsset(USlateBrushAsset BrushAsset)
{
	FSlateBrush ___ret = MakeBrushFromAsset(IntPtr.Zero,BrushAsset);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CancelDragDrop(IntPtr _this);
/// <summary>Cancels any current drag drop operation.</summary>
public static void CancelDragDrop()
{
	CancelDragDrop(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetDragDroppingContent(IntPtr _this);
/// <summary>Returns the drag and drop operation that is currently occurring if any, otherwise nothing.</summary>
public static UDragDropOperation GetDragDroppingContent()
{
	IntPtr ___ret = GetDragDroppingContent(IntPtr.Zero);
	if(___ret==IntPtr.Zero) return null; UDragDropOperation ___ret2= new UDragDropOperation(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsDragDropping(IntPtr _this);
/// <summary>Returns true if a drag/drop event is occurring that a widget can handle.</summary>
public static bool IsDragDropping()
{
	int ___ret = IsDragDropping(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply EndDragDrop(IntPtr _this,out FEventReply Reply);
/// <summary>An event should return FReply::Handled().EndDragDrop() to request that the current drag/drop operation be terminated.</summary>
public static FEventReply EndDragDrop(out FEventReply Reply)
{
	FEventReply ___ret = EndDragDrop(IntPtr.Zero,out Reply);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply DetectDragIfPressed(IntPtr _this,ref FPointerEvent PointerEvent,IntPtr WidgetDetectingDrag,ref FKey DragKey);
/// <summary>
/// Given the pointer event, emit the DetectDrag reply if the provided key was pressed.
/// If the DragKey is a touch key, that will also automatically work.
/// @param PointerEvent  The pointer device event coming in.
/// @param WidgetDetectingDrag  Detect dragging in this widget.
/// @param DragKey                      This button should be pressed to detect the drag, won't emit the DetectDrag FEventReply unless this is pressed.
/// </summary>
public static FEventReply DetectDragIfPressed(FPointerEvent PointerEvent,UWidget WidgetDetectingDrag,FKey DragKey)
{
	FEventReply ___ret = DetectDragIfPressed(IntPtr.Zero,ref PointerEvent,WidgetDetectingDrag,ref DragKey);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply DetectDrag(IntPtr _this,out FEventReply Reply,IntPtr WidgetDetectingDrag,ref FKey DragKey);
/// <summary>
/// Ask Slate to detect if a user starts dragging in this widget later.  Slate internally tracks the movement
/// and if it surpasses the drag threshold, Slate will send an OnDragDetected event to the widget.
/// @param WidgetDetectingDrag  Detect dragging in this widget
/// @param DragKey                      This button should be pressed to detect the drag
/// </summary>
public static FEventReply DetectDrag(out FEventReply Reply,UWidget WidgetDetectingDrag,FKey DragKey)
{
	FEventReply ___ret = DetectDrag(IntPtr.Zero,out Reply,WidgetDetectingDrag,ref DragKey);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply SetMousePosition(IntPtr _this,out FEventReply Reply,ref FVector2D NewMousePosition);
public static FEventReply SetMousePosition(out FEventReply Reply,FVector2D NewMousePosition)
{
	FEventReply ___ret = SetMousePosition(IntPtr.Zero,out Reply,ref NewMousePosition);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply ClearUserFocus(IntPtr _this,out FEventReply Reply,int bInAllUsers);
public static FEventReply ClearUserFocus(out FEventReply Reply,bool bInAllUsers=false)
{
	FEventReply ___ret = ClearUserFocus(IntPtr.Zero,out Reply,bInAllUsers?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply SetUserFocus(IntPtr _this,out FEventReply Reply,IntPtr FocusWidget,int bInAllUsers);
public static FEventReply SetUserFocus(out FEventReply Reply,UWidget FocusWidget,bool bInAllUsers=false)
{
	FEventReply ___ret = SetUserFocus(IntPtr.Zero,out Reply,FocusWidget,bInAllUsers?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply UnlockMouse(IntPtr _this,out FEventReply Reply);
public static FEventReply UnlockMouse(out FEventReply Reply)
{
	FEventReply ___ret = UnlockMouse(IntPtr.Zero,out Reply);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply LockMouse(IntPtr _this,out FEventReply Reply,IntPtr CapturingWidget);
public static FEventReply LockMouse(out FEventReply Reply,UWidget CapturingWidget)
{
	FEventReply ___ret = LockMouse(IntPtr.Zero,out Reply,CapturingWidget);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply ReleaseMouseCapture(IntPtr _this,out FEventReply Reply);
public static FEventReply ReleaseMouseCapture(out FEventReply Reply)
{
	FEventReply ___ret = ReleaseMouseCapture(IntPtr.Zero,out Reply);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply CaptureMouse(IntPtr _this,out FEventReply Reply,IntPtr CapturingWidget);
public static FEventReply CaptureMouse(out FEventReply Reply,UWidget CapturingWidget)
{
	FEventReply ___ret = CaptureMouse(IntPtr.Zero,out Reply,CapturingWidget);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply Unhandled(IntPtr _this);
/// <summary>The event reply to use when you choose not to handle an event.</summary>
public static FEventReply Unhandled()
{
	FEventReply ___ret = Unhandled(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply Handled(IntPtr _this);
/// <summary>
/// The event reply to use when you choose to handle an event.  This will prevent the event
/// from continuing to bubble up / down the widget hierarchy.
/// </summary>
public static FEventReply Handled()
{
	FEventReply ___ret = Handled(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawTextFormatted(IntPtr _this,out FPaintContext Context,string Text,ref FVector2D Position,IntPtr Font,int FontSize,string FontTypeFace,ref FLinearColor Tint);
/// <summary>
/// Draws text.
/// @param Text                  The string to draw.
/// @param Position              The starting position where the text is drawn in local space.
/// @param Tint                  Color to render the line.
/// </summary>
public static void DrawTextFormatted(out FPaintContext Context,string Text,FVector2D Position,UFont Font,int FontSize=16,string FontTypeFace="Regular",FLinearColor Tint=default(FLinearColor))
{
	DrawTextFormatted(IntPtr.Zero,out Context,Text,ref Position,Font,FontSize,FontTypeFace,ref Tint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawLines(IntPtr _this,out FPaintContext Context,FVector2D[] Points,ref FLinearColor Tint,int bAntiAlias);
/// <summary>
/// Draws several line segments.
/// @param Points                Line pairs, each line needs to be 2 separate points in the array.
/// @param Thickness             How many pixels thick this line should be.
/// @param Tint                  Color to render the line.
/// </summary>
public static void DrawLines(out FPaintContext Context,FVector2D[] Points,FLinearColor Tint=default(FLinearColor),bool bAntiAlias=true)
{
	DrawLines(IntPtr.Zero,out Context,Points,ref Tint,bAntiAlias?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawLine(IntPtr _this,out FPaintContext Context,ref FVector2D PositionA,ref FVector2D PositionB,ref FLinearColor Tint,int bAntiAlias);
/// <summary>
/// Draws a line.
/// @param PositionA             Starting position of the line in local space.
/// @param PositionB             Ending position of the line in local space.
/// @param Thickness             How many pixels thick this line should be.
/// @param Tint                  Color to render the line.
/// </summary>
public static void DrawLine(out FPaintContext Context,FVector2D PositionA,FVector2D PositionB,FLinearColor Tint=default(FLinearColor),bool bAntiAlias=true)
{
	DrawLine(IntPtr.Zero,out Context,ref PositionA,ref PositionB,ref Tint,bAntiAlias?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawBox(IntPtr _this,out FPaintContext Context,ref FVector2D Position,ref FVector2D Size,IntPtr Brush,ref FLinearColor Tint);
/// <summary>Draws a box</summary>
public static void DrawBox(out FPaintContext Context,FVector2D Position,FVector2D Size,USlateBrushAsset Brush,FLinearColor Tint=default(FLinearColor))
{
	DrawBox(IntPtr.Zero,out Context,ref Position,ref Size,Brush,ref Tint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFocusToGameViewport(IntPtr _this);
public static void SetFocusToGameViewport()
{
	SetFocusToGameViewport(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInputMode_GameOnly(IntPtr _this,IntPtr Target);
/// <summary>Setup an input mode that allows only player input / player controller to respond to user input.</summary>
public static void SetInputMode_GameOnly(APlayerController Target)
{
	SetInputMode_GameOnly(IntPtr.Zero,Target);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInputMode_GameAndUIEx(IntPtr _this,IntPtr Target,IntPtr InWidgetToFocus,int InMouseLockMode,int bHideCursorDuringCapture);
/// <summary>Setup an input mode that allows only the UI to respond to user input, and if the UI doesn't handle it player input / player controller gets a chance.</summary>
public static void SetInputMode_GameAndUIEx(APlayerController Target,UWidget InWidgetToFocus,EMouseLockMode InMouseLockMode=EMouseLockMode.DoNotLock,bool bHideCursorDuringCapture=true)
{
	SetInputMode_GameAndUIEx(IntPtr.Zero,Target,InWidgetToFocus,(int)InMouseLockMode,bHideCursorDuringCapture?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInputMode_UIOnlyEx(IntPtr _this,IntPtr Target,IntPtr InWidgetToFocus,int InMouseLockMode);
/// <summary>Setup an input mode that allows only the UI to respond to user input.</summary>
public static void SetInputMode_UIOnlyEx(APlayerController Target,UWidget InWidgetToFocus,EMouseLockMode InMouseLockMode=EMouseLockMode.DoNotLock)
{
	SetInputMode_UIOnlyEx(IntPtr.Zero,Target,InWidgetToFocus,(int)InMouseLockMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateDragDropOperation(IntPtr _this,IntPtr OperationClass);
/// <summary>
/// Creates a new drag and drop operation that can be returned from a drag begin to inform the UI what i
/// being dragged and dropped and what it looks like.
/// </summary>
public static UDragDropOperation CreateDragDropOperation(TSubclassOf<UDragDropOperation>  OperationClass)
{
	IntPtr ___ret = CreateDragDropOperation(IntPtr.Zero,OperationClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UDragDropOperation ___ret2= new UDragDropOperation(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr Create(IntPtr _this,IntPtr WorldContextObject,IntPtr WidgetType,IntPtr OwningPlayer);
/// <summary>Creates a widget</summary>
public static UUserWidget Create(UObject WorldContextObject,TSubclassOf<UUserWidget>  WidgetType,APlayerController OwningPlayer)
{
	IntPtr ___ret = Create(IntPtr.Zero,WorldContextObject,WidgetType.NativeClass,OwningPlayer);
	if(___ret==IntPtr.Zero) return null; UUserWidget ___ret2= new UUserWidget(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
