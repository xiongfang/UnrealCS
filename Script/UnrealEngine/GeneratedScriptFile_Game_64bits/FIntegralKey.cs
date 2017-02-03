#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FIntegralKey
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(4)]
		public int Value;
		
	}
	
}
#endif
#endif
