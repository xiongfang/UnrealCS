#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure used for holding information for one animation played on the Anim Control track.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FAnimControlTrackKey
	{
		/// <summary>Position in the Matinee sequence to start playing this animation.</summary>
		[FieldOffset(0)]
		public float StartTime;
		/// <summary>Animation Sequence to play</summary>
		/// <summary>Time to start playing AnimSequence at.</summary>
		[FieldOffset(16)]
		public float AnimStartOffset;
		/// <summary>Time to end playing the AnimSequence at.</summary>
		[FieldOffset(20)]
		public float AnimEndOffset;
		/// <summary>Playback speed of this animation.</summary>
		[FieldOffset(24)]
		public float AnimPlayRate;
		/// <summary>Should this animation loop.</summary>
		public bool bLooping
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Whether to play the animation in reverse or not.</summary>
		public bool bReverse
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
