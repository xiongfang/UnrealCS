#pragma once

namespace UnrealEngine
{
	class _UFontBulkData
	{
		static UClass* StaticClass(){return UFontBulkData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UFontBulkData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
