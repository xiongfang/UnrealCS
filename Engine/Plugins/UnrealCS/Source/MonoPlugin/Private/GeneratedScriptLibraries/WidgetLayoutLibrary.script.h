#pragma once

namespace UnrealEngine
{
	class _UWidgetLayoutLibrary
	{
		static void RemoveAllWidgets(UWidgetLayoutLibrary* _this,UObject* WorldContextObject)
		{
			_this->RemoveAllWidgets(WorldContextObject);
			
		}
		static UVerticalBoxSlot* SlotAsVerticalBoxSlot(UWidgetLayoutLibrary* _this,UWidget* Widget)
		{
			UVerticalBoxSlot* ___ret = _this->SlotAsVerticalBoxSlot(Widget);
			return ___ret;
			
		}
		static UUniformGridSlot* SlotAsUniformGridSlot(UWidgetLayoutLibrary* _this,UWidget* Widget)
		{
			UUniformGridSlot* ___ret = _this->SlotAsUniformGridSlot(Widget);
			return ___ret;
			
		}
		static UOverlaySlot* SlotAsOverlaySlot(UWidgetLayoutLibrary* _this,UWidget* Widget)
		{
			UOverlaySlot* ___ret = _this->SlotAsOverlaySlot(Widget);
			return ___ret;
			
		}
		static UHorizontalBoxSlot* SlotAsHorizontalBoxSlot(UWidgetLayoutLibrary* _this,UWidget* Widget)
		{
			UHorizontalBoxSlot* ___ret = _this->SlotAsHorizontalBoxSlot(Widget);
			return ___ret;
			
		}
		static UGridSlot* SlotAsGridSlot(UWidgetLayoutLibrary* _this,UWidget* Widget)
		{
			UGridSlot* ___ret = _this->SlotAsGridSlot(Widget);
			return ___ret;
			
		}
		static UCanvasPanelSlot* SlotAsCanvasSlot(UWidgetLayoutLibrary* _this,UWidget* Widget)
		{
			UCanvasPanelSlot* ___ret = _this->SlotAsCanvasSlot(Widget);
			return ___ret;
			
		}
		static UBorderSlot* SlotAsBorderSlot(UWidgetLayoutLibrary* _this,UWidget* Widget)
		{
			UBorderSlot* ___ret = _this->SlotAsBorderSlot(Widget);
			return ___ret;
			
		}
		static int32 GetMousePositionScaledByDPI(UWidgetLayoutLibrary* _this,APlayerController* Player,float* LocationX,float* LocationY)
		{
			bool ___ret = _this->GetMousePositionScaledByDPI(Player,*LocationX,*LocationY);
			return ___ret?1:0;
			
		}
		static FVector2D GetViewportSize(UWidgetLayoutLibrary* _this,UObject* WorldContextObject)
		{
			FVector2D ___ret = _this->GetViewportSize(WorldContextObject);
			return ___ret;
			
		}
		static float GetViewportScale(UWidgetLayoutLibrary* _this,UObject* WorldContextObject)
		{
			float ___ret = _this->GetViewportScale(WorldContextObject);
			return ___ret;
			
		}
		static int32 ProjectWorldLocationToWidgetPosition(UWidgetLayoutLibrary* _this,APlayerController* PlayerController,FVector* WorldLocation,FVector2D* ScreenPosition)
		{
			bool ___ret = _this->ProjectWorldLocationToWidgetPosition(PlayerController,*WorldLocation,*ScreenPosition);
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UWidgetLayoutLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::RemoveAllWidgets",(const void*)RemoveAllWidgets);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::SlotAsVerticalBoxSlot",(const void*)SlotAsVerticalBoxSlot);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::SlotAsUniformGridSlot",(const void*)SlotAsUniformGridSlot);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::SlotAsOverlaySlot",(const void*)SlotAsOverlaySlot);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::SlotAsHorizontalBoxSlot",(const void*)SlotAsHorizontalBoxSlot);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::SlotAsGridSlot",(const void*)SlotAsGridSlot);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::SlotAsCanvasSlot",(const void*)SlotAsCanvasSlot);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::SlotAsBorderSlot",(const void*)SlotAsBorderSlot);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::GetMousePositionScaledByDPI",(const void*)GetMousePositionScaledByDPI);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::GetViewportSize",(const void*)GetViewportSize);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::GetViewportScale",(const void*)GetViewportScale);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::ProjectWorldLocationToWidgetPosition",(const void*)ProjectWorldLocationToWidgetPosition);
			mono_add_internal_call("UnrealEngine.UWidgetLayoutLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
