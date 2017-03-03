#pragma once

namespace UnrealEngine
{
	class _ALevelStreamingVolume
	{
		static UClass* StaticClass(){return ALevelStreamingVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ALevelStreamingVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
