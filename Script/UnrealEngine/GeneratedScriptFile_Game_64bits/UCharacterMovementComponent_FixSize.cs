#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCharacterMovementComponent
	{
		static readonly int CharacterOwner__Offset;
		public ACharacter CharacterOwner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CharacterOwner__Offset); if (v == IntPtr.Zero)return null; ACharacter retValue = new ACharacter(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GravityScale__Offset;
		public float GravityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GravityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GravityScale__Offset, false);}
			
		}
		
		static readonly int MaxStepHeight__Offset;
		public float MaxStepHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxStepHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxStepHeight__Offset, false);}
			
		}
		
		static readonly int JumpZVelocity__Offset;
		public float JumpZVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpZVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpZVelocity__Offset, false);}
			
		}
		
		static readonly int JumpOffJumpZFactor__Offset;
		public float JumpOffJumpZFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpOffJumpZFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpOffJumpZFactor__Offset, false);}
			
		}
		
		static readonly int WalkableFloorAngle__Offset;
		public float WalkableFloorAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WalkableFloorAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WalkableFloorAngle__Offset, false);}
			
		}
		
		static readonly int WalkableFloorZ__Offset;
		public float WalkableFloorZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WalkableFloorZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WalkableFloorZ__Offset, false);}
			
		}
		
		static readonly int MovementMode__Offset;
		public EMovementMode MovementMode
		{
			get{ CheckIsValid();return (EMovementMode)Marshal.PtrToStructure(_this.Get()+MovementMode__Offset, typeof(EMovementMode));}
			
		}
		
		static readonly int CustomMovementMode__Offset;
		public byte CustomMovementMode
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+CustomMovementMode__Offset, typeof(byte));}
			
		}
		
		static readonly int GroundFriction__Offset;
		public float GroundFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GroundFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroundFriction__Offset, false);}
			
		}
		
		static readonly int MaxWalkSpeed__Offset;
		public float MaxWalkSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxWalkSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxWalkSpeed__Offset, false);}
			
		}
		
		static readonly int MaxWalkSpeedCrouched__Offset;
		public float MaxWalkSpeedCrouched
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxWalkSpeedCrouched__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxWalkSpeedCrouched__Offset, false);}
			
		}
		
		static readonly int MaxSwimSpeed__Offset;
		public float MaxSwimSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSwimSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSwimSpeed__Offset, false);}
			
		}
		
		static readonly int MaxFlySpeed__Offset;
		public float MaxFlySpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxFlySpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxFlySpeed__Offset, false);}
			
		}
		
		static readonly int MaxCustomMovementSpeed__Offset;
		public float MaxCustomMovementSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxCustomMovementSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxCustomMovementSpeed__Offset, false);}
			
		}
		
		static readonly int MaxAcceleration__Offset;
		public float MaxAcceleration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxAcceleration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxAcceleration__Offset, false);}
			
		}
		
		static readonly int BrakingFrictionFactor__Offset;
		public float BrakingFrictionFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingFrictionFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingFrictionFactor__Offset, false);}
			
		}
		
		static readonly int BrakingFriction__Offset;
		public float BrakingFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingFriction__Offset, false);}
			
		}
		
		static readonly int bUseSeparateBrakingFriction__Offset;
		public bool bUseSeparateBrakingFriction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseSeparateBrakingFriction__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseSeparateBrakingFriction__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BrakingDecelerationWalking__Offset;
		public float BrakingDecelerationWalking
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingDecelerationWalking__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingDecelerationWalking__Offset, false);}
			
		}
		
		static readonly int BrakingDecelerationFalling__Offset;
		public float BrakingDecelerationFalling
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingDecelerationFalling__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingDecelerationFalling__Offset, false);}
			
		}
		
		static readonly int BrakingDecelerationSwimming__Offset;
		public float BrakingDecelerationSwimming
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingDecelerationSwimming__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingDecelerationSwimming__Offset, false);}
			
		}
		
		static readonly int BrakingDecelerationFlying__Offset;
		public float BrakingDecelerationFlying
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingDecelerationFlying__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingDecelerationFlying__Offset, false);}
			
		}
		
		static readonly int AirControl__Offset;
		public float AirControl
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AirControl__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AirControl__Offset, false);}
			
		}
		
		static readonly int AirControlBoostMultiplier__Offset;
		public float AirControlBoostMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AirControlBoostMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AirControlBoostMultiplier__Offset, false);}
			
		}
		
		static readonly int AirControlBoostVelocityThreshold__Offset;
		public float AirControlBoostVelocityThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AirControlBoostVelocityThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AirControlBoostVelocityThreshold__Offset, false);}
			
		}
		
		static readonly int FallingLateralFriction__Offset;
		public float FallingLateralFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FallingLateralFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FallingLateralFriction__Offset, false);}
			
		}
		
		static readonly int CrouchedHalfHeight__Offset;
		public float CrouchedHalfHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CrouchedHalfHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CrouchedHalfHeight__Offset, false);}
			
		}
		
		static readonly int Buoyancy__Offset;
		public float Buoyancy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Buoyancy__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Buoyancy__Offset, false);}
			
		}
		
		static readonly int PerchRadiusThreshold__Offset;
		public float PerchRadiusThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PerchRadiusThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PerchRadiusThreshold__Offset, false);}
			
		}
		
		static readonly int PerchAdditionalHeight__Offset;
		public float PerchAdditionalHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PerchAdditionalHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PerchAdditionalHeight__Offset, false);}
			
		}
		
		static readonly int RotationRate__Offset;
		public FRotator RotationRate
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RotationRate__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationRate__Offset, false);}
			
		}
		
		static readonly int bUseControllerDesiredRotation__Offset;
		public bool bUseControllerDesiredRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerDesiredRotation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseControllerDesiredRotation__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOrientRotationToMovement__Offset;
		public bool bOrientRotationToMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrientRotationToMovement__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrientRotationToMovement__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMovementInProgress__Offset;
		public bool bMovementInProgress
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMovementInProgress__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bEnableScopedMovementUpdates__Offset;
		public bool bEnableScopedMovementUpdates
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableScopedMovementUpdates__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableScopedMovementUpdates__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bForceMaxAccel__Offset;
		public bool bForceMaxAccel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceMaxAccel__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bRunPhysicsWithNoController__Offset;
		public bool bRunPhysicsWithNoController
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRunPhysicsWithNoController__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRunPhysicsWithNoController__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bForceNextFloorCheck__Offset;
		public bool bForceNextFloorCheck
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceNextFloorCheck__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceNextFloorCheck__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bShrinkProxyCapsule__Offset;
		public bool bShrinkProxyCapsule
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShrinkProxyCapsule__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bCanWalkOffLedges__Offset;
		public bool bCanWalkOffLedges
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanWalkOffLedges__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanWalkOffLedges__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bCanWalkOffLedgesWhenCrouching__Offset;
		public bool bCanWalkOffLedgesWhenCrouching
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanWalkOffLedgesWhenCrouching__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanWalkOffLedgesWhenCrouching__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDeferUpdateMoveComponent__Offset;
		public bool bDeferUpdateMoveComponent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDeferUpdateMoveComponent__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int DeferredUpdatedMoveComponent__Offset;
		public USceneComponent DeferredUpdatedMoveComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DeferredUpdatedMoveComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaxOutOfWaterStepHeight__Offset;
		public float MaxOutOfWaterStepHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxOutOfWaterStepHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxOutOfWaterStepHeight__Offset, false);}
			
		}
		
		static readonly int OutofWaterZ__Offset;
		public float OutofWaterZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OutofWaterZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OutofWaterZ__Offset, false);}
			
		}
		
		static readonly int Mass__Offset;
		public float Mass
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Mass__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Mass__Offset, false);}
			
		}
		
		static readonly int bEnablePhysicsInteraction__Offset;
		public bool bEnablePhysicsInteraction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePhysicsInteraction__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePhysicsInteraction__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTouchForceScaledToMass__Offset;
		public bool bTouchForceScaledToMass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTouchForceScaledToMass__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTouchForceScaledToMass__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bPushForceScaledToMass__Offset;
		public bool bPushForceScaledToMass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPushForceScaledToMass__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPushForceScaledToMass__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bPushForceUsingZOffset__Offset;
		public bool bPushForceUsingZOffset
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPushForceUsingZOffset__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPushForceUsingZOffset__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bScalePushForceToVelocity__Offset;
		public bool bScalePushForceToVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScalePushForceToVelocity__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bScalePushForceToVelocity__Offset, 1,0,1,255);}
			
		}
		
		static readonly int StandingDownwardForceScale__Offset;
		public float StandingDownwardForceScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StandingDownwardForceScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StandingDownwardForceScale__Offset, false);}
			
		}
		
		static readonly int InitialPushForceFactor__Offset;
		public float InitialPushForceFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialPushForceFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialPushForceFactor__Offset, false);}
			
		}
		
		static readonly int PushForceFactor__Offset;
		public float PushForceFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PushForceFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PushForceFactor__Offset, false);}
			
		}
		
		static readonly int PushForcePointZOffsetFactor__Offset;
		public float PushForcePointZOffsetFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PushForcePointZOffsetFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PushForcePointZOffsetFactor__Offset, false);}
			
		}
		
		static readonly int TouchForceFactor__Offset;
		public float TouchForceFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TouchForceFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TouchForceFactor__Offset, false);}
			
		}
		
		static readonly int MinTouchForce__Offset;
		public float MinTouchForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinTouchForce__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinTouchForce__Offset, false);}
			
		}
		
		static readonly int MaxTouchForce__Offset;
		public float MaxTouchForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxTouchForce__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxTouchForce__Offset, false);}
			
		}
		
		static readonly int RepulsionForce__Offset;
		public float RepulsionForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RepulsionForce__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RepulsionForce__Offset, false);}
			
		}
		
		static readonly int bForceBraking__Offset;
		public bool bForceBraking
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceBraking__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CrouchedSpeedMultiplier__Offset;
		public float CrouchedSpeedMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CrouchedSpeedMultiplier__Offset, typeof(float));}
			
		}
		
		static readonly int UpperImpactNormalScale__Offset;
		public float UpperImpactNormalScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UpperImpactNormalScale__Offset, typeof(float));}
			
		}
		
		static readonly int Acceleration__Offset;
		public FVector Acceleration
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Acceleration__Offset, typeof(FVector));}
			
		}
		
		static readonly int LastUpdateLocation__Offset;
		public FVector LastUpdateLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastUpdateLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int LastUpdateRotation__Offset;
		public FQuat LastUpdateRotation
		{
			get{ CheckIsValid();return (FQuat)Marshal.PtrToStructure(_this.Get()+LastUpdateRotation__Offset, typeof(FQuat));}
			
		}
		
		static readonly int LastUpdateVelocity__Offset;
		public FVector LastUpdateVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastUpdateVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int ServerLastTransformUpdateTimeStamp__Offset;
		public float ServerLastTransformUpdateTimeStamp
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ServerLastTransformUpdateTimeStamp__Offset, typeof(float));}
			
		}
		
		static readonly int PendingImpulseToApply__Offset;
		public FVector PendingImpulseToApply
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PendingImpulseToApply__Offset, typeof(FVector));}
			
		}
		
		static readonly int PendingForceToApply__Offset;
		public FVector PendingForceToApply
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PendingForceToApply__Offset, typeof(FVector));}
			
		}
		
		static readonly int AnalogInputModifier__Offset;
		public float AnalogInputModifier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnalogInputModifier__Offset, typeof(float));}
			
		}
		
		static readonly int MaxSimulationTimeStep__Offset;
		public float MaxSimulationTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSimulationTimeStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationTimeStep__Offset, false);}
			
		}
		
		static readonly int MaxSimulationIterations__Offset;
		public int MaxSimulationIterations
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSimulationIterations__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationIterations__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationWithGeometry__Offset;
		public float MaxDepenetrationWithGeometry
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationWithGeometry__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationWithGeometry__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationWithGeometryAsProxy__Offset;
		public float MaxDepenetrationWithGeometryAsProxy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationWithGeometryAsProxy__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationWithGeometryAsProxy__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationWithPawn__Offset;
		public float MaxDepenetrationWithPawn
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationWithPawn__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationWithPawn__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationWithPawnAsProxy__Offset;
		public float MaxDepenetrationWithPawnAsProxy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationWithPawnAsProxy__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationWithPawnAsProxy__Offset, false);}
			
		}
		
		static readonly int NetworkSimulatedSmoothLocationTime__Offset;
		public float NetworkSimulatedSmoothLocationTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetworkSimulatedSmoothLocationTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetworkSimulatedSmoothLocationTime__Offset, false);}
			
		}
		
		static readonly int NetworkSimulatedSmoothRotationTime__Offset;
		public float NetworkSimulatedSmoothRotationTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetworkSimulatedSmoothRotationTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetworkSimulatedSmoothRotationTime__Offset, false);}
			
		}
		
		static readonly int ListenServerNetworkSimulatedSmoothLocationTime__Offset;
		public float ListenServerNetworkSimulatedSmoothLocationTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ListenServerNetworkSimulatedSmoothLocationTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ListenServerNetworkSimulatedSmoothLocationTime__Offset, false);}
			
		}
		
		static readonly int ListenServerNetworkSimulatedSmoothRotationTime__Offset;
		public float ListenServerNetworkSimulatedSmoothRotationTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ListenServerNetworkSimulatedSmoothRotationTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ListenServerNetworkSimulatedSmoothRotationTime__Offset, false);}
			
		}
		
		static readonly int NetworkMaxSmoothUpdateDistance__Offset;
		public float NetworkMaxSmoothUpdateDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetworkMaxSmoothUpdateDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetworkMaxSmoothUpdateDistance__Offset, false);}
			
		}
		
		static readonly int NetworkNoSmoothUpdateDistance__Offset;
		public float NetworkNoSmoothUpdateDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetworkNoSmoothUpdateDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetworkNoSmoothUpdateDistance__Offset, false);}
			
		}
		
		static readonly int LedgeCheckThreshold__Offset;
		public float LedgeCheckThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LedgeCheckThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LedgeCheckThreshold__Offset, false);}
			
		}
		
		static readonly int JumpOutOfWaterPitch__Offset;
		public float JumpOutOfWaterPitch
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpOutOfWaterPitch__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpOutOfWaterPitch__Offset, false);}
			
		}
		
		static readonly int CurrentFloor__Offset;
		public FFindFloorResult CurrentFloor
		{
			get{ CheckIsValid();return (FFindFloorResult)Marshal.PtrToStructure(_this.Get()+CurrentFloor__Offset, typeof(FFindFloorResult));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CurrentFloor__Offset, false);}
			
		}
		
		static readonly int DefaultLandMovementMode__Offset;
		public EMovementMode DefaultLandMovementMode
		{
			get{ CheckIsValid();return (EMovementMode)Marshal.PtrToStructure(_this.Get()+DefaultLandMovementMode__Offset, typeof(EMovementMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultLandMovementMode__Offset, false);}
			
		}
		
		static readonly int DefaultWaterMovementMode__Offset;
		public EMovementMode DefaultWaterMovementMode
		{
			get{ CheckIsValid();return (EMovementMode)Marshal.PtrToStructure(_this.Get()+DefaultWaterMovementMode__Offset, typeof(EMovementMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultWaterMovementMode__Offset, false);}
			
		}
		
		static readonly int GroundMovementMode__Offset;
		public EMovementMode GroundMovementMode
		{
			get{ CheckIsValid();return (EMovementMode)Marshal.PtrToStructure(_this.Get()+GroundMovementMode__Offset, typeof(EMovementMode));}
			
		}
		
		static readonly int bMaintainHorizontalGroundVelocity__Offset;
		public bool bMaintainHorizontalGroundVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMaintainHorizontalGroundVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMaintainHorizontalGroundVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bImpartBaseVelocityX__Offset;
		public bool bImpartBaseVelocityX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpartBaseVelocityX__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpartBaseVelocityX__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bImpartBaseVelocityY__Offset;
		public bool bImpartBaseVelocityY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpartBaseVelocityY__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpartBaseVelocityY__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bImpartBaseVelocityZ__Offset;
		public bool bImpartBaseVelocityZ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpartBaseVelocityZ__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpartBaseVelocityZ__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bImpartBaseAngularVelocity__Offset;
		public bool bImpartBaseAngularVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpartBaseAngularVelocity__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpartBaseAngularVelocity__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bJustTeleported__Offset;
		public bool bJustTeleported
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bJustTeleported__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bJustTeleported__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bNetworkUpdateReceived__Offset;
		public bool bNetworkUpdateReceived
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetworkUpdateReceived__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bNetworkMovementModeChanged__Offset;
		public bool bNetworkMovementModeChanged
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetworkMovementModeChanged__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bIgnoreClientMovementErrorChecksAndCorrection__Offset;
		public bool bIgnoreClientMovementErrorChecksAndCorrection
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreClientMovementErrorChecksAndCorrection__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreClientMovementErrorChecksAndCorrection__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bNotifyApex__Offset;
		public bool bNotifyApex
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNotifyApex__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNotifyApex__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bCheatFlying__Offset;
		public bool bCheatFlying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCheatFlying__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bWantsToCrouch__Offset;
		public bool bWantsToCrouch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWantsToCrouch__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWantsToCrouch__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bCrouchMaintainsBaseLocation__Offset;
		public bool bCrouchMaintainsBaseLocation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCrouchMaintainsBaseLocation__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCrouchMaintainsBaseLocation__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bIgnoreBaseRotation__Offset;
		public bool bIgnoreBaseRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreBaseRotation__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreBaseRotation__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bFastAttachedMove__Offset;
		public bool bFastAttachedMove
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFastAttachedMove__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bAlwaysCheckFloor__Offset;
		public bool bAlwaysCheckFloor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysCheckFloor__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysCheckFloor__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUseFlatBaseForFloorChecks__Offset;
		public bool bUseFlatBaseForFloorChecks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFlatBaseForFloorChecks__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFlatBaseForFloorChecks__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPerformingJumpOff__Offset;
		public bool bPerformingJumpOff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPerformingJumpOff__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bWantsToLeaveNavWalking__Offset;
		public bool bWantsToLeaveNavWalking
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWantsToLeaveNavWalking__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bUseRVOAvoidance__Offset;
		public bool bUseRVOAvoidance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRVOAvoidance__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRVOAvoidance__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bRequestedMoveUseAcceleration__Offset;
		public bool bRequestedMoveUseAcceleration
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequestedMoveUseAcceleration__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRequestedMoveUseAcceleration__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bHasRequestedVelocity__Offset;
		public bool bHasRequestedVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasRequestedVelocity__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bRequestedMoveWithMaxSpeed__Offset;
		public bool bRequestedMoveWithMaxSpeed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequestedMoveWithMaxSpeed__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bWasAvoidanceUpdated__Offset;
		public bool bWasAvoidanceUpdated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWasAvoidanceUpdated__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bProjectNavMeshWalking__Offset;
		public bool bProjectNavMeshWalking
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bProjectNavMeshWalking__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bProjectNavMeshWalking__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bProjectNavMeshOnBothWorldChannels__Offset;
		public bool bProjectNavMeshOnBothWorldChannels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bProjectNavMeshOnBothWorldChannels__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bProjectNavMeshOnBothWorldChannels__Offset, 1,0,16,16);}
			
		}
		
		static readonly int AvoidanceConsiderationRadius__Offset;
		public float AvoidanceConsiderationRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AvoidanceConsiderationRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceConsiderationRadius__Offset, false);}
			
		}
		
		static readonly int RequestedVelocity__Offset;
		public FVector RequestedVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RequestedVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int AvoidanceUID__Offset;
		public int AvoidanceUID
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+AvoidanceUID__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceUID__Offset, false);}
			
		}
		
		static readonly int AvoidanceGroup__Offset;
		public FNavAvoidanceMask AvoidanceGroup
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+AvoidanceGroup__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceGroup__Offset, false);}
			
		}
		
		static readonly int GroupsToAvoid__Offset;
		public FNavAvoidanceMask GroupsToAvoid
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+GroupsToAvoid__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupsToAvoid__Offset, false);}
			
		}
		
		static readonly int GroupsToIgnore__Offset;
		public FNavAvoidanceMask GroupsToIgnore
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+GroupsToIgnore__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupsToIgnore__Offset, false);}
			
		}
		
		static readonly int AvoidanceWeight__Offset;
		public float AvoidanceWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AvoidanceWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceWeight__Offset, false);}
			
		}
		
		static readonly int PendingLaunchVelocity__Offset;
		public FVector PendingLaunchVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PendingLaunchVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int NavMeshProjectionInterval__Offset;
		public float NavMeshProjectionInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavMeshProjectionInterval__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavMeshProjectionInterval__Offset, false);}
			
		}
		
		static readonly int NavMeshProjectionTimer__Offset;
		public float NavMeshProjectionTimer
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavMeshProjectionTimer__Offset, typeof(float));}
			
		}
		
		static readonly int NavMeshProjectionInterpSpeed__Offset;
		public float NavMeshProjectionInterpSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavMeshProjectionInterpSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavMeshProjectionInterpSpeed__Offset, false);}
			
		}
		
		static readonly int NavMeshProjectionHeightScaleUp__Offset;
		public float NavMeshProjectionHeightScaleUp
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavMeshProjectionHeightScaleUp__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavMeshProjectionHeightScaleUp__Offset, false);}
			
		}
		
		static readonly int NavMeshProjectionHeightScaleDown__Offset;
		public float NavMeshProjectionHeightScaleDown
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavMeshProjectionHeightScaleDown__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavMeshProjectionHeightScaleDown__Offset, false);}
			
		}
		
		static readonly int NavWalkingFloorDistTolerance__Offset;
		public float NavWalkingFloorDistTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavWalkingFloorDistTolerance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavWalkingFloorDistTolerance__Offset, false);}
			
		}
		
		static readonly int PostPhysicsTickFunction__Offset;
		public FCharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction
		{
			get{ CheckIsValid();return (FCharacterMovementComponentPostPhysicsTickFunction)Marshal.PtrToStructure(_this.Get()+PostPhysicsTickFunction__Offset, typeof(FCharacterMovementComponentPostPhysicsTickFunction));}
			
		}
		
		static readonly int MinTimeBetweenTimeStampResets__Offset;
		public float MinTimeBetweenTimeStampResets
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinTimeBetweenTimeStampResets__Offset, typeof(float));}
			
		}
		
		static readonly int CurrentRootMotion__Offset;
		public FRootMotionSourceGroup CurrentRootMotion
		{
			get{ CheckIsValid();return (FRootMotionSourceGroup)Marshal.PtrToStructure(_this.Get()+CurrentRootMotion__Offset, typeof(FRootMotionSourceGroup));}
			
		}
		
		static readonly int RootMotionParams__Offset;
		public FRootMotionMovementParams RootMotionParams
		{
			get{ CheckIsValid();return (FRootMotionMovementParams)Marshal.PtrToStructure(_this.Get()+RootMotionParams__Offset, typeof(FRootMotionMovementParams));}
			
		}
		
		static readonly int AnimRootMotionVelocity__Offset;
		public FVector AnimRootMotionVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+AnimRootMotionVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int bWasSimulatingRootMotion__Offset;
		public bool bWasSimulatingRootMotion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWasSimulatingRootMotion__Offset, 1, 0, 1, 255);}
			
		}
		
		static UCharacterMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CharacterMovementComponent");
			CharacterOwner__Offset=GetPropertyOffset(NativeClassPtr,"CharacterOwner");
			GravityScale__Offset=GetPropertyOffset(NativeClassPtr,"GravityScale");
			MaxStepHeight__Offset=GetPropertyOffset(NativeClassPtr,"MaxStepHeight");
			JumpZVelocity__Offset=GetPropertyOffset(NativeClassPtr,"JumpZVelocity");
			JumpOffJumpZFactor__Offset=GetPropertyOffset(NativeClassPtr,"JumpOffJumpZFactor");
			WalkableFloorAngle__Offset=GetPropertyOffset(NativeClassPtr,"WalkableFloorAngle");
			WalkableFloorZ__Offset=GetPropertyOffset(NativeClassPtr,"WalkableFloorZ");
			MovementMode__Offset=GetPropertyOffset(NativeClassPtr,"MovementMode");
			CustomMovementMode__Offset=GetPropertyOffset(NativeClassPtr,"CustomMovementMode");
			GroundFriction__Offset=GetPropertyOffset(NativeClassPtr,"GroundFriction");
			MaxWalkSpeed__Offset=GetPropertyOffset(NativeClassPtr,"MaxWalkSpeed");
			MaxWalkSpeedCrouched__Offset=GetPropertyOffset(NativeClassPtr,"MaxWalkSpeedCrouched");
			MaxSwimSpeed__Offset=GetPropertyOffset(NativeClassPtr,"MaxSwimSpeed");
			MaxFlySpeed__Offset=GetPropertyOffset(NativeClassPtr,"MaxFlySpeed");
			MaxCustomMovementSpeed__Offset=GetPropertyOffset(NativeClassPtr,"MaxCustomMovementSpeed");
			MaxAcceleration__Offset=GetPropertyOffset(NativeClassPtr,"MaxAcceleration");
			BrakingFrictionFactor__Offset=GetPropertyOffset(NativeClassPtr,"BrakingFrictionFactor");
			BrakingFriction__Offset=GetPropertyOffset(NativeClassPtr,"BrakingFriction");
			bUseSeparateBrakingFriction__Offset=GetPropertyOffset(NativeClassPtr,"bUseSeparateBrakingFriction");
			BrakingDecelerationWalking__Offset=GetPropertyOffset(NativeClassPtr,"BrakingDecelerationWalking");
			BrakingDecelerationFalling__Offset=GetPropertyOffset(NativeClassPtr,"BrakingDecelerationFalling");
			BrakingDecelerationSwimming__Offset=GetPropertyOffset(NativeClassPtr,"BrakingDecelerationSwimming");
			BrakingDecelerationFlying__Offset=GetPropertyOffset(NativeClassPtr,"BrakingDecelerationFlying");
			AirControl__Offset=GetPropertyOffset(NativeClassPtr,"AirControl");
			AirControlBoostMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"AirControlBoostMultiplier");
			AirControlBoostVelocityThreshold__Offset=GetPropertyOffset(NativeClassPtr,"AirControlBoostVelocityThreshold");
			FallingLateralFriction__Offset=GetPropertyOffset(NativeClassPtr,"FallingLateralFriction");
			CrouchedHalfHeight__Offset=GetPropertyOffset(NativeClassPtr,"CrouchedHalfHeight");
			Buoyancy__Offset=GetPropertyOffset(NativeClassPtr,"Buoyancy");
			PerchRadiusThreshold__Offset=GetPropertyOffset(NativeClassPtr,"PerchRadiusThreshold");
			PerchAdditionalHeight__Offset=GetPropertyOffset(NativeClassPtr,"PerchAdditionalHeight");
			RotationRate__Offset=GetPropertyOffset(NativeClassPtr,"RotationRate");
			bUseControllerDesiredRotation__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerDesiredRotation");
			bOrientRotationToMovement__Offset=GetPropertyOffset(NativeClassPtr,"bOrientRotationToMovement");
			bMovementInProgress__Offset=GetPropertyOffset(NativeClassPtr,"bMovementInProgress");
			bEnableScopedMovementUpdates__Offset=GetPropertyOffset(NativeClassPtr,"bEnableScopedMovementUpdates");
			bForceMaxAccel__Offset=GetPropertyOffset(NativeClassPtr,"bForceMaxAccel");
			bRunPhysicsWithNoController__Offset=GetPropertyOffset(NativeClassPtr,"bRunPhysicsWithNoController");
			bForceNextFloorCheck__Offset=GetPropertyOffset(NativeClassPtr,"bForceNextFloorCheck");
			bShrinkProxyCapsule__Offset=GetPropertyOffset(NativeClassPtr,"bShrinkProxyCapsule");
			bCanWalkOffLedges__Offset=GetPropertyOffset(NativeClassPtr,"bCanWalkOffLedges");
			bCanWalkOffLedgesWhenCrouching__Offset=GetPropertyOffset(NativeClassPtr,"bCanWalkOffLedgesWhenCrouching");
			bDeferUpdateMoveComponent__Offset=GetPropertyOffset(NativeClassPtr,"bDeferUpdateMoveComponent");
			DeferredUpdatedMoveComponent__Offset=GetPropertyOffset(NativeClassPtr,"DeferredUpdatedMoveComponent");
			MaxOutOfWaterStepHeight__Offset=GetPropertyOffset(NativeClassPtr,"MaxOutOfWaterStepHeight");
			OutofWaterZ__Offset=GetPropertyOffset(NativeClassPtr,"OutofWaterZ");
			Mass__Offset=GetPropertyOffset(NativeClassPtr,"Mass");
			bEnablePhysicsInteraction__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePhysicsInteraction");
			bTouchForceScaledToMass__Offset=GetPropertyOffset(NativeClassPtr,"bTouchForceScaledToMass");
			bPushForceScaledToMass__Offset=GetPropertyOffset(NativeClassPtr,"bPushForceScaledToMass");
			bPushForceUsingZOffset__Offset=GetPropertyOffset(NativeClassPtr,"bPushForceUsingZOffset");
			bScalePushForceToVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bScalePushForceToVelocity");
			StandingDownwardForceScale__Offset=GetPropertyOffset(NativeClassPtr,"StandingDownwardForceScale");
			InitialPushForceFactor__Offset=GetPropertyOffset(NativeClassPtr,"InitialPushForceFactor");
			PushForceFactor__Offset=GetPropertyOffset(NativeClassPtr,"PushForceFactor");
			PushForcePointZOffsetFactor__Offset=GetPropertyOffset(NativeClassPtr,"PushForcePointZOffsetFactor");
			TouchForceFactor__Offset=GetPropertyOffset(NativeClassPtr,"TouchForceFactor");
			MinTouchForce__Offset=GetPropertyOffset(NativeClassPtr,"MinTouchForce");
			MaxTouchForce__Offset=GetPropertyOffset(NativeClassPtr,"MaxTouchForce");
			RepulsionForce__Offset=GetPropertyOffset(NativeClassPtr,"RepulsionForce");
			bForceBraking__Offset=GetPropertyOffset(NativeClassPtr,"bForceBraking");
			CrouchedSpeedMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"CrouchedSpeedMultiplier");
			UpperImpactNormalScale__Offset=GetPropertyOffset(NativeClassPtr,"UpperImpactNormalScale");
			Acceleration__Offset=GetPropertyOffset(NativeClassPtr,"Acceleration");
			LastUpdateLocation__Offset=GetPropertyOffset(NativeClassPtr,"LastUpdateLocation");
			LastUpdateRotation__Offset=GetPropertyOffset(NativeClassPtr,"LastUpdateRotation");
			LastUpdateVelocity__Offset=GetPropertyOffset(NativeClassPtr,"LastUpdateVelocity");
			ServerLastTransformUpdateTimeStamp__Offset=GetPropertyOffset(NativeClassPtr,"ServerLastTransformUpdateTimeStamp");
			PendingImpulseToApply__Offset=GetPropertyOffset(NativeClassPtr,"PendingImpulseToApply");
			PendingForceToApply__Offset=GetPropertyOffset(NativeClassPtr,"PendingForceToApply");
			AnalogInputModifier__Offset=GetPropertyOffset(NativeClassPtr,"AnalogInputModifier");
			MaxSimulationTimeStep__Offset=GetPropertyOffset(NativeClassPtr,"MaxSimulationTimeStep");
			MaxSimulationIterations__Offset=GetPropertyOffset(NativeClassPtr,"MaxSimulationIterations");
			MaxDepenetrationWithGeometry__Offset=GetPropertyOffset(NativeClassPtr,"MaxDepenetrationWithGeometry");
			MaxDepenetrationWithGeometryAsProxy__Offset=GetPropertyOffset(NativeClassPtr,"MaxDepenetrationWithGeometryAsProxy");
			MaxDepenetrationWithPawn__Offset=GetPropertyOffset(NativeClassPtr,"MaxDepenetrationWithPawn");
			MaxDepenetrationWithPawnAsProxy__Offset=GetPropertyOffset(NativeClassPtr,"MaxDepenetrationWithPawnAsProxy");
			NetworkSimulatedSmoothLocationTime__Offset=GetPropertyOffset(NativeClassPtr,"NetworkSimulatedSmoothLocationTime");
			NetworkSimulatedSmoothRotationTime__Offset=GetPropertyOffset(NativeClassPtr,"NetworkSimulatedSmoothRotationTime");
			ListenServerNetworkSimulatedSmoothLocationTime__Offset=GetPropertyOffset(NativeClassPtr,"ListenServerNetworkSimulatedSmoothLocationTime");
			ListenServerNetworkSimulatedSmoothRotationTime__Offset=GetPropertyOffset(NativeClassPtr,"ListenServerNetworkSimulatedSmoothRotationTime");
			NetworkMaxSmoothUpdateDistance__Offset=GetPropertyOffset(NativeClassPtr,"NetworkMaxSmoothUpdateDistance");
			NetworkNoSmoothUpdateDistance__Offset=GetPropertyOffset(NativeClassPtr,"NetworkNoSmoothUpdateDistance");
			LedgeCheckThreshold__Offset=GetPropertyOffset(NativeClassPtr,"LedgeCheckThreshold");
			JumpOutOfWaterPitch__Offset=GetPropertyOffset(NativeClassPtr,"JumpOutOfWaterPitch");
			CurrentFloor__Offset=GetPropertyOffset(NativeClassPtr,"CurrentFloor");
			DefaultLandMovementMode__Offset=GetPropertyOffset(NativeClassPtr,"DefaultLandMovementMode");
			DefaultWaterMovementMode__Offset=GetPropertyOffset(NativeClassPtr,"DefaultWaterMovementMode");
			GroundMovementMode__Offset=GetPropertyOffset(NativeClassPtr,"GroundMovementMode");
			bMaintainHorizontalGroundVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bMaintainHorizontalGroundVelocity");
			bImpartBaseVelocityX__Offset=GetPropertyOffset(NativeClassPtr,"bImpartBaseVelocityX");
			bImpartBaseVelocityY__Offset=GetPropertyOffset(NativeClassPtr,"bImpartBaseVelocityY");
			bImpartBaseVelocityZ__Offset=GetPropertyOffset(NativeClassPtr,"bImpartBaseVelocityZ");
			bImpartBaseAngularVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bImpartBaseAngularVelocity");
			bJustTeleported__Offset=GetPropertyOffset(NativeClassPtr,"bJustTeleported");
			bNetworkUpdateReceived__Offset=GetPropertyOffset(NativeClassPtr,"bNetworkUpdateReceived");
			bNetworkMovementModeChanged__Offset=GetPropertyOffset(NativeClassPtr,"bNetworkMovementModeChanged");
			bIgnoreClientMovementErrorChecksAndCorrection__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreClientMovementErrorChecksAndCorrection");
			bNotifyApex__Offset=GetPropertyOffset(NativeClassPtr,"bNotifyApex");
			bCheatFlying__Offset=GetPropertyOffset(NativeClassPtr,"bCheatFlying");
			bWantsToCrouch__Offset=GetPropertyOffset(NativeClassPtr,"bWantsToCrouch");
			bCrouchMaintainsBaseLocation__Offset=GetPropertyOffset(NativeClassPtr,"bCrouchMaintainsBaseLocation");
			bIgnoreBaseRotation__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreBaseRotation");
			bFastAttachedMove__Offset=GetPropertyOffset(NativeClassPtr,"bFastAttachedMove");
			bAlwaysCheckFloor__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysCheckFloor");
			bUseFlatBaseForFloorChecks__Offset=GetPropertyOffset(NativeClassPtr,"bUseFlatBaseForFloorChecks");
			bPerformingJumpOff__Offset=GetPropertyOffset(NativeClassPtr,"bPerformingJumpOff");
			bWantsToLeaveNavWalking__Offset=GetPropertyOffset(NativeClassPtr,"bWantsToLeaveNavWalking");
			bUseRVOAvoidance__Offset=GetPropertyOffset(NativeClassPtr,"bUseRVOAvoidance");
			bRequestedMoveUseAcceleration__Offset=GetPropertyOffset(NativeClassPtr,"bRequestedMoveUseAcceleration");
			bHasRequestedVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bHasRequestedVelocity");
			bRequestedMoveWithMaxSpeed__Offset=GetPropertyOffset(NativeClassPtr,"bRequestedMoveWithMaxSpeed");
			bWasAvoidanceUpdated__Offset=GetPropertyOffset(NativeClassPtr,"bWasAvoidanceUpdated");
			bProjectNavMeshWalking__Offset=GetPropertyOffset(NativeClassPtr,"bProjectNavMeshWalking");
			bProjectNavMeshOnBothWorldChannels__Offset=GetPropertyOffset(NativeClassPtr,"bProjectNavMeshOnBothWorldChannels");
			AvoidanceConsiderationRadius__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceConsiderationRadius");
			RequestedVelocity__Offset=GetPropertyOffset(NativeClassPtr,"RequestedVelocity");
			AvoidanceUID__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceUID");
			AvoidanceGroup__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceGroup");
			GroupsToAvoid__Offset=GetPropertyOffset(NativeClassPtr,"GroupsToAvoid");
			GroupsToIgnore__Offset=GetPropertyOffset(NativeClassPtr,"GroupsToIgnore");
			AvoidanceWeight__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceWeight");
			PendingLaunchVelocity__Offset=GetPropertyOffset(NativeClassPtr,"PendingLaunchVelocity");
			NavMeshProjectionInterval__Offset=GetPropertyOffset(NativeClassPtr,"NavMeshProjectionInterval");
			NavMeshProjectionTimer__Offset=GetPropertyOffset(NativeClassPtr,"NavMeshProjectionTimer");
			NavMeshProjectionInterpSpeed__Offset=GetPropertyOffset(NativeClassPtr,"NavMeshProjectionInterpSpeed");
			NavMeshProjectionHeightScaleUp__Offset=GetPropertyOffset(NativeClassPtr,"NavMeshProjectionHeightScaleUp");
			NavMeshProjectionHeightScaleDown__Offset=GetPropertyOffset(NativeClassPtr,"NavMeshProjectionHeightScaleDown");
			NavWalkingFloorDistTolerance__Offset=GetPropertyOffset(NativeClassPtr,"NavWalkingFloorDistTolerance");
			PostPhysicsTickFunction__Offset=GetPropertyOffset(NativeClassPtr,"PostPhysicsTickFunction");
			MinTimeBetweenTimeStampResets__Offset=GetPropertyOffset(NativeClassPtr,"MinTimeBetweenTimeStampResets");
			CurrentRootMotion__Offset=GetPropertyOffset(NativeClassPtr,"CurrentRootMotion");
			RootMotionParams__Offset=GetPropertyOffset(NativeClassPtr,"RootMotionParams");
			AnimRootMotionVelocity__Offset=GetPropertyOffset(NativeClassPtr,"AnimRootMotionVelocity");
			bWasSimulatingRootMotion__Offset=GetPropertyOffset(NativeClassPtr,"bWasSimulatingRootMotion");
			
		}
		
	}
	
}
#endif
#endif
