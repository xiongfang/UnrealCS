#pragma once

namespace UnrealEngine
{
	class _USoundNodeWavePlayer
	{
		static UClass* StaticClass(){return USoundNodeWavePlayer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeWavePlayer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
