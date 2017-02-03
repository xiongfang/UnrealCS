#pragma once

namespace UnrealEngine
{
	class _UPlayer
	{
		static UClass* StaticClass(){return UPlayer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPlayer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
