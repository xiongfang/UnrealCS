#pragma once

namespace UnrealEngine
{
	class _UEngineMessage
	{
		static UClass* StaticClass(){return UEngineMessage::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UEngineMessage::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
