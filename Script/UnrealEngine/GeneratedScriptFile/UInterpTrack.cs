using System;
namespace UnrealEngine
{
	public partial class UInterpTrack:UObject
	{
		public TSubclassOf<UInterpTrackInst>  TrackInstClass;
		
		/// <summary>Sets the condition that must be met for this track to be enabled</summary>
		public ETrackActiveCondition ActiveCondition;
		
		/// <summary>Title of track type.</summary>
		public FString TrackTitle;
		
		/// <summary>Whether there may only be one of this track in an UInterpGroup.</summary>
		public bool bOnePerGroup;
		
		/// <summary>If this track can only exist inside the Director group.</summary>
		public bool bDirGroupOnly;
		
		/// <summary>Whether or not this track should actually update the target actor.</summary>
		public bool bDisableTrack;
		
		/// <summary>Whether or not this track is selected in the editor.</summary>
		public bool bIsSelected;
		
		public UTexture2D TrackIcon;
		
		/// <summary>If true, the  AActor  this track is working on will have BeginAnimControl/FinishAnimControl called on it.</summary>
		public bool bIsAnimControlTrack;
		
		/// <summary>If this track can only exist as a sub track.</summary>
		public bool bSubTrackOnly;
		
		/// <summary>Whether or not this track is visible in the editor.</summary>
		public bool bVisible;
		
		/// <summary>Whether or not this track is recording in the editor.</summary>
		public bool bIsRecording;
		
		/// <summary>If this track is collapsed. (Only applies  to tracks with subtracks).</summary>
		public bool bIsCollapsed;
		
		
	}
	
}
