#pragma once

namespace UnrealEngine
{
	class _URotatingMovementComponent
	{
		static UClass* StaticClass(){return URotatingMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URotatingMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
