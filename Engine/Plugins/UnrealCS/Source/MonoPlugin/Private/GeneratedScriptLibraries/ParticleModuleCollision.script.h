#pragma once

namespace UnrealEngine
{
	class _UParticleModuleCollision
	{
		static UClass* StaticClass(){return UParticleModuleCollision::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleCollision::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
