#pragma once

namespace UnrealEngine
{
	class _UParticleModuleTypeDataBase
	{
		static UClass* StaticClass(){return UParticleModuleTypeDataBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleTypeDataBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
