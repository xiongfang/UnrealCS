#pragma once

namespace UnrealEngine
{
	class _USoundBase
	{
		static UClass* StaticClass(){return USoundBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
