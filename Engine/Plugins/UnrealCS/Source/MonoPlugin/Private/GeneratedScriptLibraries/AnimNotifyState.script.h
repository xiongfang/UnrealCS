#pragma once

namespace UnrealEngine
{
	class _UAnimNotifyState
	{
		static UClass* StaticClass(){return UAnimNotifyState::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimNotifyState::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
