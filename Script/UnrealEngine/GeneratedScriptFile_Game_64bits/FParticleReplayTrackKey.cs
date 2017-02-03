#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FParticleReplayTrackKey
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(4)]
		public float Duration;
		[FieldOffset(8)]
		public int ClipIDNumber;
		
	}
	
}
#endif
#endif
