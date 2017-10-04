using System;
namespace UnrealEngine
{
	public partial class UCharacterMovementComponent:UPawnMovementComponent
	{
		/// <summary>Replicate root motion source correction to client when using root motion for movement.</summary>
		public extern virtual void ClientAdjustRootMotionSourcePosition(float TimeStamp,FRootMotionSourceGroup ServerRootMotion,bool bHasAnimRootMotion,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,FName ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode);
		/// <summary>Replicate position correction to client when using root motion for movement. (animation root motion specific)</summary>
		public extern virtual void ClientAdjustRootMotionPosition(float TimeStamp,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,FName ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode);
		/// <summary>Bandwidth saving version, when velocity is zeroed</summary>
		public extern virtual void ClientVeryShortAdjustPosition(float TimeStamp,FVector NewLoc,UPrimitiveComponent NewBase,FName NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode);
		/// <summary>Replicate position correction to client, associated with a timestamped servermove.  Client will replay subsequent moves after applying adjustment.</summary>
		public extern virtual void ClientAdjustPosition(float TimeStamp,FVector NewLoc,FVector NewVel,UPrimitiveComponent NewBase,FName NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode);
		/// <summary>If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves</summary>
		public extern virtual void ClientAckGoodMove(float TimeStamp);
		/// <summary>Resending an (important) old move. Process it if not already processed.</summary>
		public extern virtual void ServerMoveOld(float OldTimeStamp,FVector_NetQuantize10 OldAccel,byte OldMoveFlags);
		/// <summary>Replicated function sent by client to server - contains client movement and view info for two moves. First move is non root motion, second is root motion.</summary>
		public extern virtual void ServerMoveDualHybridRootMotion(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,FName ClientBaseBoneName,byte ClientMovementMode);
		/// <summary>Replicated function sent by client to server - contains client movement and view info for two moves.</summary>
		public extern virtual void ServerMoveDual(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,FName ClientBaseBoneName,byte ClientMovementMode);
		/// <summary>Replicated function sent by client to server - contains client movement and view info.</summary>
		public extern virtual void ServerMove(float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte CompressedMoveFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,FName ClientBaseBoneName,byte ClientMovementMode);
		/// <summary>
		/// Compute distance to the floor from bottom sphere of capsule and store the result in FloorResult.
		/// This distance is the swept distance of the capsule to the first point impacted by the lower hemisphere, or distance from the bottom of the capsule in the case of a line trace.
		/// This function does not care if collision is disabled on the capsule (unlike FindFloor).
		/// @param CapsuleLocation                Location where the capsule sweep should originate
		/// @param LineDistance                   If non-zero, max distance to test for a simple line check from the capsule base. Used only if the sweep test fails to find a walkable floor, and only returns a valid result if the impact normal is a walkable normal.
		/// @param SweepDistance                  If non-zero, max distance to use when sweeping a capsule downwards for the test. MUST be greater than or equal to the line distance.
		/// @param SweepRadius                    The radius to use for sweep tests. Should be <= capsule radius.
		/// @param FloorResult                    Result of the floor check
		/// </summary>
		public extern void K2_ComputeFloorDist(FVector CapsuleLocation,float LineDistance,float SweepDistance,float SweepRadius,out FFindFloorResult FloorResult);
		/// <summary>
		/// Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result.
		/// No floor will be found if collision is disabled on the capsule!
		/// @param CapsuleLocation                Location where the capsule sweep should originate
		/// @param FloorResult                    Result of the floor check
		/// </summary>
		public extern void K2_FindFloor(FVector CapsuleLocation,out FFindFloorResult FloorResult);
		/// <summary>Set the Z component of the normal of the steepest walkable surface for the character. Also computes WalkableFloorAngle.</summary>
		public extern void SetWalkableFloorZ(float InWalkableFloorZ);
		/// <summary>Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable.</summary>
		public extern float K2_GetWalkableFloorZ();
		/// <summary>Set the max angle in degrees of a walkable surface for the character. Also computes WalkableFloorZ.</summary>
		public extern void SetWalkableFloorAngle(float InWalkableFloorAngle);
		/// <summary>Get the max angle in degrees of a walkable surface for the character.</summary>
		public extern float K2_GetWalkableFloorAngle();
		/// <summary>Return true if the hit result should be considered a walkable surface for the character.</summary>
		public extern virtual bool IsWalkable(FHitResult Hit);
		/// <summary>
		/// Returns the radius within which we can stand on the edge of a surface without falling (if this is a walkable surface).
		/// Simply computed as the capsule radius minus the result of GetPerchRadiusThreshold().
		/// </summary>
		public extern float GetValidPerchRadius();
		/// <summary>@return The distance from the edge of the capsule within which we don't allow the character to perch on the edge of a surface.</summary>
		public extern float GetPerchRadiusThreshold();
		/// <summary>
		/// Add force to character. Forces are accumulated each tick and applied together
		/// so multiple calls to this function will accumulate.
		/// Forces are scaled depending on timestep, so they can be applied each frame. If you want an
		/// instantaneous force, use AddImpulse.
		/// Adding a force always takes the actor's mass into account.
		/// Note that changing the momentum of characters like this can change the movement mode.
		/// @param       Force                   Force to apply.
		/// </summary>
		public extern virtual void AddForce(FVector Force);
		/// <summary>
		/// Add impulse to character. Impulses are accumulated each tick and applied together
		/// so multiple calls to this function will accumulate.
		/// An impulse is an instantaneous force, usually applied once. If you want to continually apply
		/// forces each frame, use AddForce().
		/// Note that changing the momentum of characters like this can change the movement mode.
		/// @param       Impulse                         Impulse to apply.
		/// @param       bVelocityChange         Whether or not the impulse is relative to mass.
		/// </summary>
		public extern virtual void AddImpulse(FVector Impulse,bool bVelocityChange=false);
		/// <summary>@return Modifier [0..1] based on the magnitude of the last input vector, which is used to modify the acceleration and max speed during movement.</summary>
		public extern float GetAnalogInputModifier();
		/// <summary>@return Current acceleration, computed from input vector each update.</summary>
		public extern FVector GetCurrentAcceleration();
		/// <summary>@return Maximum deceleration for the current state when braking (ie when there is no acceleration).</summary>
		public extern virtual float GetMaxBrakingDeceleration();
		/// <summary>@return Maximum acceleration for the current state.</summary>
		public extern virtual float GetMaxAcceleration();
		/// <summary>Compute the max jump height based on the JumpZVelocity velocity and gravity.</summary>
		public extern virtual float GetMaxJumpHeight();
		/// <summary>
		/// Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity.
		/// This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes.
		/// @param       DeltaTime                                               time elapsed since last frame.
		/// @param       Friction                                                coefficient of friction when not accelerating, or in the direction opposite acceleration.
		/// @param       bFluid                                                  true if moving through a fluid, causing Friction to always be applied regardless of acceleration.
		/// @param       BrakingDeceleration                             deceleration applied when not accelerating, or when exceeding max velocity.
		/// </summary>
		public extern virtual void CalcVelocity(float DeltaTime,float Friction,bool bFluid,float BrakingDeceleration);
		/// <summary>
		/// If we have a movement base, get the velocity that should be imparted by that base, usually when jumping off of it.
		/// Only applies the components of the velocity enabled by bImpartBaseVelocityX, bImpartBaseVelocityY, bImpartBaseVelocityZ.
		/// </summary>
		public extern virtual FVector GetImpartedMovementBaseVelocity();
		/// <summary>Return PrimitiveComponent we are based on (standing and walking on).</summary>
		public extern UPrimitiveComponent GetMovementBase();
		/// <summary>Make movement impossible (sets movement mode to MOVE_None).</summary>
		public extern virtual void DisableMovement();
		/// <summary>@return true if the character is in the 'Walking' movement mode.</summary>
		public extern bool IsWalking();
		/// <summary>
		/// Change movement mode.
		/// @param NewMovementMode       The new movement mode
		/// @param NewCustomMode         The new custom sub-mode, only applicable if NewMovementMode is Custom.
		/// </summary>
		public extern virtual void SetMovementMode(EMovementMode NewMovementMode,byte NewCustomMode=0);
		/// <summary>Get the Character that owns UpdatedComponent.</summary>
		public extern ACharacter GetCharacterOwner();
		/// <summary>Change avoidance state and registers in RVO manager if needed</summary>
		public extern void SetAvoidanceEnabled(bool bEnable);
		public extern void SetGroupsToIgnoreMask(FNavAvoidanceMask GroupMask);
		public extern void SetGroupsToAvoidMask(FNavAvoidanceMask GroupMask);
		public extern void SetAvoidanceGroupMask(FNavAvoidanceMask GroupMask);
		/// <summary>Character movement component belongs to</summary>
		public ACharacter CharacterOwner;
		
