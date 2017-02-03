#pragma once

namespace UnrealEngine
{
	class _AVectorFieldVolume
	{
		static UClass* StaticClass(){return AVectorFieldVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AVectorFieldVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
