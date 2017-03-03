#pragma once

namespace UnrealEngine
{
	class _UReporterGraph
	{
		static UClass* StaticClass(){return UReporterGraph::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UReporterGraph::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
