#pragma once

namespace UnrealEngine
{
	class _UParticleModuleAccelerationOverLifetime
	{
		static UClass* StaticClass(){return UParticleModuleAccelerationOverLifetime::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleAccelerationOverLifetime::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
