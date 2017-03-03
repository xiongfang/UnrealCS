#pragma once

namespace UnrealEngine
{
	class _UNetworkSettings
	{
		static UClass* StaticClass(){return UNetworkSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNetworkSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
