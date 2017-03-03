#pragma once

namespace UnrealEngine
{
	class _AReflectionCapture
	{
		static UClass* StaticClass(){return AReflectionCapture::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AReflectionCapture::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
