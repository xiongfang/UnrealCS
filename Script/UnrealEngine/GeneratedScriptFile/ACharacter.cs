using System;
namespace UnrealEngine
{
	public partial class ACharacter:APawn
	{
		/// <summary>Returns current value of AnimRootMotionScale</summary>
		public extern float GetAnimRootMotionTranslationScale();
		/// <summary>
		/// true if we are playing Root Motion right now, through a Montage with RootMotionMode == ERootMotionMode::RootMotionFromMontagesOnly.
		/// This means code path for networked root motion is enabled.
		/// </summary>
		public extern bool IsPlayingNetworkedRootMotionMontage();
		/// <summary>true if we are playing Root Motion right now</summary>
		public extern bool IsPlayingRootMotion();
		/// <summary>Handles replicated root motion properties on simulated proxies and position correction.</summary>
		public extern void OnRep_RootMotion();
		public extern virtual void ClientCheatGhost();
		public extern virtual void ClientCheatFly();
		public extern virtual void ClientCheatWalk();
		/// <summary>
		/// Request the character to stop crouching. The request is processed on the next update of the CharacterMovementComponent.
		/// @see OnEndCrouch
		/// @see IsCrouched
		/// @see CharacterMovement->WantsToCrouch
		/// </summary>
		public extern virtual void UnCrouch(bool bClientSimulation=false);
		/// <summary>
		/// Request the character to start crouching. The request is processed on the next update of the CharacterMovementComponent.
		/// @see OnStartCrouch
		/// @see IsCrouched
		/// @see CharacterMovement->WantsToCrouch
		/// </summary>
		public extern virtual void Crouch(bool bClientSimulation=false);
		/// <summary>
		/// Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick,
		/// and will set it to the "falling" state. Triggers the OnLaunched event.
		/// @PARAM LaunchVelocity is the velocity to impart to the Character
		/// @PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it.
		/// @PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it.
		/// </summary>
		public extern virtual void LaunchCharacter(FVector LaunchVelocity,bool bXYOverride,bool bZOverride);
		/// <summary>Return current playing Montage *</summary>
		public extern UAnimMontage GetCurrentMontage();
		/// <summary>Stop Animation Montage. If NULL, it will stop what's currently active. The Blend Out Time is taken from the montage asset that is being stopped. *</summary>
		public extern virtual void StopAnimMontage(UAnimMontage AnimMontage);
		/// <summary>Play Animation Montage on the character mesh *</summary>
		public extern virtual float PlayAnimMontage(UAnimMontage AnimMontage,float InPlayRate=1.000000f,FName StartSectionName=default(FName));
		/// <summary>
		/// True if jump is actively providing a force, such as when the jump key is held and the time it has been held is less than JumpMaxHoldTime.
		/// @see CharacterMovement->IsFalling
		/// </summary>
		public extern virtual bool IsJumpProvidingForce();
		/// <summary>
		/// Check if the character can jump in the current state.
		/// The default implementation may be overridden or extended by implementing the custom CanJump event in Blueprints.
		/// @Return Whether the character can jump in the current state.
		/// </summary>
		public extern bool CanJump();
		/// <summary>
		/// Stop the character from jumping on the next update.
		/// Call this from an input event (such as a button 'up' event) to cease applying
		/// jump Z-velocity. If this is not called, then jump z-velocity will be applied
		/// until JumpMaxHoldTime is reached.
		/// </summary>
		public extern virtual void StopJumping();
		/// <summary>
		/// Make the character jump on the next update.
		/// If you want your character to jump according to the time that the jump key is held,
		/// then you can set JumpKeyHoldTime to some non-zero value. Make sure in this case to
		/// call StopJumping() when you want the jump's z-velocity to stop being applied (such
		/// as on a button up event), otherwise the character will carry on receiving the
		/// velocity until JumpKeyHoldTime is reached.
		/// </summary>
		public extern virtual void Jump();
		/// <summary>Handle Crouching replicated from server</summary>
		public extern virtual void OnRep_IsCrouched();
		/// <summary>Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation.</summary>
		public extern FRotator GetBaseRotationOffsetRotator();
		/// <summary>Get the saved translation offset of mesh. This is how much extra offset is applied from the center of the capsule.</summary>
		public extern FVector GetBaseTranslationOffset();
		/// <summary>Set whether this actor's movement replicates to network clients.</summary>
		public extern virtual void SetReplicateMovement(bool bInReplicateMovement);
		/// <summary>Rep notify for ReplicatedBasedMovement</summary>
		public extern virtual void OnRep_ReplicatedBasedMovement();
		/// <summary>The main skeletal mesh associated with this Character (optional sub-object).</summary>
		public USkeletalMeshComponent Mesh;
		
		public UArrowComponent ArrowComponent;
		
