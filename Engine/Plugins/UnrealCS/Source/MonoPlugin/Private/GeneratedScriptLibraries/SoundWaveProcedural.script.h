#pragma once

namespace UnrealEngine
{
	class _USoundWaveProcedural
	{
		static UClass* StaticClass(){return USoundWaveProcedural::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundWaveProcedural::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