		/// <summary>Custom gravity scale. Gravity is multiplied by this amount for the character.</summary>
		public float GravityScale;
		
		/// <summary>Maximum height character can step up</summary>
		public float MaxStepHeight;
		
		/// <summary>Initial velocity (instantaneous vertical acceleration) when jumping.</summary>
		public float JumpZVelocity;
		
		/// <summary>Fraction of JumpZVelocity to use when automatically "jumping off" of a base actor that's not allowed to be a base for a character. (For example, if you're not allowed to stand on other players.)</summary>
		public float JumpOffJumpZFactor;
		
		/// <summary>Max angle in degrees of a walkable surface. Any greater than this and it is too steep to be walkable.</summary>
		public float WalkableFloorAngle;
		
		/// <summary>Minimum Z value for floor normal. If less, not a walkable surface. Computed from WalkableFloorAngle.</summary>
		public float WalkableFloorZ;
		
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
		public EMovementMode MovementMode;
		
		/// <summary>
		/// Current custom sub-mode if MovementMode is set to Custom.
		/// This is automatically replicated through the Character owner and for client-server movement functions.
		/// @see SetMovementMode()
		/// </summary>
		public byte CustomMovementMode;
		
		/// <summary>
		/// Setting that affects movement control. Higher values allow faster changes in direction.
		/// If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero), where it is multiplied by BrakingFrictionFactor.
		/// When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity.
		/// This can be used to simulate slippery surfaces such as ice or oil by changing the value (possibly based on the material pawn is standing on).
		/// @see BrakingDecelerationWalking, BrakingFriction, bUseSeparateBrakingFriction, BrakingFrictionFactor
		/// </summary>
		public float GroundFriction;
		
