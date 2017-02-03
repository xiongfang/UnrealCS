#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FReplicatedVehicleState
	{
		[FieldOffset(0)]
		public float SteeringInput;
		[FieldOffset(4)]
		public float ThrottleInput;
		[FieldOffset(8)]
		public float BrakeInput;
		[FieldOffset(12)]
		public float HandbrakeInput;
		[FieldOffset(16)]
		public int CurrentGear;
		
	}
	
}
#endif
#endif
