#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FMovieSceneSequencePlaybackSettings
	{
		[FieldOffset(0)]
		public int LoopCount;
		[FieldOffset(4)]
		public float PlayRate;
		public bool bRandomStartTime
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(12)]
		public float StartTime;
		public bool bRestoreState
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
