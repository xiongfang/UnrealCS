#pragma once

namespace UnrealEngine
{
	class _UChannel
	{
		static UClass* StaticClass(){return UChannel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UChannel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
