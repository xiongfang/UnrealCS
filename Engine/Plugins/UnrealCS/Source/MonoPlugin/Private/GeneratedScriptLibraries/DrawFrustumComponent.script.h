#pragma once

namespace UnrealEngine
{
	class _UDrawFrustumComponent
	{
		static UClass* StaticClass(){return UDrawFrustumComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDrawFrustumComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
