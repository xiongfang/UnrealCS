#pragma once

namespace UnrealEngine
{
	class _URVOAvoidanceInterface
	{
		static UClass* StaticClass(){return URVOAvoidanceInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URVOAvoidanceInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
