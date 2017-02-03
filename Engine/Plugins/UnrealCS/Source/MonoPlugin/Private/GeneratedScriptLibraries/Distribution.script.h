#pragma once

namespace UnrealEngine
{
	class _UDistribution
	{
		static UClass* StaticClass(){return UDistribution::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDistribution::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
