#pragma once

namespace UnrealEngine
{
	class _AInfo
	{
		static UClass* StaticClass(){return AInfo::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AInfo::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
