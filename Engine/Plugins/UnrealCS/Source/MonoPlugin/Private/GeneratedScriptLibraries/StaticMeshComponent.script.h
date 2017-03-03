#pragma once

namespace UnrealEngine
{
	class _UStaticMeshComponent
	{
		static void GetLocalBounds(UStaticMeshComponent* _this,FVector* Min,FVector* Max)
		{
			_this->GetLocalBounds(*Min,*Max);
			
		}
		static void SetForcedLodModel(UStaticMeshComponent* _this,int32 NewForcedLodModel)
		{
			_this->SetForcedLodModel(NewForcedLodModel);
			
		}
		static int32 SetStaticMesh(UStaticMeshComponent* _this,UStaticMesh* NewMesh)
		{
			bool ___ret = _this->SetStaticMesh(NewMesh);
			return ___ret?1:0;
			
		}
		static void OnRep_StaticMesh(UStaticMeshComponent* _this,UStaticMesh* OldStaticMesh)
		{
			_this->OnRep_StaticMesh(OldStaticMesh);
			
		}
		static UClass* StaticClass(){return UStaticMeshComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UStaticMeshComponent::GetLocalBounds",(const void*)GetLocalBounds);
			mono_add_internal_call("UnrealEngine.UStaticMeshComponent::SetForcedLodModel",(const void*)SetForcedLodModel);
			mono_add_internal_call("UnrealEngine.UStaticMeshComponent::SetStaticMesh",(const void*)SetStaticMesh);
			mono_add_internal_call("UnrealEngine.UStaticMeshComponent::OnRep_StaticMesh",(const void*)OnRep_StaticMesh);
			mono_add_internal_call("UnrealEngine.UStaticMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
