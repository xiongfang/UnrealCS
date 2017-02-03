#pragma once

namespace UnrealEngine
{
	class _USceneCaptureComponentCube
	{
		static void CaptureScene(USceneCaptureComponentCube* _this)
		{
			_this->CaptureScene();
			
		}
		static UClass* StaticClass(){return USceneCaptureComponentCube::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USceneCaptureComponentCube::CaptureScene",(const void*)CaptureScene);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponentCube::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
