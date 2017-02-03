#pragma once

namespace UnrealEngine
{
	class _UParticleModuleAttractorParticle
	{
		static UClass* StaticClass(){return UParticleModuleAttractorParticle::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleAttractorParticle::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
