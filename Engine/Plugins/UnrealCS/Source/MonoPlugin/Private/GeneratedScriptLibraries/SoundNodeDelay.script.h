#pragma once

namespace UnrealEngine
{
	class _USoundNodeDelay
	{
		static UClass* StaticClass(){return USoundNodeDelay::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeDelay::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
