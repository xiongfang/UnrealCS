#pragma once

namespace UnrealEngine
{
	class _UDeveloperSettings
	{
		static UClass* StaticClass(){return UDeveloperSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDeveloperSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
