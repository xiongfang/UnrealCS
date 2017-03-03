#pragma once

namespace UnrealEngine
{
	class _UParticleModuleAccelerationDrag
	{
		static UClass* StaticClass(){return UParticleModuleAccelerationDrag::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleAccelerationDrag::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
