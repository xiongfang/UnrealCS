#pragma once

namespace UnrealEngine
{
	class _ANavigationGraph
	{
		static UClass* StaticClass(){return ANavigationGraph::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANavigationGraph::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
