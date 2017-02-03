#pragma once

namespace UnrealEngine
{
	class _UDrawSphereComponent
	{
		static UClass* StaticClass(){return UDrawSphereComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDrawSphereComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
