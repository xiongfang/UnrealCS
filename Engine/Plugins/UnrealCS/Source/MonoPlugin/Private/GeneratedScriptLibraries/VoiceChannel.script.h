#pragma once

namespace UnrealEngine
{
	class _UVoiceChannel
	{
		static UClass* StaticClass(){return UVoiceChannel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVoiceChannel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
