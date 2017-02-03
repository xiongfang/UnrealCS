#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FDestructibleAdvancedParameters
	{
		[FieldOffset(0)]
		public float DamageCap;
		[FieldOffset(4)]
		public float ImpactVelocityThreshold;
		[FieldOffset(8)]
		public float MaxChunkSpeed;
		[FieldOffset(12)]
		public float FractureImpulseScale;
		
	}
	
}
#endif
#endif
