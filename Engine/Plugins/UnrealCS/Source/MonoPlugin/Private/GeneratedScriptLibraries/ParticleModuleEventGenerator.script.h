#pragma once

namespace UnrealEngine
{
	class _UParticleModuleEventGenerator
	{
		static UClass* StaticClass(){return UParticleModuleEventGenerator::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleEventGenerator::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
