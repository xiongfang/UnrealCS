#pragma once

namespace UnrealEngine
{
	class _UBlueprintSetLibrary
	{
		static UClass* StaticClass(){return UBlueprintSetLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlueprintSetLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
