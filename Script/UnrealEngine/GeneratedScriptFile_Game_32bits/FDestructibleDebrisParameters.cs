#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FDestructibleDebrisParameters
	{
		[FieldOffset(0)]
		public float DebrisLifetimeMin;
		[FieldOffset(4)]
		public float DebrisLifetimeMax;
		[FieldOffset(8)]
		public float DebrisMaxSeparationMin;
		[FieldOffset(12)]
		public float DebrisMaxSeparationMax;
		[FieldOffset(16)]
		public FBox ValidBounds;
		
	}
	
}
#endif
#endif
