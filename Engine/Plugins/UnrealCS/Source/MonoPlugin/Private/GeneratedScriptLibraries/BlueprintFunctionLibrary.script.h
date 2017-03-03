#pragma once

namespace UnrealEngine
{
	class _UBlueprintFunctionLibrary
	{
		static UClass* StaticClass(){return UBlueprintFunctionLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlueprintFunctionLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
