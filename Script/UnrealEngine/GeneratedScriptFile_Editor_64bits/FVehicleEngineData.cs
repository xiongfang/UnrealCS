#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=152)]
	public partial struct FVehicleEngineData
	{
		/// <summary>Torque (Nm) at a given RPM</summary>
		[FieldOffset(0)]
		public FRuntimeFloatCurve TorqueCurve;
		/// <summary>Maximum revolutions per minute of the engine</summary>
		[FieldOffset(128)]
		public float MaxRPM;
		/// <summary>Moment of inertia of the engine around the axis of rotation (Kgm^2).</summary>
		[FieldOffset(132)]
		public float MOI;
		/// <summary>Damping rate of engine when full throttle is applied (Kgm^2/s)</summary>
		[FieldOffset(136)]
		public float DampingRateFullThrottle;
		/// <summary>Damping rate of engine in at zero throttle when the clutch is engaged (Kgm^2/s)</summary>
		[FieldOffset(140)]
		public float DampingRateZeroThrottleClutchEngaged;
		/// <summary>Damping rate of engine in at zero throttle when the clutch is disengaged (in neutral gear) (Kgm^2/s)</summary>
		[FieldOffset(144)]
		public float DampingRateZeroThrottleClutchDisengaged;
		
	}
	
}
#endif
#endif
