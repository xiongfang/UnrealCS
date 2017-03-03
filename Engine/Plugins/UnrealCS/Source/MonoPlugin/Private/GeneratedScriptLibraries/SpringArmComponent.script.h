#pragma once

namespace UnrealEngine
{
	class _USpringArmComponent
	{
		static UClass* StaticClass(){return USpringArmComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USpringArmComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
