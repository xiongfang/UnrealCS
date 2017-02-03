#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=360)]
	public partial struct FSimulatedRootMotionReplicatedMove
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(8)]
		public FRepRootMotionMontage RootMotion;
		
	}
	
}
#endif
#endif
