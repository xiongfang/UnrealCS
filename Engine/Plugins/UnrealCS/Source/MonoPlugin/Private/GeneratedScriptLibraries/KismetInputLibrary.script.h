#pragma once

namespace UnrealEngine
{
	class _UKismetInputLibrary
	{
		static FVector2D PointerEvent_GetGestureDelta(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			FVector2D ___ret = _this->PointerEvent_GetGestureDelta(*Input);
			return ___ret;
			
		}
		static int32 PointerEvent_IsTouchEvent(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			bool ___ret = _this->PointerEvent_IsTouchEvent(*Input);
			return ___ret?1:0;
			
		}
		static int32 PointerEvent_GetTouchpadIndex(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			int32 ___ret = _this->PointerEvent_GetTouchpadIndex(*Input);
			return ___ret;
			
		}
		static int32 PointerEvent_GetPointerIndex(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			int32 ___ret = _this->PointerEvent_GetPointerIndex(*Input);
			return ___ret;
			
		}
		static int32 PointerEvent_GetUserIndex(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			int32 ___ret = _this->PointerEvent_GetUserIndex(*Input);
			return ___ret;
			
		}
		static float PointerEvent_GetWheelDelta(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			float ___ret = _this->PointerEvent_GetWheelDelta(*Input);
			return ___ret;
			
		}
		static FKey PointerEvent_GetEffectingButton(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			FKey ___ret = _this->PointerEvent_GetEffectingButton(*Input);
			return ___ret;
			
		}
		static int32 PointerEvent_IsMouseButtonDown(UKismetInputLibrary* _this,FPointerEvent* Input,FKey* MouseButton)
		{
			bool ___ret = _this->PointerEvent_IsMouseButtonDown(*Input,*MouseButton);
			return ___ret?1:0;
			
		}
		static FVector2D PointerEvent_GetCursorDelta(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			FVector2D ___ret = _this->PointerEvent_GetCursorDelta(*Input);
			return ___ret;
			
		}
		static FVector2D PointerEvent_GetLastScreenSpacePosition(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			FVector2D ___ret = _this->PointerEvent_GetLastScreenSpacePosition(*Input);
			return ___ret;
			
		}
		static FVector2D PointerEvent_GetScreenSpacePosition(UKismetInputLibrary* _this,FPointerEvent* Input)
		{
			FVector2D ___ret = _this->PointerEvent_GetScreenSpacePosition(*Input);
			return ___ret;
			
		}
		static float GetAnalogValue(UKismetInputLibrary* _this,FAnalogInputEvent* Input)
		{
			float ___ret = _this->GetAnalogValue(*Input);
			return ___ret;
			
		}
		static int32 GetUserIndex(UKismetInputLibrary* _this,FKeyEvent* Input)
		{
			int32 ___ret = _this->GetUserIndex(*Input);
			return ___ret;
			
		}
		static FKey GetKey(UKismetInputLibrary* _this,FKeyEvent* Input)
		{
			FKey ___ret = _this->GetKey(*Input);
			return ___ret;
			
		}
		static int32 InputEvent_IsRightCommandDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsRightCommandDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsLeftCommandDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsLeftCommandDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsCommandDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsCommandDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsRightAltDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsRightAltDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsLeftAltDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsLeftAltDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsAltDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsAltDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsRightControlDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsRightControlDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsLeftControlDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsLeftControlDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsControlDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsControlDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsRightShiftDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsRightShiftDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsLeftShiftDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsLeftShiftDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsShiftDown(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsShiftDown(*Input);
			return ___ret?1:0;
			
		}
		static int32 InputEvent_IsRepeat(UKismetInputLibrary* _this,FInputEvent* Input)
		{
			bool ___ret = _this->InputEvent_IsRepeat(*Input);
			return ___ret?1:0;
			
		}
		static MonoString* Key_GetDisplayName(UKismetInputLibrary* _this,FKey* Key)
		{
			FText ___ret = _this->Key_GetDisplayName(*Key);
			return FStringToMonoString(___ret.ToString());
			
		}
		static int32 Key_IsVectorAxis(UKismetInputLibrary* _this,FKey* Key)
		{
			bool ___ret = _this->Key_IsVectorAxis(*Key);
			return ___ret?1:0;
			
		}
		static int32 Key_IsFloatAxis(UKismetInputLibrary* _this,FKey* Key)
		{
			bool ___ret = _this->Key_IsFloatAxis(*Key);
			return ___ret?1:0;
			
		}
		static int32 Key_IsKeyboardKey(UKismetInputLibrary* _this,FKey* Key)
		{
			bool ___ret = _this->Key_IsKeyboardKey(*Key);
			return ___ret?1:0;
			
		}
		static int32 Key_IsMouseButton(UKismetInputLibrary* _this,FKey* Key)
		{
			bool ___ret = _this->Key_IsMouseButton(*Key);
			return ___ret?1:0;
			
		}
		static int32 Key_IsGamepadKey(UKismetInputLibrary* _this,FKey* Key)
		{
			bool ___ret = _this->Key_IsGamepadKey(*Key);
			return ___ret?1:0;
			
		}
		static int32 Key_IsModifierKey(UKismetInputLibrary* _this,FKey* Key)
		{
			bool ___ret = _this->Key_IsModifierKey(*Key);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_InputChordInputChord(UKismetInputLibrary* _this,FInputChord* A,FInputChord* B)
		{
			bool ___ret = _this->EqualEqual_InputChordInputChord(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_KeyKey(UKismetInputLibrary* _this,FKey* A,FKey* B)
		{
			bool ___ret = _this->EqualEqual_KeyKey(*A,*B);
			return ___ret?1:0;
			
		}
		static void CalibrateTilt(UKismetInputLibrary* _this)
		{
			_this->CalibrateTilt();
			
		}
		static UClass* StaticClass(){return UKismetInputLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetGestureDelta",(const void*)PointerEvent_GetGestureDelta);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_IsTouchEvent",(const void*)PointerEvent_IsTouchEvent);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetTouchpadIndex",(const void*)PointerEvent_GetTouchpadIndex);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetPointerIndex",(const void*)PointerEvent_GetPointerIndex);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetUserIndex",(const void*)PointerEvent_GetUserIndex);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetWheelDelta",(const void*)PointerEvent_GetWheelDelta);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetEffectingButton",(const void*)PointerEvent_GetEffectingButton);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_IsMouseButtonDown",(const void*)PointerEvent_IsMouseButtonDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetCursorDelta",(const void*)PointerEvent_GetCursorDelta);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetLastScreenSpacePosition",(const void*)PointerEvent_GetLastScreenSpacePosition);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::PointerEvent_GetScreenSpacePosition",(const void*)PointerEvent_GetScreenSpacePosition);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::GetAnalogValue",(const void*)GetAnalogValue);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::GetUserIndex",(const void*)GetUserIndex);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::GetKey",(const void*)GetKey);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsRightCommandDown",(const void*)InputEvent_IsRightCommandDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsLeftCommandDown",(const void*)InputEvent_IsLeftCommandDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsCommandDown",(const void*)InputEvent_IsCommandDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsRightAltDown",(const void*)InputEvent_IsRightAltDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsLeftAltDown",(const void*)InputEvent_IsLeftAltDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsAltDown",(const void*)InputEvent_IsAltDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsRightControlDown",(const void*)InputEvent_IsRightControlDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsLeftControlDown",(const void*)InputEvent_IsLeftControlDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsControlDown",(const void*)InputEvent_IsControlDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsRightShiftDown",(const void*)InputEvent_IsRightShiftDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsLeftShiftDown",(const void*)InputEvent_IsLeftShiftDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsShiftDown",(const void*)InputEvent_IsShiftDown);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::InputEvent_IsRepeat",(const void*)InputEvent_IsRepeat);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::Key_GetDisplayName",(const void*)Key_GetDisplayName);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::Key_IsVectorAxis",(const void*)Key_IsVectorAxis);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::Key_IsFloatAxis",(const void*)Key_IsFloatAxis);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::Key_IsKeyboardKey",(const void*)Key_IsKeyboardKey);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::Key_IsMouseButton",(const void*)Key_IsMouseButton);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::Key_IsGamepadKey",(const void*)Key_IsGamepadKey);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::Key_IsModifierKey",(const void*)Key_IsModifierKey);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::EqualEqual_InputChordInputChord",(const void*)EqualEqual_InputChordInputChord);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::EqualEqual_KeyKey",(const void*)EqualEqual_KeyKey);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::CalibrateTilt",(const void*)CalibrateTilt);
			mono_add_internal_call("UnrealEngine.UKismetInputLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
