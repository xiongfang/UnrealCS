#pragma once

namespace UnrealEngine
{
	class _ADebugCameraController
	{
		static AActor* GetSelectedActor(ADebugCameraController* _this)
		{
			AActor* ___ret = _this->GetSelectedActor();
			return ___ret;
			
		}
		static void ToggleDisplay(ADebugCameraController* _this)
		{
			_this->ToggleDisplay();
			
		}
		static void ShowDebugSelectedInfo(ADebugCameraController* _this)
		{
			_this->ShowDebugSelectedInfo();
			
		}
		static UClass* StaticClass(){return ADebugCameraController::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ADebugCameraController::GetSelectedActor",(const void*)GetSelectedActor);
			mono_add_internal_call("UnrealEngine.ADebugCameraController::ToggleDisplay",(const void*)ToggleDisplay);
			mono_add_internal_call("UnrealEngine.ADebugCameraController::ShowDebugSelectedInfo",(const void*)ShowDebugSelectedInfo);
			mono_add_internal_call("UnrealEngine.ADebugCameraController::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
