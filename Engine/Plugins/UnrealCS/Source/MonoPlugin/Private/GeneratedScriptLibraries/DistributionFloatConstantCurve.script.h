#pragma once

namespace UnrealEngine
{
	class _UDistributionFloatConstantCurve
	{
		static UClass* StaticClass(){return UDistributionFloatConstantCurve::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionFloatConstantCurve::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
