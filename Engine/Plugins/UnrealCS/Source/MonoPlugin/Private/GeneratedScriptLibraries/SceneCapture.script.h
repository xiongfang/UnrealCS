#pragma once

namespace UnrealEngine
{
	class _ASceneCapture
	{
		static UClass* StaticClass(){return ASceneCapture::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASceneCapture::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
