#pragma once

namespace UnrealEngine
{
	class _UNativeWidgetHost
	{
		static UClass* StaticClass(){return UNativeWidgetHost::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNativeWidgetHost::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
