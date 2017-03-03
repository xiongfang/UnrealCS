#pragma once

namespace UnrealEngine
{
	class _ASceneCaptureCube
	{
		static void OnInterpToggle(ASceneCaptureCube* _this,int32 bEnable)
		{
			_this->OnInterpToggle(bEnable>0?true:false);
			
		}
		static UClass* StaticClass(){return ASceneCaptureCube::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASceneCaptureCube::OnInterpToggle",(const void*)OnInterpToggle);
			mono_add_internal_call("UnrealEngine.ASceneCaptureCube::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
