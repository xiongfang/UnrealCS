#pragma once

namespace UnrealEngine
{
	class _UDistributionVectorConstantCurve
	{
		static UClass* StaticClass(){return UDistributionVectorConstantCurve::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionVectorConstantCurve::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
