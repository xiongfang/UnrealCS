#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>this is anim segment that defines what animation and how *</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FAnimSegment
	{
		/// <summary>Anim Reference to play - only allow AnimSequence or AnimComposite *</summary>
		/// <summary>Start Pos within this AnimCompositeBase</summary>
		[FieldOffset(8)]
		public float StartPos;
		/// <summary>Time to start playing AnimSequence at.</summary>
		[FieldOffset(12)]
		public float AnimStartTime;
		/// <summary>Time to end playing the AnimSequence at.</summary>
		[FieldOffset(16)]
		public float AnimEndTime;
		/// <summary>Playback speed of this animation. If you'd like to reverse, set -1</summary>
		[FieldOffset(20)]
		public float AnimPlayRate;
		[FieldOffset(24)]
		public int LoopingCount;
		
	}
	
}
#endif
#endif
