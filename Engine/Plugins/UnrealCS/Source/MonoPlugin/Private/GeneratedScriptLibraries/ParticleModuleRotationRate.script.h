#pragma once

namespace UnrealEngine
{
	class _UParticleModuleRotationRate
	{
		static UClass* StaticClass(){return UParticleModuleRotationRate::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleRotationRate::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
