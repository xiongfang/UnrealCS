#pragma once

namespace UnrealEngine
{
	class _UFontImportOptions
	{
		static UClass* StaticClass(){return UFontImportOptions::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UFontImportOptions::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
