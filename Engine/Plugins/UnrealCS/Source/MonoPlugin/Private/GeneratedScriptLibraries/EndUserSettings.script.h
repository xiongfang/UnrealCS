#pragma once

namespace UnrealEngine
{
	class _UEndUserSettings
	{
		static UClass* StaticClass(){return UEndUserSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEndUserSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
