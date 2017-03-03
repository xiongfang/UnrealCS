#pragma once

namespace UnrealEngine
{
	class _UParticleModuleSpawnPerUnit
	{
		static UClass* StaticClass(){return UParticleModuleSpawnPerUnit::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleSpawnPerUnit::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
