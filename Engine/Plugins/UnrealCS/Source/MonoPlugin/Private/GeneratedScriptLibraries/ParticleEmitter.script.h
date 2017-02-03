#pragma once

namespace UnrealEngine
{
	class _UParticleEmitter
	{
		static UClass* StaticClass(){return UParticleEmitter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleEmitter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
