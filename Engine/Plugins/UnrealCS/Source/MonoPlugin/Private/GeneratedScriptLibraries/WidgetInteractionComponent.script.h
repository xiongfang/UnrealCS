#pragma once

namespace UnrealEngine
{
	class _UWidgetInteractionComponent
	{
		static void SetCustomHitResult(UWidgetInteractionComponent* _this,FHitResult* HitResult)
		{
			_this->SetCustomHitResult(*HitResult);
			
		}
		static FVector2D Get2DHitLocation(UWidgetInteractionComponent* _this)
		{
			FVector2D ___ret = _this->Get2DHitLocation();
			return ___ret;
			
		}
		static FHitResult GetLastHitResult(UWidgetInteractionComponent* _this)
		{
			FHitResult ___ret = _this->GetLastHitResult();
			return ___ret;
			
		}
		static int32 IsOverHitTestVisibleWidget(UWidgetInteractionComponent* _this)
		{
			bool ___ret = _this->IsOverHitTestVisibleWidget();
			return ___ret?1:0;
			
		}
		static int32 IsOverFocusableWidget(UWidgetInteractionComponent* _this)
		{
			bool ___ret = _this->IsOverFocusableWidget();
			return ___ret?1:0;
			
		}
		static int32 IsOverInteractableWidget(UWidgetInteractionComponent* _this)
		{
			bool ___ret = _this->IsOverInteractableWidget();
			return ___ret?1:0;
			
		}
		static UWidgetComponent* GetHoveredWidgetComponent(UWidgetInteractionComponent* _this)
		{
			UWidgetComponent* ___ret = _this->GetHoveredWidgetComponent();
			return ___ret;
			
		}
		static void ScrollWheel(UWidgetInteractionComponent* _this,float ScrollDelta)
		{
			_this->ScrollWheel(ScrollDelta);
			
		}
		static int32 SendKeyChar(UWidgetInteractionComponent* _this,MonoString* Characters,int32 bRepeat)
		{
			FString Characters_temp=MonoStringToFString(Characters);
			bool ___ret = _this->SendKeyChar(Characters_temp,bRepeat>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 PressAndReleaseKey(UWidgetInteractionComponent* _this,FKey* Key)
		{
			bool ___ret = _this->PressAndReleaseKey(*Key);
			return ___ret?1:0;
			
		}
		static int32 ReleaseKey(UWidgetInteractionComponent* _this,FKey* Key)
		{
			bool ___ret = _this->ReleaseKey(*Key);
			return ___ret?1:0;
			
		}
		static int32 PressKey(UWidgetInteractionComponent* _this,FKey* Key,int32 bRepeat)
		{
			bool ___ret = _this->PressKey(*Key,bRepeat>0?true:false);
			return ___ret?1:0;
			
		}
		static void ReleasePointerKey(UWidgetInteractionComponent* _this,FKey* Key)
		{
			_this->ReleasePointerKey(*Key);
			
		}
		static void PressPointerKey(UWidgetInteractionComponent* _this,FKey* Key)
		{
			_this->PressPointerKey(*Key);
			
		}
		static UClass* StaticClass(){return UWidgetInteractionComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::SetCustomHitResult",(const void*)SetCustomHitResult);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::Get2DHitLocation",(const void*)Get2DHitLocation);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::GetLastHitResult",(const void*)GetLastHitResult);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::IsOverHitTestVisibleWidget",(const void*)IsOverHitTestVisibleWidget);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::IsOverFocusableWidget",(const void*)IsOverFocusableWidget);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::IsOverInteractableWidget",(const void*)IsOverInteractableWidget);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::GetHoveredWidgetComponent",(const void*)GetHoveredWidgetComponent);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::ScrollWheel",(const void*)ScrollWheel);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::SendKeyChar",(const void*)SendKeyChar);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::PressAndReleaseKey",(const void*)PressAndReleaseKey);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::ReleaseKey",(const void*)ReleaseKey);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::PressKey",(const void*)PressKey);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::ReleasePointerKey",(const void*)ReleasePointerKey);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::PressPointerKey",(const void*)PressPointerKey);
			mono_add_internal_call("UnrealEngine.UWidgetInteractionComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
