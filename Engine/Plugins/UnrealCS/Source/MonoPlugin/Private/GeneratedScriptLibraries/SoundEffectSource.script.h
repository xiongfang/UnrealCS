#pragma once

namespace UnrealEngine
{
	class _USoundEffectSource
	{
		static UClass* StaticClass(){return USoundEffectSource::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundEffectSource::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
