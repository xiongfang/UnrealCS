#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationPrimitiveCylinder_Seeded
	{
		static UClass* StaticClass(){return UParticleModuleLocationPrimitiveCylinder_Seeded::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationPrimitiveCylinder_Seeded::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
