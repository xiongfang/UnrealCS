#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationEmitter
	{
		static UClass* StaticClass(){return UParticleModuleLocationEmitter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationEmitter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
