#pragma once

namespace UnrealEngine
{
	class _ULocalPlayer
	{
		static UClass* StaticClass(){return ULocalPlayer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULocalPlayer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
