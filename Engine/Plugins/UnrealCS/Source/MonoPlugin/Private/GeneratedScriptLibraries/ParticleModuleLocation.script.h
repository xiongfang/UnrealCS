#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocation
	{
		static UClass* StaticClass(){return UParticleModuleLocation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
