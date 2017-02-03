using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ACharacter:APawn 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnimRootMotionTranslationScale(IntPtr _this);
/// <summary>Returns current value of AnimRootMotionScale</summary>
public  float GetAnimRootMotionTranslationScale()
{
	CheckIsValid();
	float ___ret = GetAnimRootMotionTranslationScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayingNetworkedRootMotionMontage(IntPtr _this);
/// <summary>
/// true if we are playing Root Motion right now, through a Montage with RootMotionMode == ERootMotionMode::RootMotionFromMontagesOnly.
/// This means code path for networked root motion is enabled.
/// </summary>
public  bool IsPlayingNetworkedRootMotionMontage()
{
	CheckIsValid();
	int ___ret = IsPlayingNetworkedRootMotionMontage(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayingRootMotion(IntPtr _this);
/// <summary>true if we are playing Root Motion right now</summary>
public  bool IsPlayingRootMotion()
{
	CheckIsValid();
	int ___ret = IsPlayingRootMotion(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_RootMotion(IntPtr _this);
/// <summary>Handles replicated root motion properties on simulated proxies and position correction.</summary>
public  void OnRep_RootMotion()
{
	CheckIsValid();
	OnRep_RootMotion(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCheatGhost(IntPtr _this);
public  void ClientCheatGhost()
{
	CheckIsValid();
	ClientCheatGhost(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCheatFly(IntPtr _this);
public  void ClientCheatFly()
{
	CheckIsValid();
	ClientCheatFly(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCheatWalk(IntPtr _this);
public  void ClientCheatWalk()
{
	CheckIsValid();
	ClientCheatWalk(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UnCrouch(IntPtr _this,int bClientSimulation);
/// <summary>
/// Request the character to stop crouching. The request is processed on the next update of the CharacterMovementComponent.
/// @see OnEndCrouch
/// @see IsCrouched
/// @see CharacterMovement->WantsToCrouch
/// </summary>
public  void UnCrouch(bool bClientSimulation=false)
{
	CheckIsValid();
	UnCrouch(_this.Get(),bClientSimulation?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Crouch(IntPtr _this,int bClientSimulation);
/// <summary>
/// Request the character to start crouching. The request is processed on the next update of the CharacterMovementComponent.
/// @see OnStartCrouch
/// @see IsCrouched
/// @see CharacterMovement->WantsToCrouch
/// </summary>
public  void Crouch(bool bClientSimulation=false)
{
	CheckIsValid();
	Crouch(_this.Get(),bClientSimulation?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LaunchCharacter(IntPtr _this,ref FVector LaunchVelocity,int bXYOverride,int bZOverride);
/// <summary>
/// Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick,
/// and will set it to the "falling" state. Triggers the OnLaunched event.
/// @PARAM LaunchVelocity is the velocity to impart to the Character
/// @PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it.
/// @PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it.
/// </summary>
public  void LaunchCharacter(FVector LaunchVelocity,bool bXYOverride,bool bZOverride)
{
	CheckIsValid();
	LaunchCharacter(_this.Get(),ref LaunchVelocity,bXYOverride?1:0,bZOverride?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetCurrentMontage(IntPtr _this);
/// <summary>Return current playing Montage *</summary>
public  UAnimMontage GetCurrentMontage()
{
	CheckIsValid();
	IntPtr ___ret = GetCurrentMontage(_this.Get());
	if(___ret==IntPtr.Zero) return null; UAnimMontage ___ret2= new UAnimMontage(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAnimMontage(IntPtr _this,IntPtr AnimMontage);
/// <summary>Stop Animation Montage. If NULL, it will stop what's currently active. The Blend Out Time is taken from the montage asset that is being stopped. *</summary>
public  void StopAnimMontage(UAnimMontage AnimMontage)
{
	CheckIsValid();
	StopAnimMontage(_this.Get(),AnimMontage);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float PlayAnimMontage(IntPtr _this,IntPtr AnimMontage,float InPlayRate,string StartSectionName);
/// <summary>Play Animation Montage on the character mesh *</summary>
public  float PlayAnimMontage(UAnimMontage AnimMontage,float InPlayRate=1.000000f,string StartSectionName="None")
{
	CheckIsValid();
	float ___ret = PlayAnimMontage(_this.Get(),AnimMontage,InPlayRate,StartSectionName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsJumpProvidingForce(IntPtr _this);
/// <summary>
/// True if jump is actively providing a force, such as when the jump key is held and the time it has been held is less than JumpMaxHoldTime.
/// @see CharacterMovement->IsFalling
/// </summary>
public  bool IsJumpProvidingForce()
{
	CheckIsValid();
	int ___ret = IsJumpProvidingForce(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CanJump(IntPtr _this);
/// <summary>
/// Check if the character can jump in the current state.
/// The default implementation may be overridden or extended by implementing the custom CanJump event in Blueprints.
/// @Return Whether the character can jump in the current state.
/// </summary>
public  bool CanJump()
{
	CheckIsValid();
	int ___ret = CanJump(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopJumping(IntPtr _this);
/// <summary>
/// Stop the character from jumping on the next update.
/// Call this from an input event (such as a button 'up' event) to cease applying
/// jump Z-velocity. If this is not called, then jump z-velocity will be applied
/// until JumpMaxHoldTime is reached.
/// </summary>
public  void StopJumping()
{
	CheckIsValid();
	StopJumping(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Jump(IntPtr _this);
/// <summary>
/// Make the character jump on the next update.
/// If you want your character to jump according to the time that the jump key is held,
/// then you can set JumpKeyHoldTime to some non-zero value. Make sure in this case to
/// call StopJumping() when you want the jump's z-velocity to stop being applied (such
/// as on a button up event), otherwise the character will carry on receiving the
/// velocity until JumpKeyHoldTime is reached.
/// </summary>
public  void Jump()
{
	CheckIsValid();
	Jump(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_IsCrouched(IntPtr _this);
/// <summary>Handle Crouching replicated from server</summary>
public  void OnRep_IsCrouched()
{
	CheckIsValid();
	OnRep_IsCrouched(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetReplicateMovement(IntPtr _this,int bInReplicateMovement);
/// <summary>Set whether this actor's movement replicates to network clients.</summary>
public  void SetReplicateMovement(bool bInReplicateMovement)
{
	CheckIsValid();
	SetReplicateMovement(_this.Get(),bInReplicateMovement?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ReplicatedBasedMovement(IntPtr _this);
/// <summary>Rep notify for ReplicatedBasedMovement</summary>
public  void OnRep_ReplicatedBasedMovement()
{
	CheckIsValid();
	OnRep_ReplicatedBasedMovement(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
