#pragma once

namespace UnrealEngine
{
	class _AAmbientSound
	{
		static UClass* StaticClass(){return AAmbientSound::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AAmbientSound::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
