#pragma once

namespace UnrealEngine
{
	class _USkeletalMeshComponent
	{
		static void GetCurrentJointAngles(USkeletalMeshComponent* _this,MonoString* InBoneName,float* Swing1Angle,float* TwistAngle,float* Swing2Angle)
		{
			FName InBoneName_temp=MonoStringToFName(InBoneName);
			_this->GetCurrentJointAngles(InBoneName_temp,*Swing1Angle,*TwistAngle,*Swing2Angle);
			
		}
		static void SetAngularLimits(USkeletalMeshComponent* _this,MonoString* InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle)
		{
			FName InBoneName_temp=MonoStringToFName(InBoneName);
			_this->SetAngularLimits(InBoneName_temp,Swing1LimitAngle,TwistLimitAngle,Swing2LimitAngle);
			
		}
		static void BreakConstraint(USkeletalMeshComponent* _this,FVector* Impulse,FVector* HitLocation,MonoString* InBoneName)
		{
			FName InBoneName_temp=MonoStringToFName(InBoneName);
			_this->BreakConstraint(*Impulse,*HitLocation,InBoneName_temp);
			
		}
		static void SetConstraintProfileForAll(USkeletalMeshComponent* _this,MonoString* ProfileName,int32 bDefaultIfNotFound)
		{
			FName ProfileName_temp=MonoStringToFName(ProfileName);
			_this->SetConstraintProfileForAll(ProfileName_temp,bDefaultIfNotFound>0?true:false);
			
		}
		static void SetConstraintProfile(USkeletalMeshComponent* _this,MonoString* JointName,MonoString* ProfileName,int32 bDefaultIfNotFound)
		{
			FName JointName_temp=MonoStringToFName(JointName);
			FName ProfileName_temp=MonoStringToFName(ProfileName);
			_this->SetConstraintProfile(JointName_temp,ProfileName_temp,bDefaultIfNotFound>0?true:false);
			
		}
		static void SetAllMotorsAngularDriveParams(USkeletalMeshComponent* _this,float InSpring,float InDamping,float InForceLimit,int32 bSkipCustomPhysicsType)
		{
			_this->SetAllMotorsAngularDriveParams(InSpring,InDamping,InForceLimit,bSkipCustomPhysicsType>0?true:false);
			
		}
		static void SetAllMotorsAngularVelocityDrive(USkeletalMeshComponent* _this,int32 bEnableSwingDrive,int32 bEnableTwistDrive,int32 bSkipCustomPhysicsType)
		{
			_this->SetAllMotorsAngularVelocityDrive(bEnableSwingDrive>0?true:false,bEnableTwistDrive>0?true:false,bSkipCustomPhysicsType>0?true:false);
			
		}
		static void SetAllMotorsAngularPositionDrive(USkeletalMeshComponent* _this,int32 bEnableSwingDrive,int32 bEnableTwistDrive,int32 bSkipCustomPhysicsType)
		{
			_this->SetAllMotorsAngularPositionDrive(bEnableSwingDrive>0?true:false,bEnableTwistDrive>0?true:false,bSkipCustomPhysicsType>0?true:false);
			
		}
		static void AccumulateAllBodiesBelowPhysicsBlendWeight(USkeletalMeshComponent* _this,MonoString* InBoneName,float AddPhysicsBlendWeight,int32 bSkipCustomPhysicsType)
		{
			FName InBoneName_temp=MonoStringToFName(InBoneName);
			_this->AccumulateAllBodiesBelowPhysicsBlendWeight(InBoneName_temp,AddPhysicsBlendWeight,bSkipCustomPhysicsType>0?true:false);
			
		}
		static void SetAllBodiesBelowPhysicsBlendWeight(USkeletalMeshComponent* _this,MonoString* InBoneName,float PhysicsBlendWeight,int32 bSkipCustomPhysicsType,int32 bIncludeSelf)
		{
			FName InBoneName_temp=MonoStringToFName(InBoneName);
			_this->SetAllBodiesBelowPhysicsBlendWeight(InBoneName_temp,PhysicsBlendWeight,bSkipCustomPhysicsType>0?true:false,bIncludeSelf>0?true:false);
			
		}
		static void SetAllBodiesPhysicsBlendWeight(USkeletalMeshComponent* _this,float PhysicsBlendWeight,int32 bSkipCustomPhysicsType)
		{
			_this->SetAllBodiesPhysicsBlendWeight(PhysicsBlendWeight,bSkipCustomPhysicsType>0?true:false);
			
		}
		static void ResetAllBodiesSimulatePhysics(USkeletalMeshComponent* _this)
		{
			_this->ResetAllBodiesSimulatePhysics();
			
		}
		static void SetAllBodiesBelowSimulatePhysics(USkeletalMeshComponent* _this,MonoString* InBoneName,int32 bNewSimulate,int32 bIncludeSelf)
		{
			FName InBoneName_temp=MonoStringToFName(InBoneName);
			_this->SetAllBodiesBelowSimulatePhysics(InBoneName_temp,bNewSimulate>0?true:false,bIncludeSelf>0?true:false);
			
		}
		static void SetEnablePhysicsBlending(USkeletalMeshComponent* _this,int32 bNewBlendPhysics)
		{
			_this->SetEnablePhysicsBlending(bNewBlendPhysics>0?true:false);
			
		}
		static void SetPhysicsBlendWeight(USkeletalMeshComponent* _this,float PhysicsBlendWeight)
		{
			_this->SetPhysicsBlendWeight(PhysicsBlendWeight);
			
		}
		static void SetAllBodiesSimulatePhysics(USkeletalMeshComponent* _this,int32 bNewSimulate)
		{
			_this->SetAllBodiesSimulatePhysics(bNewSimulate>0?true:false);
			
		}
		static void AddImpulseToAllBodiesBelow(USkeletalMeshComponent* _this,FVector* Impulse,MonoString* BoneName,int32 bVelChange,int32 bIncludeSelf)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->AddImpulseToAllBodiesBelow(*Impulse,BoneName_temp,bVelChange>0?true:false,bIncludeSelf>0?true:false);
			
		}
		static void AddForceToAllBodiesBelow(USkeletalMeshComponent* _this,FVector* Force,MonoString* BoneName,int32 bAccelChange,int32 bIncludeSelf)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->AddForceToAllBodiesBelow(*Force,BoneName_temp,bAccelChange>0?true:false,bIncludeSelf>0?true:false);
			
		}
		static int32 K2_GetClosestPointOnPhysicsAsset(USkeletalMeshComponent* _this,FVector* WorldPosition,FVector* ClosestWorldPosition,FVector* Normal,MonoString** BoneName,float* Distance)
		{
			FName BoneName_temp;
			bool ___ret = _this->K2_GetClosestPointOnPhysicsAsset(*WorldPosition,*ClosestWorldPosition,*Normal,BoneName_temp,*Distance);
			return ___ret?1:0;
			*BoneName=FNameToMonoString(BoneName_temp);
			
		}
		static void SetEnableGravityOnAllBodiesBelow(USkeletalMeshComponent* _this,int32 bEnableGravity,MonoString* BoneName,int32 bIncludeSelf)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetEnableGravityOnAllBodiesBelow(bEnableGravity>0?true:false,BoneName_temp,bIncludeSelf>0?true:false);
			
		}
		static int32 IsBodyGravityEnabled(USkeletalMeshComponent* _this,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			bool ___ret = _this->IsBodyGravityEnabled(BoneName_temp);
			return ___ret?1:0;
			
		}
		static void SetEnableBodyGravity(USkeletalMeshComponent* _this,int32 bEnableGravity,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetEnableBodyGravity(bEnableGravity>0?true:false,BoneName_temp);
			
		}
		static void SetNotifyRigidBodyCollisionBelow(USkeletalMeshComponent* _this,int32 bNewNotifyRigidBodyCollision,MonoString* BoneName,int32 bIncludeSelf)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetNotifyRigidBodyCollisionBelow(bNewNotifyRigidBodyCollision>0?true:false,BoneName_temp,bIncludeSelf>0?true:false);
			
		}
		static void SetBodyNotifyRigidBodyCollision(USkeletalMeshComponent* _this,int32 bNewNotifyRigidBodyCollision,MonoString* BoneName)
		{
			FName BoneName_temp=MonoStringToFName(BoneName);
			_this->SetBodyNotifyRigidBodyCollision(bNewNotifyRigidBodyCollision>0?true:false,BoneName_temp);
			
		}
		static void UnbindClothFromMasterPoseComponent(USkeletalMeshComponent* _this,int32 bRestoreSimulationSpace)
		{
			_this->UnbindClothFromMasterPoseComponent(bRestoreSimulationSpace>0?true:false);
			
		}
		static void BindClothToMasterPoseComponent(USkeletalMeshComponent* _this)
		{
			_this->BindClothToMasterPoseComponent();
			
		}
		static void ResetClothTeleportMode(USkeletalMeshComponent* _this)
		{
			_this->ResetClothTeleportMode();
			
		}
		static void ForceClothNextUpdateTeleportAndReset(USkeletalMeshComponent* _this)
		{
			_this->ForceClothNextUpdateTeleportAndReset();
			
		}
		static void ForceClothNextUpdateTeleport(USkeletalMeshComponent* _this)
		{
			_this->ForceClothNextUpdateTeleport();
			
		}
		static void SetClothMaxDistanceScale(USkeletalMeshComponent* _this,float Scale)
		{
			_this->SetClothMaxDistanceScale(Scale);
			
		}
		static float GetClothMaxDistanceScale(USkeletalMeshComponent* _this)
		{
			float ___ret = _this->GetClothMaxDistanceScale();
			return ___ret;
			
		}
		static float GetMorphTarget(USkeletalMeshComponent* _this,MonoString* MorphTargetName)
		{
			FName MorphTargetName_temp=MonoStringToFName(MorphTargetName);
			float ___ret = _this->GetMorphTarget(MorphTargetName_temp);
			return ___ret;
			
		}
		static void ClearMorphTargets(USkeletalMeshComponent* _this)
		{
			_this->ClearMorphTargets();
			
		}
		static void SetMorphTarget(USkeletalMeshComponent* _this,MonoString* MorphTargetName,float Value,int32 bRemoveZeroWeight)
		{
			FName MorphTargetName_temp=MonoStringToFName(MorphTargetName);
			_this->SetMorphTarget(MorphTargetName_temp,Value,bRemoveZeroWeight>0?true:false);
			
		}
		static float GetPlayRate(USkeletalMeshComponent* _this)
		{
			float ___ret = _this->GetPlayRate();
			return ___ret;
			
		}
		static void SetPlayRate(USkeletalMeshComponent* _this,float Rate)
		{
			_this->SetPlayRate(Rate);
			
		}
		static float GetPosition(USkeletalMeshComponent* _this)
		{
			float ___ret = _this->GetPosition();
			return ___ret;
			
		}
		static void SetPosition(USkeletalMeshComponent* _this,float InPos,int32 bFireNotifies)
		{
			_this->SetPosition(InPos,bFireNotifies>0?true:false);
			
		}
		static int32 IsPlaying(USkeletalMeshComponent* _this)
		{
			bool ___ret = _this->IsPlaying();
			return ___ret?1:0;
			
		}
		static void Stop(USkeletalMeshComponent* _this)
		{
			_this->Stop();
			
		}
		static void Play(USkeletalMeshComponent* _this,int32 bLooping)
		{
			_this->Play(bLooping>0?true:false);
			
		}
		static void SetAnimation(USkeletalMeshComponent* _this,UAnimationAsset* NewAnimToPlay)
		{
			_this->SetAnimation(NewAnimToPlay);
			
		}
		static void PlayAnimation(USkeletalMeshComponent* _this,UAnimationAsset* NewAnimToPlay,int32 bLooping)
		{
			_this->PlayAnimation(NewAnimToPlay,bLooping>0?true:false);
			
		}
		static int32 GetAnimationMode(USkeletalMeshComponent* _this)
		{
			TEnumAsByte<EAnimationMode::Type> ___ret = _this->GetAnimationMode();
			return (int)___ret.GetValue();
			
		}
		static void SetAnimationMode(USkeletalMeshComponent* _this,int32 InAnimationMode)
		{
			_this->SetAnimationMode((TEnumAsByte<EAnimationMode::Type>)InAnimationMode);
			
		}
		static UAnimInstance* GetAnimInstance(USkeletalMeshComponent* _this)
		{
			UAnimInstance* ___ret = _this->GetAnimInstance();
			return ___ret;
			
		}
		static void SetAnimInstanceClass(USkeletalMeshComponent* _this,UClass* NewClass)
		{
			_this->SetAnimInstanceClass(NewClass);
			
		}
		static UClass* StaticClass(){return USkeletalMeshComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::GetCurrentJointAngles",(const void*)GetCurrentJointAngles);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAngularLimits",(const void*)SetAngularLimits);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::BreakConstraint",(const void*)BreakConstraint);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetConstraintProfileForAll",(const void*)SetConstraintProfileForAll);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetConstraintProfile",(const void*)SetConstraintProfile);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAllMotorsAngularDriveParams",(const void*)SetAllMotorsAngularDriveParams);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAllMotorsAngularVelocityDrive",(const void*)SetAllMotorsAngularVelocityDrive);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAllMotorsAngularPositionDrive",(const void*)SetAllMotorsAngularPositionDrive);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::AccumulateAllBodiesBelowPhysicsBlendWeight",(const void*)AccumulateAllBodiesBelowPhysicsBlendWeight);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAllBodiesBelowPhysicsBlendWeight",(const void*)SetAllBodiesBelowPhysicsBlendWeight);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAllBodiesPhysicsBlendWeight",(const void*)SetAllBodiesPhysicsBlendWeight);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::ResetAllBodiesSimulatePhysics",(const void*)ResetAllBodiesSimulatePhysics);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAllBodiesBelowSimulatePhysics",(const void*)SetAllBodiesBelowSimulatePhysics);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetEnablePhysicsBlending",(const void*)SetEnablePhysicsBlending);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetPhysicsBlendWeight",(const void*)SetPhysicsBlendWeight);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAllBodiesSimulatePhysics",(const void*)SetAllBodiesSimulatePhysics);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::AddImpulseToAllBodiesBelow",(const void*)AddImpulseToAllBodiesBelow);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::AddForceToAllBodiesBelow",(const void*)AddForceToAllBodiesBelow);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::K2_GetClosestPointOnPhysicsAsset",(const void*)K2_GetClosestPointOnPhysicsAsset);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetEnableGravityOnAllBodiesBelow",(const void*)SetEnableGravityOnAllBodiesBelow);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::IsBodyGravityEnabled",(const void*)IsBodyGravityEnabled);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetEnableBodyGravity",(const void*)SetEnableBodyGravity);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetNotifyRigidBodyCollisionBelow",(const void*)SetNotifyRigidBodyCollisionBelow);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetBodyNotifyRigidBodyCollision",(const void*)SetBodyNotifyRigidBodyCollision);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::UnbindClothFromMasterPoseComponent",(const void*)UnbindClothFromMasterPoseComponent);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::BindClothToMasterPoseComponent",(const void*)BindClothToMasterPoseComponent);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::ResetClothTeleportMode",(const void*)ResetClothTeleportMode);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::ForceClothNextUpdateTeleportAndReset",(const void*)ForceClothNextUpdateTeleportAndReset);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::ForceClothNextUpdateTeleport",(const void*)ForceClothNextUpdateTeleport);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetClothMaxDistanceScale",(const void*)SetClothMaxDistanceScale);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::GetClothMaxDistanceScale",(const void*)GetClothMaxDistanceScale);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::GetMorphTarget",(const void*)GetMorphTarget);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::ClearMorphTargets",(const void*)ClearMorphTargets);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetMorphTarget",(const void*)SetMorphTarget);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::GetPlayRate",(const void*)GetPlayRate);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetPlayRate",(const void*)SetPlayRate);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::GetPosition",(const void*)GetPosition);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetPosition",(const void*)SetPosition);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::IsPlaying",(const void*)IsPlaying);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::Stop",(const void*)Stop);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::Play",(const void*)Play);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAnimation",(const void*)SetAnimation);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::PlayAnimation",(const void*)PlayAnimation);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::GetAnimationMode",(const void*)GetAnimationMode);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAnimationMode",(const void*)SetAnimationMode);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::GetAnimInstance",(const void*)GetAnimInstance);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::SetAnimInstanceClass",(const void*)SetAnimInstanceClass);
			mono_add_internal_call("UnrealEngine.USkeletalMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
