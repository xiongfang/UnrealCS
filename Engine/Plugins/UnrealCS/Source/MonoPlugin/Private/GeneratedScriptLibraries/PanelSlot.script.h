#pragma once

namespace UnrealEngine
{
	class _UPanelSlot
	{
		static UClass* StaticClass(){return UPanelSlot::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPanelSlot::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
