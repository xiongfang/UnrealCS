#pragma once

namespace UnrealEngine
{
	class _UDistributionFloatParticleParameter
	{
		static UClass* StaticClass(){return UDistributionFloatParticleParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionFloatParticleParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
