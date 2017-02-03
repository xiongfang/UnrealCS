#pragma once

namespace UnrealEngine
{
	class _AHUD
	{
		static void AddHitBox(AHUD* _this,FVector2D* Position,FVector2D* Size,MonoString* InName,int32 bConsumesInput,int32 Priority)
		{
			FName InName_temp=MonoStringToFName(InName);
			_this->AddHitBox(*Position,*Size,InName_temp,bConsumesInput>0?true:false,Priority);
			
		}
		static void GetActorsInSelectionRectangle(AHUD* _this,TSubclassOf<AActor>  ClassFilter,FVector2D* FirstPoint,FVector2D* SecondPoint,MonoArray** OutActors,int32 bIncludeNonCollidingComponents,int32 bActorMustBeFullyEnclosed)
		{
			TArray<AActor*> OutActors_temp;
			_this->GetActorsInSelectionRectangle(ClassFilter,*FirstPoint,*SecondPoint,OutActors_temp,bIncludeNonCollidingComponents>0?true:false,bActorMustBeFullyEnclosed>0?true:false);
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static void Deproject(AHUD* _this,float ScreenX,float ScreenY,FVector* WorldPosition,FVector* WorldDirection)
		{
			_this->Deproject(ScreenX,ScreenY,*WorldPosition,*WorldDirection);
			
		}
		static FVector Project(AHUD* _this,FVector* Location)
		{
			FVector ___ret = _this->Project(*Location);
			return ___ret;
			
		}
		static void DrawMaterialTriangle(AHUD* _this,UMaterialInterface* Material,FVector2D* V0_Pos,FVector2D* V1_Pos,FVector2D* V2_Pos,FVector2D* V0_UV,FVector2D* V1_UV,FVector2D* V2_UV,FLinearColor* V0_Color,FLinearColor* V1_Color,FLinearColor* V2_Color)
		{
			_this->DrawMaterialTriangle(Material,*V0_Pos,*V1_Pos,*V2_Pos,*V0_UV,*V1_UV,*V2_UV,*V0_Color,*V1_Color,*V2_Color);
			
		}
		static void DrawMaterialSimple(AHUD* _this,UMaterialInterface* Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale,int32 bScalePosition)
		{
			_this->DrawMaterialSimple(Material,ScreenX,ScreenY,ScreenW,ScreenH,Scale,bScalePosition>0?true:false);
			
		}
		static void DrawMaterial(AHUD* _this,UMaterialInterface* Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale,int32 bScalePosition,float Rotation,FVector2D* RotPivot)
		{
			_this->DrawMaterial(Material,ScreenX,ScreenY,ScreenW,ScreenH,MaterialU,MaterialV,MaterialUWidth,MaterialVHeight,Scale,bScalePosition>0?true:false,Rotation,*RotPivot);
			
		}
		static void DrawTextureSimple(AHUD* _this,UTexture* Texture,float ScreenX,float ScreenY,float Scale,int32 bScalePosition)
		{
			_this->DrawTextureSimple(Texture,ScreenX,ScreenY,Scale,bScalePosition>0?true:false);
			
		}
		static void DrawTexture(AHUD* _this,UTexture* Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,FLinearColor* TintColor,int32 BlendMode,float Scale,int32 bScalePosition,float Rotation,FVector2D* RotPivot)
		{
			_this->DrawTexture(Texture,ScreenX,ScreenY,ScreenW,ScreenH,TextureU,TextureV,TextureUWidth,TextureVHeight,*TintColor,(TEnumAsByte<EBlendMode>)BlendMode,Scale,bScalePosition>0?true:false,Rotation,*RotPivot);
			
		}
		static void DrawRect(AHUD* _this,FLinearColor* RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH)
		{
			_this->DrawRect(*RectColor,ScreenX,ScreenY,ScreenW,ScreenH);
			
		}
		static void DrawLine(AHUD* _this,float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,FLinearColor* LineColor,float LineThickness)
		{
			_this->DrawLine(StartScreenX,StartScreenY,EndScreenX,EndScreenY,*LineColor,LineThickness);
			
		}
		static void DrawText(AHUD* _this,MonoString* Text,FLinearColor* TextColor,float ScreenX,float ScreenY,UFont* Font,float Scale,int32 bScalePosition)
		{
			FString Text_temp=MonoStringToFString(Text);
			_this->DrawText(Text_temp,*TextColor,ScreenX,ScreenY,Font,Scale,bScalePosition>0?true:false);
			
		}
		static void GetTextSize(AHUD* _this,MonoString* Text,float* OutWidth,float* OutHeight,UFont* Font,float Scale)
		{
			FString Text_temp=MonoStringToFString(Text);
			_this->GetTextSize(Text_temp,*OutWidth,*OutHeight,Font,Scale);
			
		}
		static void RemoveDebugText(AHUD* _this,AActor* SrcActor,int32 bLeaveDurationText)
		{
			_this->RemoveDebugText(SrcActor,bLeaveDurationText>0?true:false);
			
		}
		static void RemoveAllDebugStrings(AHUD* _this)
		{
			_this->RemoveAllDebugStrings();
			
		}
		static void AddDebugText(AHUD* _this,MonoString* DebugText,AActor* SrcActor,float Duration,FVector* Offset,FVector* DesiredOffset,FColor* TextColor,int32 bSkipOverwriteCheck,int32 bAbsoluteLocation,int32 bKeepAttachedToActor,UFont* InFont,float FontScale,int32 bDrawShadow)
		{
			FString DebugText_temp=MonoStringToFString(DebugText);
			_this->AddDebugText(DebugText_temp,SrcActor,Duration,*Offset,*DesiredOffset,*TextColor,bSkipOverwriteCheck>0?true:false,bAbsoluteLocation>0?true:false,bKeepAttachedToActor>0?true:false,InFont,FontScale,bDrawShadow>0?true:false);
			
		}
		static void ShowDebugForReticleTargetToggle(AHUD* _this,TSubclassOf<AActor>  DesiredClass)
		{
			_this->ShowDebugForReticleTargetToggle(DesiredClass);
			
		}
		static void ShowDebugToggleSubCategory(AHUD* _this,MonoString* Category)
		{
			FName Category_temp=MonoStringToFName(Category);
			_this->ShowDebugToggleSubCategory(Category_temp);
			
		}
		static void ShowDebug(AHUD* _this,MonoString* DebugType)
		{
			FName DebugType_temp=MonoStringToFName(DebugType);
			_this->ShowDebug(DebugType_temp);
			
		}
		static void ShowHUD(AHUD* _this)
		{
			_this->ShowHUD();
			
		}
		static UClass* StaticClass(){return AHUD::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AHUD::AddHitBox",(const void*)AddHitBox);
			mono_add_internal_call("UnrealEngine.AHUD::GetActorsInSelectionRectangle",(const void*)GetActorsInSelectionRectangle);
			mono_add_internal_call("UnrealEngine.AHUD::Deproject",(const void*)Deproject);
			mono_add_internal_call("UnrealEngine.AHUD::Project",(const void*)Project);
			mono_add_internal_call("UnrealEngine.AHUD::DrawMaterialTriangle",(const void*)DrawMaterialTriangle);
			mono_add_internal_call("UnrealEngine.AHUD::DrawMaterialSimple",(const void*)DrawMaterialSimple);
			mono_add_internal_call("UnrealEngine.AHUD::DrawMaterial",(const void*)DrawMaterial);
			mono_add_internal_call("UnrealEngine.AHUD::DrawTextureSimple",(const void*)DrawTextureSimple);
			mono_add_internal_call("UnrealEngine.AHUD::DrawTexture",(const void*)DrawTexture);
			mono_add_internal_call("UnrealEngine.AHUD::DrawRect",(const void*)DrawRect);
			mono_add_internal_call("UnrealEngine.AHUD::DrawLine",(const void*)DrawLine);
			mono_add_internal_call("UnrealEngine.AHUD::DrawText",(const void*)DrawText);
			mono_add_internal_call("UnrealEngine.AHUD::GetTextSize",(const void*)GetTextSize);
			mono_add_internal_call("UnrealEngine.AHUD::RemoveDebugText",(const void*)RemoveDebugText);
			mono_add_internal_call("UnrealEngine.AHUD::RemoveAllDebugStrings",(const void*)RemoveAllDebugStrings);
			mono_add_internal_call("UnrealEngine.AHUD::AddDebugText",(const void*)AddDebugText);
			mono_add_internal_call("UnrealEngine.AHUD::ShowDebugForReticleTargetToggle",(const void*)ShowDebugForReticleTargetToggle);
			mono_add_internal_call("UnrealEngine.AHUD::ShowDebugToggleSubCategory",(const void*)ShowDebugToggleSubCategory);
			mono_add_internal_call("UnrealEngine.AHUD::ShowDebug",(const void*)ShowDebug);
			mono_add_internal_call("UnrealEngine.AHUD::ShowHUD",(const void*)ShowHUD);
			mono_add_internal_call("UnrealEngine.AHUD::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
