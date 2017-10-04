using System;
namespace UnrealEngine
{
	public partial class UGameplayStatics:UBlueprintFunctionLibrary
	{
		/// <summary>
		/// Checks the commandline to see if the desired option was specified on the commandline (e.g. -demobuild)
		/// @return                               True if the launch option was specified on the commandline, false otherwise
		/// </summary>
		public extern static bool HasLaunchOption(FString OptionToCheck);
		/// <summary>
		/// Find an option in the options string and return it as an integer.
		/// @param Options               The string containing the options.
		/// @param Key                   The key to find the value of in Options.
		/// @return                              The value associated with Key as an integer if Key found in Options string, otherwise DefaultValue.
		/// </summary>
		public extern static int GetIntOption(FString Options,FString Key,int DefaultValue);
		/// <summary>
		/// Returns whether a key exists in an options string.
		/// @param Options               The string containing the options.
		/// @param Key                   The key to determine if it exists in Options.
		/// @return                              Whether Key was found in Options.
		/// </summary>
		public extern static bool HasOption(FString Options,FString InKey);
		/// <summary>
		/// Find an option in the options string and return it.
		/// @param Options               The string containing the options.
		/// @param Key                   The key to find the value of in Options.
		/// @return                              The value associated with Key if Key found in Options string.
		/// </summary>
		public extern static FString ParseOption(FString Options,FString Key);
		/// <summary>
		/// Break up a key=value pair into its key and value.
		/// @param Pair                  The string containing a pair to split apart.
		/// @param Key                   (out) Key portion of Pair. If no = in string will be the same as Pair.
		/// @param Value                 (out) Value portion of Pair. If no = in string will be empty.
		/// </summary>
		public extern static void GetKeyValue(FString Pair,out FString Key,out FString Value);
		/// <summary>
		/// Transforms the given 3D world-space point into a its 2D screen space coordinate.
		/// @param Player                        Project using this player's view.
		/// @param WorldPosition         World position to project.
		/// @param ScreenPosition        (out) Corresponding 2D position in screen space
		/// @param bPlayerViewportRelative       Should this be relative to the player viewport subregion (useful when using player attached widgets in split screen)
		/// </summary>
		public extern static bool ProjectWorldToScreen(APlayerController Player,FVector WorldPosition,out FVector2D ScreenPosition,bool bPlayerViewportRelative=false);
		/// <summary>
		/// Transforms the given 2D screen space coordinate into a 3D world-space point and direction.
		/// @param Player                        Deproject using this player's view.
		/// @param ScreenPosition        2D screen space to deproject.
		/// @param WorldPosition         (out) Corresponding 3D position in world space.
		/// @param WorldDirection        (out) World space direction vector away from the camera at the given 2d point.
		/// </summary>
		public extern static bool DeprojectScreenToWorld(APlayerController Player,FVector2D ScreenPosition,out FVector WorldPosition,out FVector WorldDirection);
		/// <summary>
		/// Counts how many grass foliage instances overlap a given sphere.
		/// @param        Mesh                    The static mesh we are interested in counting.
		/// @param        CenterPosition  The center position of the sphere.
		/// @param        Radius                  The radius of the sphere.
		/// @return Number of foliage instances with their mesh set to Mesh that overlap the sphere.
		/// </summary>
		public extern static int GrassOverlappingSphereCount(UObject WorldContextObject,UStaticMesh StaticMesh,FVector CenterPosition,float Radius);
		/// <summary>Returns local location for origin based position.</summary>
		public extern static FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject,FVector WorldLocation);
		/// <summary>Returns origin based position for local world location.</summary>
		public extern static FVector RebaseLocalOriginOntoZero(UObject WorldContextObject,FVector WorldLocation);
		/// <summary>Requests a new location for a world origin.</summary>
		public extern static void SetWorldOriginLocation(UObject WorldContextObject,FIntVector NewLocation);
		/// <summary>Returns world origin current location.</summary>
		public extern static FIntVector GetWorldOriginLocation(UObject WorldContextObject);
		/// <summary>
		/// Returns the launch velocity needed for a projectile at rest at StartPos to land on EndPos.
		/// Assumes a medium arc (e.g. 45 deg on level ground). Projectile velocity is variable and unconstrained.
		/// Does no tracing.
		/// @param OutLaunchVelocity                      Returns the launch velocity required to reach the EndPos
		/// @param StartPos                                       Start position of the simulation
		/// @param EndPos                                         Desired end location for the simulation
		/// @param OverrideGravityZ                       Optional override of WorldGravityZ
		/// @param ArcParam                                       Change height of arc between 0.0-1.0 where 0.5 is the default medium arc
		/// </summary>
		public extern static bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject,out FVector OutLaunchVelocity,FVector StartPos,FVector EndPos,float OverrideGravityZ=0.000000f,float ArcParam=0.500000f);
		/// <summary>
		/// Predict the arc of a virtual projectile affected by gravity with collision checks along the arc.
		/// Returns true if it hit something.
		/// @param PredictParams                          Input params to the trace (start location, velocity, time to simulate, etc).
		/// @param PredictResult                          Output result of the trace (Hit result, array of location/velocity/times for each trace step, etc).
		/// @return                                                       True if hit something along the path (if tracing with collision).
		/// </summary>
		public extern static bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject,FPredictProjectilePathParams PredictParams,out FPredictProjectilePathResult PredictResult);
		/// <summary>
		/// Calculates an launch velocity for a projectile to hit a specified point.
		/// @param TossVelocity          (output) Result launch velocity.
		/// @param StartLocation         Intended launch location
		/// @param EndLocation           Desired landing location
		/// @param LaunchSpeed           Desired launch speed
		/// @param OverrideGravityZ      Optional gravity override.  0 means "do not override".
		/// @param TraceOption           Controls whether or not to validate a clear path by tracing along the calculated arc
		/// @param CollisionRadius       Radius of the projectile (assumed spherical), used when tracing
		/// @param bFavorHighArc         If true and there are 2 valid solutions, will return the higher arc.  If false, will favor the lower arc.
		/// @param bDrawDebug            When true, a debug arc is drawn (red for an invalid arc, green for a valid arc)
		/// @return                                      Returns false if there is no valid solution or the valid solutions are blocked.  Returns true otherwise.
		/// </summary>
		public extern static bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject,out FVector TossVelocity,FVector StartLocation,FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,ESuggestProjVelocityTraceOption TraceOption,float CollisionRadius,bool bFavorHighArc,bool bDrawDebug);
		/// <summary>
		/// Returns the string name of the current platform, to perform different behavior based on platform.
		/// (Platform names include Windows, Mac, IOS, Android, PS4, XboxOne, HTML5, Linux)
		/// </summary>
		public extern static FString GetPlatformName();
		/// <summary>
		/// Toggle live DVR streaming.
		/// @param Enable                        If true enable streaming, otherwise disable.
		/// </summary>
		public extern static void EnableLiveStreaming(bool Enable);
		public extern static void GetAccurateRealTime(UObject WorldContextObject,out int Seconds,out float PartialSeconds);
		/// <summary>Returns time in seconds since world was brought up for play, IS stopped when game pauses, NOT dilated/clamped.</summary>
		public extern static float GetAudioTimeSeconds(UObject WorldContextObject);
		/// <summary>Returns time in seconds since world was brought up for play, does NOT stop when game pauses, NOT dilated/clamped</summary>
		public extern static float GetRealTimeSeconds(UObject WorldContextObject);
		/// <summary>Returns time in seconds since world was brought up for play, adjusted by time dilation and IS NOT stopped when game pauses</summary>
		public extern static float GetUnpausedTimeSeconds(UObject WorldContextObject);
		/// <summary>Returns time in seconds since world was brought up for play, adjusted by time dilation and IS stopped when game pauses</summary>
		public extern static float GetTimeSeconds(UObject WorldContextObject);
		/// <summary>Returns the frame delta time in seconds, adjusted by time dilation.</summary>
		public extern static float GetWorldDeltaSeconds(UObject WorldContextObject);
		/// <summary>
		/// Delete a save game in a particular slot.
		///      @param SlotName                 Name of save game slot to delete.
		///  @param UserIndex            For some platforms, master user index to identify the user doing the deletion.
		///  @return True if a file was actually able to be deleted. use DoesSaveGameExist to distinguish between delete failures and failure due to file not existing.
		/// </summary>
		public extern static bool DeleteGameInSlot(FString SlotName,int UserIndex);
		/// <summary>
		/// Load the contents from a given slot.
		/// @param SlotName                 Name of the save game slot to load from.
		/// @param UserIndex            For some platforms, master user index to identify the user doing the loading.
		/// @return SaveGameObject  Object containing loaded game state (NULL if load fails)
		/// </summary>
		public extern static USaveGame LoadGameFromSlot(FString SlotName,int UserIndex);
		/// <summary>
		/// See if a save game exists with the specified name.
		/// @param SlotName                 Name of save game slot.
		/// @param UserIndex            For some platforms, master user index to identify the user doing the saving.
		/// </summary>
		public extern static bool DoesSaveGameExist(FString SlotName,int UserIndex);
		/// <summary>
		/// Save the contents of the SaveGameObject to a slot.
		/// @param SaveGameObject   Object that contains data about the save game that we want to write out
		/// @param SlotName                 Name of save game slot to save to.
		/// @param UserIndex            For some platforms, master user index to identify the user doing the saving.
		/// @return                                 Whether we successfully saved this information
		/// </summary>
		public extern static bool SaveGameToSlot(USaveGame SaveGameObject,FString SlotName,int UserIndex);
		/// <summary>
		/// Create a new, empty SaveGame object to set data on and then pass to SaveGameToSlot.
		/// @param  SaveGameClass   Class of SaveGame to create
		/// @return                                 New SaveGame object to write data to
		/// </summary>
		public extern static USaveGame CreateSaveGameObject(TSubclassOf<USaveGame>  SaveGameClass);
		/// <summary>Try and find the UV for a collision impact. Note this ONLY works if 'Support UV From Hit Results' is enabled in Physics Settings.</summary>
		public extern static bool FindCollisionUV(FHitResult Hit,int UVChannel,out FVector2D UV);
		/// <summary>
		/// Returns the EPhysicalSurface type of the given Hit.
		/// To edit surface type for your project, use ProjectSettings/Physics/PhysicalSurface section
		/// </summary>
		public extern static EPhysicalSurface GetSurfaceType(FHitResult Hit);
		/// <summary>
		/// Create a HitResult struct
		/// @param Hit                   The source HitResult.
		/// @param bBlockingHit  True if there was a blocking hit, false otherwise.
		/// @param bInitialOverlap True if the hit started in an initial overlap. In this case some other values should be interpreted differently. Time will be 0, ImpactPoint will equal Location, and normals will be equal and indicate a depenetration vector.
		/// @param Time                  'Time' of impact along trace direction ranging from [0.0 to 1.0) if there is a hit, indicating time between start and end. Equals 1.0 if there is no hit.
		/// @param Location              Location of the hit in world space. If this was a swept shape test, this is the location where we can place the shape in the world where it will not penetrate.
		/// @param Normal                Normal of the hit in world space, for the object that was swept (e.g. for a sphere trace this points towards the sphere's center). Equal to ImpactNormal for line tests.
		/// @param ImpactPoint   Location of the actual contact point of the trace shape with the surface of the hit object. Equal to Location in the case of an initial overlap.
		/// @param ImpactNormal  Normal of the hit in world space, for the object that was hit by the sweep.
		/// @param PhysMat               Physical material that was hit. Must set bReturnPhysicalMaterial to true in the query params for this to be returned.
		/// @param HitActor              Actor hit by the trace.
		/// @param HitComponent  PrimitiveComponent hit by the trace.
		/// @param HitBoneName   Name of the bone hit (valid only if we hit a skeletal mesh).
		/// @param HitItem               Primitive-specific data recording which item in the primitive was hit
		/// @param FaceIndex             If colliding with trimesh or landscape, index of face that was hit.
		/// </summary>
		public extern static FHitResult MakeHitResult(bool bBlockingHit,bool bInitialOverlap,float Time,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UPhysicalMaterial PhysMat,AActor HitActor,UPrimitiveComponent HitComponent,FName HitBoneName,int HitItem,int FaceIndex,FVector TraceStart,FVector TraceEnd);
		/// <summary>
		/// Extracts data from a HitResult.
		/// @param Hit                   The source HitResult.
		/// @param bBlockingHit  True if there was a blocking hit, false otherwise.
		/// @param bInitialOverlap True if the hit started in an initial overlap. In this case some other values should be interpreted differently. Time will be 0, ImpactPoint will equal Location, and normals will be equal and indicate a depenetration vector.
		/// @param Time                  'Time' of impact along trace direction ranging from [0.0 to 1.0) if there is a hit, indicating time between start and end. Equals 1.0 if there is no hit.
		/// @param Location              Location of the hit in world space. If this was a swept shape test, this is the location where we can place the shape in the world where it will not penetrate.
		/// @param Normal                Normal of the hit in world space, for the object that was swept (e.g. for a sphere trace this points towards the sphere's center). Equal to ImpactNormal for line tests.
		/// @param ImpactPoint   Location of the actual contact point of the trace shape with the surface of the hit object. Equal to Location in the case of an initial overlap.
		/// @param ImpactNormal  Normal of the hit in world space, for the object that was hit by the sweep.
		/// @param PhysMat               Physical material that was hit. Must set bReturnPhysicalMaterial to true in the query params for this to be returned.
		/// @param HitActor              Actor hit by the trace.
		/// @param HitComponent  PrimitiveComponent hit by the trace.
		/// @param HitBoneName   Name of the bone hit (valid only if we hit a skeletal mesh).
		/// @param HitItem               Primitive-specific data recording which item in the primitive was hit
		/// @param FaceIndex             If colliding with trimesh or landscape, index of face that was hit.
		/// </summary>
		public extern static void BreakHitResult(FHitResult Hit,out bool bBlockingHit,out bool bInitialOverlap,out float Time,out FVector Location,out FVector ImpactPoint,out FVector Normal,out FVector ImpactNormal,out UPhysicalMaterial PhysMat,out AActor HitActor,out UPrimitiveComponent HitComponent,out FName HitBoneName,out int HitItem,out int FaceIndex,out FVector TraceStart,out FVector TraceEnd);
		/// <summary>
		/// Spawns a decal attached to and following the specified component. Does not replicate.
		/// @param DecalMaterial - decal's material
		/// @param DecalSize - size of decal
		/// @param AttachComponent - Component to attach to.
		/// @param AttachPointName - Optional named point within the AttachComponent to spawn the emitter at
		/// @param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
		/// @param Rotation - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a realative offset
		/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
		/// @param LifeSpan - destroy decal component after time runs out (0 = infinite)
		/// </summary>
		public extern static UDecalComponent SpawnDecalAttached(UMaterialInterface DecalMaterial,FVector DecalSize,USceneComponent AttachToComponent,FName AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,float LifeSpan=0.000000f);
		/// <summary>
		/// Spawns a decal at the given location and rotation, fire and forget. Does not replicate.
		/// @param DecalMaterial - decal's material
		/// @param DecalSize - size of decal
		/// @param Location - location to place the decal in world space
		/// @param Rotation - rotation to place the decal in world space
		/// @param LifeSpan - destroy decal component after time runs out (0 = infinite)
		/// </summary>
		public extern static UDecalComponent SpawnDecalAtLocation(UObject WorldContextObject,UMaterialInterface DecalMaterial,FVector DecalSize,FVector Location,FRotator Rotation=default(FRotator),float LifeSpan=0.000000f);
		/// <summary>Returns the highest priority reverb settings currently active from any source (volumes or manual setting).</summary>
		public extern static UReverbEffect GetCurrentReverbEffect(UObject WorldContextObject);
		/// <summary>
		/// Deactivates a Reverb Effect not applied by a volume
		/// @param TagName Tag associated with Reverb Effect to remove
		/// </summary>
		public extern static void DeactivateReverbEffect(UObject WorldContextObject,FName TagName);
		/// <summary>
		/// Activates a Reverb Effect without the need for a volume
		/// @param ReverbEffect Reverb Effect to use
		/// @param TagName Tag to associate with Reverb Effect
		/// @param Priority Priority of the Reverb Effect
		/// @param Volume Volume level of Reverb Effect
		/// @param FadeTime Time before Reverb Effect is fully active
		/// </summary>
		public extern static void ActivateReverbEffect(UObject WorldContextObject,UReverbEffect ReverbEffect,FName TagName,float Priority=0.000000f,float Volume=0.500000f,float FadeTime=2.000000f);
		/// <summary>Clear all sound mix modifiers from the audio system *</summary>
		public extern static void ClearSoundMixModifiers(UObject WorldContextObject);
		/// <summary>Pop a sound mix modifier from the audio system *</summary>
		public extern static void PopSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier);
		/// <summary>Push a sound mix modifier onto the audio system *</summary>
		public extern static void PushSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier);
		/// <summary>
		/// Clears the override of the sound class adjuster in the given sound mix. If the override did not exist in the sound mix, this will do nothing.
		/// @param InSoundMixModifier The sound mix to modify.
		/// @param InSoundClass The sound class to override (or add) in the sound mix.
		/// @param FadeOutTime The interpolation time to use to go from the current sound class adjuster override values to the non-override values.
		/// </summary>
		public extern static void ClearSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float FadeOutTime=1.000000f);
		/// <summary>
		/// Overrides the sound class adjuster in the given sound mix. If the sound class does not exist in the input sound mix, the sound class adjustment will be added to the sound mix.
		/// @param InSoundMixModifier The sound mix to modify.
		/// @param InSoundClass The sound class to override (or add) in the sound mix.
		/// @param Volume The volume scale to set the sound class adjuster to.
		/// @param Pitch The pitch scale to set the sound class adjuster to.
		/// @param FadeInTime The interpolation time to use to go from the current sound class adjuster values to the new values.
		/// @param bApplyToChildren Whether or not to apply this override to the sound class' children or to just the specified sound class.
		/// </summary>
		public extern static void SetSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float Volume=1.000000f,float Pitch=1.000000f,float FadeInTime=1.000000f,bool bApplyToChildren=true);
		/// <summary>Set the sound mix of the audio system for special EQing *</summary>
		public extern static void SetBaseSoundMix(UObject WorldContextObject,USoundMix InSoundMix);
		/// <summary>
		/// Returns whether or not subtitles are currently enabled.
		/// @return true if subtitles are enabled.
		/// </summary>
		public extern static bool AreSubtitlesEnabled();
		/// <summary>
		/// Will set subtitles to be enabled or disabled.
		/// @param bEnabled will enable subtitle drawing if true, disable if false.
		/// </summary>
		public extern static void SetSubtitlesEnabled(bool bEnabled);
		/// <summary>
		/// Plays a force feedback effect attached to and following the specified component. This is a fire and forget effect. Replication is also not handled at this point.
		/// @param ForceFeedbackEffect - effect to play
		/// @param AttachComponent - Component to attach to.
		/// @param AttachPointName - Optional named point within the AttachComponent to attach to
		/// @param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
		/// @param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
		/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
		/// @param bStopWhenAttachedToDestroyed - Specifies whether the feedback effect should stop playing when the owner of the attach to component is destroyed.
		/// @param IntensityMultiplier - Intensity multiplier
		/// @param StartTime - How far in to the feedback effect to begin playback at
		/// @param AttenuationSettings - Override attenuation settings package to play effect with
		/// @return Force Feedback Component to manipulate the playing feedback effect with
		/// </summary>
		public extern static UForceFeedbackComponent SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect,USceneComponent AttachToComponent,FName AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,bool bLooping=false,float IntensityMultiplier=1.000000f,float StartTime=0.000000f,UForceFeedbackAttenuation AttenuationSettings=default(UForceFeedbackAttenuation));
		/// <summary>
		/// Plays a force feedback effect at the given location. This is a fire and forget effect and does not travel with any actor. Replication is also not handled at this point.
		/// @param ForceFeedbackEffect - effect to play
		/// @param Location - World position to center the effect at
		/// @param Rotation - World rotation to center the effect at
		/// @param IntensityMultiplier - Intensity multiplier
		/// @param StartTime - How far in to the feedback effect to begin playback at
		/// @param AttenuationSettings - Override attenuation settings package to play effect with
		/// @return Force Feedback Component to manipulate the playing feedback effect with
		/// </summary>
		public extern static UForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject,UForceFeedbackEffect ForceFeedbackEffect,FVector Location,FRotator Rotation,bool bLooping=false,float IntensityMultiplier=1.000000f,float StartTime=0.000000f,UForceFeedbackAttenuation AttenuationSettings=default(UForceFeedbackAttenuation));
		/// <summary>
		/// Plays a dialogue attached to and following the specified component. This is a fire and forget sound. Replication is also not handled at this point.
		/// @param Dialogue - dialogue to play
		/// @param Context - context the dialogue is to play in
		/// @param AttachComponent - Component to attach to.
		/// @param AttachPointName - Optional named point within the AttachComponent to play the sound at
		/// @param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
		/// @param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
		/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
		/// @param bStopWhenAttachedToDestroyed - Specifies whether the sound should stop playing when the owner of the attach to component is destroyed.
		/// @param VolumeMultiplier - Volume multiplier
		/// @param PitchMultiplier - PitchMultiplier
		/// @param StartTime - How far in to the dialogue to begin playback at
		/// @param AttenuationSettings - Override attenuation settings package to play sound with
		/// @return Audio Component to manipulate the playing dialogue with
		/// </summary>
		public extern static UAudioComponent SpawnDialogueAttached(UDialogueWave Dialogue,FDialogueContext Context,USceneComponent AttachToComponent,FName AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation));
		/// <summary>
		/// Plays a dialogue at the given location. This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
		/// @param Dialogue - dialogue to play
		/// @param Context - context the dialogue is to play in
		/// @param Location - World position to play dialogue at
		/// @param Rotation - World rotation to play dialogue at
		/// @param VolumeMultiplier - Volume multiplier
		/// @param PitchMultiplier - PitchMultiplier
		/// @param StartTime - How far in to the dialogue to begin playback at
		/// @param AttenuationSettings - Override attenuation settings package to play sound with
		/// @return Audio Component to manipulate the playing dialogue with
		/// </summary>
		public extern static UAudioComponent SpawnDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation));
		/// <summary>
		/// Plays a dialogue at the given location. This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
		/// @param Dialogue - dialogue to play
		/// @param Context - context the dialogue is to play in
		/// @param Location - World position to play dialogue at
		/// @param Rotation - World rotation to play dialogue at
		/// @param VolumeMultiplier - Volume multiplier
		/// @param PitchMultiplier - Pitch multiplier
		/// @param StartTime - How far in to the dialogue to begin playback at
		/// @param AttenuationSettings - Override attenuation settings package to play sound with
		/// </summary>
		public extern static void PlayDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation));
		/// <summary>
		/// Spawns a dialogue with no attenuation, perfect for UI.
		/// * Not Replicated.
		/// @param Dialogue - dialogue to play
		/// @param Context - context the dialogue is to play in
		/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
		/// @param PitchMultiplier - Multiplies the pitch.
		/// @param StartTime - How far in to the dialogue to begin playback at
		/// @return An audio component to manipulate the spawned sound
		/// </summary>
		public extern static UAudioComponent SpawnDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f);
		/// <summary>
		/// Plays a dialogue directly with no attenuation, perfect for UI.
		/// * Fire and Forget.
		/// * Not Replicated.
		/// @param Dialogue - dialogue to play
		/// @param Context - context the dialogue is to play in
		/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
		/// @param PitchMultiplier - Multiplies the pitch.
		/// @param StartTime - How far in to the dialogue to begin playback at
		/// </summary>
		public extern static void PlayDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f);
		/// <summary>
		/// Plays a sound attached to and following the specified component. This is a fire and forget sound. Replication is also not handled at this point.
		/// @param Sound - sound to play
		/// @param AttachComponent - Component to attach to.
		/// @param AttachPointName - Optional named point within the AttachComponent to play the sound at
		/// @param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
		/// @param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
		/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
		/// @param bStopWhenAttachedToDestroyed - Specifies whether the sound should stop playing when the owner of the attach to component is destroyed.
		/// @param VolumeMultiplier - Volume multiplier
		/// @param PitchMultiplier - PitchMultiplier
		/// @param StartTime - How far in to the sound to begin playback at
		/// @param AttenuationSettings - Override attenuation settings package to play sound with
		/// @param ConcurrencySettings - Override concurrency settings package to play sound with
		/// @return An audio component to manipulate the spawned sound
		/// </summary>
		public extern static UAudioComponent SpawnSoundAttached(USoundBase Sound,USceneComponent AttachToComponent,FName AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency));
		/// <summary>
		/// Spawns a sound at the given location. This does not travel with any actor. Replication is also not handled at this point.
		/// @param Sound - sound to play
		/// @param Location - World position to play sound at
		/// @param Rotation - World rotation to play sound at
		/// @param VolumeMultiplier - Volume multiplier
		/// @param PitchMultiplier - PitchMultiplier
		/// @param StartTime - How far in to the sound to begin playback at
		/// @param AttenuationSettings - Override attenuation settings package to play sound with
		/// @param ConcurrencySettings - Override concurrency settings package to play sound with
		/// @return An audio component to manipulate the spawned sound
		/// </summary>
		public extern static UAudioComponent SpawnSoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency));
		/// <summary>
		/// Plays a sound at the given location. This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
		/// @param Sound - sound to play
		/// @param Location - World position to play sound at
		/// @param Rotation - World rotation to play sound at
		/// @param VolumeMultiplier - Volume multiplier
		/// @param PitchMultiplier - PitchMultiplier
		/// @param StartTime - How far in to the sound to begin playback at
		/// @param AttenuationSettings - Override attenuation settings package to play sound with
		/// @param ConcurrencySettings - Override concurrency settings package to play sound with
		/// </summary>
		public extern static void PlaySoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency));
		/// <summary>
		/// Creates a sound with no attenuation, perfect for UI sounds. This does NOT play the sound
		/// * Not Replicated.
		/// @param Sound - Sound to create.
		/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
		/// @param PitchMultiplier - Multiplies the pitch.
		/// @param StartTime - How far in to the sound to begin playback at
		/// @return An audio component to manipulate the spawned sound
		/// </summary>
		public extern static UAudioComponent CreateSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bPersistAcrossLevelTransition=false);
		/// <summary>
		/// Spawns a sound with no attenuation, perfect for UI sounds.
		/// * Not Replicated.
		/// @param Sound - Sound to play.
		/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
		/// @param PitchMultiplier - Multiplies the pitch.
		/// @param StartTime - How far in to the sound to begin playback at
		/// @param ConcurrencySettings - Override concurrency settings package to play sound with
		/// @return An audio component to manipulate the spawned sound
		/// </summary>
		public extern static UAudioComponent SpawnSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bPersistAcrossLevelTransition=false);
		/// <summary>
		/// Plays a sound directly with no attenuation, perfect for UI sounds.
		/// * Fire and Forget.
		/// * Not Replicated.
		/// @param Sound - Sound to play.
		/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
		/// @param PitchMultiplier - Multiplies the pitch.
		/// @param ConcurrencySettings - Override concurrency settings package to play sound with
		/// @param StartTime - How far in to the sound to begin playback at
		/// </summary>
		public extern static void PlaySound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency));
		/// <summary>
		/// Sets the global listener focus parameters which will scale focus behavior of sounds based on their focus azimuth settings in their attenuation settings.
		/// * Fire and Forget.
		/// * Not Replicated.
		/// @param FocusAzimuthScale - An angle scale value used to scale the azimuth angle that defines where sounds are in-focus.
		/// @param NonFocusAzimuthScale- An angle scale value used to scale the azimuth angle that defines where sounds are out-of-focus.
		/// @param FocusDistanceScale - A distance scale value to use for sounds which are in-focus. Values < 1.0 will reduce perceived distance to sounds, values > 1.0 will increase perceived distance to in-focus sounds.
		/// @param NonFocusDistanceScale - A distance scale value to use for sounds which are out-of-focus. Values < 1.0 will reduce perceived distance to sounds, values > 1.0 will increase perceived distance to in-focus sounds.
		/// @param FocusVolumeScale- A volume attenuation value to use for sounds which are in-focus.
		/// @param NonFocusVolumeScale- A volume attenuation value to use for sounds which are out-of-focus.
		/// @param FocusPriorityScale - A priority scale value (> 0.0) to use for sounds which are in-focus. Values < 1.0 will reduce the priority of in-focus sounds, values > 1.0 will increase the priority of in-focus sounds.
		/// @param NonFocusPriorityScale - A priority scale value (> 0.0) to use for sounds which are out-of-focus. Values < 1.0 will reduce the priority of sounds out-of-focus sounds, values > 1.0 will increase the priority of out-of-focus sounds.
		/// </summary>
		public extern static void SetGlobalListenerFocusParameters(UObject WorldContextObject,float FocusAzimuthScale=1.000000f,float NonFocusAzimuthScale=1.000000f,float FocusDistanceScale=1.000000f,float NonFocusDistanceScale=1.000000f,float FocusVolumeScale=1.000000f,float NonFocusVolumeScale=1.000000f,float FocusPriorityScale=1.000000f,float NonFocusPriorityScale=1.000000f);
		/// <summary>
		/// Sets a global pitch modulation scalar that will apply to all non-UI sounds
		/// * Fire and Forget.
		/// * Not Replicated.
		/// @param PitchModulation - A pitch modulation value to globally set.
		/// @param TimeSec - A time value to linearly interpolate the global modulation pitch over from it's current value.
		/// </summary>
		public extern static void SetGlobalPitchModulation(UObject WorldContextObject,float PitchModulation,float TimeSec);
		/// <summary>
		/// Determines if any audio listeners are within range of the specified location
		/// @param Location              The location to potentially play a sound at
		/// @param MaximumRange  The maximum distance away from Location that a listener can be
		/// @note This will always return false if there is no audio device, or the audio device is disabled.
		/// </summary>
		public extern static bool AreAnyListenersWithinRange(UObject WorldContextObject,FVector Location,float MaximumRange);
		/// <summary>
		/// Plays the specified effect attached to and following the specified component. The system will go away when the effect is complete. Does not replicate.
		/// @param EmitterTemplate - particle system to create
		/// @param AttachComponent - Component to attach to.
		/// @param AttachPointName - Optional named point within the AttachComponent to spawn the emitter at
		/// @param Location - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world location that will be translated to a relative offset (if LocationType is KeepWorldPosition).
		/// @param Rotation - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset (if LocationType is KeepWorldPosition).
		/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
		/// @param bAutoDestroy - Whether the component will automatically be destroyed when the particle system completes playing or whether it can be reactivated
		/// </summary>
		public extern static UParticleSystemComponent SpawnEmitterAttached(UParticleSystem EmitterTemplate,USceneComponent AttachToComponent,FName AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bAutoDestroy=true);
		/// <summary>
		/// Plays the specified effect at the given location and rotation, fire and forget. The system will go away when the effect is complete. Does not replicate.
		/// @param WorldContextObject - Object that we can obtain a world context from
		/// @param EmitterTemplate - particle system to create
		/// @param Location - location to place the effect in world space
		/// @param Rotation - rotation to place the effect in world space
		/// @param bAutoDestroy - Whether the component will automatically be destroyed when the particle system completes playing or whether it can be reactivated
		/// </summary>
		public extern static UParticleSystemComponent SpawnEmitterAtLocation(UObject WorldContextObject,UParticleSystem EmitterTemplate,FVector Location,FRotator Rotation,bool bAutoDestroy=true);
		/// <summary>
		/// Plays an in-world camera shake that affects all nearby local players, with distance-based attenuation. Does not replicate.
		/// @param WorldContextObject - Object that we can obtain a world context from
		/// @param Shake - Camera shake asset to use
		/// @param Epicenter - location to place the effect in world space
		/// @param InnerRadius - Cameras inside this radius are ignored
		/// @param OuterRadius - Cameras outside of InnerRadius and inside this are effected
		/// @param Falloff - Affects falloff of effect as it nears OuterRadius
		/// @param bOrientShakeTowardsEpicenter - Changes the rotation of shake to point towards epicenter instead of forward
		/// </summary>
		public extern static void PlayWorldCameraShake(UObject WorldContextObject,TSubclassOf<UCameraShake>  Shake,FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff=1.000000f,bool bOrientShakeTowardsEpicenter=false);
		/// <summary>
		/// Hurts the specified actor with generic damage.
		/// @param DamagedActor - Actor that will be damaged.
		/// @param BaseDamage - The base damage to apply.
		/// @param EventInstigator - Controller that was responsible for causing this damage (e.g. player who shot the weapon)
		/// @param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded)
		/// @param DamageTypeClass - Class that describes the damage that was done.
		/// @return Actual damage the ended up being applied to the actor.
		/// </summary>
		public extern static float ApplyDamage(AActor DamagedActor,float BaseDamage,AController EventInstigator,AActor DamageCauser,TSubclassOf<UDamageType>  DamageTypeClass);
		/// <summary>
		/// Hurts the specified actor with the specified impact.
		/// @param DamagedActor - Actor that will be damaged.
		/// @param BaseDamage - The base damage to apply.
		/// @param HitFromDirection - Direction the hit came FROM
		/// @param HitInfo - Collision or trace result that describes the hit
		/// @param EventInstigator - Controller that was responsible for causing this damage (e.g. player who shot the weapon)
		/// @param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded)
		/// @param DamageTypeClass - Class that describes the damage that was done.
		/// @return Actual damage the ended up being applied to the actor.
		/// </summary>
		public extern static float ApplyPointDamage(AActor DamagedActor,float BaseDamage,FVector HitFromDirection,FHitResult HitInfo,AController EventInstigator,AActor DamageCauser,TSubclassOf<UDamageType>  DamageTypeClass);
		/// <summary>
		/// Returns the game's paused state
		/// @return      Whether the game is currently paused or not
		/// </summary>
		public extern static bool IsGamePaused(UObject WorldContextObject);
		/// <summary>
		/// Sets the game's paused state
		/// @param       bPaused         Whether the game should be paused or not
		/// @return      Whether the game was successfully paused/unpaused
		/// </summary>
		public extern static bool SetGamePaused(UObject WorldContextObject,bool bPaused);
		/// <summary>
		/// Sets the global time dilation.
		/// @param       TimeDilation    value to set the global time dilation to
		/// </summary>
		public extern static void SetGlobalTimeDilation(UObject WorldContextObject,float TimeDilation);
		/// <summary>
		/// Gets the current global time dilation.
		/// @return Current time dilation.
		/// </summary>
		public extern static float GetGlobalTimeDilation(UObject WorldContextObject);
		/// <summary>Returns the class of a passed in Object, will always be valid if Object is not NULL</summary>
		public extern static UClass GetObjectClass(UObject Object);
		/// <summary>Returns the current GameStateBase or Null if it can't be retrieved</summary>
		public extern static AGameStateBase GetGameState(UObject WorldContextObject);
		/// <summary>Returns the current GameModeBase or Null if it can't be retrieved, such as on the client</summary>
		public extern static AGameModeBase GetGameMode(UObject WorldContextObject);
		/// <summary>
		/// Get the name of the currently-open level.
		/// @param bRemovePrefixString    remove any streaming- or editor- added prefixes from the level name.
		/// </summary>
		public extern static FString GetCurrentLevelName(UObject WorldContextObject,bool bRemovePrefixString=true);
		/// <summary>
		/// Travel to another level
		/// @param       LevelName                       the level to open
		/// @param       bAbsolute                       if true options are reset, if false options are carried over from current level
		/// @param       Options                         a string of options to use for the travel URL
		/// </summary>
		public extern static void OpenLevel(UObject WorldContextObject,FName LevelName,bool bAbsolute=true,FString Options=default(FString));
		/// <summary>Cancels all currently queued streaming packages</summary>
		public extern static void CancelAsyncLoading();
		/// <summary>Flushes level streaming in blocking fashion and returns when all sub-levels are loaded / visible / hidden</summary>
		public extern static void FlushLevelStreaming(UObject WorldContextObject);
		/// <summary>Returns level streaming object with specified level package name</summary>
		public extern static ULevelStreaming GetStreamingLevel(UObject WorldContextObject,FName PackageName);
		/// <summary>Unload a streamed in level</summary>
		public extern static void UnloadStreamLevel(UObject WorldContextObject,FName LevelName,FLatentActionInfo LatentInfo);
		/// <summary>Stream the level with the LevelName ; Calling again before it finishes has no effect</summary>
		public extern static void LoadStreamLevel(UObject WorldContextObject,FName LevelName,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo);
		/// <summary>
		/// Sets what controller ID a Player should be using
		/// @param Player                        The player controller of the player to change the controller ID of
		/// @param ControllerId          The controller ID to assign to this player
		/// </summary>
		public extern static void SetPlayerControllerID(APlayerController Player,int ControllerId);
		/// <summary>
		/// Gets what controller ID a Player is using
		/// @param Player         The player controller of the player to get the ID of
		/// @return                       The ID of the passed in player. -1 if there is no controller for the passed in player
		/// </summary>
		public extern static int GetPlayerControllerID(APlayerController Player);
		/// <summary>
		/// Removes a player from this game.
		/// @param Player                       The player controller of the player to be removed
		/// @param bDestroyPawn         Whether the controlled pawn should be deleted as well
		/// </summary>
		public extern static void RemovePlayer(APlayerController Player,bool bDestroyPawn);
		/// <summary>
		/// Create a new player for this game.
		/// @param ControllerId         The ID of the controller that the should control the newly created player.  A value of -1 specifies to use the next available ID
		/// @param bSpawnPawn           Whether a pawn should be spawned immediately. If false a pawn will not be created until transition to the next map.
		/// </summary>
		public extern static APlayerController CreatePlayer(UObject WorldContextObject,int ControllerId=-1,bool bSpawnPawn=true);
		/// <summary>Returns the player's camera manager for the specified player index</summary>
		public extern static APlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject,int PlayerIndex);
		/// <summary>Returns the player character (NULL if the player pawn doesn't exist OR is not a character) at the specified player index</summary>
		public extern static ACharacter GetPlayerCharacter(UObject WorldContextObject,int PlayerIndex);
		/// <summary>Returns the player pawn at the specified player index</summary>
		public extern static APawn GetPlayerPawn(UObject WorldContextObject,int PlayerIndex);
		/// <summary>Returns the player controller at the specified player index</summary>
		public extern static APlayerController GetPlayerController(UObject WorldContextObject,int PlayerIndex);
		/// <summary>Returns the game instance object</summary>
		public extern static UGameInstance GetGameInstance(UObject WorldContextObject);
		/// <summary>'Finish' spawning an actor.  This will run the construction script.</summary>
		public extern static AActor FinishSpawningActor(AActor Actor,FTransform SpawnTransform);
		/// <summary>--- Create Object</summary>
		public extern static UObject SpawnObject(TSubclassOf<UObject>  ObjectClass,UObject Outer);
		
	}
	
}
