using System;
namespace UnrealEngine
{
	/// <summary>Defines oscillation of a single number.</summary>
	public partial struct FFOscillator
	{
		/// <summary>Amplitude of the sinusoidal oscillation.</summary>
		public float Amplitude;
		/// <summary>Frequency of the sinusoidal oscillation.</summary>
		public float Frequency;
		/// <summary>Defines how to begin (either at zero, or at a randomized value.</summary>
		public EInitialOscillatorOffset InitialOffset;
		
	}
	
}
