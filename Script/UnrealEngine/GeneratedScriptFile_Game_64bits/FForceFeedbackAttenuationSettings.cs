#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=168)]
	public partial struct FForceFeedbackAttenuationSettings
	{
		[FieldOffset(16)]
		public FRuntimeFloatCurve CustomAttenuationCurve;
		[FieldOffset(136)]
		public EAttenuationShape AttenuationShape;
		[FieldOffset(140)]
		public float dBAttenuationAtMax;
		[FieldOffset(144)]
		public FVector AttenuationShapeExtents;
		[FieldOffset(156)]
		public float ConeOffset;
		[FieldOffset(160)]
		public float FalloffDistance;
		
	}
	
}
#endif
#endif
