#pragma once

namespace UnrealEngine
{
	class _UParticleModuleAttractorPoint
	{
		static UClass* StaticClass(){return UParticleModuleAttractorPoint::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleAttractorPoint::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
