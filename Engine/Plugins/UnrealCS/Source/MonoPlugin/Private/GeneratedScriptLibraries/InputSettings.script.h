#pragma once

namespace UnrealEngine
{
	class _UInputSettings
	{
		static UClass* StaticClass(){return UInputSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
