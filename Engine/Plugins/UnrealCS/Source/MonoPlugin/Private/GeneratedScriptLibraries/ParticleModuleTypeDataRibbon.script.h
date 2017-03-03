#pragma once

namespace UnrealEngine
{
	class _UParticleModuleTypeDataRibbon
	{
		static UClass* StaticClass(){return UParticleModuleTypeDataRibbon::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleTypeDataRibbon::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
