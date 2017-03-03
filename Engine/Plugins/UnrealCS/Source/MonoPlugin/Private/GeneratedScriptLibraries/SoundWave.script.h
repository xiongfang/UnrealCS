#pragma once

namespace UnrealEngine
{
	class _USoundWave
	{
		static UClass* StaticClass(){return USoundWave::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundWave::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
