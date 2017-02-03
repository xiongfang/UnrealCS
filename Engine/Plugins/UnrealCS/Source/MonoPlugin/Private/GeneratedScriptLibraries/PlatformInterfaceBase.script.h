#pragma once

namespace UnrealEngine
{
	class _UPlatformInterfaceBase
	{
		static UClass* StaticClass(){return UPlatformInterfaceBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPlatformInterfaceBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
