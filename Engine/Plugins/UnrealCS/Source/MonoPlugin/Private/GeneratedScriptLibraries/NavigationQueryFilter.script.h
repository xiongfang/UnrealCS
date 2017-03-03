#pragma once

namespace UnrealEngine
{
	class _UNavigationQueryFilter
	{
		static UClass* StaticClass(){return UNavigationQueryFilter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavigationQueryFilter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
