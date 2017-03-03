#pragma once

namespace UnrealEngine
{
	class _UParticleModuleVectorFieldLocal
	{
		static UClass* StaticClass(){return UParticleModuleVectorFieldLocal::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleVectorFieldLocal::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
