#pragma once

namespace UnrealEngine
{
	class _UInterface_PostProcessVolume
	{
		static UClass* StaticClass(){return UInterface_PostProcessVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterface_PostProcessVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
