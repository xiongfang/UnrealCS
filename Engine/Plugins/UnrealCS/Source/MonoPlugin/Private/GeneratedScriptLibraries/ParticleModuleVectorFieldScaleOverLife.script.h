#pragma once

namespace UnrealEngine
{
	class _UParticleModuleVectorFieldScaleOverLife
	{
		static UClass* StaticClass(){return UParticleModuleVectorFieldScaleOverLife::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleVectorFieldScaleOverLife::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
