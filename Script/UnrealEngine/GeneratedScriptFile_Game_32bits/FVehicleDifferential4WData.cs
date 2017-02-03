#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FVehicleDifferential4WData
	{
		[FieldOffset(0)]
		public EVehicleDifferential4W DifferentialType;
		[FieldOffset(4)]
		public float FrontRearSplit;
		[FieldOffset(8)]
		public float FrontLeftRightSplit;
		[FieldOffset(12)]
		public float RearLeftRightSplit;
		[FieldOffset(16)]
		public float CentreBias;
		[FieldOffset(20)]
		public float FrontBias;
		[FieldOffset(24)]
		public float RearBias;
		
	}
	
}
#endif
#endif
