using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class APawn:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMoveInputIgnored(IntPtr _this);
/// <summary>Helper to see if move input is ignored. If our controller is a PlayerController, checks Controller->IsMoveInputIgnored().</summary>
public  bool IsMoveInputIgnored()
{
	CheckIsValid();
	int ___ret = IsMoveInputIgnored(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddControllerRollInput(IntPtr _this,float Val);
/// <summary>
/// Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController.
/// This value is multiplied by the PlayerController's InputRollScale value.
/// @param Val Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value.
/// @see PlayerController::InputRollScale
/// </summary>
public  void AddControllerRollInput(float Val)
{
	CheckIsValid();
	AddControllerRollInput(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddControllerYawInput(IntPtr _this,float Val);
/// <summary>
/// Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController.
/// This value is multiplied by the PlayerController's InputYawScale value.
/// @param Val Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value.
/// @see PlayerController::InputYawScale
/// </summary>
public  void AddControllerYawInput(float Val)
{
	CheckIsValid();
	AddControllerYawInput(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddControllerPitchInput(IntPtr _this,float Val);
/// <summary>
/// Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController.
/// This value is multiplied by the PlayerController's InputPitchScale value.
/// @param Val Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value.
/// @see PlayerController::InputPitchScale
/// </summary>
public  void AddControllerPitchInput(float Val)
{
	CheckIsValid();
	AddControllerPitchInput(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ConsumeMovementInputVector(IntPtr _this);
/// <summary>
/// Returns the pending input vector and resets it to zero.
/// This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames.
/// Copies the pending input vector to the saved input vector (GetLastMovementInputVector()).
/// @return The pending input vector.
/// </summary>
public  FVector ConsumeMovementInputVector()
{
	CheckIsValid();
	FVector ___ret = ConsumeMovementInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetLastMovementInputVector(IntPtr _this);
/// <summary>
/// Return the last input vector in world space that was processed by ConsumeMovementInputVector(), which is usually done by the Pawn or PawnMovementComponent.
/// Any user that needs to know about the input that last affected movement should use this function.
/// For example an animation update would want to use this, since by default the order of updates in a frame is:
/// PlayerController (device input) -> MovementComponent -> Pawn -> Mesh (animations)
/// @return The last input vector in world space that was processed by ConsumeMovementInputVector().
/// @see AddMovementInput(), GetPendingMovementInputVector(), ConsumeMovementInputVector()
/// </summary>
public  FVector GetLastMovementInputVector()
{
	CheckIsValid();
	FVector ___ret = GetLastMovementInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPendingMovementInputVector(IntPtr _this);
/// <summary>
/// Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it,
/// Usually only a PawnMovementComponent will want to read this value, or the Pawn itself if it is responsible for movement.
/// @return The pending input vector in world space.
/// @see AddMovementInput(), GetLastMovementInputVector(), ConsumeMovementInputVector()
/// </summary>
public  FVector GetPendingMovementInputVector()
{
	CheckIsValid();
	FVector ___ret = GetPendingMovementInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddMovementInput(IntPtr _this,ref FVector WorldDirection,float ScaleValue,int bForce);
/// <summary>
/// Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction.
/// Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move.
/// @param WorldDirection        Direction in world space to apply input
/// @param ScaleValue            Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction.
/// @param bForce                        If true always add the input, ignoring the result of IsMoveInputIgnored().
/// @see GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector()
/// </summary>
public  void AddMovementInput(FVector WorldDirection,float ScaleValue=1.000000f,bool bForce=false)
{
	CheckIsValid();
	AddMovementInput(_this.Get(),ref WorldDirection,ScaleValue,bForce?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SpawnDefaultController(IntPtr _this);
/// <summary>Spawn default controller for this Pawn, and get possessed by it.</summary>
public  void SpawnDefaultController()
{
	CheckIsValid();
	SpawnDefaultController(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DetachFromControllerPendingDestroy(IntPtr _this);
/// <summary>Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon.</summary>
public  void DetachFromControllerPendingDestroy()
{
	CheckIsValid();
	DetachFromControllerPendingDestroy(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetBaseAimRotation(IntPtr _this);
/// <summary>
/// Return the aim rotation for the Pawn.
/// If we have a controller, by default we aim at the player's 'eyes' direction
/// that is by default the Pawn rotation for AI, and camera (crosshair) rotation for human players.
/// </summary>
public  FRotator GetBaseAimRotation()
{
	CheckIsValid();
	FRotator ___ret = GetBaseAimRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayerControlled(IntPtr _this);
/// <summary>@return true if controlled by a human player (possessed by a PlayerController).</summary>
public  bool IsPlayerControlled()
{
	CheckIsValid();
	int ___ret = IsPlayerControlled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLocallyControlled(IntPtr _this);
/// <summary>@return true if controlled by a local (not network) Controller.</summary>
public  bool IsLocallyControlled()
{
	CheckIsValid();
	int ___ret = IsLocallyControlled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetNavAgentLocation(IntPtr _this);
/// <summary>Basically retrieved pawn's location on navmesh</summary>
public  FVector GetNavAgentLocation()
{
	CheckIsValid();
	FVector ___ret = GetNavAgentLocation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCanAffectNavigationGeneration(IntPtr _this,int bNewValue,int bForceUpdate);
/// <summary>
/// Use SetCanAffectNavigationGeneration to change this value at runtime.
///     Note that calling this function at runtime will result in any navigation change only if runtime navigation generation is enabled.
/// </summary>
public  void SetCanAffectNavigationGeneration(bool bNewValue,bool bForceUpdate=false)
{
	CheckIsValid();
	SetCanAffectNavigationGeneration(_this.Get(),bNewValue?1:0,bForceUpdate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_PlayerState(IntPtr _this);
/// <summary>PlayerState Replication Notification Callback</summary>
public  void OnRep_PlayerState()
{
	CheckIsValid();
	OnRep_PlayerState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_Controller(IntPtr _this);
/// <summary>Called when Controller is replicated</summary>
public  void OnRep_Controller()
{
	CheckIsValid();
	OnRep_Controller(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetControlRotation(IntPtr _this);
/// <summary>Get the rotation of the Controller, often the 'view' rotation of this Pawn.</summary>
public  FRotator GetControlRotation()
{
	CheckIsValid();
	FRotator ___ret = GetControlRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetController(IntPtr _this);
/// <summary>Returns controller for this actor.</summary>
public  AController GetController()
{
	CheckIsValid();
	IntPtr ___ret = GetController(_this.Get());
	if(___ret==IntPtr.Zero) return null; AController ___ret2= new AController(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsControlled(IntPtr _this);
/// <summary>See if this actor is currently being controlled</summary>
public  bool IsControlled()
{
	CheckIsValid();
	int ___ret = IsControlled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetMovementBaseActor(IntPtr _this,IntPtr Pawn);
/// <summary>Gets the owning actor of the Movement Base Component on which the pawn is standing.</summary>
public static AActor GetMovementBaseActor(APawn Pawn)
{
	IntPtr ___ret = GetMovementBaseActor(IntPtr.Zero,Pawn);
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PawnMakeNoise(IntPtr _this,float Loudness,ref FVector NoiseLocation,int bUseNoiseMakerLocation,IntPtr NoiseMaker);
/// <summary>
/// Inform AIControllers that you've made a noise they might hear (they are sent a HearNoise message if they have bHearNoises==true)
/// The instigator of this sound is the pawn which is used to call MakeNoise.
/// @param Loudness - is the relative loudness of this noise (range 0.0 to 1.0).  Directly affects the hearing range specified by the AI's HearingThreshold.
/// @param NoiseLocation - Position of noise source.  If zero vector, use the actor's location.
/// @param bUseNoiseMakerLocation - If true, use the location of the NoiseMaker rather than NoiseLocation.  If false, use NoiseLocation.
/// @param NoiseMaker - Which actor is the source of the noise.  Not to be confused with the Noise Instigator, which is responsible for the noise (and is the pawn on which this function is called).  If not specified, the pawn instigating the noise will be used as the NoiseMaker
/// </summary>
public  void PawnMakeNoise(float Loudness,FVector NoiseLocation,bool bUseNoiseMakerLocation=true,AActor NoiseMaker=default(AActor))
{
	CheckIsValid();
	PawnMakeNoise(_this.Get(),Loudness,ref NoiseLocation,bUseNoiseMakerLocation?1:0,NoiseMaker);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetMovementComponent(IntPtr _this);
/// <summary>Return our PawnMovementComponent, if we have one.</summary>
public  UPawnMovementComponent GetMovementComponent()
{
	CheckIsValid();
	IntPtr ___ret = GetMovementComponent(_this.Get());
	if(___ret==IntPtr.Zero) return null; UPawnMovementComponent ___ret2= new UPawnMovementComponent(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
