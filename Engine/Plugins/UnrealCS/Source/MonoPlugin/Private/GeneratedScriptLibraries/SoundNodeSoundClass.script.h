#pragma once

namespace UnrealEngine
{
	class _USoundNodeSoundClass
	{
		static UClass* StaticClass(){return USoundNodeSoundClass::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeSoundClass::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
