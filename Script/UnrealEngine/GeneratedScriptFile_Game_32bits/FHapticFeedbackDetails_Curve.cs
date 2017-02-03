#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=176)]
	public partial struct FHapticFeedbackDetails_Curve
	{
		[FieldOffset(0)]
		public FRuntimeFloatCurve Frequency;
		[FieldOffset(88)]
		public FRuntimeFloatCurve Amplitude;
		
	}
	
}
#endif
#endif
