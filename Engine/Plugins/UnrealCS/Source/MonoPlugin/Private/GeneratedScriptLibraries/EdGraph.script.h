#pragma once

namespace UnrealEngine
{
	class _UEdGraph
	{
		static UClass* StaticClass(){return UEdGraph::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEdGraph::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
