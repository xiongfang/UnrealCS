#pragma once

namespace UnrealEngine
{
	class _UParticleModulePivotOffset
	{
		static UClass* StaticClass(){return UParticleModulePivotOffset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModulePivotOffset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
