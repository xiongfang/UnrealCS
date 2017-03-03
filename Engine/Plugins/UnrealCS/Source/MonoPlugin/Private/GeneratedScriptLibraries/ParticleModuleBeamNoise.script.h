#pragma once

namespace UnrealEngine
{
	class _UParticleModuleBeamNoise
	{
		static UClass* StaticClass(){return UParticleModuleBeamNoise::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleBeamNoise::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
