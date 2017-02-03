#pragma once

namespace UnrealEngine
{
	class _USoundNodeRandom
	{
		static UClass* StaticClass(){return USoundNodeRandom::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeRandom::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
