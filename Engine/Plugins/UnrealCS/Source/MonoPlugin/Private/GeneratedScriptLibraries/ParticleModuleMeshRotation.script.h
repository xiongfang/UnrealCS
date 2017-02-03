#pragma once

namespace UnrealEngine
{
	class _UParticleModuleMeshRotation
	{
		static UClass* StaticClass(){return UParticleModuleMeshRotation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleMeshRotation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
