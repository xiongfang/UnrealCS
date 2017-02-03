#pragma once

namespace UnrealEngine
{
	class _UParticleModuleAttractorLine
	{
		static UClass* StaticClass(){return UParticleModuleAttractorLine::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleAttractorLine::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
