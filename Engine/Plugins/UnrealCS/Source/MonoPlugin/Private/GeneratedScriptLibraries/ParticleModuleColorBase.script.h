#pragma once

namespace UnrealEngine
{
	class _UParticleModuleColorBase
	{
		static UClass* StaticClass(){return UParticleModuleColorBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleColorBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
