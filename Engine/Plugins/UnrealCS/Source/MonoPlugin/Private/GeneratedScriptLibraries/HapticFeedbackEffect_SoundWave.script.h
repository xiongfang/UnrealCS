#pragma once

namespace UnrealEngine
{
	class _UHapticFeedbackEffect_SoundWave
	{
		static UClass* StaticClass(){return UHapticFeedbackEffect_SoundWave::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHapticFeedbackEffect_SoundWave::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
