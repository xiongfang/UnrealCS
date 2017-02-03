#pragma once

namespace UnrealEngine
{
	class _USafeZone
	{
		static UClass* StaticClass(){return USafeZone::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USafeZone::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
