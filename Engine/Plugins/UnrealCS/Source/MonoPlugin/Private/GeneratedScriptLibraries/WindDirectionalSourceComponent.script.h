#pragma once

namespace UnrealEngine
{
	class _UWindDirectionalSourceComponent
	{
		static UClass* StaticClass(){return UWindDirectionalSourceComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWindDirectionalSourceComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
