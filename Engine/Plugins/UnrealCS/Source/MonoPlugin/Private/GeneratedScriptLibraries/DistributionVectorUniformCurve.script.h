#pragma once

namespace UnrealEngine
{
	class _UDistributionVectorUniformCurve
	{
		static UClass* StaticClass(){return UDistributionVectorUniformCurve::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionVectorUniformCurve::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
