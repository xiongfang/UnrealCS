#pragma once

namespace UnrealEngine
{
	class _USoundAttenuation
	{
		static UClass* StaticClass(){return USoundAttenuation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundAttenuation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
