#pragma once

namespace UnrealEngine
{
	class _AActor
	{
		static MonoArray* GetComponentsByTag(AActor* _this,TSubclassOf<UActorComponent>  ComponentClass,MonoString* Tag)
		{
			FName Tag_temp=MonoStringToFName(Tag);
			TArray<UActorComponent*> ___ret = _this->GetComponentsByTag(ComponentClass,Tag_temp);
			return TArrayToMonoArray(___ret,"System.IntPtr,mscorlib");
			
		}
		static MonoArray* GetComponentsByClass(AActor* _this,TSubclassOf<UActorComponent>  ComponentClass)
		{
			TArray<UActorComponent*> ___ret = _this->GetComponentsByClass(ComponentClass);
			return TArrayToMonoArray(___ret,"System.IntPtr,mscorlib");
			
		}
		static UActorComponent* GetComponentByClass(AActor* _this,TSubclassOf<UActorComponent>  ComponentClass)
		{
			UActorComponent* ___ret = _this->GetComponentByClass(ComponentClass);
			return ___ret;
			
		}
		static void GetActorEyesViewPoint(AActor* _this,FVector* OutLocation,FRotator* OutRotation)
		{
			_this->GetActorEyesViewPoint(*OutLocation,*OutRotation);
			
		}
		static void ForceNetUpdate(AActor* _this)
		{
			_this->ForceNetUpdate();
			
		}
		static int32 WasRecentlyRendered(AActor* _this,float Tolerance)
		{
			bool ___ret = _this->WasRecentlyRendered(Tolerance);
			return ___ret?1:0;
			
		}
		static void SetTickGroup(AActor* _this,int32 NewTickGroup)
		{
			_this->SetTickGroup((TEnumAsByte<ETickingGroup>)NewTickGroup);
			
		}
		static void GetAttachedActors(AActor* _this,MonoArray** OutActors)
		{
			TArray<AActor*> OutActors_temp;
			_this->GetAttachedActors(OutActors_temp);
			*OutActors=TArrayToMonoArray(OutActors_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 K2_TeleportTo(AActor* _this,FVector* DestLocation,FRotator* DestRotation)
		{
			bool ___ret = _this->K2_TeleportTo(*DestLocation,*DestRotation);
			return ___ret?1:0;
			
		}
		static AActor* GetParentActor(AActor* _this)
		{
			AActor* ___ret = _this->GetParentActor();
			return ___ret;
			
		}
		static UChildActorComponent* GetParentComponent(AActor* _this)
		{
			UChildActorComponent* ___ret = _this->GetParentComponent();
			return ___ret;
			
		}
		static void GetAllChildActors(AActor* _this,MonoArray** ChildActors,int32 bIncludeDescendants)
		{
			TArray<AActor*> ChildActors_temp;
			_this->GetAllChildActors(ChildActors_temp,bIncludeDescendants>0?true:false);
			*ChildActors=TArrayToMonoArray(ChildActors_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 IsChildActor(AActor* _this)
		{
			bool ___ret = _this->IsChildActor();
			return ___ret?1:0;
			
		}
		static void FlushNetDormancy(AActor* _this)
		{
			_this->FlushNetDormancy();
			
		}
		static int32 IsOverlappingActor(AActor* _this,AActor* Other)
		{
			bool ___ret = _this->IsOverlappingActor(Other);
			return ___ret?1:0;
			
		}
		static AActor* GetOwner(AActor* _this)
		{
			AActor* ___ret = _this->GetOwner();
			return ___ret;
			
		}
		static void SetOwner(AActor* _this,AActor* NewOwner)
		{
			_this->SetOwner(NewOwner);
			
		}
		static void OnRep_ReplicatedMovement(AActor* _this)
		{
			_this->OnRep_ReplicatedMovement();
			
		}
		static float GetActorTickInterval(AActor* _this)
		{
			float ___ret = _this->GetActorTickInterval();
			return ___ret;
			
		}
		static void SetActorTickInterval(AActor* _this,float TickInterval)
		{
			_this->SetActorTickInterval(TickInterval);
			
		}
		static int32 IsActorTickEnabled(AActor* _this)
		{
			bool ___ret = _this->IsActorTickEnabled();
			return ___ret?1:0;
			
		}
		static void SetActorTickEnabled(AActor* _this,int32 bEnabled)
		{
			_this->SetActorTickEnabled(bEnabled>0?true:false);
			
		}
		static float GetLifeSpan(AActor* _this)
		{
			float ___ret = _this->GetLifeSpan();
			return ___ret;
			
		}
		static void SetLifeSpan(AActor* _this,float InLifespan)
		{
			_this->SetLifeSpan(InLifespan);
			
		}
		static void GetOverlappingComponents(AActor* _this,MonoArray** OverlappingComponents)
		{
			TArray<UPrimitiveComponent*> OverlappingComponents_temp;
			_this->GetOverlappingComponents(OverlappingComponents_temp);
			*OverlappingComponents=TArrayToMonoArray(OverlappingComponents_temp,"System.IntPtr,mscorlib");
			
		}
		static void GetOverlappingActors(AActor* _this,MonoArray** OverlappingActors,TSubclassOf<AActor>  ClassFilter)
		{
			TArray<AActor*> OverlappingActors_temp;
			_this->GetOverlappingActors(OverlappingActors_temp,ClassFilter);
			*OverlappingActors=TArrayToMonoArray(OverlappingActors_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 IsActorBeingDestroyed(AActor* _this)
		{
			bool ___ret = _this->IsActorBeingDestroyed();
			return ___ret?1:0;
			
		}
		static void MakeNoise(AActor* _this,float Loudness,APawn* NoiseInstigator,FVector* NoiseLocation,float MaxRange,MonoString* Tag)
		{
			FName Tag_temp=MonoStringToFName(Tag);
			_this->MakeNoise(Loudness,NoiseInstigator,*NoiseLocation,MaxRange,Tag_temp);
			
		}
		static float GetGameTimeSinceCreation(AActor* _this)
		{
			float ___ret = _this->GetGameTimeSinceCreation();
			return ___ret;
			
		}
		static void SetTickableWhenPaused(AActor* _this,int32 bTickableWhenPaused)
		{
			_this->SetTickableWhenPaused(bTickableWhenPaused>0?true:false);
			
		}
		static int32 GetTickableWhenPaused(AActor* _this)
		{
			bool ___ret = _this->GetTickableWhenPaused();
			return ___ret?1:0;
			
		}
		static void RemoveTickPrerequisiteComponent(AActor* _this,UActorComponent* PrerequisiteComponent)
		{
			_this->RemoveTickPrerequisiteComponent(PrerequisiteComponent);
			
		}
		static void RemoveTickPrerequisiteActor(AActor* _this,AActor* PrerequisiteActor)
		{
			_this->RemoveTickPrerequisiteActor(PrerequisiteActor);
			
		}
		static void AddTickPrerequisiteComponent(AActor* _this,UActorComponent* PrerequisiteComponent)
		{
			_this->AddTickPrerequisiteComponent(PrerequisiteComponent);
			
		}
		static void AddTickPrerequisiteActor(AActor* _this,AActor* PrerequisiteActor)
		{
			_this->AddTickPrerequisiteActor(PrerequisiteActor);
			
		}
		static float GetActorTimeDilation(AActor* _this)
		{
			float ___ret = _this->GetActorTimeDilation();
			return ___ret;
			
		}
		static int32 ActorHasTag(AActor* _this,MonoString* Tag)
		{
			FName Tag_temp=MonoStringToFName(Tag);
			bool ___ret = _this->ActorHasTag(Tag_temp);
			return ___ret?1:0;
			
		}
		static void K2_DetachFromActor(AActor* _this,int32 LocationRule,int32 RotationRule,int32 ScaleRule)
		{
			_this->K2_DetachFromActor((EDetachmentRule)LocationRule,(EDetachmentRule)RotationRule,(EDetachmentRule)ScaleRule);
			
		}
		static void DetachRootComponentFromParent(AActor* _this,int32 bMaintainWorldPosition)
		{
			_this->DetachRootComponentFromParent(bMaintainWorldPosition>0?true:false);
			
		}
		static void K2_AttachToActor(AActor* _this,AActor* ParentActor,MonoString* SocketName,int32 LocationRule,int32 RotationRule,int32 ScaleRule,int32 bWeldSimulatedBodies)
		{
			FName SocketName_temp=MonoStringToFName(SocketName);
			_this->K2_AttachToActor(ParentActor,SocketName_temp,(EAttachmentRule)LocationRule,(EAttachmentRule)RotationRule,(EAttachmentRule)ScaleRule,bWeldSimulatedBodies>0?true:false);
			
		}
		static void K2_AttachRootComponentToActor(AActor* _this,AActor* InParentActor,MonoString* InSocketName,int32 AttachLocationType,int32 bWeldSimulatedBodies)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			_this->K2_AttachRootComponentToActor(InParentActor,InSocketName_temp,(TEnumAsByte<EAttachLocation::Type>)AttachLocationType,bWeldSimulatedBodies>0?true:false);
			
		}
		static void K2_AttachToComponent(AActor* _this,USceneComponent* Parent,MonoString* SocketName,int32 LocationRule,int32 RotationRule,int32 ScaleRule,int32 bWeldSimulatedBodies)
		{
			FName SocketName_temp=MonoStringToFName(SocketName);
			_this->K2_AttachToComponent(Parent,SocketName_temp,(EAttachmentRule)LocationRule,(EAttachmentRule)RotationRule,(EAttachmentRule)ScaleRule,bWeldSimulatedBodies>0?true:false);
			
		}
		static void K2_AttachRootComponentTo(AActor* _this,USceneComponent* InParent,MonoString* InSocketName,int32 AttachLocationType,int32 bWeldSimulatedBodies)
		{
			FName InSocketName_temp=MonoStringToFName(InSocketName);
			_this->K2_AttachRootComponentTo(InParent,InSocketName_temp,(TEnumAsByte<EAttachLocation::Type>)AttachLocationType,bWeldSimulatedBodies>0?true:false);
			
		}
		static UActorComponent* AddComponent(AActor* _this,MonoString* TemplateName,int32 bManualAttachment,FTransform* RelativeTransform,UObject* ComponentTemplateContext)
		{
			FName TemplateName_temp=MonoStringToFName(TemplateName);
			UActorComponent* ___ret = _this->AddComponent(TemplateName_temp,bManualAttachment>0?true:false,*RelativeTransform,ComponentTemplateContext);
			return ___ret;
			
		}
		static int32 HasAuthority(AActor* _this)
		{
			bool ___ret = _this->HasAuthority();
			return ___ret?1:0;
			
		}
		static void K2_DestroyActor(AActor* _this)
		{
			_this->K2_DestroyActor();
			
		}
		static int32 GetActorEnableCollision(AActor* _this)
		{
			bool ___ret = _this->GetActorEnableCollision();
			return ___ret?1:0;
			
		}
		static void SetActorEnableCollision(AActor* _this,int32 bNewActorEnableCollision)
		{
			_this->SetActorEnableCollision(bNewActorEnableCollision>0?true:false);
			
		}
		static void SetActorHiddenInGame(AActor* _this,int32 bNewHidden)
		{
			_this->SetActorHiddenInGame(bNewHidden>0?true:false);
			
		}
		static FVector GetActorRelativeScale3D(AActor* _this)
		{
			FVector ___ret = _this->GetActorRelativeScale3D();
			return ___ret;
			
		}
		static void SetActorRelativeScale3D(AActor* _this,FVector* NewRelativeScale)
		{
			_this->SetActorRelativeScale3D(*NewRelativeScale);
			
		}
		static void K2_SetActorRelativeTransform(AActor* _this,FTransform* NewRelativeTransform,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetActorRelativeTransform(*NewRelativeTransform,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_SetActorRelativeRotation(AActor* _this,FRotator* NewRelativeRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetActorRelativeRotation(*NewRelativeRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_SetActorRelativeLocation(AActor* _this,FVector* NewRelativeLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_SetActorRelativeLocation(*NewRelativeLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddActorLocalTransform(AActor* _this,FTransform* NewTransform,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddActorLocalTransform(*NewTransform,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddActorLocalRotation(AActor* _this,FRotator* DeltaRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddActorLocalRotation(*DeltaRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddActorLocalOffset(AActor* _this,FVector* DeltaLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddActorLocalOffset(*DeltaLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static int32 K2_SetActorTransform(AActor* _this,FTransform* NewTransform,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			bool ___ret = _this->K2_SetActorTransform(*NewTransform,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			return ___ret?1:0;
			
		}
		static void K2_AddActorWorldTransform(AActor* _this,FTransform* DeltaTransform,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddActorWorldTransform(*DeltaTransform,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddActorWorldRotation(AActor* _this,FRotator* DeltaRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddActorWorldRotation(*DeltaRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static void K2_AddActorWorldOffset(AActor* _this,FVector* DeltaLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			_this->K2_AddActorWorldOffset(*DeltaLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			
		}
		static float GetHorizontalDotProductTo(AActor* _this,AActor* OtherActor)
		{
			float ___ret = _this->GetHorizontalDotProductTo(OtherActor);
			return ___ret;
			
		}
		static float GetDotProductTo(AActor* _this,AActor* OtherActor)
		{
			float ___ret = _this->GetDotProductTo(OtherActor);
			return ___ret;
			
		}
		static float GetVerticalDistanceTo(AActor* _this,AActor* OtherActor)
		{
			float ___ret = _this->GetVerticalDistanceTo(OtherActor);
			return ___ret;
			
		}
		static float GetHorizontalDistanceTo(AActor* _this,AActor* OtherActor)
		{
			float ___ret = _this->GetHorizontalDistanceTo(OtherActor);
			return ___ret;
			
		}
		static float GetSquaredDistanceTo(AActor* _this,AActor* OtherActor)
		{
			float ___ret = _this->GetSquaredDistanceTo(OtherActor);
			return ___ret;
			
		}
		static float GetDistanceTo(AActor* _this,AActor* OtherActor)
		{
			float ___ret = _this->GetDistanceTo(OtherActor);
			return ___ret;
			
		}
		static FVector GetActorScale3D(AActor* _this)
		{
			FVector ___ret = _this->GetActorScale3D();
			return ___ret;
			
		}
		static void SetActorScale3D(AActor* _this,FVector* NewScale3D)
		{
			_this->SetActorScale3D(*NewScale3D);
			
		}
		static int32 K2_SetActorLocationAndRotation(AActor* _this,FVector* NewLocation,FRotator* NewRotation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			bool ___ret = _this->K2_SetActorLocationAndRotation(*NewLocation,*NewRotation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 K2_SetActorRotation(AActor* _this,FRotator* NewRotation,int32 bTeleportPhysics)
		{
			bool ___ret = _this->K2_SetActorRotation(*NewRotation,bTeleportPhysics>0?true:false);
			return ___ret?1:0;
			
		}
		static FVector GetVelocity(AActor* _this)
		{
			FVector ___ret = _this->GetVelocity();
			return ___ret;
			
		}
		static USceneComponent* K2_GetRootComponent(AActor* _this)
		{
			USceneComponent* ___ret = _this->K2_GetRootComponent();
			return ___ret;
			
		}
		static void GetActorBounds(AActor* _this,int32 bOnlyCollidingComponents,FVector* Origin,FVector* BoxExtent)
		{
			_this->GetActorBounds(bOnlyCollidingComponents>0?true:false,*Origin,*BoxExtent);
			
		}
		static FVector GetActorRightVector(AActor* _this)
		{
			FVector ___ret = _this->GetActorRightVector();
			return ___ret;
			
		}
		static FVector GetActorUpVector(AActor* _this)
		{
			FVector ___ret = _this->GetActorUpVector();
			return ___ret;
			
		}
		static FVector GetActorForwardVector(AActor* _this)
		{
			FVector ___ret = _this->GetActorForwardVector();
			return ___ret;
			
		}
		static FRotator K2_GetActorRotation(AActor* _this)
		{
			FRotator ___ret = _this->K2_GetActorRotation();
			return ___ret;
			
		}
		static int32 K2_SetActorLocation(AActor* _this,FVector* NewLocation,int32 bSweep,FHitResult* SweepHitResult,int32 bTeleport)
		{
			bool ___ret = _this->K2_SetActorLocation(*NewLocation,bSweep>0?true:false,*SweepHitResult,bTeleport>0?true:false);
			return ___ret?1:0;
			
		}
		static FVector K2_GetActorLocation(AActor* _this)
		{
			FVector ___ret = _this->K2_GetActorLocation();
			return ___ret;
			
		}
		static FTransform GetTransform(AActor* _this)
		{
			FTransform ___ret = _this->GetTransform();
			return ___ret;
			
		}
		static AController* GetInstigatorController(AActor* _this)
		{
			AController* ___ret = _this->GetInstigatorController();
			return ___ret;
			
		}
		static APawn* GetInstigator(AActor* _this)
		{
			APawn* ___ret = _this->GetInstigator();
			return ___ret;
			
		}
		static FVector GetInputVectorAxisValue(AActor* _this,FKey* InputAxisKey)
		{
			FVector ___ret = _this->GetInputVectorAxisValue(*InputAxisKey);
			return ___ret;
			
		}
		static float GetInputAxisKeyValue(AActor* _this,FKey* InputAxisKey)
		{
			float ___ret = _this->GetInputAxisKeyValue(*InputAxisKey);
			return ___ret;
			
		}
		static float GetInputAxisValue(AActor* _this,MonoString* InputAxisName)
		{
			FName InputAxisName_temp=MonoStringToFName(InputAxisName);
			float ___ret = _this->GetInputAxisValue(InputAxisName_temp);
			return ___ret;
			
		}
		static void DisableInput(AActor* _this,APlayerController* PlayerController)
		{
			_this->DisableInput(PlayerController);
			
		}
		static void EnableInput(AActor* _this,APlayerController* PlayerController)
		{
			_this->EnableInput(PlayerController);
			
		}
		static void OnRep_Instigator(AActor* _this)
		{
			_this->OnRep_Instigator();
			
		}
		static void OnRep_AttachmentReplication(AActor* _this)
		{
			_this->OnRep_AttachmentReplication();
			
		}
		static int32 GetRemoteRole(AActor* _this)
		{
			TEnumAsByte<ENetRole> ___ret = _this->GetRemoteRole();
			return (int)___ret;
			
		}
		static void SetReplicateMovement(AActor* _this,int32 bInReplicateMovement)
		{
			_this->SetReplicateMovement(bInReplicateMovement>0?true:false);
			
		}
		static void SetReplicates(AActor* _this,int32 bInReplicates)
		{
			_this->SetReplicates(bInReplicates>0?true:false);
			
		}
		static void TearOff(AActor* _this)
		{
			_this->TearOff();
			
		}
		static void OnRep_ReplicateMovement(AActor* _this)
		{
			_this->OnRep_ReplicateMovement();
			
		}
		static UClass* StaticClass(){return AActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AActor::GetComponentsByTag",(const void*)GetComponentsByTag);
			mono_add_internal_call("UnrealEngine.AActor::GetComponentsByClass",(const void*)GetComponentsByClass);
			mono_add_internal_call("UnrealEngine.AActor::GetComponentByClass",(const void*)GetComponentByClass);
			mono_add_internal_call("UnrealEngine.AActor::GetActorEyesViewPoint",(const void*)GetActorEyesViewPoint);
			mono_add_internal_call("UnrealEngine.AActor::ForceNetUpdate",(const void*)ForceNetUpdate);
			mono_add_internal_call("UnrealEngine.AActor::WasRecentlyRendered",(const void*)WasRecentlyRendered);
			mono_add_internal_call("UnrealEngine.AActor::SetTickGroup",(const void*)SetTickGroup);
			mono_add_internal_call("UnrealEngine.AActor::GetAttachedActors",(const void*)GetAttachedActors);
			mono_add_internal_call("UnrealEngine.AActor::K2_TeleportTo",(const void*)K2_TeleportTo);
			mono_add_internal_call("UnrealEngine.AActor::GetParentActor",(const void*)GetParentActor);
			mono_add_internal_call("UnrealEngine.AActor::GetParentComponent",(const void*)GetParentComponent);
			mono_add_internal_call("UnrealEngine.AActor::GetAllChildActors",(const void*)GetAllChildActors);
			mono_add_internal_call("UnrealEngine.AActor::IsChildActor",(const void*)IsChildActor);
			mono_add_internal_call("UnrealEngine.AActor::FlushNetDormancy",(const void*)FlushNetDormancy);
			mono_add_internal_call("UnrealEngine.AActor::IsOverlappingActor",(const void*)IsOverlappingActor);
			mono_add_internal_call("UnrealEngine.AActor::GetOwner",(const void*)GetOwner);
			mono_add_internal_call("UnrealEngine.AActor::SetOwner",(const void*)SetOwner);
			mono_add_internal_call("UnrealEngine.AActor::OnRep_ReplicatedMovement",(const void*)OnRep_ReplicatedMovement);
			mono_add_internal_call("UnrealEngine.AActor::GetActorTickInterval",(const void*)GetActorTickInterval);
			mono_add_internal_call("UnrealEngine.AActor::SetActorTickInterval",(const void*)SetActorTickInterval);
			mono_add_internal_call("UnrealEngine.AActor::IsActorTickEnabled",(const void*)IsActorTickEnabled);
			mono_add_internal_call("UnrealEngine.AActor::SetActorTickEnabled",(const void*)SetActorTickEnabled);
			mono_add_internal_call("UnrealEngine.AActor::GetLifeSpan",(const void*)GetLifeSpan);
			mono_add_internal_call("UnrealEngine.AActor::SetLifeSpan",(const void*)SetLifeSpan);
			mono_add_internal_call("UnrealEngine.AActor::GetOverlappingComponents",(const void*)GetOverlappingComponents);
			mono_add_internal_call("UnrealEngine.AActor::GetOverlappingActors",(const void*)GetOverlappingActors);
			mono_add_internal_call("UnrealEngine.AActor::IsActorBeingDestroyed",(const void*)IsActorBeingDestroyed);
			mono_add_internal_call("UnrealEngine.AActor::MakeNoise",(const void*)MakeNoise);
			mono_add_internal_call("UnrealEngine.AActor::GetGameTimeSinceCreation",(const void*)GetGameTimeSinceCreation);
			mono_add_internal_call("UnrealEngine.AActor::SetTickableWhenPaused",(const void*)SetTickableWhenPaused);
			mono_add_internal_call("UnrealEngine.AActor::GetTickableWhenPaused",(const void*)GetTickableWhenPaused);
			mono_add_internal_call("UnrealEngine.AActor::RemoveTickPrerequisiteComponent",(const void*)RemoveTickPrerequisiteComponent);
			mono_add_internal_call("UnrealEngine.AActor::RemoveTickPrerequisiteActor",(const void*)RemoveTickPrerequisiteActor);
			mono_add_internal_call("UnrealEngine.AActor::AddTickPrerequisiteComponent",(const void*)AddTickPrerequisiteComponent);
			mono_add_internal_call("UnrealEngine.AActor::AddTickPrerequisiteActor",(const void*)AddTickPrerequisiteActor);
			mono_add_internal_call("UnrealEngine.AActor::GetActorTimeDilation",(const void*)GetActorTimeDilation);
			mono_add_internal_call("UnrealEngine.AActor::ActorHasTag",(const void*)ActorHasTag);
			mono_add_internal_call("UnrealEngine.AActor::K2_DetachFromActor",(const void*)K2_DetachFromActor);
			mono_add_internal_call("UnrealEngine.AActor::DetachRootComponentFromParent",(const void*)DetachRootComponentFromParent);
			mono_add_internal_call("UnrealEngine.AActor::K2_AttachToActor",(const void*)K2_AttachToActor);
			mono_add_internal_call("UnrealEngine.AActor::K2_AttachRootComponentToActor",(const void*)K2_AttachRootComponentToActor);
			mono_add_internal_call("UnrealEngine.AActor::K2_AttachToComponent",(const void*)K2_AttachToComponent);
			mono_add_internal_call("UnrealEngine.AActor::K2_AttachRootComponentTo",(const void*)K2_AttachRootComponentTo);
			mono_add_internal_call("UnrealEngine.AActor::AddComponent",(const void*)AddComponent);
			mono_add_internal_call("UnrealEngine.AActor::HasAuthority",(const void*)HasAuthority);
			mono_add_internal_call("UnrealEngine.AActor::K2_DestroyActor",(const void*)K2_DestroyActor);
			mono_add_internal_call("UnrealEngine.AActor::GetActorEnableCollision",(const void*)GetActorEnableCollision);
			mono_add_internal_call("UnrealEngine.AActor::SetActorEnableCollision",(const void*)SetActorEnableCollision);
			mono_add_internal_call("UnrealEngine.AActor::SetActorHiddenInGame",(const void*)SetActorHiddenInGame);
			mono_add_internal_call("UnrealEngine.AActor::GetActorRelativeScale3D",(const void*)GetActorRelativeScale3D);
			mono_add_internal_call("UnrealEngine.AActor::SetActorRelativeScale3D",(const void*)SetActorRelativeScale3D);
			mono_add_internal_call("UnrealEngine.AActor::K2_SetActorRelativeTransform",(const void*)K2_SetActorRelativeTransform);
			mono_add_internal_call("UnrealEngine.AActor::K2_SetActorRelativeRotation",(const void*)K2_SetActorRelativeRotation);
			mono_add_internal_call("UnrealEngine.AActor::K2_SetActorRelativeLocation",(const void*)K2_SetActorRelativeLocation);
			mono_add_internal_call("UnrealEngine.AActor::K2_AddActorLocalTransform",(const void*)K2_AddActorLocalTransform);
			mono_add_internal_call("UnrealEngine.AActor::K2_AddActorLocalRotation",(const void*)K2_AddActorLocalRotation);
			mono_add_internal_call("UnrealEngine.AActor::K2_AddActorLocalOffset",(const void*)K2_AddActorLocalOffset);
			mono_add_internal_call("UnrealEngine.AActor::K2_SetActorTransform",(const void*)K2_SetActorTransform);
			mono_add_internal_call("UnrealEngine.AActor::K2_AddActorWorldTransform",(const void*)K2_AddActorWorldTransform);
			mono_add_internal_call("UnrealEngine.AActor::K2_AddActorWorldRotation",(const void*)K2_AddActorWorldRotation);
			mono_add_internal_call("UnrealEngine.AActor::K2_AddActorWorldOffset",(const void*)K2_AddActorWorldOffset);
			mono_add_internal_call("UnrealEngine.AActor::GetHorizontalDotProductTo",(const void*)GetHorizontalDotProductTo);
			mono_add_internal_call("UnrealEngine.AActor::GetDotProductTo",(const void*)GetDotProductTo);
			mono_add_internal_call("UnrealEngine.AActor::GetVerticalDistanceTo",(const void*)GetVerticalDistanceTo);
			mono_add_internal_call("UnrealEngine.AActor::GetHorizontalDistanceTo",(const void*)GetHorizontalDistanceTo);
			mono_add_internal_call("UnrealEngine.AActor::GetSquaredDistanceTo",(const void*)GetSquaredDistanceTo);
			mono_add_internal_call("UnrealEngine.AActor::GetDistanceTo",(const void*)GetDistanceTo);
			mono_add_internal_call("UnrealEngine.AActor::GetActorScale3D",(const void*)GetActorScale3D);
			mono_add_internal_call("UnrealEngine.AActor::SetActorScale3D",(const void*)SetActorScale3D);
			mono_add_internal_call("UnrealEngine.AActor::K2_SetActorLocationAndRotation",(const void*)K2_SetActorLocationAndRotation);
			mono_add_internal_call("UnrealEngine.AActor::K2_SetActorRotation",(const void*)K2_SetActorRotation);
			mono_add_internal_call("UnrealEngine.AActor::GetVelocity",(const void*)GetVelocity);
			mono_add_internal_call("UnrealEngine.AActor::K2_GetRootComponent",(const void*)K2_GetRootComponent);
			mono_add_internal_call("UnrealEngine.AActor::GetActorBounds",(const void*)GetActorBounds);
			mono_add_internal_call("UnrealEngine.AActor::GetActorRightVector",(const void*)GetActorRightVector);
			mono_add_internal_call("UnrealEngine.AActor::GetActorUpVector",(const void*)GetActorUpVector);
			mono_add_internal_call("UnrealEngine.AActor::GetActorForwardVector",(const void*)GetActorForwardVector);
			mono_add_internal_call("UnrealEngine.AActor::K2_GetActorRotation",(const void*)K2_GetActorRotation);
			mono_add_internal_call("UnrealEngine.AActor::K2_SetActorLocation",(const void*)K2_SetActorLocation);
			mono_add_internal_call("UnrealEngine.AActor::K2_GetActorLocation",(const void*)K2_GetActorLocation);
			mono_add_internal_call("UnrealEngine.AActor::GetTransform",(const void*)GetTransform);
			mono_add_internal_call("UnrealEngine.AActor::GetInstigatorController",(const void*)GetInstigatorController);
			mono_add_internal_call("UnrealEngine.AActor::GetInstigator",(const void*)GetInstigator);
			mono_add_internal_call("UnrealEngine.AActor::GetInputVectorAxisValue",(const void*)GetInputVectorAxisValue);
			mono_add_internal_call("UnrealEngine.AActor::GetInputAxisKeyValue",(const void*)GetInputAxisKeyValue);
			mono_add_internal_call("UnrealEngine.AActor::GetInputAxisValue",(const void*)GetInputAxisValue);
			mono_add_internal_call("UnrealEngine.AActor::DisableInput",(const void*)DisableInput);
			mono_add_internal_call("UnrealEngine.AActor::EnableInput",(const void*)EnableInput);
			mono_add_internal_call("UnrealEngine.AActor::OnRep_Instigator",(const void*)OnRep_Instigator);
			mono_add_internal_call("UnrealEngine.AActor::OnRep_AttachmentReplication",(const void*)OnRep_AttachmentReplication);
			mono_add_internal_call("UnrealEngine.AActor::GetRemoteRole",(const void*)GetRemoteRole);
			mono_add_internal_call("UnrealEngine.AActor::SetReplicateMovement",(const void*)SetReplicateMovement);
			mono_add_internal_call("UnrealEngine.AActor::SetReplicates",(const void*)SetReplicates);
			mono_add_internal_call("UnrealEngine.AActor::TearOff",(const void*)TearOff);
			mono_add_internal_call("UnrealEngine.AActor::OnRep_ReplicateMovement",(const void*)OnRep_ReplicateMovement);
			mono_add_internal_call("UnrealEngine.AActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
