#pragma once

namespace UnrealEngine
{
	class _ABlockingVolume
	{
		static UClass* StaticClass(){return ABlockingVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ABlockingVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
