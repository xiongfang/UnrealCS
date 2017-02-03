#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FAnimSegment
	{
		[FieldOffset(8)]
		public float StartPos;
		[FieldOffset(12)]
		public float AnimStartTime;
		[FieldOffset(16)]
		public float AnimEndTime;
		[FieldOffset(20)]
		public float AnimPlayRate;
		[FieldOffset(24)]
		public int LoopingCount;
		
	}
	
}
#endif
#endif
