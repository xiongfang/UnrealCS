#pragma once

namespace UnrealEngine
{
	class _AGameSession
	{
		static UClass* StaticClass(){return AGameSession::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AGameSession::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
