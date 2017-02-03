#pragma once

namespace UnrealEngine
{
	class _ABoxReflectionCapture
	{
		static UClass* StaticClass(){return ABoxReflectionCapture::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ABoxReflectionCapture::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
