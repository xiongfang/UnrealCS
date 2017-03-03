#pragma once

namespace UnrealEngine
{
	class _USlateWidgetStyleContainerInterface
	{
		static UClass* StaticClass(){return USlateWidgetStyleContainerInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlateWidgetStyleContainerInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
