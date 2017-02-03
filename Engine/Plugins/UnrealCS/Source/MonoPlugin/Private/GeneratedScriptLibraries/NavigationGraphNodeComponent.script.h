#pragma once

namespace UnrealEngine
{
	class _UNavigationGraphNodeComponent
	{
		static UClass* StaticClass(){return UNavigationGraphNodeComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavigationGraphNodeComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
