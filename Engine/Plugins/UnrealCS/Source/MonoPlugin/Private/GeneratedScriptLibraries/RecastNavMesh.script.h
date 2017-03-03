#pragma once

namespace UnrealEngine
{
	class _ARecastNavMesh
	{
		static UClass* StaticClass(){return ARecastNavMesh::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ARecastNavMesh::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
