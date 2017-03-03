#pragma once

namespace UnrealEngine
{
	class _UDataTable
	{
		static UClass* StaticClass(){return UDataTable::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDataTable::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
