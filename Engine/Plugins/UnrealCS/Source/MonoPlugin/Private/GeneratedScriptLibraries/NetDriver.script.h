#pragma once

namespace UnrealEngine
{
	class _UNetDriver
	{
		static UClass* StaticClass(){return UNetDriver::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNetDriver::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
