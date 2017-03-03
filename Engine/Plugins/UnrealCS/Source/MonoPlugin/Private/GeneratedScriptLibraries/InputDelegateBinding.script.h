#pragma once

namespace UnrealEngine
{
	class _UInputDelegateBinding
	{
		static UClass* StaticClass(){return UInputDelegateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputDelegateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
