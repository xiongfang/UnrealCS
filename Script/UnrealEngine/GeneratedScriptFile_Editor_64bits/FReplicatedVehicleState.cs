#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FReplicatedVehicleState
	{
		/// <summary>input replication: steering</summary>
		[FieldOffset(0)]
		public float SteeringInput;
		/// <summary>input replication: throttle</summary>
		[FieldOffset(4)]
		public float ThrottleInput;
		/// <summary>input replication: brake</summary>
		[FieldOffset(8)]
		public float BrakeInput;
		/// <summary>input replication: handbrake</summary>
		[FieldOffset(12)]
		public float HandbrakeInput;
		/// <summary>state replication: current gear</summary>
		[FieldOffset(16)]
		public int CurrentGear;
		
	}
	
}
#endif
#endif
