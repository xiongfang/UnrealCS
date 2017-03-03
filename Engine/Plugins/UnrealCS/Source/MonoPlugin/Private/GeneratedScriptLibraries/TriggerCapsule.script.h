#pragma once

namespace UnrealEngine
{
	class _ATriggerCapsule
	{
		static UClass* StaticClass(){return ATriggerCapsule::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ATriggerCapsule::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
