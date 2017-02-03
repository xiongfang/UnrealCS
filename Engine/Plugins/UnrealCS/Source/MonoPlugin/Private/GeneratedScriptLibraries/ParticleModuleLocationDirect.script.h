#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationDirect
	{
		static UClass* StaticClass(){return UParticleModuleLocationDirect::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationDirect::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
