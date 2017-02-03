#pragma once

namespace UnrealEngine
{
	class _UWidgetNavigation
	{
		static UClass* StaticClass(){return UWidgetNavigation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetNavigation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
