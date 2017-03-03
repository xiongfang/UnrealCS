#pragma once

namespace UnrealEngine
{
	class _APhysicsVolume
	{
		static UClass* StaticClass(){return APhysicsVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APhysicsVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
