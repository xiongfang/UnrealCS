#pragma once

namespace UnrealEngine
{
	class _UPhysicsThrusterComponent
	{
		static UClass* StaticClass(){return UPhysicsThrusterComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsThrusterComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
