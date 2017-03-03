#pragma once

namespace UnrealEngine
{
	class _UAnimNotifyState_Trail
	{
		static UClass* StaticClass(){return UAnimNotifyState_Trail::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimNotifyState_Trail::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
