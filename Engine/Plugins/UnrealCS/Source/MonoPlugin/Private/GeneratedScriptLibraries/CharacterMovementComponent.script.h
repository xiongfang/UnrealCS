#pragma once

namespace UnrealEngine
{
	class _UCharacterMovementComponent
	{
		static void ClientAdjustRootMotionSourcePosition(UCharacterMovementComponent* _this,float TimeStamp,FRootMotionSourceGroup* ServerRootMotion,int32 bHasAnimRootMotion,float ServerMontageTrackPosition,FVector* ServerLoc,FVector_NetQuantizeNormal* ServerRotation,float ServerVelZ,UPrimitiveComponent* ServerBase,MonoString* ServerBoneName,int32 bHasBase,int32 bBaseRelativePosition,int32 ServerMovementMode)
		{
			FName ServerBoneName_temp=MonoStringToFName(ServerBoneName);
			_this->ClientAdjustRootMotionSourcePosition(TimeStamp,*ServerRootMotion,bHasAnimRootMotion>0?true:false,ServerMontageTrackPosition,*ServerLoc,*ServerRotation,ServerVelZ,ServerBase,ServerBoneName_temp,bHasBase>0?true:false,bBaseRelativePosition>0?true:false,ServerMovementMode);
			
		}
		static void ClientAdjustRootMotionPosition(UCharacterMovementComponent* _this,float TimeStamp,float ServerMontageTrackPosition,FVector* ServerLoc,FVector_NetQuantizeNormal* ServerRotation,float ServerVelZ,UPrimitiveComponent* ServerBase,MonoString* ServerBoneName,int32 bHasBase,int32 bBaseRelativePosition,int32 ServerMovementMode)
		{
			FName ServerBoneName_temp=MonoStringToFName(ServerBoneName);
			_this->ClientAdjustRootMotionPosition(TimeStamp,ServerMontageTrackPosition,*ServerLoc,*ServerRotation,ServerVelZ,ServerBase,ServerBoneName_temp,bHasBase>0?true:false,bBaseRelativePosition>0?true:false,ServerMovementMode);
			
		}
		static void ClientVeryShortAdjustPosition(UCharacterMovementComponent* _this,float TimeStamp,FVector* NewLoc,UPrimitiveComponent* NewBase,MonoString* NewBaseBoneName,int32 bHasBase,int32 bBaseRelativePosition,int32 ServerMovementMode)
		{
			FName NewBaseBoneName_temp=MonoStringToFName(NewBaseBoneName);
			_this->ClientVeryShortAdjustPosition(TimeStamp,*NewLoc,NewBase,NewBaseBoneName_temp,bHasBase>0?true:false,bBaseRelativePosition>0?true:false,ServerMovementMode);
			
		}
		static void ClientAdjustPosition(UCharacterMovementComponent* _this,float TimeStamp,FVector* NewLoc,FVector* NewVel,UPrimitiveComponent* NewBase,MonoString* NewBaseBoneName,int32 bHasBase,int32 bBaseRelativePosition,int32 ServerMovementMode)
		{
			FName NewBaseBoneName_temp=MonoStringToFName(NewBaseBoneName);
			_this->ClientAdjustPosition(TimeStamp,*NewLoc,*NewVel,NewBase,NewBaseBoneName_temp,bHasBase>0?true:false,bBaseRelativePosition>0?true:false,ServerMovementMode);
			
		}
		static void ClientAckGoodMove(UCharacterMovementComponent* _this,float TimeStamp)
		{
			_this->ClientAckGoodMove(TimeStamp);
			
		}
		static void ServerMoveOld(UCharacterMovementComponent* _this,float OldTimeStamp,FVector_NetQuantize10* OldAccel,int32 OldMoveFlags)
		{
			_this->ServerMoveOld(OldTimeStamp,*OldAccel,OldMoveFlags);
			
		}
		static void ServerMoveDualHybridRootMotion(UCharacterMovementComponent* _this,float TimeStamp0,FVector_NetQuantize10* InAccel0,int32 PendingFlags,uint32 View0,float TimeStamp,FVector_NetQuantize10* InAccel,FVector_NetQuantize100* ClientLoc,int32 NewFlags,int32 ClientRoll,uint32 View,UPrimitiveComponent* ClientMovementBase,MonoString* ClientBaseBoneName,int32 ClientMovementMode)
		{
			FName ClientBaseBoneName_temp=MonoStringToFName(ClientBaseBoneName);
			_this->ServerMoveDualHybridRootMotion(TimeStamp0,*InAccel0,PendingFlags,View0,TimeStamp,*InAccel,*ClientLoc,NewFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName_temp,ClientMovementMode);
			
		}
		static void ServerMoveDual(UCharacterMovementComponent* _this,float TimeStamp0,FVector_NetQuantize10* InAccel0,int32 PendingFlags,uint32 View0,float TimeStamp,FVector_NetQuantize10* InAccel,FVector_NetQuantize100* ClientLoc,int32 NewFlags,int32 ClientRoll,uint32 View,UPrimitiveComponent* ClientMovementBase,MonoString* ClientBaseBoneName,int32 ClientMovementMode)
		{
			FName ClientBaseBoneName_temp=MonoStringToFName(ClientBaseBoneName);
			_this->ServerMoveDual(TimeStamp0,*InAccel0,PendingFlags,View0,TimeStamp,*InAccel,*ClientLoc,NewFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName_temp,ClientMovementMode);
			
		}
		static void ServerMove(UCharacterMovementComponent* _this,float TimeStamp,FVector_NetQuantize10* InAccel,FVector_NetQuantize100* ClientLoc,int32 CompressedMoveFlags,int32 ClientRoll,uint32 View,UPrimitiveComponent* ClientMovementBase,MonoString* ClientBaseBoneName,int32 ClientMovementMode)
		{
			FName ClientBaseBoneName_temp=MonoStringToFName(ClientBaseBoneName);
			_this->ServerMove(TimeStamp,*InAccel,*ClientLoc,CompressedMoveFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName_temp,ClientMovementMode);
			
		}
		static void K2_ComputeFloorDist(UCharacterMovementComponent* _this,FVector* CapsuleLocation,float LineDistance,float SweepDistance,float SweepRadius,FFindFloorResult* FloorResult)
		{
			_this->K2_ComputeFloorDist(*CapsuleLocation,LineDistance,SweepDistance,SweepRadius,*FloorResult);
			
		}
		static void K2_FindFloor(UCharacterMovementComponent* _this,FVector* CapsuleLocation,FFindFloorResult* FloorResult)
		{
			_this->K2_FindFloor(*CapsuleLocation,*FloorResult);
			
		}
		static void SetWalkableFloorZ(UCharacterMovementComponent* _this,float InWalkableFloorZ)
		{
			_this->SetWalkableFloorZ(InWalkableFloorZ);
			
		}
		static float K2_GetWalkableFloorZ(UCharacterMovementComponent* _this)
		{
			float ___ret = _this->K2_GetWalkableFloorZ();
			return ___ret;
			
		}
		static void SetWalkableFloorAngle(UCharacterMovementComponent* _this,float InWalkableFloorAngle)
		{
			_this->SetWalkableFloorAngle(InWalkableFloorAngle);
			
		}
		static float K2_GetWalkableFloorAngle(UCharacterMovementComponent* _this)
		{
			float ___ret = _this->K2_GetWalkableFloorAngle();
			return ___ret;
			
		}
		static int32 IsWalkable(UCharacterMovementComponent* _this,FHitResult* Hit)
		{
			bool ___ret = _this->IsWalkable(*Hit);
			return ___ret?1:0;
			
		}
		static float GetValidPerchRadius(UCharacterMovementComponent* _this)
		{
			float ___ret = _this->GetValidPerchRadius();
			return ___ret;
			
		}
		static float GetPerchRadiusThreshold(UCharacterMovementComponent* _this)
		{
			float ___ret = _this->GetPerchRadiusThreshold();
			return ___ret;
			
		}
		static void AddForce(UCharacterMovementComponent* _this,FVector* Force)
		{
			_this->AddForce(*Force);
			
		}
		static void AddImpulse(UCharacterMovementComponent* _this,FVector* Impulse,int32 bVelocityChange)
		{
			_this->AddImpulse(*Impulse,bVelocityChange>0?true:false);
			
		}
		static float GetAnalogInputModifier(UCharacterMovementComponent* _this)
		{
			float ___ret = _this->GetAnalogInputModifier();
			return ___ret;
			
		}
		static FVector GetCurrentAcceleration(UCharacterMovementComponent* _this)
		{
			FVector ___ret = _this->GetCurrentAcceleration();
			return ___ret;
			
		}
		static float GetMaxBrakingDeceleration(UCharacterMovementComponent* _this)
		{
			float ___ret = _this->GetMaxBrakingDeceleration();
			return ___ret;
			
		}
		static float GetMaxAcceleration(UCharacterMovementComponent* _this)
		{
			float ___ret = _this->GetMaxAcceleration();
			return ___ret;
			
		}
		static float GetMaxJumpHeight(UCharacterMovementComponent* _this)
		{
			float ___ret = _this->GetMaxJumpHeight();
			return ___ret;
			
		}
		static void CalcVelocity(UCharacterMovementComponent* _this,float DeltaTime,float Friction,int32 bFluid,float BrakingDeceleration)
		{
			_this->CalcVelocity(DeltaTime,Friction,bFluid>0?true:false,BrakingDeceleration);
			
		}
		static FVector GetImpartedMovementBaseVelocity(UCharacterMovementComponent* _this)
		{
			FVector ___ret = _this->GetImpartedMovementBaseVelocity();
			return ___ret;
			
		}
		static UPrimitiveComponent* GetMovementBase(UCharacterMovementComponent* _this)
		{
			UPrimitiveComponent* ___ret = _this->GetMovementBase();
			return ___ret;
			
		}
		static void DisableMovement(UCharacterMovementComponent* _this)
		{
			_this->DisableMovement();
			
		}
		static int32 IsWalking(UCharacterMovementComponent* _this)
		{
			bool ___ret = _this->IsWalking();
			return ___ret?1:0;
			
		}
		static void SetMovementMode(UCharacterMovementComponent* _this,int32 NewMovementMode,int32 NewCustomMode)
		{
			_this->SetMovementMode((TEnumAsByte<EMovementMode>)NewMovementMode,NewCustomMode);
			
		}
		static ACharacter* GetCharacterOwner(UCharacterMovementComponent* _this)
		{
			ACharacter* ___ret = _this->GetCharacterOwner();
			return ___ret;
			
		}
		static void SetAvoidanceEnabled(UCharacterMovementComponent* _this,int32 bEnable)
		{
			_this->SetAvoidanceEnabled(bEnable>0?true:false);
			
		}
		static void SetGroupsToIgnoreMask(UCharacterMovementComponent* _this,FNavAvoidanceMask* GroupMask)
		{
			_this->SetGroupsToIgnoreMask(*GroupMask);
			
		}
		static void SetGroupsToAvoidMask(UCharacterMovementComponent* _this,FNavAvoidanceMask* GroupMask)
		{
			_this->SetGroupsToAvoidMask(*GroupMask);
			
		}
		static void SetAvoidanceGroupMask(UCharacterMovementComponent* _this,FNavAvoidanceMask* GroupMask)
		{
			_this->SetAvoidanceGroupMask(*GroupMask);
			
		}
		static UClass* StaticClass(){return UCharacterMovementComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ClientAdjustRootMotionSourcePosition",(const void*)ClientAdjustRootMotionSourcePosition);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ClientAdjustRootMotionPosition",(const void*)ClientAdjustRootMotionPosition);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ClientVeryShortAdjustPosition",(const void*)ClientVeryShortAdjustPosition);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ClientAdjustPosition",(const void*)ClientAdjustPosition);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ClientAckGoodMove",(const void*)ClientAckGoodMove);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ServerMoveOld",(const void*)ServerMoveOld);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ServerMoveDualHybridRootMotion",(const void*)ServerMoveDualHybridRootMotion);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ServerMoveDual",(const void*)ServerMoveDual);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::ServerMove",(const void*)ServerMove);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::K2_ComputeFloorDist",(const void*)K2_ComputeFloorDist);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::K2_FindFloor",(const void*)K2_FindFloor);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::SetWalkableFloorZ",(const void*)SetWalkableFloorZ);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::K2_GetWalkableFloorZ",(const void*)K2_GetWalkableFloorZ);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::SetWalkableFloorAngle",(const void*)SetWalkableFloorAngle);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::K2_GetWalkableFloorAngle",(const void*)K2_GetWalkableFloorAngle);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::IsWalkable",(const void*)IsWalkable);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetValidPerchRadius",(const void*)GetValidPerchRadius);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetPerchRadiusThreshold",(const void*)GetPerchRadiusThreshold);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::AddForce",(const void*)AddForce);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::AddImpulse",(const void*)AddImpulse);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetAnalogInputModifier",(const void*)GetAnalogInputModifier);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetCurrentAcceleration",(const void*)GetCurrentAcceleration);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetMaxBrakingDeceleration",(const void*)GetMaxBrakingDeceleration);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetMaxAcceleration",(const void*)GetMaxAcceleration);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetMaxJumpHeight",(const void*)GetMaxJumpHeight);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::CalcVelocity",(const void*)CalcVelocity);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetImpartedMovementBaseVelocity",(const void*)GetImpartedMovementBaseVelocity);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetMovementBase",(const void*)GetMovementBase);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::DisableMovement",(const void*)DisableMovement);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::IsWalking",(const void*)IsWalking);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::SetMovementMode",(const void*)SetMovementMode);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::GetCharacterOwner",(const void*)GetCharacterOwner);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::SetAvoidanceEnabled",(const void*)SetAvoidanceEnabled);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::SetGroupsToIgnoreMask",(const void*)SetGroupsToIgnoreMask);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::SetGroupsToAvoidMask",(const void*)SetGroupsToAvoidMask);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::SetAvoidanceGroupMask",(const void*)SetAvoidanceGroupMask);
			mono_add_internal_call("UnrealEngine.UCharacterMovementComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
