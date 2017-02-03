#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure storing Data for pre-computation</summary>
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FAtmospherePrecomputeParameters
	{
		/// <summary>Rayleigh scattering density height scale, ranges from [0...1]</summary>
		[FieldOffset(0)]
		public float DensityHeight;
		[FieldOffset(4)]
		public float DecayHeight;
		/// <summary>Maximum scattering order</summary>
		[FieldOffset(8)]
		public int MaxScatteringOrder;
		/// <summary>Transmittance Texture Width</summary>
		[FieldOffset(12)]
		public int TransmittanceTexWidth;
		/// <summary>Transmittance Texture Height</summary>
		[FieldOffset(16)]
		public int TransmittanceTexHeight;
		/// <summary>Irradiance Texture Width</summary>
		[FieldOffset(20)]
		public int IrradianceTexWidth;
		/// <summary>Irradiance Texture Height</summary>
		[FieldOffset(24)]
		public int IrradianceTexHeight;
		/// <summary>Number of different altitudes at which to sample inscatter color (size of 3D texture Z dimension)</summary>
		[FieldOffset(28)]
		public int InscatterAltitudeSampleNum;
		/// <summary>Inscatter Texture Height</summary>
		[FieldOffset(32)]
		public int InscatterMuNum;
		/// <summary>Inscatter Texture Width</summary>
		[FieldOffset(36)]
		public int InscatterMuSNum;
		/// <summary>Inscatter Texture Width</summary>
		[FieldOffset(40)]
		public int InscatterNuNum;
		
	}
	
}
#endif
#endif
