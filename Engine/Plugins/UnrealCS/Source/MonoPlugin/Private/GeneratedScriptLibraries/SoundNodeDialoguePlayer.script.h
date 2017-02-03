#pragma once

namespace UnrealEngine
{
	class _USoundNodeDialoguePlayer
	{
		static UClass* StaticClass(){return USoundNodeDialoguePlayer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeDialoguePlayer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
