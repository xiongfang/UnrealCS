#pragma once

namespace UnrealEngine
{
	class _UAssetUserData
	{
		static UClass* StaticClass(){return UAssetUserData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAssetUserData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
