using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class APlayerController:AController 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetFocalLocation(IntPtr _this);
/// <summary>
/// Returns the location the PlayerController is focused on.
/// If there is a possessed Pawn, returns the Pawn's location.
/// If there is a spectator Pawn, returns that Pawn's location.
/// Otherwise, returns the PlayerController's spawn location (usually the last known Pawn location after it has died).
/// </summary>
public  FVector GetFocalLocation()
{
	CheckIsValid();
	FVector ___ret = GetFocalLocation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetSpectatorPawn(IntPtr _this);
/// <summary>Get the Pawn used when spectating. NULL when not spectating.</summary>
public  ASpectatorPawn GetSpectatorPawn()
{
	CheckIsValid();
	IntPtr ___ret = GetSpectatorPawn(_this.Get());
	if(___ret==IntPtr.Zero) return null; ASpectatorPawn ___ret2= new ASpectatorPawn(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnServerStartedVisualLogger(IntPtr _this,int bIsLogging);
/// <summary>Notify from server that Visual Logger is recording, to show that information on client about possible performance issues</summary>
public  void OnServerStartedVisualLogger(bool bIsLogging)
{
	CheckIsValid();
	OnServerStartedVisualLogger(_this.Get(),bIsLogging?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCinematicMode(IntPtr _this,int bInCinematicMode,int bHidePlayer,int bAffectsHUD,int bAffectsMovement,int bAffectsTurning);
/// <summary>
/// Server/SP only function for changing whether the player is in cinematic mode.  Updates values of various state variables, then replicates the call to the client
/// to sync the current cinematic mode.
/// @param       bInCinematicMode        specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.
/// @param       bHidePlayer                     specify true to hide the player's pawn (only relevant if bInCinematicMode is true)
/// @param       bAffectsHUD                     specify true if we should show/hide the HUD to match the value of bCinematicMode
/// @param       bAffectsMovement        specify true to disable movement in cinematic mode, enable it when leaving
/// @param       bAffectsTurning         specify true to disable turning in cinematic mode or enable it when leaving
/// </summary>
public  void SetCinematicMode(bool bInCinematicMode,bool bHidePlayer,bool bAffectsHUD,bool bAffectsMovement,bool bAffectsTurning)
{
	CheckIsValid();
	SetCinematicMode(_this.Get(),bInCinematicMode?1:0,bHidePlayer?1:0,bAffectsHUD?1:0,bAffectsMovement?1:0,bAffectsTurning?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearAudioListenerOverride(IntPtr _this);
/// <summary>Clear any overrides that have been applied to audio listener</summary>
public  void ClearAudioListenerOverride()
{
	CheckIsValid();
	ClearAudioListenerOverride(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAudioListenerOverride(IntPtr _this,IntPtr AttachToComponent,ref FVector Location,ref FRotator Rotation);
/// <summary>
/// Used to override the default positioning of the audio listener
/// @param AttachToComponent Optional component to attach the audio listener to
/// @param Location Depending on whether Component is attached this is either an offset from its location or an absolute position
/// @param Rotation Depending on whether Component is attached this is either an offset from its rotation or an absolute rotation
/// </summary>
public  void SetAudioListenerOverride(USceneComponent AttachToComponent,FVector Location,FRotator Rotation)
{
	CheckIsValid();
	SetAudioListenerOverride(_this.Get(),AttachToComponent,ref Location,ref Rotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetViewTargetWithBlend(IntPtr _this,IntPtr NewViewTarget,float BlendTime,int BlendFunc,float BlendExp,int bLockOutgoing);
/// <summary>
/// Set the view target blending with variable control
/// @param NewViewTarget - new actor to set as view target
/// @param BlendTime - time taken to blend
/// @param BlendFunc - Cubic, Linear etc functions for blending
/// @param BlendExp -  Exponent, used by certain blend functions to control the shape of the curve.
/// @param bLockOutgoing - If true, lock outgoing viewtarget to last frame's camera position for the remainder of the blend.
/// </summary>
public  void SetViewTargetWithBlend(AActor NewViewTarget,float BlendTime=0.000000f,EViewTargetBlendFunction BlendFunc=EViewTargetBlendFunction.VTBlend_Linear,float BlendExp=0.000000f,bool bLockOutgoing=false)
{
	CheckIsValid();
	SetViewTargetWithBlend(_this.Get(),NewViewTarget,BlendTime,(int)BlendFunc,BlendExp,bLockOutgoing?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Camera(IntPtr _this,string NewMode);
/// <summary>
/// Change Camera mode
/// @param       New camera mode to set
/// </summary>
public  void Camera(string NewMode)
{
	CheckIsValid();
	Camera(_this.Get(),NewMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVirtualJoystickVisibility(IntPtr _this,int bVisible);
/// <summary>Set the virtual joystick visibility.</summary>
public  void SetVirtualJoystickVisibility(bool bVisible)
{
	CheckIsValid();
	SetVirtualJoystickVisibility(_this.Get(),bVisible?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ActivateTouchInterface(IntPtr _this,IntPtr NewTouchInterface);
/// <summary>Activates a new touch interface for this player controller</summary>
public  void ActivateTouchInterface(UTouchInterface NewTouchInterface)
{
	CheckIsValid();
	ActivateTouchInterface(_this.Get(),NewTouchInterface);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetInputAnalogStickState(IntPtr _this,int WhichStick,out float StickX,out float StickY);
/// <summary>Retrieves the X and Y displacement of the given analog stick.</summary>
public  void GetInputAnalogStickState(EControllerAnalogStick WhichStick,out float StickX,out float StickY)
{
	CheckIsValid();
	GetInputAnalogStickState(_this.Get(),(int)WhichStick,out StickX,out StickY);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetInputMouseDelta(IntPtr _this,out float DeltaX,out float DeltaY);
/// <summary>Retrieves how far the mouse moved this frame.</summary>
public  void GetInputMouseDelta(out float DeltaX,out float DeltaY)
{
	CheckIsValid();
	GetInputMouseDelta(_this.Get(),out DeltaX,out DeltaY);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInputKeyTimeDown(IntPtr _this,ref FKey Key);
/// <summary>Returns how long the given key/button has been down.  Returns 0 if it's up or it just went down this frame.</summary>
public  float GetInputKeyTimeDown(FKey Key)
{
	CheckIsValid();
	float ___ret = GetInputKeyTimeDown(_this.Get(),ref Key);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMousePosition(IntPtr _this,out float LocationX,out float LocationY);
/// <summary>Retrieves the X and Y screen coordinates of the mouse cursor. Returns false if there is no associated mouse device</summary>
public  bool GetMousePosition(out float LocationX,out float LocationY)
{
	CheckIsValid();
	int ___ret = GetMousePosition(_this.Get(),out LocationX,out LocationY);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetInputMotionState(IntPtr _this,out FVector Tilt,out FVector RotationRate,out FVector Gravity,out FVector Acceleration);
/// <summary>Retrieves the current motion state of the player's input device</summary>
public  void GetInputMotionState(out FVector Tilt,out FVector RotationRate,out FVector Gravity,out FVector Acceleration)
{
	CheckIsValid();
	GetInputMotionState(_this.Get(),out Tilt,out RotationRate,out Gravity,out Acceleration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetInputTouchState(IntPtr _this,int FingerIndex,out float LocationX,out float LocationY,out int bIsCurrentlyPressed);
/// <summary>Retrieves the X and Y screen coordinates of the specified touch key. Returns false if the touch index is not down</summary>
public  void GetInputTouchState(ETouchIndex FingerIndex,out float LocationX,out float LocationY,out bool bIsCurrentlyPressed)
{
	CheckIsValid();
	int bIsCurrentlyPressed_temp;
	GetInputTouchState(_this.Get(),(int)FingerIndex,out LocationX,out LocationY,out bIsCurrentlyPressed_temp);
	bIsCurrentlyPressed=bIsCurrentlyPressed_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetInputVectorKeyState(IntPtr _this,ref FKey Key);
/// <summary>Returns the vector value for the given key/button.</summary>
public  FVector GetInputVectorKeyState(FKey Key)
{
	CheckIsValid();
	FVector ___ret = GetInputVectorKeyState(_this.Get(),ref Key);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInputAnalogKeyState(IntPtr _this,ref FKey Key);
/// <summary>Returns the analog value for the given key/button.  If analog isn't supported, returns 1 for down and 0 for up.</summary>
public  float GetInputAnalogKeyState(FKey Key)
{
	CheckIsValid();
	float ___ret = GetInputAnalogKeyState(_this.Get(),ref Key);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int WasInputKeyJustReleased(IntPtr _this,ref FKey Key);
/// <summary>Returns true if the given key/button was down last frame and up this frame.</summary>
public  bool WasInputKeyJustReleased(FKey Key)
{
	CheckIsValid();
	int ___ret = WasInputKeyJustReleased(_this.Get(),ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int WasInputKeyJustPressed(IntPtr _this,ref FKey Key);
/// <summary>Returns true if the given key/button was up last frame and down this frame.</summary>
public  bool WasInputKeyJustPressed(FKey Key)
{
	CheckIsValid();
	int ___ret = WasInputKeyJustPressed(_this.Get(),ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsInputKeyDown(IntPtr _this,ref FKey Key);
/// <summary>Returns true if the given key/button is pressed on the input of the controller (if present)</summary>
public  bool IsInputKeyDown(FKey Key)
{
	CheckIsValid();
	int ___ret = IsInputKeyDown(_this.Get(),ref Key);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddRollInput(IntPtr _this,float Val);
/// <summary>
/// Add Roll input. This value is multiplied by InputRollScale.
/// @param Val Amount to add to Roll. This value is multiplied by InputRollScale.
/// </summary>
public  void AddRollInput(float Val)
{
	CheckIsValid();
	AddRollInput(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddYawInput(IntPtr _this,float Val);
/// <summary>
/// Add Yaw (turn) input. This value is multiplied by InputYawScale.
/// @param Val Amount to add to Yaw. This value is multiplied by InputYawScale.
/// </summary>
public  void AddYawInput(float Val)
{
	CheckIsValid();
	AddYawInput(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddPitchInput(IntPtr _this,float Val);
/// <summary>
/// Add Pitch (look up) input. This value is multiplied by InputPitchScale.
/// @param Val Amount to add to Pitch. This value is multiplied by InputPitchScale.
/// </summary>
public  void AddPitchInput(float Val)
{
	CheckIsValid();
	AddPitchInput(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerToggleAILogging(IntPtr _this);
/// <summary>Used by UGameplayDebuggingControllerComponent to replicate messages for AI debugging in network games.</summary>
public  void ServerToggleAILogging()
{
	CheckIsValid();
	ServerToggleAILogging(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientTeamMessage(IntPtr _this,IntPtr SenderPlayerState,string S,string Type,float MsgLifeTime);
/// <summary>@todo document</summary>
public  void ClientTeamMessage(APlayerState SenderPlayerState,string S,string Type,float MsgLifeTime)
{
	CheckIsValid();
	ClientTeamMessage(_this.Get(),SenderPlayerState,S,Type,MsgLifeTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerViewSelf(IntPtr _this,ref FViewTargetTransitionParams TransitionParams);
/// <summary>Move camera to current user</summary>
public  void ServerViewSelf(FViewTargetTransitionParams TransitionParams)
{
	CheckIsValid();
	ServerViewSelf(_this.Get(),ref TransitionParams);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerViewPrevPlayer(IntPtr _this);
/// <summary>Move camera to previous player on round ended or spectating</summary>
public  void ServerViewPrevPlayer()
{
	CheckIsValid();
	ServerViewPrevPlayer(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerViewNextPlayer(IntPtr _this);
/// <summary>Move camera to next player on round ended or spectating</summary>
public  void ServerViewNextPlayer()
{
	CheckIsValid();
	ServerViewNextPlayer(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerVerifyViewTarget(IntPtr _this);
/// <summary>Used by client to request server to confirm current viewtarget (server will respond with ClientSetViewTarget() ).</summary>
public  void ServerVerifyViewTarget()
{
	CheckIsValid();
	ServerVerifyViewTarget(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerUpdateLevelVisibility(IntPtr _this,string PackageName,int bIsVisible);
/// <summary>
/// Called when the client adds/removes a streamed level
/// the server will only replicate references to Actors in visible levels so that it's impossible to send references to
/// Actors the client has not initialized
/// @param PackageName the name of the package for the level whose status changed
/// </summary>
public  void ServerUpdateLevelVisibility(string PackageName,bool bIsVisible)
{
	CheckIsValid();
	ServerUpdateLevelVisibility(_this.Get(),PackageName,bIsVisible?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerUpdateCamera(IntPtr _this,ref FVector_NetQuantize CamLoc,int CamPitchAndYaw);
/// <summary>If PlayerCamera.bUseClientSideCameraUpdates is set, client will replicate camera positions to the server. // @TODO - combine pitch/yaw into one int, maybe also send location compressed</summary>
public  void ServerUpdateCamera(FVector_NetQuantize CamLoc,int CamPitchAndYaw)
{
	CheckIsValid();
	ServerUpdateCamera(_this.Get(),ref CamLoc,CamPitchAndYaw);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerShortTimeout(IntPtr _this);
/// <summary>Notifies the server that the client has ticked gameplay code, and should no longer get the extended "still loading" timeout grace period</summary>
public  void ServerShortTimeout()
{
	CheckIsValid();
	ServerShortTimeout(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerCheckClientPossessionReliable(IntPtr _this);
/// <summary>Reliable version of ServerCheckClientPossession to be used when there is no likely danger of spamming the network.</summary>
public  void ServerCheckClientPossessionReliable()
{
	CheckIsValid();
	ServerCheckClientPossessionReliable(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerCheckClientPossession(IntPtr _this);
/// <summary>Tells the server to make sure the possessed pawn is in sync with the client.</summary>
public  void ServerCheckClientPossession()
{
	CheckIsValid();
	ServerCheckClientPossession(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerSetSpectatorLocation(IntPtr _this,ref FVector NewLoc,ref FRotator NewRot);
/// <summary>When spectating, updates spectator location/rotation and pings the server to make sure spectating should continue.</summary>
public  void ServerSetSpectatorLocation(FVector NewLoc,FRotator NewRot)
{
	CheckIsValid();
	ServerSetSpectatorLocation(_this.Get(),ref NewLoc,ref NewRot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerRestartPlayer(IntPtr _this);
/// <summary>Attempts to restart this player, generally called from the client upon respawn request.</summary>
public  void ServerRestartPlayer()
{
	CheckIsValid();
	ServerRestartPlayer(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerPause(IntPtr _this);
/// <summary>Replicate pause request to the server</summary>
public  void ServerPause()
{
	CheckIsValid();
	ServerPause(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerNotifyLoadedWorld(IntPtr _this,string WorldPackageName);
/// <summary>
/// Called to notify the server when the client has loaded a new world via seamless traveling
/// @param WorldPackageName the name of the world package that was loaded
/// </summary>
public  void ServerNotifyLoadedWorld(string WorldPackageName)
{
	CheckIsValid();
	ServerNotifyLoadedWorld(_this.Get(),WorldPackageName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerChangeName(IntPtr _this,string S);
/// <summary>Change name of server</summary>
public  void ServerChangeName(string S)
{
	CheckIsValid();
	ServerChangeName(_this.Get(),S);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerCamera(IntPtr _this,string NewMode);
/// <summary>change mode of camera</summary>
public  void ServerCamera(string NewMode)
{
	CheckIsValid();
	ServerCamera(_this.Get(),NewMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerAcknowledgePossession(IntPtr _this,IntPtr P);
/// <summary>acknowledge possession of pawn</summary>
public  void ServerAcknowledgePossession(APawn P)
{
	CheckIsValid();
	ServerAcknowledgePossession(_this.Get(),P);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientReceiveLocalizedMessage(IntPtr _this,IntPtr Message,int Switch,IntPtr RelatedPlayerState_1,IntPtr RelatedPlayerState_2,IntPtr OptionalObject);
/// <summary>send client localized message id</summary>
public  void ClientReceiveLocalizedMessage(TSubclassOf<ULocalMessage>  Message,int Switch,APlayerState RelatedPlayerState_1,APlayerState RelatedPlayerState_2,UObject OptionalObject)
{
	CheckIsValid();
	ClientReceiveLocalizedMessage(_this.Get(),Message.NativeClass,Switch,RelatedPlayerState_1,RelatedPlayerState_2,OptionalObject);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientRetryClientRestart(IntPtr _this,IntPtr NewPawn);
/// <summary>Assign Pawn to player, but avoid calling ClientRestart if we have already accepted this pawn</summary>
public  void ClientRetryClientRestart(APawn NewPawn)
{
	CheckIsValid();
	ClientRetryClientRestart(_this.Get(),NewPawn);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientEndOnlineSession(IntPtr _this);
/// <summary>Notify client that the session is about to start</summary>
public  void ClientEndOnlineSession()
{
	CheckIsValid();
	ClientEndOnlineSession(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientStartOnlineSession(IntPtr _this);
/// <summary>Notify client that the session is starting</summary>
public  void ClientStartOnlineSession()
{
	CheckIsValid();
	ClientStartOnlineSession(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientWasKicked(IntPtr _this,string KickReason);
/// <summary>Notify client they were kicked from the server</summary>
public  void ClientWasKicked(string KickReason)
{
	CheckIsValid();
	ClientWasKicked(_this.Get(),KickReason);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientUpdateLevelStreamingStatus(IntPtr _this,string PackageName,int bNewShouldBeLoaded,int bNewShouldBeVisible,int bNewShouldBlockOnLoad,int LODIndex);
/// <summary>
/// Replicated Update streaming status
/// @param PackageName - Name of the level package name used for loading.
/// @param bNewShouldBeLoaded - Whether the level should be loaded
/// @param bNewShouldBeVisible - Whether the level should be visible if it is loaded
/// @param bNewShouldBlockOnLoad - Whether we want to force a blocking load
/// @param LODIndex                              - Current LOD index for a streaming level
/// </summary>
public  void ClientUpdateLevelStreamingStatus(string PackageName,bool bNewShouldBeLoaded,bool bNewShouldBeVisible,bool bNewShouldBlockOnLoad,int LODIndex)
{
	CheckIsValid();
	ClientUpdateLevelStreamingStatus(_this.Get(),PackageName,bNewShouldBeLoaded?1:0,bNewShouldBeVisible?1:0,bNewShouldBlockOnLoad?1:0,LODIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientTravelInternal(IntPtr _this,string URL,int TravelType,int bSeamless,ref FGuid MapPackageGuid);
/// <summary>
/// Internal clientside implementation of ClientTravel - use ClientTravel to call this
/// @param URL                           A string containing the mapname (or IP address) to travel to, along with option key/value pairs
/// @param TravelType            specifies whether the client should append URL options used in previous travels; if true is specified
///                                                      for the bSeamlesss parameter, this value must be TRAVEL_Relative.
/// @param bSeamless                     Indicates whether to use seamless travel (requires TravelType of TRAVEL_Relative)
/// @param MapPackageGuid        The GUID of the map package to travel to - this is used to find the file when it has been autodownloaded,
///                                                      so it is only needed for clients
/// </summary>
public  void ClientTravelInternal(string URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid)
{
	CheckIsValid();
	ClientTravelInternal(_this.Get(),URL,(int)TravelType,bSeamless?1:0,ref MapPackageGuid);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientTravel(IntPtr _this,string URL,int TravelType,int bSeamless,ref FGuid MapPackageGuid);
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
public  void ClientTravel(string URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid)
{
	CheckIsValid();
	ClientTravel(_this.Get(),URL,(int)TravelType,bSeamless?1:0,ref MapPackageGuid);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetControllerLightColor(IntPtr _this,ref FColor Color);
/// <summary>
/// Sets the light color of the player's controller
/// @param        Color                                   The color for the light to be
/// </summary>
public  void SetControllerLightColor(FColor Color)
{
	CheckIsValid();
	SetControllerLightColor(_this.Get(),ref Color);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHapticsByValue(IntPtr _this,float Frequency,float Amplitude,int Hand);
/// <summary>
/// Sets the value of the haptics for the specified hand directly, using frequency and amplitude.  NOTE:  If a curve is already
/// playing for this hand, it will be cancelled in favour of the specified values.
/// @param        Frequency                               The normalized frequency [0.0, 1.0] to play through the haptics system
/// @param        Amplitude                               The normalized amplitude [0.0, 1.0] to set the haptic feedback to
/// @param        Hand                                    Which hand to play the effect on
/// </summary>
public  void SetHapticsByValue(float Frequency,float Amplitude,EControllerHand Hand)
{
	CheckIsValid();
	SetHapticsByValue(_this.Get(),Frequency,Amplitude,(int)Hand);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopHapticEffect(IntPtr _this,int Hand);
/// <summary>
/// Stops a playing haptic feedback curve
/// @param        HapticEffect                    The haptic effect to stop
/// @param        Hand                                    Which hand to stop the effect for
/// </summary>
public  void StopHapticEffect(EControllerHand Hand)
{
	CheckIsValid();
	StopHapticEffect(_this.Get(),(int)Hand);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayHapticEffect(IntPtr _this,IntPtr HapticEffect,int Hand,float Scale,int bLoop);
/// <summary>
/// Play a haptic feedback curve on the player's controller
/// @param        HapticEffect                    The haptic effect to play
/// @param        Hand                                    Which hand to play the effect on
/// @param        Scale                                   Scale between 0.0 and 1.0 on the intensity of playback
/// </summary>
public  void PlayHapticEffect(UHapticFeedbackEffect_Base HapticEffect,EControllerHand Hand,float Scale=1.000000f,bool bLoop=false)
{
	CheckIsValid();
	PlayHapticEffect(_this.Get(),HapticEffect,(int)Hand,Scale,bLoop?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayDynamicForceFeedback(IntPtr _this,float Intensity,float Duration,int bAffectsLeftLarge,int bAffectsLeftSmall,int bAffectsRightLarge,int bAffectsRightSmall,int Action,ref FLatentActionInfo LatentInfo);
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
public  void PlayDynamicForceFeedback(float Intensity,float Duration,bool bAffectsLeftLarge,bool bAffectsLeftSmall,bool bAffectsRightLarge,bool bAffectsRightSmall,EDynamicForceFeedbackAction Action,FLatentActionInfo LatentInfo)
{
	CheckIsValid();
	PlayDynamicForceFeedback(_this.Get(),Intensity,Duration,bAffectsLeftLarge?1:0,bAffectsLeftSmall?1:0,bAffectsRightLarge?1:0,bAffectsRightSmall?1:0,(int)Action,ref LatentInfo);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientStopForceFeedback(IntPtr _this,IntPtr ForceFeedbackEffect,string Tag);
/// <summary>
/// Stops a playing force feedback pattern
/// @param       ForceFeedbackEffect             If set only patterns from that effect will be stopped
/// @param       Tag                                             If not none only the pattern with this tag will be stopped
/// </summary>
public  void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,string Tag)
{
	CheckIsValid();
	ClientStopForceFeedback(_this.Get(),ForceFeedbackEffect,Tag);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientPlayForceFeedback(IntPtr _this,IntPtr ForceFeedbackEffect,int bLooping,string Tag);
/// <summary>
/// Play a force feedback pattern on the player's controller
/// @param       ForceFeedbackEffect             The force feedback pattern to play
/// @param       bLooping                                Whether the pattern should be played repeatedly or be a single one shot
/// @param       Tag                                             A tag that allows stopping of an effect.  If another effect with this Tag is playing, it will be stopped and replaced
/// </summary>
public  void ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,bool bLooping,string Tag)
{
	CheckIsValid();
	ClientPlayForceFeedback(_this.Get(),ForceFeedbackEffect,bLooping?1:0,Tag);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientStopCameraShake(IntPtr _this,IntPtr Shake,int bImmediately);
/// <summary>Stop camera shake on client.</summary>
public  void ClientStopCameraShake(TSubclassOf<UCameraShake>  Shake,bool bImmediately=true)
{
	CheckIsValid();
	ClientStopCameraShake(_this.Get(),Shake.NativeClass,bImmediately?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientStopCameraAnim(IntPtr _this,IntPtr AnimToStop);
/// <summary>Stop camera animation on client.</summary>
public  void ClientStopCameraAnim(UCameraAnim AnimToStop)
{
	CheckIsValid();
	ClientStopCameraAnim(_this.Get(),AnimToStop);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientClearCameraLensEffects(IntPtr _this);
/// <summary>Removes all Camera Lens Effects.</summary>
public  void ClientClearCameraLensEffects()
{
	CheckIsValid();
	ClientClearCameraLensEffects(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSpawnCameraLensEffect(IntPtr _this,IntPtr LensEffectEmitterClass);
/// <summary>Spawn a camera lens effect (e.g. blood).</summary>
public  void ClientSpawnCameraLensEffect(TSubclassOf<AEmitterCameraLensEffectBase>  LensEffectEmitterClass)
{
	CheckIsValid();
	ClientSpawnCameraLensEffect(_this.Get(),LensEffectEmitterClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetViewTarget(IntPtr _this,IntPtr A,ref FViewTargetTransitionParams TransitionParams);
/// <summary>
/// Set the view target
/// @param A - new actor to set as view target
/// @param TransitionParams - parameters to use for controlling the transition
/// </summary>
public  void ClientSetViewTarget(AActor A,FViewTargetTransitionParams TransitionParams)
{
	CheckIsValid();
	ClientSetViewTarget(_this.Get(),A,ref TransitionParams);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetHUD(IntPtr _this);
/// <summary>Gets the HUD currently being used by this player controller</summary>
public  AHUD GetHUD()
{
	CheckIsValid();
	IntPtr ___ret = GetHUD(_this.Get());
	if(___ret==IntPtr.Zero) return null; AHUD ___ret2= new AHUD(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetViewportSize(IntPtr _this,out int SizeX,out int SizeY);
/// <summary>Helper to get the size of the HUD canvas for this player controller.  Returns 0 if there is no HUD</summary>
public  void GetViewportSize(out int SizeX,out int SizeY)
{
	CheckIsValid();
	GetViewportSize(_this.Get(),out SizeX,out SizeY);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetHUD(IntPtr _this,IntPtr NewHUDClass);
/// <summary>Set the client's class of HUD and spawns a new instance of it. If there was already a HUD active, it is destroyed.</summary>
public  void ClientSetHUD(TSubclassOf<AHUD>  NewHUDClass)
{
	CheckIsValid();
	ClientSetHUD(_this.Get(),NewHUDClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetForceMipLevelsToBeResident(IntPtr _this,IntPtr Material,float ForceDuration,int CinematicTextureGroups);
/// <summary>
/// Forces the streaming system to disregard the normal logic for the specified duration and
/// instead always load all mip-levels for all textures used by the specified material.
/// @param Material              - The material whose textures should be forced into memory.
/// @param ForceDuration - Number of seconds to keep all mip-levels in memory, disregarding the normal priority logic.
/// @param CinematicTextureGroups        - Bitfield indicating which texture groups that use extra high-resolution mips
/// </summary>
public  void ClientSetForceMipLevelsToBeResident(UMaterialInterface Material,float ForceDuration,int CinematicTextureGroups)
{
	CheckIsValid();
	ClientSetForceMipLevelsToBeResident(_this.Get(),Material,ForceDuration,CinematicTextureGroups);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetCinematicMode(IntPtr _this,int bInCinematicMode,int bAffectsMovement,int bAffectsTurning,int bAffectsHUD);
/// <summary>Called by the server to synchronize cinematic transitions with the client</summary>
public  void ClientSetCinematicMode(bool bInCinematicMode,bool bAffectsMovement,bool bAffectsTurning,bool bAffectsHUD)
{
	CheckIsValid();
	ClientSetCinematicMode(_this.Get(),bInCinematicMode?1:0,bAffectsMovement?1:0,bAffectsTurning?1:0,bAffectsHUD?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetCameraMode(IntPtr _this,string NewCamMode);
/// <summary>
/// Replicated function to set camera style on client
/// @param       NewCamMode, name defining the new camera mode
/// </summary>
public  void ClientSetCameraMode(string NewCamMode)
{
	CheckIsValid();
	ClientSetCameraMode(_this.Get(),NewCamMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetCameraFade(IntPtr _this,int bEnableFading,ref FColor FadeColor,ref FVector2D FadeAlpha,float FadeTime,int bFadeAudio);
/// <summary>
/// Tell client to fade camera
/// @Param bEnableFading - true if we should apply FadeColor/FadeAmount to the screen
/// @Param FadeColor - Color to fade to
/// @Param FadeAlpha - Amount of fading to apply
/// @Param FadeTime - length of time for fade to occur over
/// @Param bFadeAudio - true to apply fading of audio alongside the video
/// </summary>
public  void ClientSetCameraFade(bool bEnableFading,FColor FadeColor,FVector2D FadeAlpha,float FadeTime,bool bFadeAudio)
{
	CheckIsValid();
	ClientSetCameraFade(_this.Get(),bEnableFading?1:0,ref FadeColor,ref FadeAlpha,FadeTime,bFadeAudio?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetBlockOnAsyncLoading(IntPtr _this);
/// <summary>
/// Tells the client to block until all pending level streaming actions are complete.
/// Happens at the end of the tick primarily used to force update the client ASAP at join time.
/// </summary>
public  void ClientSetBlockOnAsyncLoading()
{
	CheckIsValid();
	ClientSetBlockOnAsyncLoading(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientRestart(IntPtr _this,IntPtr NewPawn);
/// <summary>Tell client to restart the level</summary>
public  void ClientRestart(APawn NewPawn)
{
	CheckIsValid();
	ClientRestart(_this.Get(),NewPawn);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientReset(IntPtr _this);
/// <summary>Tell client to reset the PlayerController</summary>
public  void ClientReset()
{
	CheckIsValid();
	ClientReset(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientPrestreamTextures(IntPtr _this,IntPtr ForcedActor,float ForceDuration,int bEnableStreaming,int CinematicTextureGroups);
/// <summary>
/// Forces the streaming system to disregard the normal logic for the specified duration and
/// instead always load all mip-levels for all textures used by the specified actor.
/// @param ForcedActor           - The actor whose textures should be forced into memory.
/// @param ForceDuration         - Number of seconds to keep all mip-levels in memory, disregarding the normal priority logic.
/// @param bEnableStreaming      - Whether to start (true) or stop (false) streaming
/// @param CinematicTextureGroups        - Bitfield indicating which texture groups that use extra high-resolution mips
/// </summary>
public  void ClientPrestreamTextures(AActor ForcedActor,float ForceDuration,bool bEnableStreaming,int CinematicTextureGroups)
{
	CheckIsValid();
	ClientPrestreamTextures(_this.Get(),ForcedActor,ForceDuration,bEnableStreaming?1:0,CinematicTextureGroups);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientPrepareMapChange(IntPtr _this,string LevelName,int bFirst,int bLast);
/// <summary>
/// Asynchronously loads the given level in preparation for a streaming map transition.
/// the server sends one function per level name since dynamic arrays can't be replicated
/// @param LevelNames - the names of the level packages to load. LevelNames[0] will be the new persistent (primary) level
/// @param bFirst - whether this is the first item in the list (so clear the list first)
/// @param bLast - whether this is the last item in the list (so start preparing the change after receiving it)
/// </summary>
public  void ClientPrepareMapChange(string LevelName,bool bFirst,bool bLast)
{
	CheckIsValid();
	ClientPrepareMapChange(_this.Get(),LevelName,bFirst?1:0,bLast?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientPlaySoundAtLocation(IntPtr _this,IntPtr Sound,ref FVector Location,float VolumeMultiplier,float PitchMultiplier);
/// <summary>
/// Play sound client-side at the specified location
/// @param Sound - Sound to play
/// @param Location - Location to play the sound at
/// @param VolumeMultiplier - Volume multiplier to apply to the sound
/// @param PitchMultiplier - Pitch multiplier to apply to the sound
/// </summary>
public  void ClientPlaySoundAtLocation(USoundBase Sound,FVector Location,float VolumeMultiplier,float PitchMultiplier)
{
	CheckIsValid();
	ClientPlaySoundAtLocation(_this.Get(),Sound,ref Location,VolumeMultiplier,PitchMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientPlaySound(IntPtr _this,IntPtr Sound,float VolumeMultiplier,float PitchMultiplier);
/// <summary>
/// Play sound client-side (so only the client will hear it)
/// @param Sound - Sound to play
/// @param VolumeMultiplier - Volume multiplier to apply to the sound
/// @param PitchMultiplier - Pitch multiplier to apply to the sound
/// </summary>
public  void ClientPlaySound(USoundBase Sound,float VolumeMultiplier,float PitchMultiplier)
{
	CheckIsValid();
	ClientPlaySound(_this.Get(),Sound,VolumeMultiplier,PitchMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientPlayCameraShake(IntPtr _this,IntPtr Shake,float Scale,int PlaySpace,ref FRotator UserPlaySpaceRot);
/// <summary>
/// Play Camera Shake
/// @param Shake - Camera shake animation to play
/// @param Scale - Scalar defining how "intense" to play the anim
/// @param PlaySpace - Which coordinate system to play the shake in (used for CameraAnims within the shake).
/// @param UserPlaySpaceRot - Matrix used when PlaySpace = CAPS_UserDefined
/// </summary>
public  void ClientPlayCameraShake(TSubclassOf<UCameraShake>  Shake,float Scale=1.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator))
{
	CheckIsValid();
	ClientPlayCameraShake(_this.Get(),Shake.NativeClass,Scale,(int)PlaySpace,ref UserPlaySpaceRot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientPlayCameraAnim(IntPtr _this,IntPtr AnimToPlay,float Scale,float Rate,float BlendInTime,float BlendOutTime,int bLoop,int bRandomStartTime,int Space,ref FRotator CustomPlaySpace);
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
public  void ClientPlayCameraAnim(UCameraAnim AnimToPlay,float Scale=1.000000f,float Rate=1.000000f,float BlendInTime=0.000000f,float BlendOutTime=0.000000f,bool bLoop=false,bool bRandomStartTime=false,ECameraAnimPlaySpace Space=ECameraAnimPlaySpace.CameraLocal,FRotator CustomPlaySpace=default(FRotator))
{
	CheckIsValid();
	ClientPlayCameraAnim(_this.Get(),AnimToPlay,Scale,Rate,BlendInTime,BlendOutTime,bLoop?1:0,bRandomStartTime?1:0,(int)Space,ref CustomPlaySpace);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientMessage(IntPtr _this,string S,string Type,float MsgLifeTime);
/// <summary>
/// Outputs a message to HUD
/// @param S - message to display
/// @param Type - @todo document
/// @param MsgLifeTime - Optional length of time to display 0 = default time
/// </summary>
public  void ClientMessage(string S,string Type,float MsgLifeTime)
{
	CheckIsValid();
	ClientMessage(_this.Get(),S,Type,MsgLifeTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientIgnoreMoveInput(IntPtr _this,int bIgnore);
/// <summary>calls IgnoreMoveInput on client</summary>
public  void ClientIgnoreMoveInput(bool bIgnore)
{
	CheckIsValid();
	ClientIgnoreMoveInput(_this.Get(),bIgnore?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientIgnoreLookInput(IntPtr _this,int bIgnore);
/// <summary>calls IgnoreLookInput on client</summary>
public  void ClientIgnoreLookInput(bool bIgnore)
{
	CheckIsValid();
	ClientIgnoreLookInput(_this.Get(),bIgnore?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientGotoState(IntPtr _this,string NewState);
/// <summary>
/// Server uses this to force client into NewState .
/// @Note ALL STATE NAMES NEED TO BE DEFINED IN name table in UnrealNames.h to be correctly replicated (so they are mapped to the same thing on client and server).
/// </summary>
public  void ClientGotoState(string NewState)
{
	CheckIsValid();
	ClientGotoState(_this.Get(),NewState);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientGameEnded(IntPtr _this,IntPtr EndGameFocus,int bIsWinner);
/// <summary>
/// Replicated function called by GameHasEnded().
/// @param       EndGameFocus - actor to view with camera
/// @param       bIsWinner - true if this controller is on winning team
/// </summary>
public  void ClientGameEnded(AActor EndGameFocus,bool bIsWinner)
{
	CheckIsValid();
	ClientGameEnded(_this.Get(),EndGameFocus,bIsWinner?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientForceGarbageCollection(IntPtr _this);
/// <summary>Forces GC at the end of the tick on the client</summary>
public  void ClientForceGarbageCollection()
{
	CheckIsValid();
	ClientForceGarbageCollection(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientFlushLevelStreaming(IntPtr _this);
/// <summary>
/// Tells the client to block until all pending level streaming actions are complete
/// happens at the end of the tick
/// primarily used to force update the client ASAP at join time
/// </summary>
public  void ClientFlushLevelStreaming()
{
	CheckIsValid();
	ClientFlushLevelStreaming(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCommitMapChange(IntPtr _this);
/// <summary>Actually performs the level transition prepared by PrepareMapChange().</summary>
public  void ClientCommitMapChange()
{
	CheckIsValid();
	ClientCommitMapChange(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCapBandwidth(IntPtr _this,int Cap);
/// <summary>Set CurrentNetSpeed to the lower of its current value and Cap.</summary>
public  void ClientCapBandwidth(int Cap)
{
	CheckIsValid();
	ClientCapBandwidth(_this.Get(),Cap);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCancelPendingMapChange(IntPtr _this);
/// <summary>Tells client to cancel any pending map change.</summary>
public  void ClientCancelPendingMapChange()
{
	CheckIsValid();
	ClientCancelPendingMapChange(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAddTextureStreamingLoc(IntPtr _this,ref FVector InLoc,float Duration,int bOverrideLocation);
/// <summary>Adds a location to the texture streaming system for the specified duration.</summary>
public  void ClientAddTextureStreamingLoc(FVector InLoc,float Duration,bool bOverrideLocation)
{
	CheckIsValid();
	ClientAddTextureStreamingLoc(_this.Get(),ref InLoc,Duration,bOverrideLocation?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SendToConsole(IntPtr _this,string Command);
/// <summary>Sends a command to the console to execute if not shipping version</summary>
public  void SendToConsole(string Command)
{
	CheckIsValid();
	SendToConsole(_this.Get(),Command);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ConsoleKey(IntPtr _this,ref FKey Key);
/// <summary>Console control commands, useful when remote debugging so you can't touch the console the normal way</summary>
public  void ConsoleKey(FKey Key)
{
	CheckIsValid();
	ConsoleKey(_this.Get(),ref Key);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientUnmutePlayer(IntPtr _this,ref FUniqueNetIdRepl PlayerId);
/// <summary>
/// Tell the client to unmute a player for this controller
/// @param PlayerId player id to unmute
/// </summary>
public  void ClientUnmutePlayer(FUniqueNetIdRepl PlayerId)
{
	CheckIsValid();
	ClientUnmutePlayer(_this.Get(),ref PlayerId);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientMutePlayer(IntPtr _this,ref FUniqueNetIdRepl PlayerId);
/// <summary>
/// Tell the client to mute a player for this controller
/// @param PlayerId player id to mute
/// </summary>
public  void ClientMutePlayer(FUniqueNetIdRepl PlayerId)
{
	CheckIsValid();
	ClientMutePlayer(_this.Get(),ref PlayerId);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerUnmutePlayer(IntPtr _this,ref FUniqueNetIdRepl PlayerId);
/// <summary>
/// Tell the server to unmute a player for this controller
/// @param PlayerId player id to unmute
/// </summary>
public  void ServerUnmutePlayer(FUniqueNetIdRepl PlayerId)
{
	CheckIsValid();
	ServerUnmutePlayer(_this.Get(),ref PlayerId);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMutePlayer(IntPtr _this,ref FUniqueNetIdRepl PlayerId);
/// <summary>
/// Tell the server to mute a player for this controller
/// @param PlayerId player id to mute
/// </summary>
public  void ServerMutePlayer(FUniqueNetIdRepl PlayerId)
{
	CheckIsValid();
	ServerMutePlayer(_this.Get(),ref PlayerId);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientVoiceHandshakeComplete(IntPtr _this);
/// <summary>
/// Tells the client that the server has all the information it needs and that it
/// is ok to start sending voice packets. The server will already send voice packets
/// when this function is called, since it is set server side and then forwarded
/// NOTE: This is done as an RPC instead of variable replication because ordering matters
/// </summary>
public  void ClientVoiceHandshakeComplete()
{
	CheckIsValid();
	ClientVoiceHandshakeComplete(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleSpeaking(IntPtr _this,int bInSpeaking);
/// <summary>
/// Toggle voice chat on and off
/// @param bSpeaking enable or disable voice chat
/// </summary>
public  void ToggleSpeaking(bool bInSpeaking)
{
	CheckIsValid();
	ToggleSpeaking(_this.Get(),bInSpeaking?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientEnableNetworkVoice(IntPtr _this,int bEnable);
/// <summary>
/// Tell the client to enable or disable voice chat (not muting)
/// @param bEnable enable or disable voice chat
/// </summary>
public  void ClientEnableNetworkVoice(bool bEnable)
{
	CheckIsValid();
	ClientEnableNetworkVoice(_this.Get(),bEnable?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StartFire(IntPtr _this,int FireModeNum);
/// <summary>Fire the player's currently selected weapon with the optional firemode.</summary>
public  void StartFire(byte FireModeNum=0)
{
	CheckIsValid();
	StartFire(_this.Get(),FireModeNum);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ProjectWorldLocationToScreen(IntPtr _this,ref FVector WorldLocation,out FVector2D ScreenLocation);
/// <summary>
/// Convert a World Space 3D position into a 2D Screen Space position.
/// @return true if the world coordinate was successfully projected to the screen.
/// </summary>
public  bool ProjectWorldLocationToScreen(FVector WorldLocation,out FVector2D ScreenLocation)
{
	CheckIsValid();
	int ___ret = ProjectWorldLocationToScreen(_this.Get(),ref WorldLocation,out ScreenLocation);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DeprojectScreenPositionToWorld(IntPtr _this,float ScreenX,float ScreenY,out FVector WorldLocation,out FVector WorldDirection);
/// <summary>Convert current mouse 2D position to World Space 3D position and direction. Returns false if unable to determine value. *</summary>
public  bool DeprojectScreenPositionToWorld(float ScreenX,float ScreenY,out FVector WorldLocation,out FVector WorldDirection)
{
	CheckIsValid();
	int ___ret = DeprojectScreenPositionToWorld(_this.Get(),ScreenX,ScreenY,out WorldLocation,out WorldDirection);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DeprojectMousePositionToWorld(IntPtr _this,out FVector WorldLocation,out FVector WorldDirection);
/// <summary>Convert current mouse 2D position to World Space 3D position and direction. Returns false if unable to determine value. *</summary>
public  bool DeprojectMousePositionToWorld(out FVector WorldLocation,out FVector WorldDirection)
{
	CheckIsValid();
	int ___ret = DeprojectMousePositionToWorld(_this.Get(),out WorldLocation,out WorldDirection);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetHitResultUnderFingerForObjects(IntPtr _this,int FingerIndex,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,out FHitResult HitResult);
public  bool GetHitResultUnderFingerForObjects(ETouchIndex FingerIndex,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,out FHitResult HitResult)
{
	CheckIsValid();
	int ___ret = GetHitResultUnderFingerForObjects(_this.Get(),(int)FingerIndex,ObjectTypes,bTraceComplex?1:0,out HitResult);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetHitResultUnderFingerByChannel(IntPtr _this,int FingerIndex,int TraceChannel,int bTraceComplex,out FHitResult HitResult);
public  bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex,ETraceTypeQuery TraceChannel,bool bTraceComplex,out FHitResult HitResult)
{
	CheckIsValid();
	int ___ret = GetHitResultUnderFingerByChannel(_this.Get(),(int)FingerIndex,(int)TraceChannel,bTraceComplex?1:0,out HitResult);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetHitResultUnderCursorForObjects(IntPtr _this,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,out FHitResult HitResult);
public  bool GetHitResultUnderCursorForObjects(EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,out FHitResult HitResult)
{
	CheckIsValid();
	int ___ret = GetHitResultUnderCursorForObjects(_this.Get(),ObjectTypes,bTraceComplex?1:0,out HitResult);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetHitResultUnderCursorByChannel(IntPtr _this,int TraceChannel,int bTraceComplex,out FHitResult HitResult);
public  bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel,bool bTraceComplex,out FHitResult HitResult)
{
	CheckIsValid();
	int ___ret = GetHitResultUnderCursorByChannel(_this.Get(),(int)TraceChannel,bTraceComplex?1:0,out HitResult);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SwitchLevel(IntPtr _this,string URL);
/// <summary>SwitchLevel to the given MapURL.</summary>
public  void SwitchLevel(string URL)
{
	CheckIsValid();
	SwitchLevel(_this.Get(),URL);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetName(IntPtr _this,string S);
/// <summary>Trys to set the player's name to the given name.</summary>
public  void SetName(string S)
{
	CheckIsValid();
	SetName(_this.Get(),S);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Pause(IntPtr _this);
/// <summary>Command to try to pause the game.</summary>
public  void Pause()
{
	CheckIsValid();
	Pause(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientRepObjRef(IntPtr _this,IntPtr Object);
/// <summary>Development RPC for testing object reference replication</summary>
public  void ClientRepObjRef(UObject Object)
{
	CheckIsValid();
	ClientRepObjRef(_this.Get(),Object);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientReturnToMainMenu(IntPtr _this,string ReturnReason);
/// <summary>Return the client to the main menu gracefully</summary>
public  void ClientReturnToMainMenu(string ReturnReason)
{
	CheckIsValid();
	ClientReturnToMainMenu(_this.Get(),ReturnReason);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LocalTravel(IntPtr _this,string URL);
/// <summary>Causes the client to travel to the given URL</summary>
public  void LocalTravel(string URL)
{
	CheckIsValid();
	LocalTravel(_this.Get(),URL);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RestartLevel(IntPtr _this);
/// <summary>Restarts the current level</summary>
public  void RestartLevel()
{
	CheckIsValid();
	RestartLevel(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FOV(IntPtr _this,float NewFOV);
/// <summary>Set the field of view to NewFOV</summary>
public  void FOV(float NewFOV)
{
	CheckIsValid();
	FOV(_this.Get(),NewFOV);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableCheats(IntPtr _this);
/// <summary>Enables cheats within the game</summary>
public  void EnableCheats()
{
	CheckIsValid();
	EnableCheats(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetSpectatorWaiting(IntPtr _this,int bWaiting);
/// <summary>Indicate that the Spectator is waiting to join/respawn.</summary>
public  void ClientSetSpectatorWaiting(bool bWaiting)
{
	CheckIsValid();
	ClientSetSpectatorWaiting(_this.Get(),bWaiting?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerSetSpectatorWaiting(IntPtr _this,int bWaiting);
/// <summary>Indicate that the Spectator is waiting to join/respawn.</summary>
public  void ServerSetSpectatorWaiting(bool bWaiting)
{
	CheckIsValid();
	ServerSetSpectatorWaiting(_this.Get(),bWaiting?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
