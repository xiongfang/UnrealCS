#pragma once

namespace UnrealEngine
{
	class _UParticleModuleLocationWorldOffset
	{
		static UClass* StaticClass(){return UParticleModuleLocationWorldOffset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleLocationWorldOffset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
