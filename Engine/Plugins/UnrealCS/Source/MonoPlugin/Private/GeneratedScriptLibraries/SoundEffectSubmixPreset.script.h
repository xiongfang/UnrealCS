#pragma once

namespace UnrealEngine
{
	class _USoundEffectSubmixPreset
	{
		static UClass* StaticClass(){return USoundEffectSubmixPreset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundEffectSubmixPreset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
