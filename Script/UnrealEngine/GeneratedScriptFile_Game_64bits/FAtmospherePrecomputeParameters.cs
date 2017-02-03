#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FAtmospherePrecomputeParameters
	{
		[FieldOffset(0)]
		public float DensityHeight;
		[FieldOffset(4)]
		public float DecayHeight;
		[FieldOffset(8)]
		public int MaxScatteringOrder;
		[FieldOffset(12)]
		public int TransmittanceTexWidth;
		[FieldOffset(16)]
		public int TransmittanceTexHeight;
		[FieldOffset(20)]
		public int IrradianceTexWidth;
		[FieldOffset(24)]
		public int IrradianceTexHeight;
		[FieldOffset(28)]
		public int InscatterAltitudeSampleNum;
		[FieldOffset(32)]
		public int InscatterMuNum;
		[FieldOffset(36)]
		public int InscatterMuSNum;
		[FieldOffset(40)]
		public int InscatterNuNum;
		
	}
	
}
#endif
#endif
