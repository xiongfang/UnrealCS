#pragma once

namespace UnrealEngine
{
	class _AGameNetworkManager
	{
		static UClass* StaticClass(){return AGameNetworkManager::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AGameNetworkManager::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
