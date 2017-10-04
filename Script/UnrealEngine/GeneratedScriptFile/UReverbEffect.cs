using System;
namespace UnrealEngine
{
	public partial class UReverbEffect:UObject
	{
		/// <summary>Density - 0.0 < 1.0 < 1.0 - Coloration of the late reverb - lower value is more grainy</summary>
		public float Density;
		
		/// <summary>Diffusion - 0.0 < 1.0 < 1.0 - Echo density in the reverberation decay - lower is more grainy</summary>
		public float Diffusion;
		
		/// <summary>Reverb Gain - 0.0 < 0.32 < 1.0 - overall reverb gain - master volume control</summary>
		public float Gain;
		
		/// <summary>Reverb Gain High Frequency - 0.0 < 0.89 < 1.0 - attenuates the high frequency reflected sound</summary>
		public float GainHF;
		
		/// <summary>Decay Time - 0.1 < 1.49 < 20.0 Seconds - larger is more reverb</summary>
		public float DecayTime;
		
		/// <summary>Decay High Frequency Ratio - 0.1 < 0.83 < 2.0 - how much the quicker or slower the high frequencies decay relative to the lower frequencies.</summary>
		public float DecayHFRatio;
		
		/// <summary>Reflections Gain - 0.0 < 0.05 < 3.16 - controls the amount of initial reflections</summary>
		public float ReflectionsGain;
		
		/// <summary>Reflections Delay - 0.0 < 0.007 < 0.3 Seconds - the time between the listener receiving the direct path sound and the first reflection</summary>
		public float ReflectionsDelay;
		
		/// <summary>Late Reverb Gain - 0.0 < 1.26 < 10.0 - gain of the late reverb</summary>
		public float LateGain;
		
		/// <summary>Late Reverb Delay - 0.0 < 0.011 < 0.1 Seconds - time difference between late reverb and first reflections</summary>
		public float LateDelay;
		
		/// <summary>Air Absorption - 0.0 < 0.994 < 1.0 - lower value means more absorption</summary>
		public float AirAbsorptionGainHF;
		
		/// <summary>Room Rolloff - 0.0 < 0.0 < 10.0 - multiplies the attenuation due to distance</summary>
		public float RoomRolloffFactor;
		
		/// <summary>Transient property used to trigger real-time updates of the reverb for real-time editor previewing</summary>
		public bool bChanged;
		
		
	}
	
}
