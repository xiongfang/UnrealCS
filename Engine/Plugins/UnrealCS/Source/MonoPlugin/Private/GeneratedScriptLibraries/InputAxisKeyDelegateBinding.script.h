#pragma once

namespace UnrealEngine
{
	class _UInputAxisKeyDelegateBinding
	{
		static UClass* StaticClass(){return UInputAxisKeyDelegateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputAxisKeyDelegateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
