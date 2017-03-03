#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationPrimitiveBase
	{
		static UClass* StaticClass(){return UParticleModuleLocationPrimitiveBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationPrimitiveBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
