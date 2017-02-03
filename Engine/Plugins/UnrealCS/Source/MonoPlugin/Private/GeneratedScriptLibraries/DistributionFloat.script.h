#pragma once

namespace UnrealEngine
{
	class _UDistributionFloat
	{
		static UClass* StaticClass(){return UDistributionFloat::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistributionFloat::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
