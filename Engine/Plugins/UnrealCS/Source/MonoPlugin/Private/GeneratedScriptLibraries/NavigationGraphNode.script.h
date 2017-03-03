#pragma once

namespace UnrealEngine
{
	class _ANavigationGraphNode
	{
		static UClass* StaticClass(){return ANavigationGraphNode::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANavigationGraphNode::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
