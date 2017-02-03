#pragma once

namespace UnrealEngine
{
	class _UParticleModuleSourceMovement
	{
		static UClass* StaticClass(){return UParticleModuleSourceMovement::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleSourceMovement::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
