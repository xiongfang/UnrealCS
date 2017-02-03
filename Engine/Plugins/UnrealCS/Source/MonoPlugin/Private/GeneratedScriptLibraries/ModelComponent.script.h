#pragma once

namespace UnrealEngine
{
	class _UModelComponent
	{
		static UClass* StaticClass(){return UModelComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UModelComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
