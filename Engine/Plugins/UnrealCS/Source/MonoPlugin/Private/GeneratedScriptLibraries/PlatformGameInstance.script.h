#pragma once

namespace UnrealEngine
{
	class _UPlatformGameInstance
	{
		static UClass* StaticClass(){return UPlatformGameInstance::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPlatformGameInstance::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
