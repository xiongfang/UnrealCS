#pragma once

namespace UnrealEngine
{
	class _UInputKeyDelegateBinding
	{
		static UClass* StaticClass(){return UInputKeyDelegateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputKeyDelegateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
