#pragma once

namespace UnrealEngine
{
	class _UAssetMappingTable
	{
		static UClass* StaticClass(){return UAssetMappingTable::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAssetMappingTable::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
