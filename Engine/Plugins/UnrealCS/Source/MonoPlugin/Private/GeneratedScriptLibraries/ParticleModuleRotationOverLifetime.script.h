#pragma once

namespace UnrealEngine
{
	class _UParticleModuleRotationOverLifetime
	{
		static UClass* StaticClass(){return UParticleModuleRotationOverLifetime::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleRotationOverLifetime::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
