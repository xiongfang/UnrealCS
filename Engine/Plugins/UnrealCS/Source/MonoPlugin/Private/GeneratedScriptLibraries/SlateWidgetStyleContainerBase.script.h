#pragma once

namespace UnrealEngine
{
	class _USlateWidgetStyleContainerBase
	{
		static UClass* StaticClass(){return USlateWidgetStyleContainerBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlateWidgetStyleContainerBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
