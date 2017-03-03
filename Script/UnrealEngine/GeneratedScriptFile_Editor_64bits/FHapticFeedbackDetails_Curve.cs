#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=240)]
	public partial struct FHapticFeedbackDetails_Curve
	{
		/// <summary>The frequency to vibrate the haptic device at.  Frequency ranges vary by device!</summary>
		[FieldOffset(0)]
		public FRuntimeFloatCurve Frequency;
		/// <summary>The amplitude to vibrate the haptic device at.  Amplitudes are normalized over the range [0.0, 1.0], with 1.0 being the max setting of the device</summary>
		[FieldOffset(120)]
		public FRuntimeFloatCurve Amplitude;
		
	}
	
}
#endif
#endif
