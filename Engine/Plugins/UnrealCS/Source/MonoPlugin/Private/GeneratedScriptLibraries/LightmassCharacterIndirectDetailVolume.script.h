#pragma once

namespace UnrealEngine
{
	class _ALightmassCharacterIndirectDetailVolume
	{
		static UClass* StaticClass(){return ALightmassCharacterIndirectDetailVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ALightmassCharacterIndirectDetailVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
