#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrack
	{
		static readonly int SubTracks__Offset;
		/// <summary>A list of subtracks that belong to this track</summary>
		public TObjectArray<UInterpTrack>  SubTracks
		{
					get{ CheckIsValid();return new TObjectArray<UInterpTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubTracks__Offset, false);}
			
		}
		
		static readonly int SubTrackGroups__Offset;
		/// <summary>A list of subtrack groups (for editor UI organization only)</summary>
		public TStructArray<FSubTrackGroup> SubTrackGroups
		{
			get{ CheckIsValid();return new TStructArray<FSubTrackGroup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubTrackGroups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubTrackGroups__Offset, false);}
			
		}
		
		static readonly int SupportedSubTracks__Offset;
		/// <summary>A list of supported tracks that can be a subtrack of this track.</summary>
		public TStructArray<FSupportedSubTrackInfo> SupportedSubTracks
		{
			get{ CheckIsValid();return new TStructArray<FSupportedSubTrackInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SupportedSubTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SupportedSubTracks__Offset, false);}
			
		}
		
		static readonly int TrackInstClass__Offset;
		public TSubclassOf<UInterpTrackInst>  TrackInstClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TrackInstClass__Offset); return v; }
			
		}
		
		static readonly int ActiveCondition__Offset;
		/// <summary>Sets the condition that must be met for this track to be enabled</summary>
		public ETrackActiveCondition ActiveCondition
		{
			get{ CheckIsValid();return (ETrackActiveCondition)Marshal.PtrToStructure(_this.Get()+ActiveCondition__Offset, typeof(ETrackActiveCondition));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ActiveCondition__Offset, false);}
			
		}
		
		static readonly int TrackTitle__Offset;
		/// <summary>Title of track type.</summary>
		public FString TrackTitle
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+TrackTitle__Offset, typeof(FString));}
			
		}
		
		static readonly int bOnePerGroup__Offset;
		/// <summary>Whether there may only be one of this track in an UInterpGroup.</summary>
		public bool bOnePerGroup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnePerGroup__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bDirGroupOnly__Offset;
		/// <summary>If this track can only exist inside the Director group.</summary>
		public bool bDirGroupOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDirGroupOnly__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDisableTrack__Offset;
		/// <summary>Whether or not this track should actually update the target actor.</summary>
		public bool bDisableTrack
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableTrack__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsSelected__Offset;
		/// <summary>Whether or not this track is selected in the editor.</summary>
		public bool bIsSelected
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSelected__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int TrackIcon__Offset;
		public UTexture2D TrackIcon
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TrackIcon__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bIsAnimControlTrack__Offset;
		/// <summary>If true, the  AActor  this track is working on will have BeginAnimControl/FinishAnimControl called on it.</summary>
		public bool bIsAnimControlTrack
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsAnimControlTrack__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bSubTrackOnly__Offset;
		/// <summary>If this track can only exist as a sub track.</summary>
		public bool bSubTrackOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubTrackOnly__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bVisible__Offset;
		/// <summary>Whether or not this track is visible in the editor.</summary>
		public bool bVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVisible__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsRecording__Offset;
		/// <summary>Whether or not this track is recording in the editor.</summary>
		public bool bIsRecording
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsRecording__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bIsCollapsed__Offset;
		/// <summary>If this track is collapsed. (Only applies  to tracks with subtracks).</summary>
		public bool bIsCollapsed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsCollapsed__Offset, 1, 0, 16, 16);}
			
		}
		
		static UInterpTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrack");
			SubTracks__Offset=GetPropertyOffset(NativeClassPtr,"SubTracks");
			SubTrackGroups__Offset=GetPropertyOffset(NativeClassPtr,"SubTrackGroups");
			SupportedSubTracks__Offset=GetPropertyOffset(NativeClassPtr,"SupportedSubTracks");
			TrackInstClass__Offset=GetPropertyOffset(NativeClassPtr,"TrackInstClass");
			ActiveCondition__Offset=GetPropertyOffset(NativeClassPtr,"ActiveCondition");
			TrackTitle__Offset=GetPropertyOffset(NativeClassPtr,"TrackTitle");
			bOnePerGroup__Offset=GetPropertyOffset(NativeClassPtr,"bOnePerGroup");
			bDirGroupOnly__Offset=GetPropertyOffset(NativeClassPtr,"bDirGroupOnly");
			bDisableTrack__Offset=GetPropertyOffset(NativeClassPtr,"bDisableTrack");
			bIsSelected__Offset=GetPropertyOffset(NativeClassPtr,"bIsSelected");
			TrackIcon__Offset=GetPropertyOffset(NativeClassPtr,"TrackIcon");
			bIsAnimControlTrack__Offset=GetPropertyOffset(NativeClassPtr,"bIsAnimControlTrack");
			bSubTrackOnly__Offset=GetPropertyOffset(NativeClassPtr,"bSubTrackOnly");
			bVisible__Offset=GetPropertyOffset(NativeClassPtr,"bVisible");
			bIsRecording__Offset=GetPropertyOffset(NativeClassPtr,"bIsRecording");
			bIsCollapsed__Offset=GetPropertyOffset(NativeClassPtr,"bIsCollapsed");
			
		}
		
	}
	
}
#endif
#endif
