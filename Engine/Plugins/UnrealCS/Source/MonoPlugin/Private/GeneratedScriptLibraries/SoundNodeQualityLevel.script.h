#pragma once

namespace UnrealEngine
{
	class _USoundNodeQualityLevel
	{
		static UClass* StaticClass(){return USoundNodeQualityLevel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeQualityLevel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
