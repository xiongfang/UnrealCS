#pragma once

namespace UnrealEngine
{
	class _UInstancedStaticMeshComponent
	{
		static MonoArray* GetInstancesOverlappingBox(UInstancedStaticMeshComponent* _this,FBox* Box,int32 bBoxInWorldSpace)
		{
			TArray<int32> ___ret = _this->GetInstancesOverlappingBox(*Box,bBoxInWorldSpace>0?true:false);
			return TArrayToMonoArray(___ret,"System.Int32,mscorlib");
			
		}
		static MonoArray* GetInstancesOverlappingSphere(UInstancedStaticMeshComponent* _this,FVector* Center,float Radius,int32 bSphereInWorldSpace)
		{
			TArray<int32> ___ret = _this->GetInstancesOverlappingSphere(*Center,Radius,bSphereInWorldSpace>0?true:false);
			return TArrayToMonoArray(___ret,"System.Int32,mscorlib");
			
		}
		static void SetCullDistances(UInstancedStaticMeshComponent* _this,int32 StartCullDistance,int32 EndCullDistance)
		{
			_this->SetCullDistances(StartCullDistance,EndCullDistance);
			
		}
		static int32 GetInstanceCount(UInstancedStaticMeshComponent* _this)
		{
			int32 ___ret = _this->GetInstanceCount();
			return ___ret;
			
		}
		static void ClearInstances(UInstancedStaticMeshComponent* _this)
		{
			_this->ClearInstances();
			
		}
		static int32 RemoveInstance(UInstancedStaticMeshComponent* _this,int32 InstanceIndex)
		{
			bool ___ret = _this->RemoveInstance(InstanceIndex);
			return ___ret?1:0;
			
		}
		static int32 UpdateInstanceTransform(UInstancedStaticMeshComponent* _this,int32 InstanceIndex,FTransform* NewInstanceTransform,int32 bWorldSpace,int32 bMarkRenderStateDirty,int32 bTeleport)
		{
			bool ___ret = _this->UpdateInstanceTransform(InstanceIndex,*NewInstanceTransform,bWorldSpace>0?true:false,bMarkRenderStateDirty>0?true:false,bTeleport>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 GetInstanceTransform(UInstancedStaticMeshComponent* _this,int32 InstanceIndex,FTransform* OutInstanceTransform,int32 bWorldSpace)
		{
			bool ___ret = _this->GetInstanceTransform(InstanceIndex,*OutInstanceTransform,bWorldSpace>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 AddInstanceWorldSpace(UInstancedStaticMeshComponent* _this,FTransform* WorldTransform)
		{
			int32 ___ret = _this->AddInstanceWorldSpace(*WorldTransform);
			return ___ret;
			
		}
		static int32 AddInstance(UInstancedStaticMeshComponent* _this,FTransform* InstanceTransform)
		{
			int32 ___ret = _this->AddInstance(*InstanceTransform);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UInstancedStaticMeshComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::GetInstancesOverlappingBox",(const void*)GetInstancesOverlappingBox);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::GetInstancesOverlappingSphere",(const void*)GetInstancesOverlappingSphere);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::SetCullDistances",(const void*)SetCullDistances);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::GetInstanceCount",(const void*)GetInstanceCount);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::ClearInstances",(const void*)ClearInstances);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::RemoveInstance",(const void*)RemoveInstance);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::UpdateInstanceTransform",(const void*)UpdateInstanceTransform);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::GetInstanceTransform",(const void*)GetInstanceTransform);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::AddInstanceWorldSpace",(const void*)AddInstanceWorldSpace);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::AddInstance",(const void*)AddInstance);
			mono_add_internal_call("UnrealEngine.UInstancedStaticMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
