#pragma once

namespace UnrealEngine
{
	class _UAnimNotifyState_TimedParticleEffect
	{
		static UClass* StaticClass(){return UAnimNotifyState_TimedParticleEffect::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimNotifyState_TimedParticleEffect::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
