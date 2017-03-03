#pragma once

namespace UnrealEngine
{
	class _UParticleModule
	{
		static UClass* StaticClass(){return UParticleModule::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModule::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
