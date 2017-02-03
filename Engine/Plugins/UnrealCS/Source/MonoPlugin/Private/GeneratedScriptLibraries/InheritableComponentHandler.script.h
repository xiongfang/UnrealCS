#pragma once

namespace UnrealEngine
{
	class _UInheritableComponentHandler
	{
		static UClass* StaticClass(){return UInheritableComponentHandler::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInheritableComponentHandler::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
