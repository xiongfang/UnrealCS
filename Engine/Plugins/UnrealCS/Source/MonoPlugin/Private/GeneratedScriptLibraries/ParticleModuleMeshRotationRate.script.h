#pragma once

namespace UnrealEngine
{
	class _UParticleModuleMeshRotationRate
	{
		static UClass* StaticClass(){return UParticleModuleMeshRotationRate::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleMeshRotationRate::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
