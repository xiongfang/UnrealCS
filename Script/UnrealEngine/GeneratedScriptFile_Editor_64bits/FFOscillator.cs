#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines oscillation of a single number.</summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FFOscillator
	{
		/// <summary>Amplitude of the sinusoidal oscillation.</summary>
		[FieldOffset(0)]
		public float Amplitude;
		/// <summary>Frequency of the sinusoidal oscillation.</summary>
		[FieldOffset(4)]
		public float Frequency;
		/// <summary>Defines how to begin (either at zero, or at a randomized value.</summary>
		[FieldOffset(8)]
		public EInitialOscillatorOffset InitialOffset;
		
	}
	
}
#endif
#endif
