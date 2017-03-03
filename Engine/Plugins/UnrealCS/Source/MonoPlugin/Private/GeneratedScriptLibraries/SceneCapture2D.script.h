#pragma once

namespace UnrealEngine
{
	class _ASceneCapture2D
	{
		static UClass* StaticClass(){return ASceneCapture2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASceneCapture2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
