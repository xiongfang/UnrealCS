#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// CharacterMovementComponent handles movement logic for the associated Character owner.
	/// It supports various movement modes including: walking, falling, swimming, flying, custom.
	/// Movement is affected primarily by current Velocity and Acceleration. Acceleration is updated each frame
	/// based on the input vector accumulated thus far (see UPawnMovementComponent::GetPendingInputVector()).
	/// Networking is fully implemented, with server-client correction and prediction included.
	/// @see ACharacter, UPawnMovementComponent
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn/Character/
	/// </summary>
	public partial class UCharacterMovementComponent
	{
		static readonly int CharacterOwner__Offset;
		/// <summary>Character movement component belongs to</summary>
		public ACharacter CharacterOwner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CharacterOwner__Offset); if (v == IntPtr.Zero)return null; ACharacter retValue = new ACharacter(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GravityScale__Offset;
		/// <summary>Custom gravity scale. Gravity is multiplied by this amount for the character.</summary>
		public float GravityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GravityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GravityScale__Offset, false);}
			
		}
		
		static readonly int MaxStepHeight__Offset;
		/// <summary>Maximum height character can step up</summary>
		public float MaxStepHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxStepHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxStepHeight__Offset, false);}
			
		}
		
		static readonly int JumpZVelocity__Offset;
		/// <summary>Initial velocity (instantaneous vertical acceleration) when jumping.</summary>
		public float JumpZVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpZVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpZVelocity__Offset, false);}
			
		}
		
		static readonly int JumpOffJumpZFactor__Offset;
		/// <summary>Fraction of JumpZVelocity to use when automatically "jumping off" of a base actor that's not allowed to be a base for a character. (For example, if you're not allowed to stand on other players.)</summary>
		public float JumpOffJumpZFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpOffJumpZFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpOffJumpZFactor__Offset, false);}
			
		}
		
		static readonly int WalkableFloorAngle__Offset;
		/// <summary>Max angle in degrees of a walkable surface. Any greater than this and it is too steep to be walkable.</summary>
		public float WalkableFloorAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WalkableFloorAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WalkableFloorAngle__Offset, false);}
			
		}
		
		static readonly int WalkableFloorZ__Offset;
		/// <summary>Minimum Z value for floor normal. If less, not a walkable surface. Computed from WalkableFloorAngle.</summary>
		public float WalkableFloorZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WalkableFloorZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WalkableFloorZ__Offset, false);}
			
		}
		
		static readonly int MovementMode__Offset;
		/// <summary>
		/// Actor's current movement mode (walking, falling, etc).
		///    - walking:  Walking on a surface, under the effects of friction, and able to "step up" barriers. Vertical velocity is zero.
		///    - falling:  Falling under the effects of gravity, after jumping or walking off the edge of a surface.
		///    - flying:   Flying, ignoring the effects of gravity.
		///    - swimming: Swimming through a fluid volume, under the effects of gravity and buoyancy.
		///    - custom:   User-defined custom movement mode, including many possible sub-modes.
		/// This is automatically replicated through the Character owner and for client-server movement functions.
		/// @see SetMovementMode(), CustomMovementMode
		/// </summary>
		public EMovementMode MovementMode
		{
			get{ CheckIsValid();return (EMovementMode)Marshal.PtrToStructure(_this.Get()+MovementMode__Offset, typeof(EMovementMode));}
			
		}
		
		static readonly int CustomMovementMode__Offset;
		/// <summary>
		/// Current custom sub-mode if MovementMode is set to Custom.
		/// This is automatically replicated through the Character owner and for client-server movement functions.
		/// @see SetMovementMode()
		/// </summary>
		public byte CustomMovementMode
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+CustomMovementMode__Offset, typeof(byte));}
			
		}
		
		static readonly int GroundFriction__Offset;
		/// <summary>
		/// Setting that affects movement control. Higher values allow faster changes in direction.
		/// If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero), where it is multiplied by BrakingFrictionFactor.
		/// When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity.
		/// This can be used to simulate slippery surfaces such as ice or oil by changing the value (possibly based on the material pawn is standing on).
		/// @see BrakingDecelerationWalking, BrakingFriction, bUseSeparateBrakingFriction, BrakingFrictionFactor
		/// </summary>
		public float GroundFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GroundFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroundFriction__Offset, false);}
			
		}
		
		static readonly int MaxWalkSpeed__Offset;
		/// <summary>The maximum ground speed when walking. Also determines maximum lateral speed when falling.</summary>
		public float MaxWalkSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxWalkSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxWalkSpeed__Offset, false);}
			
		}
		
		static readonly int MaxWalkSpeedCrouched__Offset;
		/// <summary>The maximum ground speed when walking and crouched.</summary>
		public float MaxWalkSpeedCrouched
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxWalkSpeedCrouched__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxWalkSpeedCrouched__Offset, false);}
			
		}
		
		static readonly int MaxSwimSpeed__Offset;
		/// <summary>The maximum swimming speed.</summary>
		public float MaxSwimSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSwimSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSwimSpeed__Offset, false);}
			
		}
		
		static readonly int MaxFlySpeed__Offset;
		/// <summary>The maximum flying speed.</summary>
		public float MaxFlySpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxFlySpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxFlySpeed__Offset, false);}
			
		}
		
		static readonly int MaxCustomMovementSpeed__Offset;
		/// <summary>The maximum speed when using Custom movement mode.</summary>
		public float MaxCustomMovementSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxCustomMovementSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxCustomMovementSpeed__Offset, false);}
			
		}
		
		static readonly int MaxAcceleration__Offset;
		/// <summary>Max Acceleration (rate of change of velocity)</summary>
		public float MaxAcceleration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxAcceleration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxAcceleration__Offset, false);}
			
		}
		
		static readonly int BrakingFrictionFactor__Offset;
		/// <summary>
		/// Factor used to multiply actual value of friction used when braking.
		/// This applies to any friction value that is currently used, which may depend on bUseSeparateBrakingFriction.
		/// @note This is 2 by default for historical reasons, a value of 1 gives the true drag equation.
		/// @see bUseSeparateBrakingFriction, GroundFriction, BrakingFriction
		/// </summary>
		public float BrakingFrictionFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingFrictionFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingFrictionFactor__Offset, false);}
			
		}
		
		static readonly int BrakingFriction__Offset;
		/// <summary>
		/// Friction (drag) coefficient applied when braking (whenever Acceleration = 0, or if character is exceeding max speed); actual value used is this multiplied by BrakingFrictionFactor.
		/// When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity.
		/// Braking is composed of friction (velocity-dependent drag) and constant deceleration.
		/// This is the current value, used in all movement modes; if this is not desired, override it or bUseSeparateBrakingFriction when movement mode changes.
		/// @note Only used if bUseSeparateBrakingFriction setting is true, otherwise current friction such as GroundFriction is used.
		/// @see bUseSeparateBrakingFriction, BrakingFrictionFactor, GroundFriction, BrakingDecelerationWalking
		/// </summary>
		public float BrakingFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingFriction__Offset, false);}
			
		}
		
		static readonly int bUseSeparateBrakingFriction__Offset;
		/// <summary>
		/// If true, BrakingFriction will be used to slow the character to a stop (when there is no Acceleration).
		/// If false, braking uses the same friction passed to CalcVelocity() (ie GroundFriction when walking), multiplied by BrakingFrictionFactor.
		/// This setting applies to all movement modes; if only desired in certain modes, consider toggling it when movement modes change.
		/// @see BrakingFriction
		/// </summary>
		public bool bUseSeparateBrakingFriction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseSeparateBrakingFriction__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseSeparateBrakingFriction__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BrakingDecelerationWalking__Offset;
		/// <summary>
		/// Deceleration when walking and not applying acceleration. This is a constant opposing force that directly lowers velocity by a constant value.
		/// @see GroundFriction, MaxAcceleration
		/// </summary>
		public float BrakingDecelerationWalking
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingDecelerationWalking__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingDecelerationWalking__Offset, false);}
			
		}
		
		static readonly int BrakingDecelerationFalling__Offset;
		/// <summary>
		/// Lateral deceleration when falling and not applying acceleration.
		/// @see MaxAcceleration
		/// </summary>
		public float BrakingDecelerationFalling
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingDecelerationFalling__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingDecelerationFalling__Offset, false);}
			
		}
		
		static readonly int BrakingDecelerationSwimming__Offset;
		/// <summary>
		/// Deceleration when swimming and not applying acceleration.
		/// @see MaxAcceleration
		/// </summary>
		public float BrakingDecelerationSwimming
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingDecelerationSwimming__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingDecelerationSwimming__Offset, false);}
			
		}
		
		static readonly int BrakingDecelerationFlying__Offset;
		/// <summary>
		/// Deceleration when flying and not applying acceleration.
		/// @see MaxAcceleration
		/// </summary>
		public float BrakingDecelerationFlying
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakingDecelerationFlying__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakingDecelerationFlying__Offset, false);}
			
		}
		
		static readonly int AirControl__Offset;
		/// <summary>
		/// When falling, amount of lateral movement control available to the character.
		/// 0 = no control, 1 = full control at max speed of MaxWalkSpeed.
		/// </summary>
		public float AirControl
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AirControl__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AirControl__Offset, false);}
			
		}
		
		static readonly int AirControlBoostMultiplier__Offset;
		/// <summary>
		/// When falling, multiplier applied to AirControl when lateral velocity is less than AirControlBoostVelocityThreshold.
		/// Setting this to zero will disable air control boosting. Final result is clamped at 1.
		/// </summary>
		public float AirControlBoostMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AirControlBoostMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AirControlBoostMultiplier__Offset, false);}
			
		}
		
		static readonly int AirControlBoostVelocityThreshold__Offset;
		/// <summary>
		/// When falling, if lateral velocity magnitude is less than this value, AirControl is multiplied by AirControlBoostMultiplier.
		/// Setting this to zero will disable air control boosting.
		/// </summary>
		public float AirControlBoostVelocityThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AirControlBoostVelocityThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AirControlBoostVelocityThreshold__Offset, false);}
			
		}
		
		static readonly int FallingLateralFriction__Offset;
		/// <summary>
		/// Friction to apply to lateral air movement when falling.
		/// If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero).
		/// @see BrakingFriction, bUseSeparateBrakingFriction
		/// </summary>
		public float FallingLateralFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FallingLateralFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FallingLateralFriction__Offset, false);}
			
		}
		
		static readonly int CrouchedHalfHeight__Offset;
		/// <summary>Collision half-height when crouching (component scale is applied separately)</summary>
		public float CrouchedHalfHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CrouchedHalfHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CrouchedHalfHeight__Offset, false);}
			
		}
		
		static readonly int Buoyancy__Offset;
		/// <summary>Water buoyancy. A ratio (1.0 = neutral buoyancy, 0.0 = no buoyancy)</summary>
		public float Buoyancy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Buoyancy__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Buoyancy__Offset, false);}
			
		}
		
		static readonly int PerchRadiusThreshold__Offset;
		/// <summary>
		/// Don't allow the character to perch on the edge of a surface if the contact is this close to the edge of the capsule.
		/// Note that characters will not fall off if they are within MaxStepHeight of a walkable surface below.
		/// </summary>
		public float PerchRadiusThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PerchRadiusThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PerchRadiusThreshold__Offset, false);}
			
		}
		
		static readonly int PerchAdditionalHeight__Offset;
		/// <summary>
		/// When perching on a ledge, add this additional distance to MaxStepHeight when determining how high above a walkable floor we can perch.
		/// Note that we still enforce MaxStepHeight to start the step up; this just allows the character to hang off the edge or step slightly higher off the floor.
		/// (@see PerchRadiusThreshold)
		/// </summary>
		public float PerchAdditionalHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PerchAdditionalHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PerchAdditionalHeight__Offset, false);}
			
		}
		
		static readonly int RotationRate__Offset;
		/// <summary>Change in rotation per second, used when UseControllerDesiredRotation or OrientRotationToMovement are true. Set a negative value for infinite rotation rate and instant turns.</summary>
		public FRotator RotationRate
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RotationRate__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationRate__Offset, false);}
			
		}
		
		static readonly int bUseControllerDesiredRotation__Offset;
		/// <summary>
		/// If true, smoothly rotate the Character toward the Controller's desired rotation (typically Controller->ControlRotation), using RotationRate as the rate of rotation change. Overridden by OrientRotationToMovement.
		/// Normally you will want to make sure that other settings are cleared, such as bUseControllerRotationYaw on the Character.
		/// </summary>
		public bool bUseControllerDesiredRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerDesiredRotation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseControllerDesiredRotation__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOrientRotationToMovement__Offset;
		/// <summary>
		/// If true, rotate the Character toward the direction of acceleration, using RotationRate as the rate of rotation change. Overrides UseControllerDesiredRotation.
		/// Normally you will want to make sure that other settings are cleared, such as bUseControllerRotationYaw on the Character.
		/// </summary>
		public bool bOrientRotationToMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrientRotationToMovement__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrientRotationToMovement__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMovementInProgress__Offset;
		/// <summary>
		/// True during movement update.
		/// Used internally so that attempts to change CharacterOwner and UpdatedComponent are deferred until after an update.
		/// @see IsMovementInProgress()
		/// </summary>
		public bool bMovementInProgress
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMovementInProgress__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bEnableScopedMovementUpdates__Offset;
		/// <summary>
		/// If true, high-level movement updates will be wrapped in a movement scope that accumulates updates and defers a bulk of the work until the end.
		/// When enabled, touch and hit events will not be triggered until the end of multiple moves within an update, which can improve performance.
		/// @see FScopedMovementUpdate
		/// </summary>
		public bool bEnableScopedMovementUpdates
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableScopedMovementUpdates__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableScopedMovementUpdates__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bForceMaxAccel__Offset;
		/// <summary>Ignores size of acceleration component, and forces max acceleration to drive character at full velocity.</summary>
		public bool bForceMaxAccel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceMaxAccel__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bRunPhysicsWithNoController__Offset;
		/// <summary>
		/// If true, movement will be performed even if there is no Controller for the Character owner.
		/// Normally without a Controller, movement will be aborted and velocity and acceleration are zeroed if the character is walking.
		/// Characters that are spawned without a Controller but with this flag enabled will initialize the movement mode to DefaultLandMovementMode or DefaultWaterMovementMode appropriately.
		/// @see DefaultLandMovementMode, DefaultWaterMovementMode
		/// </summary>
		public bool bRunPhysicsWithNoController
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRunPhysicsWithNoController__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRunPhysicsWithNoController__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bForceNextFloorCheck__Offset;
		/// <summary>
		/// Force the Character in MOVE_Walking to do a check for a valid floor even if he hasn't moved. Cleared after next floor check.
		/// Normally if bAlwaysCheckFloor is false we try to avoid the floor check unless some conditions are met, but this can be used to force the next check to always run.
		/// </summary>
		public bool bForceNextFloorCheck
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceNextFloorCheck__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceNextFloorCheck__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bShrinkProxyCapsule__Offset;
		/// <summary>
		/// If true, the capsule needs to be shrunk on this simulated proxy, to avoid replication rounding putting us in geometry.
		/// Whenever this is set to true, this will cause the capsule to be shrunk again on the next update, and then set to false.
		/// </summary>
		public bool bShrinkProxyCapsule
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShrinkProxyCapsule__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bCanWalkOffLedges__Offset;
		/// <summary>If true, Character can walk off a ledge.</summary>
		public bool bCanWalkOffLedges
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanWalkOffLedges__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanWalkOffLedges__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bCanWalkOffLedgesWhenCrouching__Offset;
		/// <summary>If true, Character can walk off a ledge when crouching.</summary>
		public bool bCanWalkOffLedgesWhenCrouching
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanWalkOffLedgesWhenCrouching__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanWalkOffLedgesWhenCrouching__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDeferUpdateMoveComponent__Offset;
		/// <summary>true to update CharacterOwner and UpdatedComponent after movement ends</summary>
		public bool bDeferUpdateMoveComponent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDeferUpdateMoveComponent__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int DeferredUpdatedMoveComponent__Offset;
		/// <summary>What to update CharacterOwner and UpdatedComponent after movement ends</summary>
		public USceneComponent DeferredUpdatedMoveComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DeferredUpdatedMoveComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaxOutOfWaterStepHeight__Offset;
		/// <summary>Maximum step height for getting out of water</summary>
		public float MaxOutOfWaterStepHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxOutOfWaterStepHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxOutOfWaterStepHeight__Offset, false);}
			
		}
		
		static readonly int OutofWaterZ__Offset;
		/// <summary>Z velocity applied when pawn tries to get out of water</summary>
		public float OutofWaterZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OutofWaterZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OutofWaterZ__Offset, false);}
			
		}
		
		static readonly int Mass__Offset;
		/// <summary>Mass of pawn (for when momentum is imparted to it).</summary>
		public float Mass
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Mass__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Mass__Offset, false);}
			
		}
		
		static readonly int bEnablePhysicsInteraction__Offset;
		/// <summary>If enabled, the player will interact with physics objects when walking into them.</summary>
		public bool bEnablePhysicsInteraction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePhysicsInteraction__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePhysicsInteraction__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTouchForceScaledToMass__Offset;
		/// <summary>If enabled, the TouchForceFactor is applied per kg mass of the affected object.</summary>
		public bool bTouchForceScaledToMass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTouchForceScaledToMass__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTouchForceScaledToMass__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bPushForceScaledToMass__Offset;
		/// <summary>If enabled, the PushForceFactor is applied per kg mass of the affected object.</summary>
		public bool bPushForceScaledToMass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPushForceScaledToMass__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPushForceScaledToMass__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bPushForceUsingZOffset__Offset;
		/// <summary>If enabled, the PushForce location is moved using PushForcePointZOffsetFactor. Otherwise simply use the impact point.</summary>
		public bool bPushForceUsingZOffset
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPushForceUsingZOffset__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPushForceUsingZOffset__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bScalePushForceToVelocity__Offset;
		/// <summary>
		/// If enabled, the applied push force will try to get the physics object to the same velocity than the player, not faster. This will only
		///               scale the force down, it will never apply more force than defined by PushForceFactor.
		/// </summary>
		public bool bScalePushForceToVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScalePushForceToVelocity__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bScalePushForceToVelocity__Offset, 1,0,1,255);}
			
		}
		
		static readonly int StandingDownwardForceScale__Offset;
		/// <summary>Force applied to objects we stand on (due to Mass and Gravity) is scaled by this amount.</summary>
		public float StandingDownwardForceScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StandingDownwardForceScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StandingDownwardForceScale__Offset, false);}
			
		}
		
		static readonly int InitialPushForceFactor__Offset;
		/// <summary>Initial impulse force to apply when the player bounces into a blocking physics object.</summary>
		public float InitialPushForceFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialPushForceFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialPushForceFactor__Offset, false);}
			
		}
		
		static readonly int PushForceFactor__Offset;
		/// <summary>Force to apply when the player collides with a blocking physics object.</summary>
		public float PushForceFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PushForceFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PushForceFactor__Offset, false);}
			
		}
		
		static readonly int PushForcePointZOffsetFactor__Offset;
		/// <summary>Z-Offset for the position the force is applied to. 0.0f is the center of the physics object, 1.0f is the top and -1.0f is the bottom of the object.</summary>
		public float PushForcePointZOffsetFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PushForcePointZOffsetFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PushForcePointZOffsetFactor__Offset, false);}
			
		}
		
		static readonly int TouchForceFactor__Offset;
		/// <summary>Force to apply to physics objects that are touched by the player.</summary>
		public float TouchForceFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TouchForceFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TouchForceFactor__Offset, false);}
			
		}
		
		static readonly int MinTouchForce__Offset;
		/// <summary>Minimum Force applied to touched physics objects. If < 0.0f, there is no minimum.</summary>
		public float MinTouchForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinTouchForce__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinTouchForce__Offset, false);}
			
		}
		
		static readonly int MaxTouchForce__Offset;
		/// <summary>Maximum force applied to touched physics objects. If < 0.0f, there is no maximum.</summary>
		public float MaxTouchForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxTouchForce__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxTouchForce__Offset, false);}
			
		}
		
		static readonly int RepulsionForce__Offset;
		/// <summary>Force per kg applied constantly to all overlapping components.</summary>
		public float RepulsionForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RepulsionForce__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RepulsionForce__Offset, false);}
			
		}
		
		static readonly int bForceBraking__Offset;
		/// <summary>Deprecated properties</summary>
		public bool bForceBraking
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceBraking__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CrouchedSpeedMultiplier__Offset;
		/// <summary>Multiplier to max ground speed to use when crouched</summary>
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
		/// <summary>
		/// Current acceleration vector (with magnitude).
		/// This is calculated each update based on the input vector and the constraints of MaxAcceleration and the current movement mode.
		/// </summary>
		public FVector Acceleration
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Acceleration__Offset, typeof(FVector));}
			
		}
		
		static readonly int LastUpdateLocation__Offset;
		/// <summary>Location after last PerformMovement or SimulateMovement update. Used internally to detect changes in position from outside character movement to try to validate the current floor.</summary>
		public FVector LastUpdateLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastUpdateLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int LastUpdateRotation__Offset;
		/// <summary>Rotation after last PerformMovement or SimulateMovement update.</summary>
		public FQuat LastUpdateRotation
		{
			get{ CheckIsValid();return (FQuat)Marshal.PtrToStructure(_this.Get()+LastUpdateRotation__Offset, typeof(FQuat));}
			
		}
		
		static readonly int LastUpdateVelocity__Offset;
		/// <summary>Velocity after last PerformMovement or SimulateMovement update. Used internally to detect changes in velocity from external sources.</summary>
		public FVector LastUpdateVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastUpdateVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int ServerLastTransformUpdateTimeStamp__Offset;
		/// <summary>Timestamp when location or rotation last changed during an update. Only valid on the server.</summary>
		public float ServerLastTransformUpdateTimeStamp
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ServerLastTransformUpdateTimeStamp__Offset, typeof(float));}
			
		}
		
		static readonly int PendingImpulseToApply__Offset;
		/// <summary>Accumulated impulse to be added next tick.</summary>
		public FVector PendingImpulseToApply
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PendingImpulseToApply__Offset, typeof(FVector));}
			
		}
		
		static readonly int PendingForceToApply__Offset;
		/// <summary>Accumulated force to be added next tick.</summary>
		public FVector PendingForceToApply
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PendingForceToApply__Offset, typeof(FVector));}
			
		}
		
		static readonly int AnalogInputModifier__Offset;
		/// <summary>Modifier to applied to values such as acceleration and max speed due to analog input.</summary>
		public float AnalogInputModifier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnalogInputModifier__Offset, typeof(float));}
			
		}
		
		static readonly int MaxSimulationTimeStep__Offset;
		/// <summary>
		/// Max time delta for each discrete simulation step.
		/// Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking).
		/// Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationIterations
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSimulationTimeStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationTimeStep__Offset, false);}
			
		}
		
		static readonly int MaxSimulationIterations__Offset;
		/// <summary>
		/// Max number of iterations used for each discrete simulation step.
		/// Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking).
		/// Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationTimeStep
		/// </summary>
		public int MaxSimulationIterations
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSimulationIterations__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationIterations__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationWithGeometry__Offset;
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.
		/// This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server.
		/// @see MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawn, MaxDepenetrationWithPawnAsProxy
		/// </summary>
		public float MaxDepenetrationWithGeometry
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationWithGeometry__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationWithGeometry__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationWithGeometryAsProxy__Offset;
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.
		/// This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server.
		/// @see MaxDepenetrationWithGeometry, MaxDepenetrationWithPawn, MaxDepenetrationWithPawnAsProxy
		/// </summary>
		public float MaxDepenetrationWithGeometryAsProxy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationWithGeometryAsProxy__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationWithGeometryAsProxy__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationWithPawn__Offset;
		/// <summary>
		/// Max distance we are allowed to depenetrate when moving out of other Pawns.
		/// @see MaxDepenetrationWithGeometry, MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawnAsProxy
		/// </summary>
		public float MaxDepenetrationWithPawn
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationWithPawn__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationWithPawn__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationWithPawnAsProxy__Offset;
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of other Pawns.
		/// Typically we don't want a large value, because we receive a server authoritative position that we should not then ignore by pushing them out of the local player.
		/// @see MaxDepenetrationWithGeometry, MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawn
		/// </summary>
		public float MaxDepenetrationWithPawnAsProxy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationWithPawnAsProxy__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationWithPawnAsProxy__Offset, false);}
			
		}
		
		static readonly int NetworkSimulatedSmoothLocationTime__Offset;
		/// <summary>How long to take to smoothly interpolate from the old pawn position on the client to the corrected one sent by the server. Not used by Linear smoothing.</summary>
		public float NetworkSimulatedSmoothLocationTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetworkSimulatedSmoothLocationTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetworkSimulatedSmoothLocationTime__Offset, false);}
			
		}
		
		static readonly int NetworkSimulatedSmoothRotationTime__Offset;
		/// <summary>How long to take to smoothly interpolate from the old pawn rotation on the client to the corrected one sent by the server. Not used by Linear smoothing.</summary>
		public float NetworkSimulatedSmoothRotationTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetworkSimulatedSmoothRotationTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetworkSimulatedSmoothRotationTime__Offset, false);}
			
		}
		
		static readonly int ListenServerNetworkSimulatedSmoothLocationTime__Offset;
		/// <summary>Similar setting as NetworkSimulatedSmoothLocationTime but only used on Listen servers.</summary>
		public float ListenServerNetworkSimulatedSmoothLocationTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ListenServerNetworkSimulatedSmoothLocationTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ListenServerNetworkSimulatedSmoothLocationTime__Offset, false);}
			
		}
		
		static readonly int ListenServerNetworkSimulatedSmoothRotationTime__Offset;
		/// <summary>Similar setting as NetworkSimulatedSmoothRotationTime but only used on Listen servers.</summary>
		public float ListenServerNetworkSimulatedSmoothRotationTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ListenServerNetworkSimulatedSmoothRotationTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ListenServerNetworkSimulatedSmoothRotationTime__Offset, false);}
			
		}
		
		static readonly int NetworkMaxSmoothUpdateDistance__Offset;
		/// <summary>Maximum distance character is allowed to lag behind server location when interpolating between updates.</summary>
		public float NetworkMaxSmoothUpdateDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetworkMaxSmoothUpdateDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetworkMaxSmoothUpdateDistance__Offset, false);}
			
		}
		
		static readonly int NetworkNoSmoothUpdateDistance__Offset;
		/// <summary>Maximum distance beyond which character is teleported to the new server location without any smoothing.</summary>
		public float NetworkNoSmoothUpdateDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetworkNoSmoothUpdateDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetworkNoSmoothUpdateDistance__Offset, false);}
			
		}
		
		static readonly int LedgeCheckThreshold__Offset;
		/// <summary>Used in determining if pawn is going off ledge.  If the ledge is "shorter" than this value then the pawn will be able to walk off it. *</summary>
		public float LedgeCheckThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LedgeCheckThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LedgeCheckThreshold__Offset, false);}
			
		}
		
		static readonly int JumpOutOfWaterPitch__Offset;
		/// <summary>When exiting water, jump if control pitch angle is this high or above.</summary>
		public float JumpOutOfWaterPitch
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+JumpOutOfWaterPitch__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+JumpOutOfWaterPitch__Offset, false);}
			
		}
		
		static readonly int CurrentFloor__Offset;
		/// <summary>Information about the floor the Character is standing on (updated only during walking movement).</summary>
		public FFindFloorResult CurrentFloor
		{
			get{ CheckIsValid();return (FFindFloorResult)Marshal.PtrToStructure(_this.Get()+CurrentFloor__Offset, typeof(FFindFloorResult));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CurrentFloor__Offset, false);}
			
		}
		
		static readonly int DefaultLandMovementMode__Offset;
		/// <summary>
		/// Default movement mode when not in water. Used at player startup or when teleported.
		/// @see DefaultWaterMovementMode
		/// @see bRunPhysicsWithNoController
		/// </summary>
		public EMovementMode DefaultLandMovementMode
		{
			get{ CheckIsValid();return (EMovementMode)Marshal.PtrToStructure(_this.Get()+DefaultLandMovementMode__Offset, typeof(EMovementMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultLandMovementMode__Offset, false);}
			
		}
		
		static readonly int DefaultWaterMovementMode__Offset;
		/// <summary>
		/// Default movement mode when in water. Used at player startup or when teleported.
		/// @see DefaultLandMovementMode
		/// @see bRunPhysicsWithNoController
		/// </summary>
		public EMovementMode DefaultWaterMovementMode
		{
			get{ CheckIsValid();return (EMovementMode)Marshal.PtrToStructure(_this.Get()+DefaultWaterMovementMode__Offset, typeof(EMovementMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultWaterMovementMode__Offset, false);}
			
		}
		
		static readonly int GroundMovementMode__Offset;
		/// <summary>
		/// Ground movement mode to switch to after falling and resuming ground movement.
		/// Only allowed values are: MOVE_Walking, MOVE_NavWalking.
		/// @see SetGroundMovementMode(), GetGroundMovementMode()
		/// </summary>
		public EMovementMode GroundMovementMode
		{
			get{ CheckIsValid();return (EMovementMode)Marshal.PtrToStructure(_this.Get()+GroundMovementMode__Offset, typeof(EMovementMode));}
			
		}
		
		static readonly int bMaintainHorizontalGroundVelocity__Offset;
		/// <summary>
		/// If true, walking movement always maintains horizontal velocity when moving up ramps, which causes movement up ramps to be faster parallel to the ramp surface.
		/// If false, then walking movement maintains velocity magnitude parallel to the ramp surface.
		/// </summary>
		public bool bMaintainHorizontalGroundVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMaintainHorizontalGroundVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMaintainHorizontalGroundVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bImpartBaseVelocityX__Offset;
		/// <summary>If true, impart the base actor's X velocity when falling off it (which includes jumping)</summary>
		public bool bImpartBaseVelocityX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpartBaseVelocityX__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpartBaseVelocityX__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bImpartBaseVelocityY__Offset;
		/// <summary>If true, impart the base actor's Y velocity when falling off it (which includes jumping)</summary>
		public bool bImpartBaseVelocityY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpartBaseVelocityY__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpartBaseVelocityY__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bImpartBaseVelocityZ__Offset;
		/// <summary>If true, impart the base actor's Z velocity when falling off it (which includes jumping)</summary>
		public bool bImpartBaseVelocityZ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpartBaseVelocityZ__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpartBaseVelocityZ__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bImpartBaseAngularVelocity__Offset;
		/// <summary>
		/// If true, impart the base component's tangential components of angular velocity when jumping or falling off it.
		/// Only those components of the velocity allowed by the separate component settings (bImpartBaseVelocityX etc) will be applied.
		/// @see bImpartBaseVelocityX, bImpartBaseVelocityY, bImpartBaseVelocityZ
		/// </summary>
		public bool bImpartBaseAngularVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpartBaseAngularVelocity__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpartBaseAngularVelocity__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bJustTeleported__Offset;
		/// <summary>Used by movement code to determine if a change in position is based on normal movement or a teleport. If not a teleport, velocity can be recomputed based on the change in position.</summary>
		public bool bJustTeleported
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bJustTeleported__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bJustTeleported__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bNetworkUpdateReceived__Offset;
		/// <summary>True when a network replication update is received for simulated proxies.</summary>
		public bool bNetworkUpdateReceived
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetworkUpdateReceived__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bNetworkMovementModeChanged__Offset;
		/// <summary>True when the networked movement mode has been replicated.</summary>
		public bool bNetworkMovementModeChanged
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetworkMovementModeChanged__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bIgnoreClientMovementErrorChecksAndCorrection__Offset;
		/// <summary>
		/// True when we should ignore server location difference checks for client error on this movement component
		/// This can be useful when character is moving at extreme speeds for a duration and you need it to look
		/// smooth on clients. Make sure to disable when done, as this would break this character's server-client
		/// movement correction.
		/// </summary>
		public bool bIgnoreClientMovementErrorChecksAndCorrection
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreClientMovementErrorChecksAndCorrection__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreClientMovementErrorChecksAndCorrection__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bNotifyApex__Offset;
		/// <summary>
		/// If true, event NotifyJumpApex() to CharacterOwner's controller when at apex of jump. Is cleared when event is triggered.
		/// By default this is off, and if you want the event to fire you typically set it to true when movement mode changes to "Falling" from another mode (see OnMovementModeChanged).
		/// </summary>
		public bool bNotifyApex
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNotifyApex__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNotifyApex__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bCheatFlying__Offset;
		/// <summary>Instantly stop when in flying mode and no acceleration is being applied.</summary>
		public bool bCheatFlying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCheatFlying__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bWantsToCrouch__Offset;
		/// <summary>If true, try to crouch (or keep crouching) on next update. If false, try to stop crouching on next update.</summary>
		public bool bWantsToCrouch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWantsToCrouch__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWantsToCrouch__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bCrouchMaintainsBaseLocation__Offset;
		/// <summary>
		/// If true, crouching should keep the base of the capsule in place by lowering the center of the shrunken capsule. If false, the base of the capsule moves up and the center stays in place.
		/// The same behavior applies when the character uncrouches: if true, the base is kept in the same location and the center moves up. If false, the capsule grows and only moves up if the base impacts something.
		/// By default this variable is set when the movement mode changes: set to true when walking and false otherwise. Feel free to override the behavior when the movement mode changes.
		/// </summary>
		public bool bCrouchMaintainsBaseLocation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCrouchMaintainsBaseLocation__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCrouchMaintainsBaseLocation__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bIgnoreBaseRotation__Offset;
		/// <summary>
		/// Whether the character ignores changes in rotation of the base it is standing on.
		/// If true, the character maintains current world rotation.
		/// If false, the character rotates with the moving base.
		/// </summary>
		public bool bIgnoreBaseRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreBaseRotation__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreBaseRotation__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bFastAttachedMove__Offset;
		/// <summary>
		/// Set this to true if riding on a moving base that you know is clear from non-moving world obstructions.
		/// Optimization to avoid sweeps during based movement, use with care.
		/// </summary>
		public bool bFastAttachedMove
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFastAttachedMove__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bAlwaysCheckFloor__Offset;
		/// <summary>
		/// Whether we always force floor checks for stationary Characters while walking.
		/// Normally floor checks are avoided if possible when not moving, but this can be used to force them if there are use-cases where they are being skipped erroneously
		/// (such as objects moving up into the character from below).
		/// </summary>
		public bool bAlwaysCheckFloor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysCheckFloor__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysCheckFloor__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUseFlatBaseForFloorChecks__Offset;
		/// <summary>
		/// Performs floor checks as if the character is using a shape with a flat base.
		/// This avoids the situation where characters slowly lower off the side of a ledge (as their capsule 'balances' on the edge).
		/// </summary>
		public bool bUseFlatBaseForFloorChecks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFlatBaseForFloorChecks__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFlatBaseForFloorChecks__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPerformingJumpOff__Offset;
		/// <summary>Used to prevent reentry of JumpOff()</summary>
		public bool bPerformingJumpOff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPerformingJumpOff__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bWantsToLeaveNavWalking__Offset;
		/// <summary>Used to safely leave NavWalking movement mode</summary>
		public bool bWantsToLeaveNavWalking
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWantsToLeaveNavWalking__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bUseRVOAvoidance__Offset;
		/// <summary>If set, component will use RVO avoidance. This only runs on the server.</summary>
		public bool bUseRVOAvoidance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRVOAvoidance__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRVOAvoidance__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bRequestedMoveUseAcceleration__Offset;
		/// <summary>
		/// Should use acceleration for path following?
		/// If true, acceleration is applied when path following to reach the target velocity.
		/// If false, path following velocity is set directly, disregarding acceleration.
		/// </summary>
		public bool bRequestedMoveUseAcceleration
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequestedMoveUseAcceleration__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRequestedMoveUseAcceleration__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bHasRequestedVelocity__Offset;
		/// <summary>Was velocity requested by path following?</summary>
		public bool bHasRequestedVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasRequestedVelocity__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bRequestedMoveWithMaxSpeed__Offset;
		/// <summary>Was acceleration requested to be always max speed?</summary>
		public bool bRequestedMoveWithMaxSpeed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequestedMoveWithMaxSpeed__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bWasAvoidanceUpdated__Offset;
		/// <summary>Was avoidance updated in this frame?</summary>
		public bool bWasAvoidanceUpdated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWasAvoidanceUpdated__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bProjectNavMeshWalking__Offset;
		/// <summary>Whether to raycast to underlying geometry to better conform navmesh-walking characters</summary>
		public bool bProjectNavMeshWalking
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bProjectNavMeshWalking__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bProjectNavMeshWalking__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bProjectNavMeshOnBothWorldChannels__Offset;
		/// <summary>Use both WorldStatic and WorldDynamic channels for NavWalking geometry conforming</summary>
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
		/// <summary>
		/// Velocity requested by path following.
		/// @see RequestDirectMove()
		/// </summary>
		public FVector RequestedVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RequestedVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int AvoidanceUID__Offset;
		/// <summary>No default value, for now it's assumed to be valid if GetAvoidanceManager() returns non-NULL.</summary>
		public int AvoidanceUID
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+AvoidanceUID__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceUID__Offset, false);}
			
		}
		
		static readonly int AvoidanceGroup__Offset;
		/// <summary>Moving actor's group mask</summary>
		public FNavAvoidanceMask AvoidanceGroup
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+AvoidanceGroup__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceGroup__Offset, false);}
			
		}
		
		static readonly int GroupsToAvoid__Offset;
		/// <summary>Will avoid other agents if they are in one of specified groups</summary>
		public FNavAvoidanceMask GroupsToAvoid
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+GroupsToAvoid__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupsToAvoid__Offset, false);}
			
		}
		
		static readonly int GroupsToIgnore__Offset;
		/// <summary>Will NOT avoid other agents if they are in one of specified groups, higher priority than GroupsToAvoid</summary>
		public FNavAvoidanceMask GroupsToIgnore
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+GroupsToIgnore__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupsToIgnore__Offset, false);}
			
		}
		
		static readonly int AvoidanceWeight__Offset;
		/// <summary>De facto default value 0.5 (due to that being the default in the avoidance registration function), indicates RVO behavior.</summary>
		public float AvoidanceWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AvoidanceWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceWeight__Offset, false);}
			
		}
		
		static readonly int PendingLaunchVelocity__Offset;
		/// <summary>Temporarily holds launch velocity when pawn is to be launched so it happens at end of movement.</summary>
		public FVector PendingLaunchVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PendingLaunchVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int NavMeshProjectionInterval__Offset;
		/// <summary>How often we should raycast to project from navmesh to underlying geometry</summary>
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
		/// <summary>Speed at which to interpolate agent navmesh offset between traces. 0: Instant (no interp) > 0: Interp speed")</summary>
		public float NavMeshProjectionInterpSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavMeshProjectionInterpSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavMeshProjectionInterpSpeed__Offset, false);}
			
		}
		
		static readonly int NavMeshProjectionHeightScaleUp__Offset;
		/// <summary>
		/// Scale of the total capsule height to use for projection from navmesh to underlying geometry in the upward direction.
		/// In other words, start the trace at [CapsuleHeight * NavMeshProjectionHeightScaleUp] above nav mesh.
		/// </summary>
		public float NavMeshProjectionHeightScaleUp
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavMeshProjectionHeightScaleUp__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavMeshProjectionHeightScaleUp__Offset, false);}
			
		}
		
		static readonly int NavMeshProjectionHeightScaleDown__Offset;
		/// <summary>
		/// Scale of the total capsule height to use for projection from navmesh to underlying geometry in the downward direction.
		/// In other words, trace down to [CapsuleHeight * NavMeshProjectionHeightScaleDown] below nav mesh.
		/// </summary>
		public float NavMeshProjectionHeightScaleDown
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavMeshProjectionHeightScaleDown__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavMeshProjectionHeightScaleDown__Offset, false);}
			
		}
		
		static readonly int NavWalkingFloorDistTolerance__Offset;
		/// <summary>Ignore small differences in ground height between server and client data during NavWalking mode</summary>
		public float NavWalkingFloorDistTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NavWalkingFloorDistTolerance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavWalkingFloorDistTolerance__Offset, false);}
			
		}
		
		static readonly int PostPhysicsTickFunction__Offset;
		/// <summary>Post-physics tick function for this character</summary>
		public FCharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction
		{
			get{ CheckIsValid();return (FCharacterMovementComponentPostPhysicsTickFunction)Marshal.PtrToStructure(_this.Get()+PostPhysicsTickFunction__Offset, typeof(FCharacterMovementComponentPostPhysicsTickFunction));}
			
		}
		
		static readonly int MinTimeBetweenTimeStampResets__Offset;
		/// <summary>
		/// Minimum time between client TimeStamp resets.
		///        !! This has to be large enough so that we don't confuse the server if the client can stall or timeout.
		///        We do this as we use floats for TimeStamps, and server derives DeltaTime from two TimeStamps.
		///        As time goes on, accuracy decreases from those floating point numbers.
		///        So we trigger a TimeStamp reset at regular intervals to maintain a high level of accuracy.
		/// </summary>
		public float MinTimeBetweenTimeStampResets
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinTimeBetweenTimeStampResets__Offset, typeof(float));}
			
		}
		
		static readonly int CurrentRootMotion__Offset;
		/// <summary>Root Motion Group containing active root motion sources being applied to movement</summary>
		public FRootMotionSourceGroup CurrentRootMotion
		{
			get{ CheckIsValid();return (FRootMotionSourceGroup)Marshal.PtrToStructure(_this.Get()+CurrentRootMotion__Offset, typeof(FRootMotionSourceGroup));}
			
		}
		
		static readonly int RootMotionParams__Offset;
		/// <summary>
		/// Root Motion movement params. Holds result of anim montage root motion during PerformMovement(), and is overridden
		///  during autonomous move playback to force historical root motion for MoveAutonomous() calls
		/// </summary>
		public FRootMotionMovementParams RootMotionParams
		{
			get{ CheckIsValid();return (FRootMotionMovementParams)Marshal.PtrToStructure(_this.Get()+RootMotionParams__Offset, typeof(FRootMotionMovementParams));}
			
		}
		
		static readonly int AnimRootMotionVelocity__Offset;
		/// <summary>Velocity extracted from RootMotionParams when there is anim root motion active. Invalid to use when HasAnimRootMotion() returns false.</summary>
		public FVector AnimRootMotionVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+AnimRootMotionVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int bWasSimulatingRootMotion__Offset;
		/// <summary>True when SimulatedProxies are simulating RootMotion</summary>
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
