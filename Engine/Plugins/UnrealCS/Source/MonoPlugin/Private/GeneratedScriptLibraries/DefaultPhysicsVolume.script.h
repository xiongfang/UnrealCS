#pragma once

namespace UnrealEngine
{
	class _ADefaultPhysicsVolume
	{
		static UClass* StaticClass(){return ADefaultPhysicsVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ADefaultPhysicsVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
