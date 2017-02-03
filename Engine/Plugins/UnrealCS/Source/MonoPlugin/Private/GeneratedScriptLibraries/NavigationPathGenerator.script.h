#pragma once

namespace UnrealEngine
{
	class _UNavigationPathGenerator
	{
		static UClass* StaticClass(){return UNavigationPathGenerator::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavigationPathGenerator::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
