#pragma once

namespace UnrealEngine
{
	class _ATriggerBase
	{
		static UClass* StaticClass(){return ATriggerBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ATriggerBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
