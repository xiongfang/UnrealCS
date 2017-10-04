using System;
namespace UnrealEngine
{
	public partial class UParticleModuleBeamNoise:UParticleModuleBeamBase
	{
		/// <summary>Is low frequency noise enabled.</summary>
		public bool bLowFreq_Enabled;
		
		/// <summary>The frequency of noise points.</summary>
		public int Frequency;
		
		/// <summary>
		/// If not 0, then the frequency will select a random value in the range
		///         [Frequency_LowRange..Frequency]
		/// </summary>
		public int Frequency_LowRange;
		
		/// <summary>The noise point ranges.</summary>
		public FRawDistributionVector NoiseRange;
		
		/// <summary>A scale factor that will be applied to the noise range.</summary>
		public FRawDistributionFloat NoiseRangeScale;
		
		/// <summary>
		/// If true,  the NoiseRangeScale will be grabbed based on the emitter time.
		/// If false, the NoiseRangeScale will be grabbed based on the particle time.
		/// </summary>
		public bool bNRScaleEmitterTime;
		
		/// <summary>The speed with which to move each noise point.</summary>
		public FRawDistributionVector NoiseSpeed;
		
		/// <summary>Whether the noise movement should be smooth or 'jerky'.</summary>
		public bool bSmooth;
		
		/// <summary>Default target-point information to use if the beam method is endpoint.</summary>
		public float NoiseLockRadius;
		
		/// <summary>INTERNAL - Whether the noise points should be locked.</summary>
		public bool bNoiseLock;
		
		/// <summary>Whether the noise points should be oscillate.</summary>
		public bool bOscillate;
		
		/// <summary>How long the  noise points should be locked - 0.0 indicates forever.</summary>
		public float NoiseLockTime;
		
		/// <summary>The tension to apply to the tessellated noise line.</summary>
		public float NoiseTension;
		
		/// <summary>If true, calculate tangents at each noise point.</summary>
		public bool bUseNoiseTangents;
		
		/// <summary>The strength of noise tangents, if enabled.</summary>
		public FRawDistributionFloat NoiseTangentStrength;
		
		/// <summary>The amount of tessellation between noise points.</summary>
		public int NoiseTessellation;
		
		/// <summary>
		/// Whether to apply noise to the target point (or end of line in distance mode...)
		/// If true, the beam could potentially 'leave' the target...
		/// </summary>
		public bool bTargetNoise;
		
		/// <summary>
		/// The distance at which to deposit noise points.
		/// If 0.0, then use the static frequency value.
		/// If not, distribute noise points at the given distance, up to the static Frequency value.
		/// At that point, evenly distribute them along the beam.
		/// </summary>
		public float FrequencyDistance;
		
		/// <summary>If true, apply the noise scale to the beam.</summary>
		public bool bApplyNoiseScale;
		
		/// <summary>
		/// The scale factor to apply to noise range.
		/// The lookup value is determined by dividing the number of noise points present by the
		/// maximum number of noise points (Frequency).
		/// </summary>
		public FRawDistributionFloat NoiseScale;
		
		
	}
	
}
