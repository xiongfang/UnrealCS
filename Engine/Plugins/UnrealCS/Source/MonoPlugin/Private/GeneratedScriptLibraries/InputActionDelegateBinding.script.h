#pragma once

namespace UnrealEngine
{
	class _UInputActionDelegateBinding
	{
		static UClass* StaticClass(){return UInputActionDelegateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputActionDelegateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
