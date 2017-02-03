#pragma once

namespace UnrealEngine
{
	class _APlayerController
	{
		static FVector GetFocalLocation(APlayerController* _this)
		{
			FVector ___ret = _this->GetFocalLocation();
			return ___ret;
			
		}
		static ASpectatorPawn* GetSpectatorPawn(APlayerController* _this)
		{
			ASpectatorPawn* ___ret = _this->GetSpectatorPawn();
			return ___ret;
			
		}
		static void OnServerStartedVisualLogger(APlayerController* _this,int32 bIsLogging)
		{
			_this->OnServerStartedVisualLogger(bIsLogging>0?true:false);
			
		}
		static void SetCinematicMode(APlayerController* _this,int32 bInCinematicMode,int32 bHidePlayer,int32 bAffectsHUD,int32 bAffectsMovement,int32 bAffectsTurning)
		{
			_this->SetCinematicMode(bInCinematicMode>0?true:false,bHidePlayer>0?true:false,bAffectsHUD>0?true:false,bAffectsMovement>0?true:false,bAffectsTurning>0?true:false);
			
		}
		static void ClearAudioListenerOverride(APlayerController* _this)
		{
			_this->ClearAudioListenerOverride();
			
		}
		static void SetAudioListenerOverride(APlayerController* _this,USceneComponent* AttachToComponent,FVector* Location,FRotator* Rotation)
		{
			_this->SetAudioListenerOverride(AttachToComponent,*Location,*Rotation);
			
		}
		static void SetViewTargetWithBlend(APlayerController* _this,AActor* NewViewTarget,float BlendTime,int32 BlendFunc,float BlendExp,int32 bLockOutgoing)
		{
			_this->SetViewTargetWithBlend(NewViewTarget,BlendTime,(TEnumAsByte<EViewTargetBlendFunction>)BlendFunc,BlendExp,bLockOutgoing>0?true:false);
			
		}
		static void Camera(APlayerController* _this,MonoString* NewMode)
		{
			FName NewMode_temp=MonoStringToFName(NewMode);
			_this->Camera(NewMode_temp);
			
		}
		static void SetVirtualJoystickVisibility(APlayerController* _this,int32 bVisible)
		{
			_this->SetVirtualJoystickVisibility(bVisible>0?true:false);
			
		}
		static void ActivateTouchInterface(APlayerController* _this,UTouchInterface* NewTouchInterface)
		{
			_this->ActivateTouchInterface(NewTouchInterface);
			
		}
		static void GetInputAnalogStickState(APlayerController* _this,int32 WhichStick,float* StickX,float* StickY)
		{
			_this->GetInputAnalogStickState((TEnumAsByte<EControllerAnalogStick::Type>)WhichStick,*StickX,*StickY);
			
		}
		static void GetInputMouseDelta(APlayerController* _this,float* DeltaX,float* DeltaY)
		{
			_this->GetInputMouseDelta(*DeltaX,*DeltaY);
			
		}
		static float GetInputKeyTimeDown(APlayerController* _this,FKey* Key)
		{
			float ___ret = _this->GetInputKeyTimeDown(*Key);
			return ___ret;
			
		}
		static int32 GetMousePosition(APlayerController* _this,float* LocationX,float* LocationY)
		{
			bool ___ret = _this->GetMousePosition(*LocationX,*LocationY);
			return ___ret?1:0;
			
		}
		static void GetInputMotionState(APlayerController* _this,FVector* Tilt,FVector* RotationRate,FVector* Gravity,FVector* Acceleration)
		{
			_this->GetInputMotionState(*Tilt,*RotationRate,*Gravity,*Acceleration);
			
		}
		static void GetInputTouchState(APlayerController* _this,int32 FingerIndex,float* LocationX,float* LocationY,int32* bIsCurrentlyPressed)
		{
			bool bIsCurrentlyPressed_temp;
			_this->GetInputTouchState((TEnumAsByte<ETouchIndex::Type>)FingerIndex,*LocationX,*LocationY,bIsCurrentlyPressed_temp);
			*bIsCurrentlyPressed=bIsCurrentlyPressed_temp!=0;
			
		}
		static FVector GetInputVectorKeyState(APlayerController* _this,FKey* Key)
		{
			FVector ___ret = _this->GetInputVectorKeyState(*Key);
			return ___ret;
			
		}
		static float GetInputAnalogKeyState(APlayerController* _this,FKey* Key)
		{
			float ___ret = _this->GetInputAnalogKeyState(*Key);
			return ___ret;
			
		}
		static int32 WasInputKeyJustReleased(APlayerController* _this,FKey* Key)
		{
			bool ___ret = _this->WasInputKeyJustReleased(*Key);
			return ___ret?1:0;
			
		}
		static int32 WasInputKeyJustPressed(APlayerController* _this,FKey* Key)
		{
			bool ___ret = _this->WasInputKeyJustPressed(*Key);
			return ___ret?1:0;
			
		}
		static int32 IsInputKeyDown(APlayerController* _this,FKey* Key)
		{
			bool ___ret = _this->IsInputKeyDown(*Key);
			return ___ret?1:0;
			
		}
		static void AddRollInput(APlayerController* _this,float Val)
		{
			_this->AddRollInput(Val);
			
		}
		static void AddYawInput(APlayerController* _this,float Val)
		{
			_this->AddYawInput(Val);
			
		}
		static void AddPitchInput(APlayerController* _this,float Val)
		{
			_this->AddPitchInput(Val);
			
		}
		static void ServerToggleAILogging(APlayerController* _this)
		{
			_this->ServerToggleAILogging();
			
		}
		static void ClientTeamMessage(APlayerController* _this,APlayerState* SenderPlayerState,MonoString* S,MonoString* Type,float MsgLifeTime)
		{
			FString S_temp=MonoStringToFString(S);
			FName Type_temp=MonoStringToFName(Type);
			_this->ClientTeamMessage(SenderPlayerState,S_temp,Type_temp,MsgLifeTime);
			
		}
		static void ServerViewSelf(APlayerController* _this,FViewTargetTransitionParams* TransitionParams)
		{
			_this->ServerViewSelf(*TransitionParams);
			
		}
		static void ServerViewPrevPlayer(APlayerController* _this)
		{
			_this->ServerViewPrevPlayer();
			
		}
		static void ServerViewNextPlayer(APlayerController* _this)
		{
			_this->ServerViewNextPlayer();
			
		}
		static void ServerVerifyViewTarget(APlayerController* _this)
		{
			_this->ServerVerifyViewTarget();
			
		}
		static void ServerUpdateLevelVisibility(APlayerController* _this,MonoString* PackageName,int32 bIsVisible)
		{
			FName PackageName_temp=MonoStringToFName(PackageName);
			_this->ServerUpdateLevelVisibility(PackageName_temp,bIsVisible>0?true:false);
			
		}
		static void ServerUpdateCamera(APlayerController* _this,FVector_NetQuantize* CamLoc,int32 CamPitchAndYaw)
		{
			_this->ServerUpdateCamera(*CamLoc,CamPitchAndYaw);
			
		}
		static void ServerShortTimeout(APlayerController* _this)
		{
			_this->ServerShortTimeout();
			
		}
		static void ServerCheckClientPossessionReliable(APlayerController* _this)
		{
			_this->ServerCheckClientPossessionReliable();
			
		}
		static void ServerCheckClientPossession(APlayerController* _this)
		{
			_this->ServerCheckClientPossession();
			
		}
		static void ServerSetSpectatorLocation(APlayerController* _this,FVector* NewLoc,FRotator* NewRot)
		{
			_this->ServerSetSpectatorLocation(*NewLoc,*NewRot);
			
		}
		static void ServerRestartPlayer(APlayerController* _this)
		{
			_this->ServerRestartPlayer();
			
		}
		static void ServerPause(APlayerController* _this)
		{
			_this->ServerPause();
			
		}
		static void ServerNotifyLoadedWorld(APlayerController* _this,MonoString* WorldPackageName)
		{
			FName WorldPackageName_temp=MonoStringToFName(WorldPackageName);
			_this->ServerNotifyLoadedWorld(WorldPackageName_temp);
			
		}
		static void ServerChangeName(APlayerController* _this,MonoString* S)
		{
			FString S_temp=MonoStringToFString(S);
			_this->ServerChangeName(S_temp);
			
		}
		static void ServerCamera(APlayerController* _this,MonoString* NewMode)
		{
			FName NewMode_temp=MonoStringToFName(NewMode);
			_this->ServerCamera(NewMode_temp);
			
		}
		static void ServerAcknowledgePossession(APlayerController* _this,APawn* P)
		{
			_this->ServerAcknowledgePossession(P);
			
		}
		static void ClientReceiveLocalizedMessage(APlayerController* _this,TSubclassOf<ULocalMessage>  Message,int32 Switch,APlayerState* RelatedPlayerState_1,APlayerState* RelatedPlayerState_2,UObject* OptionalObject)
		{
			_this->ClientReceiveLocalizedMessage(Message,Switch,RelatedPlayerState_1,RelatedPlayerState_2,OptionalObject);
			
		}
		static void ClientRetryClientRestart(APlayerController* _this,APawn* NewPawn)
		{
			_this->ClientRetryClientRestart(NewPawn);
			
		}
		static void ClientEndOnlineSession(APlayerController* _this)
		{
			_this->ClientEndOnlineSession();
			
		}
		static void ClientStartOnlineSession(APlayerController* _this)
		{
			_this->ClientStartOnlineSession();
			
		}
		static void ClientWasKicked(APlayerController* _this,MonoString* KickReason)
		{
			FText KickReason_temp=FText::FromString(MonoStringToFString(KickReason));
			_this->ClientWasKicked(KickReason_temp);
			
		}
		static void ClientUpdateLevelStreamingStatus(APlayerController* _this,MonoString* PackageName,int32 bNewShouldBeLoaded,int32 bNewShouldBeVisible,int32 bNewShouldBlockOnLoad,int32 LODIndex)
		{
			FName PackageName_temp=MonoStringToFName(PackageName);
			_this->ClientUpdateLevelStreamingStatus(PackageName_temp,bNewShouldBeLoaded>0?true:false,bNewShouldBeVisible>0?true:false,bNewShouldBlockOnLoad>0?true:false,LODIndex);
			
		}
		static void ClientTravelInternal(APlayerController* _this,MonoString* URL,int32 TravelType,int32 bSeamless,FGuid* MapPackageGuid)
		{
			FString URL_temp=MonoStringToFString(URL);
			_this->ClientTravelInternal(URL_temp,(TEnumAsByte<ETravelType>)TravelType,bSeamless>0?true:false,*MapPackageGuid);
			
		}
		static void ClientTravel(APlayerController* _this,MonoString* URL,int32 TravelType,int32 bSeamless,FGuid* MapPackageGuid)
		{
			FString URL_temp=MonoStringToFString(URL);
			_this->ClientTravel(URL_temp,(TEnumAsByte<ETravelType>)TravelType,bSeamless>0?true:false,*MapPackageGuid);
			
		}
		static void SetControllerLightColor(APlayerController* _this,FColor* Color)
		{
			_this->SetControllerLightColor(*Color);
			
		}
		static void SetHapticsByValue(APlayerController* _this,float Frequency,float Amplitude,int32 Hand)
		{
			_this->SetHapticsByValue(Frequency,Amplitude,(TEnumAsByte<EControllerHand>)Hand);
			
		}
		static void StopHapticEffect(APlayerController* _this,int32 Hand)
		{
			_this->StopHapticEffect((TEnumAsByte<EControllerHand>)Hand);
			
		}
		static void PlayHapticEffect(APlayerController* _this,UHapticFeedbackEffect_Base* HapticEffect,int32 Hand,float Scale,int32 bLoop)
		{
			_this->PlayHapticEffect(HapticEffect,(TEnumAsByte<EControllerHand>)Hand,Scale,bLoop>0?true:false);
			
		}
		static void PlayDynamicForceFeedback(APlayerController* _this,float Intensity,float Duration,int32 bAffectsLeftLarge,int32 bAffectsLeftSmall,int32 bAffectsRightLarge,int32 bAffectsRightSmall,int32 Action,FLatentActionInfo* LatentInfo)
		{
			_this->PlayDynamicForceFeedback(Intensity,Duration,bAffectsLeftLarge>0?true:false,bAffectsLeftSmall>0?true:false,bAffectsRightLarge>0?true:false,bAffectsRightSmall>0?true:false,(TEnumAsByte<EDynamicForceFeedbackAction::Type>)Action,*LatentInfo);
			
		}
		static void ClientStopForceFeedback(APlayerController* _this,UForceFeedbackEffect* ForceFeedbackEffect,MonoString* Tag)
		{
			FName Tag_temp=MonoStringToFName(Tag);
			_this->ClientStopForceFeedback(ForceFeedbackEffect,Tag_temp);
			
		}
		static void ClientPlayForceFeedback(APlayerController* _this,UForceFeedbackEffect* ForceFeedbackEffect,int32 bLooping,MonoString* Tag)
		{
			FName Tag_temp=MonoStringToFName(Tag);
			_this->ClientPlayForceFeedback(ForceFeedbackEffect,bLooping>0?true:false,Tag_temp);
			
		}
		static void ClientStopCameraShake(APlayerController* _this,TSubclassOf<UCameraShake>  Shake,int32 bImmediately)
		{
			_this->ClientStopCameraShake(Shake,bImmediately>0?true:false);
			
		}
		static void ClientStopCameraAnim(APlayerController* _this,UCameraAnim* AnimToStop)
		{
			_this->ClientStopCameraAnim(AnimToStop);
			
		}
		static void ClientClearCameraLensEffects(APlayerController* _this)
		{
			_this->ClientClearCameraLensEffects();
			
		}
		static void ClientSpawnCameraLensEffect(APlayerController* _this,TSubclassOf<AEmitterCameraLensEffectBase>  LensEffectEmitterClass)
		{
			_this->ClientSpawnCameraLensEffect(LensEffectEmitterClass);
			
		}
		static void ClientSetViewTarget(APlayerController* _this,AActor* A,FViewTargetTransitionParams* TransitionParams)
		{
			_this->ClientSetViewTarget(A,*TransitionParams);
			
		}
		static AHUD* GetHUD(APlayerController* _this)
		{
			AHUD* ___ret = _this->GetHUD();
			return ___ret;
			
		}
		static void GetViewportSize(APlayerController* _this,int32* SizeX,int32* SizeY)
		{
			_this->GetViewportSize(*SizeX,*SizeY);
			
		}
		static void ClientSetHUD(APlayerController* _this,TSubclassOf<AHUD>  NewHUDClass)
		{
			_this->ClientSetHUD(NewHUDClass);
			
		}
		static void ClientSetForceMipLevelsToBeResident(APlayerController* _this,UMaterialInterface* Material,float ForceDuration,int32 CinematicTextureGroups)
		{
			_this->ClientSetForceMipLevelsToBeResident(Material,ForceDuration,CinematicTextureGroups);
			
		}
		static void ClientSetCinematicMode(APlayerController* _this,int32 bInCinematicMode,int32 bAffectsMovement,int32 bAffectsTurning,int32 bAffectsHUD)
		{
			_this->ClientSetCinematicMode(bInCinematicMode>0?true:false,bAffectsMovement>0?true:false,bAffectsTurning>0?true:false,bAffectsHUD>0?true:false);
			
		}
		static void ClientSetCameraMode(APlayerController* _this,MonoString* NewCamMode)
		{
			FName NewCamMode_temp=MonoStringToFName(NewCamMode);
			_this->ClientSetCameraMode(NewCamMode_temp);
			
		}
		static void ClientSetCameraFade(APlayerController* _this,int32 bEnableFading,FColor* FadeColor,FVector2D* FadeAlpha,float FadeTime,int32 bFadeAudio)
		{
			_this->ClientSetCameraFade(bEnableFading>0?true:false,*FadeColor,*FadeAlpha,FadeTime,bFadeAudio>0?true:false);
			
		}
		static void ClientSetBlockOnAsyncLoading(APlayerController* _this)
		{
			_this->ClientSetBlockOnAsyncLoading();
			
		}
		static void ClientRestart(APlayerController* _this,APawn* NewPawn)
		{
			_this->ClientRestart(NewPawn);
			
		}
		static void ClientReset(APlayerController* _this)
		{
			_this->ClientReset();
			
		}
		static void ClientPrestreamTextures(APlayerController* _this,AActor* ForcedActor,float ForceDuration,int32 bEnableStreaming,int32 CinematicTextureGroups)
		{
			_this->ClientPrestreamTextures(ForcedActor,ForceDuration,bEnableStreaming>0?true:false,CinematicTextureGroups);
			
		}
		static void ClientPrepareMapChange(APlayerController* _this,MonoString* LevelName,int32 bFirst,int32 bLast)
		{
			FName LevelName_temp=MonoStringToFName(LevelName);
			_this->ClientPrepareMapChange(LevelName_temp,bFirst>0?true:false,bLast>0?true:false);
			
		}
		static void ClientPlaySoundAtLocation(APlayerController* _this,USoundBase* Sound,FVector* Location,float VolumeMultiplier,float PitchMultiplier)
		{
			_this->ClientPlaySoundAtLocation(Sound,*Location,VolumeMultiplier,PitchMultiplier);
			
		}
		static void ClientPlaySound(APlayerController* _this,USoundBase* Sound,float VolumeMultiplier,float PitchMultiplier)
		{
			_this->ClientPlaySound(Sound,VolumeMultiplier,PitchMultiplier);
			
		}
		static void ClientPlayCameraShake(APlayerController* _this,TSubclassOf<UCameraShake>  Shake,float Scale,int32 PlaySpace,FRotator* UserPlaySpaceRot)
		{
			_this->ClientPlayCameraShake(Shake,Scale,(TEnumAsByte<ECameraAnimPlaySpace::Type>)PlaySpace,*UserPlaySpaceRot);
			
		}
		static void ClientPlayCameraAnim(APlayerController* _this,UCameraAnim* AnimToPlay,float Scale,float Rate,float BlendInTime,float BlendOutTime,int32 bLoop,int32 bRandomStartTime,int32 Space,FRotator* CustomPlaySpace)
		{
			_this->ClientPlayCameraAnim(AnimToPlay,Scale,Rate,BlendInTime,BlendOutTime,bLoop>0?true:false,bRandomStartTime>0?true:false,(TEnumAsByte<ECameraAnimPlaySpace::Type>)Space,*CustomPlaySpace);
			
		}
		static void ClientMessage(APlayerController* _this,MonoString* S,MonoString* Type,float MsgLifeTime)
		{
			FString S_temp=MonoStringToFString(S);
			FName Type_temp=MonoStringToFName(Type);
			_this->ClientMessage(S_temp,Type_temp,MsgLifeTime);
			
		}
		static void ClientIgnoreMoveInput(APlayerController* _this,int32 bIgnore)
		{
			_this->ClientIgnoreMoveInput(bIgnore>0?true:false);
			
		}
		static void ClientIgnoreLookInput(APlayerController* _this,int32 bIgnore)
		{
			_this->ClientIgnoreLookInput(bIgnore>0?true:false);
			
		}
		static void ClientGotoState(APlayerController* _this,MonoString* NewState)
		{
			FName NewState_temp=MonoStringToFName(NewState);
			_this->ClientGotoState(NewState_temp);
			
		}
		static void ClientGameEnded(APlayerController* _this,AActor* EndGameFocus,int32 bIsWinner)
		{
			_this->ClientGameEnded(EndGameFocus,bIsWinner>0?true:false);
			
		}
		static void ClientForceGarbageCollection(APlayerController* _this)
		{
			_this->ClientForceGarbageCollection();
			
		}
		static void ClientFlushLevelStreaming(APlayerController* _this)
		{
			_this->ClientFlushLevelStreaming();
			
		}
		static void ClientCommitMapChange(APlayerController* _this)
		{
			_this->ClientCommitMapChange();
			
		}
		static void ClientCapBandwidth(APlayerController* _this,int32 Cap)
		{
			_this->ClientCapBandwidth(Cap);
			
		}
		static void ClientCancelPendingMapChange(APlayerController* _this)
		{
			_this->ClientCancelPendingMapChange();
			
		}
		static void ClientAddTextureStreamingLoc(APlayerController* _this,FVector* InLoc,float Duration,int32 bOverrideLocation)
		{
			_this->ClientAddTextureStreamingLoc(*InLoc,Duration,bOverrideLocation>0?true:false);
			
		}
		static void SendToConsole(APlayerController* _this,MonoString* Command)
		{
			FString Command_temp=MonoStringToFString(Command);
			_this->SendToConsole(Command_temp);
			
		}
		static void ConsoleKey(APlayerController* _this,FKey* Key)
		{
			_this->ConsoleKey(*Key);
			
		}
		static void ClientUnmutePlayer(APlayerController* _this,FUniqueNetIdRepl* PlayerId)
		{
			_this->ClientUnmutePlayer(*PlayerId);
			
		}
		static void ClientMutePlayer(APlayerController* _this,FUniqueNetIdRepl* PlayerId)
		{
			_this->ClientMutePlayer(*PlayerId);
			
		}
		static void ServerUnmutePlayer(APlayerController* _this,FUniqueNetIdRepl* PlayerId)
		{
			_this->ServerUnmutePlayer(*PlayerId);
			
		}
		static void ServerMutePlayer(APlayerController* _this,FUniqueNetIdRepl* PlayerId)
		{
			_this->ServerMutePlayer(*PlayerId);
			
		}
		static void ClientVoiceHandshakeComplete(APlayerController* _this)
		{
			_this->ClientVoiceHandshakeComplete();
			
		}
		static void ToggleSpeaking(APlayerController* _this,int32 bInSpeaking)
		{
			_this->ToggleSpeaking(bInSpeaking>0?true:false);
			
		}
		static void ClientEnableNetworkVoice(APlayerController* _this,int32 bEnable)
		{
			_this->ClientEnableNetworkVoice(bEnable>0?true:false);
			
		}
		static void StartFire(APlayerController* _this,int32 FireModeNum)
		{
			_this->StartFire(FireModeNum);
			
		}
		static int32 ProjectWorldLocationToScreen(APlayerController* _this,FVector* WorldLocation,FVector2D* ScreenLocation)
		{
			bool ___ret = _this->ProjectWorldLocationToScreen(*WorldLocation,*ScreenLocation);
			return ___ret?1:0;
			
		}
		static int32 DeprojectScreenPositionToWorld(APlayerController* _this,float ScreenX,float ScreenY,FVector* WorldLocation,FVector* WorldDirection)
		{
			bool ___ret = _this->DeprojectScreenPositionToWorld(ScreenX,ScreenY,*WorldLocation,*WorldDirection);
			return ___ret?1:0;
			
		}
		static int32 DeprojectMousePositionToWorld(APlayerController* _this,FVector* WorldLocation,FVector* WorldDirection)
		{
			bool ___ret = _this->DeprojectMousePositionToWorld(*WorldLocation,*WorldDirection);
			return ___ret?1:0;
			
		}
		static int32 GetHitResultUnderFingerForObjects(APlayerController* _this,int32 FingerIndex,MonoArray* ObjectTypes,int32 bTraceComplex,FHitResult* HitResult)
		{
			bool ___ret = _this->GetHitResultUnderFingerForObjects((TEnumAsByte<ETouchIndex::Type>)FingerIndex,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,*HitResult);
			return ___ret?1:0;
			
		}
		static int32 GetHitResultUnderFingerByChannel(APlayerController* _this,int32 FingerIndex,int32 TraceChannel,int32 bTraceComplex,FHitResult* HitResult)
		{
			bool ___ret = _this->GetHitResultUnderFingerByChannel((TEnumAsByte<ETouchIndex::Type>)FingerIndex,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,*HitResult);
			return ___ret?1:0;
			
		}
		static int32 GetHitResultUnderCursorForObjects(APlayerController* _this,MonoArray* ObjectTypes,int32 bTraceComplex,FHitResult* HitResult)
		{
			bool ___ret = _this->GetHitResultUnderCursorForObjects(MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,*HitResult);
			return ___ret?1:0;
			
		}
		static int32 GetHitResultUnderCursorByChannel(APlayerController* _this,int32 TraceChannel,int32 bTraceComplex,FHitResult* HitResult)
		{
			bool ___ret = _this->GetHitResultUnderCursorByChannel((TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,*HitResult);
			return ___ret?1:0;
			
		}
		static void SwitchLevel(APlayerController* _this,MonoString* URL)
		{
			FString URL_temp=MonoStringToFString(URL);
			_this->SwitchLevel(URL_temp);
			
		}
		static void SetName(APlayerController* _this,MonoString* S)
		{
			FString S_temp=MonoStringToFString(S);
			_this->SetName(S_temp);
			
		}
		static void Pause(APlayerController* _this)
		{
			_this->Pause();
			
		}
		static void ClientRepObjRef(APlayerController* _this,UObject* Object)
		{
			_this->ClientRepObjRef(Object);
			
		}
		static void ClientReturnToMainMenu(APlayerController* _this,MonoString* ReturnReason)
		{
			FString ReturnReason_temp=MonoStringToFString(ReturnReason);
			_this->ClientReturnToMainMenu(ReturnReason_temp);
			
		}
		static void LocalTravel(APlayerController* _this,MonoString* URL)
		{
			FString URL_temp=MonoStringToFString(URL);
			_this->LocalTravel(URL_temp);
			
		}
		static void RestartLevel(APlayerController* _this)
		{
			_this->RestartLevel();
			
		}
		static void FOV(APlayerController* _this,float NewFOV)
		{
			_this->FOV(NewFOV);
			
		}
		static void EnableCheats(APlayerController* _this)
		{
			_this->EnableCheats();
			
		}
		static void ClientSetSpectatorWaiting(APlayerController* _this,int32 bWaiting)
		{
			_this->ClientSetSpectatorWaiting(bWaiting>0?true:false);
			
		}
		static void ServerSetSpectatorWaiting(APlayerController* _this,int32 bWaiting)
		{
			_this->ServerSetSpectatorWaiting(bWaiting>0?true:false);
			
		}
		static UClass* StaticClass(){return APlayerController::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APlayerController::GetFocalLocation",(const void*)GetFocalLocation);
			mono_add_internal_call("UnrealEngine.APlayerController::GetSpectatorPawn",(const void*)GetSpectatorPawn);
			mono_add_internal_call("UnrealEngine.APlayerController::OnServerStartedVisualLogger",(const void*)OnServerStartedVisualLogger);
			mono_add_internal_call("UnrealEngine.APlayerController::SetCinematicMode",(const void*)SetCinematicMode);
			mono_add_internal_call("UnrealEngine.APlayerController::ClearAudioListenerOverride",(const void*)ClearAudioListenerOverride);
			mono_add_internal_call("UnrealEngine.APlayerController::SetAudioListenerOverride",(const void*)SetAudioListenerOverride);
			mono_add_internal_call("UnrealEngine.APlayerController::SetViewTargetWithBlend",(const void*)SetViewTargetWithBlend);
			mono_add_internal_call("UnrealEngine.APlayerController::Camera",(const void*)Camera);
			mono_add_internal_call("UnrealEngine.APlayerController::SetVirtualJoystickVisibility",(const void*)SetVirtualJoystickVisibility);
			mono_add_internal_call("UnrealEngine.APlayerController::ActivateTouchInterface",(const void*)ActivateTouchInterface);
			mono_add_internal_call("UnrealEngine.APlayerController::GetInputAnalogStickState",(const void*)GetInputAnalogStickState);
			mono_add_internal_call("UnrealEngine.APlayerController::GetInputMouseDelta",(const void*)GetInputMouseDelta);
			mono_add_internal_call("UnrealEngine.APlayerController::GetInputKeyTimeDown",(const void*)GetInputKeyTimeDown);
			mono_add_internal_call("UnrealEngine.APlayerController::GetMousePosition",(const void*)GetMousePosition);
			mono_add_internal_call("UnrealEngine.APlayerController::GetInputMotionState",(const void*)GetInputMotionState);
			mono_add_internal_call("UnrealEngine.APlayerController::GetInputTouchState",(const void*)GetInputTouchState);
			mono_add_internal_call("UnrealEngine.APlayerController::GetInputVectorKeyState",(const void*)GetInputVectorKeyState);
			mono_add_internal_call("UnrealEngine.APlayerController::GetInputAnalogKeyState",(const void*)GetInputAnalogKeyState);
			mono_add_internal_call("UnrealEngine.APlayerController::WasInputKeyJustReleased",(const void*)WasInputKeyJustReleased);
			mono_add_internal_call("UnrealEngine.APlayerController::WasInputKeyJustPressed",(const void*)WasInputKeyJustPressed);
			mono_add_internal_call("UnrealEngine.APlayerController::IsInputKeyDown",(const void*)IsInputKeyDown);
			mono_add_internal_call("UnrealEngine.APlayerController::AddRollInput",(const void*)AddRollInput);
			mono_add_internal_call("UnrealEngine.APlayerController::AddYawInput",(const void*)AddYawInput);
			mono_add_internal_call("UnrealEngine.APlayerController::AddPitchInput",(const void*)AddPitchInput);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerToggleAILogging",(const void*)ServerToggleAILogging);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientTeamMessage",(const void*)ClientTeamMessage);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerViewSelf",(const void*)ServerViewSelf);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerViewPrevPlayer",(const void*)ServerViewPrevPlayer);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerViewNextPlayer",(const void*)ServerViewNextPlayer);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerVerifyViewTarget",(const void*)ServerVerifyViewTarget);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerUpdateLevelVisibility",(const void*)ServerUpdateLevelVisibility);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerUpdateCamera",(const void*)ServerUpdateCamera);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerShortTimeout",(const void*)ServerShortTimeout);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerCheckClientPossessionReliable",(const void*)ServerCheckClientPossessionReliable);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerCheckClientPossession",(const void*)ServerCheckClientPossession);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerSetSpectatorLocation",(const void*)ServerSetSpectatorLocation);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerRestartPlayer",(const void*)ServerRestartPlayer);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerPause",(const void*)ServerPause);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerNotifyLoadedWorld",(const void*)ServerNotifyLoadedWorld);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerChangeName",(const void*)ServerChangeName);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerCamera",(const void*)ServerCamera);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerAcknowledgePossession",(const void*)ServerAcknowledgePossession);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientReceiveLocalizedMessage",(const void*)ClientReceiveLocalizedMessage);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientRetryClientRestart",(const void*)ClientRetryClientRestart);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientEndOnlineSession",(const void*)ClientEndOnlineSession);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientStartOnlineSession",(const void*)ClientStartOnlineSession);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientWasKicked",(const void*)ClientWasKicked);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientUpdateLevelStreamingStatus",(const void*)ClientUpdateLevelStreamingStatus);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientTravelInternal",(const void*)ClientTravelInternal);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientTravel",(const void*)ClientTravel);
			mono_add_internal_call("UnrealEngine.APlayerController::SetControllerLightColor",(const void*)SetControllerLightColor);
			mono_add_internal_call("UnrealEngine.APlayerController::SetHapticsByValue",(const void*)SetHapticsByValue);
			mono_add_internal_call("UnrealEngine.APlayerController::StopHapticEffect",(const void*)StopHapticEffect);
			mono_add_internal_call("UnrealEngine.APlayerController::PlayHapticEffect",(const void*)PlayHapticEffect);
			mono_add_internal_call("UnrealEngine.APlayerController::PlayDynamicForceFeedback",(const void*)PlayDynamicForceFeedback);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientStopForceFeedback",(const void*)ClientStopForceFeedback);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientPlayForceFeedback",(const void*)ClientPlayForceFeedback);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientStopCameraShake",(const void*)ClientStopCameraShake);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientStopCameraAnim",(const void*)ClientStopCameraAnim);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientClearCameraLensEffects",(const void*)ClientClearCameraLensEffects);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSpawnCameraLensEffect",(const void*)ClientSpawnCameraLensEffect);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSetViewTarget",(const void*)ClientSetViewTarget);
			mono_add_internal_call("UnrealEngine.APlayerController::GetHUD",(const void*)GetHUD);
			mono_add_internal_call("UnrealEngine.APlayerController::GetViewportSize",(const void*)GetViewportSize);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSetHUD",(const void*)ClientSetHUD);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSetForceMipLevelsToBeResident",(const void*)ClientSetForceMipLevelsToBeResident);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSetCinematicMode",(const void*)ClientSetCinematicMode);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSetCameraMode",(const void*)ClientSetCameraMode);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSetCameraFade",(const void*)ClientSetCameraFade);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSetBlockOnAsyncLoading",(const void*)ClientSetBlockOnAsyncLoading);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientRestart",(const void*)ClientRestart);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientReset",(const void*)ClientReset);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientPrestreamTextures",(const void*)ClientPrestreamTextures);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientPrepareMapChange",(const void*)ClientPrepareMapChange);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientPlaySoundAtLocation",(const void*)ClientPlaySoundAtLocation);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientPlaySound",(const void*)ClientPlaySound);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientPlayCameraShake",(const void*)ClientPlayCameraShake);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientPlayCameraAnim",(const void*)ClientPlayCameraAnim);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientMessage",(const void*)ClientMessage);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientIgnoreMoveInput",(const void*)ClientIgnoreMoveInput);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientIgnoreLookInput",(const void*)ClientIgnoreLookInput);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientGotoState",(const void*)ClientGotoState);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientGameEnded",(const void*)ClientGameEnded);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientForceGarbageCollection",(const void*)ClientForceGarbageCollection);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientFlushLevelStreaming",(const void*)ClientFlushLevelStreaming);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientCommitMapChange",(const void*)ClientCommitMapChange);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientCapBandwidth",(const void*)ClientCapBandwidth);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientCancelPendingMapChange",(const void*)ClientCancelPendingMapChange);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientAddTextureStreamingLoc",(const void*)ClientAddTextureStreamingLoc);
			mono_add_internal_call("UnrealEngine.APlayerController::SendToConsole",(const void*)SendToConsole);
			mono_add_internal_call("UnrealEngine.APlayerController::ConsoleKey",(const void*)ConsoleKey);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientUnmutePlayer",(const void*)ClientUnmutePlayer);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientMutePlayer",(const void*)ClientMutePlayer);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerUnmutePlayer",(const void*)ServerUnmutePlayer);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerMutePlayer",(const void*)ServerMutePlayer);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientVoiceHandshakeComplete",(const void*)ClientVoiceHandshakeComplete);
			mono_add_internal_call("UnrealEngine.APlayerController::ToggleSpeaking",(const void*)ToggleSpeaking);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientEnableNetworkVoice",(const void*)ClientEnableNetworkVoice);
			mono_add_internal_call("UnrealEngine.APlayerController::StartFire",(const void*)StartFire);
			mono_add_internal_call("UnrealEngine.APlayerController::ProjectWorldLocationToScreen",(const void*)ProjectWorldLocationToScreen);
			mono_add_internal_call("UnrealEngine.APlayerController::DeprojectScreenPositionToWorld",(const void*)DeprojectScreenPositionToWorld);
			mono_add_internal_call("UnrealEngine.APlayerController::DeprojectMousePositionToWorld",(const void*)DeprojectMousePositionToWorld);
			mono_add_internal_call("UnrealEngine.APlayerController::GetHitResultUnderFingerForObjects",(const void*)GetHitResultUnderFingerForObjects);
			mono_add_internal_call("UnrealEngine.APlayerController::GetHitResultUnderFingerByChannel",(const void*)GetHitResultUnderFingerByChannel);
			mono_add_internal_call("UnrealEngine.APlayerController::GetHitResultUnderCursorForObjects",(const void*)GetHitResultUnderCursorForObjects);
			mono_add_internal_call("UnrealEngine.APlayerController::GetHitResultUnderCursorByChannel",(const void*)GetHitResultUnderCursorByChannel);
			mono_add_internal_call("UnrealEngine.APlayerController::SwitchLevel",(const void*)SwitchLevel);
			mono_add_internal_call("UnrealEngine.APlayerController::SetName",(const void*)SetName);
			mono_add_internal_call("UnrealEngine.APlayerController::Pause",(const void*)Pause);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientRepObjRef",(const void*)ClientRepObjRef);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientReturnToMainMenu",(const void*)ClientReturnToMainMenu);
			mono_add_internal_call("UnrealEngine.APlayerController::LocalTravel",(const void*)LocalTravel);
			mono_add_internal_call("UnrealEngine.APlayerController::RestartLevel",(const void*)RestartLevel);
			mono_add_internal_call("UnrealEngine.APlayerController::FOV",(const void*)FOV);
			mono_add_internal_call("UnrealEngine.APlayerController::EnableCheats",(const void*)EnableCheats);
			mono_add_internal_call("UnrealEngine.APlayerController::ClientSetSpectatorWaiting",(const void*)ClientSetSpectatorWaiting);
			mono_add_internal_call("UnrealEngine.APlayerController::ServerSetSpectatorWaiting",(const void*)ServerSetSpectatorWaiting);
			mono_add_internal_call("UnrealEngine.APlayerController::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
