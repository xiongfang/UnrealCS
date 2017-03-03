#pragma once

namespace UnrealEngine
{
	class _UChildConnection
	{
		static UClass* StaticClass(){return UChildConnection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UChildConnection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
