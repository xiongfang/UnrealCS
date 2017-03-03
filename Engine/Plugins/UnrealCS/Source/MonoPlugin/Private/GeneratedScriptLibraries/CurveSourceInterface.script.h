#pragma once

namespace UnrealEngine
{
	class _UCurveSourceInterface
	{
		static UClass* StaticClass(){return UCurveSourceInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCurveSourceInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
