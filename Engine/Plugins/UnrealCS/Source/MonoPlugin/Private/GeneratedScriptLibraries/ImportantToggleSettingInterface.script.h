#pragma once

namespace UnrealEngine
{
	class _UImportantToggleSettingInterface
	{
		static UClass* StaticClass(){return UImportantToggleSettingInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UImportantToggleSettingInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
