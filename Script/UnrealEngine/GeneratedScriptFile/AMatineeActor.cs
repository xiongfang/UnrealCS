using System;
namespace UnrealEngine
{
	public partial class AMatineeActor:AActor
	{
		/// <summary>Change the looping behaviour of this matinee</summary>
		public extern virtual void SetLoopingState(bool bNewLooping);
		/// <summary>Changes the direction of playback (go in reverse if it was going forward, or vice versa)</summary>
		public extern virtual void ChangePlaybackDirection();
		/// <summary>
		/// Set the position of the interpolation.
		/// @note if the interpolation is not currently active, this function doesn't send any Kismet events
		/// @param NewPosition the new position to set the interpolation to
		/// @param bJump if true, teleport to the new position (don't trigger any events between the old and new positions, etc)
		/// </summary>
		public extern void SetPosition(float NewPosition,bool bJump=false);
		/// <summary>Hold playback at its current position. Calling Pause again will continue playback in its current direction.</summary>
		public extern virtual void Pause();
		/// <summary>Similar to play, but the playback will go backwards until the beginning of the sequence is reached.</summary>
		public extern virtual void Reverse();
		/// <summary>Stops playback at the current position</summary>
		public extern virtual void Stop();
		/// <summary>
		/// Begin playback of the matinee. Only called in game.
		/// Will then advance Position by (PlayRate * Deltatime) each time the matinee is ticked.
		/// </summary>
		public extern virtual void Play();
		/// <summary>The matinee data used by this actor</summary>
		public UInterpData MatineeData;
		
		/// <summary>Name of controller node in level script, used to know what function to try and find for events</summary>
		public FName MatineeControllerName;
		
		/// <summary>Time multiplier for playback.</summary>
		public float PlayRate;
		
		/// <summary>If true, the matinee will play when the level is loaded.</summary>
		public bool bPlayOnLevelLoad;
		
		/// <summary>Lets you force the sequence to always start at ForceStartPosition</summary>
		public bool bForceStartPos;
		
		/// <summary>Time position to always start at if bForceStartPos is set to true.</summary>
		public float ForceStartPosition;
		
		/// <summary>
		/// If sequence should pop back to beginning when finished.
		/// Note, if true, will never get Completed/Reversed events - sequence must be explicitly Stopped.
		/// </summary>
		public bool bLooping;
		
		/// <summary>If true, sequence will rewind itself back to the start each time the Play input is activated.</summary>
		public bool bRewindOnPlay;
		
		/// <summary>
		/// If true, when rewinding this interpolation, reset the 'initial positions' of any RelateToInitial movements to the current location.
		/// This allows the next loop of movement to proceed from the current locations.
		/// </summary>
		public bool bNoResetOnRewind;
		
		/// <summary>
		/// Only used if bRewindOnPlay if true. Defines what should happen if the Play input is activated while currently playing.
		/// If true, hitting Play while currently playing will pop the position back to the start and begin playback over again.
		/// If false, hitting Play while currently playing will do nothing.
		/// </summary>
		public bool bRewindIfAlreadyPlaying;
		
		/// <summary>If true, disables the realtime radio effect</summary>
		public bool bDisableRadioFilter;
		
		/// <summary>
		/// Indicates that this interpolation does not affect gameplay. This means that:
		/// -it is not replicated via MatineeActor
		/// -it is not ticked if no affected Actors are visible
		/// -on dedicated servers, it is completely ignored
		/// </summary>
		public bool bClientSideOnly;
		
		/// <summary>if bClientSideOnly is true, whether this matinee should be completely skipped if none of the affected Actors are visible</summary>
		public bool bSkipUpdateIfNotVisible;
		
		/// <summary>Lets you skip the matinee with the CANCELMATINEE exec command. Triggers all events to the end along the way.</summary>
		public bool bIsSkippable;
		
		/// <summary>Preferred local viewport number (when split screen is active) the director track should associate with, or zero for 'all'.</summary>
		public int PreferredSplitScreenNum;
		
		/// <summary>Disable Input from player during play</summary>
		public bool bDisableMovementInput;
		
		/// <summary>Disable LookAt Input from player during play</summary>
		public bool bDisableLookAtInput;
		
		/// <summary>Hide Player Pawn during play</summary>
		public bool bHidePlayer;
		
		/// <summary>Hide HUD during play</summary>
		public bool bHideHud;
		
		/// <summary>Cached value that indicates whether or not gore was enabled when the sequence was started</summary>
		public bool bShouldShowGore;
		
		public UBillboardComponent SpriteComponent;
		
		public bool bIsBeingEdited;
		
		/// <summary>Set by the editor when scrubbing data</summary>
		public bool bIsScrubbing;
		
		/// <summary>properties that may change on InterpAction that we need to notify clients about, since the object's properties will not be replicated</summary>
		public bool bIsPlaying;
		
		public bool bReversePlayback;
		
		public bool bPaused;
		
		/// <summary>The below property is deprecated and will be removed in 4.9.</summary>
		public bool bPendingStop;
		
		public float InterpPosition;
		
		/// <summary>Counter to indicate that play count has changed. Used to work around single frames that go from play-stop-play where bIsPlaying won't get replicated.</summary>
		public byte ReplicationForceIsPlaying;
		
		
	}
	
}
