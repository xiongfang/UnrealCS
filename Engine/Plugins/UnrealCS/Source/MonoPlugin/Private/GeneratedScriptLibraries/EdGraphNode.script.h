#pragma once

namespace UnrealEngine
{
	class _UEdGraphNode
	{
		static UClass* StaticClass(){return UEdGraphNode::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEdGraphNode::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
