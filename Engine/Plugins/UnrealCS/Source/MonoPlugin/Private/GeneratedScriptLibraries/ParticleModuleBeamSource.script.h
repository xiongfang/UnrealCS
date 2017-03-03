#pragma once

namespace UnrealEngine
{
	class _UParticleModuleBeamSource
	{
		static UClass* StaticClass(){return UParticleModuleBeamSource::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleBeamSource::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
