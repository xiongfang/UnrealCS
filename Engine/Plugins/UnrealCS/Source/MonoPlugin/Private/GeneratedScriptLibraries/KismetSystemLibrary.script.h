#pragma once

namespace UnrealEngine
{
	class _UKismetSystemLibrary
	{
		static void SetUserActivity(UKismetSystemLibrary* _this,FUserActivity* UserActivity)
		{
			_this->SetUserActivity(*UserActivity);
			
		}
		static void RegisterForRemoteNotifications(UKismetSystemLibrary* _this)
		{
			_this->RegisterForRemoteNotifications();
			
		}
		static MonoString* GetLocalCurrencySymbol(UKismetSystemLibrary* _this)
		{
			FString ___ret = _this->GetLocalCurrencySymbol();
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetLocalCurrencyCode(UKismetSystemLibrary* _this)
		{
			FString ___ret = _this->GetLocalCurrencyCode();
			return FStringToMonoString(___ret);
			
		}
		static MonoArray* GetPreferredLanguages(UKismetSystemLibrary* _this)
		{
			TArray<FString> ___ret = _this->GetPreferredLanguages();
			return TArrayToMonoArray(___ret,"UnrealEngine.FString,UnrealEngine");
			
		}
		static void SetSuppressViewportTransitionMessage(UKismetSystemLibrary* _this,UObject* WorldContextObject,int32 bState)
		{
			_this->SetSuppressViewportTransitionMessage(WorldContextObject,bState>0?true:false);
			
		}
		static int32 IsControllerAssignedToGamepad(UKismetSystemLibrary* _this,int32 ControllerId)
		{
			bool ___ret = _this->IsControllerAssignedToGamepad(ControllerId);
			return ___ret?1:0;
			
		}
		static void ResetGamepadAssignmentToController(UKismetSystemLibrary* _this,int32 ControllerId)
		{
			_this->ResetGamepadAssignmentToController(ControllerId);
			
		}
		static void ResetGamepadAssignments(UKismetSystemLibrary* _this)
		{
			_this->ResetGamepadAssignments();
			
		}
		static int32 GetVolumeButtonsHandledBySystem(UKismetSystemLibrary* _this)
		{
			bool ___ret = _this->GetVolumeButtonsHandledBySystem();
			return ___ret?1:0;
			
		}
		static void SetVolumeButtonsHandledBySystem(UKismetSystemLibrary* _this,int32 bEnabled)
		{
			_this->SetVolumeButtonsHandledBySystem(bEnabled>0?true:false);
			
		}
		static void ControlScreensaver(UKismetSystemLibrary* _this,int32 bAllowScreenSaver)
		{
			_this->ControlScreensaver(bAllowScreenSaver>0?true:false);
			
		}
		static int32 IsLoggedIn(UKismetSystemLibrary* _this,APlayerController* SpecificPlayer)
		{
			bool ___ret = _this->IsLoggedIn(SpecificPlayer);
			return ___ret?1:0;
			
		}
		static void ShowPlatformSpecificAchievementsScreen(UKismetSystemLibrary* _this,APlayerController* SpecificPlayer)
		{
			_this->ShowPlatformSpecificAchievementsScreen(SpecificPlayer);
			
		}
		static void ShowPlatformSpecificLeaderboardScreen(UKismetSystemLibrary* _this,MonoString* CategoryName)
		{
			FString CategoryName_temp=MonoStringToFString(CategoryName);
			_this->ShowPlatformSpecificLeaderboardScreen(CategoryName_temp);
			
		}
		static void ShowInterstitialAd(UKismetSystemLibrary* _this)
		{
			_this->ShowInterstitialAd();
			
		}
		static int32 IsInterstitialAdRequested(UKismetSystemLibrary* _this)
		{
			bool ___ret = _this->IsInterstitialAdRequested();
			return ___ret?1:0;
			
		}
		static int32 IsInterstitialAdAvailable(UKismetSystemLibrary* _this)
		{
			bool ___ret = _this->IsInterstitialAdAvailable();
			return ___ret?1:0;
			
		}
		static void LoadInterstitialAd(UKismetSystemLibrary* _this,int32 AdIdIndex)
		{
			_this->LoadInterstitialAd(AdIdIndex);
			
		}
		static void ForceCloseAdBanner(UKismetSystemLibrary* _this)
		{
			_this->ForceCloseAdBanner();
			
		}
		static void HideAdBanner(UKismetSystemLibrary* _this)
		{
			_this->HideAdBanner();
			
		}
		static int32 GetAdIDCount(UKismetSystemLibrary* _this)
		{
			int32 ___ret = _this->GetAdIDCount();
			return ___ret;
			
		}
		static void ShowAdBanner(UKismetSystemLibrary* _this,int32 AdIdIndex,int32 bShowOnBottomOfScreen)
		{
			_this->ShowAdBanner(AdIdIndex,bShowOnBottomOfScreen>0?true:false);
			
		}
		static void CollectGarbage(UKismetSystemLibrary* _this)
		{
			_this->CollectGarbage();
			
		}
		static int32 CanLaunchURL(UKismetSystemLibrary* _this,MonoString* URL)
		{
			FString URL_temp=MonoStringToFString(URL);
			bool ___ret = _this->CanLaunchURL(URL_temp);
			return ___ret?1:0;
			
		}
		static void LaunchURL(UKismetSystemLibrary* _this,MonoString* URL)
		{
			FString URL_temp=MonoStringToFString(URL);
			_this->LaunchURL(URL_temp);
			
		}
		static int32 GetMinYResolutionFor3DView(UKismetSystemLibrary* _this)
		{
			int32 ___ret = _this->GetMinYResolutionFor3DView();
			return ___ret;
			
		}
		static int32 GetMinYResolutionForUI(UKismetSystemLibrary* _this)
		{
			int32 ___ret = _this->GetMinYResolutionForUI();
			return ___ret;
			
		}
		static int32 GetConvenientWindowedResolutions(UKismetSystemLibrary* _this,MonoArray** Resolutions)
		{
			TArray<FIntPoint> Resolutions_temp;
			bool ___ret = _this->GetConvenientWindowedResolutions(Resolutions_temp);
			return ___ret?1:0;
			*Resolutions=TArrayToMonoArray(Resolutions_temp,"UnrealEngine.FIntPoint,UnrealEngine");
			
		}
		static int32 GetSupportedFullscreenResolutions(UKismetSystemLibrary* _this,MonoArray** Resolutions)
		{
			TArray<FIntPoint> Resolutions_temp;
			bool ___ret = _this->GetSupportedFullscreenResolutions(Resolutions_temp);
			return ___ret?1:0;
			*Resolutions=TArrayToMonoArray(Resolutions_temp,"UnrealEngine.FIntPoint,UnrealEngine");
			
		}
		static int32 GetRenderingMaterialQualityLevel(UKismetSystemLibrary* _this)
		{
			int32 ___ret = _this->GetRenderingMaterialQualityLevel();
			return ___ret;
			
		}
		static int32 GetRenderingDetailMode(UKismetSystemLibrary* _this)
		{
			int32 ___ret = _this->GetRenderingDetailMode();
			return ___ret;
			
		}
		static void GetComponentBounds(UKismetSystemLibrary* _this,USceneComponent* Component,FVector* Origin,FVector* BoxExtent,float* SphereRadius)
		{
			_this->GetComponentBounds(Component,*Origin,*BoxExtent,*SphereRadius);
			
		}
		static void CreateCopyForUndoBuffer(UKismetSystemLibrary* _this,UObject* ObjectToModify)
		{
			_this->CreateCopyForUndoBuffer(ObjectToModify);
			
		}
		static FDebugFloatHistory AddFloatHistorySample(UKismetSystemLibrary* _this,float Value,FDebugFloatHistory* FloatHistory)
		{
			FDebugFloatHistory ___ret = _this->AddFloatHistorySample(Value,*FloatHistory);
			return ___ret;
			
		}
		static void DrawDebugFloatHistoryLocation(UKismetSystemLibrary* _this,UObject* WorldContextObject,FDebugFloatHistory* FloatHistory,FVector* DrawLocation,FVector2D* DrawSize,FLinearColor* DrawColor,float Duration)
		{
			_this->DrawDebugFloatHistoryLocation(WorldContextObject,*FloatHistory,*DrawLocation,*DrawSize,*DrawColor,Duration);
			
		}
		static void DrawDebugFloatHistoryTransform(UKismetSystemLibrary* _this,UObject* WorldContextObject,FDebugFloatHistory* FloatHistory,FTransform* DrawTransform,FVector2D* DrawSize,FLinearColor* DrawColor,float Duration)
		{
			_this->DrawDebugFloatHistoryTransform(WorldContextObject,*FloatHistory,*DrawTransform,*DrawSize,*DrawColor,Duration);
			
		}
		static void DrawDebugCamera(UKismetSystemLibrary* _this,ACameraActor* CameraActor,FLinearColor* CameraColor,float Duration)
		{
			_this->DrawDebugCamera(CameraActor,*CameraColor,Duration);
			
		}
		static void DrawDebugFrustum(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTransform* FrustumTransform,FLinearColor* FrustumColor,float Duration,float Thickness)
		{
			_this->DrawDebugFrustum(WorldContextObject,*FrustumTransform,*FrustumColor,Duration,Thickness);
			
		}
		static void FlushPersistentDebugLines(UKismetSystemLibrary* _this,UObject* WorldContextObject)
		{
			_this->FlushPersistentDebugLines(WorldContextObject);
			
		}
		static void DrawDebugPlane(UKismetSystemLibrary* _this,UObject* WorldContextObject,FPlane* PlaneCoordinates,FVector* Location,float Size,FLinearColor* PlaneColor,float Duration)
		{
			_this->DrawDebugPlane(WorldContextObject,*PlaneCoordinates,*Location,Size,*PlaneColor,Duration);
			
		}
		static void FlushDebugStrings(UKismetSystemLibrary* _this,UObject* WorldContextObject)
		{
			_this->FlushDebugStrings(WorldContextObject);
			
		}
		static void DrawDebugString(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* TextLocation,MonoString* Text,AActor* TestBaseActor,FLinearColor* TextColor,float Duration)
		{
			FString Text_temp=MonoStringToFString(Text);
			_this->DrawDebugString(WorldContextObject,*TextLocation,Text_temp,TestBaseActor,*TextColor,Duration);
			
		}
		static void DrawDebugCapsule(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Center,float HalfHeight,float Radius,FRotator* Rotation,FLinearColor* LineColor,float Duration,float Thickness)
		{
			_this->DrawDebugCapsule(WorldContextObject,*Center,HalfHeight,Radius,*Rotation,*LineColor,Duration,Thickness);
			
		}
		static void DrawDebugConeInDegrees(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Origin,FVector* Direction,float Length,float AngleWidth,float AngleHeight,int32 NumSides,FLinearColor* LineColor,float Duration,float Thickness)
		{
			_this->DrawDebugConeInDegrees(WorldContextObject,*Origin,*Direction,Length,AngleWidth,AngleHeight,NumSides,*LineColor,Duration,Thickness);
			
		}
		static void DrawDebugCylinder(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,int32 Segments,FLinearColor* LineColor,float Duration,float Thickness)
		{
			_this->DrawDebugCylinder(WorldContextObject,*Start,*End,Radius,Segments,*LineColor,Duration,Thickness);
			
		}
		static void DrawDebugSphere(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Center,float Radius,int32 Segments,FLinearColor* LineColor,float Duration,float Thickness)
		{
			_this->DrawDebugSphere(WorldContextObject,*Center,Radius,Segments,*LineColor,Duration,Thickness);
			
		}
		static void DrawDebugCoordinateSystem(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* AxisLoc,FRotator* AxisRot,float Scale,float Duration,float Thickness)
		{
			_this->DrawDebugCoordinateSystem(WorldContextObject,*AxisLoc,*AxisRot,Scale,Duration,Thickness);
			
		}
		static void DrawDebugBox(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Center,FVector* Extent,FLinearColor* LineColor,FRotator* Rotation,float Duration,float Thickness)
		{
			_this->DrawDebugBox(WorldContextObject,*Center,*Extent,*LineColor,*Rotation,Duration,Thickness);
			
		}
		static void DrawDebugArrow(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* LineStart,FVector* LineEnd,float ArrowSize,FLinearColor* LineColor,float Duration,float Thickness)
		{
			_this->DrawDebugArrow(WorldContextObject,*LineStart,*LineEnd,ArrowSize,*LineColor,Duration,Thickness);
			
		}
		static void DrawDebugPoint(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Position,float Size,FLinearColor* PointColor,float Duration)
		{
			_this->DrawDebugPoint(WorldContextObject,*Position,Size,*PointColor,Duration);
			
		}
		static void DrawDebugCircle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Center,float Radius,int32 NumSegments,FLinearColor* LineColor,float Duration,float Thickness,FVector* YAxis,FVector* ZAxis,int32 bDrawAxis)
		{
			_this->DrawDebugCircle(WorldContextObject,*Center,Radius,NumSegments,*LineColor,Duration,Thickness,*YAxis,*ZAxis,bDrawAxis>0?true:false);
			
		}
		static void DrawDebugLine(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* LineStart,FVector* LineEnd,FLinearColor* LineColor,float Duration,float Thickness)
		{
			_this->DrawDebugLine(WorldContextObject,*LineStart,*LineEnd,*LineColor,Duration,Thickness);
			
		}
		static void GetActorListFromComponentList(UKismetSystemLibrary* _this,MonoArray* ComponentList,UClass* ActorClassFilter,MonoArray** OutActorList)
		{
			TArray<AActor*> OutActorList_temp;
			_this->GetActorListFromComponentList(MonoArrayToTArray<UPrimitiveComponent*>(ComponentList),ActorClassFilter,OutActorList_temp);
			*OutActorList=TArrayToMonoArray(OutActorList_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 CapsuleTraceMultiForObjects(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,float HalfHeight,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,MonoArray** OutHits,int32 bIgnoreSelf)
		{
			TArray<FHitResult> OutHits_temp;
			bool ___ret = _this->CapsuleTraceMultiForObjects(WorldContextObject,*Start,*End,Radius,HalfHeight,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,OutHits_temp,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			*OutHits=TArrayToMonoArray(OutHits_temp,"UnrealEngine.FHitResult,UnrealEngine");
			
		}
		static int32 CapsuleTraceSingleForObjects(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,float HalfHeight,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,FHitResult* OutHit,int32 bIgnoreSelf)
		{
			bool ___ret = _this->CapsuleTraceSingleForObjects(WorldContextObject,*Start,*End,Radius,HalfHeight,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,*OutHit,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 BoxTraceMultiForObjects(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,FVector* HalfSize,FRotator* Orientation,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,MonoArray** OutHits,int32 bIgnoreSelf)
		{
			TArray<FHitResult> OutHits_temp;
			bool ___ret = _this->BoxTraceMultiForObjects(WorldContextObject,*Start,*End,*HalfSize,*Orientation,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,OutHits_temp,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			*OutHits=TArrayToMonoArray(OutHits_temp,"UnrealEngine.FHitResult,UnrealEngine");
			
		}
		static int32 BoxTraceSingleForObjects(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,FVector* HalfSize,FRotator* Orientation,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,FHitResult* OutHit,int32 bIgnoreSelf)
		{
			bool ___ret = _this->BoxTraceSingleForObjects(WorldContextObject,*Start,*End,*HalfSize,*Orientation,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,*OutHit,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 SphereTraceMultiForObjects(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,MonoArray** OutHits,int32 bIgnoreSelf)
		{
			TArray<FHitResult> OutHits_temp;
			bool ___ret = _this->SphereTraceMultiForObjects(WorldContextObject,*Start,*End,Radius,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,OutHits_temp,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			*OutHits=TArrayToMonoArray(OutHits_temp,"UnrealEngine.FHitResult,UnrealEngine");
			
		}
		static int32 SphereTraceSingleForObjects(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,FHitResult* OutHit,int32 bIgnoreSelf)
		{
			bool ___ret = _this->SphereTraceSingleForObjects(WorldContextObject,*Start,*End,Radius,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,*OutHit,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 LineTraceMultiForObjects(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,MonoArray** OutHits,int32 bIgnoreSelf,FLinearColor* TraceColor,FLinearColor* TraceHitColor,float DrawTime)
		{
			TArray<FHitResult> OutHits_temp;
			bool ___ret = _this->LineTraceMultiForObjects(WorldContextObject,*Start,*End,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,OutHits_temp,bIgnoreSelf>0?true:false,*TraceColor,*TraceHitColor,DrawTime);
			return ___ret?1:0;
			*OutHits=TArrayToMonoArray(OutHits_temp,"UnrealEngine.FHitResult,UnrealEngine");
			
		}
		static int32 LineTraceSingleForObjects(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,MonoArray* ObjectTypes,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,FHitResult* OutHit,int32 bIgnoreSelf,FLinearColor* TraceColor,FLinearColor* TraceHitColor,float DrawTime)
		{
			bool ___ret = _this->LineTraceSingleForObjects(WorldContextObject,*Start,*End,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,*OutHit,bIgnoreSelf>0?true:false,*TraceColor,*TraceHitColor,DrawTime);
			return ___ret?1:0;
			
		}
		static int32 CapsuleTraceMulti_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,float HalfHeight,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,MonoArray** OutHits,int32 bIgnoreSelf)
		{
			TArray<FHitResult> OutHits_temp;
			bool ___ret = _this->CapsuleTraceMulti_NEW(WorldContextObject,*Start,*End,Radius,HalfHeight,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,OutHits_temp,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			*OutHits=TArrayToMonoArray(OutHits_temp,"UnrealEngine.FHitResult,UnrealEngine");
			
		}
		static int32 CapsuleTraceSingle_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,float HalfHeight,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,FHitResult* OutHit,int32 bIgnoreSelf)
		{
			bool ___ret = _this->CapsuleTraceSingle_NEW(WorldContextObject,*Start,*End,Radius,HalfHeight,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,*OutHit,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 BoxTraceMulti(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,FVector* HalfSize,FRotator* Orientation,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,MonoArray** OutHits,int32 bIgnoreSelf)
		{
			TArray<FHitResult> OutHits_temp;
			bool ___ret = _this->BoxTraceMulti(WorldContextObject,*Start,*End,*HalfSize,*Orientation,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,OutHits_temp,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			*OutHits=TArrayToMonoArray(OutHits_temp,"UnrealEngine.FHitResult,UnrealEngine");
			
		}
		static int32 BoxTraceSingle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,FVector* HalfSize,FRotator* Orientation,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,FHitResult* OutHit,int32 bIgnoreSelf)
		{
			bool ___ret = _this->BoxTraceSingle(WorldContextObject,*Start,*End,*HalfSize,*Orientation,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,*OutHit,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 SphereTraceMulti_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,MonoArray** OutHits,int32 bIgnoreSelf)
		{
			TArray<FHitResult> OutHits_temp;
			bool ___ret = _this->SphereTraceMulti_NEW(WorldContextObject,*Start,*End,Radius,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,OutHits_temp,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			*OutHits=TArrayToMonoArray(OutHits_temp,"UnrealEngine.FHitResult,UnrealEngine");
			
		}
		static int32 SphereTraceSingle_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,float Radius,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,FHitResult* OutHit,int32 bIgnoreSelf)
		{
			bool ___ret = _this->SphereTraceSingle_NEW(WorldContextObject,*Start,*End,Radius,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,*OutHit,bIgnoreSelf>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 LineTraceMulti_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,MonoArray** OutHits,int32 bIgnoreSelf,FLinearColor* TraceColor,FLinearColor* TraceHitColor,float DrawTime)
		{
			TArray<FHitResult> OutHits_temp;
			bool ___ret = _this->LineTraceMulti_NEW(WorldContextObject,*Start,*End,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,OutHits_temp,bIgnoreSelf>0?true:false,*TraceColor,*TraceHitColor,DrawTime);
			return ___ret?1:0;
			*OutHits=TArrayToMonoArray(OutHits_temp,"UnrealEngine.FHitResult,UnrealEngine");
			
		}
		static int32 LineTraceSingle_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* Start,FVector* End,int32 TraceChannel,int32 bTraceComplex,MonoArray* ActorsToIgnore,int32 DrawDebugType,FHitResult* OutHit,int32 bIgnoreSelf,FLinearColor* TraceColor,FLinearColor* TraceHitColor,float DrawTime)
		{
			bool ___ret = _this->LineTraceSingle_NEW(WorldContextObject,*Start,*End,(TEnumAsByte<ETraceTypeQuery>)TraceChannel,bTraceComplex>0?true:false,MonoArrayToTArray<AActor*>(ActorsToIgnore),(TEnumAsByte<EDrawDebugTrace::Type>)DrawDebugType,*OutHit,bIgnoreSelf>0?true:false,*TraceColor,*TraceHitColor,DrawTime);
			return ___ret?1:0;
			
		}
		static int32 ComponentOverlapComponents_NEW(UKismetSystemLibrary* _this,UPrimitiveComponent* Component,FTransform* ComponentTransform,MonoArray* ObjectTypes,UClass* ComponentClassFilter,MonoArray* ActorsToIgnore,MonoArray** OutComponents)
		{
			TArray<UPrimitiveComponent*> OutComponents_temp;
			bool ___ret = _this->ComponentOverlapComponents_NEW(Component,*ComponentTransform,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),ComponentClassFilter,MonoArrayToTArray<AActor*>(ActorsToIgnore),OutComponents_temp);
			return ___ret?1:0;
			*OutComponents=TArrayToMonoArray(OutComponents_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 ComponentOverlapActors_NEW(UKismetSystemLibrary* _this,UPrimitiveComponent* Component,FTransform* ComponentTransform,MonoArray* ObjectTypes,UClass* ActorClassFilter,MonoArray* ActorsToIgnore,MonoArray** OutActors)
		{
			TArray<AActor*> OutActors_temp;
			bool ___ret = _this->ComponentOverlapActors_NEW(Component,*ComponentTransform,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),ActorClassFilter,MonoArrayToTArray<AActor*>(ActorsToIgnore),OutActors_temp);
			return ___ret?1:0;
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 CapsuleOverlapComponents_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* CapsulePos,float Radius,float HalfHeight,MonoArray* ObjectTypes,UClass* ComponentClassFilter,MonoArray* ActorsToIgnore,MonoArray** OutComponents)
		{
			TArray<UPrimitiveComponent*> OutComponents_temp;
			bool ___ret = _this->CapsuleOverlapComponents_NEW(WorldContextObject,*CapsulePos,Radius,HalfHeight,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),ComponentClassFilter,MonoArrayToTArray<AActor*>(ActorsToIgnore),OutComponents_temp);
			return ___ret?1:0;
			*OutComponents=TArrayToMonoArray(OutComponents_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 CapsuleOverlapActors_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* CapsulePos,float Radius,float HalfHeight,MonoArray* ObjectTypes,UClass* ActorClassFilter,MonoArray* ActorsToIgnore,MonoArray** OutActors)
		{
			TArray<AActor*> OutActors_temp;
			bool ___ret = _this->CapsuleOverlapActors_NEW(WorldContextObject,*CapsulePos,Radius,HalfHeight,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),ActorClassFilter,MonoArrayToTArray<AActor*>(ActorsToIgnore),OutActors_temp);
			return ___ret?1:0;
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 BoxOverlapComponents_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* BoxPos,FVector* Extent,MonoArray* ObjectTypes,UClass* ComponentClassFilter,MonoArray* ActorsToIgnore,MonoArray** OutComponents)
		{
			TArray<UPrimitiveComponent*> OutComponents_temp;
			bool ___ret = _this->BoxOverlapComponents_NEW(WorldContextObject,*BoxPos,*Extent,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),ComponentClassFilter,MonoArrayToTArray<AActor*>(ActorsToIgnore),OutComponents_temp);
			return ___ret?1:0;
			*OutComponents=TArrayToMonoArray(OutComponents_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 BoxOverlapActors_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* BoxPos,FVector* BoxExtent,MonoArray* ObjectTypes,UClass* ActorClassFilter,MonoArray* ActorsToIgnore,MonoArray** OutActors)
		{
			TArray<AActor*> OutActors_temp;
			bool ___ret = _this->BoxOverlapActors_NEW(WorldContextObject,*BoxPos,*BoxExtent,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),ActorClassFilter,MonoArrayToTArray<AActor*>(ActorsToIgnore),OutActors_temp);
			return ___ret?1:0;
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 SphereOverlapComponents_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* SpherePos,float SphereRadius,MonoArray* ObjectTypes,UClass* ComponentClassFilter,MonoArray* ActorsToIgnore,MonoArray** OutComponents)
		{
			TArray<UPrimitiveComponent*> OutComponents_temp;
			bool ___ret = _this->SphereOverlapComponents_NEW(WorldContextObject,*SpherePos,SphereRadius,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),ComponentClassFilter,MonoArrayToTArray<AActor*>(ActorsToIgnore),OutComponents_temp);
			return ___ret?1:0;
			*OutComponents=TArrayToMonoArray(OutComponents_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 SphereOverlapActors_NEW(UKismetSystemLibrary* _this,UObject* WorldContextObject,FVector* SpherePos,float SphereRadius,MonoArray* ObjectTypes,UClass* ActorClassFilter,MonoArray* ActorsToIgnore,MonoArray** OutActors)
		{
			TArray<AActor*> OutActors_temp;
			bool ___ret = _this->SphereOverlapActors_NEW(WorldContextObject,*SpherePos,SphereRadius,MonoArrayToTArray<TEnumAsByte<EObjectTypeQuery>>(ObjectTypes),ActorClassFilter,MonoArrayToTArray<AActor*>(ActorsToIgnore),OutActors_temp);
			return ___ret?1:0;
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static void SetStructurePropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,FGenericStruct* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetStructurePropertyByName(Object,PropertyName_temp,*Value);
			
		}
		static void SetCollisionProfileNameProperty(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,FCollisionProfileName* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetCollisionProfileNameProperty(Object,PropertyName_temp,*Value);
			
		}
		static void SetTransformPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,FTransform* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetTransformPropertyByName(Object,PropertyName_temp,*Value);
			
		}
		static void SetLinearColorPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,FLinearColor* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetLinearColorPropertyByName(Object,PropertyName_temp,*Value);
			
		}
		static void SetRotatorPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,FRotator* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetRotatorPropertyByName(Object,PropertyName_temp,*Value);
			
		}
		static void SetVectorPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,FVector* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetVectorPropertyByName(Object,PropertyName_temp,*Value);
			
		}
		static void SetTextPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,MonoString* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			FText Value_temp=FText::FromString(MonoStringToFString(Value));
			_this->SetTextPropertyByName(Object,PropertyName_temp,Value_temp);
			
		}
		static void SetStringPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,MonoString* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			FString Value_temp=MonoStringToFString(Value);
			_this->SetStringPropertyByName(Object,PropertyName_temp,Value_temp);
			
		}
		static void SetNamePropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,MonoString* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			FName Value_temp=MonoStringToFName(Value);
			_this->SetNamePropertyByName(Object,PropertyName_temp,Value_temp);
			
		}
		static void SetClassPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,TSubclassOf<UObject>  Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetClassPropertyByName(Object,PropertyName_temp,Value);
			
		}
		static void SetObjectPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,UObject* Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetObjectPropertyByName(Object,PropertyName_temp,Value);
			
		}
		static void SetBoolPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,int32 Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetBoolPropertyByName(Object,PropertyName_temp,Value>0?true:false);
			
		}
		static void SetFloatPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,float Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetFloatPropertyByName(Object,PropertyName_temp,Value);
			
		}
		static void SetBytePropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,int32 Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetBytePropertyByName(Object,PropertyName_temp,Value);
			
		}
		static void SetIntPropertyByName(UKismetSystemLibrary* _this,UObject* Object,MonoString* PropertyName,int32 Value)
		{
			FName PropertyName_temp=MonoStringToFName(PropertyName);
			_this->SetIntPropertyByName(Object,PropertyName_temp,Value);
			
		}
		static float K2_GetTimerRemainingTime(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			float ___ret = _this->K2_GetTimerRemainingTime(Object,FunctionName_temp);
			return ___ret;
			
		}
		static float K2_GetTimerElapsedTime(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			float ___ret = _this->K2_GetTimerElapsedTime(Object,FunctionName_temp);
			return ___ret;
			
		}
		static int32 K2_TimerExists(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			bool ___ret = _this->K2_TimerExists(Object,FunctionName_temp);
			return ___ret?1:0;
			
		}
		static int32 K2_IsTimerPaused(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			bool ___ret = _this->K2_IsTimerPaused(Object,FunctionName_temp);
			return ___ret?1:0;
			
		}
		static int32 K2_IsTimerActive(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			bool ___ret = _this->K2_IsTimerActive(Object,FunctionName_temp);
			return ___ret?1:0;
			
		}
		static void K2_UnPauseTimer(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			_this->K2_UnPauseTimer(Object,FunctionName_temp);
			
		}
		static void K2_PauseTimer(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			_this->K2_PauseTimer(Object,FunctionName_temp);
			
		}
		static void K2_ClearTimer(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			_this->K2_ClearTimer(Object,FunctionName_temp);
			
		}
		static FTimerHandle K2_SetTimer(UKismetSystemLibrary* _this,UObject* Object,MonoString* FunctionName,float Time,int32 bLooping)
		{
			FString FunctionName_temp=MonoStringToFString(FunctionName);
			FTimerHandle ___ret = _this->K2_SetTimer(Object,FunctionName_temp,Time,bLooping>0?true:false);
			return ___ret;
			
		}
		static float K2_GetTimerRemainingTimeHandle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTimerHandle* Handle)
		{
			float ___ret = _this->K2_GetTimerRemainingTimeHandle(WorldContextObject,*Handle);
			return ___ret;
			
		}
		static float K2_GetTimerElapsedTimeHandle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTimerHandle* Handle)
		{
			float ___ret = _this->K2_GetTimerElapsedTimeHandle(WorldContextObject,*Handle);
			return ___ret;
			
		}
		static int32 K2_TimerExistsHandle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTimerHandle* Handle)
		{
			bool ___ret = _this->K2_TimerExistsHandle(WorldContextObject,*Handle);
			return ___ret?1:0;
			
		}
		static int32 K2_IsTimerPausedHandle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTimerHandle* Handle)
		{
			bool ___ret = _this->K2_IsTimerPausedHandle(WorldContextObject,*Handle);
			return ___ret?1:0;
			
		}
		static int32 K2_IsTimerActiveHandle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTimerHandle* Handle)
		{
			bool ___ret = _this->K2_IsTimerActiveHandle(WorldContextObject,*Handle);
			return ___ret?1:0;
			
		}
		static void K2_UnPauseTimerHandle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTimerHandle* Handle)
		{
			_this->K2_UnPauseTimerHandle(WorldContextObject,*Handle);
			
		}
		static void K2_PauseTimerHandle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTimerHandle* Handle)
		{
			_this->K2_PauseTimerHandle(WorldContextObject,*Handle);
			
		}
		static void K2_ClearAndInvalidateTimerHandle(UKismetSystemLibrary* _this,UObject* WorldContextObject,FTimerHandle* Handle)
		{
			_this->K2_ClearAndInvalidateTimerHandle(WorldContextObject,*Handle);
			
		}
		static FTimerHandle K2_InvalidateTimerHandle(UKismetSystemLibrary* _this,FTimerHandle* Handle)
		{
			FTimerHandle ___ret = _this->K2_InvalidateTimerHandle(*Handle);
			return ___ret;
			
		}
		static int32 K2_IsValidTimerHandle(UKismetSystemLibrary* _this,FTimerHandle* Handle)
		{
			bool ___ret = _this->K2_IsValidTimerHandle(*Handle);
			return ___ret?1:0;
			
		}
		static void MoveComponentTo(UKismetSystemLibrary* _this,USceneComponent* Component,FVector* TargetRelativeLocation,FRotator* TargetRelativeRotation,int32 bEaseOut,int32 bEaseIn,float OverTime,int32 bForceShortestRotationPath,int32 MoveAction,FLatentActionInfo* LatentInfo)
		{
			_this->MoveComponentTo(Component,*TargetRelativeLocation,*TargetRelativeRotation,bEaseOut>0?true:false,bEaseIn>0?true:false,OverTime,bForceShortestRotationPath>0?true:false,(TEnumAsByte<EMoveComponentAction::Type>)MoveAction,*LatentInfo);
			
		}
		static void RetriggerableDelay(UKismetSystemLibrary* _this,UObject* WorldContextObject,float Duration,FLatentActionInfo* LatentInfo)
		{
			_this->RetriggerableDelay(WorldContextObject,Duration,*LatentInfo);
			
		}
		static void Delay(UKismetSystemLibrary* _this,UObject* WorldContextObject,float Duration,FLatentActionInfo* LatentInfo)
		{
			_this->Delay(WorldContextObject,Duration,*LatentInfo);
			
		}
		static void QuitGame(UKismetSystemLibrary* _this,UObject* WorldContextObject,APlayerController* SpecificPlayer,int32 QuitPreference)
		{
			_this->QuitGame(WorldContextObject,SpecificPlayer,(TEnumAsByte<EQuitPreference::Type>)QuitPreference);
			
		}
		static void ExecuteConsoleCommand(UKismetSystemLibrary* _this,UObject* WorldContextObject,MonoString* Command,APlayerController* SpecificPlayer)
		{
			FString Command_temp=MonoStringToFString(Command);
			_this->ExecuteConsoleCommand(WorldContextObject,Command_temp,SpecificPlayer);
			
		}
		static void SetWindowTitle(UKismetSystemLibrary* _this,MonoString* Title)
		{
			FText Title_temp=FText::FromString(MonoStringToFString(Title));
			_this->SetWindowTitle(Title_temp);
			
		}
		static void PrintWarning(UKismetSystemLibrary* _this,MonoString* InString)
		{
			FString InString_temp=MonoStringToFString(InString);
			_this->PrintWarning(InString_temp);
			
		}
		static void PrintText(UKismetSystemLibrary* _this,UObject* WorldContextObject,MonoString* InText,int32 bPrintToScreen,int32 bPrintToLog,FLinearColor* TextColor,float Duration)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			_this->PrintText(WorldContextObject,InText_temp,bPrintToScreen>0?true:false,bPrintToLog>0?true:false,*TextColor,Duration);
			
		}
		static void PrintString(UKismetSystemLibrary* _this,UObject* WorldContextObject,MonoString* InString,int32 bPrintToScreen,int32 bPrintToLog,FLinearColor* TextColor,float Duration)
		{
			FString InString_temp=MonoStringToFString(InString);
			_this->PrintString(WorldContextObject,InString_temp,bPrintToScreen>0?true:false,bPrintToLog>0?true:false,*TextColor,Duration);
			
		}
		static MonoString* MakeLiteralText(UKismetSystemLibrary* _this,MonoString* Value)
		{
			FText Value_temp=FText::FromString(MonoStringToFString(Value));
			FText ___ret = _this->MakeLiteralText(Value_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* MakeLiteralString(UKismetSystemLibrary* _this,MonoString* Value)
		{
			FString Value_temp=MonoStringToFString(Value);
			FString ___ret = _this->MakeLiteralString(Value_temp);
			return FStringToMonoString(___ret);
			
		}
		static int32 MakeLiteralByte(UKismetSystemLibrary* _this,int32 Value)
		{
			uint8 ___ret = _this->MakeLiteralByte(Value);
			return (uint8)___ret;
			
		}
		static MonoString* MakeLiteralName(UKismetSystemLibrary* _this,MonoString* Value)
		{
			FName Value_temp=MonoStringToFName(Value);
			FName ___ret = _this->MakeLiteralName(Value_temp);
			return FNameToMonoString(___ret);
			
		}
		static int32 MakeLiteralBool(UKismetSystemLibrary* _this,int32 Value)
		{
			bool ___ret = _this->MakeLiteralBool(Value>0?true:false);
			return ___ret?1:0;
			
		}
		static float MakeLiteralFloat(UKismetSystemLibrary* _this,float Value)
		{
			float ___ret = _this->MakeLiteralFloat(Value);
			return ___ret;
			
		}
		static int32 MakeLiteralInt(UKismetSystemLibrary* _this,int32 Value)
		{
			int32 ___ret = _this->MakeLiteralInt(Value);
			return ___ret;
			
		}
		static MonoString* GetUniqueDeviceId(UKismetSystemLibrary* _this)
		{
			FString ___ret = _this->GetUniqueDeviceId();
			return FStringToMonoString(___ret);
			
		}
		static int32 IsPackagedForDistribution(UKismetSystemLibrary* _this)
		{
			bool ___ret = _this->IsPackagedForDistribution();
			return ___ret?1:0;
			
		}
		static int32 IsStandalone(UKismetSystemLibrary* _this,UObject* WorldContextObject)
		{
			bool ___ret = _this->IsStandalone(WorldContextObject);
			return ___ret?1:0;
			
		}
		static int32 IsDedicatedServer(UKismetSystemLibrary* _this,UObject* WorldContextObject)
		{
			bool ___ret = _this->IsDedicatedServer(WorldContextObject);
			return ___ret?1:0;
			
		}
		static int32 IsServer(UKismetSystemLibrary* _this,UObject* WorldContextObject)
		{
			bool ___ret = _this->IsServer(WorldContextObject);
			return ___ret?1:0;
			
		}
		static float GetGameTimeInSeconds(UKismetSystemLibrary* _this,UObject* WorldContextObject)
		{
			float ___ret = _this->GetGameTimeInSeconds(WorldContextObject);
			return ___ret;
			
		}
		static int32 DoesImplementInterface(UKismetSystemLibrary* _this,UObject* TestObject,TSubclassOf<UInterface>  Interface)
		{
			bool ___ret = _this->DoesImplementInterface(TestObject,Interface);
			return ___ret?1:0;
			
		}
		static MonoString* GetPlatformUserName(UKismetSystemLibrary* _this)
		{
			FString ___ret = _this->GetPlatformUserName();
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetGameBundleId(UKismetSystemLibrary* _this)
		{
			FString ___ret = _this->GetGameBundleId();
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetGameName(UKismetSystemLibrary* _this)
		{
			FString ___ret = _this->GetGameName();
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetEngineVersion(UKismetSystemLibrary* _this)
		{
			FString ___ret = _this->GetEngineVersion();
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetClassDisplayName(UKismetSystemLibrary* _this,UClass* Class)
		{
			FString ___ret = _this->GetClassDisplayName(Class);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetDisplayName(UKismetSystemLibrary* _this,UObject* Object)
		{
			FString ___ret = _this->GetDisplayName(Object);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetPathName(UKismetSystemLibrary* _this,UObject* Object)
		{
			FString ___ret = _this->GetPathName(Object);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetObjectName(UKismetSystemLibrary* _this,UObject* Object)
		{
			FString ___ret = _this->GetObjectName(Object);
			return FStringToMonoString(___ret);
			
		}
		static int32 IsValidClass(UKismetSystemLibrary* _this,UClass* Class)
		{
			bool ___ret = _this->IsValidClass(Class);
			return ___ret?1:0;
			
		}
		static int32 IsValid(UKismetSystemLibrary* _this,UObject* Object)
		{
			bool ___ret = _this->IsValid(Object);
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UKismetSystemLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetUserActivity",(const void*)SetUserActivity);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::RegisterForRemoteNotifications",(const void*)RegisterForRemoteNotifications);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetLocalCurrencySymbol",(const void*)GetLocalCurrencySymbol);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetLocalCurrencyCode",(const void*)GetLocalCurrencyCode);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetPreferredLanguages",(const void*)GetPreferredLanguages);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetSuppressViewportTransitionMessage",(const void*)SetSuppressViewportTransitionMessage);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsControllerAssignedToGamepad",(const void*)IsControllerAssignedToGamepad);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ResetGamepadAssignmentToController",(const void*)ResetGamepadAssignmentToController);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ResetGamepadAssignments",(const void*)ResetGamepadAssignments);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetVolumeButtonsHandledBySystem",(const void*)GetVolumeButtonsHandledBySystem);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetVolumeButtonsHandledBySystem",(const void*)SetVolumeButtonsHandledBySystem);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ControlScreensaver",(const void*)ControlScreensaver);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsLoggedIn",(const void*)IsLoggedIn);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ShowPlatformSpecificAchievementsScreen",(const void*)ShowPlatformSpecificAchievementsScreen);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ShowPlatformSpecificLeaderboardScreen",(const void*)ShowPlatformSpecificLeaderboardScreen);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ShowInterstitialAd",(const void*)ShowInterstitialAd);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsInterstitialAdRequested",(const void*)IsInterstitialAdRequested);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsInterstitialAdAvailable",(const void*)IsInterstitialAdAvailable);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::LoadInterstitialAd",(const void*)LoadInterstitialAd);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ForceCloseAdBanner",(const void*)ForceCloseAdBanner);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::HideAdBanner",(const void*)HideAdBanner);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetAdIDCount",(const void*)GetAdIDCount);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ShowAdBanner",(const void*)ShowAdBanner);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CollectGarbage",(const void*)CollectGarbage);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CanLaunchURL",(const void*)CanLaunchURL);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::LaunchURL",(const void*)LaunchURL);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetMinYResolutionFor3DView",(const void*)GetMinYResolutionFor3DView);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetMinYResolutionForUI",(const void*)GetMinYResolutionForUI);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetConvenientWindowedResolutions",(const void*)GetConvenientWindowedResolutions);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetSupportedFullscreenResolutions",(const void*)GetSupportedFullscreenResolutions);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetRenderingMaterialQualityLevel",(const void*)GetRenderingMaterialQualityLevel);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetRenderingDetailMode",(const void*)GetRenderingDetailMode);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetComponentBounds",(const void*)GetComponentBounds);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CreateCopyForUndoBuffer",(const void*)CreateCopyForUndoBuffer);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::AddFloatHistorySample",(const void*)AddFloatHistorySample);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugFloatHistoryLocation",(const void*)DrawDebugFloatHistoryLocation);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugFloatHistoryTransform",(const void*)DrawDebugFloatHistoryTransform);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugCamera",(const void*)DrawDebugCamera);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugFrustum",(const void*)DrawDebugFrustum);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::FlushPersistentDebugLines",(const void*)FlushPersistentDebugLines);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugPlane",(const void*)DrawDebugPlane);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::FlushDebugStrings",(const void*)FlushDebugStrings);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugString",(const void*)DrawDebugString);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugCapsule",(const void*)DrawDebugCapsule);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugConeInDegrees",(const void*)DrawDebugConeInDegrees);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugCylinder",(const void*)DrawDebugCylinder);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugSphere",(const void*)DrawDebugSphere);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugCoordinateSystem",(const void*)DrawDebugCoordinateSystem);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugBox",(const void*)DrawDebugBox);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugArrow",(const void*)DrawDebugArrow);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugPoint",(const void*)DrawDebugPoint);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugCircle",(const void*)DrawDebugCircle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DrawDebugLine",(const void*)DrawDebugLine);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetActorListFromComponentList",(const void*)GetActorListFromComponentList);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CapsuleTraceMultiForObjects",(const void*)CapsuleTraceMultiForObjects);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CapsuleTraceSingleForObjects",(const void*)CapsuleTraceSingleForObjects);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::BoxTraceMultiForObjects",(const void*)BoxTraceMultiForObjects);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::BoxTraceSingleForObjects",(const void*)BoxTraceSingleForObjects);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SphereTraceMultiForObjects",(const void*)SphereTraceMultiForObjects);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SphereTraceSingleForObjects",(const void*)SphereTraceSingleForObjects);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::LineTraceMultiForObjects",(const void*)LineTraceMultiForObjects);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::LineTraceSingleForObjects",(const void*)LineTraceSingleForObjects);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CapsuleTraceMulti_NEW",(const void*)CapsuleTraceMulti_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CapsuleTraceSingle_NEW",(const void*)CapsuleTraceSingle_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::BoxTraceMulti",(const void*)BoxTraceMulti);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::BoxTraceSingle",(const void*)BoxTraceSingle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SphereTraceMulti_NEW",(const void*)SphereTraceMulti_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SphereTraceSingle_NEW",(const void*)SphereTraceSingle_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::LineTraceMulti_NEW",(const void*)LineTraceMulti_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::LineTraceSingle_NEW",(const void*)LineTraceSingle_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ComponentOverlapComponents_NEW",(const void*)ComponentOverlapComponents_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ComponentOverlapActors_NEW",(const void*)ComponentOverlapActors_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CapsuleOverlapComponents_NEW",(const void*)CapsuleOverlapComponents_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::CapsuleOverlapActors_NEW",(const void*)CapsuleOverlapActors_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::BoxOverlapComponents_NEW",(const void*)BoxOverlapComponents_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::BoxOverlapActors_NEW",(const void*)BoxOverlapActors_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SphereOverlapComponents_NEW",(const void*)SphereOverlapComponents_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SphereOverlapActors_NEW",(const void*)SphereOverlapActors_NEW);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetStructurePropertyByName",(const void*)SetStructurePropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetCollisionProfileNameProperty",(const void*)SetCollisionProfileNameProperty);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetTransformPropertyByName",(const void*)SetTransformPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetLinearColorPropertyByName",(const void*)SetLinearColorPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetRotatorPropertyByName",(const void*)SetRotatorPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetVectorPropertyByName",(const void*)SetVectorPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetTextPropertyByName",(const void*)SetTextPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetStringPropertyByName",(const void*)SetStringPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetNamePropertyByName",(const void*)SetNamePropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetClassPropertyByName",(const void*)SetClassPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetObjectPropertyByName",(const void*)SetObjectPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetBoolPropertyByName",(const void*)SetBoolPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetFloatPropertyByName",(const void*)SetFloatPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetBytePropertyByName",(const void*)SetBytePropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetIntPropertyByName",(const void*)SetIntPropertyByName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_GetTimerRemainingTime",(const void*)K2_GetTimerRemainingTime);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_GetTimerElapsedTime",(const void*)K2_GetTimerElapsedTime);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_TimerExists",(const void*)K2_TimerExists);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_IsTimerPaused",(const void*)K2_IsTimerPaused);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_IsTimerActive",(const void*)K2_IsTimerActive);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_UnPauseTimer",(const void*)K2_UnPauseTimer);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_PauseTimer",(const void*)K2_PauseTimer);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_ClearTimer",(const void*)K2_ClearTimer);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_SetTimer",(const void*)K2_SetTimer);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_GetTimerRemainingTimeHandle",(const void*)K2_GetTimerRemainingTimeHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_GetTimerElapsedTimeHandle",(const void*)K2_GetTimerElapsedTimeHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_TimerExistsHandle",(const void*)K2_TimerExistsHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_IsTimerPausedHandle",(const void*)K2_IsTimerPausedHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_IsTimerActiveHandle",(const void*)K2_IsTimerActiveHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_UnPauseTimerHandle",(const void*)K2_UnPauseTimerHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_PauseTimerHandle",(const void*)K2_PauseTimerHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_ClearAndInvalidateTimerHandle",(const void*)K2_ClearAndInvalidateTimerHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_InvalidateTimerHandle",(const void*)K2_InvalidateTimerHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::K2_IsValidTimerHandle",(const void*)K2_IsValidTimerHandle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::MoveComponentTo",(const void*)MoveComponentTo);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::RetriggerableDelay",(const void*)RetriggerableDelay);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::Delay",(const void*)Delay);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::QuitGame",(const void*)QuitGame);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::ExecuteConsoleCommand",(const void*)ExecuteConsoleCommand);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::SetWindowTitle",(const void*)SetWindowTitle);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::PrintWarning",(const void*)PrintWarning);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::PrintText",(const void*)PrintText);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::PrintString",(const void*)PrintString);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::MakeLiteralText",(const void*)MakeLiteralText);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::MakeLiteralString",(const void*)MakeLiteralString);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::MakeLiteralByte",(const void*)MakeLiteralByte);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::MakeLiteralName",(const void*)MakeLiteralName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::MakeLiteralBool",(const void*)MakeLiteralBool);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::MakeLiteralFloat",(const void*)MakeLiteralFloat);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::MakeLiteralInt",(const void*)MakeLiteralInt);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetUniqueDeviceId",(const void*)GetUniqueDeviceId);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsPackagedForDistribution",(const void*)IsPackagedForDistribution);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsStandalone",(const void*)IsStandalone);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsDedicatedServer",(const void*)IsDedicatedServer);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsServer",(const void*)IsServer);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetGameTimeInSeconds",(const void*)GetGameTimeInSeconds);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::DoesImplementInterface",(const void*)DoesImplementInterface);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetPlatformUserName",(const void*)GetPlatformUserName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetGameBundleId",(const void*)GetGameBundleId);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetGameName",(const void*)GetGameName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetEngineVersion",(const void*)GetEngineVersion);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetClassDisplayName",(const void*)GetClassDisplayName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetDisplayName",(const void*)GetDisplayName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetPathName",(const void*)GetPathName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::GetObjectName",(const void*)GetObjectName);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsValidClass",(const void*)IsValidClass);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::IsValid",(const void*)IsValid);
			mono_add_internal_call("UnrealEngine.UKismetSystemLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
