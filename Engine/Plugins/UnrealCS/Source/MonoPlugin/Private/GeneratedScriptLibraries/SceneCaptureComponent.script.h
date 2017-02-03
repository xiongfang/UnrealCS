#pragma once

namespace UnrealEngine
{
	class _USceneCaptureComponent
	{
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
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::ShowOnlyActorComponents",(const void*)ShowOnlyActorComponents);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::ShowOnlyComponent",(const void*)ShowOnlyComponent);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::HideActorComponents",(const void*)HideActorComponents);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::HideComponent",(const void*)HideComponent);
			mono_add_internal_call("UnrealEngine.USceneCaptureComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
