#pragma once

namespace UnrealEngine
{
	class _UParticleModuleVelocityCone
	{
		static UClass* StaticClass(){return UParticleModuleVelocityCone::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleVelocityCone::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
