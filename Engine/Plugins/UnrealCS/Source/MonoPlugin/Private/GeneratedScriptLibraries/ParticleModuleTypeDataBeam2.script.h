#pragma once

namespace UnrealEngine
{
	class _UParticleModuleTypeDataBeam2
	{
		static UClass* StaticClass(){return UParticleModuleTypeDataBeam2::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleTypeDataBeam2::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
