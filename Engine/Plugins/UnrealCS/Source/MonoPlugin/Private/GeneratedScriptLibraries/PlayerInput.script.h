#pragma once

namespace UnrealEngine
{
	class _UPlayerInput
	{
		static void ClearSmoothing(UPlayerInput* _this)
		{
			_this->ClearSmoothing();
			
		}
		static void InvertAxis(UPlayerInput* _this,MonoString* AxisName)
		{
			FName AxisName_temp=MonoStringToFName(AxisName);
			_this->InvertAxis(AxisName_temp);
			
		}
		static void InvertAxisKey(UPlayerInput* _this,FKey* AxisKey)
		{
			_this->InvertAxisKey(*AxisKey);
			
		}
		static void SetBind(UPlayerInput* _this,MonoString* BindName,MonoString* Command)
		{
			FName BindName_temp=MonoStringToFName(BindName);
			FString Command_temp=MonoStringToFString(Command);
			_this->SetBind(BindName_temp,Command_temp);
			
		}
		static void SetMouseSensitivity(UPlayerInput* _this,float Sensitivity)
		{
			_this->SetMouseSensitivity(Sensitivity);
			
		}
		static UClass* StaticClass(){return UPlayerInput::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPlayerInput::ClearSmoothing",(const void*)ClearSmoothing);
			mono_add_internal_call("UnrealEngine.UPlayerInput::InvertAxis",(const void*)InvertAxis);
			mono_add_internal_call("UnrealEngine.UPlayerInput::InvertAxisKey",(const void*)InvertAxisKey);
			mono_add_internal_call("UnrealEngine.UPlayerInput::SetBind",(const void*)SetBind);
			mono_add_internal_call("UnrealEngine.UPlayerInput::SetMouseSensitivity",(const void*)SetMouseSensitivity);
			mono_add_internal_call("UnrealEngine.UPlayerInput::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
