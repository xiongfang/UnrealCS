#pragma once

namespace UnrealEngine
{
	class _UWidget
	{
		static APlayerController* GetOwningPlayer(UWidget* _this)
		{
			APlayerController* ___ret = _this->GetOwningPlayer();
			return ___ret;
			
		}
		static void RemoveFromParent(UWidget* _this)
		{
			_this->RemoveFromParent();
			
		}
		static UPanelWidget* GetParent(UWidget* _this)
		{
			UPanelWidget* ___ret = _this->GetParent();
			return ___ret;
			
		}
		static FVector2D GetDesiredSize(UWidget* _this)
		{
			FVector2D ___ret = _this->GetDesiredSize();
			return ___ret;
			
		}
		static void InvalidateLayoutAndVolatility(UWidget* _this)
		{
			_this->InvalidateLayoutAndVolatility();
			
		}
		static void ForceLayoutPrepass(UWidget* _this)
		{
			_this->ForceLayoutPrepass();
			
		}
		static void SetUserFocus(UWidget* _this,APlayerController* PlayerController)
		{
			_this->SetUserFocus(PlayerController);
			
		}
		static int32 HasUserFocusedDescendants(UWidget* _this,APlayerController* PlayerController)
		{
			bool ___ret = _this->HasUserFocusedDescendants(PlayerController);
			return ___ret?1:0;
			
		}
		static int32 HasFocusedDescendants(UWidget* _this)
		{
			bool ___ret = _this->HasFocusedDescendants();
			return ___ret?1:0;
			
		}
		static int32 HasAnyUserFocus(UWidget* _this)
		{
			bool ___ret = _this->HasAnyUserFocus();
			return ___ret?1:0;
			
		}
		static int32 HasUserFocus(UWidget* _this,APlayerController* PlayerController)
		{
			bool ___ret = _this->HasUserFocus(PlayerController);
			return ___ret?1:0;
			
		}
		static void SetKeyboardFocus(UWidget* _this)
		{
			_this->SetKeyboardFocus();
			
		}
		static int32 HasMouseCapture(UWidget* _this)
		{
			bool ___ret = _this->HasMouseCapture();
			return ___ret?1:0;
			
		}
		static int32 HasKeyboardFocus(UWidget* _this)
		{
			bool ___ret = _this->HasKeyboardFocus();
			return ___ret?1:0;
			
		}
		static int32 IsHovered(UWidget* _this)
		{
			bool ___ret = _this->IsHovered();
			return ___ret?1:0;
			
		}
		static void ForceVolatile(UWidget* _this,int32 bForce)
		{
			_this->ForceVolatile(bForce>0?true:false);
			
		}
		static void SetVisibility(UWidget* _this,int32 InVisibility)
		{
			_this->SetVisibility((ESlateVisibility)InVisibility);
			
		}
		static int32 GetVisibility(UWidget* _this)
		{
			ESlateVisibility ___ret = _this->GetVisibility();
			return (int)___ret;
			
		}
		static int32 IsVisible(UWidget* _this)
		{
			bool ___ret = _this->IsVisible();
			return ___ret?1:0;
			
		}
		static void ResetCursor(UWidget* _this)
		{
			_this->ResetCursor();
			
		}
		static void SetCursor(UWidget* _this,int32 InCursor)
		{
			_this->SetCursor((TEnumAsByte<EMouseCursor::Type>)InCursor);
			
		}
		static void SetToolTip(UWidget* _this,UWidget* Widget)
		{
			_this->SetToolTip(Widget);
			
		}
		static void SetToolTipText(UWidget* _this,MonoString* InToolTipText)
		{
			FText InToolTipText_temp=FText::FromString(MonoStringToFString(InToolTipText));
			_this->SetToolTipText(InToolTipText_temp);
			
		}
		static void SetIsEnabled(UWidget* _this,int32 bInIsEnabled)
		{
			_this->SetIsEnabled(bInIsEnabled>0?true:false);
			
		}
		static int32 GetIsEnabled(UWidget* _this)
		{
			bool ___ret = _this->GetIsEnabled();
			return ___ret?1:0;
			
		}
		static void SetRenderTransformPivot(UWidget* _this,FVector2D* Pivot)
		{
			_this->SetRenderTransformPivot(*Pivot);
			
		}
		static void SetRenderTranslation(UWidget* _this,FVector2D* Translation)
		{
			_this->SetRenderTranslation(*Translation);
			
		}
		static void SetRenderAngle(UWidget* _this,float Angle)
		{
			_this->SetRenderAngle(Angle);
			
		}
		static void SetRenderShear(UWidget* _this,FVector2D* Shear)
		{
			_this->SetRenderShear(*Shear);
			
		}
		static void SetRenderScale(UWidget* _this,FVector2D* Scale)
		{
			_this->SetRenderScale(*Scale);
			
		}
		static void SetRenderTransform(UWidget* _this,FWidgetTransform* InTransform)
		{
			_this->SetRenderTransform(*InTransform);
			
		}
		static UClass* StaticClass(){return UWidget::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidget::GetOwningPlayer",(const void*)GetOwningPlayer);
			mono_add_internal_call("UnrealEngine.UWidget::RemoveFromParent",(const void*)RemoveFromParent);
			mono_add_internal_call("UnrealEngine.UWidget::GetParent",(const void*)GetParent);
			mono_add_internal_call("UnrealEngine.UWidget::GetDesiredSize",(const void*)GetDesiredSize);
			mono_add_internal_call("UnrealEngine.UWidget::InvalidateLayoutAndVolatility",(const void*)InvalidateLayoutAndVolatility);
			mono_add_internal_call("UnrealEngine.UWidget::ForceLayoutPrepass",(const void*)ForceLayoutPrepass);
			mono_add_internal_call("UnrealEngine.UWidget::SetUserFocus",(const void*)SetUserFocus);
			mono_add_internal_call("UnrealEngine.UWidget::HasUserFocusedDescendants",(const void*)HasUserFocusedDescendants);
			mono_add_internal_call("UnrealEngine.UWidget::HasFocusedDescendants",(const void*)HasFocusedDescendants);
			mono_add_internal_call("UnrealEngine.UWidget::HasAnyUserFocus",(const void*)HasAnyUserFocus);
			mono_add_internal_call("UnrealEngine.UWidget::HasUserFocus",(const void*)HasUserFocus);
			mono_add_internal_call("UnrealEngine.UWidget::SetKeyboardFocus",(const void*)SetKeyboardFocus);
			mono_add_internal_call("UnrealEngine.UWidget::HasMouseCapture",(const void*)HasMouseCapture);
			mono_add_internal_call("UnrealEngine.UWidget::HasKeyboardFocus",(const void*)HasKeyboardFocus);
			mono_add_internal_call("UnrealEngine.UWidget::IsHovered",(const void*)IsHovered);
			mono_add_internal_call("UnrealEngine.UWidget::ForceVolatile",(const void*)ForceVolatile);
			mono_add_internal_call("UnrealEngine.UWidget::SetVisibility",(const void*)SetVisibility);
			mono_add_internal_call("UnrealEngine.UWidget::GetVisibility",(const void*)GetVisibility);
			mono_add_internal_call("UnrealEngine.UWidget::IsVisible",(const void*)IsVisible);
			mono_add_internal_call("UnrealEngine.UWidget::ResetCursor",(const void*)ResetCursor);
			mono_add_internal_call("UnrealEngine.UWidget::SetCursor",(const void*)SetCursor);
			mono_add_internal_call("UnrealEngine.UWidget::SetToolTip",(const void*)SetToolTip);
			mono_add_internal_call("UnrealEngine.UWidget::SetToolTipText",(const void*)SetToolTipText);
			mono_add_internal_call("UnrealEngine.UWidget::SetIsEnabled",(const void*)SetIsEnabled);
			mono_add_internal_call("UnrealEngine.UWidget::GetIsEnabled",(const void*)GetIsEnabled);
			mono_add_internal_call("UnrealEngine.UWidget::SetRenderTransformPivot",(const void*)SetRenderTransformPivot);
			mono_add_internal_call("UnrealEngine.UWidget::SetRenderTranslation",(const void*)SetRenderTranslation);
			mono_add_internal_call("UnrealEngine.UWidget::SetRenderAngle",(const void*)SetRenderAngle);
			mono_add_internal_call("UnrealEngine.UWidget::SetRenderShear",(const void*)SetRenderShear);
			mono_add_internal_call("UnrealEngine.UWidget::SetRenderScale",(const void*)SetRenderScale);
			mono_add_internal_call("UnrealEngine.UWidget::SetRenderTransform",(const void*)SetRenderTransform);
			mono_add_internal_call("UnrealEngine.UWidget::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
