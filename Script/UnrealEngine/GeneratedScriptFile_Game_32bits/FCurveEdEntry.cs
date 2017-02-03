#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FCurveEdEntry
	{
		[FieldOffset(4)]
		public FColor CurveColor;
		[FieldOffset(8)]
		public FString CurveName;
		[FieldOffset(20)]
		public int bHideCurve;
		[FieldOffset(24)]
		public int bColorCurve;
		[FieldOffset(28)]
		public int bFloatingPointColorCurve;
		[FieldOffset(32)]
		public int bClamp;
		[FieldOffset(36)]
		public float ClampLow;
		[FieldOffset(40)]
		public float ClampHigh;
		
	}
	
}
#endif
#endif
