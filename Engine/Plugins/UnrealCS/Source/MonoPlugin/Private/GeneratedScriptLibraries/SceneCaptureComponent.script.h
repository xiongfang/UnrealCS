#pragma once

namespace UnrealEngine
{
	class _USceneCaptureComponent
	{
		static void ClearShowOnlyComponents(USceneCaptureComponent* _this,UPrimitiveComponent* InComponent)
		{
			_this->ClearShowOnlyComponents(InComponent);
			
		}
		static void RemoveShowOnlyActorComponents(USceneCaptureComponent* _this,AActor* InActor)
		{
			_this->RemoveShowOnlyActorComponents(InActor);
			
		}
		static void RemoveShowOnlyComponent(USceneCaptureComponent* _this,UPrimitiveComponent* InComponent)
		{
			_this->RemoveShowOnlyComponent(InComponent);
			
		}
		static void ShowOnlyActorComponents(USceneCaptureComponent* _this,AActor* InActor)
		{
			_this->ShowOnlyActorComponents(InActor);
			
		}
		static void ShowOnlyComponent(USceneCaptureComponent* _this,UPrimitiveComponent* InComponent)
		{
			_this->ShowOnlyComponent(InComponent);
			
		}
		static void HideActorComponents(USceneCaptureComponent* _this,AActor* InActor)
		{
			_this->HideActorComponents(InActor);
			
		}
		static void HideComponent(USceneCaptureComponent* _this,UPrimitiveComponent* InComponent)
		{
			_this->HideComponent(InComponent);
			
		}
		static UClass* StaticClass(){return USceneCaptureComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::ClearShowOnlyComponents",(const void*)ClearShowOnlyComponents);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::RemoveShowOnlyActorComponents",(const void*)RemoveShowOnlyActorComponents);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::RemoveShowOnlyComponent",(const void*)RemoveShowOnlyComponent);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::ShowOnlyActorComponents",(const void*)ShowOnlyActorComponents);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::ShowOnlyComponent",(const void*)ShowOnlyComponent);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::HideActorComponents",(const void*)HideActorComponents);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::HideComponent",(const void*)HideComponent);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
