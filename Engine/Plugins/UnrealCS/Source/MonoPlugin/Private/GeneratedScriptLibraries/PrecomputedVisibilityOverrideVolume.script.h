#pragma once

namespace UnrealEngine
{
	class _APrecomputedVisibilityOverrideVolume
	{
		static UClass* StaticClass(){return APrecomputedVisibilityOverrideVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APrecomputedVisibilityOverrideVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
