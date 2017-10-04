using System;
namespace UnrealEngine
{
	public partial class APawn:AActor
	{
		/// <summary>Helper to see if move input is ignored. If our controller is a PlayerController, checks Controller->IsMoveInputIgnored().</summary>
		public extern virtual bool IsMoveInputIgnored();
		/// <summary>
		/// Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController.
		/// This value is multiplied by the PlayerController's InputRollScale value.
		/// @param Val Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value.
		/// @see PlayerController::InputRollScale
		/// </summary>
		public extern virtual void AddControllerRollInput(float Val);
		/// <summary>
		/// Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController.
		/// This value is multiplied by the PlayerController's InputYawScale value.
		/// @param Val Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value.
		/// @see PlayerController::InputYawScale
		/// </summary>
		public extern virtual void AddControllerYawInput(float Val);
		/// <summary>
		/// Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController.
		/// This value is multiplied by the PlayerController's InputPitchScale value.
		/// @param Val Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value.
		/// @see PlayerController::InputPitchScale
		/// </summary>
		public extern virtual void AddControllerPitchInput(float Val);
		/// <summary>
		/// Returns the pending input vector and resets it to zero.
		/// This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames.
		/// Copies the pending input vector to the saved input vector (GetLastMovementInputVector()).
		/// @return The pending input vector.
		/// </summary>
		public extern virtual FVector ConsumeMovementInputVector();
		/// <summary>
		/// Return the last input vector in world space that was processed by ConsumeMovementInputVector(), which is usually done by the Pawn or PawnMovementComponent.
		/// Any user that needs to know about the input that last affected movement should use this function.
		/// For example an animation update would want to use this, since by default the order of updates in a frame is:
		/// PlayerController (device input) -> MovementComponent -> Pawn -> Mesh (animations)
		/// @return The last input vector in world space that was processed by ConsumeMovementInputVector().
		/// @see AddMovementInput(), GetPendingMovementInputVector(), ConsumeMovementInputVector()
		/// </summary>
		public extern FVector GetLastMovementInputVector();
		/// <summary>
		/// Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it,
		/// Usually only a PawnMovementComponent will want to read this value, or the Pawn itself if it is responsible for movement.
		/// @return The pending input vector in world space.
		/// @see AddMovementInput(), GetLastMovementInputVector(), ConsumeMovementInputVector()
		/// </summary>
		public extern FVector GetPendingMovementInputVector();
		/// <summary>
		/// Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction.
		/// Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move.
		/// @param WorldDirection        Direction in world space to apply input
		/// @param ScaleValue            Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction.
		/// @param bForce                        If true always add the input, ignoring the result of IsMoveInputIgnored().
		/// @see GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector()
		/// </summary>
		public extern virtual void AddMovementInput(FVector WorldDirection,float ScaleValue=1.000000f,bool bForce=false);
		/// <summary>Spawn default controller for this Pawn, and get possessed by it.</summary>
		public extern virtual void SpawnDefaultController();
		/// <summary>Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon.</summary>
		public extern virtual void DetachFromControllerPendingDestroy();
		/// <summary>
		/// Return the aim rotation for the Pawn.
		/// If we have a controller, by default we aim at the player's 'eyes' direction
		/// that is by default the Pawn rotation for AI, and camera (crosshair) rotation for human players.
		/// </summary>
		public extern virtual FRotator GetBaseAimRotation();
		/// <summary>@return true if controlled by a human player (possessed by a PlayerController).</summary>
		public extern virtual bool IsPlayerControlled();
		/// <summary>@return true if controlled by a local (not network) Controller.</summary>
		public extern virtual bool IsLocallyControlled();
		/// <summary>Basically retrieved pawn's location on navmesh</summary>
		public extern virtual FVector GetNavAgentLocation();
		/// <summary>
		/// Use SetCanAffectNavigationGeneration to change this value at runtime.
		///     Note that calling this function at runtime will result in any navigation change only if runtime navigation generation is enabled.
		/// </summary>
		public extern void SetCanAffectNavigationGeneration(bool bNewValue,bool bForceUpdate=false);
		/// <summary>PlayerState Replication Notification Callback</summary>
		public extern virtual void OnRep_PlayerState();
		/// <summary>Called when Controller is replicated</summary>
		public extern virtual void OnRep_Controller();
		/// <summary>Get the rotation of the Controller, often the 'view' rotation of this Pawn.</summary>
		public extern FRotator GetControlRotation();
		/// <summary>Returns controller for this actor.</summary>
		public extern AController GetController();
		/// <summary>See if this actor is currently being controlled</summary>
		public extern bool IsControlled();
		/// <summary>Gets the owning actor of the Movement Base Component on which the pawn is standing.</summary>
		public extern static AActor GetMovementBaseActor(APawn Pawn);
		/// <summary>
		/// Inform AIControllers that you've made a noise they might hear (they are sent a HearNoise message if they have bHearNoises==true)
		/// The instigator of this sound is the pawn which is used to call MakeNoise.
		/// @param Loudness - is the relative loudness of this noise (range 0.0 to 1.0).  Directly affects the hearing range specified by the AI's HearingThreshold.
		/// @param NoiseLocation - Position of noise source.  If zero vector, use the actor's location.
		/// @param bUseNoiseMakerLocation - If true, use the location of the NoiseMaker rather than NoiseLocation.  If false, use NoiseLocation.
		/// @param NoiseMaker - Which actor is the source of the noise.  Not to be confused with the Noise Instigator, which is responsible for the noise (and is the pawn on which this function is called).  If not specified, the pawn instigating the noise will be used as the NoiseMaker
		/// </summary>
		public extern void PawnMakeNoise(float Loudness,FVector NoiseLocation,bool bUseNoiseMakerLocation=true,AActor NoiseMaker=default(AActor));
		/// <summary>Return our PawnMovementComponent, if we have one.</summary>
		public extern virtual UPawnMovementComponent GetMovementComponent();
		/// <summary>If true, this Pawn's pitch will be updated to match the Controller's ControlRotation pitch, if controlled by a PlayerController.</summary>
		public bool bUseControllerRotationPitch;
		
