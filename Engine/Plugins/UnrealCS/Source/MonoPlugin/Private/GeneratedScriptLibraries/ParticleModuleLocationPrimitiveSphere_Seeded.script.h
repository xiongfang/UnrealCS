#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationPrimitiveSphere_Seeded
	{
		static UClass* StaticClass(){return UParticleModuleLocationPrimitiveSphere_Seeded::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationPrimitiveSphere_Seeded::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
