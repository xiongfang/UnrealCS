#pragma once

namespace UnrealEngine
{
	class _APostProcessVolume
	{
		static UClass* StaticClass(){return APostProcessVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APostProcessVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
