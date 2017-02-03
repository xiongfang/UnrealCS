#pragma once

namespace UnrealEngine
{
	class _UInputAxisDelegateBinding
	{
		static UClass* StaticClass(){return UInputAxisDelegateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputAxisDelegateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
