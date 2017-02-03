#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FInterpCurvePointQuat
	{
		[FieldOffset(0)]
		public float InVal;
		[FieldOffset(16)]
		public FQuat OutVal;
		[FieldOffset(32)]
		public FQuat ArriveTangent;
		[FieldOffset(48)]
		public FQuat LeaveTangent;
		[FieldOffset(64)]
		public EInterpCurveMode InterpMode;
		
	}
	
}
#endif
#endif
