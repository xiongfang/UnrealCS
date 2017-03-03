#pragma once

namespace UnrealEngine
{
	class _UParticleModuleVelocityOverLifetime
	{
		static UClass* StaticClass(){return UParticleModuleVelocityOverLifetime::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleVelocityOverLifetime::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
