#pragma once

namespace UnrealEngine
{
	class _UDialogueWave
	{
		static UClass* StaticClass(){return UDialogueWave::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDialogueWave::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
