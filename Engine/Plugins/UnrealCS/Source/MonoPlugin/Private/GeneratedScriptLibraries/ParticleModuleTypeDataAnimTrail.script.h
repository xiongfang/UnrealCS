#pragma once

namespace UnrealEngine
{
	class _UParticleModuleTypeDataAnimTrail
	{
		static UClass* StaticClass(){return UParticleModuleTypeDataAnimTrail::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleTypeDataAnimTrail::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
