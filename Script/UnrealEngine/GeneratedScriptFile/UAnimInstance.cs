using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAnimInstance:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FMarkerSyncAnimPosition GetSyncGroupPosition(IntPtr _this,string InSyncGroupName);
public  FMarkerSyncAnimPosition GetSyncGroupPosition(string InSyncGroupName)
{
	CheckIsValid();
	FMarkerSyncAnimPosition ___ret = GetSyncGroupPosition(_this.Get(),InSyncGroupName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsSyncGroupBetweenMarkers(IntPtr _this,string InSyncGroupName,string PreviousMarker,string NextMarker,int bRespectMarkerOrder);
public  bool IsSyncGroupBetweenMarkers(string InSyncGroupName,string PreviousMarker,string NextMarker,bool bRespectMarkerOrder=true)
{
	CheckIsValid();
	int ___ret = IsSyncGroupBetweenMarkers(_this.Get(),InSyncGroupName,PreviousMarker,NextMarker,bRespectMarkerOrder?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMarkerBeenHitThisFrame(IntPtr _this,string SyncGroup,string MarkerName);
public  bool HasMarkerBeenHitThisFrame(string SyncGroup,string MarkerName)
{
	CheckIsValid();
	int ___ret = HasMarkerBeenHitThisFrame(_this.Get(),SyncGroup,MarkerName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetTimeToClosestMarker(IntPtr _this,string SyncGroup,string MarkerName,out float OutMarkerTime);
/// <summary>--- AI communication end ---</summary>
public  bool GetTimeToClosestMarker(string SyncGroup,string MarkerName,out float OutMarkerTime)
{
	CheckIsValid();
	int ___ret = GetTimeToClosestMarker(_this.Get(),SyncGroup,MarkerName,out OutMarkerTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float CalculateDirection(IntPtr _this,ref FVector Velocity,ref FRotator BaseRotation);
/// <summary>
/// Returns degree of the angle betwee velocity and Rotation forward vector
/// The range of return will be from [-180, 180], and this can be used to feed blendspace directional value
/// </summary>
public  float CalculateDirection(FVector Velocity,FRotator BaseRotation)
{
	CheckIsValid();
	float ___ret = CalculateDirection(_this.Get(),ref Velocity,ref BaseRotation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMorphTargets(IntPtr _this);
/// <summary>Clears the current morph targets.</summary>
public  void ClearMorphTargets()
{
	CheckIsValid();
	ClearMorphTargets(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMorphTarget(IntPtr _this,string MorphTargetName,float Value);
/// <summary>Sets a morph target to a certain weight.</summary>
public  void SetMorphTarget(string MorphTargetName,float Value)
{
	CheckIsValid();
	SetMorphTarget(_this.Get(),MorphTargetName,Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetCurrentStateName(IntPtr _this,int MachineIndex);
/// <summary>Returns the name of a currently active state in a state machine.</summary>
public  string GetCurrentStateName(int MachineIndex)
{
	CheckIsValid();
	string ___ret = GetCurrentStateName(_this.Get(),MachineIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetCurrentStateElapsedTime(IntPtr _this,int MachineIndex);
public  float GetCurrentStateElapsedTime(int MachineIndex)
{
	CheckIsValid();
	float ___ret = GetCurrentStateElapsedTime(_this.Get(),MachineIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetStateWeight(IntPtr _this,int MachineIndex,int StateIndex);
public  float GetStateWeight(int MachineIndex,int StateIndex)
{
	CheckIsValid();
	float ___ret = GetStateWeight(_this.Get(),MachineIndex,StateIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnimAssetPlayerTimeFromEndFraction(IntPtr _this,IntPtr AnimAsset,float CurrentTime);
public static float GetAnimAssetPlayerTimeFromEndFraction(UAnimationAsset AnimAsset,float CurrentTime)
{
	float ___ret = GetAnimAssetPlayerTimeFromEndFraction(IntPtr.Zero,AnimAsset,CurrentTime);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnimAssetPlayerTimeFromEnd(IntPtr _this,IntPtr AnimAsset,float CurrentTime);
public  float GetAnimAssetPlayerTimeFromEnd(UAnimationAsset AnimAsset,float CurrentTime)
{
	CheckIsValid();
	float ___ret = GetAnimAssetPlayerTimeFromEnd(_this.Get(),AnimAsset,CurrentTime);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnimAssetPlayerTimeFraction(IntPtr _this,IntPtr AnimAsset,float CurrentTime);
public static float GetAnimAssetPlayerTimeFraction(UAnimationAsset AnimAsset,float CurrentTime)
{
	float ___ret = GetAnimAssetPlayerTimeFraction(IntPtr.Zero,AnimAsset,CurrentTime);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnimAssetPlayerLength(IntPtr _this,IntPtr AnimAsset);
public static float GetAnimAssetPlayerLength(UAnimationAsset AnimAsset)
{
	float ___ret = GetAnimAssetPlayerLength(IntPtr.Zero,AnimAsset);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetCurveValue(IntPtr _this,string CurveName);
/// <summary>Returns the value of a named curve.</summary>
public  float GetCurveValue(string CurveName)
{
	CheckIsValid();
	float ___ret = GetCurveValue(_this.Get(),CurveName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRelevantAnimTimeFraction(IntPtr _this,int MachineIndex,int StateIndex);
/// <summary>Get the current accumulated time as a fraction of the length of the most relevant animation in the source state</summary>
public  float GetRelevantAnimTimeFraction(int MachineIndex,int StateIndex)
{
	CheckIsValid();
	float ___ret = GetRelevantAnimTimeFraction(_this.Get(),MachineIndex,StateIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRelevantAnimTime(IntPtr _this,int MachineIndex,int StateIndex);
/// <summary>Get the current accumulated time in seconds for the most relevant animation in the source state</summary>
public  float GetRelevantAnimTime(int MachineIndex,int StateIndex)
{
	CheckIsValid();
	float ___ret = GetRelevantAnimTime(_this.Get(),MachineIndex,StateIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRelevantAnimLength(IntPtr _this,int MachineIndex,int StateIndex);
/// <summary>Get the length in seconds of the most relevant animation in the source state</summary>
public  float GetRelevantAnimLength(int MachineIndex,int StateIndex)
{
	CheckIsValid();
	float ___ret = GetRelevantAnimLength(_this.Get(),MachineIndex,StateIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRelevantAnimTimeRemainingFraction(IntPtr _this,int MachineIndex,int StateIndex);
/// <summary>Get the time remaining as a fraction of the duration for the most relevant animation in the source state</summary>
public  float GetRelevantAnimTimeRemainingFraction(int MachineIndex,int StateIndex)
{
	CheckIsValid();
	float ___ret = GetRelevantAnimTimeRemainingFraction(_this.Get(),MachineIndex,StateIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRelevantAnimTimeRemaining(IntPtr _this,int MachineIndex,int StateIndex);
/// <summary>Get the time remaining in seconds for the most relevant animation in the source state</summary>
public  float GetRelevantAnimTimeRemaining(int MachineIndex,int StateIndex)
{
	CheckIsValid();
	float ___ret = GetRelevantAnimTimeRemaining(_this.Get(),MachineIndex,StateIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceTransitionTimeElapsedFraction(IntPtr _this,int MachineIndex,int TransitionIndex);
/// <summary>Get the elapsed time as a fraction of the crossfade duration of a specified transition</summary>
public  float GetInstanceTransitionTimeElapsedFraction(int MachineIndex,int TransitionIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceTransitionTimeElapsedFraction(_this.Get(),MachineIndex,TransitionIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceTransitionTimeElapsed(IntPtr _this,int MachineIndex,int TransitionIndex);
/// <summary>Get the elapsed time in seconds of a specified transition</summary>
public  float GetInstanceTransitionTimeElapsed(int MachineIndex,int TransitionIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceTransitionTimeElapsed(_this.Get(),MachineIndex,TransitionIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceTransitionCrossfadeDuration(IntPtr _this,int MachineIndex,int TransitionIndex);
/// <summary>Get the crossfade duration of a specified transition</summary>
public  float GetInstanceTransitionCrossfadeDuration(int MachineIndex,int TransitionIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceTransitionCrossfadeDuration(_this.Get(),MachineIndex,TransitionIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceCurrentStateElapsedTime(IntPtr _this,int MachineIndex);
/// <summary>Get the current elapsed time of a state within the specified state machine</summary>
public  float GetInstanceCurrentStateElapsedTime(int MachineIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceCurrentStateElapsedTime(_this.Get(),MachineIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceStateWeight(IntPtr _this,int MachineIndex,int StateIndex);
/// <summary>Get the blend weight of a specified state</summary>
public  float GetInstanceStateWeight(int MachineIndex,int StateIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceStateWeight(_this.Get(),MachineIndex,StateIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceMachineWeight(IntPtr _this,int MachineIndex);
/// <summary>Get the blend weight of a specified state machine</summary>
public  float GetInstanceMachineWeight(int MachineIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceMachineWeight(_this.Get(),MachineIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceAssetPlayerTimeFromEndFraction(IntPtr _this,int AssetPlayerIndex);
/// <summary>Get the time as a fraction of the asset length of an animation in an asset player node</summary>
public  float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceAssetPlayerTimeFromEndFraction(_this.Get(),AssetPlayerIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceAssetPlayerTimeFromEnd(IntPtr _this,int AssetPlayerIndex);
/// <summary>Get the time in seconds from the end of an animation in an asset player node</summary>
public  float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceAssetPlayerTimeFromEnd(_this.Get(),AssetPlayerIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceAssetPlayerTimeFraction(IntPtr _this,int AssetPlayerIndex);
/// <summary>Get the current accumulated time as a fraction for an asset player node</summary>
public  float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceAssetPlayerTimeFraction(_this.Get(),AssetPlayerIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceAssetPlayerTime(IntPtr _this,int AssetPlayerIndex);
/// <summary>Get the current accumulated time in seconds for an asset player node</summary>
public  float GetInstanceAssetPlayerTime(int AssetPlayerIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceAssetPlayerTime(_this.Get(),AssetPlayerIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInstanceAssetPlayerLength(IntPtr _this,int AssetPlayerIndex);
/// <summary>Gets the length in seconds of the asset referenced in an asset player node</summary>
public  float GetInstanceAssetPlayerLength(int AssetPlayerIndex)
{
	CheckIsValid();
	float ___ret = GetInstanceAssetPlayerLength(_this.Get(),AssetPlayerIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRootMotionMode(IntPtr _this,int Value);
/// <summary>Set RootMotionMode</summary>
public  void SetRootMotionMode(ERootMotionMode Value)
{
	CheckIsValid();
	SetRootMotionMode(_this.Get(),(int)Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Montage_GetCurrentSection(IntPtr _this,IntPtr Montage);
/// <summary>Returns the name of the current animation montage section.</summary>
public  string Montage_GetCurrentSection(UAnimMontage Montage)
{
	CheckIsValid();
	string ___ret = Montage_GetCurrentSection(_this.Get(),Montage);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Montage_IsPlaying(IntPtr _this,IntPtr Montage);
/// <summary>
/// Returns true if the animation montage is currently active and playing.
///       If reference is NULL, it will return true is ANY montage is currently active and playing.
/// </summary>
public  bool Montage_IsPlaying(UAnimMontage Montage)
{
	CheckIsValid();
	int ___ret = Montage_IsPlaying(_this.Get(),Montage);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Montage_IsActive(IntPtr _this,IntPtr Montage);
/// <summary>Returns true if the animation montage is active. If the Montage reference is NULL, it will return true if any Montage is active.</summary>
public  bool Montage_IsActive(UAnimMontage Montage)
{
	CheckIsValid();
	int ___ret = Montage_IsActive(_this.Get(),Montage);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Montage_SetPlayRate(IntPtr _this,IntPtr Montage,float NewPlayRate);
/// <summary>Change AnimMontage play rate. NewPlayRate = 1.0 is the default playback rate.</summary>
public  void Montage_SetPlayRate(UAnimMontage Montage,float NewPlayRate=1.000000f)
{
	CheckIsValid();
	Montage_SetPlayRate(_this.Get(),Montage,NewPlayRate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Montage_SetNextSection(IntPtr _this,string SectionNameToChange,string NextSection,IntPtr Montage);
/// <summary>
/// Relink new next section AFTER SectionNameToChange in run-time
///     You can link section order the way you like in editor, but in run-time if you'd like to change it dynamically,
///     use this function to relink the next section
///     For example, you can have Start->Loop->Loop->Loop.... but when you want it to end, you can relink
///     next section of Loop to be End to finish the montage, in which case, it stops looping by Loop->End.
/// @param SectionNameToChange : This should be the name of the Montage Section after which you want to insert a new next section
/// @param NextSection   : new next section
/// </summary>
public  void Montage_SetNextSection(string SectionNameToChange,string NextSection,UAnimMontage Montage)
{
	CheckIsValid();
	Montage_SetNextSection(_this.Get(),SectionNameToChange,NextSection,Montage);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Montage_JumpToSectionsEnd(IntPtr _this,string SectionName,IntPtr Montage);
/// <summary>Makes a montage jump to the end of a named section. If Montage reference is NULL, it will do that to all active montages.</summary>
public  void Montage_JumpToSectionsEnd(string SectionName,UAnimMontage Montage)
{
	CheckIsValid();
	Montage_JumpToSectionsEnd(_this.Get(),SectionName,Montage);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Montage_JumpToSection(IntPtr _this,string SectionName,IntPtr Montage);
/// <summary>Makes a montage jump to a named section. If Montage reference is NULL, it will do that to all active montages.</summary>
public  void Montage_JumpToSection(string SectionName,UAnimMontage Montage)
{
	CheckIsValid();
	Montage_JumpToSection(_this.Get(),SectionName,Montage);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Montage_Resume(IntPtr _this,IntPtr Montage);
/// <summary>Resumes a paused animation montage. If reference is NULL, it will resume ALL active montages.</summary>
public  void Montage_Resume(UAnimMontage Montage)
{
	CheckIsValid();
	Montage_Resume(_this.Get(),Montage);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Montage_Pause(IntPtr _this,IntPtr Montage);
/// <summary>Pauses the animation montage. If reference is NULL, it will pause ALL active montages.</summary>
public  void Montage_Pause(UAnimMontage Montage)
{
	CheckIsValid();
	Montage_Pause(_this.Get(),Montage);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Montage_Stop(IntPtr _this,float InBlendOutTime,IntPtr Montage);
/// <summary>Stops the animation montage. If reference is NULL, it will stop ALL active montages.</summary>
public  void Montage_Stop(float InBlendOutTime,UAnimMontage Montage)
{
	CheckIsValid();
	Montage_Stop(_this.Get(),InBlendOutTime,Montage);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Montage_Play(IntPtr _this,IntPtr MontageToPlay,float InPlayRate,int ReturnValueType);
/// <summary>Plays an animation montage. Returns the length of the animation montage in seconds. Returns 0.f if failed to play.</summary>
public  float Montage_Play(UAnimMontage MontageToPlay,float InPlayRate=1.000000f,EMontagePlayReturnType ReturnValueType=EMontagePlayReturnType.MontageLength)
{
	CheckIsValid();
	float ___ret = Montage_Play(_this.Get(),MontageToPlay,InPlayRate,(int)ReturnValueType);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayingSlotAnimation(IntPtr _this,IntPtr Asset,string SlotNodeName);
/// <summary>Return true if it's playing the slot animation</summary>
public  bool IsPlayingSlotAnimation(UAnimSequenceBase Asset,string SlotNodeName)
{
	CheckIsValid();
	int ___ret = IsPlayingSlotAnimation(_this.Get(),Asset,SlotNodeName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopSlotAnimation(IntPtr _this,float InBlendOutTime,string SlotNodeName);
/// <summary>Stops currently playing slot animation slot or all</summary>
public  void StopSlotAnimation(float InBlendOutTime=0.250000f,string SlotNodeName="None")
{
	CheckIsValid();
	StopSlotAnimation(_this.Get(),InBlendOutTime,SlotNodeName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr PlaySlotAnimationAsDynamicMontage(IntPtr _this,IntPtr Asset,string SlotNodeName,float BlendInTime,float BlendOutTime,float InPlayRate,int LoopCount,float BlendOutTriggerTime);
/// <summary>Play normal animation asset on the slot node by creating a dynamic UAnimMontage. You can only play one asset (whether montage or animsequence) at a time per SlotGroup.</summary>
public  UAnimMontage PlaySlotAnimationAsDynamicMontage(UAnimSequenceBase Asset,string SlotNodeName,float BlendInTime=0.250000f,float BlendOutTime=0.250000f,float InPlayRate=1.000000f,int LoopCount=1,float BlendOutTriggerTime=-1.000000f)
{
	CheckIsValid();
	IntPtr ___ret = PlaySlotAnimationAsDynamicMontage(_this.Get(),Asset,SlotNodeName,BlendInTime,BlendOutTime,InPlayRate,LoopCount,BlendOutTriggerTime);
	if(___ret==IntPtr.Zero) return null; UAnimMontage ___ret2= new UAnimMontage(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float PlaySlotAnimation(IntPtr _this,IntPtr Asset,string SlotNodeName,float BlendInTime,float BlendOutTime,float InPlayRate,int LoopCount);
public  float PlaySlotAnimation(UAnimSequenceBase Asset,string SlotNodeName,float BlendInTime=0.250000f,float BlendOutTime=0.250000f,float InPlayRate=1.000000f,int LoopCount=1)
{
	CheckIsValid();
	float ___ret = PlaySlotAnimation(_this.Get(),Asset,SlotNodeName,BlendInTime,BlendOutTime,InPlayRate,LoopCount);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwningComponent(IntPtr _this);
/// <summary>Returns the skeletal mesh component that has created this AnimInstance</summary>
public  USkeletalMeshComponent GetOwningComponent()
{
	CheckIsValid();
	IntPtr ___ret = GetOwningComponent(_this.Get());
	if(___ret==IntPtr.Zero) return null; USkeletalMeshComponent ___ret2= new USkeletalMeshComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwningActor(IntPtr _this);
/// <summary>Returns the owning actor of this AnimInstance</summary>
public  AActor GetOwningActor()
{
	CheckIsValid();
	IntPtr ___ret = GetOwningActor(_this.Get());
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr TryGetPawnOwner(IntPtr _this);
/// <summary>kismet event functions</summary>
public  APawn TryGetPawnOwner()
{
	CheckIsValid();
	IntPtr ___ret = TryGetPawnOwner(_this.Get());
	if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
