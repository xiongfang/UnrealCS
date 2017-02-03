#pragma once

namespace UnrealEngine
{
	class _USCS_Node
	{
		static UClass* StaticClass(){return USCS_Node::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USCS_Node::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
