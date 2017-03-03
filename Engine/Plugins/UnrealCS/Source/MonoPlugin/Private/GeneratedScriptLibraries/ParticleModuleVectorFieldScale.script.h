#pragma once

namespace UnrealEngine
{
	class _UParticleModuleVectorFieldScale
	{
		static UClass* StaticClass(){return UParticleModuleVectorFieldScale::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleVectorFieldScale::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
