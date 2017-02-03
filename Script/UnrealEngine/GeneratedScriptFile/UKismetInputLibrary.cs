using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetInputLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D PointerEvent_GetGestureDelta(IntPtr _this,ref FPointerEvent Input);
/// <summary>@return The change in gesture value since the last gesture event of the same type.</summary>
public static FVector2D PointerEvent_GetGestureDelta(FPointerEvent Input)
{
	FVector2D ___ret = PointerEvent_GetGestureDelta(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int PointerEvent_IsTouchEvent(IntPtr _this,ref FPointerEvent Input);
/// <summary>@return Is this event a result from a touch (as opposed to a mouse)</summary>
public static bool PointerEvent_IsTouchEvent(FPointerEvent Input)
{
	int ___ret = PointerEvent_IsTouchEvent(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int PointerEvent_GetTouchpadIndex(IntPtr _this,ref FPointerEvent Input);
/// <summary>@return The index of the touch pad that generated this event (for platforms with multiple touch pads per user)</summary>
public static int PointerEvent_GetTouchpadIndex(FPointerEvent Input)
{
	int ___ret = PointerEvent_GetTouchpadIndex(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int PointerEvent_GetPointerIndex(IntPtr _this,ref FPointerEvent Input);
/// <summary>@return The unique identifier of the pointer (e.g., finger index)</summary>
public static int PointerEvent_GetPointerIndex(FPointerEvent Input)
{
	int ___ret = PointerEvent_GetPointerIndex(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int PointerEvent_GetUserIndex(IntPtr _this,ref FPointerEvent Input);
/// <summary>@return The index of the user that caused the event</summary>
public static int PointerEvent_GetUserIndex(FPointerEvent Input)
{
	int ___ret = PointerEvent_GetUserIndex(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float PointerEvent_GetWheelDelta(IntPtr _this,ref FPointerEvent Input);
/// <summary>How much did the mouse wheel turn since the last mouse event</summary>
public static float PointerEvent_GetWheelDelta(FPointerEvent Input)
{
	float ___ret = PointerEvent_GetWheelDelta(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FKey PointerEvent_GetEffectingButton(IntPtr _this,ref FPointerEvent Input);
/// <summary>Mouse button that caused this event to be raised (possibly EB_None)</summary>
public static FKey PointerEvent_GetEffectingButton(FPointerEvent Input)
{
	FKey ___ret = PointerEvent_GetEffectingButton(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int PointerEvent_IsMouseButtonDown(IntPtr _this,ref FPointerEvent Input,ref FKey MouseButton);
/// <summary>Mouse buttons that are currently pressed</summary>
public static bool PointerEvent_IsMouseButtonDown(FPointerEvent Input,FKey MouseButton)
{
	int ___ret = PointerEvent_IsMouseButtonDown(IntPtr.Zero,ref Input,ref MouseButton);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D PointerEvent_GetCursorDelta(IntPtr _this,ref FPointerEvent Input);
/// <summary>@return the distance the mouse traveled since the last event was handled.</summary>
public static FVector2D PointerEvent_GetCursorDelta(FPointerEvent Input)
{
	FVector2D ___ret = PointerEvent_GetCursorDelta(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D PointerEvent_GetLastScreenSpacePosition(IntPtr _this,ref FPointerEvent Input);
/// <summary>@return The position of the cursor in screen space last time we handled an input event</summary>
public static FVector2D PointerEvent_GetLastScreenSpacePosition(FPointerEvent Input)
{
	FVector2D ___ret = PointerEvent_GetLastScreenSpacePosition(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D PointerEvent_GetScreenSpacePosition(IntPtr _this,ref FPointerEvent Input);
/// <summary>@return The position of the cursor in screen space</summary>
public static FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent Input)
{
	FVector2D ___ret = PointerEvent_GetScreenSpacePosition(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnalogValue(IntPtr _this,ref FAnalogInputEvent Input);
public static float GetAnalogValue(FAnalogInputEvent Input)
{
	float ___ret = GetAnalogValue(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetUserIndex(IntPtr _this,ref FKeyEvent Input);
public static int GetUserIndex(FKeyEvent Input)
{
	int ___ret = GetUserIndex(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FKey GetKey(IntPtr _this,ref FKeyEvent Input);
/// <summary>
/// Returns the key for this event.
/// @return  Key name
/// </summary>
public static FKey GetKey(FKeyEvent Input)
{
	FKey ___ret = GetKey(IntPtr.Zero,ref Input);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsRightCommandDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if right command key was down when this event occurred
/// @return  True if right command is pressed
/// </summary>
public static bool InputEvent_IsRightCommandDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsRightCommandDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsLeftCommandDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if left command key was down when this event occurred
/// @return  True if left command is pressed
/// </summary>
public static bool InputEvent_IsLeftCommandDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsLeftCommandDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsCommandDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if either command key was down when this event occurred
/// @return  True if command is pressed
/// </summary>
public static bool InputEvent_IsCommandDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsCommandDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsRightAltDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if right alt key was down when this event occurred
/// @return  True if right alt is pressed
/// </summary>
public static bool InputEvent_IsRightAltDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsRightAltDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsLeftAltDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if left alt key was down when this event occurred
/// @return  True if left alt is pressed
/// </summary>
public static bool InputEvent_IsLeftAltDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsLeftAltDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsAltDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if either alt key was down when this event occurred
/// @return  True if alt is pressed
/// </summary>
public static bool InputEvent_IsAltDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsAltDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsRightControlDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if left control key was down when this event occurred
/// @return  True if left control is pressed
/// </summary>
public static bool InputEvent_IsRightControlDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsRightControlDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsLeftControlDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if left control key was down when this event occurred
/// @return  True if left control is pressed
/// </summary>
public static bool InputEvent_IsLeftControlDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsLeftControlDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsControlDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if either control key was down when this event occurred
/// @return  True if control is pressed
/// </summary>
public static bool InputEvent_IsControlDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsControlDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsRightShiftDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if right shift key was down when this event occurred
/// @return True if right shift is pressed.
/// </summary>
public static bool InputEvent_IsRightShiftDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsRightShiftDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsLeftShiftDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if left shift key was down when this event occurred
/// @return True if left shift is pressed.
/// </summary>
public static bool InputEvent_IsLeftShiftDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsLeftShiftDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsShiftDown(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns true if either shift key was down when this event occurred
/// @return  True if shift is pressed
/// </summary>
public static bool InputEvent_IsShiftDown(FInputEvent Input)
{
	int ___ret = InputEvent_IsShiftDown(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InputEvent_IsRepeat(IntPtr _this,ref FInputEvent Input);
/// <summary>
/// Returns whether or not this character is an auto-repeated keystroke
/// @return  True if this character is a repeat
/// </summary>
public static bool InputEvent_IsRepeat(FInputEvent Input)
{
	int ___ret = InputEvent_IsRepeat(IntPtr.Zero,ref Input);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Key_GetDisplayName(IntPtr _this,ref FKey Key);
/// <summary>@returns The display name of the key.</summary>
public static string Key_GetDisplayName(FKey Key)
{
	string ___ret = Key_GetDisplayName(IntPtr.Zero,ref Key);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Key_IsVectorAxis(IntPtr _this,ref FKey Key);
/// <summary>@returns True if the key is a vector axis</summary>
public static bool Key_IsVectorAxis(FKey Key)
{
	int ___ret = Key_IsVectorAxis(IntPtr.Zero,ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Key_IsFloatAxis(IntPtr _this,ref FKey Key);
/// <summary>@returns True if the key is a float axis</summary>
public static bool Key_IsFloatAxis(FKey Key)
{
	int ___ret = Key_IsFloatAxis(IntPtr.Zero,ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Key_IsKeyboardKey(IntPtr _this,ref FKey Key);
/// <summary>@returns True if the key is a keyboard button</summary>
public static bool Key_IsKeyboardKey(FKey Key)
{
	int ___ret = Key_IsKeyboardKey(IntPtr.Zero,ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Key_IsMouseButton(IntPtr _this,ref FKey Key);
/// <summary>@returns True if the key is a mouse button</summary>
public static bool Key_IsMouseButton(FKey Key)
{
	int ___ret = Key_IsMouseButton(IntPtr.Zero,ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Key_IsGamepadKey(IntPtr _this,ref FKey Key);
/// <summary>@returns True if the key is a gamepad button</summary>
public static bool Key_IsGamepadKey(FKey Key)
{
	int ___ret = Key_IsGamepadKey(IntPtr.Zero,ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Key_IsModifierKey(IntPtr _this,ref FKey Key);
/// <summary>@returns True if the key is a modifier key: Ctrl, Command, Alt, Shift</summary>
public static bool Key_IsModifierKey(FKey Key)
{
	int ___ret = Key_IsModifierKey(IntPtr.Zero,ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_InputChordInputChord(IntPtr _this,ref FInputChord A,ref FInputChord B);
/// <summary>
/// Test if the input chords are equal (A == B)
/// @param A - The chord to compare against
/// @param B - The chord to compare
/// @returns True if the chords are equal, false otherwise
/// </summary>
public static bool EqualEqual_InputChordInputChord(FInputChord A,FInputChord B)
{
	int ___ret = EqualEqual_InputChordInputChord(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_KeyKey(IntPtr _this,ref FKey A,ref FKey B);
/// <summary>
/// Test if the input key are equal (A == B)
/// @param A - The key to compare against
/// @param B - The key to compare
/// @returns True if the key are equal, false otherwise
/// </summary>
public static bool EqualEqual_KeyKey(FKey A,FKey B)
{
	int ___ret = EqualEqual_KeyKey(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CalibrateTilt(IntPtr _this);
/// <summary>Calibrate the tilt for the input device</summary>
public static void CalibrateTilt()
{
	CalibrateTilt(IntPtr.Zero);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
