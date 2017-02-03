#pragma once

namespace UnrealEngine
{
	class _ADebugCameraHUD
	{
		static UClass* StaticClass(){return ADebugCameraHUD::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ADebugCameraHUD::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
