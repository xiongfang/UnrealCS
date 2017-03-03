#pragma once

namespace UnrealEngine
{
	class _USoundNodeAttenuation
	{
		static UClass* StaticClass(){return USoundNodeAttenuation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeAttenuation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
