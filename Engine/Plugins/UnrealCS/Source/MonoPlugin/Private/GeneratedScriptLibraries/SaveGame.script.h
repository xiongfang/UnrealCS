#pragma once

namespace UnrealEngine
{
	class _USaveGame
	{
		static UClass* StaticClass(){return USaveGame::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USaveGame::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
