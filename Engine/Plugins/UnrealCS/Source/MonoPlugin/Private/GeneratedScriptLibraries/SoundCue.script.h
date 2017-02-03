#pragma once

namespace UnrealEngine
{
	class _USoundCue
	{
		static UClass* StaticClass(){return USoundCue::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundCue::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
