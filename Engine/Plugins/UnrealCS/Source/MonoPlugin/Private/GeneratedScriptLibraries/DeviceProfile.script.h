#pragma once

namespace UnrealEngine
{
	class _UDeviceProfile
	{
		static UClass* StaticClass(){return UDeviceProfile::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDeviceProfile::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
