#pragma once

namespace UnrealEngine
{
	class _UParticleModuleColorScaleOverLife
	{
		static UClass* StaticClass(){return UParticleModuleColorScaleOverLife::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleColorScaleOverLife::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
