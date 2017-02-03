#pragma once

namespace UnrealEngine
{
	class _ANote
	{
		static UClass* StaticClass(){return ANote::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANote::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
