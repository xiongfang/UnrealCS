#pragma once

namespace UnrealEngine
{
	class _UPlanarReflectionComponent
	{
		static UClass* StaticClass(){return UPlanarReflectionComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPlanarReflectionComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
