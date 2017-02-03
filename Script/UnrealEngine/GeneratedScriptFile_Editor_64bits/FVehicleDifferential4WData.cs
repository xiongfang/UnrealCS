#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FVehicleDifferential4WData
	{
		/// <summary>Type of differential</summary>
		[FieldOffset(0)]
		public EVehicleDifferential4W DifferentialType;
		/// <summary>Ratio of torque split between front and rear (>0.5 means more to front, <0.5 means more to rear, works only with 4W type)</summary>
		[FieldOffset(4)]
		public float FrontRearSplit;
		/// <summary>Ratio of torque split between front-left and front-right (>0.5 means more to front-left, <0.5 means more to front-right, works only with 4W and LimitedSlip_FrontDrive)</summary>
		[FieldOffset(8)]
		public float FrontLeftRightSplit;
		/// <summary>Ratio of torque split between rear-left and rear-right (>0.5 means more to rear-left, <0.5 means more to rear-right, works only with 4W and LimitedSlip_RearDrive)</summary>
		[FieldOffset(12)]
		public float RearLeftRightSplit;
		/// <summary>Maximum allowed ratio of average front wheel rotation speed and rear wheel rotation speeds (range: 1..inf, works only with LimitedSlip_4W)</summary>
		[FieldOffset(16)]
		public float CentreBias;
		/// <summary>Maximum allowed ratio of front-left and front-right wheel rotation speeds (range: 1..inf, works only with LimitedSlip_4W, LimitedSlip_FrontDrive)</summary>
		[FieldOffset(20)]
		public float FrontBias;
		/// <summary>Maximum allowed ratio of rear-left and rear-right wheel rotation speeds (range: 1..inf, works only with LimitedSlip_4W, LimitedSlip_FrontDrive)</summary>
		[FieldOffset(24)]
		public float RearBias;
		
	}
	
}
#endif
#endif
