#pragma once

namespace UnrealEngine
{
	class _USoundNodeWaveParam
	{
		static UClass* StaticClass(){return USoundNodeWaveParam::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeWaveParam::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
