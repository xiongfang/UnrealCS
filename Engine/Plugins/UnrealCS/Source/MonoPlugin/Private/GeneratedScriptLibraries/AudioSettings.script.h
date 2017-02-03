#pragma once

namespace UnrealEngine
{
	class _UAudioSettings
	{
		static UClass* StaticClass(){return UAudioSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAudioSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
