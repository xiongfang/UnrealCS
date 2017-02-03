#pragma once

namespace UnrealEngine
{
	class _USoundNodeDistanceCrossFade
	{
		static UClass* StaticClass(){return USoundNodeDistanceCrossFade::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeDistanceCrossFade::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
