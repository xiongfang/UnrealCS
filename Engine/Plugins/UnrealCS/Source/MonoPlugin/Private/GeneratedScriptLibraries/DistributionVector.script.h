#pragma once

namespace UnrealEngine
{
	class _UDistributionVector
	{
		static UClass* StaticClass(){return UDistributionVector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionVector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
