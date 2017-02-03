#pragma once

namespace UnrealEngine
{
	class _UDistributionFloatUniform
	{
		static UClass* StaticClass(){return UDistributionFloatUniform::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionFloatUniform::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
