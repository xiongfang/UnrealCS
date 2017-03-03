#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FInterpLookupPoint
	{
		[FieldOffset(0)]
		public FName GroupName;
		[FieldOffset(8)]
		public float Time;
		
	}
	
}
#endif
#endif
