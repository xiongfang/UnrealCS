#pragma once

namespace UnrealEngine
{
	class _UNavLinkRenderingComponent
	{
		static UClass* StaticClass(){return UNavLinkRenderingComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavLinkRenderingComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
