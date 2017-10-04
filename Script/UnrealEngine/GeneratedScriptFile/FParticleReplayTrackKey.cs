using System;
namespace UnrealEngine
{
	/// <summary>Data for a single key in this track</summary>
	public partial struct FParticleReplayTrackKey
	{
		/// <summary>Position along timeline</summary>
		public float Time;
		/// <summary>Time length this clip should be captured/played for</summary>
		public float Duration;
		/// <summary>Replay clip ID number that identifies the clip we should capture to or playback from</summary>
		public int ClipIDNumber;
		
	}
	
}
