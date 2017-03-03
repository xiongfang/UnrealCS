#pragma once

namespace UnrealEngine
{
	class _UParticleSystem
	{
		static UClass* StaticClass(){return UParticleSystem::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleSystem::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
