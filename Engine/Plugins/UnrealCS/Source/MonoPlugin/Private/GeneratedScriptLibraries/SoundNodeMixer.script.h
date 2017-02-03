#pragma once

namespace UnrealEngine
{
	class _USoundNodeMixer
	{
		static UClass* StaticClass(){return USoundNodeMixer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeMixer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
