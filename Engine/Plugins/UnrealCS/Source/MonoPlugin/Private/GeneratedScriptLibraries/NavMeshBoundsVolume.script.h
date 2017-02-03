#pragma once

namespace UnrealEngine
{
	class _ANavMeshBoundsVolume
	{
		static UClass* StaticClass(){return ANavMeshBoundsVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANavMeshBoundsVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
