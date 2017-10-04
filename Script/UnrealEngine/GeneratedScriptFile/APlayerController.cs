using System;
namespace UnrealEngine
{
	public partial class APlayerController:AController
	{
		/// <summary>
		/// Returns the location the PlayerController is focused on.
		/// If there is a possessed Pawn, returns the Pawn's location.
		/// If there is a spectator Pawn, returns that Pawn's location.
		/// Otherwise, returns the PlayerController's spawn location (usually the last known Pawn location after it has died).
		/// </summary>
		public extern virtual FVector GetFocalLocation();
		/// <summary>Get the Pawn used when spectating. NULL when not spectating.</summary>
		public extern ASpectatorPawn GetSpectatorPawn();
		/// <summary>Notify from server that Visual Logger is recording, to show that information on client about possible performance issues</summary>
		public extern virtual void OnServerStartedVisualLogger(bool bIsLogging);
		/// <summary>
		/// Server/SP only function for changing whether the player is in cinematic mode.  Updates values of various state variables, then replicates the call to the client
		/// to sync the current cinematic mode.
		/// @param       bInCinematicMode        specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.
		/// @param       bHidePlayer                     specify true to hide the player's pawn (only relevant if bInCinematicMode is true)
		/// @param       bAffectsHUD                     specify true if we should show/hide the HUD to match the value of bCinematicMode
		/// @param       bAffectsMovement        specify true to disable movement in cinematic mode, enable it when leaving
		/// @param       bAffectsTurning         specify true to disable turning in cinematic mode or enable it when leaving
		/// </summary>
		public extern virtual void SetCinematicMode(bool bInCinematicMode,bool bHidePlayer,bool bAffectsHUD,bool bAffectsMovement,bool bAffectsTurning);
		/// <summary>Clear any overrides that have been applied to audio listener</summary>
		public extern void ClearAudioListenerOverride();
		/// <summary>
		/// Used to override the default positioning of the audio listener
		/// @param AttachToComponent Optional component to attach the audio listener to
		/// @param Location Depending on whether Component is attached this is either an offset from its location or an absolute position
		/// @param Rotation Depending on whether Component is attached this is either an offset from its rotation or an absolute rotation
		/// </summary>
		public extern void SetAudioListenerOverride(USceneComponent AttachToComponent,FVector Location,FRotator Rotation);
		/// <summary>
		/// Set the view target blending with variable control
		/// @param NewViewTarget - new actor to set as view target
		/// @param BlendTime - time taken to blend
		/// @param BlendFunc - Cubic, Linear etc functions for blending
		/// @param BlendExp -  Exponent, used by certain blend functions to control the shape of the curve.
		/// @param bLockOutgoing - If true, lock outgoing viewtarget to last frame's camera position for the remainder of the blend.
		/// </summary>
		public extern virtual void SetViewTargetWithBlend(AActor NewViewTarget,float BlendTime=0.000000f,EViewTargetBlendFunction BlendFunc=EViewTargetBlendFunction.VTBlend_Linear,float BlendExp=0.000000f,bool bLockOutgoing=false);
		/// <summary>
		/// Change Camera mode
		/// @param       New camera mode to set
		/// </summary>
		public extern virtual void Camera(FName NewMode);
		/// <summary>Set the virtual joystick visibility.</summary>
		public extern virtual void SetVirtualJoystickVisibility(bool bVisible);
		/// <summary>Activates a new touch interface for this player controller</summary>
		public extern virtual void ActivateTouchInterface(UTouchInterface NewTouchInterface);
		/// <summary>Retrieves the X and Y displacement of the given analog stick.</summary>
		public extern void GetInputAnalogStickState(EControllerAnalogStick WhichStick,out float StickX,out float StickY);
		/// <summary>Retrieves how far the mouse moved this frame.</summary>
		public extern void GetInputMouseDelta(out float DeltaX,out float DeltaY);
		/// <summary>Returns how long the given key/button has been down.  Returns 0 if it's up or it just went down this frame.</summary>
		public extern float GetInputKeyTimeDown(FKey Key);
		/// <summary>Retrieves the X and Y screen coordinates of the mouse cursor. Returns false if there is no associated mouse device</summary>
		public extern bool GetMousePosition(out float LocationX,out float LocationY);
		/// <summary>Retrieves the current motion state of the player's input device</summary>
		public extern void GetInputMotionState(out FVector Tilt,out FVector RotationRate,out FVector Gravity,out FVector Acceleration);
		/// <summary>Retrieves the X and Y screen coordinates of the specified touch key. Returns false if the touch index is not down</summary>
		public extern void GetInputTouchState(ETouchIndex FingerIndex,out float LocationX,out float LocationY,out bool bIsCurrentlyPressed);
		/// <summary>Returns the vector value for the given key/button.</summary>
		public extern FVector GetInputVectorKeyState(FKey Key);
		/// <summary>Returns the analog value for the given key/button.  If analog isn't supported, returns 1 for down and 0 for up.</summary>
		public extern float GetInputAnalogKeyState(FKey Key);
		/// <summary>Returns true if the given key/button was down last frame and up this frame.</summary>
		public extern bool WasInputKeyJustReleased(FKey Key);
		/// <summary>Returns true if the given key/button was up last frame and down this frame.</summary>
		public extern bool WasInputKeyJustPressed(FKey Key);
		/// <summary>Returns true if the given key/button is pressed on the input of the controller (if present)</summary>
		public extern bool IsInputKeyDown(FKey Key);
		/// <summary>
		/// Add Roll input. This value is multiplied by InputRollScale.
		/// @param Val Amount to add to Roll. This value is multiplied by InputRollScale.
		/// </summary>
		public extern virtual void AddRollInput(float Val);
		/// <summary>
		/// Add Yaw (turn) input. This value is multiplied by InputYawScale.
		/// @param Val Amount to add to Yaw. This value is multiplied by InputYawScale.
		/// </summary>
		public extern virtual void AddYawInput(float Val);
		/// <summary>
		/// Add Pitch (look up) input. This value is multiplied by InputPitchScale.
		/// @param Val Amount to add to Pitch. This value is multiplied by InputPitchScale.
		/// </summary>
		public extern virtual void AddPitchInput(float Val);
		/// <summary>Used by UGameplayDebuggingControllerComponent to replicate messages for AI debugging in network games.</summary>
		public extern virtual void ServerToggleAILogging();
		/// <summary>@todo document</summary>
		public extern virtual void ClientTeamMessage(APlayerState SenderPlayerState,FString S,FName Type,float MsgLifeTime);
		/// <summary>Move camera to current user</summary>
		public extern virtual void ServerViewSelf(FViewTargetTransitionParams TransitionParams);
		/// <summary>Move camera to previous player on round ended or spectating</summary>
		public extern virtual void ServerViewPrevPlayer();
		/// <summary>Move camera to next player on round ended or spectating</summary>
		public extern virtual void ServerViewNextPlayer();
		/// <summary>Used by client to request server to confirm current viewtarget (server will respond with ClientSetViewTarget() ).</summary>
		public extern virtual void ServerVerifyViewTarget();
		/// <summary>
		/// Called when the client adds/removes a streamed level
		/// the server will only replicate references to Actors in visible levels so that it's impossible to send references to
		/// Actors the client has not initialized
		/// @param PackageName the name of the package for the level whose status changed
		/// </summary>
		public extern void ServerUpdateLevelVisibility(FName PackageName,bool bIsVisible);
		/// <summary>If PlayerCamera.bUseClientSideCameraUpdates is set, client will replicate camera positions to the server. // @TODO - combine pitch/yaw into one int, maybe also send location compressed</summary>
		public extern virtual void ServerUpdateCamera(FVector_NetQuantize CamLoc,int CamPitchAndYaw);
		/// <summary>Notifies the server that the client has ticked gameplay code, and should no longer get the extended "still loading" timeout grace period</summary>
		public extern virtual void ServerShortTimeout();
		/// <summary>Reliable version of ServerCheckClientPossession to be used when there is no likely danger of spamming the network.</summary>
		public extern virtual void ServerCheckClientPossessionReliable();
		/// <summary>Tells the server to make sure the possessed pawn is in sync with the client.</summary>
		public extern virtual void ServerCheckClientPossession();
		/// <summary>When spectating, updates spectator location/rotation and pings the server to make sure spectating should continue.</summary>
		public extern virtual void ServerSetSpectatorLocation(FVector NewLoc,FRotator NewRot);
		/// <summary>Attempts to restart this player, generally called from the client upon respawn request.</summary>
		public extern virtual void ServerRestartPlayer();
		/// <summary>Replicate pause request to the server</summary>
		public extern virtual void ServerPause();
		/// <summary>
		/// Called to notify the server when the client has loaded a new world via seamless traveling
		/// @param WorldPackageName the name of the world package that was loaded
		/// </summary>
		public extern void ServerNotifyLoadedWorld(FName WorldPackageName);
		/// <summary>Change name of server</summary>
		public extern virtual void ServerChangeName(FString S);
		/// <summary>change mode of camera</summary>
		public extern virtual void ServerCamera(FName NewMode);
		/// <summary>acknowledge possession of pawn</summary>
		public extern virtual void ServerAcknowledgePossession(APawn P);
		/// <summary>send client localized message id</summary>
		public extern virtual void ClientReceiveLocalizedMessage(TSubclassOf<ULocalMessage>  Message,int Switch,APlayerState RelatedPlayerState_1,APlayerState RelatedPlayerState_2,UObject OptionalObject);
		/// <summary>Assign Pawn to player, but avoid calling ClientRestart if we have already accepted this pawn</summary>
		public extern virtual void ClientRetryClientRestart(APawn NewPawn);
		/// <summary>Notify client that the session is about to start</summary>
		public extern virtual void ClientEndOnlineSession();
		/// <summary>Notify client that the session is starting</summary>
		public extern virtual void ClientStartOnlineSession();
		/// <summary>Notify client they were kicked from the server</summary>
		public extern virtual void ClientWasKicked(FText KickReason);
		/// <summary>
		/// Replicated Update streaming status
		/// @param PackageName - Name of the level package name used for loading.
		/// @param bNewShouldBeLoaded - Whether the level should be loaded
		/// @param bNewShouldBeVisible - Whether the level should be visible if it is loaded
		/// @param bNewShouldBlockOnLoad - Whether we want to force a blocking load
		/// @param LODIndex                              - Current LOD index for a streaming level
		/// </summary>
		public extern virtual void ClientUpdateLevelStreamingStatus(FName PackageName,bool bNewShouldBeLoaded,bool bNewShouldBeVisible,bool bNewShouldBlockOnLoad,int LODIndex);
		/// <summary>
		/// Internal clientside implementation of ClientTravel - use ClientTravel to call this
		/// @param URL                           A string containing the mapname (or IP address) to travel to, along with option key/value pairs
		/// @param TravelType            specifies whether the client should append URL options used in previous travels; if true is specified
		///                                                      for the bSeamlesss parameter, this value must be TRAVEL_Relative.
		/// @param bSeamless                     Indicates whether to use seamless travel (requires TravelType of TRAVEL_Relative)
		/// @param MapPackageGuid        The GUID of the map package to travel to - this is used to find the file when it has been autodownloaded,
		///                                                      so it is only needed for clients
		/// </summary>
		public extern virtual void ClientTravelInternal(FString URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid);
		/// <summary>
		/// Travel to a different map or IP address. Calls the PreClientTravel event before doing anything.
		/// NOTE: This is implemented as a locally executed wrapper for ClientTravelInternal, to avoid API compatability breakage
		/// @param URL                           A string containing the mapname (or IP address) to travel to, along with option key/value pairs
		/// @param TravelType            specifies whether the client should append URL options used in previous travels; if true is specified
		///                                                      for the bSeamlesss parameter, this value must be TRAVEL_Relative.
		/// @param bSeamless                     Indicates whether to use seamless travel (requires TravelType of TRAVEL_Relative)
		/// @param MapPackageGuid        The GUID of the map package to travel to - this is used to find the file when it has been autodownloaded,
		///                                                      so it is only needed for clients
		/// </summary>
		public extern void ClientTravel(FString URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid);
		/// <summary>
		/// Sets the light color of the player's controller
		/// @param        Color                                   The color for the light to be
		/// </summary>
		public extern void SetControllerLightColor(FColor Color);
		/// <summary>
		/// Latent action that controls the playing of force feedback
		/// Begins playing when Start is called.  Calling Update or Stop if the feedback is not active will have no effect.
		/// Completed will execute when Stop is called or the duration ends.
		/// When Update is called the Intensity, Duration, and affect values will be updated with the current inputs
		/// @param       Intensity                               How strong the feedback should be.  Valid values are between 0.0 and 1.0
		/// @param       Duration                                How long the feedback should play for.  If the value is negative it will play until stopped
		/// @param   bAffectsLeftLarge           Whether the intensity should be applied to the large left servo
		/// @param   bAffectsLeftSmall           Whether the intensity should be applied to the small left servo
		/// @param   bAffectsRightLarge          Whether the intensity should be applied to the large right servo
		/// @param   bAffectsRightSmall          Whether the intensity should be applied to the small right servo
		/// </summary>
		public extern void PlayDynamicForceFeedback(float Intensity,float Duration,bool bAffectsLeftLarge,bool bAffectsLeftSmall,bool bAffectsRightLarge,bool bAffectsRightSmall,EDynamicForceFeedbackAction Action,FLatentActionInfo LatentInfo);
		/// <summary>
		/// Stops a playing force feedback pattern
		/// @param       ForceFeedbackEffect             If set only patterns from that effect will be stopped
		/// @param       Tag                                             If not none only the pattern with this tag will be stopped
		/// </summary>
		public extern virtual void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,FName Tag);
		/// <summary>
		/// Play a force feedback pattern on the player's controller
		/// @param       ForceFeedbackEffect             The force feedback pattern to play
		/// @param       bLooping                                Whether the pattern should be played repeatedly or be a single one shot
		/// @param       Tag                                             A tag that allows stopping of an effect.  If another effect with this Tag is playing, it will be stopped and replaced
		/// </summary>
		public extern virtual void ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,bool bLooping,FName Tag);
		/// <summary>Stop camera shake on client.</summary>
		public extern virtual void ClientStopCameraShake(TSubclassOf<UCameraShake>  Shake,bool bImmediately=true);
		/// <summary>Stop camera animation on client.</summary>
		public extern virtual void ClientStopCameraAnim(UCameraAnim AnimToStop);
		/// <summary>Removes all Camera Lens Effects.</summary>
		public extern virtual void ClientClearCameraLensEffects();
		/// <summary>Spawn a camera lens effect (e.g. blood).</summary>
		public extern virtual void ClientSpawnCameraLensEffect(TSubclassOf<AEmitterCameraLensEffectBase>  LensEffectEmitterClass);
		/// <summary>
		/// Set the view target
		/// @param A - new actor to set as view target
		/// @param TransitionParams - parameters to use for controlling the transition
		/// </summary>
		public extern virtual void ClientSetViewTarget(AActor A,FViewTargetTransitionParams TransitionParams);
		/// <summary>Gets the HUD currently being used by this player controller</summary>
		public extern AHUD GetHUD();
		/// <summary>Helper to get the size of the HUD canvas for this player controller.  Returns 0 if there is no HUD</summary>
		public extern void GetViewportSize(out int SizeX,out int SizeY);
		/// <summary>Set the client's class of HUD and spawns a new instance of it. If there was already a HUD active, it is destroyed.</summary>
		public extern virtual void ClientSetHUD(TSubclassOf<AHUD>  NewHUDClass);
		/// <summary>
		/// Forces the streaming system to disregard the normal logic for the specified duration and
		/// instead always load all mip-levels for all textures used by the specified material.
		/// @param Material              - The material whose textures should be forced into memory.
		/// @param ForceDuration - Number of seconds to keep all mip-levels in memory, disregarding the normal priority logic.
		/// @param CinematicTextureGroups        - Bitfield indicating which texture groups that use extra high-resolution mips
		/// </summary>
		public extern virtual void ClientSetForceMipLevelsToBeResident(UMaterialInterface Material,float ForceDuration,int CinematicTextureGroups);
		/// <summary>Called by the server to synchronize cinematic transitions with the client</summary>
		public extern virtual void ClientSetCinematicMode(bool bInCinematicMode,bool bAffectsMovement,bool bAffectsTurning,bool bAffectsHUD);
		/// <summary>
		/// Replicated function to set camera style on client
		/// @param       NewCamMode, name defining the new camera mode
		/// </summary>
		public extern virtual void ClientSetCameraMode(FName NewCamMode);
		/// <summary>
		/// Tell client to fade camera
		/// @Param bEnableFading - true if we should apply FadeColor/FadeAmount to the screen
		/// @Param FadeColor - Color to fade to
		/// @Param FadeAlpha - Amount of fading to apply
		/// @Param FadeTime - length of time for fade to occur over
		/// @Param bFadeAudio - true to apply fading of audio alongside the video
		/// </summary>
		public extern virtual void ClientSetCameraFade(bool bEnableFading,FColor FadeColor,FVector2D FadeAlpha,float FadeTime,bool bFadeAudio);
		/// <summary>
		/// Tells the client to block until all pending level streaming actions are complete.
		/// Happens at the end of the tick primarily used to force update the client ASAP at join time.
		/// </summary>
		public extern virtual void ClientSetBlockOnAsyncLoading();
		/// <summary>Tell client to restart the level</summary>
		public extern virtual void ClientRestart(APawn NewPawn);
		/// <summary>Tell client to reset the PlayerController</summary>
		public extern virtual void ClientReset();
		/// <summary>
		/// Forces the streaming system to disregard the normal logic for the specified duration and
		/// instead always load all mip-levels for all textures used by the specified actor.
		/// @param ForcedActor           - The actor whose textures should be forced into memory.
		/// @param ForceDuration         - Number of seconds to keep all mip-levels in memory, disregarding the normal priority logic.
		/// @param bEnableStreaming      - Whether to start (true) or stop (false) streaming
		/// @param CinematicTextureGroups        - Bitfield indicating which texture groups that use extra high-resolution mips
		/// </summary>
		public extern virtual void ClientPrestreamTextures(AActor ForcedActor,float ForceDuration,bool bEnableStreaming,int CinematicTextureGroups);
		/// <summary>
		/// Asynchronously loads the given level in preparation for a streaming map transition.
		/// the server sends one function per level name since dynamic arrays can't be replicated
		/// @param LevelNames - the names of the level packages to load. LevelNames[0] will be the new persistent (primary) level
		/// @param bFirst - whether this is the first item in the list (so clear the list first)
		/// @param bLast - whether this is the last item in the list (so start preparing the change after receiving it)
		/// </summary>
		public extern virtual void ClientPrepareMapChange(FName LevelName,bool bFirst,bool bLast);
		/// <summary>
		/// Play sound client-side at the specified location
		/// @param Sound - Sound to play
		/// @param Location - Location to play the sound at
		/// @param VolumeMultiplier - Volume multiplier to apply to the sound
		/// @param PitchMultiplier - Pitch multiplier to apply to the sound
		/// </summary>
		public extern virtual void ClientPlaySoundAtLocation(USoundBase Sound,FVector Location,float VolumeMultiplier,float PitchMultiplier);
		/// <summary>
		/// Play sound client-side (so only the client will hear it)
		/// @param Sound - Sound to play
		/// @param VolumeMultiplier - Volume multiplier to apply to the sound
		/// @param PitchMultiplier - Pitch multiplier to apply to the sound
		/// </summary>
		public extern virtual void ClientPlaySound(USoundBase Sound,float VolumeMultiplier,float PitchMultiplier);
		/// <summary>
		/// Play Camera Shake
		/// @param Shake - Camera shake animation to play
		/// @param Scale - Scalar defining how "intense" to play the anim
		/// @param PlaySpace - Which coordinate system to play the shake in (used for CameraAnims within the shake).
		/// @param UserPlaySpaceRot - Matrix used when PlaySpace = CAPS_UserDefined
		/// </summary>
		public extern virtual void ClientPlayCameraShake(TSubclassOf<UCameraShake>  Shake,float Scale=1.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator));
		/// <summary>
		/// Play the indicated CameraAnim on this camera.
		/// @param AnimToPlay - Camera animation to play
		/// @param Scale - "Intensity" scalar.  This is the scale at which the anim was first played.
		/// @param Rate -  Multiplier for playback rate.  1.0 = normal.
		/// @param BlendInTime - Time to interpolate in from zero, for smooth starts
		/// @param BlendOutTime - Time to interpolate out to zero, for smooth finishes
		/// @param bLoop - True if the animation should loop, false otherwise
		/// @param bRandomStartTime - Whether or not to choose a random time to start playing.  Only really makes sense for bLoop = true
		/// @param Space - Animation play area
		/// @param CustomPlaySpace - Matrix used when Space = CAPS_UserDefined
		/// </summary>
		public extern virtual void ClientPlayCameraAnim(UCameraAnim AnimToPlay,float Scale=1.000000f,float Rate=1.000000f,float BlendInTime=0.000000f,float BlendOutTime=0.000000f,bool bLoop=false,bool bRandomStartTime=false,ECameraAnimPlaySpace Space=ECameraAnimPlaySpace.CameraLocal,FRotator CustomPlaySpace=default(FRotator));
		/// <summary>
		/// Outputs a message to HUD
		/// @param S - message to display
		/// @param Type - @todo document
		/// @param MsgLifeTime - Optional length of time to display 0 = default time
		/// </summary>
		public extern virtual void ClientMessage(FString S,FName Type,float MsgLifeTime);
		/// <summary>calls IgnoreMoveInput on client</summary>
		public extern virtual void ClientIgnoreMoveInput(bool bIgnore);
		/// <summary>calls IgnoreLookInput on client</summary>
		public extern virtual void ClientIgnoreLookInput(bool bIgnore);
		/// <summary>
		/// Server uses this to force client into NewState .
		/// @Note ALL STATE NAMES NEED TO BE DEFINED IN name table in UnrealNames.h to be correctly replicated (so they are mapped to the same thing on client and server).
		/// </summary>
		public extern virtual void ClientGotoState(FName NewState);
		/// <summary>
		/// Replicated function called by GameHasEnded().
		/// @param       EndGameFocus - actor to view with camera
		/// @param       bIsWinner - true if this controller is on winning team
		/// </summary>
		public extern virtual void ClientGameEnded(AActor EndGameFocus,bool bIsWinner);
		/// <summary>Forces GC at the end of the tick on the client</summary>
		public extern virtual void ClientForceGarbageCollection();
		/// <summary>
		/// Tells the client to block until all pending level streaming actions are complete
		/// happens at the end of the tick
		/// primarily used to force update the client ASAP at join time
		/// </summary>
		public extern void ClientFlushLevelStreaming();
		/// <summary>Actually performs the level transition prepared by PrepareMapChange().</summary>
		public extern virtual void ClientCommitMapChange();
		/// <summary>Set CurrentNetSpeed to the lower of its current value and Cap.</summary>
		public extern virtual void ClientCapBandwidth(int Cap);
		/// <summary>Tells client to cancel any pending map change.</summary>
		public extern virtual void ClientCancelPendingMapChange();
		/// <summary>Adds a location to the texture streaming system for the specified duration.</summary>
		public extern void ClientAddTextureStreamingLoc(FVector InLoc,float Duration,bool bOverrideLocation);
		/// <summary>Sends a command to the console to execute if not shipping version</summary>
		public extern virtual void SendToConsole(FString Command);
		/// <summary>Console control commands, useful when remote debugging so you can't touch the console the normal way</summary>
		public extern virtual void ConsoleKey(FKey Key);
		/// <summary>
		/// Tell the client to unmute a player for this controller
		/// @param PlayerId player id to unmute
		/// </summary>
		public extern virtual void ClientUnmutePlayer(FUniqueNetIdRepl PlayerId);
		/// <summary>
		/// Tell the client to mute a player for this controller
		/// @param PlayerId player id to mute
		/// </summary>
		public extern virtual void ClientMutePlayer(FUniqueNetIdRepl PlayerId);
		/// <summary>
		/// Tell the server to unmute a player for this controller
		/// @param PlayerId player id to unmute
		/// </summary>
		public extern virtual void ServerUnmutePlayer(FUniqueNetIdRepl PlayerId);
		/// <summary>
		/// Tell the server to mute a player for this controller
		/// @param PlayerId player id to mute
		/// </summary>
		public extern virtual void ServerMutePlayer(FUniqueNetIdRepl PlayerId);
		/// <summary>
		/// Tells the client that the server has all the information it needs and that it
		/// is ok to start sending voice packets. The server will already send voice packets
		/// when this function is called, since it is set server side and then forwarded
		/// NOTE: This is done as an RPC instead of variable replication because ordering matters
		/// </summary>
		public extern virtual void ClientVoiceHandshakeComplete();
		/// <summary>
		/// Toggle voice chat on and off
		/// @param bSpeaking enable or disable voice chat
		/// </summary>
		public extern virtual void ToggleSpeaking(bool bInSpeaking);
		/// <summary>
		/// Tell the client to enable or disable voice chat (not muting)
		/// @param bEnable enable or disable voice chat
		/// </summary>
		public extern virtual void ClientEnableNetworkVoice(bool bEnable);
		/// <summary>Fire the player's currently selected weapon with the optional firemode.</summary>
		public extern virtual void StartFire(byte FireModeNum=0);
		/// <summary>Positions the mouse cursor in screen space, in pixels.</summary>
		public extern void SetMouseLocation(int X,int Y);
		/// <summary>
		/// Convert a World Space 3D position into a 2D Screen Space position.
		/// @return true if the world coordinate was successfully projected to the screen.
		/// </summary>
		public extern bool ProjectWorldLocationToScreen(FVector WorldLocation,out FVector2D ScreenLocation,bool bPlayerViewportRelative=false);
		/// <summary>Convert current mouse 2D position to World Space 3D position and direction. Returns false if unable to determine value. *</summary>
		public extern bool DeprojectScreenPositionToWorld(float ScreenX,float ScreenY,out FVector WorldLocation,out FVector WorldDirection);
		/// <summary>Convert current mouse 2D position to World Space 3D position and direction. Returns false if unable to determine value. *</summary>
		public extern bool DeprojectMousePositionToWorld(out FVector WorldLocation,out FVector WorldDirection);
		public extern bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex,ETraceTypeQuery TraceChannel,bool bTraceComplex,out FHitResult HitResult);
		public extern bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel,bool bTraceComplex,out FHitResult HitResult);
		/// <summary>SwitchLevel to the given MapURL.</summary>
		public extern virtual void SwitchLevel(FString URL);
		/// <summary>Trys to set the player's name to the given name.</summary>
		public extern virtual void SetName(FString S);
		/// <summary>Command to try to pause the game.</summary>
		public extern virtual void Pause();
		/// <summary>Development RPC for testing object reference replication</summary>
		public extern virtual void ClientRepObjRef(UObject Object);
		/// <summary>Return the client to the main menu gracefully</summary>
		public extern virtual void ClientReturnToMainMenu(FString ReturnReason);
		/// <summary>Causes the client to travel to the given URL</summary>
		public extern virtual void LocalTravel(FString URL);
		/// <summary>Restarts the current level</summary>
		public extern virtual void RestartLevel();
		/// <summary>Set the field of view to NewFOV</summary>
		public extern virtual void FOV(float NewFOV);
		/// <summary>Enables cheats within the game</summary>
		public extern virtual void EnableCheats();
		/// <summary>Indicate that the Spectator is waiting to join/respawn.</summary>
		public extern virtual void ClientSetSpectatorWaiting(bool bWaiting);
		/// <summary>Indicate that the Spectator is waiting to join/respawn.</summary>
		public extern virtual void ServerSetSpectatorWaiting(bool bWaiting);
		/// <summary>UPlayer associated with this PlayerController.  Could be a local player or a net connection.</summary>
		public UPlayer Player;
		
		/// <summary>Used in net games so client can acknowledge it possessed a specific pawn.</summary>
		public APawn AcknowledgedPawn;
		
		/// <summary>Director track that's currently possessing this player controller, or none if not possessed.</summary>
		public UInterpTrackInstDirector ControllingDirTrackInst;
		
		/// <summary>Heads up display associated with this PlayerController.</summary>
		public AHUD MyHUD;
		
		/// <summary>Camera manager associated with this Player Controller.</summary>
		public APlayerCameraManager PlayerCameraManager;
		
		/// <summary>PlayerCamera class should be set for each game, otherwise Engine.PlayerCameraManager is used</summary>
		public TSubclassOf<APlayerCameraManager>  PlayerCameraManagerClass;
		
		/// <summary>
		/// True to allow this player controller to manage the camera target for you,
		/// typically by using the possessed pawn as the camera target. Set to false
		/// if you want to manually control the camera target.
		/// </summary>
		public bool bAutoManageActiveCameraTarget;
		
		/// <summary>Used to replicate the view rotation of targets not owned/possessed by this PlayerController.</summary>
		public FRotator TargetViewRotation;
		
		/// <summary>Interp speed for blending remote view rotation for smoother client updates</summary>
		public float SmoothTargetViewRotationSpeed;
		
		/// <summary>Used to make sure the client is kept synchronized when in a spectator state</summary>
		public float LastSpectatorStateSynchTime;
		
		/// <summary>Last location synced on the server for a spectator.</summary>
		public FVector LastSpectatorSyncLocation;
		
		/// <summary>Last rotation synced on the server for a spectator.</summary>
		public FRotator LastSpectatorSyncRotation;
		
		/// <summary>Cap set by server on bandwidth from client to server in bytes/sec (only has impact if >=2600)</summary>
		public int ClientCap;
		
		/// <summary>Object that manages "cheat" commands.  Not instantiated in shipping builds.</summary>
		public UCheatManager CheatManager;
		
		/// <summary>Class of my CheatManager.  The Cheat Manager is not created in shipping builds</summary>
		public TSubclassOf<UCheatManager>  CheatClass;
		
		/// <summary>Object that manages player input.</summary>
		public UPlayerInput PlayerInput;
		
		/// <summary>True if PlayerController is currently waiting for the match to start or to respawn. Only valid in Spectating state.</summary>
		public bool bPlayerIsWaiting;
		
		/// <summary>
		/// index identifying players using the same base connection (splitscreen clients)
		/// Used by netcode to match replicated PlayerControllers to the correct splitscreen viewport and child connection
		/// replicated via special internal code, not through normal variable replication
		/// </summary>
		public byte NetPlayerIndex;
		
		/// <summary>
		/// this is set on the OLD PlayerController when performing a swap over a network connection
		/// so we know what connection we're waiting on acknowledgment from to finish destroying this PC
		/// (or when the connection is closed)
		/// @see GameModeBase::SwapPlayerControllers()
		/// </summary>
		public UNetConnection PendingSwapConnection;
		
		/// <summary>The net connection this controller is communicating on, NULL for local players on server</summary>
		public UNetConnection NetConnection;
		
		/// <summary>Yaw input speed scaling</summary>
		public float InputYawScale;
		
		/// <summary>Pitch input speed scaling</summary>
		public float InputPitchScale;
		
		/// <summary>Roll input speed scaling</summary>
		public float InputRollScale;
		
		/// <summary>Whether the mouse cursor should be displayed.</summary>
		public bool bShowMouseCursor;
		
		/// <summary>Whether actor/component click events should be generated.</summary>
		public bool bEnableClickEvents;
		
		/// <summary>Whether actor/component touch events should be generated.</summary>
		public bool bEnableTouchEvents;
		
		/// <summary>Whether actor/component mouse over events should be generated.</summary>
		public bool bEnableMouseOverEvents;
		
		/// <summary>Whether actor/component touch over events should be generated.</summary>
		public bool bEnableTouchOverEvents;
		
		public bool bForceFeedbackEnabled;
		
		public EMouseCursor DefaultMouseCursor;
		
		public EMouseCursor CurrentMouseCursor;
		
		/// <summary>Default trace channel used for determining what world object was clicked on.</summary>
		public ECollisionChannel DefaultClickTraceChannel;
		
		/// <summary>Trace channel currently being used for determining what world object was clicked on.</summary>
		public ECollisionChannel CurrentClickTraceChannel;
		
		public float HitResultTraceDistance;
		
		/// <summary>InputComponent we use when player is in Inactive state.</summary>
		public UInputComponent InactiveStateInputComponent;
		
		/// <summary>The currently set touch interface</summary>
		public UTouchInterface CurrentTouchInterface;
		
		/// <summary>The pawn used when spectating (NULL if not spectating).</summary>
		public ASpectatorPawn SpectatorPawn;
		
		/// <summary>The location used internally when there is no pawn or spectator, to know where to spawn the spectator or focus the camera on death.</summary>
		public FVector SpawnLocation;
		
		/// <summary>Set during SpawnActor once and never again to indicate the intent of this controller instance (SERVER ONLY)</summary>
		public bool bIsLocalPlayerController;
		
		/// <summary>Counter for this players seamless travels (used along with the below value, to restrict ServerNotifyLoadedWorld)</summary>
		public ushort SeamlessTravelCount;
		
		/// <summary>The value of SeamlessTravelCount, upon the last call to GameModeBase::HandleSeamlessTravelPlayer; used to detect seamless travel</summary>
		public ushort LastCompletedSeamlessTravelCount;
		
		
	}
	
}
