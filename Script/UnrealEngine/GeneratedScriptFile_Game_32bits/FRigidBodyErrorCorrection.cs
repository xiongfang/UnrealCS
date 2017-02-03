#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FRigidBodyErrorCorrection
	{
		[FieldOffset(0)]
		public float LinearDeltaThresholdSq;
		[FieldOffset(4)]
		public float LinearInterpAlpha;
		[FieldOffset(8)]
		public float LinearRecipFixTime;
		[FieldOffset(12)]
		public float AngularDeltaThreshold;
		[FieldOffset(16)]
		public float AngularInterpAlpha;
		[FieldOffset(20)]
		public float AngularRecipFixTime;
		[FieldOffset(24)]
		public float BodySpeedThresholdSq;
		
	}
	
}
#endif
#endif
