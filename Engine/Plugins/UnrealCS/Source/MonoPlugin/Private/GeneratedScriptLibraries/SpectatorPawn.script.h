#pragma once

namespace UnrealEngine
{
	class _ASpectatorPawn
	{
		static UClass* StaticClass(){return ASpectatorPawn::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASpectatorPawn::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
