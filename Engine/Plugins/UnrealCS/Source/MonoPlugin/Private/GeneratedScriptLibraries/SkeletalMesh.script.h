#pragma once

namespace UnrealEngine
{
	class _USkeletalMesh
	{
		static int32 IsSectionUsingCloth(USkeletalMesh* _this,int32 InSectionIndex,int32 bCheckCorrespondingSections)
		{
			bool ___ret = _this->IsSectionUsingCloth(InSectionIndex,bCheckCorrespondingSections>0?true:false);
			return ___ret?1:0;
			
		}
		static USkeletalMeshSocket* GetSocketByIndex(USkeletalMesh* _this,int32 Index)
		{
			USkeletalMeshSocket* ___ret = _this->GetSocketByIndex(Index);
			return ___ret;
			
		}
		static int32 NumSockets(USkeletalMesh* _this)
		{
			int32 ___ret = _this->NumSockets();
			return ___ret;
			
		}
		static USkeletalMeshSocket* FindSocketAndIndex(USkeletalMesh* _this,MonoString* InSocketName,int32* OutIndex)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			USkeletalMeshSocket* ___ret = _this->FindSocketAndIndex(InSocketName_temp,*OutIndex);
			return ___ret;
			
		}
		static USkeletalMeshSocket* FindSocket(USkeletalMesh* _this,MonoString* InSocketName)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			USkeletalMeshSocket* ___ret = _this->FindSocket(InSocketName_temp);
			return ___ret;
			
		}
		static FBoxSphereBounds GetImportedBounds(USkeletalMesh* _this)
		{
			FBoxSphereBounds ___ret = _this->GetImportedBounds();
			return ___ret;
			
		}
		static FBoxSphereBounds GetBounds(USkeletalMesh* _this)
		{
			FBoxSphereBounds ___ret = _this->GetBounds();
			return ___ret;
			
		}
		static UClass* StaticClass(){return USkeletalMesh::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USkeletalMesh::IsSectionUsingCloth",(const void*)IsSectionUsingCloth);
			mono_add_internal_call("UnrealEngine.USkeletalMesh::GetSocketByIndex",(const void*)GetSocketByIndex);
			mono_add_internal_call("UnrealEngine.USkeletalMesh::NumSockets",(const void*)NumSockets);
			mono_add_internal_call("UnrealEngine.USkeletalMesh::FindSocketAndIndex",(const void*)FindSocketAndIndex);
			mono_add_internal_call("UnrealEngine.USkeletalMesh::FindSocket",(const void*)FindSocket);
			mono_add_internal_call("UnrealEngine.USkeletalMesh::GetImportedBounds",(const void*)GetImportedBounds);
			mono_add_internal_call("UnrealEngine.USkeletalMesh::GetBounds",(const void*)GetBounds);
			mono_add_internal_call("UnrealEngine.USkeletalMesh::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
