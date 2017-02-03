#pragma once

namespace UnrealEngine
{
	class _UInputVectorAxisDelegateBinding
	{
		static UClass* StaticClass(){return UInputVectorAxisDelegateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputVectorAxisDelegateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
