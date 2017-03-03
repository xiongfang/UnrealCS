#pragma once

namespace UnrealEngine
{
	class _UAnimNotify_PlayParticleEffect
	{
		static UClass* StaticClass(){return UAnimNotify_PlayParticleEffect::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimNotify_PlayParticleEffect::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
