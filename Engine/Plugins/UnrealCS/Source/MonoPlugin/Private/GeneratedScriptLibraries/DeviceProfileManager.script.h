#pragma once

namespace UnrealEngine
{
	class _UDeviceProfileManager
	{
		static UClass* StaticClass(){return UDeviceProfileManager::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDeviceProfileManager::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
