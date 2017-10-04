using System;
namespace UnrealEngine
{
	public partial class UKismetInputLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>@return The change in gesture value since the last gesture event of the same type.</summary>
		public extern static FVector2D PointerEvent_GetGestureDelta(FPointerEvent Input);
		/// <summary>@return Is this event a result from a touch (as opposed to a mouse)</summary>
		public extern static bool PointerEvent_IsTouchEvent(FPointerEvent Input);
		/// <summary>@return The index of the touch pad that generated this event (for platforms with multiple touch pads per user)</summary>
		public extern static int PointerEvent_GetTouchpadIndex(FPointerEvent Input);
		/// <summary>@return The unique identifier of the pointer (e.g., finger index)</summary>
		public extern static int PointerEvent_GetPointerIndex(FPointerEvent Input);
		/// <summary>@return The index of the user that caused the event</summary>
		public extern static int PointerEvent_GetUserIndex(FPointerEvent Input);
		/// <summary>How much did the mouse wheel turn since the last mouse event</summary>
		public extern static float PointerEvent_GetWheelDelta(FPointerEvent Input);
		/// <summary>Mouse button that caused this event to be raised (possibly EB_None)</summary>
		public extern static FKey PointerEvent_GetEffectingButton(FPointerEvent Input);
		/// <summary>Mouse buttons that are currently pressed</summary>
		public extern static bool PointerEvent_IsMouseButtonDown(FPointerEvent Input,FKey MouseButton);
		/// <summary>@return the distance the mouse traveled since the last event was handled.</summary>
		public extern static FVector2D PointerEvent_GetCursorDelta(FPointerEvent Input);
		/// <summary>@return The position of the cursor in screen space last time we handled an input event</summary>
		public extern static FVector2D PointerEvent_GetLastScreenSpacePosition(FPointerEvent Input);
		/// <summary>@return The position of the cursor in screen space</summary>
		public extern static FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent Input);
		public extern static float GetAnalogValue(FAnalogInputEvent Input);
		public extern static int GetUserIndex(FKeyEvent Input);
		/// <summary>
		/// Returns the key for this event.
		/// @return  Key name
		/// </summary>
		public extern static FKey GetKey(FKeyEvent Input);
		/// <summary>
		/// Returns true if right command key was down when this event occurred
		/// @return  True if right command is pressed
		/// </summary>
		public extern static bool InputEvent_IsRightCommandDown(FInputEvent Input);
		/// <summary>
		/// Returns true if left command key was down when this event occurred
		/// @return  True if left command is pressed
		/// </summary>
		public extern static bool InputEvent_IsLeftCommandDown(FInputEvent Input);
		/// <summary>
		/// Returns true if either command key was down when this event occurred
		/// @return  True if command is pressed
		/// </summary>
		public extern static bool InputEvent_IsCommandDown(FInputEvent Input);
		/// <summary>
		/// Returns true if right alt key was down when this event occurred
		/// @return  True if right alt is pressed
		/// </summary>
		public extern static bool InputEvent_IsRightAltDown(FInputEvent Input);
		/// <summary>
		/// Returns true if left alt key was down when this event occurred
		/// @return  True if left alt is pressed
		/// </summary>
		public extern static bool InputEvent_IsLeftAltDown(FInputEvent Input);
		/// <summary>
		/// Returns true if either alt key was down when this event occurred
		/// @return  True if alt is pressed
		/// </summary>
		public extern static bool InputEvent_IsAltDown(FInputEvent Input);
		/// <summary>
		/// Returns true if left control key was down when this event occurred
		/// @return  True if left control is pressed
		/// </summary>
		public extern static bool InputEvent_IsRightControlDown(FInputEvent Input);
		/// <summary>
		/// Returns true if left control key was down when this event occurred
		/// @return  True if left control is pressed
		/// </summary>
		public extern static bool InputEvent_IsLeftControlDown(FInputEvent Input);
		/// <summary>
		/// Returns true if either control key was down when this event occurred
		/// @return  True if control is pressed
		/// </summary>
		public extern static bool InputEvent_IsControlDown(FInputEvent Input);
		/// <summary>
		/// Returns true if right shift key was down when this event occurred
		/// @return True if right shift is pressed.
		/// </summary>
		public extern static bool InputEvent_IsRightShiftDown(FInputEvent Input);
		/// <summary>
		/// Returns true if left shift key was down when this event occurred
		/// @return True if left shift is pressed.
		/// </summary>
		public extern static bool InputEvent_IsLeftShiftDown(FInputEvent Input);
		/// <summary>
		/// Returns true if either shift key was down when this event occurred
		/// @return  True if shift is pressed
		/// </summary>
		public extern static bool InputEvent_IsShiftDown(FInputEvent Input);
		/// <summary>
		/// Returns whether or not this character is an auto-repeated keystroke
		/// @return  True if this character is a repeat
		/// </summary>
		public extern static bool InputEvent_IsRepeat(FInputEvent Input);
		/// <summary>@returns The display name of the key.</summary>
		public extern static FText Key_GetDisplayName(FKey Key);
		/// <summary>@returns True if the key is a vector axis</summary>
		public extern static bool Key_IsVectorAxis(FKey Key);
		/// <summary>@returns True if the key is a float axis</summary>
		public extern static bool Key_IsFloatAxis(FKey Key);
		/// <summary>@returns True if the key is a keyboard button</summary>
		public extern static bool Key_IsKeyboardKey(FKey Key);
		/// <summary>@returns True if the key is a mouse button</summary>
		public extern static bool Key_IsMouseButton(FKey Key);
		/// <summary>@returns True if the key is a gamepad button</summary>
		public extern static bool Key_IsGamepadKey(FKey Key);
		/// <summary>@returns True if the key is a modifier key: Ctrl, Command, Alt, Shift</summary>
		public extern static bool Key_IsModifierKey(FKey Key);
		/// <summary>
		/// Test if the input chords are equal (A == B)
		/// @param A - The chord to compare against
		/// @param B - The chord to compare
		/// @returns True if the chords are equal, false otherwise
		/// </summary>
		public extern static bool EqualEqual_InputChordInputChord(FInputChord A,FInputChord B);
		/// <summary>
		/// Test if the input key are equal (A == B)
		/// @param A - The key to compare against
		/// @param B - The key to compare
		/// @returns True if the key are equal, false otherwise
		/// </summary>
		public extern static bool EqualEqual_KeyKey(FKey A,FKey B);
		/// <summary>Calibrate the tilt for the input device</summary>
		public extern static void CalibrateTilt();
		
	}
	
}
