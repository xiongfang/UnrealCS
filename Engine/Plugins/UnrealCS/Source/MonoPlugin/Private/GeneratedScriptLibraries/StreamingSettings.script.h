#pragma once

namespace UnrealEngine
{
	class _UStreamingSettings
	{
		static UClass* StaticClass(){return UStreamingSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UStreamingSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