		/// <summary>If true, this Pawn's yaw will be updated to match the Controller's ControlRotation yaw, if controlled by a PlayerController.</summary>
		public bool bUseControllerRotationYaw;
		
		/// <summary>If true, this Pawn's roll will be updated to match the Controller's ControlRotation roll, if controlled by a PlayerController.</summary>
		public bool bUseControllerRotationRoll;
		
		/// <summary>
		/// If set to false (default) given pawn instance will never affect navigation generation.
		///     Setting it to true will result in using regular AActor's navigation relevancy
		///     calculation to check if this pawn instance should affect navigation generation
		///     Use SetCanAffectNavigationGeneration to change this value at runtime.
		///     Note that modifying this value at runtime will result in any navigation change only if runtime navigation generation is enabled.
		/// </summary>
		public bool bCanAffectNavigationGeneration;
		
		/// <summary>Base eye height above collision center.</summary>
		public float BaseEyeHeight;
		
		/// <summary>
		/// Determines which PlayerController, if any, should automatically possess the pawn when the level starts or when the pawn is spawned.
		/// @see AutoPossessAI
		/// </summary>
		public EAutoReceiveInput AutoPossessPlayer;
		
		/// <summary>Default class to use when pawn is controlled by AI.</summary>
		public TSubclassOf<AController>  AIControllerClass;
		
		/// <summary>If Pawn is possessed by a player, points to his playerstate.  Needed for network play as controllers are not replicated to clients.</summary>
		public APlayerState PlayerState;
		
		/// <summary>Replicated so we can see where remote clients are looking.</summary>
		public byte RemoteViewPitch;
		
		/// <summary>Controller of the last Actor that caused us damage.</summary>
		public AController LastHitBy;
		
		/// <summary>Controller currently possessing this Actor</summary>
		public AController Controller;
		
		/// <summary>
		/// Accumulated control input vector, stored in world space. This is the pending input, which is cleared (zeroed) once consumed.
		/// @see GetPendingMovementInputVector(), AddMovementInput()
		/// </summary>
		public FVector ControlInputVector;
		
		/// <summary>
		/// The last control input vector that was processed by ConsumeMovementInputVector().
		/// @see GetLastMovementInputVector()
		/// </summary>
		public FVector LastControlInputVector;
		
		
	}
	
}
