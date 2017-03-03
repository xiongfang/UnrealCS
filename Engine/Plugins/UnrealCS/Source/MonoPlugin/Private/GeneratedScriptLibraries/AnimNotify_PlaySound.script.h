#pragma once

namespace UnrealEngine
{
	class _UAnimNotify_PlaySound
	{
		static UClass* StaticClass(){return UAnimNotify_PlaySound::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimNotify_PlaySound::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
