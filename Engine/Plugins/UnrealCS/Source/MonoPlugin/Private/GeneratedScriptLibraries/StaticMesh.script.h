#pragma once

namespace UnrealEngine
{
	class _UStaticMesh
	{
		static int32 GetNumSections(UStaticMesh* _this,int32 InLOD)
		{
			int32 ___ret = _this->GetNumSections(InLOD);
			return ___ret;
			
		}
		static FBox GetBoundingBox(UStaticMesh* _this)
		{
			FBox ___ret = _this->GetBoundingBox();
			return ___ret;
			
		}
		static FBoxSphereBounds GetBounds(UStaticMesh* _this)
		{
			FBoxSphereBounds ___ret = _this->GetBounds();
			return ___ret;
			
		}
		static int32 GetNumLODs(UStaticMesh* _this)
		{
			int32 ___ret = _this->GetNumLODs();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UStaticMesh::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UStaticMesh::GetNumSections",(const void*)GetNumSections);
			mono_add_internal_call("UnrealEngine.UStaticMesh::GetBoundingBox",(const void*)GetBoundingBox);
			mono_add_internal_call("UnrealEngine.UStaticMesh::GetBounds",(const void*)GetBounds);
			mono_add_internal_call("UnrealEngine.UStaticMesh::GetNumLODs",(const void*)GetNumLODs);
			mono_add_internal_call("UnrealEngine.UStaticMesh::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
