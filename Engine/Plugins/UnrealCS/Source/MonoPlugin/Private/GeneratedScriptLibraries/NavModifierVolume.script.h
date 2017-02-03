#pragma once

namespace UnrealEngine
{
	class _ANavModifierVolume
	{
		static UClass* StaticClass(){return ANavModifierVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANavModifierVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
