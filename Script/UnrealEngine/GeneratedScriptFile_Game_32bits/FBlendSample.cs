#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FBlendSample
	{
		[FieldOffset(4)]
		public FVector SampleValue;
		[FieldOffset(16)]
		public float RateScale;
		
	}
	
}
#endif
#endif
