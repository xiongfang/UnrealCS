#pragma once

namespace UnrealEngine
{
	class _UObjectLibrary
	{
		static UClass* StaticClass(){return UObjectLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UObjectLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
