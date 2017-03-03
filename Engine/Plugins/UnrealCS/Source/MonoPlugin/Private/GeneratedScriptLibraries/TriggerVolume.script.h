#pragma once

namespace UnrealEngine
{
	class _ATriggerVolume
	{
		static UClass* StaticClass(){return ATriggerVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ATriggerVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
