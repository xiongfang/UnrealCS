#pragma once

namespace UnrealEngine
{
	class _UTouchInterface
	{
		static UClass* StaticClass(){return UTouchInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTouchInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
