#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FInterpCurvePointVector2D
	{
		[FieldOffset(0)]
		public float InVal;
		[FieldOffset(4)]
		public FVector2D OutVal;
		[FieldOffset(12)]
		public FVector2D ArriveTangent;
		[FieldOffset(20)]
		public FVector2D LeaveTangent;
		[FieldOffset(28)]
		public EInterpCurveMode InterpMode;
		
	}
	
}
#endif
#endif
