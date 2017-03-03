#pragma once

namespace UnrealEngine
{
	class _USoundNodeModulator
	{
		static UClass* StaticClass(){return USoundNodeModulator::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeModulator::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
