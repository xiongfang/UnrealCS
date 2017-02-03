#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FSplineCurves
	{
		/// <summary>Spline built from position data.</summary>
		[FieldOffset(0)]
		public FInterpCurveVector Position;
		/// <summary>Spline built from rotation data.</summary>
		[FieldOffset(24)]
		public FInterpCurveQuat Rotation;
		/// <summary>Spline built from scale data.</summary>
		[FieldOffset(48)]
		public FInterpCurveVector Scale;
		/// <summary>Input: distance along curve, output: parameter that puts you there.</summary>
		[FieldOffset(72)]
		public FInterpCurveFloat ReparamTable;
		
	}
	
}
#endif
#endif
