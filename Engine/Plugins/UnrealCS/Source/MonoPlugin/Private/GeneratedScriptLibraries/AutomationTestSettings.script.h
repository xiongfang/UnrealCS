#pragma once

namespace UnrealEngine
{
	class _UAutomationTestSettings
	{
		static UClass* StaticClass(){return UAutomationTestSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAutomationTestSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
