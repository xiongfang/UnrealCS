#pragma once

namespace UnrealEngine
{
	class _UWidgetBlueprintLibrary
	{
		static void GetSafeZonePadding(UWidgetBlueprintLibrary* _this,UObject* WorldContextObject,FVector2D* SafePadding,FVector2D* SafePaddingScale,FVector2D* SpillOverPadding)
		{
			_this->GetSafeZonePadding(WorldContextObject,*SafePadding,*SafePaddingScale,*SpillOverPadding);
			
		}
		static FInputEvent GetInputEventFromNavigationEvent(UWidgetBlueprintLibrary* _this,FNavigationEvent* Event)
		{
			FInputEvent ___ret = _this->GetInputEventFromNavigationEvent(*Event);
			return ___ret;
			
		}
		static FInputEvent GetInputEventFromControllerEvent(UWidgetBlueprintLibrary* _this,FControllerEvent* Event)
		{
			FInputEvent ___ret = _this->GetInputEventFromControllerEvent(*Event);
			return ___ret;
			
		}
		static FInputEvent GetInputEventFromPointerEvent(UWidgetBlueprintLibrary* _this,FPointerEvent* Event)
		{
			FInputEvent ___ret = _this->GetInputEventFromPointerEvent(*Event);
			return ___ret;
			
		}
		static FInputEvent GetInputEventFromCharacterEvent(UWidgetBlueprintLibrary* _this,FCharacterEvent* Event)
		{
			FInputEvent ___ret = _this->GetInputEventFromCharacterEvent(*Event);
			return ___ret;
			
		}
		static FKeyEvent GetKeyEventFromAnalogInputEvent(UWidgetBlueprintLibrary* _this,FAnalogInputEvent* Event)
		{
			FKeyEvent ___ret = _this->GetKeyEventFromAnalogInputEvent(*Event);
			return ___ret;
			
		}
		static FInputEvent GetInputEventFromKeyEvent(UWidgetBlueprintLibrary* _this,FKeyEvent* Event)
		{
			FInputEvent ___ret = _this->GetInputEventFromKeyEvent(*Event);
			return ___ret;
			
		}
		static void GetAllWidgetsWithInterface(UWidgetBlueprintLibrary* _this,UObject* WorldContextObject,TSubclassOf<UInterface>  Interface,MonoArray** FoundWidgets,int32 TopLevelOnly)
		{
			TArray<UUserWidget*> FoundWidgets_temp;
			_this->GetAllWidgetsWithInterface(WorldContextObject,Interface,FoundWidgets_temp,TopLevelOnly>0?true:false);
			*FoundWidgets=TArrayToMonoArray(FoundWidgets_temp,"System.IntPtr,mscorlib");
			
		}
		static void GetAllWidgetsOfClass(UWidgetBlueprintLibrary* _this,UObject* WorldContextObject,MonoArray** FoundWidgets,TSubclassOf<UUserWidget>  WidgetClass,int32 TopLevelOnly)
		{
			TArray<UUserWidget*> FoundWidgets_temp;
			_this->GetAllWidgetsOfClass(WorldContextObject,FoundWidgets_temp,WidgetClass,TopLevelOnly>0?true:false);
			*FoundWidgets=TArrayToMonoArray(FoundWidgets_temp,"System.IntPtr,mscorlib");
			
		}
		static void DismissAllMenus(UWidgetBlueprintLibrary* _this)
		{
			_this->DismissAllMenus();
			
		}
		static UMaterialInstanceDynamic* GetDynamicMaterial(UWidgetBlueprintLibrary* _this,FSlateBrush* Brush)
		{
			UMaterialInstanceDynamic* ___ret = _this->GetDynamicMaterial(*Brush);
			return ___ret;
			
		}
		static FSlateBrush NoResourceBrush(UWidgetBlueprintLibrary* _this)
		{
			FSlateBrush ___ret = _this->NoResourceBrush();
			return ___ret;
			
		}
		static void SetBrushResourceToMaterial(UWidgetBlueprintLibrary* _this,FSlateBrush* Brush,UMaterialInterface* Material)
		{
			_this->SetBrushResourceToMaterial(*Brush,Material);
			
		}
		static void SetBrushResourceToTexture(UWidgetBlueprintLibrary* _this,FSlateBrush* Brush,UTexture2D* Texture)
		{
			_this->SetBrushResourceToTexture(*Brush,Texture);
			
		}
		static UMaterialInterface* GetBrushResourceAsMaterial(UWidgetBlueprintLibrary* _this,FSlateBrush* Brush)
		{
			UMaterialInterface* ___ret = _this->GetBrushResourceAsMaterial(*Brush);
			return ___ret;
			
		}
		static UTexture2D* GetBrushResourceAsTexture2D(UWidgetBlueprintLibrary* _this,FSlateBrush* Brush)
		{
			UTexture2D* ___ret = _this->GetBrushResourceAsTexture2D(*Brush);
			return ___ret;
			
		}
		static UObject* GetBrushResource(UWidgetBlueprintLibrary* _this,FSlateBrush* Brush)
		{
			UObject* ___ret = _this->GetBrushResource(*Brush);
			return ___ret;
			
		}
		static FSlateBrush MakeBrushFromMaterial(UWidgetBlueprintLibrary* _this,UMaterialInterface* Material,int32 Width,int32 Height)
		{
			FSlateBrush ___ret = _this->MakeBrushFromMaterial(Material,Width,Height);
			return ___ret;
			
		}
		static FSlateBrush MakeBrushFromTexture(UWidgetBlueprintLibrary* _this,UTexture2D* Texture,int32 Width,int32 Height)
		{
			FSlateBrush ___ret = _this->MakeBrushFromTexture(Texture,Width,Height);
			return ___ret;
			
		}
		static FSlateBrush MakeBrushFromAsset(UWidgetBlueprintLibrary* _this,USlateBrushAsset* BrushAsset)
		{
			FSlateBrush ___ret = _this->MakeBrushFromAsset(BrushAsset);
			return ___ret;
			
		}
		static void CancelDragDrop(UWidgetBlueprintLibrary* _this)
		{
			_this->CancelDragDrop();
			
		}
		static UDragDropOperation* GetDragDroppingContent(UWidgetBlueprintLibrary* _this)
		{
			UDragDropOperation* ___ret = _this->GetDragDroppingContent();
			return ___ret;
			
		}
		static int32 IsDragDropping(UWidgetBlueprintLibrary* _this)
		{
			bool ___ret = _this->IsDragDropping();
			return ___ret?1:0;
			
		}
		static FEventReply EndDragDrop(UWidgetBlueprintLibrary* _this,FEventReply* Reply)
		{
			FEventReply ___ret = _this->EndDragDrop(*Reply);
			return ___ret;
			
		}
		static FEventReply DetectDragIfPressed(UWidgetBlueprintLibrary* _this,FPointerEvent* PointerEvent,UWidget* WidgetDetectingDrag,FKey* DragKey)
		{
			FEventReply ___ret = _this->DetectDragIfPressed(*PointerEvent,WidgetDetectingDrag,*DragKey);
			return ___ret;
			
		}
		static FEventReply DetectDrag(UWidgetBlueprintLibrary* _this,FEventReply* Reply,UWidget* WidgetDetectingDrag,FKey* DragKey)
		{
			FEventReply ___ret = _this->DetectDrag(*Reply,WidgetDetectingDrag,*DragKey);
			return ___ret;
			
		}
		static FEventReply SetMousePosition(UWidgetBlueprintLibrary* _this,FEventReply* Reply,FVector2D* NewMousePosition)
		{
			FEventReply ___ret = _this->SetMousePosition(*Reply,*NewMousePosition);
			return ___ret;
			
		}
		static FEventReply ClearUserFocus(UWidgetBlueprintLibrary* _this,FEventReply* Reply,int32 bInAllUsers)
		{
			FEventReply ___ret = _this->ClearUserFocus(*Reply,bInAllUsers>0?true:false);
			return ___ret;
			
		}
		static FEventReply SetUserFocus(UWidgetBlueprintLibrary* _this,FEventReply* Reply,UWidget* FocusWidget,int32 bInAllUsers)
		{
			FEventReply ___ret = _this->SetUserFocus(*Reply,FocusWidget,bInAllUsers>0?true:false);
			return ___ret;
			
		}
		static FEventReply UnlockMouse(UWidgetBlueprintLibrary* _this,FEventReply* Reply)
		{
			FEventReply ___ret = _this->UnlockMouse(*Reply);
			return ___ret;
			
		}
		static FEventReply LockMouse(UWidgetBlueprintLibrary* _this,FEventReply* Reply,UWidget* CapturingWidget)
		{
			FEventReply ___ret = _this->LockMouse(*Reply,CapturingWidget);
			return ___ret;
			
		}
		static FEventReply ReleaseMouseCapture(UWidgetBlueprintLibrary* _this,FEventReply* Reply)
		{
			FEventReply ___ret = _this->ReleaseMouseCapture(*Reply);
			return ___ret;
			
		}
		static FEventReply CaptureMouse(UWidgetBlueprintLibrary* _this,FEventReply* Reply,UWidget* CapturingWidget)
		{
			FEventReply ___ret = _this->CaptureMouse(*Reply,CapturingWidget);
			return ___ret;
			
		}
		static FEventReply Unhandled(UWidgetBlueprintLibrary* _this)
		{
			FEventReply ___ret = _this->Unhandled();
			return ___ret;
			
		}
		static FEventReply Handled(UWidgetBlueprintLibrary* _this)
		{
			FEventReply ___ret = _this->Handled();
			return ___ret;
			
		}
		static void DrawTextFormatted(UWidgetBlueprintLibrary* _this,FPaintContext* Context,MonoString* Text,FVector2D* Position,UFont* Font,int32 FontSize,MonoString* FontTypeFace,FLinearColor* Tint)
		{
			FText Text_temp=FText::FromString(MonoStringToFString(Text));
			FName FontTypeFace_temp=MonoStringToFName(FontTypeFace);
			_this->DrawTextFormatted(*Context,Text_temp,*Position,Font,FontSize,FontTypeFace_temp,*Tint);
			
		}
		static void DrawLines(UWidgetBlueprintLibrary* _this,FPaintContext* Context,MonoArray* Points,FLinearColor* Tint,int32 bAntiAlias)
		{
			_this->DrawLines(*Context,MonoArrayToTArray<FVector2D>(Points),*Tint,bAntiAlias>0?true:false);
			
		}
		static void DrawLine(UWidgetBlueprintLibrary* _this,FPaintContext* Context,FVector2D* PositionA,FVector2D* PositionB,FLinearColor* Tint,int32 bAntiAlias)
		{
			_this->DrawLine(*Context,*PositionA,*PositionB,*Tint,bAntiAlias>0?true:false);
			
		}
		static void DrawBox(UWidgetBlueprintLibrary* _this,FPaintContext* Context,FVector2D* Position,FVector2D* Size,USlateBrushAsset* Brush,FLinearColor* Tint)
		{
			_this->DrawBox(*Context,*Position,*Size,Brush,*Tint);
			
		}
		static void SetFocusToGameViewport(UWidgetBlueprintLibrary* _this)
		{
			_this->SetFocusToGameViewport();
			
		}
		static void SetInputMode_GameOnly(UWidgetBlueprintLibrary* _this,APlayerController* Target)
		{
			_this->SetInputMode_GameOnly(Target);
			
		}
		static void SetInputMode_GameAndUIEx(UWidgetBlueprintLibrary* _this,APlayerController* Target,UWidget* InWidgetToFocus,int32 InMouseLockMode,int32 bHideCursorDuringCapture)
		{
			_this->SetInputMode_GameAndUIEx(Target,InWidgetToFocus,(EMouseLockMode)InMouseLockMode,bHideCursorDuringCapture>0?true:false);
			
		}
		static void SetInputMode_UIOnlyEx(UWidgetBlueprintLibrary* _this,APlayerController* Target,UWidget* InWidgetToFocus,int32 InMouseLockMode)
		{
			_this->SetInputMode_UIOnlyEx(Target,InWidgetToFocus,(EMouseLockMode)InMouseLockMode);
			
		}
		static UDragDropOperation* CreateDragDropOperation(UWidgetBlueprintLibrary* _this,TSubclassOf<UDragDropOperation>  OperationClass)
		{
			UDragDropOperation* ___ret = _this->CreateDragDropOperation(OperationClass);
			return ___ret;
			
		}
		static UUserWidget* Create(UWidgetBlueprintLibrary* _this,UObject* WorldContextObject,TSubclassOf<UUserWidget>  WidgetType,APlayerController* OwningPlayer)
		{
			UUserWidget* ___ret = _this->Create(WorldContextObject,WidgetType,OwningPlayer);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UWidgetBlueprintLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetSafeZonePadding",(const void*)GetSafeZonePadding);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetInputEventFromNavigationEvent",(const void*)GetInputEventFromNavigationEvent);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetInputEventFromControllerEvent",(const void*)GetInputEventFromControllerEvent);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetInputEventFromPointerEvent",(const void*)GetInputEventFromPointerEvent);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetInputEventFromCharacterEvent",(const void*)GetInputEventFromCharacterEvent);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetKeyEventFromAnalogInputEvent",(const void*)GetKeyEventFromAnalogInputEvent);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetInputEventFromKeyEvent",(const void*)GetInputEventFromKeyEvent);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetAllWidgetsWithInterface",(const void*)GetAllWidgetsWithInterface);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetAllWidgetsOfClass",(const void*)GetAllWidgetsOfClass);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::DismissAllMenus",(const void*)DismissAllMenus);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetDynamicMaterial",(const void*)GetDynamicMaterial);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::NoResourceBrush",(const void*)NoResourceBrush);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::SetBrushResourceToMaterial",(const void*)SetBrushResourceToMaterial);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::SetBrushResourceToTexture",(const void*)SetBrushResourceToTexture);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetBrushResourceAsMaterial",(const void*)GetBrushResourceAsMaterial);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetBrushResourceAsTexture2D",(const void*)GetBrushResourceAsTexture2D);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetBrushResource",(const void*)GetBrushResource);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::MakeBrushFromMaterial",(const void*)MakeBrushFromMaterial);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::MakeBrushFromTexture",(const void*)MakeBrushFromTexture);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::MakeBrushFromAsset",(const void*)MakeBrushFromAsset);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::CancelDragDrop",(const void*)CancelDragDrop);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::GetDragDroppingContent",(const void*)GetDragDroppingContent);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::IsDragDropping",(const void*)IsDragDropping);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::EndDragDrop",(const void*)EndDragDrop);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::DetectDragIfPressed",(const void*)DetectDragIfPressed);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::DetectDrag",(const void*)DetectDrag);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::SetMousePosition",(const void*)SetMousePosition);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::ClearUserFocus",(const void*)ClearUserFocus);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::SetUserFocus",(const void*)SetUserFocus);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::UnlockMouse",(const void*)UnlockMouse);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::LockMouse",(const void*)LockMouse);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::ReleaseMouseCapture",(const void*)ReleaseMouseCapture);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::CaptureMouse",(const void*)CaptureMouse);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::Unhandled",(const void*)Unhandled);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::Handled",(const void*)Handled);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::DrawTextFormatted",(const void*)DrawTextFormatted);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::DrawLines",(const void*)DrawLines);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::DrawLine",(const void*)DrawLine);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::DrawBox",(const void*)DrawBox);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::SetFocusToGameViewport",(const void*)SetFocusToGameViewport);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::SetInputMode_GameOnly",(const void*)SetInputMode_GameOnly);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::SetInputMode_GameAndUIEx",(const void*)SetInputMode_GameAndUIEx);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::SetInputMode_UIOnlyEx",(const void*)SetInputMode_UIOnlyEx);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::CreateDragDropOperation",(const void*)CreateDragDropOperation);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::Create",(const void*)Create);
			mono_add_internal_call("UnrealEngine.UWidgetBlueprintLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
