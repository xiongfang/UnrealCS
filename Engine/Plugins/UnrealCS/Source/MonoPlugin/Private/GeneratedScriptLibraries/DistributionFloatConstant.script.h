#pragma once

namespace UnrealEngine
{
	class _UDistributionFloatConstant
	{
		static UClass* StaticClass(){return UDistributionFloatConstant::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionFloatConstant::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
