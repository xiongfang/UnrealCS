#pragma once

namespace UnrealEngine
{
	class _UParticleModuleParameterDynamic
	{
		static UClass* StaticClass(){return UParticleModuleParameterDynamic::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleParameterDynamic::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
