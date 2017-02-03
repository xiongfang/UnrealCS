#pragma once

namespace UnrealEngine
{
	class _UBreakpoint
	{
		static UClass* StaticClass(){return UBreakpoint::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBreakpoint::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
