#pragma once

namespace UnrealEngine
{
	class _UParticleModuleRotationRateMultiplyLife
	{
		static UClass* StaticClass(){return UParticleModuleRotationRateMultiplyLife::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleRotationRateMultiplyLife::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
