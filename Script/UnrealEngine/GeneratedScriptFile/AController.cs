using System;
namespace UnrealEngine
{
	public partial class AController:AActor
	{
		/// <summary>Reset move and look input ignore flags.</summary>
		public extern virtual void ResetIgnoreInputFlags();
		/// <summary>Returns true if look input is ignored.</summary>
		public extern virtual bool IsLookInputIgnored();
		/// <summary>Stops ignoring look input by resetting the ignore look input state.</summary>
		public extern virtual void ResetIgnoreLookInput();
		/// <summary>
		/// Locks or unlocks look input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreLookInput.
		/// @param bNewLookInput  If true, look input is ignored. If false, input is not ignored.
		/// </summary>
		public extern virtual void SetIgnoreLookInput(bool bNewLookInput);
		/// <summary>Returns true if movement input is ignored.</summary>
		public extern virtual bool IsMoveInputIgnored();
		/// <summary>Stops ignoring move input by resetting the ignore move input state.</summary>
		public extern virtual void ResetIgnoreMoveInput();
		/// <summary>
		/// Locks or unlocks movement input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreMoveInput.
		/// @param bNewMoveInput  If true, move input is ignored. If false, input is not ignored.
		/// </summary>
		public extern virtual void SetIgnoreMoveInput(bool bNewMoveInput);
		/// <summary>Aborts the move the controller is currently performing</summary>
		public extern virtual void StopMovement();
		/// <summary>Called to unpossess our pawn for any reason that is not the pawn being destroyed (destruction handled by PawnDestroyed()).</summary>
		public extern virtual void UnPossess();
		/// <summary>
		/// Handles attaching this controller to the specified pawn.
		/// Only runs on the network authority (where HasAuthority() returns true).
		/// @param InPawn The Pawn to be possessed.
		/// @see HasAuthority()
		/// </summary>
		public extern virtual void Possess(APawn InPawn);
		/// <summary>Returns whether this Controller is a local controller.</summary>
		public extern virtual bool IsLocalController();
		/// <summary>Returns whether this Controller is a locally controlled PlayerController.</summary>
		public extern bool IsLocalPlayerController();
		/// <summary>Returns whether this Controller is a PlayerController.</summary>
		public extern bool IsPlayerController();
		/// <summary>Get the desired pawn target rotation</summary>
		public extern virtual FRotator GetDesiredRotation();
		/// <summary>Get the actor the controller is looking at</summary>
		public extern virtual AActor GetViewTarget();
		/// <summary>Return the Pawn that is currently 'controlled' by this PlayerController</summary>
		public extern APawn K2_GetPawn();
		/// <summary>Replicated function to set the pawn rotation, allowing the server to force.</summary>
		public extern virtual void ClientSetRotation(FRotator NewRotation,bool bResetCamera);
		/// <summary>Replicated function to set the pawn location and rotation, allowing server to force (ex. teleports).</summary>
		public extern virtual void ClientSetLocation(FVector NewLocation,FRotator NewRotation);
		public extern virtual void OnRep_PlayerState();
		/// <summary>Replication Notification Callbacks</summary>
		public extern virtual void OnRep_Pawn();
		/// <summary>
		/// Checks line to center and top of other actor
		/// @param Other is the actor whose visibility is being checked.
		/// @param ViewPoint is eye position visibility is being checked from.  If vect(0,0,0) passed in, uses current viewtarget's eye position.
		/// @param bAlternateChecks used only in AIController implementation
		/// @return true if controller's pawn can see Other actor.
		/// </summary>
		public extern virtual bool LineOfSightTo(AActor Other,FVector ViewPoint,bool bAlternateChecks=false);
		/// <summary>Set the initial location and rotation of the controller, as well as the control rotation. Typically used when the controller is first created.</summary>
		public extern virtual void SetInitialLocationAndRotation(FVector NewLocation,FRotator NewRotation);
		/// <summary>Set the control rotation.</summary>
		public extern virtual void SetControlRotation(FRotator NewRotation);
		/// <summary>
		/// Get the control rotation. This is the full aim rotation, which may be different than a camera orientation (for example in a third person view),
		/// and may differ from the rotation of the controlled Pawn (which may choose not to visually pitch or roll, for example).
		/// </summary>
		public extern virtual FRotator GetControlRotation();
		/// <summary>Pawn currently being controlled by this controller.  Use Pawn.Possess() to take control of a pawn</summary>
		public APawn Pawn;
		
		/// <summary>Character currently being controlled by this controller.  Value is same as Pawn if the controlled pawn is a character, otherwise NULL</summary>
		public ACharacter Character;
		
		/// <summary>PlayerState containing replicated information about the player using this controller (only exists for players, not NPCs).</summary>
		public APlayerState PlayerState;
		
		public USceneComponent TransformComponent;
		
		/// <summary>The control rotation of the Controller. See GetControlRotation.</summary>
		public FRotator ControlRotation;
		
		/// <summary>
		/// If true, the controller location will match the possessed Pawn's location. If false, it will not be updated. Rotation will match ControlRotation in either case.
		/// Since a Controller's location is normally inaccessible, this is intended mainly for purposes of being able to attach
		/// an Actor that follows the possessed Pawn location, but that still has the full aim rotation (since a Pawn might
		/// update only some components of the rotation).
		/// </summary>
		public bool bAttachToPawn;
		
		/// <summary>Whether this controller is a PlayerController.</summary>
		public bool bIsPlayerController;
		
		/// <summary>CONTROLLER STATE PROPERTIES</summary>
		public FName StateName;
		
		
	}
	
}
