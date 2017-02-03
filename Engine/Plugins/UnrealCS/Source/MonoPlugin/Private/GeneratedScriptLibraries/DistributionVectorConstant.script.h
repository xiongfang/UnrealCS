#pragma once

namespace UnrealEngine
{
	class _UDistributionVectorConstant
	{
		static UClass* StaticClass(){return UDistributionVectorConstant::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionVectorConstant::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
