#pragma once

namespace UnrealEngine
{
	class _UParticleModuleVelocityInheritParent
	{
		static UClass* StaticClass(){return UParticleModuleVelocityInheritParent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleVelocityInheritParent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
