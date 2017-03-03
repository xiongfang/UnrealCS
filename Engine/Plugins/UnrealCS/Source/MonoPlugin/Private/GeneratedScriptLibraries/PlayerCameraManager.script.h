#pragma once

namespace UnrealEngine
{
	class _APlayerCameraManager
	{
		static void StopAllCameraAnims(APlayerCameraManager* _this,int32 bImmediate)
		{
			_this->StopAllCameraAnims(bImmediate>0?true:false);
			
		}
		static void StopCameraAnimInst(APlayerCameraManager* _this,UCameraAnimInst* AnimInst,int32 bImmediate)
		{
			_this->StopCameraAnimInst(AnimInst,bImmediate>0?true:false);
			
		}
		static void StopAllInstancesOfCameraAnim(APlayerCameraManager* _this,UCameraAnim* Anim,int32 bImmediate)
		{
			_this->StopAllInstancesOfCameraAnim(Anim,bImmediate>0?true:false);
			
		}
		static UCameraAnimInst* PlayCameraAnim(APlayerCameraManager* _this,UCameraAnim* Anim,float Rate,float Scale,float BlendInTime,float BlendOutTime,int32 bLoop,int32 bRandomStartTime,float Duration,int32 PlaySpace,FRotator* UserPlaySpaceRot)
		{
			UCameraAnimInst* ___ret = _this->PlayCameraAnim(Anim,Rate,Scale,BlendInTime,BlendOutTime,bLoop>0?true:false,bRandomStartTime>0?true:false,Duration,(TEnumAsByte<ECameraAnimPlaySpace::Type>)PlaySpace,*UserPlaySpaceRot);
			return ___ret;
			
		}
		static void SetManualCameraFade(APlayerCameraManager* _this,float InFadeAmount,FLinearColor* Color,int32 bInFadeAudio)
		{
			_this->SetManualCameraFade(InFadeAmount,*Color,bInFadeAudio>0?true:false);
			
		}
		static void StopCameraFade(APlayerCameraManager* _this)
		{
			_this->StopCameraFade();
			
		}
		static void StartCameraFade(APlayerCameraManager* _this,float FromAlpha,float ToAlpha,float Duration,FLinearColor* Color,int32 bShouldFadeAudio,int32 bHoldWhenFinished)
		{
			_this->StartCameraFade(FromAlpha,ToAlpha,Duration,*Color,bShouldFadeAudio>0?true:false,bHoldWhenFinished>0?true:false);
			
		}
		static void StopAllCameraShakes(APlayerCameraManager* _this,int32 bImmediately)
		{
			_this->StopAllCameraShakes(bImmediately>0?true:false);
			
		}
		static void StopAllInstancesOfCameraShake(APlayerCameraManager* _this,TSubclassOf<UCameraShake>  Shake,int32 bImmediately)
		{
			_this->StopAllInstancesOfCameraShake(Shake,bImmediately>0?true:false);
			
		}
		static void StopCameraShake(APlayerCameraManager* _this,UCameraShake* ShakeInstance,int32 bImmediately)
		{
			_this->StopCameraShake(ShakeInstance,bImmediately>0?true:false);
			
		}
		static UCameraShake* PlayCameraShake(APlayerCameraManager* _this,TSubclassOf<UCameraShake>  ShakeClass,float Scale,int32 PlaySpace,FRotator* UserPlaySpaceRot)
		{
			UCameraShake* ___ret = _this->PlayCameraShake(ShakeClass,Scale,(TEnumAsByte<ECameraAnimPlaySpace::Type>)PlaySpace,*UserPlaySpaceRot);
			return ___ret;
			
		}
		static void ClearCameraLensEffects(APlayerCameraManager* _this)
		{
			_this->ClearCameraLensEffects();
			
		}
		static void RemoveCameraLensEffect(APlayerCameraManager* _this,AEmitterCameraLensEffectBase* Emitter)
		{
			_this->RemoveCameraLensEffect(Emitter);
			
		}
		static AEmitterCameraLensEffectBase* AddCameraLensEffect(APlayerCameraManager* _this,TSubclassOf<AEmitterCameraLensEffectBase>  LensEffectEmitterClass)
		{
			AEmitterCameraLensEffectBase* ___ret = _this->AddCameraLensEffect(LensEffectEmitterClass);
			return ___ret;
			
		}
		static FVector GetCameraLocation(APlayerCameraManager* _this)
		{
			FVector ___ret = _this->GetCameraLocation();
			return ___ret;
			
		}
		static FRotator GetCameraRotation(APlayerCameraManager* _this)
		{
			FRotator ___ret = _this->GetCameraRotation();
			return ___ret;
			
		}
		static float GetFOVAngle(APlayerCameraManager* _this)
		{
			float ___ret = _this->GetFOVAngle();
			return ___ret;
			
		}
		static int32 RemoveCameraModifier(APlayerCameraManager* _this,UCameraModifier* ModifierToRemove)
		{
			bool ___ret = _this->RemoveCameraModifier(ModifierToRemove);
			return ___ret?1:0;
			
		}
		static UCameraModifier* FindCameraModifierByClass(APlayerCameraManager* _this,TSubclassOf<UCameraModifier>  ModifierClass)
		{
			UCameraModifier* ___ret = _this->FindCameraModifierByClass(ModifierClass);
			return ___ret;
			
		}
		static UCameraModifier* AddNewCameraModifier(APlayerCameraManager* _this,TSubclassOf<UCameraModifier>  ModifierClass)
		{
			UCameraModifier* ___ret = _this->AddNewCameraModifier(ModifierClass);
			return ___ret;
			
		}
		static APlayerController* GetOwningPlayerController(APlayerCameraManager* _this)
		{
			APlayerController* ___ret = _this->GetOwningPlayerController();
			return ___ret;
			
		}
		static UClass* StaticClass(){return APlayerCameraManager::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StopAllCameraAnims",(const void*)StopAllCameraAnims);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StopCameraAnimInst",(const void*)StopCameraAnimInst);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StopAllInstancesOfCameraAnim",(const void*)StopAllInstancesOfCameraAnim);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::PlayCameraAnim",(const void*)PlayCameraAnim);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::SetManualCameraFade",(const void*)SetManualCameraFade);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StopCameraFade",(const void*)StopCameraFade);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StartCameraFade",(const void*)StartCameraFade);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StopAllCameraShakes",(const void*)StopAllCameraShakes);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StopAllInstancesOfCameraShake",(const void*)StopAllInstancesOfCameraShake);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StopCameraShake",(const void*)StopCameraShake);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::PlayCameraShake",(const void*)PlayCameraShake);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::ClearCameraLensEffects",(const void*)ClearCameraLensEffects);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::RemoveCameraLensEffect",(const void*)RemoveCameraLensEffect);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::AddCameraLensEffect",(const void*)AddCameraLensEffect);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::GetCameraLocation",(const void*)GetCameraLocation);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::GetCameraRotation",(const void*)GetCameraRotation);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::GetFOVAngle",(const void*)GetFOVAngle);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::RemoveCameraModifier",(const void*)RemoveCameraModifier);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::FindCameraModifierByClass",(const void*)FindCameraModifierByClass);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::AddNewCameraModifier",(const void*)AddNewCameraModifier);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::GetOwningPlayerController",(const void*)GetOwningPlayerController);
			mono_add_internal_call("UnrealEngine.APlayerCameraManager::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
