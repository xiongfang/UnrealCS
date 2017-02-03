#pragma once

namespace UnrealEngine
{
	class _UParticleModuleRequired
	{
		static UClass* StaticClass(){return UParticleModuleRequired::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleRequired::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
