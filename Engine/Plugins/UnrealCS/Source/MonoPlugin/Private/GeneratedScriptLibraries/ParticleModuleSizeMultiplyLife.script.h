#pragma once

namespace UnrealEngine
{
	class _UParticleModuleSizeMultiplyLife
	{
		static UClass* StaticClass(){return UParticleModuleSizeMultiplyLife::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleSizeMultiplyLife::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