		/// <summary>The maximum ground speed when walking. Also determines maximum lateral speed when falling.</summary>
		public float MaxWalkSpeed;
		
		/// <summary>The maximum ground speed when walking and crouched.</summary>
		public float MaxWalkSpeedCrouched;
		
		/// <summary>The maximum swimming speed.</summary>
		public float MaxSwimSpeed;
		
		/// <summary>The maximum flying speed.</summary>
		public float MaxFlySpeed;
		
		/// <summary>The maximum speed when using Custom movement mode.</summary>
		public float MaxCustomMovementSpeed;
		
		/// <summary>Max Acceleration (rate of change of velocity)</summary>
		public float MaxAcceleration;
		
		/// <summary>
		/// Factor used to multiply actual value of friction used when braking.
		/// This applies to any friction value that is currently used, which may depend on bUseSeparateBrakingFriction.
		/// @note This is 2 by default for historical reasons, a value of 1 gives the true drag equation.
		/// @see bUseSeparateBrakingFriction, GroundFriction, BrakingFriction
		/// </summary>
		public float BrakingFrictionFactor;
		
		/// <summary>
		/// Friction (drag) coefficient applied when braking (whenever Acceleration = 0, or if character is exceeding max speed); actual value used is this multiplied by BrakingFrictionFactor.
		/// When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity.
		/// Braking is composed of friction (velocity-dependent drag) and constant deceleration.
		/// This is the current value, used in all movement modes; if this is not desired, override it or bUseSeparateBrakingFriction when movement mode changes.
		/// @note Only used if bUseSeparateBrakingFriction setting is true, otherwise current friction such as GroundFriction is used.
		/// @see bUseSeparateBrakingFriction, BrakingFrictionFactor, GroundFriction, BrakingDecelerationWalking
		/// </summary>
		public float BrakingFriction;
		
		/// <summary>
		/// If true, BrakingFriction will be used to slow the character to a stop (when there is no Acceleration).
		/// If false, braking uses the same friction passed to CalcVelocity() (ie GroundFriction when walking), multiplied by BrakingFrictionFactor.
		/// This setting applies to all movement modes; if only desired in certain modes, consider toggling it when movement modes change.
		/// @see BrakingFriction
		/// </summary>
		public bool bUseSeparateBrakingFriction;
		
		/// <summary>
		/// Deceleration when walking and not applying acceleration. This is a constant opposing force that directly lowers velocity by a constant value.
		/// @see GroundFriction, MaxAcceleration
		/// </summary>
		public float BrakingDecelerationWalking;
		
		/// <summary>
		/// Lateral deceleration when falling and not applying acceleration.
		/// @see MaxAcceleration
		/// </summary>
		public float BrakingDecelerationFalling;
		
