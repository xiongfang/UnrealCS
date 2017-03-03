#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLight_Seeded
	{
		static UClass* StaticClass(){return UParticleModuleLight_Seeded::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLight_Seeded::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
