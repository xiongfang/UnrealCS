#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FAnimSegment
	{
		[FieldOffset(4)]
		public float StartPos;
		[FieldOffset(8)]
		public float AnimStartTime;
		[FieldOffset(12)]
		public float AnimEndTime;
		[FieldOffset(16)]
		public float AnimPlayRate;
		[FieldOffset(20)]
		public int LoopingCount;
		
	}
	
}
#endif
#endif