		/// <summary>
		/// Deceleration when swimming and not applying acceleration.
		/// @see MaxAcceleration
		/// </summary>
		public float BrakingDecelerationSwimming;
		
		/// <summary>
		/// Deceleration when flying and not applying acceleration.
		/// @see MaxAcceleration
		/// </summary>
		public float BrakingDecelerationFlying;
		
		/// <summary>
		/// When falling, amount of lateral movement control available to the character.
		/// 0 = no control, 1 = full control at max speed of MaxWalkSpeed.
		/// </summary>
		public float AirControl;
		
		/// <summary>
		/// When falling, multiplier applied to AirControl when lateral velocity is less than AirControlBoostVelocityThreshold.
		/// Setting this to zero will disable air control boosting. Final result is clamped at 1.
		/// </summary>
		public float AirControlBoostMultiplier;
		
		/// <summary>
		/// When falling, if lateral velocity magnitude is less than this value, AirControl is multiplied by AirControlBoostMultiplier.
		/// Setting this to zero will disable air control boosting.
		/// </summary>
		public float AirControlBoostVelocityThreshold;
		
		/// <summary>
		/// Friction to apply to lateral air movement when falling.
		/// If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero).
		/// @see BrakingFriction, bUseSeparateBrakingFriction
		/// </summary>
		public float FallingLateralFriction;
		
		/// <summary>Collision half-height when crouching (component scale is applied separately)</summary>
		public float CrouchedHalfHeight;
		
		/// <summary>Water buoyancy. A ratio (1.0 = neutral buoyancy, 0.0 = no buoyancy)</summary>
		public float Buoyancy;
		
		/// <summary>
		/// Don't allow the character to perch on the edge of a surface if the contact is this close to the edge of the capsule.
		/// Note that characters will not fall off if they are within MaxStepHeight of a walkable surface below.
		/// </summary>
		public float PerchRadiusThreshold;
		
		/// <summary>
		/// When perching on a ledge, add this additional distance to MaxStepHeight when determining how high above a walkable floor we can perch.
		/// Note that we still enforce MaxStepHeight to start the step up; this just allows the character to hang off the edge or step slightly higher off the floor.
		/// (@see PerchRadiusThreshold)
		/// </summary>
		public float PerchAdditionalHeight;
		
		/// <summary>Change in rotation per second, used when UseControllerDesiredRotation or OrientRotationToMovement are true. Set a negative value for infinite rotation rate and instant turns.</summary>
		public FRotator RotationRate;
		
		/// <summary>
		/// If true, smoothly rotate the Character toward the Controller's desired rotation (typically Controller->ControlRotation), using RotationRate as the rate of rotation change. Overridden by OrientRotationToMovement.
		/// Normally you will want to make sure that other settings are cleared, such as bUseControllerRotationYaw on the Character.
		/// </summary>
		public bool bUseControllerDesiredRotation;
		
		/// <summary>
		/// If true, rotate the Character toward the direction of acceleration, using RotationRate as the rate of rotation change. Overrides UseControllerDesiredRotation.
		/// Normally you will want to make sure that other settings are cleared, such as bUseControllerRotationYaw on the Character.
		/// </summary>
		public bool bOrientRotationToMovement;
		
		/// <summary>
		/// True during movement update.
		/// Used internally so that attempts to change CharacterOwner and UpdatedComponent are deferred until after an update.
		/// @see IsMovementInProgress()
		/// </summary>
		public bool bMovementInProgress;
		
		/// <summary>
		/// If true, high-level movement updates will be wrapped in a movement scope that accumulates updates and defers a bulk of the work until the end.
		/// When enabled, touch and hit events will not be triggered until the end of multiple moves within an update, which can improve performance.
		/// @see FScopedMovementUpdate
		/// </summary>
		public bool bEnableScopedMovementUpdates;
		
		/// <summary>Ignores size of acceleration component, and forces max acceleration to drive character at full velocity.</summary>
		public bool bForceMaxAccel;
		
		/// <summary>
		/// If true, movement will be performed even if there is no Controller for the Character owner.
		/// Normally without a Controller, movement will be aborted and velocity and acceleration are zeroed if the character is walking.
		/// Characters that are spawned without a Controller but with this flag enabled will initialize the movement mode to DefaultLandMovementMode or DefaultWaterMovementMode appropriately.
		/// @see DefaultLandMovementMode, DefaultWaterMovementMode
		/// </summary>
		public bool bRunPhysicsWithNoController;
		
