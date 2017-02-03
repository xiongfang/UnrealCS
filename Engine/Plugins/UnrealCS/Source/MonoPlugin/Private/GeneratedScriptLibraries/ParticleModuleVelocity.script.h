#pragma once

namespace UnrealEngine
{
	class _UParticleModuleVelocity
	{
		static UClass* StaticClass(){return UParticleModuleVelocity::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleVelocity::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