		/// <summary>Movement component used for movement logic in various movement modes (walking, falling, etc), containing relevant settings and functions to control movement.</summary>
		public UCharacterMovementComponent CharacterMovement;
		
		/// <summary>The CapsuleComponent being used for movement collision (by CharacterMovement). Always treated as being vertically aligned in simple collision check functions.</summary>
		public UCapsuleComponent CapsuleComponent;
		
		/// <summary>Info about our current movement base (object we are standing on).</summary>
		public FBasedMovementInfo BasedMovement;
		
		/// <summary>Replicated version of relative movement. Read-only on simulated proxies!</summary>
		public FBasedMovementInfo ReplicatedBasedMovement;
		
		/// <summary>Scale to apply to root motion translation on this Character</summary>
		public float AnimRootMotionTranslationScale;
		
		/// <summary>Saved translation offset of mesh.</summary>
		public FVector BaseTranslationOffset;
		
		/// <summary>Saved rotation offset of mesh.</summary>
		public FQuat BaseRotationOffset;
		
		/// <summary>CharacterMovement ServerLastTransformUpdateTimeStamp value, replicated to simulated proxies.</summary>
		public float ReplicatedServerLastTransformUpdateTimeStamp;
		
		/// <summary>CharacterMovement MovementMode (and custom mode) replicated for simulated proxies. Use CharacterMovementComponent::UnpackNetworkMovementMode() to translate it.</summary>
		public byte ReplicatedMovementMode;
		
		/// <summary>Flag that we are receiving replication of the based movement.</summary>
		public bool bInBaseReplication;
		
		/// <summary>Default crouched eye height</summary>
		public float CrouchedEyeHeight;
		
		/// <summary>Set by character movement to specify that this Character is currently crouched.</summary>
		public bool bIsCrouched;
		
		/// <summary>When true, player wants to jump</summary>
		public bool bPressedJump;
		
		/// <summary>When true, applying updates to network client (replaying saved moves for a locally controlled character)</summary>
		public bool bClientUpdating;
		
		/// <summary>True if Pawn was initially falling when started to replay network moves.</summary>
		public bool bClientWasFalling;
		
		/// <summary>If server disagrees with root motion track position, client has to resimulate root motion from last AckedMove.</summary>
		public bool bClientResimulateRootMotion;
		
		/// <summary>If server disagrees with root motion state, client has to resimulate root motion from last AckedMove.</summary>
		public bool bClientResimulateRootMotionSources;
		
		/// <summary>Disable simulated gravity (set when character encroaches geometry on client, to keep him from falling through floors)</summary>
		public bool bSimGravityDisabled;
		
		public bool bClientCheckEncroachmentOnNetUpdate;
		
		/// <summary>Disable root motion on the server. When receiving a DualServerMove, where the first move is not root motion and the second is.</summary>
		public bool bServerMoveIgnoreRootMotion;
		
		/// <summary>
		/// Jump key Held Time.
		/// This is the time that the player has held the jump key, in seconds.
		/// </summary>
		public float JumpKeyHoldTime;
		
		/// <summary>
		/// The max time the jump key can be held.
		/// Note that if StopJumping() is not called before the max jump hold time is reached,
		/// then the character will carry on receiving vertical velocity. Therefore it is usually
		/// best to call StopJumping() when jump input has ceased (such as a button up event).
		/// </summary>
		public float JumpMaxHoldTime;
		
		/// <summary>
		/// The max number of jumps the character can perform.
		/// Note that if JumpMaxHoldTime is non zero and StopJumping is not called, the player
		/// may be able to perform and unlimited number of jumps. Therefore it is usually
		/// best to call StopJumping() when jump input has ceased (such as a button up event).
		/// </summary>
		public int JumpMaxCount;
		
		/// <summary>
		/// Tracks the current number of jumps performed.
		/// This is incremented in CheckJumpInput, used in CanJump_Implementation, and reset in OnMovementModeChanged.
		/// When providing overrides for these methods, it's recommended to either manually
		/// increment / reset this value, or call the Super:: method.
		/// </summary>
		public int JumpCurrentCount;
		
		/// <summary>Tracks whether or not the character was already jumping last frame.</summary>
		public bool bWasJumping;
		
		/// <summary>
		/// For LocallyControlled Autonomous clients.
		/// During a PerformMovement() after root motion is prepared, we save it off into this and
		/// then record it into our SavedMoves.
		/// During SavedMove playback we use it as our "Previous Move" SavedRootMotion which includes
		/// last received root motion from the Server
		/// </summary>
		public FRootMotionSourceGroup SavedRootMotion;
		
		/// <summary>For LocallyControlled Autonomous clients. Saved root motion data to be used by SavedMoves.</summary>
		public FRootMotionMovementParams ClientRootMotionParams;
		
		/// <summary>Replicated Root Motion montage</summary>
		public FRepRootMotionMontage RepRootMotion;
		
		
	}
	
}
