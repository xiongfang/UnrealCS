using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCharacterMovementComponent:UPawnMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAdjustRootMotionSourcePosition(IntPtr _this,float TimeStamp,ref FRootMotionSourceGroup ServerRootMotion,int bHasAnimRootMotion,float ServerMontageTrackPosition,ref FVector ServerLoc,ref FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,IntPtr ServerBase,string ServerBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
/// <summary>Replicate root motion source correction to client when using root motion for movement.</summary>
public  void ClientAdjustRootMotionSourcePosition(float TimeStamp,FRootMotionSourceGroup ServerRootMotion,bool bHasAnimRootMotion,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
{
	CheckIsValid();
	ClientAdjustRootMotionSourcePosition(_this.Get(),TimeStamp,ref ServerRootMotion,bHasAnimRootMotion?1:0,ServerMontageTrackPosition,ref ServerLoc,ref ServerRotation,ServerVelZ,ServerBase,ServerBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAdjustRootMotionPosition(IntPtr _this,float TimeStamp,float ServerMontageTrackPosition,ref FVector ServerLoc,ref FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,IntPtr ServerBase,string ServerBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
/// <summary>Replicate position correction to client when using root motion for movement. (animation root motion specific)</summary>
public  void ClientAdjustRootMotionPosition(float TimeStamp,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
{
	CheckIsValid();
	ClientAdjustRootMotionPosition(_this.Get(),TimeStamp,ServerMontageTrackPosition,ref ServerLoc,ref ServerRotation,ServerVelZ,ServerBase,ServerBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientVeryShortAdjustPosition(IntPtr _this,float TimeStamp,ref FVector NewLoc,IntPtr NewBase,string NewBaseBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
/// <summary>Bandwidth saving version, when velocity is zeroed</summary>
public  void ClientVeryShortAdjustPosition(float TimeStamp,FVector NewLoc,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
{
	CheckIsValid();
	ClientVeryShortAdjustPosition(_this.Get(),TimeStamp,ref NewLoc,NewBase,NewBaseBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAdjustPosition(IntPtr _this,float TimeStamp,ref FVector NewLoc,ref FVector NewVel,IntPtr NewBase,string NewBaseBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
/// <summary>Replicate position correction to client, associated with a timestamped servermove.  Client will replay subsequent moves after applying adjustment.</summary>
public  void ClientAdjustPosition(float TimeStamp,FVector NewLoc,FVector NewVel,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
{
	CheckIsValid();
	ClientAdjustPosition(_this.Get(),TimeStamp,ref NewLoc,ref NewVel,NewBase,NewBaseBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAckGoodMove(IntPtr _this,float TimeStamp);
/// <summary>If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves</summary>
public  void ClientAckGoodMove(float TimeStamp)
{
	CheckIsValid();
	ClientAckGoodMove(_this.Get(),TimeStamp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMoveOld(IntPtr _this,float OldTimeStamp,ref FVector_NetQuantize10 OldAccel,int OldMoveFlags);
/// <summary>Resending an (important) old move. Process it if not already processed.</summary>
public  void ServerMoveOld(float OldTimeStamp,FVector_NetQuantize10 OldAccel,byte OldMoveFlags)
{
	CheckIsValid();
	ServerMoveOld(_this.Get(),OldTimeStamp,ref OldAccel,OldMoveFlags);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMoveDualHybridRootMotion(IntPtr _this,float TimeStamp0,ref FVector_NetQuantize10 InAccel0,int PendingFlags,uint View0,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int NewFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
/// <summary>Replicated function sent by client to server - contains client movement and view info for two moves. First move is non root motion, second is root motion.</summary>
public  void ServerMoveDualHybridRootMotion(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
{
	CheckIsValid();
	ServerMoveDualHybridRootMotion(_this.Get(),TimeStamp0,ref InAccel0,PendingFlags,View0,TimeStamp,ref InAccel,ref ClientLoc,NewFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMoveDual(IntPtr _this,float TimeStamp0,ref FVector_NetQuantize10 InAccel0,int PendingFlags,uint View0,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int NewFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
/// <summary>Replicated function sent by client to server - contains client movement and view info for two moves.</summary>
public  void ServerMoveDual(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
{
	CheckIsValid();
	ServerMoveDual(_this.Get(),TimeStamp0,ref InAccel0,PendingFlags,View0,TimeStamp,ref InAccel,ref ClientLoc,NewFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMove(IntPtr _this,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int CompressedMoveFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
/// <summary>Replicated function sent by client to server - contains client movement and view info.</summary>
public  void ServerMove(float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte CompressedMoveFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
{
	CheckIsValid();
	ServerMove(_this.Get(),TimeStamp,ref InAccel,ref ClientLoc,CompressedMoveFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWalkableFloorZ(IntPtr _this,float InWalkableFloorZ);
/// <summary>Set the Z component of the normal of the steepest walkable surface for the character. Also computes WalkableFloorAngle.</summary>
public  void SetWalkableFloorZ(float InWalkableFloorZ)
{
	CheckIsValid();
	SetWalkableFloorZ(_this.Get(),InWalkableFloorZ);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetWalkableFloorZ(IntPtr _this);
/// <summary>Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable.</summary>
public  float K2_GetWalkableFloorZ()
{
	CheckIsValid();
	float ___ret = K2_GetWalkableFloorZ(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWalkableFloorAngle(IntPtr _this,float InWalkableFloorAngle);
/// <summary>Set the max angle in degrees of a walkable surface for the character. Also computes WalkableFloorZ.</summary>
public  void SetWalkableFloorAngle(float InWalkableFloorAngle)
{
	CheckIsValid();
	SetWalkableFloorAngle(_this.Get(),InWalkableFloorAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetWalkableFloorAngle(IntPtr _this);
/// <summary>Get the max angle in degrees of a walkable surface for the character.</summary>
public  float K2_GetWalkableFloorAngle()
{
	CheckIsValid();
	float ___ret = K2_GetWalkableFloorAngle(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsWalkable(IntPtr _this,ref FHitResult Hit);
/// <summary>Return true if the hit result should be considered a walkable surface for the character.</summary>
public  bool IsWalkable(FHitResult Hit)
{
	CheckIsValid();
	int ___ret = IsWalkable(_this.Get(),ref Hit);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetValidPerchRadius(IntPtr _this);
/// <summary>
/// Returns the radius within which we can stand on the edge of a surface without falling (if this is a walkable surface).
/// Simply computed as the capsule radius minus the result of GetPerchRadiusThreshold().
/// </summary>
public  float GetValidPerchRadius()
{
	CheckIsValid();
	float ___ret = GetValidPerchRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPerchRadiusThreshold(IntPtr _this);
/// <summary>@return The distance from the edge of the capsule within which we don't allow the character to perch on the edge of a surface.</summary>
public  float GetPerchRadiusThreshold()
{
	CheckIsValid();
	float ___ret = GetPerchRadiusThreshold(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddForce(IntPtr _this,ref FVector Force);
/// <summary>
/// Add force to character. Forces are accumulated each tick and applied together
/// so multiple calls to this function will accumulate.
/// Forces are scaled depending on timestep, so they can be applied each frame. If you want an
/// instantaneous force, use AddImpulse.
/// Adding a force always takes the actor's mass into account.
/// Note that changing the momentum of characters like this can change the movement mode.
/// @param       Force                   Force to apply.
/// </summary>
public  void AddForce(FVector Force)
{
	CheckIsValid();
	AddForce(_this.Get(),ref Force);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddImpulse(IntPtr _this,ref FVector Impulse,int bVelocityChange);
/// <summary>
/// Add impulse to character. Impulses are accumulated each tick and applied together
/// so multiple calls to this function will accumulate.
/// An impulse is an instantaneous force, usually applied once. If you want to continually apply
/// forces each frame, use AddForce().
/// Note that changing the momentum of characters like this can change the movement mode.
/// @param       Impulse                         Impulse to apply.
/// @param       bVelocityChange         Whether or not the impulse is relative to mass.
/// </summary>
public  void AddImpulse(FVector Impulse,bool bVelocityChange=false)
{
	CheckIsValid();
	AddImpulse(_this.Get(),ref Impulse,bVelocityChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnalogInputModifier(IntPtr _this);
/// <summary>@return Modifier [0..1] based on the magnitude of the last input vector, which is used to modify the acceleration and max speed during movement.</summary>
public  float GetAnalogInputModifier()
{
	CheckIsValid();
	float ___ret = GetAnalogInputModifier(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetCurrentAcceleration(IntPtr _this);
/// <summary>@return Current acceleration, computed from input vector each update.</summary>
public  FVector GetCurrentAcceleration()
{
	CheckIsValid();
	FVector ___ret = GetCurrentAcceleration(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMaxAcceleration(IntPtr _this);
/// <summary>@return Maximum acceleration for the current state.</summary>
public  float GetMaxAcceleration()
{
	CheckIsValid();
	float ___ret = GetMaxAcceleration(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMaxJumpHeight(IntPtr _this);
/// <summary>Compute the max jump height based on the JumpZVelocity velocity and gravity.</summary>
public  float GetMaxJumpHeight()
{
	CheckIsValid();
	float ___ret = GetMaxJumpHeight(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CalcVelocity(IntPtr _this,float DeltaTime,float Friction,int bFluid,float BrakingDeceleration);
/// <summary>
/// Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity.
/// This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes.
/// @param       DeltaTime                                               time elapsed since last frame.
/// @param       Friction                                                coefficient of friction when not accelerating, or in the direction opposite acceleration.
/// @param       bFluid                                                  true if moving through a fluid, causing Friction to always be applied regardless of acceleration.
/// @param       BrakingDeceleration                             deceleration applied when not accelerating, or when exceeding max velocity.
/// </summary>
public  void CalcVelocity(float DeltaTime,float Friction,bool bFluid,float BrakingDeceleration)
{
	CheckIsValid();
	CalcVelocity(_this.Get(),DeltaTime,Friction,bFluid?1:0,BrakingDeceleration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetImpartedMovementBaseVelocity(IntPtr _this);
/// <summary>
/// If we have a movement base, get the velocity that should be imparted by that base, usually when jumping off of it.
/// Only applies the components of the velocity enabled by bImpartBaseVelocityX, bImpartBaseVelocityY, bImpartBaseVelocityZ.
/// </summary>
public  FVector GetImpartedMovementBaseVelocity()
{
	CheckIsValid();
	FVector ___ret = GetImpartedMovementBaseVelocity(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetMovementBase(IntPtr _this);
/// <summary>Return PrimitiveComponent we are based on (standing and walking on).</summary>
public  UPrimitiveComponent GetMovementBase()
{
	CheckIsValid();
	IntPtr ___ret = GetMovementBase(_this.Get());
	if(___ret==IntPtr.Zero) return null; UPrimitiveComponent ___ret2= new UPrimitiveComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DisableMovement(IntPtr _this);
/// <summary>Make movement impossible (sets movement mode to MOVE_None).</summary>
public  void DisableMovement()
{
	CheckIsValid();
	DisableMovement(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsWalking(IntPtr _this);
/// <summary>@return true if the character is in the 'Walking' movement mode.</summary>
public  bool IsWalking()
{
	CheckIsValid();
	int ___ret = IsWalking(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMovementMode(IntPtr _this,int NewMovementMode,int NewCustomMode);
/// <summary>
/// Change movement mode.
/// @param NewMovementMode       The new movement mode
/// @param NewCustomMode         The new custom sub-mode, only applicable if NewMovementMode is Custom.
/// </summary>
public  void SetMovementMode(EMovementMode NewMovementMode,byte NewCustomMode=0)
{
	CheckIsValid();
	SetMovementMode(_this.Get(),(int)NewMovementMode,NewCustomMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetCharacterOwner(IntPtr _this);
/// <summary>Get the Character that owns UpdatedComponent.</summary>
public  ACharacter GetCharacterOwner()
{
	CheckIsValid();
	IntPtr ___ret = GetCharacterOwner(_this.Get());
	if(___ret==IntPtr.Zero) return null; ACharacter ___ret2= new ACharacter(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAvoidanceEnabled(IntPtr _this,int bEnable);
/// <summary>Change avoidance state and registers in RVO manager if needed</summary>
public  void SetAvoidanceEnabled(bool bEnable)
{
	CheckIsValid();
	SetAvoidanceEnabled(_this.Get(),bEnable?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGroupsToIgnore(IntPtr _this,int GroupFlags);
public  void SetGroupsToIgnore(int GroupFlags)
{
	CheckIsValid();
	SetGroupsToIgnore(_this.Get(),GroupFlags);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGroupsToAvoid(IntPtr _this,int GroupFlags);
public  void SetGroupsToAvoid(int GroupFlags)
{
	CheckIsValid();
	SetGroupsToAvoid(_this.Get(),GroupFlags);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAvoidanceGroup(IntPtr _this,int GroupFlags);
public  void SetAvoidanceGroup(int GroupFlags)
{
	CheckIsValid();
	SetAvoidanceGroup(_this.Get(),GroupFlags);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
