#pragma once

namespace UnrealEngine
{
	class _UFloatingPawnMovement
	{
		static UClass* StaticClass(){return UFloatingPawnMovement::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UFloatingPawnMovement::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
