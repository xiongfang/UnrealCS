#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=124)]
	public partial struct FForceFeedbackAttenuationSettings
	{
		[FieldOffset(8)]
		public FRuntimeFloatCurve CustomAttenuationCurve;
		[FieldOffset(96)]
		public EAttenuationShape AttenuationShape;
		[FieldOffset(100)]
		public float dBAttenuationAtMax;
		[FieldOffset(104)]
		public FVector AttenuationShapeExtents;
		[FieldOffset(116)]
		public float ConeOffset;
		[FieldOffset(120)]
		public float FalloffDistance;
		
	}
	
}
#endif
#endif
