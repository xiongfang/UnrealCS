using System;
namespace UnrealEngine
{
	public partial struct FTimeline
	{
		/// <summary>Specified how the timeline determines its own length (e.g. specified length, last keyframe)</summary>
		public ETimelineLengthMode LengthMode;
		/// <summary>How long the timeline is, will stop or loop at the end</summary>
		public float Length;
		/// <summary>Whether timeline should loop when it reaches the end, or stop</summary>
		public bool bLooping;
		/// <summary>If playback should move the current position backwards instead of forwards</summary>
		public bool bReversePlayback;
		/// <summary>Are we currently playing (moving Position)</summary>
		public bool bPlaying;
		/// <summary>How fast we should play through the timeline</summary>
		public float PlayRate;
		/// <summary>Current position in the timeline</summary>
		public float Position;
		/// <summary>Optional. If set, Timeline will also set ETimelineDirection property on PropertySetObject using the name.</summary>
		public FName DirectionPropertyName;
		/// <summary>Cached property pointer for setting timeline direction</summary>
		public UProperty DirectionProperty;
		
	}
	
}