		/// <summary>
		/// Force the Character in MOVE_Walking to do a check for a valid floor even if he hasn't moved. Cleared after next floor check.
		/// Normally if bAlwaysCheckFloor is false we try to avoid the floor check unless some conditions are met, but this can be used to force the next check to always run.
		/// </summary>
		public bool bForceNextFloorCheck;
		
		/// <summary>
		/// If true, the capsule needs to be shrunk on this simulated proxy, to avoid replication rounding putting us in geometry.
		/// Whenever this is set to true, this will cause the capsule to be shrunk again on the next update, and then set to false.
		/// </summary>
		public bool bShrinkProxyCapsule;
		
		/// <summary>If true, Character can walk off a ledge.</summary>
		public bool bCanWalkOffLedges;
		
		/// <summary>If true, Character can walk off a ledge when crouching.</summary>
		public bool bCanWalkOffLedgesWhenCrouching;
		
		/// <summary>true to update CharacterOwner and UpdatedComponent after movement ends</summary>
		public bool bDeferUpdateMoveComponent;
		
		/// <summary>What to update CharacterOwner and UpdatedComponent after movement ends</summary>
		public USceneComponent DeferredUpdatedMoveComponent;
		
		/// <summary>Maximum step height for getting out of water</summary>
		public float MaxOutOfWaterStepHeight;
		
		/// <summary>Z velocity applied when pawn tries to get out of water</summary>
		public float OutofWaterZ;
		
		/// <summary>Mass of pawn (for when momentum is imparted to it).</summary>
		public float Mass;
		
		/// <summary>If enabled, the player will interact with physics objects when walking into them.</summary>
		public bool bEnablePhysicsInteraction;
		
		/// <summary>If enabled, the TouchForceFactor is applied per kg mass of the affected object.</summary>
		public bool bTouchForceScaledToMass;
		
		/// <summary>If enabled, the PushForceFactor is applied per kg mass of the affected object.</summary>
		public bool bPushForceScaledToMass;
		
		/// <summary>If enabled, the PushForce location is moved using PushForcePointZOffsetFactor. Otherwise simply use the impact point.</summary>
		public bool bPushForceUsingZOffset;
		
		/// <summary>
		/// If enabled, the applied push force will try to get the physics object to the same velocity than the player, not faster. This will only
		///               scale the force down, it will never apply more force than defined by PushForceFactor.
		/// </summary>
		public bool bScalePushForceToVelocity;
		
		/// <summary>Force applied to objects we stand on (due to Mass and Gravity) is scaled by this amount.</summary>
		public float StandingDownwardForceScale;
		
		/// <summary>Initial impulse force to apply when the player bounces into a blocking physics object.</summary>
		public float InitialPushForceFactor;
		
		/// <summary>Force to apply when the player collides with a blocking physics object.</summary>
		public float PushForceFactor;
		
		/// <summary>Z-Offset for the position the force is applied to. 0.0f is the center of the physics object, 1.0f is the top and -1.0f is the bottom of the object.</summary>
		public float PushForcePointZOffsetFactor;
		
		/// <summary>Force to apply to physics objects that are touched by the player.</summary>
		public float TouchForceFactor;
		
		/// <summary>Minimum Force applied to touched physics objects. If < 0.0f, there is no minimum.</summary>
		public float MinTouchForce;
		
		/// <summary>Maximum force applied to touched physics objects. If < 0.0f, there is no maximum.</summary>
		public float MaxTouchForce;
		
		/// <summary>Force per kg applied constantly to all overlapping components.</summary>
		public float RepulsionForce;
		
		/// <summary>Deprecated properties</summary>
		public bool bForceBraking;
		
		/// <summary>Multiplier to max ground speed to use when crouched</summary>
		public float CrouchedSpeedMultiplier;
		
		public float UpperImpactNormalScale;
		
		/// <summary>
		/// Current acceleration vector (with magnitude).
		/// This is calculated each update based on the input vector and the constraints of MaxAcceleration and the current movement mode.
		/// </summary>
		public FVector Acceleration;
		
		/// <summary>Location after last PerformMovement or SimulateMovement update. Used internally to detect changes in position from outside character movement to try to validate the current floor.</summary>
		public FVector LastUpdateLocation;
		
		/// <summary>Rotation after last PerformMovement or SimulateMovement update.</summary>
		public FQuat LastUpdateRotation;
		
		/// <summary>Velocity after last PerformMovement or SimulateMovement update. Used internally to detect changes in velocity from external sources.</summary>
		public FVector LastUpdateVelocity;
		
