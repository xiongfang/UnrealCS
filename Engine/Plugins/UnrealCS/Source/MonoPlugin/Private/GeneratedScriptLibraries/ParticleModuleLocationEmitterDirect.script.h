#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationEmitterDirect
	{
		static UClass* StaticClass(){return UParticleModuleLocationEmitterDirect::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationEmitterDirect::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
