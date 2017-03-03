#pragma once

namespace UnrealEngine
{
	class _UNamedSlot
	{
		static UClass* StaticClass(){return UNamedSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNamedSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
