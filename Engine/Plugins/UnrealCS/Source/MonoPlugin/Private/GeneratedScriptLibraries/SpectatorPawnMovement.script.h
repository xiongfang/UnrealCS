#pragma once

namespace UnrealEngine
{
	class _USpectatorPawnMovement
	{
		static UClass* StaticClass(){return USpectatorPawnMovement::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USpectatorPawnMovement::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
