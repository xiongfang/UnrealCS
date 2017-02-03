#pragma once

namespace UnrealEngine
{
	class _UInputComponent
	{
		static UClass* StaticClass(){return UInputComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInputComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
