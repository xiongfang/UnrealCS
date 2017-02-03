#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLifetime
	{
		static UClass* StaticClass(){return UParticleModuleLifetime::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLifetime::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
