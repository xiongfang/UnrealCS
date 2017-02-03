#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FSplineCurves
	{
		[FieldOffset(0)]
		public FInterpCurveVector Position;
		[FieldOffset(20)]
		public FInterpCurveQuat Rotation;
		[FieldOffset(40)]
		public FInterpCurveVector Scale;
		[FieldOffset(60)]
		public FInterpCurveFloat ReparamTable;
		
	}
	
}
#endif
#endif
