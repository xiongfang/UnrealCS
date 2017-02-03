#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FDistanceDatum
	{
		[FieldOffset(0)]
		public float FadeInDistanceStart;
		[FieldOffset(4)]
		public float FadeInDistanceEnd;
		[FieldOffset(8)]
		public float FadeOutDistanceStart;
		[FieldOffset(12)]
		public float FadeOutDistanceEnd;
		[FieldOffset(16)]
		public float Volume;
		
	}
	
}
#endif
#endif
