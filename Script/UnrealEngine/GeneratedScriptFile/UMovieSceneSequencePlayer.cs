using System;
namespace UnrealEngine
{
	public partial class UMovieSceneSequencePlayer:UObject
	{
		/// <summary>Get the offset within the level sequence to finish playing</summary>
		public extern float GetPlaybackEnd();
		/// <summary>Get the offset within the level sequence to start playing</summary>
		public extern float GetPlaybackStart();
		/// <summary>
		/// Sets the range in time to be played back by this player, overriding the default range stored in the asset
		/// @param       NewStartTime    The new starting time for playback
		/// @param       NewEndTime              The new ending time for playback.  Must be larger than the start time.
		/// </summary>
		public extern void SetPlaybackRange(float NewStartTime,float NewEndTime);
		/// <summary>
		/// Set the playback rate of this player. Negative values will play the animation in reverse.
		/// @param PlayRate - The new rate of playback for the animation.
		/// </summary>
		public extern void SetPlayRate(float PlayRate);
		/// <summary>Get the playback rate of this player.</summary>
		public extern float GetPlayRate();
		/// <summary>Get the playback length of the sequence</summary>
		public extern float GetLength();
		/// <summary>Check whether the sequence is actively playing.</summary>
		public extern bool IsPlaying();
		/// <summary>
		/// Set the current playback position
		/// @param NewPlaybackPosition - The new playback position to set.
		/// If the animation is currently playing, it will continue to do so from the new position
		/// </summary>
		public extern void SetPlaybackPosition(float NewPlaybackPosition);
		/// <summary>Get the current playback position</summary>
		public extern float GetPlaybackPosition();
		/// <summary>Stop playback.</summary>
		public extern void Stop();
		/// <summary>Pause playback.</summary>
		public extern void Pause();
		/// <summary>Start playback from the current time cursor position, using the current play rate. Does not update the animation until next tick.</summary>
		public extern void StartPlayingNextTick();
		/// <summary>
		/// Start playback from the current time cursor position, looping the specified number of times.
		/// @param NumLoops - The number of loops to play. -1 indicates infinite looping.
		/// </summary>
		public extern void PlayLooping(int NumLoops=-1);
		/// <summary>Changes the direction of playback (go in reverse if it was going forward, or vice versa)</summary>
		public extern void ChangePlaybackDirection();
		/// <summary>Reverse playback.</summary>
		public extern void PlayReverse();
		/// <summary>Start playback forwards from the current time cursor position, using the current play rate.</summary>
		public extern void Play();
		/// <summary>Whether we're currently playing. If false, then sequence playback is paused or was never started.</summary>
		public bool bIsPlaying;
		
		/// <summary>Whether we're currently playing in reverse.</summary>
		public bool bReversePlayback;
		
		/// <summary>True where we're waiting for the first update of the sequence after calling StartPlayingNextTick.</summary>
		public bool bPendingFirstUpdate;
		
		/// <summary>The sequence to play back</summary>
		public UMovieSceneSequence Sequence;
		
		/// <summary>The current time cursor position within the sequence (in seconds)</summary>
		public float TimeCursorPosition;
		
		/// <summary>Time time at which to start playing the sequence (defaults to the lower bound of the sequence's play range)</summary>
		public float StartTime;
		
		/// <summary>Time time at which to end playing the sequence (defaults to the upper bound of the sequence's play range)</summary>
		public float EndTime;
		
		/// <summary>The number of times we have looped in the current playback</summary>
		public int CurrentNumLoops;
		
		/// <summary>Specific playback settings for the animation.</summary>
		public FMovieSceneSequencePlaybackSettings PlaybackSettings;
		
		
	}
	
}
