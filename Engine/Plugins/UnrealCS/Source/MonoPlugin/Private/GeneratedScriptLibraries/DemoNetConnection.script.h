#pragma once

namespace UnrealEngine
{
	class _UDemoNetConnection
	{
		static UClass* StaticClass(){return UDemoNetConnection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDemoNetConnection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
