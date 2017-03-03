#pragma once

namespace UnrealEngine
{
	class _UNavAgentInterface
	{
		static UClass* StaticClass(){return UNavAgentInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavAgentInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
