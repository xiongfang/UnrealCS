#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FInterpCurvePointLinearColor
	{
		[FieldOffset(0)]
		public float InVal;
		[FieldOffset(4)]
		public FLinearColor OutVal;
		[FieldOffset(20)]
		public FLinearColor ArriveTangent;
		[FieldOffset(36)]
		public FLinearColor LeaveTangent;
		[FieldOffset(52)]
		public EInterpCurveMode InterpMode;
		
	}
	
}
#endif
#endif
