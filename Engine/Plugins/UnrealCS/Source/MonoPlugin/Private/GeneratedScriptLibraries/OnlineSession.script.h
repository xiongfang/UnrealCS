#pragma once

namespace UnrealEngine
{
	class _UOnlineSession
	{
		static UClass* StaticClass(){return UOnlineSession::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UOnlineSession::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
