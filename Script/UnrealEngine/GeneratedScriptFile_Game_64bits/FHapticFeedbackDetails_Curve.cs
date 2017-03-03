#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=240)]
	public partial struct FHapticFeedbackDetails_Curve
	{
		[FieldOffset(0)]
		public FRuntimeFloatCurve Frequency;
		[FieldOffset(120)]
		public FRuntimeFloatCurve Amplitude;
		
	}
	
}
#endif
#endif
