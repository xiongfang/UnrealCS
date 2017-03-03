#pragma once

namespace UnrealEngine
{
	class _UParticleModuleSubUV
	{
		static UClass* StaticClass(){return UParticleModuleSubUV::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleSubUV::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
