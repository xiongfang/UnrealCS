#pragma once

namespace UnrealEngine
{
	class _UUserInterfaceSettings
	{
		static UClass* StaticClass(){return UUserInterfaceSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UUserInterfaceSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
