#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationPrimitiveCylinder
	{
		static UClass* StaticClass(){return UParticleModuleLocationPrimitiveCylinder::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationPrimitiveCylinder::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
