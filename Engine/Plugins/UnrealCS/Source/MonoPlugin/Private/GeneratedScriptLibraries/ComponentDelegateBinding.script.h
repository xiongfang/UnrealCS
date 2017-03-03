#pragma once

namespace UnrealEngine
{
	class _UComponentDelegateBinding
	{
		static UClass* StaticClass(){return UComponentDelegateBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UComponentDelegateBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
