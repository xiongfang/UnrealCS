#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationBase
	{
		static UClass* StaticClass(){return UParticleModuleLocationBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
