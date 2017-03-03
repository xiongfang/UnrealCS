#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FMovieSceneCameraAnimSectionData
	{
		[FieldOffset(4)]
		public float PlayRate;
		[FieldOffset(8)]
		public float PlayScale;
		[FieldOffset(12)]
		public float BlendInTime;
		[FieldOffset(16)]
		public float BlendOutTime;
		public bool bLooping
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
