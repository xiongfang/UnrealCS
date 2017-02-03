#pragma once

namespace UnrealEngine
{
	class _USoundConcurrency
	{
		static UClass* StaticClass(){return USoundConcurrency::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundConcurrency::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
