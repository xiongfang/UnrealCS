#pragma once

namespace UnrealEngine
{
	class _USoundEffectSourcePreset
	{
		static UClass* StaticClass(){return USoundEffectSourcePreset::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundEffectSourcePreset::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
