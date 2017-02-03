#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationWorldOffset_Seeded
	{
		static UClass* StaticClass(){return UParticleModuleLocationWorldOffset_Seeded::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationWorldOffset_Seeded::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
