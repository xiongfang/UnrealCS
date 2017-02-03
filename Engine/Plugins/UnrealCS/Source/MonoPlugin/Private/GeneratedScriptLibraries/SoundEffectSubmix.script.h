#pragma once

namespace UnrealEngine
{
	class _USoundEffectSubmix
	{
		static UClass* StaticClass(){return USoundEffectSubmix::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundEffectSubmix::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
