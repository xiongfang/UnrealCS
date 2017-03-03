#pragma once

namespace UnrealEngine
{
	class _UParticleModuleSize
	{
		static UClass* StaticClass(){return UParticleModuleSize::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleSize::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
