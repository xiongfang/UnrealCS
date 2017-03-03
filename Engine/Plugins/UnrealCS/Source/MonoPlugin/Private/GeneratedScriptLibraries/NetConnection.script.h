#pragma once

namespace UnrealEngine
{
	class _UNetConnection
	{
		static UClass* StaticClass(){return UNetConnection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNetConnection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
