#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AMatineeActor
	{
		static readonly int MatineeData__Offset;
		/// <summary>The matinee data used by this actor</summary>
		public UInterpData MatineeData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MatineeData__Offset); if (v == IntPtr.Zero)return null; UInterpData retValue = new UInterpData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + MatineeData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + MatineeData__Offset, value._this.Get()); }
			
		}
		
		static readonly int MatineeControllerName__Offset;
		/// <summary>Name of controller node in level script, used to know what function to try and find for events</summary>
		public FName MatineeControllerName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+MatineeControllerName__Offset, typeof(FName));}
			
		}
		
		static readonly int PlayRate__Offset;
		/// <summary>Time multiplier for playback.</summary>
		public float PlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlayRate__Offset, false);}
			
		}
		
		static readonly int bPlayOnLevelLoad__Offset;
		/// <summary>If true, the matinee will play when the level is loaded.</summary>
		public bool bPlayOnLevelLoad
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlayOnLevelLoad__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPlayOnLevelLoad__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bForceStartPos__Offset;
		/// <summary>Lets you force the sequence to always start at ForceStartPosition</summary>
		public bool bForceStartPos
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceStartPos__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceStartPos__Offset, 1,0,2,2);}
			
		}
		
		static readonly int ForceStartPosition__Offset;
		/// <summary>Time position to always start at if bForceStartPos is set to true.</summary>
		public float ForceStartPosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ForceStartPosition__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForceStartPosition__Offset, false);}
			
		}
		
		static readonly int bLooping__Offset;
		/// <summary>
		/// If sequence should pop back to beginning when finished.
		/// Note, if true, will never get Completed/Reversed events - sequence must be explicitly Stopped.
		/// </summary>
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRewindOnPlay__Offset;
		/// <summary>If true, sequence will rewind itself back to the start each time the Play input is activated.</summary>
		public bool bRewindOnPlay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRewindOnPlay__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRewindOnPlay__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bNoResetOnRewind__Offset;
		/// <summary>
		/// If true, when rewinding this interpolation, reset the 'initial positions' of any RelateToInitial movements to the current location.
		/// This allows the next loop of movement to proceed from the current locations.
		/// </summary>
		public bool bNoResetOnRewind
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoResetOnRewind__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNoResetOnRewind__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bRewindIfAlreadyPlaying__Offset;
		/// <summary>
		/// Only used if bRewindOnPlay if true. Defines what should happen if the Play input is activated while currently playing.
		/// If true, hitting Play while currently playing will pop the position back to the start and begin playback over again.
		/// If false, hitting Play while currently playing will do nothing.
		/// </summary>
		public bool bRewindIfAlreadyPlaying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRewindIfAlreadyPlaying__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRewindIfAlreadyPlaying__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bDisableRadioFilter__Offset;
		/// <summary>If true, disables the realtime radio effect</summary>
		public bool bDisableRadioFilter
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableRadioFilter__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableRadioFilter__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bClientSideOnly__Offset;
		/// <summary>
		/// Indicates that this interpolation does not affect gameplay. This means that:
		/// -it is not replicated via MatineeActor
		/// -it is not ticked if no affected Actors are visible
		/// -on dedicated servers, it is completely ignored
		/// </summary>
		public bool bClientSideOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientSideOnly__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClientSideOnly__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bSkipUpdateIfNotVisible__Offset;
		/// <summary>if bClientSideOnly is true, whether this matinee should be completely skipped if none of the affected Actors are visible</summary>
		public bool bSkipUpdateIfNotVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSkipUpdateIfNotVisible__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSkipUpdateIfNotVisible__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bIsSkippable__Offset;
		/// <summary>Lets you skip the matinee with the CANCELMATINEE exec command. Triggers all events to the end along the way.</summary>
		public bool bIsSkippable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSkippable__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsSkippable__Offset, 1,0,128,128);}
			
		}
		
		static readonly int PreferredSplitScreenNum__Offset;
		/// <summary>Preferred local viewport number (when split screen is active) the director track should associate with, or zero for 'all'.</summary>
		public int PreferredSplitScreenNum
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreferredSplitScreenNum__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreferredSplitScreenNum__Offset, false);}
			
		}
		
		static readonly int bDisableMovementInput__Offset;
		/// <summary>Disable Input from player during play</summary>
		public bool bDisableMovementInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableMovementInput__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableMovementInput__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDisableLookAtInput__Offset;
		/// <summary>Disable LookAt Input from player during play</summary>
		public bool bDisableLookAtInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableLookAtInput__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableLookAtInput__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bHidePlayer__Offset;
		/// <summary>Hide Player Pawn during play</summary>
		public bool bHidePlayer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHidePlayer__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHidePlayer__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bHideHud__Offset;
		/// <summary>Hide HUD during play</summary>
		public bool bHideHud
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHideHud__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHideHud__Offset, 1,0,8,8);}
			
		}
		
		static readonly int GroupActorInfos__Offset;
		/// <summary>@todo UE4 matinee - shouldnt be directly editable.  Needs a nice interface in matinee</summary>
		public TStructArray<FInterpGroupActorInfo> GroupActorInfos
		{
			get{ CheckIsValid();return new TStructArray<FInterpGroupActorInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GroupActorInfos__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GroupActorInfos__Offset, false);}
			
		}
		
		static readonly int bShouldShowGore__Offset;
		/// <summary>Cached value that indicates whether or not gore was enabled when the sequence was started</summary>
		public bool bShouldShowGore
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldShowGore__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int GroupInst__Offset;
		/// <summary>Instance data for interp groups. One for each variable/group combination.</summary>
		public TObjectArray<UInterpGroupInst>  GroupInst
		{
					get{ CheckIsValid();return new TObjectArray<UInterpGroupInst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GroupInst__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GroupInst__Offset, false);}
			
		}
		
		static readonly int CameraCuts__Offset;
		/// <summary>Contains the camera world-position for each camera cut in the cinematic.</summary>
		public TStructArray<FCameraCutInfo> CameraCuts
		{
			get{ CheckIsValid();return new TStructArray<FCameraCutInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CameraCuts__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CameraCuts__Offset, false);}
			
		}
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bIsBeingEdited__Offset;
		public bool bIsBeingEdited
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsBeingEdited__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsScrubbing__Offset;
		/// <summary>Set by the editor when scrubbing data</summary>
		public bool bIsScrubbing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsScrubbing__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsPlaying__Offset;
		/// <summary>properties that may change on InterpAction that we need to notify clients about, since the object's properties will not be replicated</summary>
		public bool bIsPlaying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsPlaying__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsPlaying__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bReversePlayback__Offset;
		public bool bReversePlayback
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReversePlayback__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bPaused__Offset;
		public bool bPaused
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPaused__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bPendingStop__Offset;
		/// <summary>The below property is deprecated and will be removed in 4.9.</summary>
		public bool bPendingStop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPendingStop__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int InterpPosition__Offset;
		public float InterpPosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InterpPosition__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpPosition__Offset, false);}
			
		}
		
		static readonly int ReplicationForceIsPlaying__Offset;
		/// <summary>Counter to indicate that play count has changed. Used to work around single frames that go from play-stop-play where bIsPlaying won't get replicated.</summary>
		public byte ReplicationForceIsPlaying
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+ReplicationForceIsPlaying__Offset, typeof(byte));}
			
		}
		
		static readonly int OnPlay__Offset;
		/// <summary>Event triggered when the matinee is played for whatever reason</summary>
		public FMulticastScriptDelegate OnPlay
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnPlay__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnPlay__Offset, false);}
			
		}
		
		static readonly int OnStop__Offset;
		/// <summary>Event triggered when the matinee is stopped for whatever reason</summary>
		public FMulticastScriptDelegate OnStop
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnStop__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnStop__Offset, false);}
			
		}
		
		static readonly int OnPause__Offset;
		/// <summary>Event triggered when the matinee is paused for whatever reason</summary>
		public FMulticastScriptDelegate OnPause
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnPause__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnPause__Offset, false);}
			
		}
		
		static AMatineeActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MatineeActor");
			MatineeData__Offset=GetPropertyOffset(NativeClassPtr,"MatineeData");
			MatineeControllerName__Offset=GetPropertyOffset(NativeClassPtr,"MatineeControllerName");
			PlayRate__Offset=GetPropertyOffset(NativeClassPtr,"PlayRate");
			bPlayOnLevelLoad__Offset=GetPropertyOffset(NativeClassPtr,"bPlayOnLevelLoad");
			bForceStartPos__Offset=GetPropertyOffset(NativeClassPtr,"bForceStartPos");
			ForceStartPosition__Offset=GetPropertyOffset(NativeClassPtr,"ForceStartPosition");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			bRewindOnPlay__Offset=GetPropertyOffset(NativeClassPtr,"bRewindOnPlay");
			bNoResetOnRewind__Offset=GetPropertyOffset(NativeClassPtr,"bNoResetOnRewind");
			bRewindIfAlreadyPlaying__Offset=GetPropertyOffset(NativeClassPtr,"bRewindIfAlreadyPlaying");
			bDisableRadioFilter__Offset=GetPropertyOffset(NativeClassPtr,"bDisableRadioFilter");
			bClientSideOnly__Offset=GetPropertyOffset(NativeClassPtr,"bClientSideOnly");
			bSkipUpdateIfNotVisible__Offset=GetPropertyOffset(NativeClassPtr,"bSkipUpdateIfNotVisible");
			bIsSkippable__Offset=GetPropertyOffset(NativeClassPtr,"bIsSkippable");
			PreferredSplitScreenNum__Offset=GetPropertyOffset(NativeClassPtr,"PreferredSplitScreenNum");
			bDisableMovementInput__Offset=GetPropertyOffset(NativeClassPtr,"bDisableMovementInput");
			bDisableLookAtInput__Offset=GetPropertyOffset(NativeClassPtr,"bDisableLookAtInput");
			bHidePlayer__Offset=GetPropertyOffset(NativeClassPtr,"bHidePlayer");
			bHideHud__Offset=GetPropertyOffset(NativeClassPtr,"bHideHud");
			GroupActorInfos__Offset=GetPropertyOffset(NativeClassPtr,"GroupActorInfos");
			bShouldShowGore__Offset=GetPropertyOffset(NativeClassPtr,"bShouldShowGore");
			GroupInst__Offset=GetPropertyOffset(NativeClassPtr,"GroupInst");
			CameraCuts__Offset=GetPropertyOffset(NativeClassPtr,"CameraCuts");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			bIsBeingEdited__Offset=GetPropertyOffset(NativeClassPtr,"bIsBeingEdited");
			bIsScrubbing__Offset=GetPropertyOffset(NativeClassPtr,"bIsScrubbing");
			bIsPlaying__Offset=GetPropertyOffset(NativeClassPtr,"bIsPlaying");
			bReversePlayback__Offset=GetPropertyOffset(NativeClassPtr,"bReversePlayback");
			bPaused__Offset=GetPropertyOffset(NativeClassPtr,"bPaused");
			bPendingStop__Offset=GetPropertyOffset(NativeClassPtr,"bPendingStop");
			InterpPosition__Offset=GetPropertyOffset(NativeClassPtr,"InterpPosition");
			ReplicationForceIsPlaying__Offset=GetPropertyOffset(NativeClassPtr,"ReplicationForceIsPlaying");
			OnPlay__Offset=GetPropertyOffset(NativeClassPtr,"OnPlay");
			OnStop__Offset=GetPropertyOffset(NativeClassPtr,"OnStop");
			OnPause__Offset=GetPropertyOffset(NativeClassPtr,"OnPause");
			
		}
		
	}
	
}
#endif
#endif
