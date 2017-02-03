#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=360)]
	public partial struct FSimulatedRootMotionReplicatedMove
	{
		/// <summary>Local time when move was received on client and saved.</summary>
		[FieldOffset(0)]
		public float Time;
		/// <summary>Root Motion information</summary>
		[FieldOffset(8)]
		public FRepRootMotionMontage RootMotion;
		
	}
	
}
#endif
#endif
