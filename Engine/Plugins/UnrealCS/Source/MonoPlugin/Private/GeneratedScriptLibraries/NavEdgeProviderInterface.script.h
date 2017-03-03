#pragma once

namespace UnrealEngine
{
	class _UNavEdgeProviderInterface
	{
		static UClass* StaticClass(){return UNavEdgeProviderInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavEdgeProviderInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
