using System;
namespace UnrealEngine
{
	public partial class UTimelineComponent:UActorComponent
	{
		/// <summary>Update a certain linear color track's curve</summary>
		public extern void SetLinearColorCurve(UCurveLinearColor NewLinearColorCurve,FName LinearColorTrackName);
		/// <summary>Update a certain vector track's curve</summary>
		public extern void SetVectorCurve(UCurveVector NewVectorCurve,FName VectorTrackName);
		/// <summary>Update a certain float track's curve</summary>
		public extern void SetFloatCurve(UCurveFloat NewFloatCurve,FName FloatTrackName);
		/// <summary>Get whether to ignore time dilation.</summary>
		public extern bool GetIgnoreTimeDilation();
		/// <summary>Set whether to ignore time dilation.</summary>
		public extern void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation);
		/// <summary>Sets the length mode of the timeline</summary>
		public extern void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode);
		/// <summary>Set length of the timeline</summary>
		public extern void SetTimelineLength(float NewLength);
		/// <summary>Get length of the timeline</summary>
		public extern float GetTimelineLength();
		/// <summary>Set the new playback position time to use</summary>
		public extern void SetNewTime(float NewTime);
		/// <summary>Get the current play rate for this timeline</summary>
		public extern float GetPlayRate();
		/// <summary>Sets the new play rate for this timeline</summary>
		public extern void SetPlayRate(float NewRate);
		/// <summary>Get whether we are looping or not</summary>
		public extern bool IsLooping();
		/// <summary>true means we would loop, false means we should not.</summary>
		public extern void SetLooping(bool bNewLooping);
		/// <summary>Get the current playback position of the Timeline</summary>
		public extern float GetPlaybackPosition();
		/// <summary>
		/// Jump to a position in the timeline.
		/// @param bFireEvents If true, event functions that are between current position and new playback position will fire.
		/// @param bFireUpdate If true, the update output exec will fire after setting the new playback position.
		/// </summary>
		public extern void SetPlaybackPosition(float NewPosition,bool bFireEvents,bool bFireUpdate=true);
		/// <summary>Get whether we are reversing or not</summary>
		public extern bool IsReversing();
		/// <summary>Get whether this timeline is playing or not.</summary>
		public extern bool IsPlaying();
		/// <summary>Stop playback of timeline</summary>
		public extern void Stop();
		/// <summary>Start playback of timeline in reverse from the end</summary>
		public extern void ReverseFromEnd();
		/// <summary>Start playback of timeline in reverse</summary>
		public extern void Reverse();
		/// <summary>Start playback of timeline from the start</summary>
		public extern void PlayFromStart();
		/// <summary>Start playback of timeline</summary>
		public extern void Play();
		/// <summary>The actual timeline structure</summary>
		public FTimeline TheTimeline;
		
		/// <summary>True if global time dilation should be ignored by this timeline, false otherwise.</summary>
		public bool bIgnoreTimeDilation;
		
		
	}
	
}
