#pragma once

namespace UnrealEngine
{
	class _ASkeletalMeshActor
	{
		static void OnRep_ReplicatedMaterial1(ASkeletalMeshActor* _this)
		{
			_this->OnRep_ReplicatedMaterial1();
			
		}
		static void OnRep_ReplicatedMaterial0(ASkeletalMeshActor* _this)
		{
			_this->OnRep_ReplicatedMaterial0();
			
		}
		static void OnRep_ReplicatedPhysAsset(ASkeletalMeshActor* _this)
		{
			_this->OnRep_ReplicatedPhysAsset();
			
		}
		static void OnRep_ReplicatedMesh(ASkeletalMeshActor* _this)
		{
			_this->OnRep_ReplicatedMesh();
			
		}
		static UClass* StaticClass(){return ASkeletalMeshActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASkeletalMeshActor::OnRep_ReplicatedMaterial1",(const void*)OnRep_ReplicatedMaterial1);
			mono_add_internal_call("UnrealEngine.ASkeletalMeshActor::OnRep_ReplicatedMaterial0",(const void*)OnRep_ReplicatedMaterial0);
			mono_add_internal_call("UnrealEngine.ASkeletalMeshActor::OnRep_ReplicatedPhysAsset",(const void*)OnRep_ReplicatedPhysAsset);
			mono_add_internal_call("UnrealEngine.ASkeletalMeshActor::OnRep_ReplicatedMesh",(const void*)OnRep_ReplicatedMesh);
			mono_add_internal_call("UnrealEngine.ASkeletalMeshActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
