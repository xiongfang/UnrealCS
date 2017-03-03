#pragma once

namespace UnrealEngine
{
	class _APlaneReflectionCapture
	{
		static UClass* StaticClass(){return APlaneReflectionCapture::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APlaneReflectionCapture::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
