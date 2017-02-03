#pragma once

namespace UnrealEngine
{
	class _UParticleModuleMeshMaterial
	{
		static UClass* StaticClass(){return UParticleModuleMeshMaterial::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleMeshMaterial::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
