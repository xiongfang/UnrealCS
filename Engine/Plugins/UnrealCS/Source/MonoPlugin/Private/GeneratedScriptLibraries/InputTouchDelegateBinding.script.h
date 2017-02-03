#pragma once

namespace UnrealEngine
{
	class _UInputTouchDelegateBinding
	{
		static UClass* StaticClass(){return UInputTouchDelegateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputTouchDelegateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
