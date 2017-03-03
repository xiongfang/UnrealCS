#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FMovieSceneCameraAnimSectionData
	{
		/// <summary>The camera anim to play</summary>
		/// <summary>How fast to play back the animation.</summary>
		[FieldOffset(8)]
		public float PlayRate;
		/// <summary>Scalar to control intensity of the animation.</summary>
		[FieldOffset(12)]
		public float PlayScale;
		[FieldOffset(16)]
		public float BlendInTime;
		[FieldOffset(20)]
		public float BlendOutTime;
		public bool bLooping
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
