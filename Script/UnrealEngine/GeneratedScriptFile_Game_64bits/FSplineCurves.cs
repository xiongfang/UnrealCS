#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FSplineCurves
	{
		[FieldOffset(0)]
		public FInterpCurveVector Position;
		[FieldOffset(24)]
		public FInterpCurveQuat Rotation;
		[FieldOffset(48)]
		public FInterpCurveVector Scale;
		[FieldOffset(72)]
		public FInterpCurveFloat ReparamTable;
		
	}
	
}
#endif
#endif
