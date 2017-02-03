#pragma once

namespace UnrealEngine
{
	class _UInterface_AssetUserData
	{
		static UClass* StaticClass(){return UInterface_AssetUserData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterface_AssetUserData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
