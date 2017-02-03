#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=108)]
	public partial struct FVehicleEngineData
	{
		[FieldOffset(0)]
		public FRuntimeFloatCurve TorqueCurve;
		[FieldOffset(88)]
		public float MaxRPM;
		[FieldOffset(92)]
		public float MOI;
		[FieldOffset(96)]
		public float DampingRateFullThrottle;
		[FieldOffset(100)]
		public float DampingRateZeroThrottleClutchEngaged;
		[FieldOffset(104)]
		public float DampingRateZeroThrottleClutchDisengaged;
		
	}
	
}
#endif
#endif
