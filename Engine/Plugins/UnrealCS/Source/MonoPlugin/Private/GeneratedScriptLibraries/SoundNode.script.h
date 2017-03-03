#pragma once

namespace UnrealEngine
{
	class _USoundNode
	{
		static UClass* StaticClass(){return USoundNode::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNode::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
