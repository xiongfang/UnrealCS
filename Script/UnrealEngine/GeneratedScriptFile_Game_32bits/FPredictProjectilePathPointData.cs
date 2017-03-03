#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FPredictProjectilePathPointData
	{
		[FieldOffset(0)]
		public FVector Location;
		[FieldOffset(12)]
		public FVector Velocity;
		[FieldOffset(24)]
		public float Time;
		
	}
	
}
#endif
#endif
