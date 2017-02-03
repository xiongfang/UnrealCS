#pragma once

namespace UnrealEngine
{
	class _AHLODMeshCullingVolume
	{
		static UClass* StaticClass(){return AHLODMeshCullingVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AHLODMeshCullingVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
