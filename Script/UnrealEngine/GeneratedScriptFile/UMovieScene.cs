using System;
namespace UnrealEngine
{
	public partial class UMovieScene:UMovieSceneSignedObject
	{
		/// <summary>The camera cut track is a specialized track for switching between cameras on a cinematic</summary>
		public UMovieSceneTrack CameraCutTrack;
		
		/// <summary>User-defined selection range.</summary>
		public FFloatRange SelectionRange;
		
		/// <summary>User-defined playback range for this movie scene. Must be a finite range. Relative to this movie-scene's 0-time origin.</summary>
		public FFloatRange PlaybackRange;
		
		public bool bPlaybackRangeLocked;
		
		public bool bForceFixedFrameIntervalPlayback;
		
		public float FixedFrameInterval;
		
		/// <summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
		public FMovieSceneEditorData EditorData;
		
		public float InTime;
		
		public float OutTime;
		
		public float StartTime;
		
		public float EndTime;
		
		
	}
	
}
