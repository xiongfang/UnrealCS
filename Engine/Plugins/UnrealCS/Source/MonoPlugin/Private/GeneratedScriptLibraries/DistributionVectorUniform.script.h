#pragma once

namespace UnrealEngine
{
	class _UDistributionVectorUniform
	{
		static UClass* StaticClass(){return UDistributionVectorUniform::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionVectorUniform::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
