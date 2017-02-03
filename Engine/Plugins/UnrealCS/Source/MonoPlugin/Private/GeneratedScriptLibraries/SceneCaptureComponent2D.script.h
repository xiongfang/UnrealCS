#pragma once

namespace UnrealEngine
{
	class _USceneCaptureComponent2D
	{
		static void CaptureScene(USceneCaptureComponent2D* _this)
		{
			_this->CaptureScene();
			
		}
		static UClass* StaticClass(){return USceneCaptureComponent2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent2D::CaptureScene",(const void*)CaptureScene);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
