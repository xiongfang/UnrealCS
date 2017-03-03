#pragma once

namespace UnrealEngine
{
	class _UEdGraphNode_Documentation
	{
		static UClass* StaticClass(){return UEdGraphNode_Documentation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEdGraphNode_Documentation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
