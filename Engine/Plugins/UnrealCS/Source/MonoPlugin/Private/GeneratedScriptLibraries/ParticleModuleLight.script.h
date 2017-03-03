#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLight
	{
		static UClass* StaticClass(){return UParticleModuleLight::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLight::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
