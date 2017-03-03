#pragma once

namespace UnrealEngine
{
	class _ULevelStreamingAlwaysLoaded
	{
		static UClass* StaticClass(){return ULevelStreamingAlwaysLoaded::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULevelStreamingAlwaysLoaded::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
