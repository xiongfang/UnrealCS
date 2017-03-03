#pragma once

namespace UnrealEngine
{
	class _UParticleModuleTrailSource
	{
		static UClass* StaticClass(){return UParticleModuleTrailSource::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleTrailSource::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
