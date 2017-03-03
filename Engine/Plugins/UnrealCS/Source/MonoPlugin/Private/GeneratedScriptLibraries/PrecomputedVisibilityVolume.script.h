#pragma once

namespace UnrealEngine
{
	class _APrecomputedVisibilityVolume
	{
		static UClass* StaticClass(){return APrecomputedVisibilityVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APrecomputedVisibilityVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
