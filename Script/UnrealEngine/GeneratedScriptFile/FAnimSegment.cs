using System;
namespace UnrealEngine
{
	/// <summary>this is anim segment that defines what animation and how *</summary>
	public partial struct FAnimSegment
	{
		/// <summary>Anim Reference to play - only allow AnimSequence or AnimComposite *</summary>
		public UAnimSequenceBase AnimReference;
		/// <summary>Start Pos within this AnimCompositeBase</summary>
		public float StartPos;
		/// <summary>Time to start playing AnimSequence at.</summary>
		public float AnimStartTime;
		/// <summary>Time to end playing the AnimSequence at.</summary>
		public float AnimEndTime;
		/// <summary>Playback speed of this animation. If you'd like to reverse, set -1</summary>
		public float AnimPlayRate;
		public int LoopingCount;
		
	}
	
}
