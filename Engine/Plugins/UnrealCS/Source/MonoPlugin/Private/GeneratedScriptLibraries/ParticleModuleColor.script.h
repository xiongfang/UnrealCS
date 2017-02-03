#pragma once

namespace UnrealEngine
{
	class _UParticleModuleColor
	{
		static UClass* StaticClass(){return UParticleModuleColor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleColor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
