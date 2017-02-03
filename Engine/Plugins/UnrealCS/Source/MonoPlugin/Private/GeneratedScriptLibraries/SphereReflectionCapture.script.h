#pragma once

namespace UnrealEngine
{
	class _ASphereReflectionCapture
	{
		static UClass* StaticClass(){return ASphereReflectionCapture::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASphereReflectionCapture::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