		/// <summary>Timestamp when location or rotation last changed during an update. Only valid on the server.</summary>
		public float ServerLastTransformUpdateTimeStamp;
		
		/// <summary>Accumulated impulse to be added next tick.</summary>
		public FVector PendingImpulseToApply;
		
		/// <summary>Accumulated force to be added next tick.</summary>
		public FVector PendingForceToApply;
		
		/// <summary>Modifier to applied to values such as acceleration and max speed due to analog input.</summary>
		public float AnalogInputModifier;
		
		/// <summary>
		/// Max time delta for each discrete simulation step.
		/// Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking).
		/// Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationIterations
		/// </summary>
		public float MaxSimulationTimeStep;
		
		/// <summary>
		/// Max number of iterations used for each discrete simulation step.
		/// Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking).
		/// Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationTimeStep
		/// </summary>
		public int MaxSimulationIterations;
		
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.
		/// This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server.
		/// @see MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawn, MaxDepenetrationWithPawnAsProxy
		/// </summary>
		public float MaxDepenetrationWithGeometry;
		
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.
		/// This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server.
		/// @see MaxDepenetrationWithGeometry, MaxDepenetrationWithPawn, MaxDepenetrationWithPawnAsProxy
		/// </summary>
		public float MaxDepenetrationWithGeometryAsProxy;
		
		/// <summary>
		/// Max distance we are allowed to depenetrate when moving out of other Pawns.
		/// @see MaxDepenetrationWithGeometry, MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawnAsProxy
		/// </summary>
		public float MaxDepenetrationWithPawn;
		
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of other Pawns.
		/// Typically we don't want a large value, because we receive a server authoritative position that we should not then ignore by pushing them out of the local player.
		/// @see MaxDepenetrationWithGeometry, MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawn
		/// </summary>
		public float MaxDepenetrationWithPawnAsProxy;
		
		/// <summary>How long to take to smoothly interpolate from the old pawn position on the client to the corrected one sent by the server. Not used by Linear smoothing.</summary>
		public float NetworkSimulatedSmoothLocationTime;
		
		/// <summary>How long to take to smoothly interpolate from the old pawn rotation on the client to the corrected one sent by the server. Not used by Linear smoothing.</summary>
		public float NetworkSimulatedSmoothRotationTime;
		
		/// <summary>Similar setting as NetworkSimulatedSmoothLocationTime but only used on Listen servers.</summary>
		public float ListenServerNetworkSimulatedSmoothLocationTime;
		
		/// <summary>Similar setting as NetworkSimulatedSmoothRotationTime but only used on Listen servers.</summary>
		public float ListenServerNetworkSimulatedSmoothRotationTime;
		
		/// <summary>Maximum distance character is allowed to lag behind server location when interpolating between updates.</summary>
		public float NetworkMaxSmoothUpdateDistance;
		
		/// <summary>Maximum distance beyond which character is teleported to the new server location without any smoothing.</summary>
		public float NetworkNoSmoothUpdateDistance;
		
		/// <summary>Used in determining if pawn is going off ledge.  If the ledge is "shorter" than this value then the pawn will be able to walk off it. *</summary>
		public float LedgeCheckThreshold;
		
		/// <summary>When exiting water, jump if control pitch angle is this high or above.</summary>
		public float JumpOutOfWaterPitch;
		
		/// <summary>Information about the floor the Character is standing on (updated only during walking movement).</summary>
		public FFindFloorResult CurrentFloor;
		
		/// <summary>
		/// Default movement mode when not in water. Used at player startup or when teleported.
		/// @see DefaultWaterMovementMode
		/// @see bRunPhysicsWithNoController
		/// </summary>
		public EMovementMode DefaultLandMovementMode;
		
		/// <summary>
		/// Default movement mode when in water. Used at player startup or when teleported.
		/// @see DefaultLandMovementMode
		/// @see bRunPhysicsWithNoController
		/// </summary>
		public EMovementMode DefaultWaterMovementMode;
		
		/// <summary>
		/// Ground movement mode to switch to after falling and resuming ground movement.
		/// Only allowed values are: MOVE_Walking, MOVE_NavWalking.
		/// @see SetGroundMovementMode(), GetGroundMovementMode()
		/// </summary>
		public EMovementMode GroundMovementMode;
		
		/// <summary>
		/// If true, walking movement always maintains horizontal velocity when moving up ramps, which causes movement up ramps to be faster parallel to the ramp surface.
		/// If false, then walking movement maintains velocity magnitude parallel to the ramp surface.
		/// </summary>
		public bool bMaintainHorizontalGroundVelocity;
		
