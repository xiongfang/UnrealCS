#pragma once

namespace UnrealEngine
{
	class _ACameraBlockingVolume
	{
		static UClass* StaticClass(){return ACameraBlockingVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ACameraBlockingVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
