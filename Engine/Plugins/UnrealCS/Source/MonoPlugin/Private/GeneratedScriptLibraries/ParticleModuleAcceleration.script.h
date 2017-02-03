#pragma once

namespace UnrealEngine
{
	class _UParticleModuleAcceleration
	{
		static UClass* StaticClass(){return UParticleModuleAcceleration::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleAcceleration::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
