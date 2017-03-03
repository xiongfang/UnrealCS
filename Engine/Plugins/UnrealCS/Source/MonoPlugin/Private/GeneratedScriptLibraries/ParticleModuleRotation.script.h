#pragma once

namespace UnrealEngine
{
	class _UParticleModuleRotation
	{
		static UClass* StaticClass(){return UParticleModuleRotation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleRotation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
