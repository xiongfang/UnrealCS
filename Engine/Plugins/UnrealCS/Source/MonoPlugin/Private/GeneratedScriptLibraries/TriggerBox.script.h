#pragma once

namespace UnrealEngine
{
	class _ATriggerBox
	{
		static UClass* StaticClass(){return ATriggerBox::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ATriggerBox::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
