#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationPrimitiveSphere
	{
		static UClass* StaticClass(){return UParticleModuleLocationPrimitiveSphere::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationPrimitiveSphere::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
