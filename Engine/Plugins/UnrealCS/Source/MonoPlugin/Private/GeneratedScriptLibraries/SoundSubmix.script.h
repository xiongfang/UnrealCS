#pragma once

namespace UnrealEngine
{
	class _USoundSubmix
	{
		static UClass* StaticClass(){return USoundSubmix::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundSubmix::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
