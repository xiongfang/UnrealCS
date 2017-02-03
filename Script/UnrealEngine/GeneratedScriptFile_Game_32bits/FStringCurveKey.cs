#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FStringCurveKey
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(4)]
		public FString Value;
		
	}
	
}
#endif
#endif
