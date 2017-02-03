#pragma once

namespace UnrealEngine
{
	class _UDistributionVectorParticleParameter
	{
		static UClass* StaticClass(){return UDistributionVectorParticleParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionVectorParticleParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
