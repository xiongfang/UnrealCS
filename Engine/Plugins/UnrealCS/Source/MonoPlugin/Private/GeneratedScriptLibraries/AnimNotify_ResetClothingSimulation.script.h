#pragma once

namespace UnrealEngine
{
	class _UAnimNotify_ResetClothingSimulation
	{
		static UClass* StaticClass(){return UAnimNotify_ResetClothingSimulation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimNotify_ResetClothingSimulation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
