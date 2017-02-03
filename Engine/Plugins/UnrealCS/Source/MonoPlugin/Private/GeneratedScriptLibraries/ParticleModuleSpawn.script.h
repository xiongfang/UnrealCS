#pragma once

namespace UnrealEngine
{
	class _UParticleModuleSpawn
	{
		static UClass* StaticClass(){return UParticleModuleSpawn::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleSpawn::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
