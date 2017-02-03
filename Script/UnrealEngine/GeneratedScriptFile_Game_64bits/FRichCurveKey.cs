#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FRichCurveKey
	{
		[FieldOffset(0)]
		public ERichCurveInterpMode InterpMode;
		[FieldOffset(1)]
		public ERichCurveTangentMode TangentMode;
		[FieldOffset(2)]
		public ERichCurveTangentWeightMode TangentWeightMode;
		[FieldOffset(4)]
		public float Time;
		[FieldOffset(8)]
		public float Value;
		[FieldOffset(12)]
		public float ArriveTangent;
		[FieldOffset(16)]
		public float ArriveTangentWeight;
		[FieldOffset(20)]
		public float LeaveTangent;
		[FieldOffset(24)]
		public float LeaveTangentWeight;
		
	}
	
}
#endif
#endif
