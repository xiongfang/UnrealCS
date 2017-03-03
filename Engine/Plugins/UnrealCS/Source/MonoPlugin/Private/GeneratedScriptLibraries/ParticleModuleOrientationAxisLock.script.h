#pragma once

namespace UnrealEngine
{
	class _UParticleModuleOrientationAxisLock
	{
		static UClass* StaticClass(){return UParticleModuleOrientationAxisLock::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleOrientationAxisLock::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
