#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FInterpCurvePointFloat
	{
		[FieldOffset(0)]
		public float InVal;
		[FieldOffset(4)]
		public float OutVal;
		[FieldOffset(8)]
		public float ArriveTangent;
		[FieldOffset(12)]
		public float LeaveTangent;
		[FieldOffset(16)]
		public EInterpCurveMode InterpMode;
		
	}
	
}
#endif
#endif
