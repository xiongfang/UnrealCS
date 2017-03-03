#pragma once

namespace UnrealEngine
{
	class _UDestructibleMesh
	{
		static UClass* StaticClass(){return UDestructibleMesh::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDestructibleMesh::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
