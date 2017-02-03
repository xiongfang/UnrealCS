#pragma once

namespace UnrealEngine
{
	class _USoundNodeSwitch
	{
		static UClass* StaticClass(){return USoundNodeSwitch::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeSwitch::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
