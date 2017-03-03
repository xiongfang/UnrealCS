#pragma once

namespace UnrealEngine
{
	class _UNamedSlotInterface
	{
		static UClass* StaticClass(){return UNamedSlotInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNamedSlotInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
