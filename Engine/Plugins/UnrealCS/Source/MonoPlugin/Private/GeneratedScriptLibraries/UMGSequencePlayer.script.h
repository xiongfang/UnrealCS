#pragma once

namespace UnrealEngine
{
	class _UUMGSequencePlayer
	{
		static UClass* StaticClass(){return UUMGSequencePlayer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UUMGSequencePlayer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
