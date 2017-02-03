#pragma once

namespace UnrealEngine
{
	class _UActorChannel
	{
		static UClass* StaticClass(){return UActorChannel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UActorChannel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
