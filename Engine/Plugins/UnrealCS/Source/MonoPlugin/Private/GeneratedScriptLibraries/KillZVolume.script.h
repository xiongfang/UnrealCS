#pragma once

namespace UnrealEngine
{
	class _AKillZVolume
	{
		static UClass* StaticClass(){return AKillZVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AKillZVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