		/// <summary>If true, impart the base actor's X velocity when falling off it (which includes jumping)</summary>
		public bool bImpartBaseVelocityX;
		
		/// <summary>If true, impart the base actor's Y velocity when falling off it (which includes jumping)</summary>
		public bool bImpartBaseVelocityY;
		
		/// <summary>If true, impart the base actor's Z velocity when falling off it (which includes jumping)</summary>
		public bool bImpartBaseVelocityZ;
		
		/// <summary>
		/// If true, impart the base component's tangential components of angular velocity when jumping or falling off it.
		/// Only those components of the velocity allowed by the separate component settings (bImpartBaseVelocityX etc) will be applied.
		/// @see bImpartBaseVelocityX, bImpartBaseVelocityY, bImpartBaseVelocityZ
		/// </summary>
		public bool bImpartBaseAngularVelocity;
		
		/// <summary>Used by movement code to determine if a change in position is based on normal movement or a teleport. If not a teleport, velocity can be recomputed based on the change in position.</summary>
		public bool bJustTeleported;
		
		/// <summary>True when a network replication update is received for simulated proxies.</summary>
		public bool bNetworkUpdateReceived;
		
		/// <summary>True when the networked movement mode has been replicated.</summary>
		public bool bNetworkMovementModeChanged;
		
		/// <summary>
		/// True when we should ignore server location difference checks for client error on this movement component
		/// This can be useful when character is moving at extreme speeds for a duration and you need it to look
		/// smooth on clients. Make sure to disable when done, as this would break this character's server-client
		/// movement correction.
		/// </summary>
		public bool bIgnoreClientMovementErrorChecksAndCorrection;
		
		/// <summary>
		/// If true, event NotifyJumpApex() to CharacterOwner's controller when at apex of jump. Is cleared when event is triggered.
		/// By default this is off, and if you want the event to fire you typically set it to true when movement mode changes to "Falling" from another mode (see OnMovementModeChanged).
		/// </summary>
		public bool bNotifyApex;
		
		/// <summary>Instantly stop when in flying mode and no acceleration is being applied.</summary>
		public bool bCheatFlying;
		
		/// <summary>If true, try to crouch (or keep crouching) on next update. If false, try to stop crouching on next update.</summary>
		public bool bWantsToCrouch;
		
		/// <summary>
		/// If true, crouching should keep the base of the capsule in place by lowering the center of the shrunken capsule. If false, the base of the capsule moves up and the center stays in place.
		/// The same behavior applies when the character uncrouches: if true, the base is kept in the same location and the center moves up. If false, the capsule grows and only moves up if the base impacts something.
		/// By default this variable is set when the movement mode changes: set to true when walking and false otherwise. Feel free to override the behavior when the movement mode changes.
		/// </summary>
		public bool bCrouchMaintainsBaseLocation;
		
		/// <summary>
		/// Whether the character ignores changes in rotation of the base it is standing on.
		/// If true, the character maintains current world rotation.
		/// If false, the character rotates with the moving base.
		/// </summary>
		public bool bIgnoreBaseRotation;
		
		/// <summary>
		/// Set this to true if riding on a moving base that you know is clear from non-moving world obstructions.
		/// Optimization to avoid sweeps during based movement, use with care.
		/// </summary>
		public bool bFastAttachedMove;
		
		/// <summary>
		/// Whether we always force floor checks for stationary Characters while walking.
		/// Normally floor checks are avoided if possible when not moving, but this can be used to force them if there are use-cases where they are being skipped erroneously
		/// (such as objects moving up into the character from below).
		/// </summary>
		public bool bAlwaysCheckFloor;
		
		/// <summary>
		/// Performs floor checks as if the character is using a shape with a flat base.
		/// This avoids the situation where characters slowly lower off the side of a ledge (as their capsule 'balances' on the edge).
		/// </summary>
		public bool bUseFlatBaseForFloorChecks;
		
		/// <summary>Used to prevent reentry of JumpOff()</summary>
		public bool bPerformingJumpOff;
		
		/// <summary>Used to safely leave NavWalking movement mode</summary>
		public bool bWantsToLeaveNavWalking;
		
		/// <summary>If set, component will use RVO avoidance. This only runs on the server.</summary>
		public bool bUseRVOAvoidance;
		
