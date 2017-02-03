#pragma once

namespace UnrealEngine
{
	class _UDistributionFloatUniformCurve
	{
		static UClass* StaticClass(){return UDistributionFloatUniformCurve::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionFloatUniformCurve::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
