using System;
namespace UnrealEngine
{
	/// <summary>Structure used for holding information for one animation played on the Anim Control track.</summary>
	public partial struct FAnimControlTrackKey
	{
		/// <summary>Position in the Matinee sequence to start playing this animation.</summary>
		public float StartTime;
		/// <summary>Animation Sequence to play</summary>
		public UAnimSequence AnimSeq;
		/// <summary>Time to start playing AnimSequence at.</summary>
		public float AnimStartOffset;
		/// <summary>Time to end playing the AnimSequence at.</summary>
		public float AnimEndOffset;
		/// <summary>Playback speed of this animation.</summary>
		public float AnimPlayRate;
		/// <summary>Should this animation loop.</summary>
		public bool bLooping;
		/// <summary>Whether to play the animation in reverse or not.</summary>
		public bool bReverse;
		
	}
	
}
