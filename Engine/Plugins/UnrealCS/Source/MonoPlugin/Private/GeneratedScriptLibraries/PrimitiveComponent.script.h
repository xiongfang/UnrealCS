#pragma once

namespace UnrealEngine
{
	class _UPrimitiveComponent
	{
		static int32 CanCharacterStepUp(UPrimitiveComponent* _this,APawn* Pawn)
		{
			bool ___ret = _this->CanCharacterStepUp(Pawn);
			return ___ret?1:0;
			
		}
		static void SetCullDistance(UPrimitiveComponent* _this,float NewCullDistance)
		{
			_this->SetCullDistance(NewCullDistance);
			
		}
		static void SetPhysMaterialOverride(UPrimitiveComponent* _this,UPhysicalMaterial* NewPhysMaterial)
		{
			_this->SetPhysMaterialOverride(NewPhysMaterial);
			
		}
		static void SetCollisionResponseToAllChannels(UPrimitiveComponent* _this,int32 NewResponse)
		{
			_this->SetCollisionResponseToAllChannels((TEnumAsByte<ECollisionResponse>)NewResponse);
			
		}
		static void SetCollisionResponseToChannel(UPrimitiveComponent* _this,int32 Channel,int32 NewResponse)
		{
			_this->SetCollisionResponseToChannel((TEnumAsByte<ECollisionChannel>)Channel,(TEnumAsByte<ECollisionResponse>)NewResponse);
			
		}
		static int32 IsAnyRigidBodyAwake(UPrimitiveComponent* _this)
		{
			bool ___ret = _this->IsAnyRigidBodyAwake();
			return ___ret?1:0;
			
		}
		static FVector ScaleByMomentOfInertia(UPrimitiveComponent* _this,FVector* InputVector,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FVector ___ret = _this->ScaleByMomentOfInertia(*InputVector,BoneName_temp);
			return ___ret;
			
		}
		static FVector GetInertiaTensor(UPrimitiveComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FVector ___ret = _this->GetInertiaTensor(BoneName_temp);
			return ___ret;
			
		}
		static float GetMass(UPrimitiveComponent* _this)
		{
			float ___ret = _this->GetMass();
			return ___ret;
			
		}
		static void SetMassOverrideInKg(UPrimitiveComponent* _this,MonoString* BoneName,float MassInKg,int32 bOverrideMass)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetMassOverrideInKg(BoneName_temp,MassInKg,bOverrideMass>0?true:false);
			
		}
		static void SetAllMassScale(UPrimitiveComponent* _this,float InMassScale)
		{
			_this->SetAllMassScale(InMassScale);
			
		}
		static float GetMassScale(UPrimitiveComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			float ___ret = _this->GetMassScale(BoneName_temp);
			return ___ret;
			
		}
		static void SetMassScale(UPrimitiveComponent* _this,MonoString* BoneName,float InMassScale)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetMassScale(BoneName_temp,InMassScale);
			
		}
		static float GetAngularDamping(UPrimitiveComponent* _this)
		{
			float ___ret = _this->GetAngularDamping();
			return ___ret;
			
		}
		static void SetAngularDamping(UPrimitiveComponent* _this,float InDamping)
		{
			_this->SetAngularDamping(InDamping);
			
		}
		static float GetLinearDamping(UPrimitiveComponent* _this)
		{
			float ___ret = _this->GetLinearDamping();
			return ___ret;
			
		}
		static void SetLinearDamping(UPrimitiveComponent* _this,float InDamping)
		{
			_this->SetLinearDamping(InDamping);
			
		}
		static int32 IsGravityEnabled(UPrimitiveComponent* _this)
		{
			bool ___ret = _this->IsGravityEnabled();
			return ___ret?1:0;
			
		}
		static void SetEnableGravity(UPrimitiveComponent* _this,int32 bGravityEnabled)
		{
			_this->SetEnableGravity(bGravityEnabled>0?true:false);
			
		}
		static void WakeAllRigidBodies(UPrimitiveComponent* _this)
		{
			_this->WakeAllRigidBodies();
			
		}
		static int32 GetCollisionObjectType(UPrimitiveComponent* _this)
		{
			TEnumAsByte<ECollisionChannel> ___ret = _this->GetCollisionObjectType();
			return (int)___ret;
			
		}
		static int32 GetCollisionResponseToChannel(UPrimitiveComponent* _this,int32 Channel)
		{
			TEnumAsByte<ECollisionResponse> ___ret = _this->GetCollisionResponseToChannel((TEnumAsByte<ECollisionChannel>)Channel);
			return (int)___ret;
			
		}
		static int32 K2_IsPhysicsCollisionEnabled(UPrimitiveComponent* _this)
		{
			bool ___ret = _this->K2_IsPhysicsCollisionEnabled();
			return ___ret?1:0;
			
		}
		static int32 K2_IsQueryCollisionEnabled(UPrimitiveComponent* _this)
		{
			bool ___ret = _this->K2_IsQueryCollisionEnabled();
			return ___ret?1:0;
			
		}
		static int32 K2_IsCollisionEnabled(UPrimitiveComponent* _this)
		{
			bool ___ret = _this->K2_IsCollisionEnabled();
			return ___ret?1:0;
			
		}
		static int32 GetCollisionEnabled(UPrimitiveComponent* _this)
		{
			TEnumAsByte<ECollisionEnabled::Type> ___ret = _this->GetCollisionEnabled();
			return (int)___ret;
			
		}
		static float GetClosestPointOnCollision(UPrimitiveComponent* _this,FVector* Point,FVector* OutPointOnBody,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			float ___ret = _this->GetClosestPointOnCollision(*Point,*OutPointOnBody,BoneName_temp);
			return ___ret;
			
		}
		static int32 GetNumMaterials(UPrimitiveComponent* _this)
		{
			int32 ___ret = _this->GetNumMaterials();
			return ___ret;
			
		}
		static void SetRenderInMainPass(UPrimitiveComponent* _this,int32 bValue)
		{
			_this->SetRenderInMainPass(bValue>0?true:false);
			
		}
		static void SetCustomDepthStencilValue(UPrimitiveComponent* _this,int32 Value)
		{
			_this->SetCustomDepthStencilValue(Value);
			
		}
		static void SetRenderCustomDepth(UPrimitiveComponent* _this,int32 bValue)
		{
			_this->SetRenderCustomDepth(bValue>0?true:false);
			
		}
		static int32 K2_LineTraceComponent(UPrimitiveComponent* _this,FVector* TraceStart,FVector* TraceEnd,int32 bTraceComplex,int32 bShowTrace,FVector* HitLocation,FVector* HitNormal,MonoString** BoneName)
		{
			FName BoneName_temp;
			bool ___ret = _this->K2_LineTraceComponent(*TraceStart,*TraceEnd,bTraceComplex>0?true:false,bShowTrace>0?true:false,*HitLocation,*HitNormal,BoneName_temp);
			return ___ret?1:0;
			*BoneName=FNameToMonoString(BoneName_temp);
			
		}
		static void SetCollisionObjectType(UPrimitiveComponent* _this,int32 Channel)
		{
			_this->SetCollisionObjectType((TEnumAsByte<ECollisionChannel>)Channel);
			
		}
		static MonoString* GetCollisionProfileName(UPrimitiveComponent* _this)
		{
			FName ___ret = _this->GetCollisionProfileName();
			return FNameToMonoString(___ret);
			
		}
		static void SetCollisionProfileName(UPrimitiveComponent* _this,MonoString* InCollisionProfileName)
		{
			FName InCollisionProfileName_temp=MonoStringToFName(InCollisionProfileName);
			_this->SetCollisionProfileName(InCollisionProfileName_temp);
			
		}
		static void SetCollisionEnabled(UPrimitiveComponent* _this,int32 NewType)
		{
			_this->SetCollisionEnabled((TEnumAsByte<ECollisionEnabled::Type>)NewType);
			
		}
		static void SetTranslucentSortPriority(UPrimitiveComponent* _this,int32 NewTranslucentSortPriority)
		{
			_this->SetTranslucentSortPriority(NewTranslucentSortPriority);
			
		}
		static void SetCastShadow(UPrimitiveComponent* _this,int32 NewCastShadow)
		{
			_this->SetCastShadow(NewCastShadow>0?true:false);
			
		}
		static void SetOnlyOwnerSee(UPrimitiveComponent* _this,int32 bNewOnlyOwnerSee)
		{
			_this->SetOnlyOwnerSee(bNewOnlyOwnerSee>0?true:false);
			
		}
		static void SetOwnerNoSee(UPrimitiveComponent* _this,int32 bNewOwnerNoSee)
		{
			_this->SetOwnerNoSee(bNewOwnerNoSee>0?true:false);
			
		}
		static void SetNotifyRigidBodyCollision(UPrimitiveComponent* _this,int32 bNewNotifyRigidBodyCollision)
		{
			_this->SetNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision>0?true:false);
			
		}
		static void PutRigidBodyToSleep(UPrimitiveComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->PutRigidBodyToSleep(BoneName_temp);
			
		}
		static void WakeRigidBody(UPrimitiveComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->WakeRigidBody(BoneName_temp);
			
		}
		static void SetCenterOfMass(UPrimitiveComponent* _this,FVector* CenterOfMassOffset,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetCenterOfMass(*CenterOfMassOffset,BoneName_temp);
			
		}
		static FVector GetCenterOfMass(UPrimitiveComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FVector ___ret = _this->GetCenterOfMass(BoneName_temp);
			return ___ret;
			
		}
		static FVector GetPhysicsAngularVelocity(UPrimitiveComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FVector ___ret = _this->GetPhysicsAngularVelocity(BoneName_temp);
			return ___ret;
			
		}
		static void SetPhysicsMaxAngularVelocity(UPrimitiveComponent* _this,float NewMaxAngVel,int32 bAddToCurrent,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetPhysicsMaxAngularVelocity(NewMaxAngVel,bAddToCurrent>0?true:false,BoneName_temp);
			
		}
		static void SetPhysicsAngularVelocity(UPrimitiveComponent* _this,FVector* NewAngVel,int32 bAddToCurrent,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetPhysicsAngularVelocity(*NewAngVel,bAddToCurrent>0?true:false,BoneName_temp);
			
		}
		static void SetAllPhysicsLinearVelocity(UPrimitiveComponent* _this,FVector* NewVel,int32 bAddToCurrent)
		{
			_this->SetAllPhysicsLinearVelocity(*NewVel,bAddToCurrent>0?true:false);
			
		}
		static FVector GetPhysicsLinearVelocityAtPoint(UPrimitiveComponent* _this,FVector* Point,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FVector ___ret = _this->GetPhysicsLinearVelocityAtPoint(*Point,BoneName_temp);
			return ___ret;
			
		}
		static FVector GetPhysicsLinearVelocity(UPrimitiveComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			FVector ___ret = _this->GetPhysicsLinearVelocity(BoneName_temp);
			return ___ret;
			
		}
		static void SetPhysicsLinearVelocity(UPrimitiveComponent* _this,FVector* NewVel,int32 bAddToCurrent,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetPhysicsLinearVelocity(*NewVel,bAddToCurrent>0?true:false,BoneName_temp);
			
		}
		static void AddTorque(UPrimitiveComponent* _this,FVector* Torque,MonoString* BoneName,int32 bAccelChange)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->AddTorque(*Torque,BoneName_temp,bAccelChange>0?true:false);
			
		}
		static void AddRadialForce(UPrimitiveComponent* _this,FVector* Origin,float Radius,float Strength,int32 Falloff,int32 bAccelChange)
		{
			_this->AddRadialForce(*Origin,Radius,Strength,(TEnumAsByte<ERadialImpulseFalloff>)Falloff,bAccelChange>0?true:false);
			
		}
		static void AddForceAtLocation(UPrimitiveComponent* _this,FVector* Force,FVector* Location,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->AddForceAtLocation(*Force,*Location,BoneName_temp);
			
		}
		static void AddForce(UPrimitiveComponent* _this,FVector* Force,MonoString* BoneName,int32 bAccelChange)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->AddForce(*Force,BoneName_temp,bAccelChange>0?true:false);
			
		}
		static void AddRadialImpulse(UPrimitiveComponent* _this,FVector* Origin,float Radius,float Strength,int32 Falloff,int32 bVelChange)
		{
			_this->AddRadialImpulse(*Origin,Radius,Strength,(TEnumAsByte<ERadialImpulseFalloff>)Falloff,bVelChange>0?true:false);
			
		}
		static void AddImpulseAtLocation(UPrimitiveComponent* _this,FVector* Impulse,FVector* Location,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->AddImpulseAtLocation(*Impulse,*Location,BoneName_temp);
			
		}
		static void AddAngularImpulse(UPrimitiveComponent* _this,FVector* Impulse,MonoString* BoneName,int32 bVelChange)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->AddAngularImpulse(*Impulse,BoneName_temp,bVelChange>0?true:false);
			
		}
		static void AddImpulse(UPrimitiveComponent* _this,FVector* Impulse,MonoString* BoneName,int32 bVelChange)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->AddImpulse(*Impulse,BoneName_temp,bVelChange>0?true:false);
			
		}
		static void SetConstraintMode(UPrimitiveComponent* _this,int32 ConstraintMode)
		{
			_this->SetConstraintMode((TEnumAsByte<EDOFMode::Type>)ConstraintMode);
			
		}
		static void SetSimulatePhysics(UPrimitiveComponent* _this,int32 bSimulate)
		{
			_this->SetSimulatePhysics(bSimulate>0?true:false);
			
		}
		static void SetWalkableSlopeOverride(UPrimitiveComponent* _this,FWalkableSlopeOverride* NewOverride)
		{
			_this->SetWalkableSlopeOverride(*NewOverride);
			
		}
		static FWalkableSlopeOverride GetWalkableSlopeOverride(UPrimitiveComponent* _this)
		{
			FWalkableSlopeOverride ___ret = _this->GetWalkableSlopeOverride();
			return ___ret;
			
		}
		static UMaterialInstanceDynamic* CreateDynamicMaterialInstance(UPrimitiveComponent* _this,int32 ElementIndex,UMaterialInterface* SourceMaterial)
		{
			UMaterialInstanceDynamic* ___ret = _this->CreateDynamicMaterialInstance(ElementIndex,SourceMaterial);
			return ___ret;
			
		}
		static void SetMaterialByName(UPrimitiveComponent* _this,MonoString* MaterialSlotName,UMaterialInterface* Material)
		{
			FName MaterialSlotName_temp=MonoStringToFName(MaterialSlotName);
			_this->SetMaterialByName(MaterialSlotName_temp,Material);
			
		}
		static void SetMaterial(UPrimitiveComponent* _this,int32 ElementIndex,UMaterialInterface* Material)
		{
			_this->SetMaterial(ElementIndex,Material);
			
		}
		static UMaterialInterface* GetMaterial(UPrimitiveComponent* _this,int32 ElementIndex)
		{
			UMaterialInterface* ___ret = _this->GetMaterial(ElementIndex);
			return ___ret;
			
		}
		static void SetBoundsScale(UPrimitiveComponent* _this,float NewBoundsScale)
		{
			_this->SetBoundsScale(NewBoundsScale);
			
		}
		static MonoArray* GetOverlapInfos(UPrimitiveComponent* _this)
		{
			TArray<FOverlapInfo> ___ret = _this->GetOverlapInfos();
			return TArrayToMonoArray(___ret,"UnrealEngine.FOverlapInfo,UnrealEngine");
			
		}
		static void GetOverlappingComponents(UPrimitiveComponent* _this,MonoArray** InOverlappingComponents)
		{
			TArray<UPrimitiveComponent*> InOverlappingComponents_temp;
			_this->GetOverlappingComponents(InOverlappingComponents_temp);
			*InOverlappingComponents=TArrayToMonoArray(InOverlappingComponents_temp,"System.IntPtr,mscorlib");
			
		}
		static void GetOverlappingActors(UPrimitiveComponent* _this,MonoArray** OverlappingActors,TSubclassOf<AActor>  ClassFilter)
		{
			TArray<AActor*> OverlappingActors_temp;
			_this->GetOverlappingActors(OverlappingActors_temp,ClassFilter);
			*OverlappingActors=TArrayToMonoArray(OverlappingActors_temp,"System.IntPtr,mscorlib");
			
		}
		static int32 IsOverlappingActor(UPrimitiveComponent* _this,AActor* Other)
		{
			bool ___ret = _this->IsOverlappingActor(Other);
			return ___ret?1:0;
			
		}
		static int32 IsOverlappingComponent(UPrimitiveComponent* _this,UPrimitiveComponent* OtherComp)
		{
			bool ___ret = _this->IsOverlappingComponent(OtherComp);
			return ___ret?1:0;
			
		}
		static void ClearMoveIgnoreComponents(UPrimitiveComponent* _this)
		{
			_this->ClearMoveIgnoreComponents();
			
		}
		static MonoArray* CopyArrayOfMoveIgnoreComponents(UPrimitiveComponent* _this)
		{
			TArray<UPrimitiveComponent*> ___ret = _this->CopyArrayOfMoveIgnoreComponents();
			return TArrayToMonoArray(___ret,"System.IntPtr,mscorlib");
			
		}
		static void IgnoreComponentWhenMoving(UPrimitiveComponent* _this,UPrimitiveComponent* Component,int32 bShouldIgnore)
		{
			_this->IgnoreComponentWhenMoving(Component,bShouldIgnore>0?true:false);
			
		}
		static void ClearMoveIgnoreActors(UPrimitiveComponent* _this)
		{
			_this->ClearMoveIgnoreActors();
			
		}
		static MonoArray* CopyArrayOfMoveIgnoreActors(UPrimitiveComponent* _this)
		{
			TArray<AActor*> ___ret = _this->CopyArrayOfMoveIgnoreActors();
			return TArrayToMonoArray(___ret,"System.IntPtr,mscorlib");
			
		}
		static void IgnoreActorWhenMoving(UPrimitiveComponent* _this,AActor* Actor,int32 bShouldIgnore)
		{
			_this->IgnoreActorWhenMoving(Actor,bShouldIgnore>0?true:false);
			
		}
		static UClass* StaticClass(){return UPrimitiveComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::CanCharacterStepUp",(const void*)CanCharacterStepUp);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCullDistance",(const void*)SetCullDistance);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetPhysMaterialOverride",(const void*)SetPhysMaterialOverride);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCollisionResponseToAllChannels",(const void*)SetCollisionResponseToAllChannels);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCollisionResponseToChannel",(const void*)SetCollisionResponseToChannel);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::IsAnyRigidBodyAwake",(const void*)IsAnyRigidBodyAwake);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::ScaleByMomentOfInertia",(const void*)ScaleByMomentOfInertia);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetInertiaTensor",(const void*)GetInertiaTensor);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetMass",(const void*)GetMass);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetMassOverrideInKg",(const void*)SetMassOverrideInKg);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetAllMassScale",(const void*)SetAllMassScale);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetMassScale",(const void*)GetMassScale);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetMassScale",(const void*)SetMassScale);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetAngularDamping",(const void*)GetAngularDamping);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetAngularDamping",(const void*)SetAngularDamping);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetLinearDamping",(const void*)GetLinearDamping);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetLinearDamping",(const void*)SetLinearDamping);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::IsGravityEnabled",(const void*)IsGravityEnabled);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetEnableGravity",(const void*)SetEnableGravity);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::WakeAllRigidBodies",(const void*)WakeAllRigidBodies);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetCollisionObjectType",(const void*)GetCollisionObjectType);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetCollisionResponseToChannel",(const void*)GetCollisionResponseToChannel);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::K2_IsPhysicsCollisionEnabled",(const void*)K2_IsPhysicsCollisionEnabled);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::K2_IsQueryCollisionEnabled",(const void*)K2_IsQueryCollisionEnabled);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::K2_IsCollisionEnabled",(const void*)K2_IsCollisionEnabled);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetCollisionEnabled",(const void*)GetCollisionEnabled);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetClosestPointOnCollision",(const void*)GetClosestPointOnCollision);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetNumMaterials",(const void*)GetNumMaterials);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetRenderInMainPass",(const void*)SetRenderInMainPass);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCustomDepthStencilValue",(const void*)SetCustomDepthStencilValue);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetRenderCustomDepth",(const void*)SetRenderCustomDepth);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::K2_LineTraceComponent",(const void*)K2_LineTraceComponent);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCollisionObjectType",(const void*)SetCollisionObjectType);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetCollisionProfileName",(const void*)GetCollisionProfileName);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCollisionProfileName",(const void*)SetCollisionProfileName);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCollisionEnabled",(const void*)SetCollisionEnabled);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetTranslucentSortPriority",(const void*)SetTranslucentSortPriority);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCastShadow",(const void*)SetCastShadow);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetOnlyOwnerSee",(const void*)SetOnlyOwnerSee);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetOwnerNoSee",(const void*)SetOwnerNoSee);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetNotifyRigidBodyCollision",(const void*)SetNotifyRigidBodyCollision);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::PutRigidBodyToSleep",(const void*)PutRigidBodyToSleep);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::WakeRigidBody",(const void*)WakeRigidBody);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetCenterOfMass",(const void*)SetCenterOfMass);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetCenterOfMass",(const void*)GetCenterOfMass);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetPhysicsAngularVelocity",(const void*)GetPhysicsAngularVelocity);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetPhysicsMaxAngularVelocity",(const void*)SetPhysicsMaxAngularVelocity);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetPhysicsAngularVelocity",(const void*)SetPhysicsAngularVelocity);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetAllPhysicsLinearVelocity",(const void*)SetAllPhysicsLinearVelocity);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetPhysicsLinearVelocityAtPoint",(const void*)GetPhysicsLinearVelocityAtPoint);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetPhysicsLinearVelocity",(const void*)GetPhysicsLinearVelocity);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetPhysicsLinearVelocity",(const void*)SetPhysicsLinearVelocity);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::AddTorque",(const void*)AddTorque);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::AddRadialForce",(const void*)AddRadialForce);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::AddForceAtLocation",(const void*)AddForceAtLocation);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::AddForce",(const void*)AddForce);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::AddRadialImpulse",(const void*)AddRadialImpulse);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::AddImpulseAtLocation",(const void*)AddImpulseAtLocation);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::AddAngularImpulse",(const void*)AddAngularImpulse);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::AddImpulse",(const void*)AddImpulse);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetConstraintMode",(const void*)SetConstraintMode);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetSimulatePhysics",(const void*)SetSimulatePhysics);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetWalkableSlopeOverride",(const void*)SetWalkableSlopeOverride);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetWalkableSlopeOverride",(const void*)GetWalkableSlopeOverride);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::CreateDynamicMaterialInstance",(const void*)CreateDynamicMaterialInstance);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetMaterialByName",(const void*)SetMaterialByName);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetMaterial",(const void*)SetMaterial);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetMaterial",(const void*)GetMaterial);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::SetBoundsScale",(const void*)SetBoundsScale);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetOverlapInfos",(const void*)GetOverlapInfos);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetOverlappingComponents",(const void*)GetOverlappingComponents);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::GetOverlappingActors",(const void*)GetOverlappingActors);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::IsOverlappingActor",(const void*)IsOverlappingActor);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::IsOverlappingComponent",(const void*)IsOverlappingComponent);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::ClearMoveIgnoreComponents",(const void*)ClearMoveIgnoreComponents);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::CopyArrayOfMoveIgnoreComponents",(const void*)CopyArrayOfMoveIgnoreComponents);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::IgnoreComponentWhenMoving",(const void*)IgnoreComponentWhenMoving);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::ClearMoveIgnoreActors",(const void*)ClearMoveIgnoreActors);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::CopyArrayOfMoveIgnoreActors",(const void*)CopyArrayOfMoveIgnoreActors);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::IgnoreActorWhenMoving",(const void*)IgnoreActorWhenMoving);
			mono_add_internal_call("UnrealEngine.UPrimitiveComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
