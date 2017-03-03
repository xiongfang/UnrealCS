#pragma once

namespace UnrealEngine
{
	class _UParticleModuleTypeDataMesh
	{
		static UClass* StaticClass(){return UParticleModuleTypeDataMesh::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleModuleTypeDataMesh::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
