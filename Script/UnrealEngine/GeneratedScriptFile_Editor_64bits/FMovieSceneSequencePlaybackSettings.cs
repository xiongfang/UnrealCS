#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Settings for the level sequence player actor.</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FMovieSceneSequencePlaybackSettings
	{
		/// <summary>Number of times to loop playback. -1 for infinite, else the number of times to loop before stopping</summary>
		[FieldOffset(0)]
		public int LoopCount;
		/// <summary>The rate at which to playback the animation</summary>
		[FieldOffset(4)]
		public float PlayRate;
		/// <summary>Start playback at a random time</summary>
		public bool bRandomStartTime
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Start playback at the specified time</summary>
		[FieldOffset(12)]
		public float StartTime;
		/// <summary>Flag used to specify whether actor states should be restored on stop</summary>
		public bool bRestoreState
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
