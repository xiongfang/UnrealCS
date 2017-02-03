#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FInterpCurvePointVector
	{
		[FieldOffset(0)]
		public float InVal;
		[FieldOffset(4)]
		public FVector OutVal;
		[FieldOffset(16)]
		public FVector ArriveTangent;
		[FieldOffset(28)]
		public FVector LeaveTangent;
		[FieldOffset(40)]
		public EInterpCurveMode InterpMode;
		
	}
	
}
#endif
#endif
