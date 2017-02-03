#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=152)]
	public partial struct FVehicleEngineData
	{
		[FieldOffset(0)]
		public FRuntimeFloatCurve TorqueCurve;
		[FieldOffset(128)]
		public float MaxRPM;
		[FieldOffset(132)]
		public float MOI;
		[FieldOffset(136)]
		public float DampingRateFullThrottle;
		[FieldOffset(140)]
		public float DampingRateZeroThrottleClutchEngaged;
		[FieldOffset(144)]
		public float DampingRateZeroThrottleClutchDisengaged;
		
	}
	
}
#endif
#endif
