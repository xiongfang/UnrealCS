using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AController:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetIgnoreInputFlags(IntPtr _this);
/// <summary>Reset move and look input ignore flags.</summary>
public  void ResetIgnoreInputFlags()
{
	CheckIsValid();
	ResetIgnoreInputFlags(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLookInputIgnored(IntPtr _this);
/// <summary>Returns true if look input is ignored.</summary>
public  bool IsLookInputIgnored()
{
	CheckIsValid();
	int ___ret = IsLookInputIgnored(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetIgnoreLookInput(IntPtr _this);
/// <summary>Stops ignoring look input by resetting the ignore look input state.</summary>
public  void ResetIgnoreLookInput()
{
	CheckIsValid();
	ResetIgnoreLookInput(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIgnoreLookInput(IntPtr _this,int bNewLookInput);
/// <summary>
/// Locks or unlocks look input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreLookInput.
/// @param bNewLookInput  If true, look input is ignored. If false, input is not ignored.
/// </summary>
public  void SetIgnoreLookInput(bool bNewLookInput)
{
	CheckIsValid();
	SetIgnoreLookInput(_this.Get(),bNewLookInput?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMoveInputIgnored(IntPtr _this);
/// <summary>Returns true if movement input is ignored.</summary>
public  bool IsMoveInputIgnored()
{
	CheckIsValid();
	int ___ret = IsMoveInputIgnored(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetIgnoreMoveInput(IntPtr _this);
/// <summary>Stops ignoring move input by resetting the ignore move input state.</summary>
public  void ResetIgnoreMoveInput()
{
	CheckIsValid();
	ResetIgnoreMoveInput(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIgnoreMoveInput(IntPtr _this,int bNewMoveInput);
/// <summary>
/// Locks or unlocks movement input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreMoveInput.
/// @param bNewMoveInput  If true, move input is ignored. If false, input is not ignored.
/// </summary>
public  void SetIgnoreMoveInput(bool bNewMoveInput)
{
	CheckIsValid();
	SetIgnoreMoveInput(_this.Get(),bNewMoveInput?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopMovement(IntPtr _this);
/// <summary>Aborts the move the controller is currently performing</summary>
public  void StopMovement()
{
	CheckIsValid();
	StopMovement(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UnPossess(IntPtr _this);
/// <summary>Called to unpossess our pawn for any reason that is not the pawn being destroyed (destruction handled by PawnDestroyed()).</summary>
public  void UnPossess()
{
	CheckIsValid();
	UnPossess(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Possess(IntPtr _this,IntPtr InPawn);
/// <summary>
/// Handles attaching this controller to the specified pawn.
/// Only runs on the network authority (where HasAuthority() returns true).
/// @param InPawn The Pawn to be possessed.
/// @see HasAuthority()
/// </summary>
public  void Possess(APawn InPawn)
{
	CheckIsValid();
	Possess(_this.Get(),InPawn);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLocalController(IntPtr _this);
/// <summary>Returns whether this Controller is a local controller.</summary>
public  bool IsLocalController()
{
	CheckIsValid();
	int ___ret = IsLocalController(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLocalPlayerController(IntPtr _this);
/// <summary>Returns whether this Controller is a locally controlled PlayerController.</summary>
public  bool IsLocalPlayerController()
{
	CheckIsValid();
	int ___ret = IsLocalPlayerController(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayerController(IntPtr _this);
/// <summary>Returns whether this Controller is a PlayerController.</summary>
public  bool IsPlayerController()
{
	CheckIsValid();
	int ___ret = IsPlayerController(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetDesiredRotation(IntPtr _this);
/// <summary>Get the desired pawn target rotation</summary>
public  FRotator GetDesiredRotation()
{
	CheckIsValid();
	FRotator ___ret = GetDesiredRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetViewTarget(IntPtr _this);
/// <summary>Get the actor the controller is looking at</summary>
public  AActor GetViewTarget()
{
	CheckIsValid();
	IntPtr ___ret = GetViewTarget(_this.Get());
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr K2_GetPawn(IntPtr _this);
/// <summary>Return the Pawn that is currently 'controlled' by this PlayerController</summary>
public  APawn K2_GetPawn()
{
	CheckIsValid();
	IntPtr ___ret = K2_GetPawn(_this.Get());
	if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetRotation(IntPtr _this,ref FRotator NewRotation,int bResetCamera);
/// <summary>Replicated function to set the pawn rotation, allowing the server to force.</summary>
public  void ClientSetRotation(FRotator NewRotation,bool bResetCamera)
{
	CheckIsValid();
	ClientSetRotation(_this.Get(),ref NewRotation,bResetCamera?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetLocation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation);
/// <summary>Replicated function to set the pawn location and rotation, allowing server to force (ex. teleports).</summary>
public  void ClientSetLocation(FVector NewLocation,FRotator NewRotation)
{
	CheckIsValid();
	ClientSetLocation(_this.Get(),ref NewLocation,ref NewRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_PlayerState(IntPtr _this);
public  void OnRep_PlayerState()
{
	CheckIsValid();
	OnRep_PlayerState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_Pawn(IntPtr _this);
/// <summary>Replication Notification Callbacks</summary>
public  void OnRep_Pawn()
{
	CheckIsValid();
	OnRep_Pawn(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LineOfSightTo(IntPtr _this,IntPtr Other,ref FVector ViewPoint,int bAlternateChecks);
/// <summary>
/// Checks line to center and top of other actor
/// @param Other is the actor whose visibility is being checked.
/// @param ViewPoint is eye position visibility is being checked from.  If vect(0,0,0) passed in, uses current viewtarget's eye position.
/// @param bAlternateChecks used only in AIController implementation
/// @return true if controller's pawn can see Other actor.
/// </summary>
public  bool LineOfSightTo(AActor Other,FVector ViewPoint,bool bAlternateChecks=false)
{
	CheckIsValid();
	int ___ret = LineOfSightTo(_this.Get(),Other,ref ViewPoint,bAlternateChecks?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInitialLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation);
/// <summary>Set the initial location and rotation of the controller, as well as the control rotation. Typically used when the controller is first created.</summary>
public  void SetInitialLocationAndRotation(FVector NewLocation,FRotator NewRotation)
{
	CheckIsValid();
	SetInitialLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetControlRotation(IntPtr _this,ref FRotator NewRotation);
/// <summary>Set the control rotation.</summary>
public  void SetControlRotation(FRotator NewRotation)
{
	CheckIsValid();
	SetControlRotation(_this.Get(),ref NewRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetControlRotation(IntPtr _this);
/// <summary>
/// Get the control rotation. This is the full aim rotation, which may be different than a camera orientation (for example in a third person view),
/// and may differ from the rotation of the controlled Pawn (which may choose not to visually pitch or roll, for example).
/// </summary>
public  FRotator GetControlRotation()
{
	CheckIsValid();
	FRotator ___ret = GetControlRotation(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
