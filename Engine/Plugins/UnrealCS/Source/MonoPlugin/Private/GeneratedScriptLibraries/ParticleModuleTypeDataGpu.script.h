#pragma once

namespace UnrealEngine
{
	class _UParticleModuleTypeDataGpu
	{
		static UClass* StaticClass(){return UParticleModuleTypeDataGpu::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleTypeDataGpu::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
