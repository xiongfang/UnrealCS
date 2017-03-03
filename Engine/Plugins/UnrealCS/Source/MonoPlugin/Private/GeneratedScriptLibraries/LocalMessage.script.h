#pragma once

namespace UnrealEngine
{
	class _ULocalMessage
	{
		static UClass* StaticClass(){return ULocalMessage::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULocalMessage::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
