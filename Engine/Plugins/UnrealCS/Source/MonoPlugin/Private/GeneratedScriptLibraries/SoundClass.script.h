#pragma once

namespace UnrealEngine
{
	class _USoundClass
	{
		static UClass* StaticClass(){return USoundClass::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundClass::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
