using System;
namespace UnrealEngine
{
	/// <summary>Structure storing Data for pre-computation</summary>
	public partial struct FAtmospherePrecomputeParameters
	{
		/// <summary>Rayleigh scattering density height scale, ranges from [0...1]</summary>
		public float DensityHeight;
		public float DecayHeight;
		/// <summary>Maximum scattering order</summary>
		public int MaxScatteringOrder;
		/// <summary>Transmittance Texture Width</summary>
		public int TransmittanceTexWidth;
		/// <summary>Transmittance Texture Height</summary>
		public int TransmittanceTexHeight;
		/// <summary>Irradiance Texture Width</summary>
		public int IrradianceTexWidth;
		/// <summary>Irradiance Texture Height</summary>
		public int IrradianceTexHeight;
		/// <summary>Number of different altitudes at which to sample inscatter color (size of 3D texture Z dimension)</summary>
		public int InscatterAltitudeSampleNum;
		/// <summary>Inscatter Texture Height</summary>
		public int InscatterMuNum;
		/// <summary>Inscatter Texture Width</summary>
		public int InscatterMuSNum;
		/// <summary>Inscatter Texture Width</summary>
		public int InscatterNuNum;
		
	}
	
}
