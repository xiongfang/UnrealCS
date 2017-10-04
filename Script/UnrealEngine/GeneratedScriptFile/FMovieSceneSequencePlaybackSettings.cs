using System;
namespace UnrealEngine
{
	/// <summary>Settings for the level sequence player actor.</summary>
	public partial struct FMovieSceneSequencePlaybackSettings
	{
		/// <summary>Number of times to loop playback. -1 for infinite, else the number of times to loop before stopping</summary>
		public int LoopCount;
		/// <summary>The rate at which to playback the animation</summary>
		public float PlayRate;
		/// <summary>Start playback at a random time</summary>
		public bool bRandomStartTime;
		/// <summary>Start playback at the specified time</summary>
		public float StartTime;
		/// <summary>Flag used to specify whether actor states should be restored on stop</summary>
		public bool bRestoreState;
		
	}
	
}
