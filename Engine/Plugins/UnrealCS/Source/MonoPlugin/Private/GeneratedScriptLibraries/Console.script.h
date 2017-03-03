#pragma once

namespace UnrealEngine
{
	class _UConsole
	{
		static UClass* StaticClass(){return UConsole::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UConsole::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
