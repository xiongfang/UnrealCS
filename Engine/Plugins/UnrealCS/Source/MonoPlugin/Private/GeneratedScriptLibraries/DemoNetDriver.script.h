#pragma once

namespace UnrealEngine
{
	class _UDemoNetDriver
	{
		static UClass* StaticClass(){return UDemoNetDriver::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDemoNetDriver::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
