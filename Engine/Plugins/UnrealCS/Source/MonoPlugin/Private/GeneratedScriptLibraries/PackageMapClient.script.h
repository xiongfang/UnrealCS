#pragma once

namespace UnrealEngine
{
	class _UPackageMapClient
	{
		static UClass* StaticClass(){return UPackageMapClient::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPackageMapClient::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
