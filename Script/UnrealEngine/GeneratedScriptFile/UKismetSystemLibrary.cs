using System;
namespace UnrealEngine
{
	public partial class UKismetSystemLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Returns the command line that the process was launched with.</summary>
		public extern static FString GetCommandLine();
		/// <summary>Tells the engine what the user is doing for debug, analytics, etc.</summary>
		public extern static void SetUserActivity(FUserActivity UserActivity);
		/// <summary>
		/// Requests permission to send remote notifications to the user's device.
		/// (iOS only)
		/// </summary>
		public extern static void RegisterForRemoteNotifications();
		/// <summary>
		/// Returns the currency symbol associated with the device's locale
		/// @return the currency symbol associated with the device's locale
		/// </summary>
		public extern static FString GetLocalCurrencySymbol();
		/// <summary>
		/// Returns the currency code associated with the device's locale
		/// @return the currency code associated with the device's locale
		/// </summary>
		public extern static FString GetLocalCurrencyCode();
		/// <summary>
		/// Sets the state of the transition message rendered by the viewport. (The blue text displayed when the game is paused and so forth.)
		/// @param WorldContextObject    World context
		/// @param State                                 set true to suppress transition message
		/// </summary>
		public extern static void SetSuppressViewportTransitionMessage(UObject WorldContextObject,bool bState);
		/// <summary>Returns true if controller id assigned to a gamepad (Android only)</summary>
		public extern static bool IsControllerAssignedToGamepad(int ControllerId);
		/// <summary>* Resets the gamepad assignment to player controller id (Android only)</summary>
		public extern static void ResetGamepadAssignmentToController(int ControllerId);
		/// <summary>Resets the gamepad to player controller id assignments (Android only)</summary>
		public extern static void ResetGamepadAssignments();
		/// <summary>Returns true if system default handling of volume up and volume down buttons enabled (Android only)</summary>
		public extern static bool GetVolumeButtonsHandledBySystem();
		/// <summary>
		/// Allows or inhibits system default handling of volume up and volume down buttons (Android only)
		/// @param       bEnabled                                If true, allow Android to handle volume up and down events
		/// </summary>
		public extern static void SetVolumeButtonsHandledBySystem(bool bEnabled);
		/// <summary>
		/// Allows or inhibits screensaver
		/// @param       bAllowScreenSaver               If false, don't allow screensaver if possible, otherwise allow default behavior
		/// </summary>
		public extern static void ControlScreensaver(bool bAllowScreenSaver);
		/// <summary>
		/// Returns whether the player is logged in to the currently active online subsystem.
		/// @param Player Specific player's login status to get. May not be supported on all platforms. If null, defaults to the player with ControllerId 0.
		/// </summary>
		public extern static bool IsLoggedIn(APlayerController SpecificPlayer);
		/// <summary>
		/// Displays the built-in achievements GUI (iOS and Android only; this function may be renamed or moved in a future release)
		/// @param SpecificPlayer Specific player's achievements to show. May not be supported on all platforms. If null, defaults to the player with ControllerId 0
		/// </summary>
		public extern static void ShowPlatformSpecificAchievementsScreen(APlayerController SpecificPlayer);
		/// <summary>Displays the built-in leaderboard GUI (iOS and Android only; this function may be renamed or moved in a future release)</summary>
		public extern static void ShowPlatformSpecificLeaderboardScreen(FString CategoryName);
		/// <summary>
		/// Shows the loaded interstitial ad (loaded with LoadInterstitialAd)
		/// (Android only)
		/// </summary>
		public extern static void ShowInterstitialAd();
		/// <summary>
		/// Returns true if the requested interstitial ad has been successfully requested (false if load request fails)
		/// (Android only)
		/// </summary>
		public extern static bool IsInterstitialAdRequested();
		/// <summary>
		/// Returns true if the requested interstitial ad is loaded and ready
		/// (Android only)
		/// </summary>
		public extern static bool IsInterstitialAdAvailable();
		/// <summary>
		/// Will load a fullscreen interstitial AdMob ad. Call this before using ShowInterstitialAd
		/// (Android only)
		/// @param AdIdIndex The index of the ID to select for the ad to show
		/// </summary>
		public extern static void LoadInterstitialAd(int AdIdIndex);
		/// <summary>
		/// Forces closed any displayed ad. Can lead to loss of revenue
		/// (iOS and Android only)
		/// </summary>
		public extern static void ForceCloseAdBanner();
		/// <summary>
		/// Hides the ad banner (iAd on iOS, or AdMob on Android). Will force close the ad if it's open
		/// (iOS and Android only)
		/// </summary>
		public extern static void HideAdBanner();
		/// <summary>Retrieves the total number of Ad IDs that can be selected between</summary>
		public extern static int GetAdIDCount();
		/// <summary>
		/// Will show an ad banner (iAd on iOS, or AdMob on Android) on the top or bottom of screen, on top of the GL view (doesn't resize the view)
		/// (iOS and Android only)
		/// @param AdIdIndex The index of the ID to select for the ad to show
		/// @param bShowOnBottomOfScreen If true, the iAd will be shown at the bottom of the screen, top otherwise
		/// </summary>
		public extern static void ShowAdBanner(int AdIdIndex,bool bShowOnBottomOfScreen);
		/// <summary>
		/// Deletes all unreferenced objects, keeping only referenced objects (this command will be queued and happen at the end of the frame)
		/// Note: This can be a slow operation, and should only be performed where a hitch would be acceptable
		/// </summary>
		public extern static void CollectGarbage();
		public extern static bool CanLaunchURL(FString URL);
		/// <summary>Opens the specified URL in the platform's web browser of choice</summary>
		public extern static void LaunchURL(FString URL);
		/// <summary>
		/// Gets the smallest Y resolution we want to support in the 3D view, clamped within reasons
		/// @return value in pixels
		/// </summary>
		public extern static int GetMinYResolutionFor3DView();
		/// <summary>
		/// Gets the smallest Y resolution we want to support in the UI, clamped within reasons
		/// @return value in pixels
		/// </summary>
		public extern static int GetMinYResolutionForUI();
		/// <summary>
		/// Get the clamped state of r.MaterialQualityLevel, see console variable help (allows for scalability, cannot be used in construction scripts)
		/// 0: low
		/// 1: high
		/// 2: medium
		/// </summary>
		public extern static int GetRenderingMaterialQualityLevel();
		/// <summary>
		/// Get the clamped state of r.DetailMode, see console variable help (allows for scalability, cannot be used in construction scripts)
		/// 0: low, show only object with DetailMode low or higher
		/// 1: medium, show all object with DetailMode medium or higher
		/// 2: high, show all objects
		/// </summary>
		public extern static int GetRenderingDetailMode();
		/// <summary>Get bounds</summary>
		public extern static void GetComponentBounds(USceneComponent Component,out FVector Origin,out FVector BoxExtent,out float SphereRadius);
		/// <summary>Mark as modified.</summary>
		public extern static void CreateCopyForUndoBuffer(UObject ObjectToModify);
		public extern static FDebugFloatHistory AddFloatHistorySample(float Value,FDebugFloatHistory FloatHistory);
		/// <summary>Draws a 2D Histogram of size 'DrawSize' based FDebugFloatHistory struct, using DrawLocation for the location in the world, rotation will face camera of first player.</summary>
		public extern static void DrawDebugFloatHistoryLocation(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FVector DrawLocation,FVector2D DrawSize,FLinearColor DrawColor=default(FLinearColor),float Duration=0.000000f);
		/// <summary>Draws a 2D Histogram of size 'DrawSize' based FDebugFloatHistory struct, using DrawTransform for the position in the world.</summary>
		public extern static void DrawDebugFloatHistoryTransform(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FTransform DrawTransform,FVector2D DrawSize,FLinearColor DrawColor=default(FLinearColor),float Duration=0.000000f);
		/// <summary>Draw a debug camera shape.</summary>
		public extern static void DrawDebugCamera(ACameraActor CameraActor,FLinearColor CameraColor=default(FLinearColor),float Duration=0.000000f);
		/// <summary>Draws a debug frustum.</summary>
		public extern static void DrawDebugFrustum(UObject WorldContextObject,FTransform FrustumTransform,FLinearColor FrustumColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>
		/// Flush all persistent debug lines and shapes.
		/// @param WorldContext  World context
		/// </summary>
		public extern static void FlushPersistentDebugLines(UObject WorldContextObject);
		/// <summary>Draws a debug plane.</summary>
		public extern static void DrawDebugPlane(UObject WorldContextObject,FPlane PlaneCoordinates,FVector Location,float Size,FLinearColor PlaneColor=default(FLinearColor),float Duration=0.000000f);
		/// <summary>
		/// Removes all debug strings.
		/// @param WorldContext  World context
		/// </summary>
		public extern static void FlushDebugStrings(UObject WorldContextObject);
		/// <summary>Draw a debug string at a 3d world location.</summary>
		public extern static void DrawDebugString(UObject WorldContextObject,FVector TextLocation,FString Text,AActor TestBaseActor,FLinearColor TextColor=default(FLinearColor),float Duration=0.000000f);
		/// <summary>Draw a debug capsule</summary>
		public extern static void DrawDebugCapsule(UObject WorldContextObject,FVector Center,float HalfHeight,float Radius,FRotator Rotation,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>
		/// Draw a debug cone
		/// Angles are specified in degrees
		/// </summary>
		public extern static void DrawDebugConeInDegrees(UObject WorldContextObject,FVector Origin,FVector Direction,float Length=100.000000f,float AngleWidth=45.000000f,float AngleHeight=45.000000f,int NumSides=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>Draw a debug cylinder</summary>
		public extern static void DrawDebugCylinder(UObject WorldContextObject,FVector Start,FVector End,float Radius=100.000000f,int Segments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>Draw a debug sphere</summary>
		public extern static void DrawDebugSphere(UObject WorldContextObject,FVector Center,float Radius=100.000000f,int Segments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>Draw a debug coordinate system.</summary>
		public extern static void DrawDebugCoordinateSystem(UObject WorldContextObject,FVector AxisLoc,FRotator AxisRot,float Scale=1.000000f,float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>Draw a debug box</summary>
		public extern static void DrawDebugBox(UObject WorldContextObject,FVector Center,FVector Extent,FLinearColor LineColor,FRotator Rotation,float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>Draw directional arrow, pointing from LineStart to LineEnd.</summary>
		public extern static void DrawDebugArrow(UObject WorldContextObject,FVector LineStart,FVector LineEnd,float ArrowSize,FLinearColor LineColor,float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>Draw a debug point</summary>
		public extern static void DrawDebugPoint(UObject WorldContextObject,FVector Position,float Size,FLinearColor PointColor,float Duration=0.000000f);
		/// <summary>Draw a debug circle!</summary>
		public extern static void DrawDebugCircle(UObject WorldContextObject,FVector Center,float Radius,int NumSegments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f,FVector YAxis=default(FVector),FVector ZAxis=default(FVector),bool bDrawAxis=false);
		/// <summary>Draw a debug line</summary>
		public extern static void DrawDebugLine(UObject WorldContextObject,FVector LineStart,FVector LineEnd,FLinearColor LineColor,float Duration=0.000000f,float Thickness=0.000000f);
		/// <summary>Set a custom structure property by name</summary>
		public extern static void SetStructurePropertyByName(UObject Object,FName PropertyName,FGenericStruct Value);
		/// <summary>Set a CollisionProfileName property by name</summary>
		public extern static void SetCollisionProfileNameProperty(UObject Object,FName PropertyName,FCollisionProfileName Value);
		/// <summary>Set a TRANSFORM property by name</summary>
		public extern static void SetTransformPropertyByName(UObject Object,FName PropertyName,FTransform Value);
		/// <summary>Set a LINEAR COLOR property by name</summary>
		public extern static void SetLinearColorPropertyByName(UObject Object,FName PropertyName,FLinearColor Value);
		/// <summary>Set a ROTATOR property by name</summary>
		public extern static void SetRotatorPropertyByName(UObject Object,FName PropertyName,FRotator Value);
		/// <summary>Set a VECTOR property by name</summary>
		public extern static void SetVectorPropertyByName(UObject Object,FName PropertyName,FVector Value);
		/// <summary>Set a TEXT property by name</summary>
		public extern static void SetTextPropertyByName(UObject Object,FName PropertyName,FText Value);
		/// <summary>Set a STRING property by name</summary>
		public extern static void SetStringPropertyByName(UObject Object,FName PropertyName,FString Value);
		/// <summary>Set a NAME property by name</summary>
		public extern static void SetNamePropertyByName(UObject Object,FName PropertyName,FName Value);
		/// <summary>Set a CLASS property by name</summary>
		public extern static void SetClassPropertyByName(UObject Object,FName PropertyName,TSubclassOf<UObject>  Value);
		/// <summary>Set an OBJECT property by name</summary>
		public extern static void SetObjectPropertyByName(UObject Object,FName PropertyName,UObject Value);
		/// <summary>Set a bool property by name</summary>
		public extern static void SetBoolPropertyByName(UObject Object,FName PropertyName,bool Value);
		/// <summary>Set a float property by name</summary>
		public extern static void SetFloatPropertyByName(UObject Object,FName PropertyName,float Value);
		/// <summary>Set an uint8 or enum property by name</summary>
		public extern static void SetBytePropertyByName(UObject Object,FName PropertyName,byte Value);
		/// <summary>Set an int32 property by name</summary>
		public extern static void SetIntPropertyByName(UObject Object,FName PropertyName,int Value);
		/// <summary>
		/// Returns time until the timer will next execute its delegate.
		/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
		/// @return                              How long is remaining in the current iteration of the timer.
		/// </summary>
		public extern static float K2_GetTimerRemainingTime(UObject Object,FString FunctionName);
		/// <summary>
		/// Returns elapsed time for the given delegate (time since current countdown iteration began).
		/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
		/// @return                              How long has elapsed since the current iteration of the timer began.
		/// </summary>
		public extern static float K2_GetTimerElapsedTime(UObject Object,FString FunctionName);
		/// <summary>
		/// Returns true is a timer for the given delegate exists, false otherwise.
		/// @param Object         Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName   Delegate function name. Can be a K2 function or a Custom Event.
		/// @return                               True if the timer exists.
		/// </summary>
		public extern static bool K2_TimerExists(UObject Object,FString FunctionName);
		/// <summary>
		/// Returns true if a timer exists and is paused for the given delegate, false otherwise.
		/// @param Object         Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName   Delegate function name. Can be a K2 function or a Custom Event.
		/// @return                               True if the timer exists and is paused.
		/// </summary>
		public extern static bool K2_IsTimerPaused(UObject Object,FString FunctionName);
		/// <summary>
		/// Returns true if a timer exists and is active for the given delegate, false otherwise.
		/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
		/// @return                              True if the timer exists and is active.
		/// </summary>
		public extern static bool K2_IsTimerActive(UObject Object,FString FunctionName);
		/// <summary>
		/// Resumes a paused timer from its current elapsed time.
		/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
		/// </summary>
		public extern static void K2_UnPauseTimer(UObject Object,FString FunctionName);
		/// <summary>
		/// Pauses a set timer at its current elapsed time.
		/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
		/// </summary>
		public extern static void K2_PauseTimer(UObject Object,FString FunctionName);
		/// <summary>
		/// Clears a set timer.
		/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
		/// </summary>
		public extern static void K2_ClearTimer(UObject Object,FString FunctionName);
		/// <summary>
		/// Set a timer to execute delegate. Setting an existing timer will reset that timer with updated parameters.
		/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
		/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
		/// @param Time                  How long to wait before executing the delegate, in seconds. Setting a timer to <= 0 seconds will clear it if it is set.
		/// @param bLooping              true to keep executing the delegate every Time seconds, false to execute delegate only once.
		/// @return                              The timer handle to pass to other timer functions to manipulate this timer.
		/// </summary>
		public extern static FTimerHandle K2_SetTimer(UObject Object,FString FunctionName,float Time,bool bLooping);
		/// <summary>
		/// Returns time until the timer will next execute its handle.
		/// @param Handle                The handle of the timer to time remaining of.
		/// @return                              How long is remaining in the current iteration of the timer.
		/// </summary>
		public extern static float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject,FTimerHandle Handle);
		/// <summary>
		/// Returns elapsed time for the given handle (time since current countdown iteration began).
		/// @param Handle                The handle of the timer to get the elapsed time of.
		/// @return                              How long has elapsed since the current iteration of the timer began.
		/// </summary>
		public extern static float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject,FTimerHandle Handle);
		/// <summary>
		/// Returns true is a timer for the given handle exists, false otherwise.
		/// @param Handle                The handle to check whether it exists.
		/// @return                              True if the timer exists.
		/// </summary>
		public extern static bool K2_TimerExistsHandle(UObject WorldContextObject,FTimerHandle Handle);
		/// <summary>
		/// Returns true if a timer exists and is paused for the given handle, false otherwise.
		/// @param Handle                The handle of the timer to check whether it is paused.
		/// @return                              True if the timer exists and is paused.
		/// </summary>
		public extern static bool K2_IsTimerPausedHandle(UObject WorldContextObject,FTimerHandle Handle);
		/// <summary>
		/// Returns true if a timer exists and is active for the given handle, false otherwise.
		/// @param Handle                The handle of the timer to check whether it is active.
		/// @return                              True if the timer exists and is active.
		/// </summary>
		public extern static bool K2_IsTimerActiveHandle(UObject WorldContextObject,FTimerHandle Handle);
		/// <summary>
		/// Resumes a paused timer from its current elapsed time.
		/// @param Handle                The handle of the timer to unpause.
		/// </summary>
		public extern static void K2_UnPauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle);
		/// <summary>
		/// Pauses a set timer at its current elapsed time.
		/// @param Handle                The handle of the timer to pause.
		/// </summary>
		public extern static void K2_PauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle);
		/// <summary>
		/// Clears a set timer.
		/// @param Handle                The handle of the timer to clear.
		/// </summary>
		public extern static void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject,out FTimerHandle Handle);
		/// <summary>
		/// Returns whether the timer handle is valid. This does not indicate that there is an active timer that this handle references, but rather that it once referenced a valid timer.
		/// @param Handle                The handle of the timer to check validity of.
		/// @return                              Return the invalidated timer handle for convenience.
		/// </summary>
		public extern static FTimerHandle K2_InvalidateTimerHandle(out FTimerHandle Handle);
		/// <summary>
		/// Returns whether the timer handle is valid. This does not indicate that there is an active timer that this handle references, but rather that it once referenced a valid timer.
		/// @param Handle                The handle of the timer to check validity of.
		/// @return                              Whether the timer handle is valid.
		/// </summary>
		public extern static bool K2_IsValidTimerHandle(FTimerHandle Handle);
		/// <summary>
		/// * Interpolate a component to the specified relative location and rotation over the course of OverTime seconds.
		/// * @param Component                                             Component to interpolate
		/// * @param TargetRelativeLocation                Relative target location
		/// * @param TargetRelativeRotation                Relative target rotation
		/// * @param bEaseOut                                              if true we will ease out (ie end slowly) during interpolation
		/// * @param bEaseIn                                               if true we will ease in (ie start slowly) during interpolation
		/// * @param OverTime                                              duration of interpolation
		/// * @param bForceShortestRotationPath    if true we will always use the shortest path for rotation
		/// * @param MoveAction                                    required movement behavior @see EMoveComponentAction
		/// * @param LatentInfo                                    The latent action
		/// </summary>
		public extern static void MoveComponentTo(USceneComponent Component,FVector TargetRelativeLocation,FRotator TargetRelativeRotation,bool bEaseOut,bool bEaseIn,float OverTime,bool bForceShortestRotationPath,EMoveComponentAction MoveAction,FLatentActionInfo LatentInfo);
		/// <summary>
		/// Perform a latent action with a retriggerable delay (specified in seconds).  Calling again while it is counting down will reset the countdown to Duration.
		/// @param WorldContext  World context.
		/// @param Duration              length of delay (in seconds).
		/// @param LatentInfo    The latent action.
		/// </summary>
		public extern static void RetriggerableDelay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo);
		/// <summary>
		/// Perform a latent action with a delay (specified in seconds).  Calling again while it is counting down will be ignored.
		/// @param WorldContext  World context.
		/// @param Duration              length of delay (in seconds).
		/// @param LatentInfo    The latent action.
		/// </summary>
		public extern static void Delay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo);
		/// <summary>
		/// Exit the current game
		/// @param       SpecificPlayer  The specific player to quit the game. If not specified, player 0 will quit.
		/// </summary>
		public extern static void QuitGame(UObject WorldContextObject,APlayerController SpecificPlayer,EQuitPreference QuitPreference);
		/// <summary>
		/// Executes a console command, optionally on a specific controller
		/// @param       Command                 Command to send to the console
		/// @param       SpecificPlayer  If specified, the console command will be routed through the specified player
		/// </summary>
		public extern static void ExecuteConsoleCommand(UObject WorldContextObject,FString Command,APlayerController SpecificPlayer);
		/// <summary>Sets the game window title</summary>
		public extern static void SetWindowTitle(FText Title);
		/// <summary>
		/// Prints a warning string to the log and the screen. Meant to be used as a way to inform the user that they misused the node.
		/// WARNING!! Don't change the signature of this function without fixing up all nodes using it in the compiler
		/// @param       InString                The string to log out
		/// </summary>
		public extern static void PrintWarning(FString InString);
		/// <summary>
		/// Prints text to the log, and optionally, to the screen
		/// If Print To Log is true, it will be visible in the Output Log window.  Otherwise it will be logged only as 'Verbose', so it generally won't show up.
		/// @param       InText                  The text to log out
		/// @param       bPrintToScreen  Whether or not to print the output to the screen
		/// @param       bPrintToLog             Whether or not to print the output to the log
		/// @param       bPrintToConsole Whether or not to print the output to the console
		/// @param       TextColor               Whether or not to print the output to the console
		/// @param       Duration                The display duration (if Print to Screen is True). Using negative number will result in loading the duration time from the config.
		/// </summary>
		public extern static void PrintText(UObject WorldContextObject,FText InText,bool bPrintToScreen=true,bool bPrintToLog=true,FLinearColor TextColor=default(FLinearColor),float Duration=2.000000f);
		/// <summary>
		/// Prints a string to the log, and optionally, to the screen
		/// If Print To Log is true, it will be visible in the Output Log window.  Otherwise it will be logged only as 'Verbose', so it generally won't show up.
		/// @param       InString                The string to log out
		/// @param       bPrintToScreen  Whether or not to print the output to the screen
		/// @param       bPrintToLog             Whether or not to print the output to the log
		/// @param       bPrintToConsole Whether or not to print the output to the console
		/// @param       TextColor               Whether or not to print the output to the console
		/// @param       Duration                The display duration (if Print to Screen is True). Using negative number will result in loading the duration time from the config.
		/// </summary>
		public extern static void PrintString(UObject WorldContextObject,FString InString,bool bPrintToScreen=true,bool bPrintToLog=true,FLinearColor TextColor=default(FLinearColor),float Duration=2.000000f);
		/// <summary>
		/// Creates a literal FText
		/// @param       Value   value to set the FText to
		/// @return      The literal FText
		/// </summary>
		public extern static FText MakeLiteralText(FText Value);
		/// <summary>
		/// Creates a literal string
		/// @param       Value   value to set the string to
		/// @return      The literal string
		/// </summary>
		public extern static FString MakeLiteralString(FString Value);
		/// <summary>
		/// Creates a literal byte
		/// @param       Value   value to set the byte to
		/// @return      The literal byte
		/// </summary>
		public extern static byte MakeLiteralByte(byte Value);
		/// <summary>
		/// Creates a literal name
		/// @param       Value   value to set the name to
		/// @return      The literal name
		/// </summary>
		public extern static FName MakeLiteralName(FName Value);
		/// <summary>
		/// Creates a literal bool
		/// @param       Value   value to set the bool to
		/// @return      The literal bool
		/// </summary>
		public extern static bool MakeLiteralBool(bool Value);
		/// <summary>
		/// Creates a literal float
		/// @param       Value   value to set the float to
		/// @return      The literal float
		/// </summary>
		public extern static float MakeLiteralFloat(float Value);
		/// <summary>
		/// Creates a literal integer
		/// @param       Value   value to set the integer to
		/// @return      The literal integer
		/// </summary>
		public extern static int MakeLiteralInt(int Value);
		/// <summary>Returns the platform specific unique device id</summary>
		public extern static FString GetDeviceId();
		/// <summary>Returns whether this is a build that is packaged for distribution</summary>
		public extern static bool IsPackagedForDistribution();
		/// <summary>Returns whether this game instance is stand alone (no networking).</summary>
		public extern static bool IsStandalone(UObject WorldContextObject);
		/// <summary>Returns whether this is running on a dedicated server</summary>
		public extern static bool IsDedicatedServer(UObject WorldContextObject);
		/// <summary>Returns whether the world this object is in is the host or not</summary>
		public extern static bool IsServer(UObject WorldContextObject);
		/// <summary>
		/// Get the current game time, in seconds. This stops when the game is paused and is affected by slomo.
		/// @param WorldContextObject    World context
		/// </summary>
		public extern static float GetGameTimeInSeconds(UObject WorldContextObject);
		public extern static bool DoesImplementInterface(UObject TestObject,TSubclassOf<UInterface>  Interface);
		/// <summary>Get the current user name from the OS</summary>
		public extern static FString GetPlatformUserName();
		/// <summary>
		/// Retrieves the game's platform-specific bundle identifier or package name of the game
		/// @return The game's bundle identifier or package name.
		/// </summary>
		public extern static FString GetGameBundleId();
		/// <summary>Get the name of the current game</summary>
		public extern static FString GetGameName();
		/// <summary>Engine build number, for displaying to end users.</summary>
		public extern static FString GetEngineVersion();
		/// <summary>Returns the display name of a class</summary>
		public extern static FString GetClassDisplayName(UClass Class);
		/// <summary>
		/// Returns the display name (or actor label), for displaying as a debugging aid.
		/// Note: In editor builds, this is the actor label.  In non-editor builds, this is the actual object name.  This function should not be used to uniquely identify actors!
		/// It is not localized and should not be used for display to an end user of a game.
		/// </summary>
		public extern static FString GetDisplayName(UObject Object);
		/// <summary>Returns the full path to the specified object.</summary>
		public extern static FString GetPathName(UObject Object);
		/// <summary>Returns the actual object name.</summary>
		public extern static FString GetObjectName(UObject Object);
		/// <summary>Return true if the class is usable : non-null and not pending kill</summary>
		public extern static bool IsValidClass(UClass Class);
		/// <summary>Return true if the object is usable : non-null and not pending kill</summary>
		public extern static bool IsValid(UObject Object);
		
	}
	
}
