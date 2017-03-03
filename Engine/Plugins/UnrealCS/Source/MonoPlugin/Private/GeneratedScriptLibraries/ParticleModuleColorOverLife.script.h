#pragma once

namespace UnrealEngine
{
	class _UParticleModuleColorOverLife
	{
		static UClass* StaticClass(){return UParticleModuleColorOverLife::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleColorOverLife::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
