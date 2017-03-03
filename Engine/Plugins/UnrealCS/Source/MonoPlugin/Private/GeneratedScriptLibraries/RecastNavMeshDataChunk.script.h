#pragma once

namespace UnrealEngine
{
	class _URecastNavMeshDataChunk
	{
		static UClass* StaticClass(){return URecastNavMeshDataChunk::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URecastNavMeshDataChunk::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
