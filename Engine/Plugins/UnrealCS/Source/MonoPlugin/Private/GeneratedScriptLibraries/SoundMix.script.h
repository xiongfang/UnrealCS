#pragma once

namespace UnrealEngine
{
	class _USoundMix
	{
		static UClass* StaticClass(){return USoundMix::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundMix::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
