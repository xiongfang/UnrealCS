#pragma once

namespace UnrealEngine
{
	class _UPostProcessComponent
	{
		static UClass* StaticClass(){return UPostProcessComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPostProcessComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
