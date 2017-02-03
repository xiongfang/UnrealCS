#pragma once

namespace UnrealEngine
{
	class _UParticleModuleBeamTarget
	{
		static UClass* StaticClass(){return UParticleModuleBeamTarget::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleBeamTarget::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
