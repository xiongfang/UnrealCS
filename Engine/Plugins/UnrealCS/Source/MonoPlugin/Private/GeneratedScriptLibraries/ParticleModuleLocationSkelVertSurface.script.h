#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationSkelVertSurface
	{
		static UClass* StaticClass(){return UParticleModuleLocationSkelVertSurface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationSkelVertSurface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
