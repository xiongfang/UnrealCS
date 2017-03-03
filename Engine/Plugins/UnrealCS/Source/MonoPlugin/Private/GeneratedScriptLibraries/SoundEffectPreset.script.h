#pragma once

namespace UnrealEngine
{
	class _USoundEffectPreset
	{
		static UClass* StaticClass(){return USoundEffectPreset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundEffectPreset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
