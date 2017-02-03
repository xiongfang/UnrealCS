#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FSlotAnimationTrack
	{
		[FieldOffset(0)]
		public FName SlotName;
		[FieldOffset(8)]
		public FAnimTrack AnimTrack;
		
	}
	
}
#endif
#endif
