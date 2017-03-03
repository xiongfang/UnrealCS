#pragma once

namespace UnrealEngine
{
	class _UDynamicBlueprintBinding
	{
		static UClass* StaticClass(){return UDynamicBlueprintBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDynamicBlueprintBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
