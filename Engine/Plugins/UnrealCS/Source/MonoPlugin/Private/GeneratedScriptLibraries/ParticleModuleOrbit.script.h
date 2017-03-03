#pragma once

namespace UnrealEngine
{
	class _UParticleModuleOrbit
	{
		static UClass* StaticClass(){return UParticleModuleOrbit::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleOrbit::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
