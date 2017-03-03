#pragma once

namespace UnrealEngine
{
	class _AVolume
	{
		static UClass* StaticClass(){return AVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
