#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMargin
	{
		[FieldOffset(0)]
		public float Left;
		[FieldOffset(4)]
		public float Top;
		[FieldOffset(8)]
		public float Right;
		[FieldOffset(12)]
		public float Bottom;
		
	}
	
}
#endif
#endif
