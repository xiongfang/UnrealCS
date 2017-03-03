#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FMovieSceneSkeletalAnimationParams
	{
		[FieldOffset(8)]
		public float StartOffset;
		[FieldOffset(12)]
		public float EndOffset;
		[FieldOffset(16)]
		public float PlayRate;
		public bool bReverse
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(24)]
		public FName SlotName;
		[FieldOffset(32)]
		public FRichCurve Weight;
		
	}
	
}
#endif
#endif
