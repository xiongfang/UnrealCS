#pragma once

namespace UnrealEngine
{
	class _AAtmosphericFog
	{
		static UClass* StaticClass(){return AAtmosphericFog::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AAtmosphericFog::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
