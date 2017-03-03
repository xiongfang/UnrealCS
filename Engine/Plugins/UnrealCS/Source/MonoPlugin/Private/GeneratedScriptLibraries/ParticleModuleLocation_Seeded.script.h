#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocation_Seeded
	{
		static UClass* StaticClass(){return UParticleModuleLocation_Seeded::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocation_Seeded::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
