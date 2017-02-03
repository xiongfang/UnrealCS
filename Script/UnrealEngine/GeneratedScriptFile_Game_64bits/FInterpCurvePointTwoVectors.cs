#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FInterpCurvePointTwoVectors
	{
		[FieldOffset(0)]
		public float InVal;
		[FieldOffset(4)]
		public FTwoVectors OutVal;
		[FieldOffset(28)]
		public FTwoVectors ArriveTangent;
		[FieldOffset(52)]
		public FTwoVectors LeaveTangent;
		[FieldOffset(76)]
		public EInterpCurveMode InterpMode;
		
	}
	
}
#endif
#endif
