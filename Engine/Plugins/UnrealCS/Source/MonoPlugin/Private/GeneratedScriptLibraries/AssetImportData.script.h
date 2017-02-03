#pragma once

namespace UnrealEngine
{
	class _UAssetImportData
	{
		static UClass* StaticClass(){return UAssetImportData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAssetImportData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
