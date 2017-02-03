#pragma once

namespace UnrealEngine
{
	class _UParticleModuleCollisionGPU
	{
		static UClass* StaticClass(){return UParticleModuleCollisionGPU::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleCollisionGPU::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
