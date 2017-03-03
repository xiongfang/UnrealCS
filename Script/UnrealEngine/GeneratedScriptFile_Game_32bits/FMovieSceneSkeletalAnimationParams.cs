#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FMovieSceneSkeletalAnimationParams
	{
		[FieldOffset(4)]
		public float StartOffset;
		[FieldOffset(8)]
		public float EndOffset;
		[FieldOffset(12)]
		public float PlayRate;
		public bool bReverse
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(20)]
		public FName SlotName;
		[FieldOffset(28)]
		public FRichCurve Weight;
		
	}
	
}
#endif
#endif
