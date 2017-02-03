#pragma once

namespace UnrealEngine
{
	class _UDialogueVoice
	{
		static UClass* StaticClass(){return UDialogueVoice::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDialogueVoice::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
