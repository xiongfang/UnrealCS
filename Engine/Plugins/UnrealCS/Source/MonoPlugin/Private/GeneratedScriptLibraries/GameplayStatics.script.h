#pragma once

namespace UnrealEngine
{
	class _UGameplayStatics
	{
		static int32 HasLaunchOption(UGameplayStatics* _this,MonoString* OptionToCheck)
		{
			FString OptionToCheck_temp=MonoStringToFString(OptionToCheck);
			bool ___ret = _this->HasLaunchOption(OptionToCheck_temp);
			return ___ret?1:0;
			
		}
		static int32 GetIntOption(UGameplayStatics* _this,MonoString* Options,MonoString* Key,int32 DefaultValue)
		{
			FString Options_temp=MonoStringToFString(Options);
			FString Key_temp=MonoStringToFString(Key);
			int32 ___ret = _this->GetIntOption(Options_temp,Key_temp,DefaultValue);
			return ___ret;
			
		}
		static int32 HasOption(UGameplayStatics* _this,MonoString* Options,MonoString* InKey)
		{
			FString Options_temp=MonoStringToFString(Options);
			FString InKey_temp=MonoStringToFString(InKey);
			bool ___ret = _this->HasOption(Options_temp,InKey_temp);
			return ___ret?1:0;
			
		}
		static MonoString* ParseOption(UGameplayStatics* _this,MonoString* Options,MonoString* Key)
		{
			FString Options_temp=MonoStringToFString(Options);
			FString Key_temp=MonoStringToFString(Key);
			FString ___ret = _this->ParseOption(Options_temp,Key_temp);
			return FStringToMonoString(___ret);
			
		}
		static void GetKeyValue(UGameplayStatics* _this,MonoString* Pair,MonoString** Key,MonoString** Value)
		{
			FString Pair_temp=MonoStringToFString(Pair);
			FString Key_temp;
			FString Value_temp;
			_this->GetKeyValue(Pair_temp,Key_temp,Value_temp);
			*Key=FStringToMonoString(Key_temp);
			*Value=FStringToMonoString(Value_temp);
			
		}
		static int32 ProjectWorldToScreen(UGameplayStatics* _this,APlayerController* Player,FVector* WorldPosition,FVector2D* ScreenPosition,int32 bPlayerViewportRelative)
		{
			bool ___ret = _this->ProjectWorldToScreen(Player,*WorldPosition,*ScreenPosition,bPlayerViewportRelative>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 DeprojectScreenToWorld(UGameplayStatics* _this,APlayerController* Player,FVector2D* ScreenPosition,FVector* WorldPosition,FVector* WorldDirection)
		{
			bool ___ret = _this->DeprojectScreenToWorld(Player,*ScreenPosition,*WorldPosition,*WorldDirection);
			return ___ret?1:0;
			
		}
		static int32 GrassOverlappingSphereCount(UGameplayStatics* _this,UObject* WorldContextObject,UStaticMesh* StaticMesh,FVector* CenterPosition,float Radius)
		{
			int32 ___ret = _this->GrassOverlappingSphereCount(WorldContextObject,StaticMesh,*CenterPosition,Radius);
			return ___ret;
			
		}
		static FVector RebaseZeroOriginOntoLocal(UGameplayStatics* _this,UObject* WorldContextObject,FVector* WorldLocation)
		{
			FVector ___ret = _this->RebaseZeroOriginOntoLocal(WorldContextObject,*WorldLocation);
			return ___ret;
			
		}
		static FVector RebaseLocalOriginOntoZero(UGameplayStatics* _this,UObject* WorldContextObject,FVector* WorldLocation)
		{
			FVector ___ret = _this->RebaseLocalOriginOntoZero(WorldContextObject,*WorldLocation);
			return ___ret;
			
		}
		static void SetWorldOriginLocation(UGameplayStatics* _this,UObject* WorldContextObject,FIntVector* NewLocation)
		{
			_this->SetWorldOriginLocation(WorldContextObject,*NewLocation);
			
		}
		static FIntVector GetWorldOriginLocation(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			FIntVector ___ret = _this->GetWorldOriginLocation(WorldContextObject);
			return ___ret;
			
		}
		static int32 SuggestProjectileVelocity_CustomArc(UGameplayStatics* _this,UObject* WorldContextObject,FVector* OutLaunchVelocity,FVector* StartPos,FVector* EndPos,float OverrideGravityZ,float ArcParam)
		{
			bool ___ret = _this->SuggestProjectileVelocity_CustomArc(WorldContextObject,*OutLaunchVelocity,*StartPos,*EndPos,OverrideGravityZ,ArcParam);
			return ___ret?1:0;
			
		}
		static int32 Blueprint_PredictProjectilePath_Advanced(UGameplayStatics* _this,UObject* WorldContextObject,FPredictProjectilePathParams* PredictParams,FPredictProjectilePathResult* PredictResult)
		{
			bool ___ret = _this->Blueprint_PredictProjectilePath_Advanced(WorldContextObject,*PredictParams,*PredictResult);
			return ___ret?1:0;
			
		}
		static int32 Blueprint_PredictProjectilePath_ByTraceChannel(UGameplayStatics* _this,UObject* WorldContextObject,FHitResult* OutHit,MonoArray** OutPathPositions,FVector* OutLastTraceDestination,FVector* StartPos,FVector* LaunchVelocity,int32 bTracePath,float ProjectileRadius,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,float DrawDebugTime,float SimFrequency,float MaxSimTime,float OverrideGravityZ)
		{
			TArray<FVector> OutPathPositions_temp;
			bool ___ret = _this->Blueprint_PredictProjectilePath_ByTraceChannel(WorldContextObject,*OutHit,OutPathPositions_temp,*OutLastTraceDestination,*StartPos,*LaunchVelocity,bTracePath>0?true:false,ProjectileRadius,(TEnumAsByte<ECollisionChannel>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,DrawDebugTime,SimFrequency,MaxSimTime,OverrideGravityZ);
			return ___ret?1:0;
			*OutPathPositions=TArrayToMonoArray(OutPathPositions_temp,"UnrealEngine.FVector,UnrealEngine");
			
		}
		static int32 Blueprint_PredictProjectilePath_ByObjectType(UGameplayStatics* _this,UObject* WorldContextObject,FHitResult* OutHit,MonoArray** OutPathPositions,FVector* OutLastTraceDestination,FVector* StartPos,FVector* LaunchVelocity,int32 bTracePath,float ProjectileRadius,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,float DrawDebugTime,float SimFrequency,float MaxSimTime,float OverrideGravityZ)
		{
			TArray<FVector> OutPathPositions_temp;
			bool ___ret = _this->Blueprint_PredictProjectilePath_ByObjectType(WorldContextObject,*OutHit,OutPathPositions_temp,*OutLastTraceDestination,*StartPos,*LaunchVelocity,bTracePath>0?true:false,ProjectileRadius,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,DrawDebugTime,SimFrequency,MaxSimTime,OverrideGravityZ);
			return ___ret?1:0;
			*OutPathPositions=TArrayToMonoArray(OutPathPositions_temp,"UnrealEngine.FVector,UnrealEngine");
			
		}
		static int32 BlueprintSuggestProjectileVelocity(UGameplayStatics* _this,UObject* WorldContextObject,FVector* TossVelocity,FVector* StartLocation,FVector* EndLocation,float LaunchSpeed,float OverrideGravityZ,int32 TraceOption,float CollisionRadius,int32 bFavorHighArc,int32 bDrawDebug)
		{
			bool ___ret = _this->BlueprintSuggestProjectileVelocity(WorldContextObject,*TossVelocity,*StartLocation,*EndLocation,LaunchSpeed,OverrideGravityZ,(TEnumAsByte<ESuggestProjVelocityTraceOption::Type>)TraceOption,CollisionRadius,bFavorHighArc>0?true:false,bDrawDebug>0?true:false);
			return ___ret?1:0;
			
		}
		static MonoString* GetPlatformName(UGameplayStatics* _this)
		{
			FString ___ret = _this->GetPlatformName();
			return FStringToMonoString(___ret);
			
		}
		static void EnableLiveStreaming(UGameplayStatics* _this,int32 Enable)
		{
			_this->EnableLiveStreaming(Enable>0?true:false);
			
		}
		static void GetAccurateRealTime(UGameplayStatics* _this,UObject* WorldContextObject,int32* Seconds,float* PartialSeconds)
		{
			_this->GetAccurateRealTime(WorldContextObject,*Seconds,*PartialSeconds);
			
		}
		static float GetAudioTimeSeconds(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			float ___ret = _this->GetAudioTimeSeconds(WorldContextObject);
			return ___ret;
			
		}
		static float GetRealTimeSeconds(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			float ___ret = _this->GetRealTimeSeconds(WorldContextObject);
			return ___ret;
			
		}
		static float GetUnpausedTimeSeconds(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			float ___ret = _this->GetUnpausedTimeSeconds(WorldContextObject);
			return ___ret;
			
		}
		static float GetTimeSeconds(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			float ___ret = _this->GetTimeSeconds(WorldContextObject);
			return ___ret;
			
		}
		static float GetWorldDeltaSeconds(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			float ___ret = _this->GetWorldDeltaSeconds(WorldContextObject);
			return ___ret;
			
		}
		static int32 DeleteGameInSlot(UGameplayStatics* _this,MonoString* SlotName,int32 UserIndex)
		{
			FString SlotName_temp=MonoStringToFString(SlotName);
			bool ___ret = _this->DeleteGameInSlot(SlotName_temp,UserIndex);
			return ___ret?1:0;
			
		}
		static USaveGame* LoadGameFromSlot(UGameplayStatics* _this,MonoString* SlotName,int32 UserIndex)
		{
			FString SlotName_temp=MonoStringToFString(SlotName);
			USaveGame* ___ret = _this->LoadGameFromSlot(SlotName_temp,UserIndex);
			return ___ret;
			
		}
		static int32 DoesSaveGameExist(UGameplayStatics* _this,MonoString* SlotName,int32 UserIndex)
		{
			FString SlotName_temp=MonoStringToFString(SlotName);
			bool ___ret = _this->DoesSaveGameExist(SlotName_temp,UserIndex);
			return ___ret?1:0;
			
		}
		static int32 SaveGameToSlot(UGameplayStatics* _this,USaveGame* SaveGameObject,MonoString* SlotName,int32 UserIndex)
		{
			FString SlotName_temp=MonoStringToFString(SlotName);
			bool ___ret = _this->SaveGameToSlot(SaveGameObject,SlotName_temp,UserIndex);
			return ___ret?1:0;
			
		}
		static USaveGame* CreateSaveGameObject(UGameplayStatics* _this,TSubclassOf<USaveGame>  SaveGameClass)
		{
			USaveGame* ___ret = _this->CreateSaveGameObject(SaveGameClass);
			return ___ret;
			
		}
		static int32 FindCollisionUV(UGameplayStatics* _this,FHitResult* Hit,int32 UVChannel,FVector2D* UV)
		{
			bool ___ret = _this->FindCollisionUV(*Hit,UVChannel,*UV);
			return ___ret?1:0;
			
		}
		static int32 GetSurfaceType(UGameplayStatics* _this,FHitResult* Hit)
		{
			TEnumAsByte<EPhysicalSurface> ___ret = _this->GetSurfaceType(*Hit);
			return (int32)___ret.GetValue();
			
		}
		static FHitResult MakeHitResult(UGameplayStatics* _this,int32 bBlockingHit,int32 bInitialOverlap,float Time,FVector* Location,FVector* ImpactPoint,FVector* Normal,FVector* ImpactNormal,UPhysicalMaterial* PhysMat,AActor* HitActor,UPrimitiveComponent* HitComponent,MonoString* HitBoneName,int32 HitItem,int32 FaceIndex,FVector* TraceStart,FVector* TraceEnd)
		{
			FName HitBoneName_temp=MonoStringToFName(HitBoneName);
			FHitResult ___ret = _this->MakeHitResult(bBlockingHit>0?true:false,bInitialOverlap>0?true:false,Time,*Location,*ImpactPoint,*Normal,*ImpactNormal,PhysMat,HitActor,HitComponent,HitBoneName_temp,HitItem,FaceIndex,*TraceStart,*TraceEnd);
			return ___ret;
			
		}
		static void BreakHitResult(UGameplayStatics* _this,FHitResult* Hit,int32* bBlockingHit,int32* bInitialOverlap,float* Time,FVector* Location,FVector* ImpactPoint,FVector* Normal,FVector* ImpactNormal,UPhysicalMaterial** PhysMat,AActor** HitActor,UPrimitiveComponent** HitComponent,MonoString** HitBoneName,int32* HitItem,int32* FaceIndex,FVector* TraceStart,FVector* TraceEnd)
		{
			bool bBlockingHit_temp;
			bool bInitialOverlap_temp;
			FName HitBoneName_temp;
			_this->BreakHitResult(*Hit,bBlockingHit_temp,bInitialOverlap_temp,*Time,*Location,*ImpactPoint,*Normal,*ImpactNormal,*PhysMat,*HitActor,*HitComponent,HitBoneName_temp,*HitItem,*FaceIndex,*TraceStart,*TraceEnd);
			*bBlockingHit=bBlockingHit_temp!=0;
			*bInitialOverlap=bInitialOverlap_temp!=0;
			*HitBoneName=FNameToMonoString(HitBoneName_temp);
			
		}
		static UDecalComponent* SpawnDecalAttached(UGameplayStatics* _this,UMaterialInterface* DecalMaterial,FVector* DecalSize,USceneComponent* AttachToComponent,MonoString* AttachPointName,FVector* Location,FRotator* Rotation,int32 LocationType,float LifeSpan)
		{
			FName AttachPointName_temp=MonoStringToFName(AttachPointName);
			UDecalComponent* ___ret = _this->SpawnDecalAttached(DecalMaterial,*DecalSize,AttachToComponent,AttachPointName_temp,*Location,*Rotation,(TEnumAsByte<EAttachLocation::Type>)LocationType,LifeSpan);
			return ___ret;
			
		}
		static UDecalComponent* SpawnDecalAtLocation(UGameplayStatics* _this,UObject* WorldContextObject,UMaterialInterface* DecalMaterial,FVector* DecalSize,FVector* Location,FRotator* Rotation,float LifeSpan)
		{
			UDecalComponent* ___ret = _this->SpawnDecalAtLocation(WorldContextObject,DecalMaterial,*DecalSize,*Location,*Rotation,LifeSpan);
			return ___ret;
			
		}
		static UReverbEffect* GetCurrentReverbEffect(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			UReverbEffect* ___ret = _this->GetCurrentReverbEffect(WorldContextObject);
			return ___ret;
			
		}
		static void DeactivateReverbEffect(UGameplayStatics* _this,UObject* WorldContextObject,MonoString* TagName)
		{
			FName TagName_temp=MonoStringToFName(TagName);
			_this->DeactivateReverbEffect(WorldContextObject,TagName_temp);
			
		}
		static void ActivateReverbEffect(UGameplayStatics* _this,UObject* WorldContextObject,UReverbEffect* ReverbEffect,MonoString* TagName,float Priority,float Volume,float FadeTime)
		{
			FName TagName_temp=MonoStringToFName(TagName);
			_this->ActivateReverbEffect(WorldContextObject,ReverbEffect,TagName_temp,Priority,Volume,FadeTime);
			
		}
		static void ClearSoundMixModifiers(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			_this->ClearSoundMixModifiers(WorldContextObject);
			
		}
		static void PopSoundMixModifier(UGameplayStatics* _this,UObject* WorldContextObject,USoundMix* InSoundMixModifier)
		{
			_this->PopSoundMixModifier(WorldContextObject,InSoundMixModifier);
			
		}
		static void PushSoundMixModifier(UGameplayStatics* _this,UObject* WorldContextObject,USoundMix* InSoundMixModifier)
		{
			_this->PushSoundMixModifier(WorldContextObject,InSoundMixModifier);
			
		}
		static void ClearSoundMixClassOverride(UGameplayStatics* _this,UObject* WorldContextObject,USoundMix* InSoundMixModifier,USoundClass* InSoundClass,float FadeOutTime)
		{
			_this->ClearSoundMixClassOverride(WorldContextObject,InSoundMixModifier,InSoundClass,FadeOutTime);
			
		}
		static void SetSoundMixClassOverride(UGameplayStatics* _this,UObject* WorldContextObject,USoundMix* InSoundMixModifier,USoundClass* InSoundClass,float Volume,float Pitch,float FadeInTime,int32 bApplyToChildren)
		{
			_this->SetSoundMixClassOverride(WorldContextObject,InSoundMixModifier,InSoundClass,Volume,Pitch,FadeInTime,bApplyToChildren>0?true:false);
			
		}
		static void SetBaseSoundMix(UGameplayStatics* _this,UObject* WorldContextObject,USoundMix* InSoundMix)
		{
			_this->SetBaseSoundMix(WorldContextObject,InSoundMix);
			
		}
		static int32 AreSubtitlesEnabled(UGameplayStatics* _this)
		{
			bool ___ret = _this->AreSubtitlesEnabled();
			return ___ret?1:0;
			
		}
		static void SetSubtitlesEnabled(UGameplayStatics* _this,int32 bEnabled)
		{
			_this->SetSubtitlesEnabled(bEnabled>0?true:false);
			
		}
		static UForceFeedbackComponent* SpawnForceFeedbackAttached(UGameplayStatics* _this,UForceFeedbackEffect* ForceFeedbackEffect,USceneComponent* AttachToComponent,MonoString* AttachPointName,FVector* Location,FRotator* Rotation,int32 LocationType,int32 bStopWhenAttachedToDestroyed,int32 bLooping,float IntensityMultiplier,float StartTime,UForceFeedbackAttenuation* AttenuationSettings)
		{
			FName AttachPointName_temp=MonoStringToFName(AttachPointName);
			UForceFeedbackComponent* ___ret = _this->SpawnForceFeedbackAttached(ForceFeedbackEffect,AttachToComponent,AttachPointName_temp,*Location,*Rotation,(TEnumAsByte<EAttachLocation::Type>)LocationType,bStopWhenAttachedToDestroyed>0?true:false,bLooping>0?true:false,IntensityMultiplier,StartTime,AttenuationSettings);
			return ___ret;
			
		}
		static UForceFeedbackComponent* SpawnForceFeedbackAtLocation(UGameplayStatics* _this,UObject* WorldContextObject,UForceFeedbackEffect* ForceFeedbackEffect,FVector* Location,FRotator* Rotation,int32 bLooping,float IntensityMultiplier,float StartTime,UForceFeedbackAttenuation* AttenuationSettings)
		{
			UForceFeedbackComponent* ___ret = _this->SpawnForceFeedbackAtLocation(WorldContextObject,ForceFeedbackEffect,*Location,*Rotation,bLooping>0?true:false,IntensityMultiplier,StartTime,AttenuationSettings);
			return ___ret;
			
		}
		static UAudioComponent* SpawnDialogueAttached(UGameplayStatics* _this,UDialogueWave* Dialogue,FDialogueContext* Context,USceneComponent* AttachToComponent,MonoString* AttachPointName,FVector* Location,FRotator* Rotation,int32 LocationType,int32 bStopWhenAttachedToDestroyed,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundAttenuation* AttenuationSettings)
		{
			FName AttachPointName_temp=MonoStringToFName(AttachPointName);
			UAudioComponent* ___ret = _this->SpawnDialogueAttached(Dialogue,*Context,AttachToComponent,AttachPointName_temp,*Location,*Rotation,(TEnumAsByte<EAttachLocation::Type>)LocationType,bStopWhenAttachedToDestroyed>0?true:false,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings);
			return ___ret;
			
		}
		static UAudioComponent* SpawnDialogueAtLocation(UGameplayStatics* _this,UObject* WorldContextObject,UDialogueWave* Dialogue,FDialogueContext* Context,FVector* Location,FRotator* Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundAttenuation* AttenuationSettings)
		{
			UAudioComponent* ___ret = _this->SpawnDialogueAtLocation(WorldContextObject,Dialogue,*Context,*Location,*Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings);
			return ___ret;
			
		}
		static void PlayDialogueAtLocation(UGameplayStatics* _this,UObject* WorldContextObject,UDialogueWave* Dialogue,FDialogueContext* Context,FVector* Location,FRotator* Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundAttenuation* AttenuationSettings)
		{
			_this->PlayDialogueAtLocation(WorldContextObject,Dialogue,*Context,*Location,*Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings);
			
		}
		static UAudioComponent* SpawnDialogue2D(UGameplayStatics* _this,UObject* WorldContextObject,UDialogueWave* Dialogue,FDialogueContext* Context,float VolumeMultiplier,float PitchMultiplier,float StartTime)
		{
			UAudioComponent* ___ret = _this->SpawnDialogue2D(WorldContextObject,Dialogue,*Context,VolumeMultiplier,PitchMultiplier,StartTime);
			return ___ret;
			
		}
		static void PlayDialogue2D(UGameplayStatics* _this,UObject* WorldContextObject,UDialogueWave* Dialogue,FDialogueContext* Context,float VolumeMultiplier,float PitchMultiplier,float StartTime)
		{
			_this->PlayDialogue2D(WorldContextObject,Dialogue,*Context,VolumeMultiplier,PitchMultiplier,StartTime);
			
		}
		static UAudioComponent* SpawnSoundAttached(UGameplayStatics* _this,USoundBase* Sound,USceneComponent* AttachToComponent,MonoString* AttachPointName,FVector* Location,FRotator* Rotation,int32 LocationType,int32 bStopWhenAttachedToDestroyed,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundAttenuation* AttenuationSettings,USoundConcurrency* ConcurrencySettings)
		{
			FName AttachPointName_temp=MonoStringToFName(AttachPointName);
			UAudioComponent* ___ret = _this->SpawnSoundAttached(Sound,AttachToComponent,AttachPointName_temp,*Location,*Rotation,(TEnumAsByte<EAttachLocation::Type>)LocationType,bStopWhenAttachedToDestroyed>0?true:false,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings);
			return ___ret;
			
		}
		static UAudioComponent* SpawnSoundAtLocation(UGameplayStatics* _this,UObject* WorldContextObject,USoundBase* Sound,FVector* Location,FRotator* Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundAttenuation* AttenuationSettings,USoundConcurrency* ConcurrencySettings)
		{
			UAudioComponent* ___ret = _this->SpawnSoundAtLocation(WorldContextObject,Sound,*Location,*Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings);
			return ___ret;
			
		}
		static void PlaySoundAtLocation(UGameplayStatics* _this,UObject* WorldContextObject,USoundBase* Sound,FVector* Location,FRotator* Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundAttenuation* AttenuationSettings,USoundConcurrency* ConcurrencySettings)
		{
			_this->PlaySoundAtLocation(WorldContextObject,Sound,*Location,*Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings);
			
		}
		static UAudioComponent* CreateSound2D(UGameplayStatics* _this,UObject* WorldContextObject,USoundBase* Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundConcurrency* ConcurrencySettings,int32 bPersistAcrossLevelTransition)
		{
			UAudioComponent* ___ret = _this->CreateSound2D(WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings,bPersistAcrossLevelTransition>0?true:false);
			return ___ret;
			
		}
		static UAudioComponent* SpawnSound2D(UGameplayStatics* _this,UObject* WorldContextObject,USoundBase* Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundConcurrency* ConcurrencySettings,int32 bPersistAcrossLevelTransition)
		{
			UAudioComponent* ___ret = _this->SpawnSound2D(WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings,bPersistAcrossLevelTransition>0?true:false);
			return ___ret;
			
		}
		static void PlaySound2D(UGameplayStatics* _this,UObject* WorldContextObject,USoundBase* Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,USoundConcurrency* ConcurrencySettings)
		{
			_this->PlaySound2D(WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings);
			
		}
		static void SetGlobalListenerFocusParameters(UGameplayStatics* _this,UObject* WorldContextObject,float FocusAzimuthScale,float NonFocusAzimuthScale,float FocusDistanceScale,float NonFocusDistanceScale,float FocusVolumeScale,float NonFocusVolumeScale,float FocusPriorityScale,float NonFocusPriorityScale)
		{
			_this->SetGlobalListenerFocusParameters(WorldContextObject,FocusAzimuthScale,NonFocusAzimuthScale,FocusDistanceScale,NonFocusDistanceScale,FocusVolumeScale,NonFocusVolumeScale,FocusPriorityScale,NonFocusPriorityScale);
			
		}
		static void SetGlobalPitchModulation(UGameplayStatics* _this,UObject* WorldContextObject,float PitchModulation,float TimeSec)
		{
			_this->SetGlobalPitchModulation(WorldContextObject,PitchModulation,TimeSec);
			
		}
		static int32 AreAnyListenersWithinRange(UGameplayStatics* _this,UObject* WorldContextObject,FVector* Location,float MaximumRange)
		{
			bool ___ret = _this->AreAnyListenersWithinRange(WorldContextObject,*Location,MaximumRange);
			return ___ret?1:0;
			
		}
		static UParticleSystemComponent* SpawnEmitterAttached(UGameplayStatics* _this,UParticleSystem* EmitterTemplate,USceneComponent* AttachToComponent,MonoString* AttachPointName,FVector* Location,FRotator* Rotation,int32 LocationType,int32 bAutoDestroy)
		{
			FName AttachPointName_temp=MonoStringToFName(AttachPointName);
			UParticleSystemComponent* ___ret = _this->SpawnEmitterAttached(EmitterTemplate,AttachToComponent,AttachPointName_temp,*Location,*Rotation,(TEnumAsByte<EAttachLocation::Type>)LocationType,bAutoDestroy>0?true:false);
			return ___ret;
			
		}
		static UParticleSystemComponent* SpawnEmitterAtLocation(UGameplayStatics* _this,UObject* WorldContextObject,UParticleSystem* EmitterTemplate,FVector* Location,FRotator* Rotation,int32 bAutoDestroy)
		{
			UParticleSystemComponent* ___ret = _this->SpawnEmitterAtLocation(WorldContextObject,EmitterTemplate,*Location,*Rotation,bAutoDestroy>0?true:false);
			return ___ret;
			
		}
		static void PlayWorldCameraShake(UGameplayStatics* _this,UObject* WorldContextObject,TSubclassOf<UCameraShake>  Shake,FVector* Epicenter,float InnerRadius,float OuterRadius,float Falloff,int32 bOrientShakeTowardsEpicenter)
		{
			_this->PlayWorldCameraShake(WorldContextObject,Shake,*Epicenter,InnerRadius,OuterRadius,Falloff,bOrientShakeTowardsEpicenter>0?true:false);
			
		}
		static float ApplyDamage(UGameplayStatics* _this,AActor* DamagedActor,float BaseDamage,AController* EventInstigator,AActor* DamageCauser,TSubclassOf<UDamageType>  DamageTypeClass)
		{
			float ___ret = _this->ApplyDamage(DamagedActor,BaseDamage,EventInstigator,DamageCauser,DamageTypeClass);
			return ___ret;
			
		}
		static float ApplyPointDamage(UGameplayStatics* _this,AActor* DamagedActor,float BaseDamage,FVector* HitFromDirection,FHitResult* HitInfo,AController* EventInstigator,AActor* DamageCauser,TSubclassOf<UDamageType>  DamageTypeClass)
		{
			float ___ret = _this->ApplyPointDamage(DamagedActor,BaseDamage,*HitFromDirection,*HitInfo,EventInstigator,DamageCauser,DamageTypeClass);
			return ___ret;
			
		}
		static int32 ApplyRadialDamageWithFalloff(UGameplayStatics* _this,UObject* WorldContextObject,float BaseDamage,float MinimumDamage,FVector* Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,TSubclassOf<UDamageType>  DamageTypeClass,MonoArray* IgnoreActors,AActor* DamageCauser,AController* InstigatedByController,int32 DamagePreventionChannel)
		{
			bool ___ret = _this->ApplyRadialDamageWithFalloff(WorldContextObject,BaseDamage,MinimumDamage,*Origin,DamageInnerRadius,DamageOuterRadius,DamageFalloff,DamageTypeClass,MonoArrayToTArray<AActor*>(IgnoreActors),DamageCauser,InstigatedByController,(TEnumAsByte<ECollisionChannel>)DamagePreventionChannel);
			return ___ret?1:0;
			
		}
		static int32 ApplyRadialDamage(UGameplayStatics* _this,UObject* WorldContextObject,float BaseDamage,FVector* Origin,float DamageRadius,TSubclassOf<UDamageType>  DamageTypeClass,MonoArray* IgnoreActors,AActor* DamageCauser,AController* InstigatedByController,int32 bDoFullDamage,int32 DamagePreventionChannel)
		{
			bool ___ret = _this->ApplyRadialDamage(WorldContextObject,BaseDamage,*Origin,DamageRadius,DamageTypeClass,MonoArrayToTArray<AActor*>(IgnoreActors),DamageCauser,InstigatedByController,bDoFullDamage>0?true:false,(TEnumAsByte<ECollisionChannel>)DamagePreventionChannel);
			return ___ret?1:0;
			
		}
		static int32 IsGamePaused(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			bool ___ret = _this->IsGamePaused(WorldContextObject);
			return ___ret?1:0;
			
		}
		static int32 SetGamePaused(UGameplayStatics* _this,UObject* WorldContextObject,int32 bPaused)
		{
			bool ___ret = _this->SetGamePaused(WorldContextObject,bPaused>0?true:false);
			return ___ret?1:0;
			
		}
		static void SetGlobalTimeDilation(UGameplayStatics* _this,UObject* WorldContextObject,float TimeDilation)
		{
			_this->SetGlobalTimeDilation(WorldContextObject,TimeDilation);
			
		}
		static float GetGlobalTimeDilation(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			float ___ret = _this->GetGlobalTimeDilation(WorldContextObject);
			return ___ret;
			
		}
		static UClass* GetObjectClass(UGameplayStatics* _this,UObject* Object)
		{
			UClass* ___ret = _this->GetObjectClass(Object);
			return ___ret;
			
		}
		static AGameStateBase* GetGameState(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			AGameStateBase* ___ret = _this->GetGameState(WorldContextObject);
			return ___ret;
			
		}
		static AGameModeBase* GetGameMode(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			AGameModeBase* ___ret = _this->GetGameMode(WorldContextObject);
			return ___ret;
			
		}
		static MonoString* GetCurrentLevelName(UGameplayStatics* _this,UObject* WorldContextObject,int32 bRemovePrefixString)
		{
			FString ___ret = _this->GetCurrentLevelName(WorldContextObject,bRemovePrefixString>0?true:false);
			return FStringToMonoString(___ret);
			
		}
		static void OpenLevel(UGameplayStatics* _this,UObject* WorldContextObject,MonoString* LevelName,int32 bAbsolute,MonoString* Options)
		{
			FName LevelName_temp=MonoStringToFName(LevelName);
			FString Options_temp=MonoStringToFString(Options);
			_this->OpenLevel(WorldContextObject,LevelName_temp,bAbsolute>0?true:false,Options_temp);
			
		}
		static void CancelAsyncLoading(UGameplayStatics* _this)
		{
			_this->CancelAsyncLoading();
			
		}
		static void FlushLevelStreaming(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			_this->FlushLevelStreaming(WorldContextObject);
			
		}
		static ULevelStreaming* GetStreamingLevel(UGameplayStatics* _this,UObject* WorldContextObject,MonoString* PackageName)
		{
			FName PackageName_temp=MonoStringToFName(PackageName);
			ULevelStreaming* ___ret = _this->GetStreamingLevel(WorldContextObject,PackageName_temp);
			return ___ret;
			
		}
		static void UnloadStreamLevel(UGameplayStatics* _this,UObject* WorldContextObject,MonoString* LevelName,FLatentActionInfo* LatentInfo)
		{
			FName LevelName_temp=MonoStringToFName(LevelName);
			_this->UnloadStreamLevel(WorldContextObject,LevelName_temp,*LatentInfo);
			
		}
		static void LoadStreamLevel(UGameplayStatics* _this,UObject* WorldContextObject,MonoString* LevelName,int32 bMakeVisibleAfterLoad,int32 bShouldBlockOnLoad,FLatentActionInfo* LatentInfo)
		{
			FName LevelName_temp=MonoStringToFName(LevelName);
			_this->LoadStreamLevel(WorldContextObject,LevelName_temp,bMakeVisibleAfterLoad>0?true:false,bShouldBlockOnLoad>0?true:false,*LatentInfo);
			
		}
		static void SetPlayerControllerID(UGameplayStatics* _this,APlayerController* Player,int32 ControllerId)
		{
			_this->SetPlayerControllerID(Player,ControllerId);
			
		}
		static int32 GetPlayerControllerID(UGameplayStatics* _this,APlayerController* Player)
		{
			int32 ___ret = _this->GetPlayerControllerID(Player);
			return ___ret;
			
		}
		static void RemovePlayer(UGameplayStatics* _this,APlayerController* Player,int32 bDestroyPawn)
		{
			_this->RemovePlayer(Player,bDestroyPawn>0?true:false);
			
		}
		static APlayerController* CreatePlayer(UGameplayStatics* _this,UObject* WorldContextObject,int32 ControllerId,int32 bSpawnPawn)
		{
			APlayerController* ___ret = _this->CreatePlayer(WorldContextObject,ControllerId,bSpawnPawn>0?true:false);
			return ___ret;
			
		}
		static APlayerCameraManager* GetPlayerCameraManager(UGameplayStatics* _this,UObject* WorldContextObject,int32 PlayerIndex)
		{
			APlayerCameraManager* ___ret = _this->GetPlayerCameraManager(WorldContextObject,PlayerIndex);
			return ___ret;
			
		}
		static ACharacter* GetPlayerCharacter(UGameplayStatics* _this,UObject* WorldContextObject,int32 PlayerIndex)
		{
			ACharacter* ___ret = _this->GetPlayerCharacter(WorldContextObject,PlayerIndex);
			return ___ret;
			
		}
		static APawn* GetPlayerPawn(UGameplayStatics* _this,UObject* WorldContextObject,int32 PlayerIndex)
		{
			APawn* ___ret = _this->GetPlayerPawn(WorldContextObject,PlayerIndex);
			return ___ret;
			
		}
		static APlayerController* GetPlayerController(UGameplayStatics* _this,UObject* WorldContextObject,int32 PlayerIndex)
		{
			APlayerController* ___ret = _this->GetPlayerController(WorldContextObject,PlayerIndex);
			return ___ret;
			
		}
		static UGameInstance* GetGameInstance(UGameplayStatics* _this,UObject* WorldContextObject)
		{
			UGameInstance* ___ret = _this->GetGameInstance(WorldContextObject);
			return ___ret;
			
		}
		static void GetAllActorsWithTag(UGameplayStatics* _this,UObject* WorldContextObject,MonoString* Tag,MonoArray** OutActors)
		{
			FName Tag_temp=MonoStringToFName(Tag);
			TArray<AActor*> OutActors_temp;
			_this->GetAllActorsWithTag(WorldContextObject,Tag_temp,OutActors_temp);
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static void GetAllActorsWithInterface(UGameplayStatics* _this,UObject* WorldContextObject,TSubclassOf<UInterface>  Interface,MonoArray** OutActors)
		{
			TArray<AActor*> OutActors_temp;
			_this->GetAllActorsWithInterface(WorldContextObject,Interface,OutActors_temp);
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static void GetAllActorsOfClass(UGameplayStatics* _this,UObject* WorldContextObject,TSubclassOf<AActor>  ActorClass,MonoArray** OutActors)
		{
			TArray<AActor*> OutActors_temp;
			_this->GetAllActorsOfClass(WorldContextObject,ActorClass,OutActors_temp);
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static void GetActorArrayBounds(UGameplayStatics* _this,MonoArray* Actors,int32 bOnlyCollidingComponents,FVector* Center,FVector* BoxExtent)
		{
			_this->GetActorArrayBounds(MonoArrayToTArray<AActor*>(Actors),bOnlyCollidingComponents>0?true:false,*Center,*BoxExtent);
			
		}
		static FVector GetActorArrayAverageLocation(UGameplayStatics* _this,MonoArray* Actors)
		{
			FVector ___ret = _this->GetActorArrayAverageLocation(MonoArrayToTArray<AActor*>(Actors));
			return ___ret;
			
		}
		static AActor* FinishSpawningActor(UGameplayStatics* _this,AActor* Actor,FTransform* SpawnTransform)
		{
			AActor* ___ret = _this->FinishSpawningActor(Actor,*SpawnTransform);
			return ___ret;
			
		}
		static AActor* BeginSpawningActorFromClass(UGameplayStatics* _this,UObject* WorldContextObject,TSubclassOf<AActor>  ActorClass,FTransform* SpawnTransform,int32 bNoCollisionFail,AActor* Owner)
		{
			AActor* ___ret = _this->BeginSpawningActorFromClass(WorldContextObject,ActorClass,*SpawnTransform,bNoCollisionFail>0?true:false,Owner);
			return ___ret;
			
		}
		static UObject* SpawnObject(UGameplayStatics* _this,TSubclassOf<UObject>  ObjectClass,UObject* Outer)
		{
			UObject* ___ret = _this->SpawnObject(ObjectClass,Outer);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UGameplayStatics::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UGameplayStatics::HasLaunchOption",(const void*)HasLaunchOption);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetIntOption",(const void*)GetIntOption);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::HasOption",(const void*)HasOption);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ParseOption",(const void*)ParseOption);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetKeyValue",(const void*)GetKeyValue);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ProjectWorldToScreen",(const void*)ProjectWorldToScreen);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::DeprojectScreenToWorld",(const void*)DeprojectScreenToWorld);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GrassOverlappingSphereCount",(const void*)GrassOverlappingSphereCount);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::RebaseZeroOriginOntoLocal",(const void*)RebaseZeroOriginOntoLocal);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::RebaseLocalOriginOntoZero",(const void*)RebaseLocalOriginOntoZero);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetWorldOriginLocation",(const void*)SetWorldOriginLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetWorldOriginLocation",(const void*)GetWorldOriginLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SuggestProjectileVelocity_CustomArc",(const void*)SuggestProjectileVelocity_CustomArc);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::Blueprint_PredictProjectilePath_Advanced",(const void*)Blueprint_PredictProjectilePath_Advanced);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::Blueprint_PredictProjectilePath_ByTraceChannel",(const void*)Blueprint_PredictProjectilePath_ByTraceChannel);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::Blueprint_PredictProjectilePath_ByObjectType",(const void*)Blueprint_PredictProjectilePath_ByObjectType);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::BlueprintSuggestProjectileVelocity",(const void*)BlueprintSuggestProjectileVelocity);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetPlatformName",(const void*)GetPlatformName);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::EnableLiveStreaming",(const void*)EnableLiveStreaming);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetAccurateRealTime",(const void*)GetAccurateRealTime);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetAudioTimeSeconds",(const void*)GetAudioTimeSeconds);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetRealTimeSeconds",(const void*)GetRealTimeSeconds);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetUnpausedTimeSeconds",(const void*)GetUnpausedTimeSeconds);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetTimeSeconds",(const void*)GetTimeSeconds);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetWorldDeltaSeconds",(const void*)GetWorldDeltaSeconds);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::DeleteGameInSlot",(const void*)DeleteGameInSlot);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::LoadGameFromSlot",(const void*)LoadGameFromSlot);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::DoesSaveGameExist",(const void*)DoesSaveGameExist);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SaveGameToSlot",(const void*)SaveGameToSlot);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::CreateSaveGameObject",(const void*)CreateSaveGameObject);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::FindCollisionUV",(const void*)FindCollisionUV);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetSurfaceType",(const void*)GetSurfaceType);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::MakeHitResult",(const void*)MakeHitResult);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::BreakHitResult",(const void*)BreakHitResult);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnDecalAttached",(const void*)SpawnDecalAttached);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnDecalAtLocation",(const void*)SpawnDecalAtLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetCurrentReverbEffect",(const void*)GetCurrentReverbEffect);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::DeactivateReverbEffect",(const void*)DeactivateReverbEffect);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ActivateReverbEffect",(const void*)ActivateReverbEffect);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ClearSoundMixModifiers",(const void*)ClearSoundMixModifiers);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::PopSoundMixModifier",(const void*)PopSoundMixModifier);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::PushSoundMixModifier",(const void*)PushSoundMixModifier);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ClearSoundMixClassOverride",(const void*)ClearSoundMixClassOverride);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetSoundMixClassOverride",(const void*)SetSoundMixClassOverride);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetBaseSoundMix",(const void*)SetBaseSoundMix);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::AreSubtitlesEnabled",(const void*)AreSubtitlesEnabled);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetSubtitlesEnabled",(const void*)SetSubtitlesEnabled);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnForceFeedbackAttached",(const void*)SpawnForceFeedbackAttached);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnForceFeedbackAtLocation",(const void*)SpawnForceFeedbackAtLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnDialogueAttached",(const void*)SpawnDialogueAttached);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnDialogueAtLocation",(const void*)SpawnDialogueAtLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::PlayDialogueAtLocation",(const void*)PlayDialogueAtLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnDialogue2D",(const void*)SpawnDialogue2D);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::PlayDialogue2D",(const void*)PlayDialogue2D);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnSoundAttached",(const void*)SpawnSoundAttached);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnSoundAtLocation",(const void*)SpawnSoundAtLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::PlaySoundAtLocation",(const void*)PlaySoundAtLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::CreateSound2D",(const void*)CreateSound2D);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnSound2D",(const void*)SpawnSound2D);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::PlaySound2D",(const void*)PlaySound2D);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetGlobalListenerFocusParameters",(const void*)SetGlobalListenerFocusParameters);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetGlobalPitchModulation",(const void*)SetGlobalPitchModulation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::AreAnyListenersWithinRange",(const void*)AreAnyListenersWithinRange);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnEmitterAttached",(const void*)SpawnEmitterAttached);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnEmitterAtLocation",(const void*)SpawnEmitterAtLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::PlayWorldCameraShake",(const void*)PlayWorldCameraShake);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ApplyDamage",(const void*)ApplyDamage);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ApplyPointDamage",(const void*)ApplyPointDamage);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ApplyRadialDamageWithFalloff",(const void*)ApplyRadialDamageWithFalloff);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::ApplyRadialDamage",(const void*)ApplyRadialDamage);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::IsGamePaused",(const void*)IsGamePaused);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetGamePaused",(const void*)SetGamePaused);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetGlobalTimeDilation",(const void*)SetGlobalTimeDilation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetGlobalTimeDilation",(const void*)GetGlobalTimeDilation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetObjectClass",(const void*)GetObjectClass);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetGameState",(const void*)GetGameState);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetGameMode",(const void*)GetGameMode);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetCurrentLevelName",(const void*)GetCurrentLevelName);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::OpenLevel",(const void*)OpenLevel);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::CancelAsyncLoading",(const void*)CancelAsyncLoading);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::FlushLevelStreaming",(const void*)FlushLevelStreaming);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetStreamingLevel",(const void*)GetStreamingLevel);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::UnloadStreamLevel",(const void*)UnloadStreamLevel);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::LoadStreamLevel",(const void*)LoadStreamLevel);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SetPlayerControllerID",(const void*)SetPlayerControllerID);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetPlayerControllerID",(const void*)GetPlayerControllerID);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::RemovePlayer",(const void*)RemovePlayer);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::CreatePlayer",(const void*)CreatePlayer);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetPlayerCameraManager",(const void*)GetPlayerCameraManager);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetPlayerCharacter",(const void*)GetPlayerCharacter);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetPlayerPawn",(const void*)GetPlayerPawn);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetPlayerController",(const void*)GetPlayerController);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetGameInstance",(const void*)GetGameInstance);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetAllActorsWithTag",(const void*)GetAllActorsWithTag);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetAllActorsWithInterface",(const void*)GetAllActorsWithInterface);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetAllActorsOfClass",(const void*)GetAllActorsOfClass);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetActorArrayBounds",(const void*)GetActorArrayBounds);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::GetActorArrayAverageLocation",(const void*)GetActorArrayAverageLocation);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::FinishSpawningActor",(const void*)FinishSpawningActor);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::BeginSpawningActorFromClass",(const void*)BeginSpawningActorFromClass);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::SpawnObject",(const void*)SpawnObject);
			mono_add_internal_call("UnrealEngine.UGameplayStatics::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