		/// <summary>
		/// Should use acceleration for path following?
		/// If true, acceleration is applied when path following to reach the target velocity.
		/// If false, path following velocity is set directly, disregarding acceleration.
		/// </summary>
		public bool bRequestedMoveUseAcceleration;
		
		/// <summary>Was velocity requested by path following?</summary>
		public bool bHasRequestedVelocity;
		
		/// <summary>Was acceleration requested to be always max speed?</summary>
		public bool bRequestedMoveWithMaxSpeed;
		
		/// <summary>Was avoidance updated in this frame?</summary>
		public bool bWasAvoidanceUpdated;
		
		/// <summary>Whether to raycast to underlying geometry to better conform navmesh-walking characters</summary>
		public bool bProjectNavMeshWalking;
		
		/// <summary>Use both WorldStatic and WorldDynamic channels for NavWalking geometry conforming</summary>
		public bool bProjectNavMeshOnBothWorldChannels;
		
		public float AvoidanceConsiderationRadius;
		
		/// <summary>
		/// Velocity requested by path following.
		/// @see RequestDirectMove()
		/// </summary>
		public FVector RequestedVelocity;
		
		/// <summary>No default value, for now it's assumed to be valid if GetAvoidanceManager() returns non-NULL.</summary>
		public int AvoidanceUID;
		
		/// <summary>Moving actor's group mask</summary>
		public FNavAvoidanceMask AvoidanceGroup;
		
		/// <summary>Will avoid other agents if they are in one of specified groups</summary>
		public FNavAvoidanceMask GroupsToAvoid;
		
		/// <summary>Will NOT avoid other agents if they are in one of specified groups, higher priority than GroupsToAvoid</summary>
		public FNavAvoidanceMask GroupsToIgnore;
		
		/// <summary>De facto default value 0.5 (due to that being the default in the avoidance registration function), indicates RVO behavior.</summary>
		public float AvoidanceWeight;
		
		/// <summary>Temporarily holds launch velocity when pawn is to be launched so it happens at end of movement.</summary>
		public FVector PendingLaunchVelocity;
		
		/// <summary>How often we should raycast to project from navmesh to underlying geometry</summary>
		public float NavMeshProjectionInterval;
		
		public float NavMeshProjectionTimer;
		
		/// <summary>Speed at which to interpolate agent navmesh offset between traces. 0: Instant (no interp) > 0: Interp speed")</summary>
		public float NavMeshProjectionInterpSpeed;
		
		/// <summary>
		/// Scale of the total capsule height to use for projection from navmesh to underlying geometry in the upward direction.
		/// In other words, start the trace at [CapsuleHeight * NavMeshProjectionHeightScaleUp] above nav mesh.
		/// </summary>
		public float NavMeshProjectionHeightScaleUp;
		
		/// <summary>
		/// Scale of the total capsule height to use for projection from navmesh to underlying geometry in the downward direction.
		/// In other words, trace down to [CapsuleHeight * NavMeshProjectionHeightScaleDown] below nav mesh.
		/// </summary>
		public float NavMeshProjectionHeightScaleDown;
		
		/// <summary>Ignore small differences in ground height between server and client data during NavWalking mode</summary>
		public float NavWalkingFloorDistTolerance;
		
		/// <summary>Post-physics tick function for this character</summary>
		public FCharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction;
		
		/// <summary>
		/// Minimum time between client TimeStamp resets.
		///        !! This has to be large enough so that we don't confuse the server if the client can stall or timeout.
		///        We do this as we use floats for TimeStamps, and server derives DeltaTime from two TimeStamps.
		///        As time goes on, accuracy decreases from those floating point numbers.
		///        So we trigger a TimeStamp reset at regular intervals to maintain a high level of accuracy.
		/// </summary>
		public float MinTimeBetweenTimeStampResets;
		
		/// <summary>Root Motion Group containing active root motion sources being applied to movement</summary>
		public FRootMotionSourceGroup CurrentRootMotion;
		
		/// <summary>
		/// Root Motion movement params. Holds result of anim montage root motion during PerformMovement(), and is overridden
		///  during autonomous move playback to force historical root motion for MoveAutonomous() calls
		/// </summary>
		public FRootMotionMovementParams RootMotionParams;
		
		/// <summary>Velocity extracted from RootMotionParams when there is anim root motion active. Invalid to use when HasAnimRootMotion() returns false.</summary>
		public FVector AnimRootMotionVelocity;
		
		/// <summary>True when SimulatedProxies are simulating RootMotion</summary>
		public bool bWasSimulatingRootMotion;
		
		
	}
	
}
