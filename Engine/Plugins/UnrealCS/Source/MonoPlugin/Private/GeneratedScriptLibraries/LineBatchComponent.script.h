#pragma once

namespace UnrealEngine
{
	class _ULineBatchComponent
	{
		static UClass* StaticClass(){return ULineBatchComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULineBatchComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
