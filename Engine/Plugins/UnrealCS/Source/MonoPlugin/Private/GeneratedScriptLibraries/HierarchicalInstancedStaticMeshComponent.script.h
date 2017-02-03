#pragma once

namespace UnrealEngine
{
	class _UHierarchicalInstancedStaticMeshComponent
	{
		static int32 RemoveInstances(UHierarchicalInstancedStaticMeshComponent* _this,MonoArray* InstancesToRemove)
		{
			bool ___ret = _this->RemoveInstances(MonoArrayToTArray<int32>(InstancesToRemove));
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UHierarchicalInstancedStaticMeshComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHierarchicalInstancedStaticMeshComponent::RemoveInstances",(const void*)RemoveInstances);
			mono_add_internal_call("UnrealEngine.UHierarchicalInstancedStaticMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
