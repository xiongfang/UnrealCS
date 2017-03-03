#pragma once

namespace UnrealEngine
{
	class _UDPICustomScalingRule
	{
		static UClass* StaticClass(){return UDPICustomScalingRule::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDPICustomScalingRule::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
