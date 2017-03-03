#pragma once

namespace UnrealEngine
{
	class _USlateDataSheet
	{
		static UClass* StaticClass(){return USlateDataSheet::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlateDataSheet::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
