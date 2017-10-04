using System;
namespace UnrealEngine
{
	public partial class UAnimInstance:UObject
	{
		public extern FMarkerSyncAnimPosition GetSyncGroupPosition(FName InSyncGroupName);
		public extern bool IsSyncGroupBetweenMarkers(FName InSyncGroupName,FName PreviousMarker,FName NextMarker,bool bRespectMarkerOrder=true);
		public extern bool HasMarkerBeenHitThisFrame(FName SyncGroup,FName MarkerName);
		/// <summary>--- AI communication end ---</summary>
		public extern bool GetTimeToClosestMarker(FName SyncGroup,FName MarkerName,out float OutMarkerTime);
		/// <summary>
		/// Returns degree of the angle betwee velocity and Rotation forward vector
		/// The range of return will be from [-180, 180], and this can be used to feed blendspace directional value
		/// </summary>
		public extern float CalculateDirection(FVector Velocity,FRotator BaseRotation);
		/// <summary>Clears the current morph targets.</summary>
		public extern void ClearMorphTargets();
		/// <summary>Sets a morph target to a certain weight.</summary>
		public extern void SetMorphTarget(FName MorphTargetName,float Value);
		/// <summary>Returns the name of a currently active state in a state machine.</summary>
		public extern FName GetCurrentStateName(int MachineIndex);
		/// <summary>Returns the value of a named curve.</summary>
		public extern float GetCurveValue(FName CurveName);
		/// <summary>Get the current accumulated time as a fraction of the length of the most relevant animation in the source state</summary>
		public extern float GetRelevantAnimTimeFraction(int MachineIndex,int StateIndex);
		/// <summary>Get the current accumulated time in seconds for the most relevant animation in the source state</summary>
		public extern float GetRelevantAnimTime(int MachineIndex,int StateIndex);
		/// <summary>Get the length in seconds of the most relevant animation in the source state</summary>
		public extern float GetRelevantAnimLength(int MachineIndex,int StateIndex);
		/// <summary>Get the time remaining as a fraction of the duration for the most relevant animation in the source state</summary>
		public extern float GetRelevantAnimTimeRemainingFraction(int MachineIndex,int StateIndex);
		/// <summary>Get the time remaining in seconds for the most relevant animation in the source state</summary>
		public extern float GetRelevantAnimTimeRemaining(int MachineIndex,int StateIndex);
		/// <summary>Get the elapsed time as a fraction of the crossfade duration of a specified transition</summary>
		public extern float GetInstanceTransitionTimeElapsedFraction(int MachineIndex,int TransitionIndex);
		/// <summary>Get the elapsed time in seconds of a specified transition</summary>
		public extern float GetInstanceTransitionTimeElapsed(int MachineIndex,int TransitionIndex);
		/// <summary>Get the crossfade duration of a specified transition</summary>
		public extern float GetInstanceTransitionCrossfadeDuration(int MachineIndex,int TransitionIndex);
		/// <summary>Get the current elapsed time of a state within the specified state machine</summary>
		public extern float GetInstanceCurrentStateElapsedTime(int MachineIndex);
		/// <summary>Get the blend weight of a specified state</summary>
		public extern float GetInstanceStateWeight(int MachineIndex,int StateIndex);
		/// <summary>Get the blend weight of a specified state machine</summary>
		public extern float GetInstanceMachineWeight(int MachineIndex);
		/// <summary>Get the time as a fraction of the asset length of an animation in an asset player node</summary>
		public extern float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex);
		/// <summary>Get the time in seconds from the end of an animation in an asset player node</summary>
		public extern float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex);
		/// <summary>Get the current accumulated time as a fraction for an asset player node</summary>
		public extern float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex);
		/// <summary>Get the current accumulated time in seconds for an asset player node</summary>
		public extern float GetInstanceAssetPlayerTime(int AssetPlayerIndex);
		/// <summary>Gets the length in seconds of the asset referenced in an asset player node</summary>
		public extern float GetInstanceAssetPlayerLength(int AssetPlayerIndex);
		/// <summary>Set RootMotionMode</summary>
		public extern void SetRootMotionMode(ERootMotionMode Value);
		/// <summary>
		/// Get a current Active Montage in this AnimInstance.
		///               Note that there might be multiple Active at the same time. This will only return the first active one it finds. *
		/// </summary>
		public extern UAnimMontage GetCurrentActiveMontage();
		/// <summary>Returns true if any montage is playing currently. Doesn't mean it's active though, it could be blending out.</summary>
		public extern bool IsAnyMontagePlaying();
		/// <summary>
		/// Get PlayRate for Montage.
		///       If Montage reference is NULL, PlayRate for any Active Montage will be returned.
		///       If Montage is not playing, 0 is returned.
		/// </summary>
		public extern float Montage_GetPlayRate(UAnimMontage Montage);
		/// <summary>
		/// Get the current blend time of the Montage.
		///       If Montage reference is NULL, it will return the current blend time on the first active Montage found.
		/// </summary>
		public extern float Montage_GetBlendTime(UAnimMontage Montage);
		/// <summary>return true if Montage is not currently active. (not valid or blending out)</summary>
		public extern bool Montage_GetIsStopped(UAnimMontage Montage);
		/// <summary>Set position.</summary>
		public extern void Montage_SetPosition(UAnimMontage Montage,float NewPosition);
		/// <summary>Get Current Montage Position</summary>
		public extern float Montage_GetPosition(UAnimMontage Montage);
		/// <summary>Returns the name of the current animation montage section.</summary>
		public extern FName Montage_GetCurrentSection(UAnimMontage Montage);
		/// <summary>
		/// Returns true if the animation montage is currently active and playing.
		///       If reference is NULL, it will return true is ANY montage is currently active and playing.
		/// </summary>
		public extern bool Montage_IsPlaying(UAnimMontage Montage);
		/// <summary>Returns true if the animation montage is active. If the Montage reference is NULL, it will return true if any Montage is active.</summary>
		public extern bool Montage_IsActive(UAnimMontage Montage);
		/// <summary>Change AnimMontage play rate. NewPlayRate = 1.0 is the default playback rate.</summary>
		public extern void Montage_SetPlayRate(UAnimMontage Montage,float NewPlayRate=1.000000f);
		/// <summary>
		/// Relink new next section AFTER SectionNameToChange in run-time
		///     You can link section order the way you like in editor, but in run-time if you'd like to change it dynamically,
		///     use this function to relink the next section
		///     For example, you can have Start->Loop->Loop->Loop.... but when you want it to end, you can relink
		///     next section of Loop to be End to finish the montage, in which case, it stops looping by Loop->End.
		/// @param SectionNameToChange : This should be the name of the Montage Section after which you want to insert a new next section
		/// @param NextSection   : new next section
		/// </summary>
		public extern void Montage_SetNextSection(FName SectionNameToChange,FName NextSection,UAnimMontage Montage);
		/// <summary>Makes a montage jump to the end of a named section. If Montage reference is NULL, it will do that to all active montages.</summary>
		public extern void Montage_JumpToSectionsEnd(FName SectionName,UAnimMontage Montage);
		/// <summary>Makes a montage jump to a named section. If Montage reference is NULL, it will do that to all active montages.</summary>
		public extern void Montage_JumpToSection(FName SectionName,UAnimMontage Montage);
		/// <summary>Resumes a paused animation montage. If reference is NULL, it will resume ALL active montages.</summary>
		public extern void Montage_Resume(UAnimMontage Montage);
		/// <summary>Pauses the animation montage. If reference is NULL, it will pause ALL active montages.</summary>
		public extern void Montage_Pause(UAnimMontage Montage);
		/// <summary>Stops the animation montage. If reference is NULL, it will stop ALL active montages.</summary>
		public extern void Montage_Stop(float InBlendOutTime,UAnimMontage Montage);
		/// <summary>Return true if it's playing the slot animation</summary>
		public extern bool IsPlayingSlotAnimation(UAnimSequenceBase Asset,FName SlotNodeName);
		/// <summary>Stops currently playing slot animation slot or all</summary>
		public extern void StopSlotAnimation(float InBlendOutTime=0.250000f,FName SlotNodeName=default(FName));
		/// <summary>Play normal animation asset on the slot node by creating a dynamic UAnimMontage. You can only play one asset (whether montage or animsequence) at a time per SlotGroup.</summary>
		public extern UAnimMontage PlaySlotAnimationAsDynamicMontage(UAnimSequenceBase Asset,FName SlotNodeName,float BlendInTime=0.250000f,float BlendOutTime=0.250000f,float InPlayRate=1.000000f,int LoopCount=1,float BlendOutTriggerTime=-1.000000f,float InTimeToStartMontageAt=0.000000f);
		/// <summary>Returns the skeletal mesh component that has created this AnimInstance</summary>
		public extern USkeletalMeshComponent GetOwningComponent();
		/// <summary>Returns the owning actor of this AnimInstance</summary>
		public extern AActor GetOwningActor();
		/// <summary>
		/// Takes a snapshot of the current skeletal mesh component pose and saves it to the specified snapshot.
		/// The snapshot is taken at the current LOD, so if for example you took the snapshot at LOD1
		/// and then used it at LOD0 any bones not in LOD1 will use the reference pose
		/// </summary>
		public extern virtual void SnapshotPose(out FPoseSnapshot Snapshot);
		/// <summary>
		/// Takes a snapshot of the current skeletal mesh component pose & saves it internally.
		/// This snapshot can then be retrieved by name in the animation blueprint for blending.
		/// The snapshot is taken at the current LOD, so if for example you took the snapshot at LOD1 and then used it at LOD0 any bones not in LOD1 will use the reference pose
		/// </summary>
		public extern virtual void SavePoseSnapshot(FName SnapshotName);
		/// <summary>kismet event functions</summary>
		public extern virtual APawn TryGetPawnOwner();
		/// <summary>DeltaTime *</summary>
		public float DeltaTime;
		
		/// <summary>This is used to extract animation. If Mesh exists, this will be overwritten by Mesh->Skeleton</summary>
		public USkeleton CurrentSkeleton;
		
		/// <summary>Sets where this blueprint pulls Root Motion from</summary>
		public ERootMotionMode RootMotionMode;
		
		public bool bRunUpdatesInWorkerThreads;
		
		public bool bCanUseParallelUpdateAnimation;
		
		/// <summary>
		/// Allows this anim instance to update its native update, blend tree, montages and asset players on
		/// a worker thread. This flag is propagated from the UAnimBlueprint to this instance by the compiler.
		/// The compiler will attempt to pick up any issues that may occur with threaded update.
		/// For updates to run in multiple threads both this flag and the project setting "Allow Multi Threaded
		/// Animation Update" should be set.
		/// </summary>
		public bool bUseMultiThreadedAnimationUpdate;
		
		public bool bWarnAboutBlueprintUsage;
		
		/// <summary>
		/// True when Montages are being ticked, and Montage Events should be queued.
		/// When Montage are being ticked, we queue AnimNotifies and Events. We trigger notifies first, then Montage events.
		/// </summary>
		public bool bQueueMontageEvents;
		
		
	}
	
}
