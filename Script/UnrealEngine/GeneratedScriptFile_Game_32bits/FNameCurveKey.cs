#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FNameCurveKey
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(4)]
		public FName Value;
		
	}
	
}
#endif
#endif
