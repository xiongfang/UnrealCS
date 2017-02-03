#pragma once

namespace UnrealEngine
{
	class _USoundNodeLooping
	{
		static UClass* StaticClass(){return USoundNodeLooping::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeLooping::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
