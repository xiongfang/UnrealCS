#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Information about a particule curve being viewed.
	/// Property could be an FInterpCurve, a DistributionFloat or a DistributionVector
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FCurveEdEntry
	{
		[FieldOffset(8)]
		public FColor CurveColor;
		[FieldOffset(16)]
		public FString CurveName;
		[FieldOffset(32)]
		public int bHideCurve;
		[FieldOffset(36)]
		public int bColorCurve;
		[FieldOffset(40)]
		public int bFloatingPointColorCurve;
		[FieldOffset(44)]
		public int bClamp;
		[FieldOffset(48)]
		public float ClampLow;
		[FieldOffset(52)]
		public float ClampHigh;
		
	}
	
}
#endif
#endif
