#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FFOscillator
	{
		[FieldOffset(0)]
		public float Amplitude;
		[FieldOffset(4)]
		public float Frequency;
		[FieldOffset(8)]
		public EInitialOscillatorOffset InitialOffset;
		
	}
	
}
#endif
#endif
