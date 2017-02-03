#pragma once

namespace UnrealEngine
{
	class _UWidgetComponent
	{
		static void SetBackgroundColor(UWidgetComponent* _this,FLinearColor* NewBackgroundColor)
		{
			_this->SetBackgroundColor(*NewBackgroundColor);
			
		}
		static void RequestRedraw(UWidgetComponent* _this)
		{
			_this->RequestRedraw();
			
		}
		static void SetDrawSize(UWidgetComponent* _this,FVector2D* Size)
		{
			_this->SetDrawSize(*Size);
			
		}
		static FVector2D GetDrawSize(UWidgetComponent* _this)
		{
			FVector2D ___ret = _this->GetDrawSize();
			return ___ret;
			
		}
		static ULocalPlayer* GetOwnerPlayer(UWidgetComponent* _this)
		{
			ULocalPlayer* ___ret = _this->GetOwnerPlayer();
			return ___ret;
			
		}
		static void SetOwnerPlayer(UWidgetComponent* _this,ULocalPlayer* LocalPlayer)
		{
			_this->SetOwnerPlayer(LocalPlayer);
			
		}
		static void SetWidget(UWidgetComponent* _this,UUserWidget* Widget)
		{
			_this->SetWidget(Widget);
			
		}
		static UMaterialInstanceDynamic* GetMaterialInstance(UWidgetComponent* _this)
		{
			UMaterialInstanceDynamic* ___ret = _this->GetMaterialInstance();
			return ___ret;
			
		}
		static UTextureRenderTarget2D* GetRenderTarget(UWidgetComponent* _this)
		{
			UTextureRenderTarget2D* ___ret = _this->GetRenderTarget();
			return ___ret;
			
		}
		static UUserWidget* GetUserWidgetObject(UWidgetComponent* _this)
		{
			UUserWidget* ___ret = _this->GetUserWidgetObject();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UWidgetComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetComponent::SetBackgroundColor",(const void*)SetBackgroundColor);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::RequestRedraw",(const void*)RequestRedraw);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::SetDrawSize",(const void*)SetDrawSize);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::GetDrawSize",(const void*)GetDrawSize);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::GetOwnerPlayer",(const void*)GetOwnerPlayer);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::SetOwnerPlayer",(const void*)SetOwnerPlayer);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::SetWidget",(const void*)SetWidget);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::GetMaterialInstance",(const void*)GetMaterialInstance);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::GetRenderTarget",(const void*)GetRenderTarget);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::GetUserWidgetObject",(const void*)GetUserWidgetObject);
			mono_add_internal_call("UnrealEngine.UWidgetComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
