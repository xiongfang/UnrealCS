#pragma once

namespace UnrealEngine
{
	class _UParticleModuleSizeScale
	{
		static UClass* StaticClass(){return UParticleModuleSizeScale::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleSizeScale::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
