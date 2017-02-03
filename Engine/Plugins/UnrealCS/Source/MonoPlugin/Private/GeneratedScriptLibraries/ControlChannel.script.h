#pragma once

namespace UnrealEngine
{
	class _UControlChannel
	{
		static UClass* StaticClass(){return UControlChannel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UControlChannel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
